using Newtonsoft.Json.Linq;
using RFID_EX_ETC_Client.Model.Enitys;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;


namespace RFID_EX_ETC_Client.Model.Remote {
     public class NetUtils {
        private static HttpClient httpClient;

        public static HttpClient Instance() {
            if (httpClient == null) {
                httpClient = new HttpClient();
            }
            
            return httpClient;
        }

        public static byte[] ConvertStr2ByteArray(string str) {
            return Encoding.UTF8.GetBytes(str);
        }

        public static string ConverByteArray2Str(byte[] bytes) {
            return Encoding.UTF8.GetString(bytes);
        }

        public static ResponseResult ExplainHttpResponce(HttpResponseMessage responce) {
            ResponseResult result = null;
            if (responce.IsSuccessStatusCode) {
                string json = responce.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Responce String:"+json);
                result = ResponseResult.InstanceFormJson(json);
               // Console.WriteLine("Responce 解析完成");
            } else {
                //网络错误处理
            }
            responce.Dispose();
            return result;
        }


    }
}
