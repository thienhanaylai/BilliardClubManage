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
using Sunny.UI;

namespace BilliardClubManage
{
    public partial class frmBill : Form
    {
        Ban ban;
        List<Hanghoa> dshh;
        Hoadon hd;
        int mode; //0 la hanh toan tu order 1 la thanh toan từ list ban

        public frmBill(Ban ban,List<Hanghoa> ds, Hoadon hd, int mode)
        {
            InitializeComponent();
            this.ban = ban;
            this.dshh = ds;
            this.hd = hd;
            this.mode = mode;
        }


        private void creInfohh(Hanghoa hh,int y)
        {
            UILabel ten = new UILabel();
            ten.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ten.Location = new Point(60, y);
            ten.BackColor = Color.Transparent;
            ten.AutoSize = true;
            ten.TextAlign = ContentAlignment.MiddleCenter;
            ten.Text = hh.Tenhanghoa;

            UILabel sl = new UILabel();
            sl.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sl.Location = new Point(377, y);
            sl.AutoSize = true;
            sl.BackColor = Color.Transparent;
            sl.TextAlign = ContentAlignment.MiddleCenter;
            sl.Text = hh.Soluong.ToString();

            UILabel gia = new UILabel();
            gia.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gia.Location = new Point(560, y);
            gia.AutoSize = true;
            gia.BackColor = Color.Transparent;
            gia.TextAlign = ContentAlignment.MiddleCenter;
            gia.Text = hh.Gia.ToString("#,##0");

            dsOder.Controls.Add(ten);
            dsOder.Controls.Add(sl);
            dsOder.Controls.Add(gia);

        }

        private void creInfoban(Ban ban,int y)
        {
            UILabel ten = new UILabel();
            ten.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ten.Location = new Point(60, y);
            ten.AutoSize = true;
            ten.BackColor = Color.Transparent;
            ten.TextAlign = ContentAlignment.MiddleCenter;
            ten.Text = ban.Tenban;

            UILabel sl = new UILabel();
            sl.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sl.Location = new Point(377, y);
            sl.AutoSize = true;
            sl.BackColor = Color.Transparent;
            sl.TextAlign = ContentAlignment.MiddleCenter;
            int sogiochoi = 0;
            TimeSpan time = (DateTime)ban.GioKT - (DateTime)ban.GioBD;
            sogiochoi = (int)time.TotalHours;
            sl.Text = sogiochoi.ToString();

            UILabel gia = new UILabel();
            gia.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gia.Location = new Point(560, y);
            gia.AutoSize = true;
            gia.BackColor = Color.Transparent;
            gia.TextAlign = ContentAlignment.MiddleCenter;
            gia.Text = (sogiochoi * ban.Dongia).ToString("#,##0");

            dsOder.Controls.Add(ten);
            dsOder.Controls.Add(sl);
            dsOder.Controls.Add(gia);
        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            int tongtien = 0;
        private void frmBill_Load(object sender, EventArgs e)
        {
            int y = 50;
            
            foreach(Hanghoa n in dshh)
            {
                if (n.Soluong > 0)
                {
                creInfohh(n, y+=30);
                tongtien += (int)n.Soluong * n.Gia;
                }
            }
            if(ban != null)
            {
            creInfoban(ban, y += 30);
            TimeSpan time = (DateTime)ban.GioKT - (DateTime)ban.GioBD;
            int sogiochoi = 0;
             sogiochoi = (int)time.TotalHours;
            tongtien += sogiochoi * ban.Dongia;
            }
            
            txtThanhTien.Text = tongtien.ToString("#,##0")+ " VND";
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {   
            hd.Tongtien = tongtien;
            hd.Ngaylap = DateTime.Now;
            hd.Trangthai = true;
            hd.IDkh = "";
            hd.IDnv = frmMain.Nhanvien.IDnv;
            //thieeus ham cap nhat chi tiet hoa don cho tung san pham torng hoa don
            int flag = 0;
            if (mode == 0) {
                if (HoadonBUS.insertHoaDon(hd)) flag = 1;
            } else if(mode == 1)
            {
                if(HoadonBUS.updateHoadon(hd)) flag =1;
            }
            if (flag == 1)
            {
                foreach (chitiethoadon n in hd.Dschitiet)
                {
                    chitiethoadonBUS.insertCTHD(n);
                }
                MessageBox.Show("Thanh toan thanh cong !");
                this.Close();
            }
        }
    }
}
