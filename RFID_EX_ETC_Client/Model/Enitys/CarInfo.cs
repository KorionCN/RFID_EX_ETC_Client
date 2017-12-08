using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Model.Enitys {
    public class CarInfo {
        private string tagId;
        private int type;
        private string plateNum;
        private string engineNum;

        public string TagId { get => tagId; set => tagId = value; }
        public int Type { get => type; set => type = value; }
        public string PlateNum { get => plateNum; set => plateNum = value; }
        public string EngineNum { get => engineNum; set => engineNum = value; }


        public static CarInfo InstanceFormJson(string json) {
            //CarInfo carInfo = new CarInfo();
            //JObject jObj = (JObject)JsonConvert.DeserializeObject(json);
            //carInfo.TagId = jObj["TagId"].ToString();
            //carInfo.Type = jObj["Type"].ToObject<int>();
            //carInfo.PlateNum = jObj["PlateNum"].ToString();
            //carInfo.EngineNum = jObj["EngineNum"].ToString();
            CarInfo carInfo = JsonConvert.DeserializeObject<CarInfo>(json);
            return carInfo;
        }

        public string ToJson() {
            string jsonData = JsonConvert.SerializeObject(this);
            return jsonData;
        }
    }
}
