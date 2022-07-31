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
    public partial class UC_TTTK : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_TTTK()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void UC_TTTK_Load(object sender, EventArgs e)
        {
            picAvatar.Image = Image.FromFile(@"C:\Users\Loc\Pictures\2022-06-29 Loc\Loc.jpg");
            labTen.Text = "Lâm Vĩnh Lộc.";
            labQuyen.Text = "admin.";
            labEmail.Text = "locvuminh8@gmail.com.";
            labelTenTK.Text = "Admin.";
        }
    }
}
