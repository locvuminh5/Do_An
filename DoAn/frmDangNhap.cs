using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnClose_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void messThongBao(String s)
        {
            MessageBox.Show(s, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtTaiKhoan.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "admin")
            {
                Close();
            }
            else if (txtTaiKhoan.Text == "" && txtMatKhau.Text == "")
            {
                messThongBao("Không được để trống mật khẩu và tài khoản.");
            }
            else if (txtTaiKhoan.Text == "")
            {
                messThongBao("Không được để trống tài khoản.");
            }
            else if (txtMatKhau.Text == "")
            {
                messThongBao("Không được để trống mật khẩu.");
            }
            else if (txtTaiKhoan.Text != "admin" || txtMatKhau.Text != "admin")
            {
                messThongBao("Thông tin tài khoản hoặc mật khẩu không chính xác.");
            }
        }

        private void labQMK_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau frm = new frmQuenMatKhau();
            frm.ShowDialog();
        }

        private void labDK_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.ShowDialog();
        }
    }
}