using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Model.Remote {
    public class ResponseResult {
        private int stateCode;
        private string message;
        private string data;

        public int StateCode { get => stateCode; set => stateCode = value; }
        public string Message { get => message; set => message = value; }
        public string Data { get => data; set => data = value; }

        public static ResponseResult InstanceFormJson(string json) {
            ResponseResult carInfo = JsonConvert.DeserializeObject<ResponseResult>(json);
            return carInfo;
        }

        public string ToJson() {
            string jsonData = JsonConvert.SerializeObject(this);
            return jsonData;
        }
    }
}
