using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardClubManage
{
    public partial class frmQuanly : Form
    {
        public frmQuanly()
        {
            InitializeComponent();
        }
        private Form crtFormChild;

        private void OpenFormChild(Form formChild)
        {
            if (crtFormChild != null)
            {
                crtFormChild.Close();
            }
            crtFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            frmChild.Controls.Add(formChild);
            frmChild.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }
        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmQuanlyDoanhthu());
        }

        private void btnHanghoa_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmQuanlyKho());
        }

        private void btnNhansu_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmQuanlyNhansu());
        }

        private void btnQlban_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmQuanlyban());
        }
    }
}
