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
    public partial class frmLogin : Form
    {
        private static Nhanvien Nhanvien;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtID.Focus();
            txtID.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string id = txtID.Text.Trim();
            string pw = txtPw.Text.Trim();
            if (BilliardClubBUS.NhanvienBUS.validateNV(id, pw))
            {
                Nhanvien = BilliardClubBUS.NhanvienBUS.getNVbyId(id);
                frmMain main = new frmMain(Nhanvien);
                this.Hide();
                main.ShowDialog();
                this.Show();
                txtID.Clear();
                txtPw.Clear();
            } else
            {
                string message = "Sai tên đăng nhập hoặc mật khẩu";
                MessageBox.Show(message);
            }


        }
    }
}
