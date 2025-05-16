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
    public partial class frmQuanlyban : Form
    {
        public frmQuanlyban()
        {
            InitializeComponent();
        }

        private void btnThemban_Click(object sender, EventArgs e)
        {
            int type = 0;
            Ban ban = new Ban();
            frmInfoban addTable = new frmInfoban(type,ban,LoadData);
            addTable.ShowDialog();
        }

        private void btnSuaban_Click(object sender, EventArgs e)
        {
            int type = 1;
            Ban ban = new Ban();

            if (dgvBan.CurrentRow != null)
            {
                string id = dgvBan.CurrentRow.Cells[0].Value.ToString();
                ban = BilliardClubBUS.BanBUS.getBanbyID(id);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng.");
            }
            frmInfoban editTable = new frmInfoban(type,ban,LoadData);
            editTable.ShowDialog();
            //còn thiếu hàm đổ data của bàn được chọn trong datagirdview vào form info
        }

        private void LoadData()
        {
            dgvBan.DataSource = BilliardClubBUS.BanBUS.getListBan();
        }
        private void frmQuanlyban_Load(object sender, EventArgs e)
        {
            dgvBan.DataSource = BilliardClubBUS.BanBUS.getListBan();
        }

        private void dgvBan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBan.Columns[e.ColumnIndex].Name == "tinhtrang") // Tên cột cần thay đổi
            {
                if (e.Value != null)
                {
                    bool tinhtrang = Convert.ToBoolean(e.Value); // Chuyển đổi giá trị từ DB
                    e.Value = tinhtrang ? "Đang sử dụng" : "Trống"; // Nếu true → Nữ, false → Nam
                    e.FormattingApplied = true; // Đánh dấu đã áp dụng format
                }
            }

            if(dgvBan.Columns[e.ColumnIndex].Name == "dongia")
            {
                if (e.Value != null)
                {
                    string valueAsString = e.Value.ToString(); // Lấy giá trị dưới dạng chuỗi
                    if (decimal.TryParse(valueAsString, out decimal numericValue))
                    {
                        // Định dạng giá trị số và thêm " VND"
                        e.Value = numericValue.ToString("#,##0") + " VND";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void btnXoaban_Click(object sender, EventArgs e)
        {
            Ban ban = new Ban();
            if (dgvBan.CurrentRow != null)
            {
                string id = dgvBan.CurrentRow.Cells[0].Value.ToString();
                ban = BilliardClubBUS.BanBUS.getBanbyID(id);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng.");
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ban này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BilliardClubBUS.BanBUS.deleteBan(ban.IDban.Trim()))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại ! Co hoa don lien quan den ban khong the xoa !");
                }
            }
        }

        private void btnTimban_Click(object sender, EventArgs e)
        {
            string idOrName = txtTimban.Text;
            List<Ban> list = BilliardClubBUS.BanBUS.getListBan();
            List<Ban> result = new List<Ban>();
            foreach (Ban ban in list)
            {
                if (ban.IDban.Contains(idOrName) || ban.Tenban.Contains(idOrName))
                {
                    result.Add(ban);
                }
            }
            dgvBan.DataSource = result;
        }
    }
}
