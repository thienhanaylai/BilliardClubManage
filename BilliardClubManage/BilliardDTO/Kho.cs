using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClubManage.BilliardDTO
{
    internal class Kho
    {
        string _Idhanghoa;
        int _soluong;

        public Kho(string idhanghoa, int soluong)
        {
            Idhanghoa = idhanghoa;
            Soluong = soluong;
        } 
        public Kho()
        {

        }

        public string Idhanghoa { get => _Idhanghoa; set => _Idhanghoa = value; }
        public int Soluong { get => _soluong; set => _soluong = value; }
    }
}
