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
                txtGioBD.Text = ((DateTime)ban.GioBD).ToString("yyyy-MM-dd HH:mm:ss");
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
                if (ban.GioBD == null)
                {
                    txtGioBD.Text = "";
                }
                else
                {
                    txtGioBD.Text = ((DateTime)ban.GioBD).ToString("yyyy-MM-dd HH:mm:ss");
                    btnMoBan.Enabled = false;
                }
                if (ban.GioKT == null)
                {
                    txtGioKT.Text = "";
                }
                else
                {
                    txtGioKT.Text = ((DateTime)ban.GioKT).ToString("yyyy-MM-dd HH:mm:ss");
                    btnMoBan.Enabled = false;
                    int sogiochoi = 0;
                    TimeSpan time = (DateTime)ban.GioKT - (DateTime)ban.GioBD;
                    sogiochoi = (int)time.TotalHours;
                    txtGioChoi.Text = sogiochoi.ToString();
                    txtTongTien.Text = (sogiochoi * ban.Dongia).ToString("#,##0") + " VND";
                }
                btnDongBan.Enabled = false;
                btnThanhToan.Enabled = true;
                
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoBan_Click(object sender, EventArgs e)
        {
            DateTime gettime = DateTime.Now;
            string giobd = gettime.ToString("yyyy-MM-dd HH:mm:ss");
            txtGioBD.Text = giobd;
            ban.GioBD = gettime;
            ban.Tinhtrang = true;
            ban.GioKT = null;
            if (BanBUS.updateGio(ban))
            {
                btnDongBan.Enabled = true;
                btnThanhToan.Enabled = true;
                btnMoBan.Enabled = false;
            }
        }

        private void btnDongBan_Click(object sender, EventArgs e)
        {
            DateTime gettime = DateTime.Now;
            string giokt = gettime.ToString("yyyy-MM-dd HH:mm:ss");
            txtGioKT.Text= giokt;
            ban.Tinhtrang = false;
            ban.GioKT = gettime;
            int sogiochoi = 0;
            if (ban.GioBD != null)
            {
                TimeSpan time = (DateTime)ban.GioKT - (DateTime)ban.GioBD;
                sogiochoi = (int)time.TotalHours;
            }
            txtGioChoi.Text = sogiochoi.ToString();
            txtTongTien.Text = (sogiochoi * ban.Dongia).ToString("#,##0") + " VND";
            if (BanBUS.updateGio(ban))
            {
                btnDongBan.Enabled = false;
                btnThanhToan.Enabled = true;
                btnMoBan.Enabled = false;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            List<Hanghoa> dshh = new List<Hanghoa>();
            frmBill thanhtoan = new frmBill(ban,dshh);
            thanhtoan.Show();
        }
    }
}
