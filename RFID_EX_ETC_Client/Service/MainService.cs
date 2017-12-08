using RFID_EX_ETC_Client.Model.Enitys;
using RFID_EX_ETC_Client.Model.Remote;
using RFID_EX_ETC_Client.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Service {
    class MainService {
        private MainModel model = new MainModel();
        private Thread workThread;
        private Dictionary<int, Toll> tollDict;
        private string tagId;
        private CarInfo carInfo;

        public string TagId { get => tagId; set => tagId = value; }
        internal Dictionary<int, Toll> TollDict { get => tollDict; }
        public CarInfo CarInfo { get => carInfo; }

        //请求成功，isSuccess 为 true，message可忽略，result为请求结果
        //请求失败， isSuccess为 false, message为错误信息，result = null
        public delegate void ResultCallBack<T>(bool isSuccess, string message, T result);

        private ResultCallBack<CarInfo> CarInfoCallBack;
        private ResultCallBack<RouteInfo> RouteInfoCallBack;
        ResultCallBack<List<HistoryRouteInfo>> HistoryRouteInfoCallBack;

        

        //获取车辆信息
        public void GetCarInfo(string carTagId, ResultCallBack<CarInfo> callBack) {
            CarInfoCallBack = callBack;
            ParameterizedThreadStart runable = GetCarInfoDele;
            workThread = new Thread(runable);
            workThread.IsBackground = true;
            workThread.Start(carTagId);
        }

        //获取车辆行程信息
        public void GetRouteInfo(string carTagId, ResultCallBack<RouteInfo> callBack) {
            RouteInfoCallBack = callBack;
            ParameterizedThreadStart runable = GetRouteInfoDele;
            workThread = new Thread(runable);
            workThread.IsBackground = true;
            workThread.Start(carTagId);
        }

        //获取车辆历史行程记录
        public void GetHistoryRouteInfo(string carTagId, ResultCallBack<List<HistoryRouteInfo>> callBack) {
            HistoryRouteInfoCallBack = callBack;
            ParameterizedThreadStart runable = GetHistoryRouteInfoDele;
            workThread = new Thread(runable);
            workThread.IsBackground = true;
            workThread.Start(carTagId);
        }

        /**
         * 以下函数在子线程中运行
         * *****************************************************************/

        private void GetCarInfoDele(object value) {
            string carTagId = (string)value;
            Result<CarInfo> result = model.GetCarInfoAsync(carTagId).Result;
            bool isSuccess = false;
            if (result.StateCode == 200) {
                isSuccess = true;
                carInfo = result.Data;
            }
            if (CarInfoCallBack != null) {
                CarInfoCallBack.Invoke(isSuccess, result.Message, result.Data);
            }
        }

        private Random random = new Random(1024);
        private void GetRouteInfoDele(object value) {
            if (tollDict == null) {
                Result<Dictionary<int, Toll>> r = model.GetToll().Result;
                tollDict = r.Data;
            }
            string carTagId = (string)value;
            Result<RouteInfo> result = model.GetRouteInfoAsync(carTagId).Result;
            if (result.StateCode == 200) {
                //查询到该车辆的一半行程信息，在起始站的信息
                RouteInfo routeInfo = new RouteInfo() {
                    TagId = result.Data.TagId,
                    StartStat = result.Data.StartStat,
                    StartTime = result.Data.StartTime,
                    EndStat = GlobalVar.StatName,
                    EndTime = SimpleUtils.GetNowTimeStamp() + "",
                    Distance = random.Next(1024) + 20
                };
                if (RouteInfoCallBack != null) {
                    //生成车辆行程终点信息
                    RouteInfoCallBack.Invoke(true, result.Message, routeInfo);
                }
                //上传在终点站的信息
                Result<string> postResult = model.PostRouteInfoAsync(routeInfo, false).Result;
                HandlePostReuslt(postResult);
            } else if (result.StateCode == 400) {
                //查询不到该车辆的行程信息
                //生成车辆行程起始信息
                RouteInfo routeInfo = new RouteInfo() {
                    TagId = tagId,
                    StartStat = GlobalVar.StatName,
                    StartTime = SimpleUtils.GetNowTimeStamp() + "",
                    EndStat = "",
                    EndTime = "",
                    Distance = 0,
                };
                if (RouteInfoCallBack != null) {
                    RouteInfoCallBack.Invoke(true, result.Message, routeInfo);
                }
                //上传起始信息。
                Result<string> postResult = model.PostRouteInfoAsync(routeInfo, true).Result;
                HandlePostReuslt(postResult);
            } else {
                //错误处理
                if (RouteInfoCallBack != null) {
                    RouteInfoCallBack.Invoke(false, result.Message, null);
                }
            }
        }

        private void HandlePostReuslt(Result<string> result) {

        }

        private void GetHistoryRouteInfoDele(object value) {
            string carTagId = (string)value;
            Result<List<HistoryRouteInfo>> result =  model.GetHistoryRouteInfoAsync(carTagId).Result;
            bool isSuccess = false;
            if (result.StateCode == 200) {
                isSuccess = true;
            }
            if (CarInfoCallBack != null) {
                HistoryRouteInfoCallBack.Invoke(isSuccess, result.Message, result.Data);
            }
        }

    }
}
