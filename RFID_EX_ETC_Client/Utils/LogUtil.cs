using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Utils {
    public class LogUtil {
        private static DebugConfig debugConfig = new DebugConfig();

        public static void WriteLine(String message) {
            Debug.WriteLineIf(debugConfig.IsDebug, message);
        }
    }
}
