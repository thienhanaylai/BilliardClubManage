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
    public partial class frmQuanlyban : Form
    {
        public frmQuanlyban()
        {
            InitializeComponent();
        }

        private void btnThemban_Click(object sender, EventArgs e)
        {
            frmInfoban addTable = new frmInfoban();
            addTable.ShowDialog();
        }

        private void btnSuaban_Click(object sender, EventArgs e)
        {
            frmInfoban editTable = new frmInfoban();
            editTable.ShowDialog();
            //còn thiếu hàm đổ data của bàn được chọn trong datagirdview vào form info
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
                    e.Value = tinhtrang ? "Dang su dung" : "Trong"; // Nếu true → Nữ, false → Nam
                    e.FormattingApplied = true; // Đánh dấu đã áp dụng format
                }
            }
        }
    }
}
