using RFID_EX_ETC_Client.Model.Enitys;
using RFID_EX_ETC_Client.Service;
using RFID_EX_ETC_Client.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_EX_ETC_Client {
    public partial class CheckMoreForm : Form {

        private string carTagId;
        private MainService service;

        public string CarTagId { set => carTagId = value; }
        internal MainService Service { set => service = value; }

        public CheckMoreForm() {
            InitializeComponent();
            this.Load += CheckMoreForm_Load;
        }

        private void CheckMoreForm_Load(object sender, EventArgs e) {
            InitView();
        }

        private void InitView() {
            if (carTagId != null) {
                tb_carTagId.Text = carTagId;
            }
            dtp_startTime.Value = DateTime.Now.Date;
            dtp_endTime.Value = DateTime.Now.Date;

            //添加ListView列名行
            int width = ls_dataList.Width;
            ls_dataList.View = View.Details;
            ls_dataList.Columns.Add("起始站", width/6, HorizontalAlignment.Center);
            ls_dataList.Columns.Add("入站时间", width/6, HorizontalAlignment.Center);
            ls_dataList.Columns.Add("终点站", width/6, HorizontalAlignment.Center);
            ls_dataList.Columns.Add("出站时间", width/6, HorizontalAlignment.Center);
            ls_dataList.Columns.Add("里程数", width/6, HorizontalAlignment.Center);
            ls_dataList.Columns.Add("收费", width/6, HorizontalAlignment.Center);

        }
        
        private void btn_check_Click(object sender, EventArgs e) {
            string startTimeStr = dtp_startTime.Text;
            string endTimeStr = dtp_endTime.Text;
            string tagId = tb_carTagId.Text.Trim();

            long startTime = SimpleUtils.TimeStr2TimeStamp(startTimeStr);
            long endTime = SimpleUtils.TimeStr2TimeStamp(DateTime.Parse(endTimeStr).AddDays(1f).ToString());

            if (tagId == null || tagId.Length != "004061EECF".Length) {
                MessageBox.Show("车辆标签ID不合法", "错误");
                return;
            }
            LogUtil.WriteLine("startTime=" + startTime + " endTime=" + endTime);
            if (startTime >= endTime) {
                MessageBox.Show("截止日期不得超过起始日期！", "错误");
                return;
            }
            //检查日期，不得大于当前时间
            if (startTime > SimpleUtils.TimeStr2TimeStamp(DateTime.Now.Date.AddHours(1).ToString())) {
                MessageBox.Show("无记录", "提示");
                return;
            }
            
            //向服务器请求车辆历史行程记录数据
            service.GetHistoryRouteInfo(carTagId, GetHistoryRouteInfoDele);
        }

        private void GetHistoryRouteInfoDele(bool isSuccess, string message, List<HistoryRouteInfo> list) {
            if (isSuccess) {
                LoadData2DataList(list);
            } else {

            }
        }

        private delegate void LoadData2DataListDelegate(List<HistoryRouteInfo> dataList);
        private void LoadData2DataList(List<HistoryRouteInfo> dataList) {
            if (ls_dataList.InvokeRequired) {
                this.Invoke(new LoadData2DataListDelegate(LoadData2DataList), dataList);
            } else {
                this.ls_dataList.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
                foreach (HistoryRouteInfo temp in dataList) {
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.StartStat;
                    item.SubItems.Add(SimpleUtils.TimeStamp2DateTime(temp.StartTime).ToLocalTime().ToString());
                    item.SubItems.Add(temp.EndStat);
                    item.SubItems.Add(SimpleUtils.TimeStamp2DateTime(temp.EndTime).ToLocalTime().ToString());
                    item.SubItems.Add(temp.Distance.ToString());
                    item.SubItems.Add(temp.Cost.ToString());
                    ls_dataList.Items.Add(item);
                }
                this.ls_dataList.EndUpdate();  //结束数据处理，UI界面一次性绘制。  
            }
            
        }
        
    }
}
