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
    public partial class frmQuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi mật khẩu mới vào số điện thoại của bạn!!!");
            Close();
        }
    }
}