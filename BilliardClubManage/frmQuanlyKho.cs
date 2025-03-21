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
    public partial class frmQuanlyKho : Form
    {
        public frmQuanlyKho()
        {
            InitializeComponent();
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemHanghoa_Click(object sender, EventArgs e)
        {
            frmInfoHanghoa addItem = new frmInfoHanghoa();
            addItem.ShowDialog();
        }

        private void btnSuaHanghoa_Click(object sender, EventArgs e)
        {
            frmInfoHanghoa editItem = new frmInfoHanghoa();
            editItem.ShowDialog();
            //còn thiếu hàm đổ data của hàng hóa được chọn trong datagirdview vào form info
        }

        private void btnXuatHanghoa_Click(object sender, EventArgs e)
        {
            //chọn hàng hóa cần xuất trong datagirdview 
            //nhập số lượng cần xuất 
            frmXuatHanghoa exportItem = new frmXuatHanghoa();
            exportItem.ShowDialog();
        }
    }
}
