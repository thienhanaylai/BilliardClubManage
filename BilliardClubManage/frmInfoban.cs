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
    public partial class frmInfoban : Form
    {

        int type; //0 la them 1 la sua
        Ban ban;
        private Action onDataUpdated; // delegate khi update du lieu goi ham event tu form cha de cap nhat lai du lieu
        public frmInfoban(int type,Ban ban,Action onDataUpdate)
        {
            InitializeComponent();
            this.type = type;
            this.ban = ban;
            this.onDataUpdated = onDataUpdate;
        }

        private void updateBan_load(object sender, EventArgs e)
        {
            if(type == 1)
            {
                txtId.Text = ban.IDban;
                txtName.Text = ban.Tenban;
                txtPrice.Text = ban.Dongia.ToString();
                switch (ban.Khuvuc)
                {
                    case "Vip 1":
                        cbxStation.Text = "Vip 1";
                        break;
                    case "Vip 2":
                        cbxStation.Text = "Vip 2";
                        break;
                    default:
                        cbxStation.Text = "Vip 1";
                        break;
                }
                switch (ban.Loaiban)
                {
                    case "Pool":
                        cbxLoaiban.Text = "Pool";
                        break;
                    case "Libre":
                        cbxLoaiban.Text = "Libre";
                        break;
                    default:
                        cbxLoaiban.Text = "Pool";
                        break;
                }
            }
        }


        private void btnXacnhan_Click(object sender, EventArgs e)
        {
         string idban;
         string tenban;
         bool tinhtrang = false;
         string khuvuc;
         DateTime? gioBD = DateTime.Now;
         DateTime? gioKT = DateTime.Now;
         int dongia;
         string loaiban;


        idban = txtId.Text;
            tenban = txtName.Text;
            switch (cbxStation.Text)
            {
                case "Vip 1":
                    khuvuc = "Vip 1";
                    break;
                case "Vip 2":
                    khuvuc = "Vip 2";
                    break;
                default:
                    khuvuc = "Vip 1";
                    break;
            }
            dongia = Convert.ToInt32(txtPrice.Text);
            switch (cbxLoaiban.Text)
            {
                case "Pool":
                    loaiban = "Pool";
                    break;
                case "Libre":
                    loaiban = "Libre";
                    break;
                default:
                    loaiban = "Pool";
                    break;
            }
            if (type == 0)
            {
                if (BilliardClubBUS.BanBUS.validateID(idban))
                {
                    MessageBox.Show("ID bàn đã tồn tại");
                }
                else
                {
                    Ban temp = new Ban(idban, tenban, tinhtrang, khuvuc, null, null, dongia, loaiban);
                    if (BilliardClubBUS.BanBUS.insertBan(temp))
                    {
                        MessageBox.Show("Thêm bàn thành công");
                        onDataUpdated?.Invoke(); // sua thanh cong thi goi ham tu form cha de refesh form cha
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm bàn thất bại");
                    }
                }
            }
            else
            {
                Ban temp = new Ban(idban, tenban, tinhtrang, khuvuc, null, null, dongia, loaiban);
                if (BilliardClubBUS.BanBUS.updateBan(temp))
                {
                    MessageBox.Show("Sửa bàn thành công");
                    onDataUpdated?.Invoke(); // sua thanh cong thi goi ham tu form cha de refesh form cha
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa bàn thất bại");
                }

            }

        }
    }
}
