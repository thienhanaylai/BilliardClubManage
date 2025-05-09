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
using Sunny.UI;

namespace BilliardClubManage
{
    public partial class frmOder : Form
    {

        public frmOder()
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
            ListOder.Controls.Add(formChild);
            ListOder.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }


    }
}
