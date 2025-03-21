using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClubManage.BilliardDTO
{
    public class Nhanvien
    {
        private string _IDnv;
        private string _Hoten;
        private DateTime _Ngaysinh;
        private bool _Gioitinh;
        private string _Chucvu;
        private string _Matkhau;

        public Nhanvien(string IDnv, string Hoten, DateTime Ngaysinh, bool Gioitinh, string Chucvu, string Matkhau)
        {
            IDnv = this.IDnv;
            Hoten = this.Hoten;
            Ngaysinh = this.Ngaysinh;
            Gioitinh = this.Gioitinh;
            Chucvu = this.Chucvu;
            Matkhau = this.Matkhau;
        }

        public Nhanvien()
        {
        }

        public string IDnv { get => _IDnv; set => _IDnv = value; }
        public string Hoten { get => _Hoten; set => _Hoten = value; }
        public DateTime Ngaysinh { get => _Ngaysinh; set => _Ngaysinh = value; }
        public bool Gioitinh { get => _Gioitinh; set => _Gioitinh = value; }
        public string Chucvu { get => _Chucvu; set => _Chucvu = value; }
        public string Matkhau { get => _Matkhau; set => _Matkhau = value; }


    }
}
