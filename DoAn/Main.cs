using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        UC_TTTK uc_ThongTin;
        UC_DanhMuc uc_DanhMuc;
        DoiMK uc_DoiMK;

        public frmMain()
        {
            frmDangNhap a = new frmDangNhap();
            a.ShowDialog();
            InitializeComponent();
            uc_ThongTin = new UC_TTTK();
            addUserControl(uc_ThongTin);
            labViTri.Caption = accThongTinTK.Text;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            formMainContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void proHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void tranHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void sysThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accDangNhap_Click(object sender, EventArgs e)
        {
            if (uc_ThongTin == null)
            {
                uc_ThongTin = new UC_TTTK();
                addUserControl(uc_ThongTin);
            }
            else
            {
                uc_ThongTin.BringToFront();
            }
            labViTri.Caption = accThongTinTK.Text;
        }

        private void accDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (uc_DoiMK == null)
            {
                uc_DoiMK = new DoiMK();
                addUserControl(uc_DoiMK);
            }
            else
            {
                uc_DoiMK.BringToFront();
            }
            labViTri.Caption = "";
        }

        private void proDanhMuc_Click(object sender, EventArgs e)
        {
            if (uc_DanhMuc == null)
            {
                uc_DanhMuc = new UC_DanhMuc();
                addUserControl(uc_DanhMuc);
            }
            else
            {
                uc_DanhMuc.BringToFront();
            }
            labViTri.Caption = "Danh mục hàng hóa";
        }

        private void proThietLapGia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được hoàn thiện.\nMong bạn thông cảm cho sự bất tiện này.", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uc_ThongTin.BringToFront();
        }
    }
}
