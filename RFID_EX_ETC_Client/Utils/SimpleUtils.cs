using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Utils {
    public class SimpleUtils {

        private static DateTime zeroTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
        public static long TimeStr2TimeStamp(string timeStr) {
            DateTime endTime = DateTime.Parse(timeStr);
            return (long)(endTime - zeroTime).TotalMilliseconds;
        }

        private static DateTime TimeStamp2DateTime(long timeStamp) {
            TimeSpan time = new TimeSpan(timeStamp);
            return zeroTime.Add(time);
        }

        public static DateTime TimeStamp2DateTime(string timeStamp) {
            long time = long.Parse(timeStamp+ "0000");
            return TimeStamp2DateTime(time);
        }

        public static long GetNowTimeStamp() {
            return (long)(DateTime.Now - zeroTime).TotalMilliseconds;
        }

        //字节数组转16进制字符串
        public static string Byte2HexStr(byte[] data) {
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < data.Length; i++) {
                sb.Append(data[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
