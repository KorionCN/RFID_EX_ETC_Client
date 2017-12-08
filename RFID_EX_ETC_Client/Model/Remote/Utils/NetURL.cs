using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Model.Remote {
    class NetURL {
        private static readonly string HOST = "";
        public static readonly string URL_CAR_INFO = "http://" + HOST + "/main/getCarInfo";
        public static readonly string URL_ROUTE_INFO = "http://" + HOST + "/main/getRouteInfo";
        public static readonly string URL_TOLLS = "http://" + HOST + "/main/getToll";
        public static readonly string URL_HISTORY_RECORD = "http://" + HOST + "/main/getHistoryRouteInfo";
        public static readonly string URL_POST_ROUTE_INFO = "http://" + HOST + "/main/postRouteInfo";
    }
}
