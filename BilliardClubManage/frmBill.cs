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
using Sunny.UI;

namespace BilliardClubManage
{
    public partial class frmBill : Form
    {
        Ban ban;
        List<Hanghoa> dshh;
        public frmBill(Ban ban,List<Hanghoa> ds)
        {
            InitializeComponent();
            this.ban = ban;
            this.dshh = ds;
        }


        private void creInfohh(Hanghoa hh,int y)
        {
            UILabel ten = new UILabel();
            ten.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ten.Location = new Point(60, 50+y);
            ten.BackColor = Color.Transparent;
            ten.AutoSize = true;
            ten.TextAlign = ContentAlignment.MiddleCenter;
            ten.Text = hh.Tenhanghoa;

            UILabel sl = new UILabel();
            sl.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sl.Location = new Point(377, 50 + y);
            sl.AutoSize = true;
            sl.BackColor = Color.Transparent;
            sl.TextAlign = ContentAlignment.MiddleCenter;
            sl.Text = hh.Soluong.ToString();

            UILabel gia = new UILabel();
            gia.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gia.Location = new Point(560, 50 + y);
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
            ten.Location = new Point(60, 50 + y);
            ten.AutoSize = true;
            ten.BackColor = Color.Transparent;
            ten.TextAlign = ContentAlignment.MiddleCenter;
            ten.Text = ban.Tenban;

            UILabel sl = new UILabel();
            sl.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sl.Location = new Point(377, 50 + y);
            sl.AutoSize = true;
            sl.BackColor = Color.Transparent;
            sl.TextAlign = ContentAlignment.MiddleCenter;
            int sogiochoi = 0;
            TimeSpan time = (DateTime)ban.GioKT - (DateTime)ban.GioBD;
            sogiochoi = (int)time.TotalHours;
            sl.Text = sogiochoi.ToString();

            UILabel gia = new UILabel();
            gia.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gia.Location = new Point(560, 50 + y);
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

        private void frmBill_Load(object sender, EventArgs e)
        {
            int y = 0;
            int tongtien = 0;
            foreach(Hanghoa n in dshh)
            {
                creInfohh(n, 10);
                tongtien += (int)n.Soluong * n.Gia;
            }
            creInfoban(ban, 10);
            TimeSpan time = (DateTime)ban.GioKT - (DateTime)ban.GioBD;
            int sogiochoi = 0;
             sogiochoi = (int)time.TotalHours;
            tongtien += sogiochoi * ban.Dongia;
            txtThanhTien.Text = tongtien.ToString("#,##0")+ " VND";
        }
    }
}
