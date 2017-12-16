using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Model.Remote {
    class NetURL {
      // result.eolinker.com/2QhE5Rpb3fad254c515e0def77fb072014f18e0ddc2b9ad? uri =
        private static readonly string HOST = "result.eolinker.com/2QhE5Rpb3fad254c515e0def77fb072014f18e0ddc2b9ad?uri=";
        public static readonly string URL_CAR_INFO = "http://" + HOST + "/main/getCarInfo";
        public static readonly string URL_ROUTE_INFO = "http://" + HOST + "/main/getRouteInfo";
        public static readonly string URL_TOLLS = "http://" + HOST + "/main/getToll";
        public static readonly string URL_HISTORY_RECORD = "http://" + HOST + "/main/getHistoryRouteInfo";
        public static readonly string URL_POST_ROUTE_INFO = "http://" + HOST + "/main/postRouteInfo";
    }
}
