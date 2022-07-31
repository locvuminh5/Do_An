namespace DoAn
{
    partial class frmQuenMatKhau
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
            this.btnGui = new DevExpress.XtraEditors.SimpleButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.labSDT = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGui
            // 
            this.btnGui.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Appearance.Options.UseFont = true;
            this.btnGui.Location = new System.Drawing.Point(166, 158);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(125, 27);
            this.btnGui.TabIndex = 14;
            this.btnGui.Text = "Gửi Mật Khẩu Mới";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(207, 107);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(145, 21);
            this.txtSDT.TabIndex = 12;
            // 
            // labSDT
            // 
            this.labSDT.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSDT.Appearance.Options.UseFont = true;
            this.labSDT.Location = new System.Drawing.Point(54, 108);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(147, 18);
            this.labSDT.TabIndex = 10;
            this.labSDT.Text = "Số điện thoại đăng ký:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(143, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(180, 25);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "QUÊN MẬT KHẨU";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.EditValue = global::DoAn.Properties.Resources.icons8_close_window_1;
            this.btnClose.Location = new System.Drawing.Point(407, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 15;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 256);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.labSDT);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit btnClose;
        private DevExpress.XtraEditors.SimpleButton btnGui;
        private System.Windows.Forms.TextBox txtSDT;
        private DevExpress.XtraEditors.LabelControl labSDT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}