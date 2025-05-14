using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClubManage.BilliardDTO
{
    internal class chitiethoadon
    {
        private string idchitiethoadon;
        private string idhoadon;
        private string idhanghoa;
        private int soluong;
        private string idban;
        private int sogiochoi;

        public chitiethoadon() { }
        public chitiethoadon(string idchitiethoadon, string idhoadon, string idhanghoa, int soluong, string idban, int sogiochoi)
        {
            this.idchitiethoadon = idchitiethoadon;
            this.idhoadon = idhoadon;
            this.idhanghoa = idhanghoa;
            this.soluong = soluong;
            this.idban = idban;
            this.sogiochoi = sogiochoi;
        }

        public string Idchitiethoadon { get => idchitiethoadon; set => idchitiethoadon = value; }
        public string Idhoadon { get => idhoadon; set => idhoadon = value; }
        public string Idhanghoa { get => idhanghoa; set => idhanghoa = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Idban { get => idban; set => idban = value; }
        public int Sogiochoi { get => sogiochoi; set => sogiochoi = value; }
    }


}
