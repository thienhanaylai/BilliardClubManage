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
using BilliardClubManage.BilliardBUS;
using BilliardClubManage.BilliardDAO;
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

        Hoadon hoadon = new Hoadon();
        private void btnMoBan_Click(object sender, EventArgs e)
        {
            DateTime gettime = DateTime.Now;
            string giobd = gettime.ToString("yyyy-MM-dd HH:mm:ss");
            txtGioBD.Text = giobd;
            ban.GioBD = gettime;
            ban.Tinhtrang = true;
            ban.GioKT = null;

             //khi nhan bat dau tinh gio se t ao 1 bill voi trang thai chua thanh toan false
            hoadon.IDhoadon =  "HD" + new unity().getIDhd(); 
            hoadon.Ngaylap = gettime;
            hoadon.Tongtien = 0;
            hoadon.Trangthai = false; //chua thanh toan
            hoadon.IDkh = "";
            Nhanvien nv = frmMain.Nhanvien;
            hoadon.IDnv = nv.IDnv;
            hoadon.Dschitiet = new List<chitiethoadon>();
            chitiethoadon hdban = new chitiethoadon("",hoadon.IDhoadon,"",0,ban.IDban,0);
            hoadon.Dschitiet.Add(hdban);

            try
            {
                if (BanBUS.updateGio(ban)&& HoadonBUS.insertHoaDon(hoadon)&& chitiethoadonBUS.insertCTHD(hdban.Idchitiethoadon,hdban.Idhoadon,hdban.Idhanghoa,hdban.Soluong,hdban.Idban,hdban.Sogiochoi))
                {
                    btnDongBan.Enabled = true;
                    btnThanhToan.Enabled = true;
                    btnMoBan.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            //update bill
            hoadon.Tongtien = int.Parse(txtTongTien.Text);
            hoadon.Trangthai = false; 
            
            chitiethoadon tmep = hoadon.Dschitiet.FirstOrDefault(idban => ban.IDban == idban.Idban);
            if (tmep != null)
            {
                tmep.Sogiochoi = sogiochoi;
            }
            else
            {
                chitiethoadon hdban = new chitiethoadon("", hoadon.IDhoadon, "", 0, ban.IDban, sogiochoi);
                hoadon.Dschitiet.Add(hdban);
            }
            if (BanBUS.updateGio(ban)&&chitiethoadonBUS.updateCTHD(tmep))
            {
                btnDongBan.Enabled = false;
                btnThanhToan.Enabled = true;
                btnMoBan.Enabled = false;
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            List<Hanghoa> dshh = new List<Hanghoa>();
            frmBill thanhtoan = new frmBill(ban,dshh,hoadon);
            thanhtoan.Show();
        }
    }
}
