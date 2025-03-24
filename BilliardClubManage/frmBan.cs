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
    public partial class frmBan : Form
    {
        public frmBan()
        {
            InitializeComponent();
        }

        private Form crtFormChild;

        private void OpenFormChild(Form formChild)
        {
            if (crtFormChild != null)
            {
                crtFormChild.Close();
            }
            crtFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            dsBan.Controls.Add(formChild);
            dsBan.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            OpenFormChild(new frmListBan());
        }
    }
}
