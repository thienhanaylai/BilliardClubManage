using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilliardClubBUS;
using BilliardClubManage.BilliardDTO;
using Sunny.UI;

namespace BilliardClubManage
{
    public partial class frmBan : Form
    {
        int khuvuc = 1;
        public frmBan()
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
            dsBan.Controls.Add(formChild);
            dsBan.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private string convertKhuvuc(int khuvuc)
        {
            string kv;
            switch (khuvuc)
            {
                case 1:
                    kv = "Vip 1";
                    break;
                case 2:
                    kv = "Vip 2";
                    break;
                default:
                    kv = "Vip 1";
                    break ;
            }
            return kv; 
        }
        private void frmBan_Load(object sender, EventArgs e)
        {
            
            List<Ban> ds = BilliardClubBUS.BanBUS.getListBanByKhuVuc(convertKhuvuc(khuvuc));
            OpenFormChild(new frmListBan(ds, khuvuc));
        }

        private void btnK1_Click(object sender, EventArgs e)
        {
            khuvuc = 1;
            List<Ban> ds = BilliardClubBUS.BanBUS.getListBanByKhuVuc(convertKhuvuc(khuvuc));
            OpenFormChild(new frmListBan(ds, khuvuc));
        }

        private void btnK2_Click(object sender, EventArgs e)
        {
            khuvuc = 2;
            List<Ban> ds = BilliardClubBUS.BanBUS.getListBanByKhuVuc(convertKhuvuc(khuvuc));
            OpenFormChild(new frmListBan(ds, khuvuc));
        }
    }
}
