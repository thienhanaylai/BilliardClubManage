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
    public partial class frmQuanlyDoanhthu : Form
    {
        public frmQuanlyDoanhthu()
        {
            InitializeComponent();
        }

        private void frmQuanlyDoanhthu_Load(object sender, EventArgs e)
        {

            dvDoanhthu.AutoGenerateColumns = false;
            dvDoanhthu.DataSource = BilliardBUS.HoadonBUS.getDsHoaDon();
        }

        private void dvDoanhthu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dvDoanhthu.Columns[e.ColumnIndex].Name == "Trangthai")
            {
                if (e.Value != null) {
                    bool tinhtrang = Convert.ToBoolean(e.Value); 
                    e.Value = tinhtrang ? "Đã thanh toán" : "Chưa thanh toán"; 
                    e.FormattingApplied = true;
                }
            }

            if (dvDoanhthu.Columns[e.ColumnIndex].Name == "Tongtien")
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
    }
}
