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
    public partial class frmListOder : Form
    {
        private List<Hanghoa> ds;
        int type; //0 la nuoc 1 la thuc an 2 .....
        public frmListOder(List<Hanghoa> ds,int type)
        {
            InitializeComponent();
            this.type = type;
            this.ds = ds;
        }

        private UIPanel createCardPrd(Hanghoa hh,int x, int y)
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
                case "Ly":
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
            tensp.Size = new Size(104, 23);
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
           // card.Click += (s, e) => themsp(); //click vao se them 1 san pham sao from oder
           // img.Click += (s, e) => themsp();
           // tensp.Click += (s, e) => themsp();
           // gia.Click += (s, e) => themsp();

            
            return card;
        }

        private void uiFlowLayoutPanel1_Load(object sender, EventArgs e)
        {
            int x = 0, y =0;
            List<Hanghoa> listPrd = this.ds;
            foreach (Hanghoa hanghoa in listPrd)
            {
                this.uiFlowLayoutPanel1.Controls.Add(createCardPrd(hanghoa, x+10, y+10));
            }
        }
    }
}
