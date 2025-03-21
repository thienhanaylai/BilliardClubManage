using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubManage
{
    public partial class frmMain : Form
    {
        private static Nhanvien nhanvien;
        public frmMain(Nhanvien nv)
        {
            InitializeComponent();
            nhanvien =  nv;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            FrmChild.Controls.Add(formChild);
            FrmChild.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }
        

        private void btnBan_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmBan());
        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmOder());
        }

        private void btnQuanly_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmQuanly());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnBan.Selected = true;
            OpenFormChild(new frmBan());
            lbTennv.Text = nhanvien.Hoten;
           lbChucvu.Text = nhanvien.Chucvu;
        }
    }
}
