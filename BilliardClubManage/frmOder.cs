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
    public partial class frmOder : Form
    {
        int type = 0;
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

        private void ListOder_Load(object sender, EventArgs e)
        {
            List<Hanghoa> ds = new List<Hanghoa>();
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Chai"));
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Lon"));
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Ly"));
            OpenFormChild(new frmListOder(ds, type));
        }

        private void btnNuoc_Click(object sender, EventArgs e)
        {
            type = 0;
            List<Hanghoa> ds = new List<Hanghoa>();
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Chai"));
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Lon"));
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Ly"));
            OpenFormChild(new frmListOder(ds, type));
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            type = 1;
            List<Hanghoa> ds = new List<Hanghoa>();
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Goi"));
            ds.AddRange(BilliardClubBUS.HanghoaBUS.getListHhByLoai("Dia"));
            OpenFormChild(new frmListOder(ds, type));
        }


    }
}
