using Newtonsoft.Json.Linq;
using RFID_EX_ETC_Client.Model.Enitys;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Model.Remote {
     class MainModel {

        public async Task<Result<CarInfo>> GetCarInfoAsync(string carTagId) {
            FormUrlEncodedContent content = new FormUrlEncodedContentBuilder()
                                            .Add("CarTagId", carTagId)
                                            .Build();
             
            HttpClient client = NetUtils.Instance();
            HttpResponseMessage respone = await client.PostAsync(NetURL.URL_CAR_INFO, content);
            ResponseResult result = NetUtils.ExplainHttpResponce(respone);
            CarInfo carInfo = null;
            if (result.StateCode == 200) {
                carInfo = CarInfo.InstanceFormJson(result.Data);
            }
            return Result<CarInfo>.FromResponseResult(result, carInfo);
        }


        public async Task<Result<RouteInfo>> GetRouteInfoAsync(string carTagId) {
            FormUrlEncodedContent content = new FormUrlEncodedContentBuilder()
                                            .Add("CarTagId", carTagId)
                                            .Build();
            HttpClient client = NetUtils.Instance();
            HttpResponseMessage respone = await client.PostAsync(NetURL.URL_ROUTE_INFO, content);
            RouteInfo routeInfo = null;
            ResponseResult result = NetUtils.ExplainHttpResponce(respone);
            if (result.StateCode == 200) {
                routeInfo = RouteInfo.InstanceFormJson(result.Data);
            }
            return Result<RouteInfo> .FromResponseResult(result, routeInfo);
        }

        public async Task<Result<Dictionary<int, Toll>>> GetToll() {
            HttpClient client = NetUtils.Instance();
            HttpResponseMessage respone = await client.GetAsync(NetURL.URL_TOLLS);
            ResponseResult result = NetUtils.ExplainHttpResponce(respone);
            Dictionary<int, Toll> dict = null;
            if (result.StateCode == 200) {
                JArray jArray = JArray.Parse(result.Data);
                dict = new Dictionary<int, Toll>();
                for (int i = 0; i < jArray.Count; i++) {
                    Toll toll = Toll.InstanceFormJson(jArray[i].ToString());
                    dict.Add(toll.Type, toll);
                }
            }
            return Result<Dictionary<int, Toll>>.FromResponseResult(result, dict);
        }

        public async Task<Result<List<HistoryRouteInfo>>> GetHistoryRouteInfoAsync(string carTagId) {
            FormUrlEncodedContent content = new FormUrlEncodedContentBuilder()
                                           .Add("CarTagId", carTagId)
                                           .Build();
            HttpClient client = NetUtils.Instance();
            HttpResponseMessage respone = await client.PostAsync(NetURL.URL_HISTORY_RECORD, content);
            ResponseResult result = NetUtils.ExplainHttpResponce(respone);
            List<HistoryRouteInfo> list = null;
            if (result.StateCode == 200) {
                JArray jArray = JArray.Parse(result.Data);
                list = new List<HistoryRouteInfo>();
                for (int i = 0; i < jArray.Count; i++) {
                    HistoryRouteInfo info = HistoryRouteInfo.InstanceFormJson(jArray[i].ToString());
                    list.Add(info);
                }
            }
            return Result<List<HistoryRouteInfo>>.FromResponseResult(result, list);
        }

        public async Task<Result<string>> PostRouteInfoAsync(RouteInfo routeInfo, bool isStart) {
            FormUrlEncodedContent content = new FormUrlEncodedContentBuilder()
                                          .Add("CarTagId", routeInfo.TagId)
                                          .Add("IsStart", isStart.ToString())
                                          .Add("Data", routeInfo.ToJson())
                                          .Build();
            HttpClient client = NetUtils.Instance();
            HttpResponseMessage respone = await client.PostAsync(NetURL.URL_POST_ROUTE_INFO, content);
            ResponseResult result = NetUtils.ExplainHttpResponce(respone);
            return Result<string>.FromResponseResult(result, "");
        }
    }
}
