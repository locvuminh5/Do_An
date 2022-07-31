namespace DoAn
{
    partial class frmDangKy
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
            this.btnDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.labMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.labTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.EditValueChanged += new System.EventHandler(this.btnClose_EditValueChanged);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Appearance.Options.UseFont = true;
            this.btnDangKy.Location = new System.Drawing.Point(175, 183);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(97, 27);
            this.btnDangKy.TabIndex = 14;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(188, 137);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(145, 21);
            this.txtMatKhau.TabIndex = 13;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(188, 100);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(145, 21);
            this.txtTaiKhoan.TabIndex = 12;
            // 
            // labMatKhau
            // 
            this.labMatKhau.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMatKhau.Appearance.Options.UseFont = true;
            this.labMatKhau.Location = new System.Drawing.Point(106, 138);
            this.labMatKhau.Name = "labMatKhau";
            this.labMatKhau.Size = new System.Drawing.Size(73, 18);
            this.labMatKhau.TabIndex = 11;
            this.labMatKhau.Text = "Mật Khẩu: ";
            // 
            // labTaiKhoan
            // 
            this.labTaiKhoan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTaiKhoan.Appearance.Options.UseFont = true;
            this.labTaiKhoan.Location = new System.Drawing.Point(106, 102);
            this.labTaiKhoan.Name = "labTaiKhoan";
            this.labTaiKhoan.Size = new System.Drawing.Size(76, 18);
            this.labTaiKhoan.TabIndex = 10;
            this.labTaiKhoan.Text = "Tài Khoản: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(166, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 25);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "ĐĂNG KÝ";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 256);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.labMatKhau);
            this.Controls.Add(this.labTaiKhoan);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangKy";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDangKy;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labMatKhau;
        private DevExpress.XtraEditors.LabelControl labTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}