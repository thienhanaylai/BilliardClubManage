using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilliardClubManage.BilliardDAO;
using BilliardClubManage.BilliardDTO;
using Sunny.UI;

namespace BilliardClubManage
{
    public partial class frmOder : Form
    {

        public frmOder()
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
            ListOder.Controls.Add(formChild);
            ListOder.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }



        private UIFlowLayoutPanel createListOder()
        {
            UIFlowLayoutPanel flw = new UIFlowLayoutPanel();
            flw.Size = new Size(800, 840);
            flw.Margin = new Padding(4, 5, 4, 5);
            flw.Padding = new Padding(2);
            flw.TextAlignment = ContentAlignment.MiddleCenter;
            flw.Location = new Point(0, 0);

            return flw;
        }

        private UIPanel createCardPrd(Hanghoa hh, int x, int y)
        {
            UIPanel card = new UIPanel();
            card.Size = new Size(150, 250);
            card.Radius = 15;
            card.TextAlignment = ContentAlignment.MiddleCenter;
            card.Margin = new Padding(10);
            card.Location = new Point(x, y);

            UIPanel img = new UIPanel();
            img.Size = new Size(130, 150);
            img.Location = new Point(10, 10);
            img.Margin = new Padding(10);
            img.MinimumSize = new Size(1, 1);
            img.Radius = 10;
            img.TextAlignment = ContentAlignment.MiddleCenter;
            switch (hh.Donvi)
            {
                case "Lon":
                    img.BackgroundImage = Properties.Resources.lon;
                    break;
                case "Chai":
                    img.BackgroundImage = Properties.Resources.chai;
                    break;
                case "Goi":
                    img.BackgroundImage = Properties.Resources.chai;
                    break;
                default:
                    img.BackgroundImage = Properties.Resources.chai;
                    break;
            }

            UILabel tensp = new UILabel();
            tensp.Font = new Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tensp.BackColor = Color.Transparent;
            tensp.Location = new Point(6, 170);
            tensp.ForeColor = Color.Black;
            tensp.Size = new Size(130, 23);
            tensp.Text = hh.Tenhanghoa;

            UILabel gia = new UILabel();
            gia.Font = new Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gia.ForeColor = Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            gia.BackColor = Color.Transparent;
            gia.Location = new Point(10, 221);
            gia.Size = new Size(132, 19);
            gia.Text = hh.Gia.ToString("#,##0") + " VND";

            card.Controls.Add(img);
            card.Controls.Add(tensp);
            card.Controls.Add(gia);

            card.Click += (s, e) => themsp(hh);
            img.Click += (s, e) => themsp(hh);
            tensp.Click += (s, e) => themsp(hh);
            gia.Click += (s, e) => themsp(hh);

            return card;
        }

        private void ListOder_Load(object sender, EventArgs e)
        {
            List<Hanghoa> ds = new List<Hanghoa>();
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Chai"));
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Lon"));
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Ly"));
            int x = 0, y = 0;
            UIFlowLayoutPanel flw = createListOder();
            foreach (Hanghoa hanghoa in ds)
            {
                flw.Controls.Add(createCardPrd(hanghoa, x + 10, y + 10));
            }
            ListOder.Controls.Clear();
            ListOder.Controls.Add(flw);
        }

        private void btnNuoc_Click(object sender, EventArgs e)
        {
            List<Hanghoa> ds = new List<Hanghoa>();
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Chai"));
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Lon"));
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Ly"));
            int x = 0, y = 0;
            UIFlowLayoutPanel flw = createListOder();
            foreach (Hanghoa hanghoa in ds)
            {
                flw.Controls.Add(createCardPrd(hanghoa, x + 10, y + 10));
            }
            ListOder.Controls.Clear();
            ListOder.Controls.Add(flw);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            List<Hanghoa> ds = new List<Hanghoa>();
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Goi"));
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Dia"));
            int x = 0, y = 0;
            UIFlowLayoutPanel flw = createListOder();
            foreach (Hanghoa hanghoa in ds)
            {
                flw.Controls.Add(createCardPrd(hanghoa, x + 10, y + 10));
            }
            ListOder.Controls.Clear();
            ListOder.Controls.Add(flw);
        }

        // List<Hanghoa> dsOder = new List<Hanghoa>();
        private List<Hanghoa> orderItems = new List<Hanghoa>();
        public void themsp(Hanghoa sp)
        {
            Hanghoa existingItem = orderItems.FirstOrDefault(item => item.IDhanghoa == sp.IDhanghoa);
            if (existingItem != null)
            {
                existingItem.Soluong++;

            }
            else
            {
                Hanghoa newItem = new Hanghoa
                {
                    IDhanghoa = sp.IDhanghoa,
                    Tenhanghoa = sp.Tenhanghoa,
                    Gia = sp.Gia,
                    Donvi = sp.Donvi,
                    Soluong = 1
                };
                orderItems.Add(newItem);
            }
            LoadData();
        }

        private int tongTien(List<Hanghoa> ds)
        {
            int tongTien = 0;
            foreach (Hanghoa n in ds)
            {
                tongTien += n.Gia * (int)n.Soluong;
            }
            return tongTien;
        }
        private void LoadData()

        { dgvOder.AutoGenerateColumns = false;

            dgvOder.DataSource = null;
            dgvOder.DataSource = orderItems;

            txtThanhTien.Text = tongTien(orderItems).ToString("#,##0") + " VND";
        }

        private void btnTangsl_Click(object sender, EventArgs e)
        {
            if (dgvOder.CurrentRow != null)
            {
                string id = dgvOder.CurrentRow.Cells[0].Value.ToString();
                Hanghoa existingItem = orderItems.FirstOrDefault(item => item.IDhanghoa == id);
                if (txtsl.Text != "")
                {
                    existingItem.Soluong += txtsl.IntValue;
                } else
                {
                    existingItem.Soluong++;
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng.");
            }
        }

        private void btnXoahh_Click(object sender, EventArgs e)
        {
            string id = dgvOder.CurrentRow.Cells[0].Value.ToString();
            Hanghoa existingItem = orderItems.FirstOrDefault(item => item.IDhanghoa == id);
            if (existingItem != null)
            {
                orderItems.Remove(existingItem);
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng.");
            }
        }

        private void btnGiamsl_Click(object sender, EventArgs e)
        {
            if (dgvOder.CurrentRow != null)
            {
                string id = dgvOder.CurrentRow.Cells[0].Value.ToString();
                Hanghoa existingItem = orderItems.FirstOrDefault(item => item.IDhanghoa == id);
                if (txtsl.Text != "")
                {
                    existingItem.Soluong -= txtsl.IntValue;
                }
                else
                {
                    existingItem.Soluong--;
                }
                if (existingItem.Soluong <= 0)
                {
                    orderItems.Remove(existingItem);
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng.");
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            orderItems.Clear();
            LoadData();
        }
        Hoadon hd = new Hoadon();
    private void btnThanhtoan_Click(object sender, EventArgs e)
    {
            hd.IDhoadon = "HD" + new unity().getIDhd();
            hd.Dschitiet = new List<chitiethoadon>();
            foreach (Hanghoa n in orderItems)
            {
                chitiethoadon temp = new chitiethoadon();
                temp.Idchitiethoadon = "CT" + new unity().getIDhdct();
                temp.Idban = "";
                temp.Sogiochoi = 0;
                temp.Idhanghoa = n.IDhanghoa;
                temp.Soluong = (int)n.Soluong;
                temp.Idban = "";
                temp.Sogiochoi = 0;
                temp.Idhoadon = hd.IDhoadon;
                hd.Dschitiet.Add(temp);
            }
             frmBill bill = new frmBill(null, orderItems,hd);
           bill.Show();
       
    }

        private void btnChonban_Click(object sender, EventArgs e)
        {
            List<Ban> lista = BilliardClubBUS.BanBUS.getListBan();
            frmListBan listall = new frmListBan(lista, 1);
            listall.ShowDialog();
        }
    }

}
