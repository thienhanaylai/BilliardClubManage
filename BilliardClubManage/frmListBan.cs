using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using BilliardClubManage.BilliardBUS;
using BilliardClubManage.BilliardDAO;
using BilliardClubManage.BilliardDTO;
using BilliardClubManage.Properties;
using Sunny.UI;

namespace BilliardClubManage
{
    public partial class frmListBan : Form
    {

        private List<Ban> ds;
        int mode;
        List<Hanghoa> dshh;
        public frmListBan(List<Ban> ds,List<Hanghoa> dshh, int mode)
        {
            InitializeComponent();
            this.ds = ds;
            this.mode = mode;
            this.dshh = dshh;
        }


        private UIPanel createCard(Ban ban,int x,int y)
        {
            UIPanel card = new UIPanel();
            card.Size = new Size(180, 240);
            card.Radius = 10;
            card.TextAlignment = ContentAlignment.MiddleCenter;
            card.Margin = new Padding(10);
            card.FillColor = Color.FromArgb(255, 255, 255);
            card.Location = new Point(x,y);

            UIPanel img = new UIPanel();
            img.Size = new Size(160, 172);
            img.Location = new Point(10, 10);
            if (ban.Tinhtrang)
                img.BackgroundImage = Properties.Resources.ban1;
            else
                img.BackgroundImage = Properties.Resources.ban0;
            img.BackgroundImageLayout = ImageLayout.Zoom;
            img.Margin = new Padding(10);
            img.MinimumSize = new Size(1, 1);
            img.TextAlignment = ContentAlignment.MiddleCenter;

            UILabel ten = new UILabel();
            ten.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point,((byte)(0)));
            ten.BackColor = Color.Transparent;
            ten.Location = new Point(6, 192);
            ten.Size = new Size(104, 23);
            ten.Text = ban.Tenban;

            card.Controls.Add(img);
            card.Controls.Add(ten);
            if(mode == 0)
            {
            card.Click += (s, e) => openBan(ban);
            img.Click += (s, e) => openBan(ban);
            ten.Click += (s, e) => openBan(ban);
            } else if(mode ==1)
            {
                card.Click += (s, e) => themvaobill(ban,dshh);
                img.Click += (s, e) => themvaobill(ban, dshh);
                ten.Click += (s, e) => themvaobill(ban, dshh);
            }

            return card;
        }
        //ham filter sap xep danh sach ban theo trnag thai ban trong va ban dang su dung
        public List<Ban> fillterList(List<Ban> ds)
        {
            List<Ban> LstFilltered = new List<Ban>();
            foreach (Ban n in ds)
            {
                if (n.Tinhtrang == true)
                {
                    LstFilltered.Add(n);
                }
            }
            foreach (Ban n in ds)
            {
                if (n.Tinhtrang == false)
                {
                    LstFilltered.Add(n);
                }
            }
            return LstFilltered;

        }

        private void openBan(Ban ban)
        {
            frmTinhgio f = new frmTinhgio(ban);
            f.Show();
        }

        private void themvaobill(Ban ban,List<Hanghoa> dshh)
        {
            foreach(Hanghoa h in dshh)
            {
                chitiethoadon chitiethoadon= new chitiethoadon();
                chitiethoadon.Idhanghoa = h.IDhanghoa;
                chitiethoadon.Soluong = (int)h.Soluong;
                chitiethoadon.Idhoadon = HoadonBUS.gethoadonbyIDban(ban.IDban).IDhoadon;
                chitiethoadon.Idchitiethoadon = "CT" + new unity().getIDhdct();
                chitiethoadonBUS.insertCTHD(chitiethoadon);
            }
            this.Close();
        }

        private void uiFlowLayoutPanel1_Load(object sender, EventArgs e)
        {
            int x=0, y=0;
            List<Ban> list = fillterList(this.ds);
                foreach (Ban n in list)
                {
                    this.uiFlowLayoutPanel1.Controls.Add(createCard(n, x + 10, y + 10));
                }

        }
    }
}
