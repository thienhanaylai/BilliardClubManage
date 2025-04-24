using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using BilliardClubManage.BilliardDTO;
using Sunny.UI;

namespace BilliardClubManage
{
    public partial class frmInfoNv : Form
    {
        int type; //0 la them 1 la sua
        Nhanvien nv;
        private Action onDataUpdated; // delegate khi update du lieu goi ham event tu form cha de cap nhat lai du lieu
        public frmInfoNv(int type, Nhanvien nv, Action onDataUpdated)
        {
            InitializeComponent();
            this.type = type;
            this.nv = nv;
            this.onDataUpdated = onDataUpdated;
        }

        private void frmAddnv_Load(object sender, EventArgs e)
        {
            if (type == 1)
            {
                txtID.Text = nv.IDnv;
                string[] tach = nv.Hoten.Trim().Split(' ');

                if (tach.Length == 1)
                {
                    txtHo.Text = tach[0];
                }
                else
                {
                    txtHo.Text = tach[0];
                    txtTen.Text = string.Join(" ", tach.Skip(1));
                }
                dtpBirthdate.Value = nv.Ngaysinh;
                if (nv.Gioitinh == false)
                {
                    rdNu.Checked = true;
                }
                else
                {
                    rdNam.Checked = true;
                }
                switch (nv.Chucvu)
                {
                    case "admin":
                        slChucvu.Text = "Quản lý";
                        break;
                    case "staff":
                        slChucvu.Text = "Nhân viên";
                        break;
                    default:
                        MessageBox.Show("Chưa chọn chức vụ");
                        slChucvu.Text = "";
                        break;
                }
                txtPw.Text = nv.Matkhau;
            }
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
            string temp = dtpBirthdate.Value.ToString();
            ngaysinh = dtpBirthdate.Value;
            if (rdNam.Checked)
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
                    chucvu = "staff";
                    break;
            }
            if (txtPw.Text != txtRePw.Text || txtPw.Text == "" || txtRePw.Text == "")
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
            }
            else
            {
                matkhau = txtPw.Text;
                if (type == 0)
                {
                    if (BilliardClubBUS.NhanvienBUS.checkID(id))
                    {
                        MessageBox.Show("Da ton tai id nay !");
                    }
                    else
                    {
                        if (BilliardClubBUS.NhanvienBUS.insertNV(id, ho, ten, ngaysinh, gioitinh, chucvu, matkhau))
                        {
                            MessageBox.Show("Thêm nhân viên thành công");
                            onDataUpdated?.Invoke(); // sua thanh cong thi goi ham tu form cha de refesh form cha
                            this.Close();
                        }
                        else { MessageBox.Show("Thêm nhân viên thất bại"); }
                    }
                } 
                else 
                {
                    if (BilliardClubBUS.NhanvienBUS.updateNV(id, ho, ten, ngaysinh, gioitinh, chucvu, matkhau))
                    {
                        MessageBox.Show("Sua thong tin nhân viên thành công");
                        onDataUpdated?.Invoke(); // sua thanh cong thi goi ham tu form cha de refesh form cha
                        this.Close();   
                    }
                    else { MessageBox.Show("Thêm nhân viên thất bại"); }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            txtHo.Clear();
            txtID.Clear();
            txtPw.Clear();
            txtRePw.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
