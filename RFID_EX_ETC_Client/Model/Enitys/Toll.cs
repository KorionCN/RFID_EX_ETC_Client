using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Model.Enitys {
    class Toll {
        private int type;
        private double unitCost;

        public int Type { get => type; set => type = value; }
        public double UnitCost { get => unitCost; set => unitCost = value; }

        public static Toll InstanceFormJson(string json) {
            Toll carInfo = JsonConvert.DeserializeObject<Toll>(json);
            return carInfo;
        }

        public string ToJson() {
            string jsonData = JsonConvert.SerializeObject(this);
            return jsonData;
        }
    }
}
