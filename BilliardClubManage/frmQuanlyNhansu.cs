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
    public partial class frmQuanlyNhansu : Form
    {
        public frmQuanlyNhansu()
        {
            InitializeComponent();
        }

        private void btnThemnv_Click(object sender, EventArgs e)
        {
            int type = 0;
            Nhanvien nv = new Nhanvien();
            frmInfoNv addnv = new frmInfoNv(type, nv,LoadData);
            addnv.Show();
        }

        private void btnSuanv_Click(object sender, EventArgs e)
        {
            int type = 1;
            Nhanvien nv = new Nhanvien();
            
            if (dgvNhansu.CurrentRow != null)
            {
                string id = dgvNhansu.CurrentRow.Cells[0].Value.ToString();
                nv = BilliardClubBUS.NhanvienBUS.getNVbyId(id);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng.");
            }
            frmInfoNv info = new frmInfoNv(type, nv, LoadData);
            info.Show();
        }

        private void frmQuanlyNhansu_Load(object sender, EventArgs e)
        {
            dgvNhansu.DataSource = BilliardClubBUS.NhanvienBUS.getListNV();
        }
        private void LoadData()
        {
            dgvNhansu.DataSource = BilliardClubBUS.NhanvienBUS.getListNV();
        }

        private void btnXoanv_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            if (dgvNhansu.CurrentRow != null)
            {
                string id = dgvNhansu.CurrentRow.Cells[0].Value.ToString();
                nv = BilliardClubBUS.NhanvienBUS.getNVbyId(id);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng.");
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BilliardClubBUS.NhanvienBUS.dropNV(nv.IDnv))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnTimnv_Click(object sender, EventArgs e)
        {
            string idOrName = txtTim.Text;
            List<Nhanvien> list = BilliardClubBUS.NhanvienBUS.getListNV();
            List<Nhanvien> result = new List<Nhanvien>();
            foreach (Nhanvien nv in list)
            {
                if (nv.IDnv.Contains(idOrName) || nv.Hoten.Contains(idOrName))
                {
                    result.Add(nv);
                }
            }
           dgvNhansu.DataSource = result;
        }

        private void dgvNhansu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhansu.Columns[e.ColumnIndex].Name == "clmGioitinh") // Tên cột cần thay đổi
            {
                if (e.Value != null)
                {
                    bool gioiTinh = Convert.ToBoolean(e.Value); // Chuyển đổi giá trị từ DB
                    e.Value = gioiTinh ? "Nữ" : "Nam"; // Nếu true → Nữ, false → Nam
                    e.FormattingApplied = true; // Đánh dấu đã áp dụng format
                }
            }
        }
    }
}
