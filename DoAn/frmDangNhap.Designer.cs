namespace DoAn
{
    partial class frmDangNhap
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
            this.btnClose = new DevExpress.XtraEditors.PictureEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.labMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.labTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labQMK = new System.Windows.Forms.Label();
            this.labDK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.EditValue = global::DoAn.Properties.Resources.icons8_close_window_1;
            this.btnClose.Location = new System.Drawing.Point(406, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 22;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.Paint += new System.Windows.Forms.PaintEventHandler(this.btnClose_Paint);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(174, 183);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(97, 27);
            this.btnDangNhap.TabIndex = 21;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(196, 122);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(145, 21);
            this.txtMatKhau.TabIndex = 20;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(196, 85);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(145, 21);
            this.txtTaiKhoan.TabIndex = 19;
            // 
            // labMatKhau
            // 
            this.labMatKhau.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMatKhau.Appearance.Options.UseFont = true;
            this.labMatKhau.Location = new System.Drawing.Point(114, 123);
            this.labMatKhau.Name = "labMatKhau";
            this.labMatKhau.Size = new System.Drawing.Size(73, 18);
            this.labMatKhau.TabIndex = 18;
            this.labMatKhau.Text = "Mật Khẩu: ";
            // 
            // labTaiKhoan
            // 
            this.labTaiKhoan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTaiKhoan.Appearance.Options.UseFont = true;
            this.labTaiKhoan.Location = new System.Drawing.Point(114, 87);
            this.labTaiKhoan.Name = "labTaiKhoan";
            this.labTaiKhoan.Size = new System.Drawing.Size(76, 18);
            this.labTaiKhoan.TabIndex = 17;
            this.labTaiKhoan.Text = "Tài Khoản: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(174, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 25);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "ĐĂNG NHẬP";
            // 
            // labQMK
            // 
            this.labQMK.AutoSize = true;
            this.labQMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labQMK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQMK.ForeColor = System.Drawing.Color.Blue;
            this.labQMK.Location = new System.Drawing.Point(119, 156);
            this.labQMK.Name = "labQMK";
            this.labQMK.Size = new System.Drawing.Size(100, 16);
            this.labQMK.TabIndex = 23;
            this.labQMK.Text = "Quên mật khẩu?";
            this.labQMK.Click += new System.EventHandler(this.labQMK_Click);
            // 
            // labDK
            // 
            this.labDK.AutoSize = true;
            this.labDK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labDK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDK.ForeColor = System.Drawing.Color.Blue;
            this.labDK.Location = new System.Drawing.Point(270, 156);
            this.labDK.Name = "labDK";
            this.labDK.Size = new System.Drawing.Size(53, 16);
            this.labDK.TabIndex = 24;
            this.labDK.Text = "Đăng ký";
            this.labDK.Click += new System.EventHandler(this.labDK_Click);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 224);
            this.Controls.Add(this.labDK);
            this.Controls.Add(this.labQMK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.labMatKhau);
            this.Controls.Add(this.labTaiKhoan);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::DoAn.Properties.Resources.icons8_key_2;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labMatKhau;
        private DevExpress.XtraEditors.LabelControl labTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label labQMK;
        private System.Windows.Forms.Label labDK;
    }
}