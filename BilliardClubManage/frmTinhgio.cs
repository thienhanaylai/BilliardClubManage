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
        private Action onDataUpdated;
        public frmTinhgio(Ban ban, Action onDataUpdated)
        {
            InitializeComponent();
            this.ban = ban;
            this.onDataUpdated = onDataUpdated;
        }

        private void uiPanel1_Load(object sender, EventArgs e)
        {
            if (ban.Tinhtrang)
            {
                imgBan.BackgroundImage = Properties.Resources.ban1;
                txtTenBan.Text = ban.Tenban;
                txtId.Text = ban.IDban;
                txtKhuVuc.Text = ban.Khuvuc;
                txtLoaiBan.Text = ban.Loaiban;
                txtGioBD.Text = ((DateTime)ban.GioBD).ToString("yyyy-MM-dd HH:mm:ss");
                txtGioKT.Text = "";
                btnMoBan.Enabled = false;
                btnThanhToan.Enabled = false;
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
                if (txtGioKT.Text  != "")
                {
                    btnThanhToan.Enabled = true;
                } else
                {
                    btnThanhToan.Enabled = false;
                }
                

            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            onDataUpdated?.Invoke();
        }


        private void btnMoBan_Click(object sender, EventArgs e)
        {
            DateTime gettime = DateTime.Now;
            string giobd = gettime.ToString("yyyy-MM-dd HH:mm:ss");
            txtGioBD.Text = giobd;
            ban.GioBD = gettime;
            ban.Tinhtrang = true;
            ban.GioKT = null;
            Hoadon hoadon = new Hoadon();
            //khi nhan bat dau tinh gio se t ao 1 bill voi trang thai chua thanh toan false
            hoadon.IDhoadon = "HD" + new unity().getIDhd();
            hoadon.Ngaylap = gettime;
            hoadon.Tongtien = 0;
            hoadon.Trangthai = false; //chua thanh toan
            hoadon.IDkh = "";
            Nhanvien nv = frmMain.Nhanvien;
            hoadon.IDnv = nv.IDnv;
            hoadon.Dschitiet = new List<chitiethoadon>();
            string idcthd = "CT" + new unity().getIDhdct();
            chitiethoadon hdban = new chitiethoadon(idcthd, hoadon.IDhoadon, "", 0, ban.IDban, 0);
            hoadon.Dschitiet.Add(hdban);

            try
            {
                if (BanBUS.updateGio(ban) && HoadonBUS.insertHoaDon(hoadon) && chitiethoadonBUS.insertCTHD(hdban))
                {
                    btnDongBan.Enabled = true;
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
            txtGioKT.Text = giokt;
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
            Hoadon hd = new Hoadon();
            hd = HoadonBUS.gethoadonbyIDban(ban.IDban);
            hd.Tongtien = sogiochoi * ban.Dongia;
            hd.Trangthai = false;
            hd.Dschitiet = chitiethoadonBUS.getDsSanphamByIDHoadon(hd.IDhoadon);
            chitiethoadon tmep = hd.Dschitiet.FirstOrDefault(idban => ban.IDban == idban.Idban);
            if (tmep != null)
            {
                tmep.Sogiochoi = sogiochoi;
            }
            if (BanBUS.updateGio(ban) && chitiethoadonBUS.updateCTHD(tmep))
            {
                btnDongBan.Enabled = false;
                btnThanhToan.Enabled = true;
                btnMoBan.Enabled = false;
            }

        }

        private void resetBan()
        {
            ban.Tinhtrang= false;
            ban.GioBD = null;
            ban.GioKT = null;
            txtGioBD.Text = "";
            txtGioKT.Text = "";
            txtGioChoi.Text = "";
            txtTongTien.Text = "";
            btnDongBan.Enabled = false;
            btnThanhToan.Enabled = false;
            btnMoBan.Enabled = true;
            BanBUS.updateBan(ban);

        }

        private Hanghoa convertCTHDtoHangHoa(chitiethoadon cthd)
        {
            Hanghoa temp = HanghoaBUS.getHHbyId(cthd.Idhanghoa);
            temp.Soluong = cthd.Soluong;
            temp.IDhanghoa = cthd.Idhanghoa;
            return temp;
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            List<Hanghoa> dshh = new List<Hanghoa>();
            Hoadon hoadon = new Hoadon();
            hoadon = HoadonBUS.gethoadonbyIDban(ban.IDban);
            hoadon.Dschitiet = chitiethoadonBUS.getDsSanphamByIDHoadon(hoadon.IDhoadon);
            foreach (chitiethoadon n in hoadon.Dschitiet) {
                Hanghoa hanghoa = new Hanghoa();
                hanghoa = convertCTHDtoHangHoa(n);
                dshh.Add(hanghoa);
            }
            frmBill thanhtoan = new frmBill(ban, dshh, hoadon,1);
            thanhtoan.Show();
            resetBan();
        }
    }
}
