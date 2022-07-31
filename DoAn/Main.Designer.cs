namespace DoAn
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.formMainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accTaiKhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accThongTinTK = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accDoiMatKhau = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.proHangHoa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.proDanhMuc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.proThietLapGia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tranGiaoDich = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tranDatHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tranHoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tranNhapHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.partDoiTac = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.partKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.partNhaCungCap = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sysHeThong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sysTimKiem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sysThoat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.labViTri = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // formMainContainer
            // 
            this.formMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formMainContainer.Location = new System.Drawing.Point(260, 31);
            this.formMainContainer.Name = "formMainContainer";
            this.formMainContainer.Size = new System.Drawing.Size(839, 581);
            this.formMainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.Group.Default.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Default.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Hovered.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Default.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Default.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accTaiKhoan,
            this.proHangHoa,
            this.tranGiaoDich,
            this.partDoiTac,
            this.sysHeThong});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 581);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accTaiKhoan
            // 
            this.accTaiKhoan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accThongTinTK,
            this.accDoiMatKhau});
            this.accTaiKhoan.Expanded = true;
            this.accTaiKhoan.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accTaiKhoan.Name = "accTaiKhoan";
            this.accTaiKhoan.Text = "Tài Khoản";
            // 
            // accThongTinTK
            // 
            this.accThongTinTK.ImageOptions.Image = global::DoAn.Properties.Resources.icons8_info_1;
            this.accThongTinTK.Name = "accThongTinTK";
            this.accThongTinTK.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accThongTinTK.Text = "Thông Tin Tài Khoản";
            this.accThongTinTK.Click += new System.EventHandler(this.accDangNhap_Click);
            // 
            // accDoiMatKhau
            // 
            this.accDoiMatKhau.ImageOptions.Image = global::DoAn.Properties.Resources.icons8_Forgot_Password_16px;
            this.accDoiMatKhau.Name = "accDoiMatKhau";
            this.accDoiMatKhau.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.accDoiMatKhau.Click += new System.EventHandler(this.accDoiMatKhau_Click);
            // 
            // proHangHoa
            // 
            this.proHangHoa.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.proDanhMuc,
            this.proThietLapGia});
            this.proHangHoa.Expanded = true;
            this.proHangHoa.Name = "proHangHoa";
            this.proHangHoa.Text = "Hàng Hóa";
            this.proHangHoa.Click += new System.EventHandler(this.proHangHoa_Click);
            // 
            // proDanhMuc
            // 
            this.proDanhMuc.ImageOptions.Image = global::DoAn.Properties.Resources.icons8_sorting_16px;
            this.proDanhMuc.Name = "proDanhMuc";
            this.proDanhMuc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.proDanhMuc.Text = "Danh Mục";
            this.proDanhMuc.Click += new System.EventHandler(this.proDanhMuc_Click);
            // 
            // proThietLapGia
            // 
            this.proThietLapGia.ImageOptions.Image = global::DoAn.Properties.Resources.icons8_price_16px;
            this.proThietLapGia.Name = "proThietLapGia";
            this.proThietLapGia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.proThietLapGia.Text = "Thiết Lập Giá";
            this.proThietLapGia.Click += new System.EventHandler(this.proThietLapGia_Click);
            // 
            // tranGiaoDich
            // 
            this.tranGiaoDich.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.tranDatHang,
            this.tranHoaDon,
            this.tranNhapHang});
            this.tranGiaoDich.Expanded = true;
            this.tranGiaoDich.Name = "tranGiaoDich";
            this.tranGiaoDich.Text = "Giao Dịch";
            // 
            // tranDatHang
            // 
            this.tranDatHang.ImageOptions.Image = global::DoAn.Properties.Resources.icons8_purchase_order_16px;
            this.tranDatHang.Name = "tranDatHang";
            this.tranDatHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.tranDatHang.Text = "Đặt Hàng";
            // 
            // tranHoaDon
            // 
            this.tranHoaDon.ImageOptions.Image = global::DoAn.Properties.Resources.icons8_receipt_16px;
            this.tranHoaDon.Name = "tranHoaDon";
            this.tranHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.tranHoaDon.Text = "Hóa Đơn";
            this.tranHoaDon.Click += new System.EventHandler(this.tranHoaDon_Click);
            // 
            // tranNhapHang
            // 
            this.tranNhapHang.ImageOptions.Image = global::DoAn.Properties.Resources.icons8_report_16px;
            this.tranNhapHang.Name = "tranNhapHang";
            this.tranNhapHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.tranNhapHang.Text = "Nhập Hàng";
            // 
            // partDoiTac
            // 
            this.partDoiTac.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.partKhachHang,
            this.partNhaCungCap});
            this.partDoiTac.Expanded = true;
            this.partDoiTac.Name = "partDoiTac";
            this.partDoiTac.Text = "Đối tác";
            // 
            // partKhachHang
            // 
            this.partKhachHang.ImageOptions.Image = global::DoAn.Properties.Resources.icons8_customer_16px;
            this.partKhachHang.Name = "partKhachHang";
            this.partKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.partKhachHang.Text = "Khách Hàng";
            // 
            // partNhaCungCap
            // 
            this.partNhaCungCap.ImageOptions.Image = global::DoAn.Properties.Resources.icons8_supplier_16px;
            this.partNhaCungCap.Name = "partNhaCungCap";
            this.partNhaCungCap.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.partNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // sysHeThong
            // 
            this.sysHeThong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.sysTimKiem,
            this.sysThoat});
            this.sysHeThong.Expanded = true;
            this.sysHeThong.Name = "sysHeThong";
            this.sysHeThong.Text = "Hệ Thống";
            // 
            // sysTimKiem
            // 
            this.sysTimKiem.ImageOptions.Image = global::DoAn.Properties.Resources.icons8_search_16px;
            this.sysTimKiem.Name = "sysTimKiem";
            this.sysTimKiem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sysTimKiem.Text = "Tìm Kiếm";
            // 
            // sysThoat
            // 
            this.sysThoat.ImageOptions.Image = global::DoAn.Properties.Resources.icons8_cancel_16px;
            this.sysThoat.Name = "sysThoat";
            this.sysThoat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sysThoat.Text = "Thoát";
            this.sysThoat.Click += new System.EventHandler(this.sysThoat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.labViTri});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1099, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.labViTri);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.labViTri});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // labViTri
            // 
            this.labViTri.Caption = "Vị trí";
            this.labViTri.Id = 0;
            this.labViTri.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labViTri.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labViTri.ItemAppearance.Normal.Options.UseFont = true;
            this.labViTri.ItemAppearance.Normal.Options.UseForeColor = true;
            this.labViTri.Name = "labViTri";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 612);
            this.ControlContainer = this.formMainContainer;
            this.Controls.Add(this.formMainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::DoAn.Properties.Resources.icons8_online_store;
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer formMainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accTaiKhoan;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accThongTinTK;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accDoiMatKhau;
        private DevExpress.XtraBars.Navigation.AccordionControlElement proHangHoa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement proDanhMuc;
        private DevExpress.XtraBars.Navigation.AccordionControlElement proThietLapGia;
        private DevExpress.XtraBars.Navigation.AccordionControlElement tranGiaoDich;
        private DevExpress.XtraBars.Navigation.AccordionControlElement tranDatHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement tranHoaDon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement tranNhapHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement partDoiTac;
        private DevExpress.XtraBars.Navigation.AccordionControlElement partKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement partNhaCungCap;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sysHeThong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sysTimKiem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sysThoat;
        private DevExpress.XtraBars.BarStaticItem labViTri;
    }
}

