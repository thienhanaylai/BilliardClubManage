using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardClubManage
{
    public partial class frmInfoNv : Form
    {
        int type; //0 la them 1 la sua
        public frmInfoNv(int type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void frmAddnv_Load(object sender, EventArgs e)
        {

        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            string id;
            string ho;
            string ten;
            DateTime ngaysinh;
            bool gioitinh;
            string chucvu;
            string matkhau;

            id = txtID.Text;
            ho = txtHo.Text;
            ten = txtTen.Text;
            ngaysinh = dtpBirthdate.Value;
            if(rdNam.Checked)
            {
                gioitinh = false;
            }
            else
            {
                gioitinh = true;
            }
            switch (slChucvu.Text)
            {
                case "Quản lý":
                    chucvu = "admin";
                    break;
                case "Nhân viên":
                    chucvu = "staff";
                    break;
                default:
                    MessageBox.Show("Chưa chọn chức vụ");
                    chucvu= "staff";
                    break;
            }
            if (txtPw.Text != txtRePw.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
            }
            else
            {
                matkhau = txtPw.Text;
                if (type == 0)
                {
                   if( BilliardClubBUS.NhanvienBUS.insertNV(id, ho, ten, ngaysinh, gioitinh, chucvu, matkhau)) 
                    { 
                        MessageBox.Show("Thêm nhân viên thành công");
                        this.Update();
                    }
                   else { MessageBox.Show("Thêm nhân viên thất bại"); }

                }
                else { }
                //còn thiếu hàm update nhân viên
            }
        }
    }
}
