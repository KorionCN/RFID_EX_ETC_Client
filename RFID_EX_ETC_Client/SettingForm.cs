using RFID_EX_ETC_Client.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_EX_ETC_Client {
    public partial class SettingForm : Form {
        public SettingForm() {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e) {
            string statName = btn_save.Text.Trim();
            if (!"".Equals(statName)) {
                GlobalVar.StatName = statName;
            }
        }

        private void SettingForm_Load(object sender, EventArgs e) => tb_StatName.Text = GlobalVar.StatName;

    }
}
