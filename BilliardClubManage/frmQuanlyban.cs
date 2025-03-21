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
         
        }
    }
}
