using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClubManage.BilliardDTO
{
    public class Hoadon
    {
        private string idhoadon;
        private DateTime ngaylap;
        private int tongtien;
        private bool trangthai;
        private string idkh;
        private string idnv;

        public Hoadon() { }

        public Hoadon(string idhoadon, DateTime ngaylap, int tongtien, bool trangthai, string idkh, string idnv)
        {
            this.idhoadon = idhoadon;
            this.ngaylap = ngaylap;
            this.tongtien = tongtien;
            this.trangthai = trangthai;
            this.idkh = idkh;
            this.idnv = idnv;
        }

        public string IDhoadon { get => idhoadon; set => idhoadon = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        public string IDkh { get => idkh; set => idkh = value; }
        public string IDnv { get => idnv; set => idnv = value; }
    }
}
