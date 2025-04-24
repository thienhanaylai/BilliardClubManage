using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClubManage.BilliardDTO
{
    public class Ban
    {
        private string idban;
        private string tenban;
        private bool tinhtrang;
        private string khuvuc;
        private DateTime? gioBD;
        private DateTime? gioKT;
        private int dongia;
        private string loaiban;

        public Ban() { }

        public Ban(string idban, string tenban, bool tinhtrang, string khuvuc, DateTime gioBD, DateTime gioKT, int dongia, string loaiban)
        {
            this.idban = idban;
            this.tenban = tenban;
            this.tinhtrang = tinhtrang;
            this.khuvuc = khuvuc;
            this.gioBD = gioBD;
            this.gioKT = gioKT;
            this.dongia = dongia;
            this.loaiban = loaiban;
        }

        public Ban(string idban, string tenban, bool tinhtrang, string khuvuc, DateTime? gioBD, DateTime? gioKT, int dongia, string loaiban)
        {
            this.idban = idban;
            this.tenban = tenban;
            this.tinhtrang = tinhtrang;
            this.khuvuc = khuvuc;
            this.gioBD = gioBD;
            this.gioKT = gioKT;
            this.dongia = dongia;
            this.loaiban = loaiban;
        }

        public string IDban { get => idban; set => idban = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public bool Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Khuvuc { get => khuvuc; set => khuvuc = value; }
        public DateTime? GioBD { get => gioBD; set => gioBD = value; }
        public DateTime? GioKT { get => gioKT; set => gioKT = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public string Loaiban { get => loaiban; set => loaiban = value; }
    }
}
