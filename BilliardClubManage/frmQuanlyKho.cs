using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using BilliardClubBUS;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubManage
{
    public partial class frmQuanlyKho : Form
    {
        public frmQuanlyKho()
        {
            InitializeComponent();
        }



        private void btnThemHanghoa_Click(object sender, EventArgs e)
        {
            Hanghoa h = new Hanghoa();
            frmInfoHanghoa addItem = new frmInfoHanghoa(0,h,LoadData);
            addItem.ShowDialog();
        }

        private void btnSuaHanghoa_Click(object sender, EventArgs e)
        {
            Hanghoa h = new Hanghoa();
            if (dgvKho.CurrentRow != null)
            {
                string id = dgvKho.CurrentRow.Cells[0].Value.ToString();
                h = BilliardClubBUS.HanghoaBUS.getHHbyId(id);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng.");
            }
            frmInfoHanghoa editItem = new frmInfoHanghoa(1, h, LoadData);
            editItem.ShowDialog();
            //còn thiếu hàm đổ data của hàng hóa được chọn trong datagirdview vào form info
        }

        private void btnXuatHanghoa_Click(object sender, EventArgs e)
        {
            Hanghoa h = new Hanghoa();
            if (dgvKho.CurrentRow != null)
            {
                string id = dgvKho.CurrentRow.Cells[0].Value.ToString();
                h = BilliardClubBUS.HanghoaBUS.getHHbyId(id);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng.");
            }
            frmXuatHanghoa exportItem = new frmXuatHanghoa(h,LoadData);
            exportItem.ShowDialog();
        }

        private void frmQuanlyKho_Load(object sender, EventArgs e)
        {
            List<Hanghoa> listHH = BilliardClubBUS.HanghoaBUS.getListHH();
            dgvKho.DataSource = listHH;
            
        }

        private void LoadData()
        {
            dgvKho.DataSource = BilliardClubBUS.HanghoaBUS.getListHH();
        }

        private void btnTimHanghoa_Click(object sender, EventArgs e)
        {
            string id = txtTimhanghoa.Text.ToLower();
            List<Hanghoa> listHH = BilliardClubBUS.HanghoaBUS.getListHH();
            List<Hanghoa> listRes = new List<Hanghoa>();
            foreach (Hanghoa hh in listHH)
            {
                if (hh.IDhanghoa.ToLower().Contains(id) || hh.Tenhanghoa.ToLower().Contains(id))
                {
                    listRes.Add(hh);
                }
            }
            dgvKho.DataSource = listRes;
        }

        private void dgvKho_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvKho.Columns[e.ColumnIndex].Name == "clmPrice")
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
