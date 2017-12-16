using RFID_EX_ETC_Client.Model.Enitys;
using RFID_EX_ETC_Client.Model.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Model {
    public class UnitTest {
        private static MainModel mainModel = new MainModel();

        public static void TestGetCarInfoAsync() {
            Result<CarInfo> result =  mainModel.GetCarInfoAsync("004061EECF").Result;
            Console.WriteLine(result.Data.ToJson());
        }

        public static void TestGetRouteInfoAsync() {
            Result<RouteInfo> result = mainModel.GetRouteInfoAsync("004061EECF").Result;
            Console.WriteLine(result.Data.ToJson());
        }

        public static void TestGetToll() {
            Result<Dictionary<int, Toll>> result = mainModel.GetToll().Result;
            foreach (KeyValuePair<int, Toll> temp in result.Data) {
                Console.WriteLine(temp.Key+"--->"+temp.Value.ToJson());
            }
        }

        public static void TestGetHistoryRouteInfo() {
            Result<List<HistoryRouteInfo>> result = mainModel.GetHistoryRouteInfoAsync("004061EECF").Result;
            foreach (HistoryRouteInfo temp in result.Data) {
                Console.WriteLine(temp.ToJson());
            }
        }

        public static void TestPostRouteInfo() {
            RouteInfo routeInfo = new RouteInfo() {
                TagId = "48022323131",
                StartStat = "A",
                StartTime = "456152",
                EndStat = "B",
                EndTime = "1112313",
                Distance = 12
                
            };
            Result<string> r = mainModel.PostRouteInfoAsync(routeInfo, true).Result;
        }
    }
}
