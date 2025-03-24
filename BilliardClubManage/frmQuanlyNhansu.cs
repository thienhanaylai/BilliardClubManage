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
            frmInfoNv addnv = new frmInfoNv(type);
            addnv.ShowDialog();
        }

        private void btnSuanv_Click(object sender, EventArgs e)
        {
            int type = 1;
            frmInfoNv info = new frmInfoNv(type);
            info.ShowDialog();
            //còn thiếu hàm đổ data của nhân viên được chọn trong datagirdview vào form info
        }

        private void frmQuanlyNhansu_Load(object sender, EventArgs e)
        {
            dgvNhansu.DataSource = BilliardClubBUS.NhanvienBUS.getListNV();
        }


    }
}
