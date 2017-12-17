namespace RFID_EX_ETC_Client {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.tb_CarTagID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Flash = new System.Windows.Forms.Button();
            this.tb_DataBits = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ComState = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_StopBits = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Parity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_BaudRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ComNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_UnitCost = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_Distance = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_EndTime = new System.Windows.Forms.TextBox();
            this.tb_StartTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_End = new System.Windows.Forms.TextBox();
            this.tb_Start = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_CarInfo = new System.Windows.Forms.TextBox();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_more = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_CarTagID
            // 
            this.tb_CarTagID.Location = new System.Drawing.Point(117, 24);
            this.tb_CarTagID.Name = "tb_CarTagID";
            this.tb_CarTagID.ReadOnly = true;
            this.tb_CarTagID.Size = new System.Drawing.Size(206, 25);
            this.tb_CarTagID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "车辆标签ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Flash);
            this.groupBox1.Controls.Add(this.tb_DataBits);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_ComState);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_StopBits);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_Parity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_BaudRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_ComNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(405, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口参数";
            // 
            // btn_Flash
            // 
            this.btn_Flash.BackgroundImage = global::RFID_EX_ETC_Client.Properties.Resources.flush;
            this.btn_Flash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Flash.Location = new System.Drawing.Point(81, 19);
            this.btn_Flash.Name = "btn_Flash";
            this.btn_Flash.Size = new System.Drawing.Size(23, 23);
            this.btn_Flash.TabIndex = 13;
            this.btn_Flash.UseVisualStyleBackColor = true;
            this.btn_Flash.Click += new System.EventHandler(this.btn_Flash_Click);
            // 
            // tb_DataBits
            // 
            this.tb_DataBits.Location = new System.Drawing.Point(110, 143);
            this.tb_DataBits.Name = "tb_DataBits";
            this.tb_DataBits.ReadOnly = true;
            this.tb_DataBits.Size = new System.Drawing.Size(74, 25);
            this.tb_DataBits.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "数据位:";
            // 
            // btn_ComState
            // 
            this.btn_ComState.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_ComState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ComState.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ComState.ForeColor = System.Drawing.Color.White;
            this.btn_ComState.Location = new System.Drawing.Point(109, 172);
            this.btn_ComState.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ComState.Name = "btn_ComState";
            this.btn_ComState.Size = new System.Drawing.Size(75, 27);
            this.btn_ComState.TabIndex = 10;
            this.btn_ComState.Text = "Open";
            this.btn_ComState.UseVisualStyleBackColor = false;
            this.btn_ComState.Click += new System.EventHandler(this.btn_ComState_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "串口状态:";
            // 
            // tb_StopBits
            // 
            this.tb_StopBits.Location = new System.Drawing.Point(110, 112);
            this.tb_StopBits.Name = "tb_StopBits";
            this.tb_StopBits.ReadOnly = true;
            this.tb_StopBits.Size = new System.Drawing.Size(74, 25);
            this.tb_StopBits.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "停止位:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "奇偶校验位:";
            // 
            // tb_Parity
            // 
            this.tb_Parity.Location = new System.Drawing.Point(110, 81);
            this.tb_Parity.Name = "tb_Parity";
            this.tb_Parity.ReadOnly = true;
            this.tb_Parity.Size = new System.Drawing.Size(74, 25);
            this.tb_Parity.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 4;
            // 
            // tb_BaudRate
            // 
            this.tb_BaudRate.Location = new System.Drawing.Point(110, 49);
            this.tb_BaudRate.Name = "tb_BaudRate";
            this.tb_BaudRate.ReadOnly = true;
            this.tb_BaudRate.Size = new System.Drawing.Size(74, 25);
            this.tb_BaudRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "波特率:";
            // 
            // cb_ComNum
            // 
            this.cb_ComNum.FormattingEnabled = true;
            this.cb_ComNum.Location = new System.Drawing.Point(110, 19);
            this.cb_ComNum.Name = "cb_ComNum";
            this.cb_ComNum.Size = new System.Drawing.Size(74, 23);
            this.cb_ComNum.TabIndex = 1;
            this.cb_ComNum.SelectedIndexChanged += new System.EventHandler(this.cb_ComNum_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "串口号:";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(329, 24);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(60, 25);
            this.btn.TabIndex = 5;
            this.btn.Text = "清除";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Total);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tb_UnitCost);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tb_Distance);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tb_EndTime);
            this.groupBox2.Controls.Add(this.tb_StartTime);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_End);
            this.groupBox2.Controls.Add(this.tb_Start);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(24, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 162);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "行程信息";
            // 
            // tb_Total
            // 
            this.tb_Total.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Total.Location = new System.Drawing.Point(260, 106);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.ReadOnly = true;
            this.tb_Total.Size = new System.Drawing.Size(99, 34);
            this.tb_Total.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(191, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 24);
            this.label16.TabIndex = 12;
            this.label16.Text = "总计";
            // 
            // tb_UnitCost
            // 
            this.tb_UnitCost.Location = new System.Drawing.Point(118, 124);
            this.tb_UnitCost.Name = "tb_UnitCost";
            this.tb_UnitCost.ReadOnly = true;
            this.tb_UnitCost.Size = new System.Drawing.Size(59, 25);
            this.tb_UnitCost.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "收费(元/公里)";
            // 
            // tb_Distance
            // 
            this.tb_Distance.Location = new System.Drawing.Point(118, 94);
            this.tb_Distance.Name = "tb_Distance";
            this.tb_Distance.ReadOnly = true;
            this.tb_Distance.Size = new System.Drawing.Size(59, 25);
            this.tb_Distance.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "里程数(公里)";
            // 
            // tb_EndTime
            // 
            this.tb_EndTime.Location = new System.Drawing.Point(200, 62);
            this.tb_EndTime.Name = "tb_EndTime";
            this.tb_EndTime.ReadOnly = true;
            this.tb_EndTime.Size = new System.Drawing.Size(159, 25);
            this.tb_EndTime.TabIndex = 7;
            // 
            // tb_StartTime
            // 
            this.tb_StartTime.Location = new System.Drawing.Point(200, 31);
            this.tb_StartTime.Name = "tb_StartTime";
            this.tb_StartTime.ReadOnly = true;
            this.tb_StartTime.Size = new System.Drawing.Size(159, 25);
            this.tb_StartTime.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(157, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "时间";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "时间";
            // 
            // tb_End
            // 
            this.tb_End.Location = new System.Drawing.Point(68, 62);
            this.tb_End.Name = "tb_End";
            this.tb_End.ReadOnly = true;
            this.tb_End.Size = new System.Drawing.Size(74, 25);
            this.tb_End.TabIndex = 3;
            // 
            // tb_Start
            // 
            this.tb_Start.Location = new System.Drawing.Point(68, 31);
            this.tb_Start.Name = "tb_Start";
            this.tb_Start.ReadOnly = true;
            this.tb_Start.Size = new System.Drawing.Size(74, 25);
            this.tb_Start.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "终点站";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "起始站";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_CarInfo);
            this.groupBox3.Location = new System.Drawing.Point(24, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 171);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "车辆信息";
            // 
            // tb_CarInfo
            // 
            this.tb_CarInfo.Location = new System.Drawing.Point(7, 24);
            this.tb_CarInfo.Multiline = true;
            this.tb_CarInfo.Name = "tb_CarInfo";
            this.tb_CarInfo.ReadOnly = true;
            this.tb_CarInfo.Size = new System.Drawing.Size(352, 141);
            this.tb_CarInfo.TabIndex = 0;
            // 
            // btn_Setting
            // 
            this.btn_Setting.Location = new System.Drawing.Point(416, 288);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(173, 30);
            this.btn_Setting.TabIndex = 9;
            this.btn_Setting.Text = "设置";
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(416, 323);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(173, 29);
            this.btn_Help.TabIndex = 10;
            this.btn_Help.Text = "帮助";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(472, 361);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 11;
            this.label17.Text = "关于软件";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(435, 381);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 15);
            this.label18.TabIndex = 12;
            this.label18.Text = "Developed By CYY";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_more
            // 
            this.btn_more.Location = new System.Drawing.Point(416, 253);
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(173, 29);
            this.btn_more.TabIndex = 13;
            this.btn_more.Text = "查询更多";
            this.btn_more.UseVisualStyleBackColor = true;
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 414);
            this.Controls.Add(this.btn_more);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_CarTagID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ETC客户端";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_CarTagID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Parity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_BaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ComNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ComState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_StopBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_DataBits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_End;
        private System.Windows.Forms.TextBox tb_Start;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_CarInfo;
        private System.Windows.Forms.TextBox tb_EndTime;
        private System.Windows.Forms.TextBox tb_StartTime;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_UnitCost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_Distance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_more;
        private System.Windows.Forms.Button btn_Flash;
    }
}

