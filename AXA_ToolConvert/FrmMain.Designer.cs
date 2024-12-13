
namespace AXA_ToolConvert
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_loading = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_fail = new System.Windows.Forms.Label();
            this.lbl_success = new System.Windows.Forms.Label();
            this.lbl_totalNumber = new System.Windows.Forms.Label();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.GB = new System.Windows.Forms.GroupBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fileoutput = new System.Windows.Forms.Button();
            this.txt_pathName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fileInput = new System.Windows.Forms.Button();
            this.btn_DeleteLog = new System.Windows.Forms.Button();
            this.btn_convert = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pb_loading);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 38);
            this.panel2.TabIndex = 1;
            // 
            // pb_loading
            // 
            this.pb_loading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_loading.Location = new System.Drawing.Point(13, 6);
            this.pb_loading.MarqueeAnimationSpeed = 10;
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(608, 20);
            this.pb_loading.TabIndex = 8;
            this.pb_loading.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_fail);
            this.panel3.Controls.Add(this.lbl_success);
            this.panel3.Controls.Add(this.lbl_totalNumber);
            this.panel3.Controls.Add(this.rtb_Log);
            this.panel3.Controls.Add(this.GB);
            this.panel3.Controls.Add(this.btn_DeleteLog);
            this.panel3.Controls.Add(this.btn_convert);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 416);
            this.panel3.TabIndex = 1;
            // 
            // lbl_fail
            // 
            this.lbl_fail.AutoSize = true;
            this.lbl_fail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fail.ForeColor = System.Drawing.Color.Red;
            this.lbl_fail.Location = new System.Drawing.Point(529, 144);
            this.lbl_fail.Name = "lbl_fail";
            this.lbl_fail.Size = new System.Drawing.Size(71, 14);
            this.lbl_fail.TabIndex = 11;
            this.lbl_fail.Text = "Thất bại : 0";
            // 
            // lbl_success
            // 
            this.lbl_success.AutoSize = true;
            this.lbl_success.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_success.ForeColor = System.Drawing.Color.Green;
            this.lbl_success.Location = new System.Drawing.Point(241, 144);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(92, 14);
            this.lbl_success.TabIndex = 10;
            this.lbl_success.Text = "Thành công : 0";
            // 
            // lbl_totalNumber
            // 
            this.lbl_totalNumber.AutoSize = true;
            this.lbl_totalNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalNumber.Location = new System.Drawing.Point(13, 144);
            this.lbl_totalNumber.Name = "lbl_totalNumber";
            this.lbl_totalNumber.Size = new System.Drawing.Size(78, 13);
            this.lbl_totalNumber.TabIndex = 9;
            this.lbl_totalNumber.Text = "Tổng số file : 0";
            // 
            // rtb_Log
            // 
            this.rtb_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Log.Location = new System.Drawing.Point(13, 176);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.Size = new System.Drawing.Size(608, 220);
            this.rtb_Log.TabIndex = 8;
            this.rtb_Log.Text = "";
            // 
            // GB
            // 
            this.GB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB.Controls.Add(this.txt_output);
            this.GB.Controls.Add(this.label2);
            this.GB.Controls.Add(this.btn_fileoutput);
            this.GB.Controls.Add(this.txt_pathName);
            this.GB.Controls.Add(this.label1);
            this.GB.Controls.Add(this.btn_fileInput);
            this.GB.Location = new System.Drawing.Point(12, 6);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(609, 97);
            this.GB.TabIndex = 1;
            this.GB.TabStop = false;
            this.GB.Text = "Trường nhập";
            // 
            // txt_output
            // 
            this.txt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_output.BackColor = System.Drawing.Color.White;
            this.txt_output.Enabled = false;
            this.txt_output.ForeColor = System.Drawing.Color.Black;
            this.txt_output.Location = new System.Drawing.Point(148, 54);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(343, 20);
            this.txt_output.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thư mục đích * :";
            // 
            // btn_fileoutput
            // 
            this.btn_fileoutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fileoutput.Location = new System.Drawing.Point(520, 51);
            this.btn_fileoutput.Name = "btn_fileoutput";
            this.btn_fileoutput.Size = new System.Drawing.Size(75, 23);
            this.btn_fileoutput.TabIndex = 5;
            this.btn_fileoutput.Text = "Chọn";
            this.btn_fileoutput.UseVisualStyleBackColor = true;
            this.btn_fileoutput.Click += new System.EventHandler(this.btn_fileoutput_Click);
            // 
            // txt_pathName
            // 
            this.txt_pathName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pathName.Enabled = false;
            this.txt_pathName.ForeColor = System.Drawing.Color.Black;
            this.txt_pathName.Location = new System.Drawing.Point(148, 19);
            this.txt_pathName.Name = "txt_pathName";
            this.txt_pathName.Size = new System.Drawing.Size(343, 20);
            this.txt_pathName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư mục gốc * :";
            // 
            // btn_fileInput
            // 
            this.btn_fileInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fileInput.Location = new System.Drawing.Point(520, 16);
            this.btn_fileInput.Name = "btn_fileInput";
            this.btn_fileInput.Size = new System.Drawing.Size(75, 23);
            this.btn_fileInput.TabIndex = 2;
            this.btn_fileInput.Text = "Chọn";
            this.btn_fileInput.UseVisualStyleBackColor = true;
            this.btn_fileInput.Click += new System.EventHandler(this.btn_fileInput_Click);
            // 
            // btn_DeleteLog
            // 
            this.btn_DeleteLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteLog.Location = new System.Drawing.Point(428, 109);
            this.btn_DeleteLog.Name = "btn_DeleteLog";
            this.btn_DeleteLog.Size = new System.Drawing.Size(75, 22);
            this.btn_DeleteLog.TabIndex = 7;
            this.btn_DeleteLog.Text = "Xóa log";
            this.btn_DeleteLog.UseVisualStyleBackColor = true;
            this.btn_DeleteLog.Click += new System.EventHandler(this.btn_DeleteLog_Click);
            // 
            // btn_convert
            // 
            this.btn_convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_convert.Location = new System.Drawing.Point(532, 109);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 22);
            this.btn_convert.TabIndex = 3;
            this.btn_convert.Text = "Chuyển đổi";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 454);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "AX.ConvertTool";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_DeleteLog;

        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_fileInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pb_loading;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.TextBox txt_pathName;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fileoutput;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.Label lbl_fail;
        private System.Windows.Forms.Label lbl_success;
        private System.Windows.Forms.Label lbl_totalNumber;
    }
}