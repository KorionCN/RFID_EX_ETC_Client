using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RFID_EX_ETC_Client.Model.Remote {
    class FormUrlEncodedContentBuilder {
        private List<KeyValuePair<string, string>> list;

        public FormUrlEncodedContentBuilder() {
            list = new List<KeyValuePair<string, string>>();
        }

        public FormUrlEncodedContentBuilder Add(string key, string value) {
            list.Add(new KeyValuePair<string, string>(key, value));
            return this;
        }

        public FormUrlEncodedContent Build() {
            FormUrlEncodedContent temp = new FormUrlEncodedContent(list);
            list.Clear();
            return temp;
        }
    }
}
