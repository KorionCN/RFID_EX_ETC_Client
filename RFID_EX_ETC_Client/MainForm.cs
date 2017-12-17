using RFID_EX_ETC_Client.Model.Enitys;
using RFID_EX_ETC_Client.Service;
using RFID_EX_ETC_Client.Utils;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace RFID_EX_ETC_Client {
    public partial class MainForm : Form {

        private SerialPort serialPort;
        private MainService service;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            service = new MainService();
            InitView();
        }

        private void InitView() {
            this.Text = GlobalVar.APP_NAME;
            //获取所有串口设备
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) {
                cb_ComNum.Items.Add(port);
            }
            if (ports.Length <= 0) {
                //若没有串口设备，弹出提示，退出程序
                MessageBox.Show("没有发现任何串口设备", "错误");
                System.Environment.Exit(0);
            }
            //设置默认串口
            cb_ComNum.SelectedIndex = 0;
            //初始化默认串口 
            InitSerialPort();
            ShowSerialPortInfo();
        }

        private void InitSerialPort() {
            string defaultCom = cb_ComNum.SelectedItem.ToString();
            LogUtil.WriteLine("默认串口号:" + defaultCom);
            //初始化串口对象

            serialPort = new SerialPort(defaultCom);
            serialPort.ReadTimeout = 500;
            //注册串口监听事件
            serialPort.DataReceived += new SerialDataReceivedEventHandler(ComDataReceived);
        }

        /**
         * 业务逻辑回调
         * ***************************************************************************************/

        //阅读器接收到数据时，回调此函数
        private void ComDataReceived(object sender, SerialDataReceivedEventArgs e) {

            StringBuilder sb = new StringBuilder("");
            //读取来自阅读器的数据
            int data = serialPort.ReadByte();
            while (data != -1) {
                sb.Append(data.ToString("X2"));
                try {
                    data = serialPort.ReadByte();
                } catch {
                    //超时结束读取
                    break;
                }
            }
            string result = sb.ToString();
            LogUtil.WriteLine("接收到数据:" + result);
            //更新车辆标签ID
            SetTagID2UI(result);
            service.TagId = result;
            //获取车辆信息
            service.GetCarInfo(result, GetCarInfoDele);

        }

        private void GetCarInfoDele(bool isSuccess, string message, CarInfo carInfo) {
            if (isSuccess) {
                ShowCarInfo(carInfo);
                service.GetRouteInfo(carInfo.TagId, GetRouteInfoDele);
            } else {
                ShowMessageBox(message);
            }
        }

        private void GetRouteInfoDele(bool isSuccess, string message, RouteInfo routeInfo) {
            if (isSuccess) {
                ShowRouteInfo(routeInfo);
            } else {
                ShowMessageBox(message);
            }
        }

        /**
         * UI更新显示
         * **********************************************************************************/
        

        private delegate void SetBtnComStateTextDelegate(bool isOpen);
        private void SetBtnComStateText(bool isOpen) {
            if (btn_ComState.InvokeRequired) {
                this.Invoke(new SetBtnComStateTextDelegate(SetBtnComStateText), isOpen);
            } else {
                if (isOpen) {
                    btn_ComState.Text = "Open";
                    btn_ComState.BackColor = Color.Lime;
                } else {
                    btn_ComState.Text = "Close";
                    btn_ComState.BackColor = Color.Red;
                }
            }
        }

        private delegate void SetTagID2UIDelegate(string result);
        private void SetTagID2UI(string result) {
            if (tb_CarTagID.InvokeRequired) {
                SetTagID2UIDelegate dele = new SetTagID2UIDelegate(SetTagID2UI);
                this.Invoke(dele, result);
            } else {
                tb_CarTagID.Text = result;
            }
        }

        private delegate void ShoaCarInfoDelegate(CarInfo carInfo);
        private void ShowCarInfo(CarInfo carInfo) {
            if (tb_CarInfo.InvokeRequired) {
                this.Invoke(new ShoaCarInfoDelegate(ShowCarInfo), carInfo);
            } else {
                tb_CarInfo.Text = "";
                tb_CarInfo.AppendText("车牌号:" + carInfo.PlateNum + "\r\n");
                tb_CarInfo.AppendText("车型:" + carInfo.Type + "\r\n");
                tb_CarInfo.AppendText("发动机号:" + carInfo.EngineNum + "\r\n");
            }
        }

        private delegate void ShowRouteInfoDelegate(RouteInfo routeInfo);
        private void ShowRouteInfo(RouteInfo routeInfo) {
            if (tb_Start.InvokeRequired) {
                this.Invoke(new ShowRouteInfoDelegate(ShowRouteInfo), routeInfo);
            } else {
                tb_Start.Text = routeInfo.StartStat;
                tb_StartTime.Text = SimpleUtils.TimeStamp2DateTime(routeInfo.StartTime).ToString();
                tb_End.Text = routeInfo.EndStat;
                tb_EndTime.Text = SimpleUtils.TimeStamp2DateTime(routeInfo.EndTime).ToString();
                tb_Distance.Text = routeInfo.Distance.ToString("F2");
                int type = service.CarInfo.Type;
                double unitCost = service.TollDict[type].UnitCost;
                double cost = routeInfo.Distance * unitCost;
                tb_UnitCost.Text = unitCost.ToString("F2");
                tb_Total.Text = cost.ToString("F2");
            }
        }

        private delegate void ShowMessageBoxDelegate(string msg);
        private void ShowMessageBox(string msg) {
            if (this.InvokeRequired) {
                this.Invoke(new ShowMessageBoxDelegate(ShowMessageBox), msg);
            } else {
                MessageBox.Show(msg, "提示");
            }
        }

        //更新串口信息
        private void ShowSerialPortInfo() {
            if (serialPort == null) return;
            LogUtil.WriteLine("串口输入缓冲区大小:" + serialPort.ReadBufferSize + "byte");
            LogUtil.WriteLine("串口名:" + serialPort.PortName);
            LogUtil.WriteLine("校验位:" + serialPort.Parity);
            LogUtil.WriteLine("停止位:" + serialPort.StopBits);
            LogUtil.WriteLine("数据位值:" + serialPort.DataBits);
            LogUtil.WriteLine("波特率:" + serialPort.BaudRate);

            //显示串口参数信息
            tb_BaudRate.Text = serialPort.BaudRate.ToString();
            tb_DataBits.Text = serialPort.DataBits.ToString();
            tb_Parity.Text = serialPort.Parity.ToString();
            tb_StopBits.Text = serialPort.StopBits.ToString();
            SetBtnComStateText(serialPort.IsOpen);
        }


        /***
         * 控件事件处理
         * **********************************************************************/

        //打开或关闭串口
        private void btn_ComState_Click(object sender, EventArgs e) {
            if (serialPort.IsOpen) {
                serialPort.Close();
                SetBtnComStateText(false);
            } else {
                try {
                    serialPort.Open();
                    SetBtnComStateText(true);
                } catch {
                    MessageBox.Show("串口已经被占用，请关闭其他串口程序", "错误");
                }
            }
        }

        private void btn_Click(object sender, EventArgs e) {
            tb_CarTagID.Text = "";
            tb_Start.Text = "";
            tb_StartTime.Text = "";
            tb_End.Text = "";
            tb_EndTime.Text = "";
            tb_UnitCost.Text = "";
            tb_Distance.Text = "";
            tb_Total.Text = "";
            tb_CarInfo.Text = "";

        }

        //选择串口
        private void cb_ComNum_SelectedIndexChanged(object sender, EventArgs e) {
            string comNum = cb_ComNum.SelectedItem.ToString();
            if (serialPort != null) {
                if (comNum.Equals(serialPort.PortName)) {
                    return;
                }
                //关闭已经打开的串口
                if (serialPort.IsOpen) {
                    serialPort.Close();
                }
            }
            if (InstanceSerialPort(comNum)) {
                ShowSerialPortInfo();
            }

        }


        private void btn_more_Click(object sender, EventArgs e) {
            CheckMoreForm checkMoreForm = new CheckMoreForm();
            string carTagId = tb_CarTagID.Text;
            checkMoreForm.CarTagId = carTagId;
            checkMoreForm.Service = service;
            checkMoreForm.ShowDialog();
        }


        private void btn_Setting_Click(object sender, EventArgs e) {
            SettingForm settingForm = new SettingForm();
            settingForm.ShowDialog();
        }

        private void btn_Help_Click(object sender, EventArgs e) {
            MessageBox.Show("不存在的！", "提示");
        }

        /**
         *
         * ****************************************************************************************/
        private bool InstanceSerialPort(string comNum) {
            try {
                serialPort = new SerialPort(comNum);
                return true;
            } catch {
                //串口已被占用
                MessageBox.Show("串口已经被占用，请关闭其他串口程序", "错误");
                return false;
            }
        }

        private void btn_Flash_Click(object sender, EventArgs e) {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) {
                cb_ComNum.Items.Add(port);
            }
            if (cb_ComNum.Items.Count > 0) {
                cb_ComNum.SelectedIndex = 0;
            }
        }

        
    }
}
