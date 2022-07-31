namespace DoAn
{
    partial class DoiMK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.btnHideMKC = new System.Windows.Forms.Button();
            this.btnHideMKM = new System.Windows.Forms.Button();
            this.btnShowMKC = new System.Windows.Forms.Button();
            this.btnShowMKM = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(335, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(160, 33);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Đổi Mật Khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(100, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mật khẩu cũ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(100, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mật khẩu mới:";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(208, 57);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(180, 21);
            this.txtMKCu.TabIndex = 6;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(208, 105);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '*';
            this.txtMKMoi.Size = new System.Drawing.Size(180, 21);
            this.txtMKMoi.TabIndex = 7;
            // 
            // btnHideMKC
            // 
            this.btnHideMKC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideMKC.Image = global::DoAn.Properties.Resources.icons8_hide_15px;
            this.btnHideMKC.Location = new System.Drawing.Point(366, 57);
            this.btnHideMKC.Name = "btnHideMKC";
            this.btnHideMKC.Size = new System.Drawing.Size(22, 21);
            this.btnHideMKC.TabIndex = 8;
            this.btnHideMKC.UseVisualStyleBackColor = true;
            this.btnHideMKC.Click += new System.EventHandler(this.btnHideMKC_Click);
            // 
            // btnHideMKM
            // 
            this.btnHideMKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideMKM.Image = global::DoAn.Properties.Resources.icons8_hide_15px;
            this.btnHideMKM.Location = new System.Drawing.Point(366, 105);
            this.btnHideMKM.Name = "btnHideMKM";
            this.btnHideMKM.Size = new System.Drawing.Size(22, 21);
            this.btnHideMKM.TabIndex = 9;
            this.btnHideMKM.UseVisualStyleBackColor = true;
            this.btnHideMKM.Click += new System.EventHandler(this.btnHideMKM_Click);
            // 
            // btnShowMKC
            // 
            this.btnShowMKC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMKC.Image = global::DoAn.Properties.Resources.icons8_eye_15;
            this.btnShowMKC.Location = new System.Drawing.Point(366, 57);
            this.btnShowMKC.Name = "btnShowMKC";
            this.btnShowMKC.Size = new System.Drawing.Size(22, 21);
            this.btnShowMKC.TabIndex = 10;
            this.btnShowMKC.UseVisualStyleBackColor = true;
            this.btnShowMKC.Click += new System.EventHandler(this.btnShowMKC_Click);
            // 
            // btnShowMKM
            // 
            this.btnShowMKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMKM.Image = global::DoAn.Properties.Resources.icons8_eye_15;
            this.btnShowMKM.Location = new System.Drawing.Point(366, 105);
            this.btnShowMKM.Name = "btnShowMKM";
            this.btnShowMKM.Size = new System.Drawing.Size(22, 21);
            this.btnShowMKM.TabIndex = 11;
            this.btnShowMKM.UseVisualStyleBackColor = true;
            this.btnShowMKM.Click += new System.EventHandler(this.btnShowMKM_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHoanTat.Location = new System.Drawing.Point(199, 165);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(108, 43);
            this.btnHoanTat.TabIndex = 12;
            this.btnHoanTat.Text = "Hoàn Tất";
            this.btnHoanTat.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnHoanTat);
            this.panel1.Controls.Add(this.btnShowMKM);
            this.panel1.Controls.Add(this.btnShowMKC);
            this.panel1.Controls.Add(this.btnHideMKM);
            this.panel1.Controls.Add(this.btnHideMKC);
            this.panel1.Controls.Add(this.txtMKMoi);
            this.panel1.Controls.Add(this.txtMKCu);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Location = new System.Drawing.Point(161, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 273);
            this.panel1.TabIndex = 13;
            // 
            // DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl1);
            this.Name = "DoiMK";
            this.Size = new System.Drawing.Size(839, 581);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Button btnHideMKC;
        private System.Windows.Forms.Button btnHideMKM;
        private System.Windows.Forms.Button btnShowMKC;
        private System.Windows.Forms.Button btnShowMKM;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Panel panel1;
    }
}
