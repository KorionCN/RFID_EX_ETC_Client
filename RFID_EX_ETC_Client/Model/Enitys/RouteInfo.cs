using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Model.Enitys {
    public class RouteInfo {
        private string tagId;
        private string startStat;
        private string startTime;
        private string endStat;
        private string endTime;
        private double distance;
      
        public double Distance { get => distance; set => distance = value; }
        public string EndTime { get => endTime; set => endTime = value; }
        public string EndStat { get => endStat; set => endStat = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string StartStat { get => startStat; set => startStat = value; }
        public string TagId { get => tagId; set => tagId = value; }

        public static RouteInfo InstanceFormJson(string json) {
            RouteInfo carInfo = JsonConvert.DeserializeObject<RouteInfo>(json);
            return carInfo;
        }

        public string ToJson() {
            string jsonData = JsonConvert.SerializeObject(this);
            return jsonData;
        }
    }
}
