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
        private int donvi;
        private int gia;

        public Hanghoa() { }

        public Hanghoa(string idhanghoa, string tenhanghoa, int donvi, int gia)
        {
            this.idhanghoa = idhanghoa;
            this.tenhanghoa = tenhanghoa;
            this.donvi = donvi;
            this.gia = gia;
        }

        public string IDhanghoa { get => idhanghoa; set => idhanghoa = value; }
        public string Tenhanghoa { get => tenhanghoa; set => tenhanghoa = value; }
        public int Donvi { get => donvi; set => donvi = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
