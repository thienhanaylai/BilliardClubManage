using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClubManage.BilliardDTO
{
    public class Hanghoa
    {
        private string idhanghoa;
        private string tenhanghoa;
        private string donvi;
        private int gia;
        private int? soluong;

        public Hanghoa() { }

        public Hanghoa(string idhanghoa, string tenhanghoa, string donvi, int gia)
        {
            this.idhanghoa = idhanghoa;
            this.tenhanghoa = tenhanghoa;
            this.donvi = donvi;
            this.gia = gia;
        }

        public string IDhanghoa { get => idhanghoa; set => idhanghoa = value; }
        public string Tenhanghoa { get => tenhanghoa; set => tenhanghoa = value; }
        public string Donvi { get => donvi; set => donvi = value; }
        public int Gia { get => gia; set => gia = value; }
        public int? Soluong { get => soluong; set => soluong = value; }
    }
}
