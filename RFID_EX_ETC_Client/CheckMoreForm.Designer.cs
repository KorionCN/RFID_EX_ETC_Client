namespace RFID_EX_ETC_Client {
    partial class CheckMoreForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_carTagId = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.dtp_startTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_endTime = new System.Windows.Forms.DateTimePicker();
            this.ls_dataList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "车辆标签ID";
            // 
            // tb_carTagId
            // 
            this.tb_carTagId.Location = new System.Drawing.Point(102, 19);
            this.tb_carTagId.Name = "tb_carTagId";
            this.tb_carTagId.Size = new System.Drawing.Size(157, 25);
            this.tb_carTagId.TabIndex = 1;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(288, 19);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 25);
            this.btn_check.TabIndex = 3;
            this.btn_check.Text = "查询";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // dtp_startTime
            // 
            this.dtp_startTime.Location = new System.Drawing.Point(102, 51);
            this.dtp_startTime.Name = "dtp_startTime";
            this.dtp_startTime.Size = new System.Drawing.Size(157, 25);
            this.dtp_startTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "起始时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "截止时间";
            // 
            // dtp_endTime
            // 
            this.dtp_endTime.Location = new System.Drawing.Point(377, 51);
            this.dtp_endTime.Name = "dtp_endTime";
            this.dtp_endTime.Size = new System.Drawing.Size(155, 25);
            this.dtp_endTime.TabIndex = 7;
            // 
            // ls_dataList
            // 
            this.ls_dataList.GridLines = true;
            this.ls_dataList.Location = new System.Drawing.Point(15, 91);
            this.ls_dataList.Name = "ls_dataList";
            this.ls_dataList.Size = new System.Drawing.Size(610, 400);
            this.ls_dataList.TabIndex = 8;
            this.ls_dataList.UseCompatibleStateImageBehavior = false;
            // 
            // CheckMoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 503);
            this.Controls.Add(this.ls_dataList);
            this.Controls.Add(this.dtp_endTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_startTime);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.tb_carTagId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckMoreForm";
            this.Text = "查询车辆行程记录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_carTagId;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.DateTimePicker dtp_startTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_endTime;
        private System.Windows.Forms.ListView ls_dataList;
    }
}