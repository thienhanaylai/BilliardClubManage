using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilliardClubBUS;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubManage
{
    public partial class frmXuatHanghoa : Form
    {
        Hanghoa h;
        private Action onDataUpdated;
        public frmXuatHanghoa(Hanghoa h, Action onDataUpdated)
        {
            InitializeComponent();
            this.h = h;
            this.onDataUpdated = onDataUpdated;
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if(txtSl.IntValue <= 0)
            {
                MessageBox.Show("Vui long nhap so lon hon 0 !");
                return;
            }
            if (h.Soluong < txtSl.IntValue)
            {
                MessageBox.Show("Khong du so luong hang hoa trong kho !");
                return;
            }
            else
            {
                int soluong = (int)h.Soluong - txtSl.IntValue;
                KhoBUS.updateSoluong(h.IDhanghoa, soluong); 
                onDataUpdated?.Invoke();
            }
             //cap nhat so luong hang hoa
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
