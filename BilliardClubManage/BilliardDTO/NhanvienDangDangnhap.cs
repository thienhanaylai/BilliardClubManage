using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClubManage.BilliardDTO
{
    public static class NhanvienDangDangnhap
    {
        private static Nhanvien nv; // nv ddang dang nhap

        public static Nhanvien Nv { get => nv; set => nv = value; }

        public static void setNhanvien(Nhanvien nv)
        {
            NhanvienDangDangnhap.nv = nv;
        }

        public static void clearNhanvien()
        {
            nv = null;
        }
    }
}
