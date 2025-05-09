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
    public partial class frmTinhgio : Form
    {

        Ban ban;
        public frmTinhgio(Ban ban)
        {
            InitializeComponent();
            this.ban = ban;
        }

        private void uiPanel1_Load(object sender, EventArgs e)
        {
            if(ban.Tinhtrang)
            {
                imgBan.BackgroundImage = Properties.Resources.ban1;
                txtTenBan.Text = ban.Tenban;
                txtId.Text = ban.IDban;
                txtKhuVuc.Text = ban.Khuvuc;
                txtLoaiBan.Text = ban.Loaiban;
                txtGioBD.Text = ban.GioBD.ToString();
                txtGioKT.Text = "";
                btnMoBan.Enabled = false;
            }
            else
            {
                imgBan.BackgroundImage = Properties.Resources.ban0;
                txtTenBan.Text = ban.Tenban;
                txtId.Text = ban.IDban;
                txtKhuVuc.Text = ban.Khuvuc;
                txtLoaiBan.Text = ban.Loaiban;
                txtGioBD.Text = ban.GioBD.ToString();
                txtGioKT.Text = "";
                btnDongBan.Enabled = false;
                btnThanhToan.Enabled = false;
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
