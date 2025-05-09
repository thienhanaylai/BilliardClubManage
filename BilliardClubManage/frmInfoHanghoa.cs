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
    public partial class frmInfoHanghoa : Form
    {
        int type; //0 la them 1 la sua
        Hanghoa hh;
        private Action onDataUpdated; // delegate khi update du lieu goi ham event tu form cha de cap nhat lai du lieu
        public frmInfoHanghoa(int type,Hanghoa hh, Action onDataUpdated)
        {
            InitializeComponent();
            this.hh = hh;
            this.type= type;
            this.onDataUpdated = onDataUpdated;
        }


        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            string idhh = txtID.Text;
            string tenhh = txtTenHh.Text;
            string donvi = slDonvi.Text;
            int gia = txtTien.IntValue;
            int sl = txtSl.IntValue;

            Hanghoa h = new Hanghoa(idhh, tenhh, donvi, gia);

            if (type == 0)
            {
                if (HanghoaBUS.getHHbyId(idhh) == null)
                {
                    MessageBox.Show("Da ton tai id nay !");
                }
                else
                {
                    if (HanghoaBUS.insertHH(h))
                    {
                        KhoBUS.insertHHKho(idhh, sl); //them kho cho hang hoa
                        MessageBox.Show("Them hang hoa thanh cong !");
                        onDataUpdated?.Invoke();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Them hang hoa that bai !");
                    }
                }
            } 
            else if (type == 1)
            {
                if (HanghoaBUS.updateHanghoa(h))
                {
                    KhoBUS.updateSoluong(idhh, sl); //cap nhat so luong hang hoa
                    MessageBox.Show("Sua hang hoa thanh cong !");
                    onDataUpdated?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sua hang hoa that bai !");
                }
            }
        }

        private void frmInfoHanghoa_Load(object sender, EventArgs e)
        {
            if (type == 1)
            {
                txtID.Text = hh.IDhanghoa;
                txtTenHh.Text = hh.Tenhanghoa;
                txtTien.Text = hh.Gia.ToString();
                txtSl.Text = hh.Soluong.ToString();
                slDonvi.Text = hh.Donvi.ToString();

            }
        }
    }
}
