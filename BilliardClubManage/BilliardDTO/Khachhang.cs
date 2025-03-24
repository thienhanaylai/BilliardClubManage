using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClubManage.BilliardDTO
{
    internal class Khachhang
    {
        private string _IDkh;
        private string _TenKH;
        private string _Sdt;

        public string IDkh { get => _IDkh; set => _IDkh = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }

        public Khachhang() { }
        
        public Khachhang(string IDkh, string TenKH, string Sdt)
        {
            IDkh = this.IDkh;
            TenKH = this.TenKH;
            Sdt = this.Sdt;
        }
    }
}
