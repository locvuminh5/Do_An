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
    public partial class DoiMK : DevExpress.XtraEditors.XtraUserControl
    {
        public DoiMK()
        {
            InitializeComponent();
        }

        private void btnHideMKC_Click(object sender, EventArgs e)
        {
            if(txtMKCu.PasswordChar == '\0')
            {
                txtMKCu.PasswordChar = '*';
                btnShowMKC.BringToFront();
            }
        }

        private void btnHideMKM_Click(object sender, EventArgs e)
        {
            if (txtMKMoi.PasswordChar == '\0')
            {
                txtMKMoi.PasswordChar = '*';
                btnShowMKM.BringToFront();
            }
        }

        private void btnShowMKC_Click(object sender, EventArgs e)
        {
            if (txtMKCu.PasswordChar == '*')
            {
                txtMKCu.PasswordChar = '\0';
                btnHideMKC.BringToFront();
            }
        }

        private void btnShowMKM_Click(object sender, EventArgs e)
        {
            if (txtMKMoi.PasswordChar == '*')
            {
                txtMKMoi.PasswordChar = '\0';
                btnHideMKM.BringToFront();
            }
        }
    }
}
