using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubManage.BilliardDAO
{
    internal class chitiethoadonDAO
    {
        DataProvider DataProvider;

        public chitiethoadonDAO()
        {
            DataProvider = new DataProvider();
        }

        public bool insertChitiethoadon(string idchitiethoadon, string idhoadon, string idhanghoa, int soluong, string idban, int sogiochoi)
        {
            DataProvider.Connect();
            string sql = "insert into chitiethoadon values(N'" + idchitiethoadon+"', N'"+idhoadon+"',N'"+idhanghoa+"',"+soluong+",N'"+idban+"',"+sogiochoi+")";
            int res = DataProvider.ExecuteNonQuery(sql);
            if (res > 0)
            {
                DataProvider.Close();
                return true;
            }
            else
            {
                DataProvider.Close();
                return false;
            }
        }

        public List<chitiethoadon> getDsSanPhamByIDHoadon(string id)
        {
            DataProvider.Connect();
            List<chitiethoadon> listSanPham = new List<chitiethoadon>();
            string sql = "select * from chitiethoadon where IDhoadon = N'"+id+"'";
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            while (rd.Read()) {
                chitiethoadon sp = new chitiethoadon();
                sp.Idchitiethoadon = rd.GetString(0);
                sp.Idhoadon = rd.GetString(1);
                sp.Idhanghoa = rd.GetString(2);
                sp.Soluong = rd.GetInt32(3);
                sp.Idban = rd.GetString(4);
                sp.Sogiochoi = rd.GetInt32(5);
                listSanPham.Add(sp);
            }
            DataProvider.Close();
            return listSanPham;
        }
        
        public bool updatecthd(chitiethoadon hd)
        {
            DataProvider.Connect();
            string sql = "update chitiethoadon set IDchitiet = N'" + hd.Idchitiethoadon + "',IDchitiet = N'" + hd.Idhoadon + "',IDhanghoa = N'" + hd.Idhanghoa + "',IDban = N'" + hd.Idban + "', Soluong = " + hd.Soluong + ", Sogiochoi = " + hd.Sogiochoi;
            int res = DataProvider.ExecuteNonQuery(sql);
            if (res > 0)
            {
                DataProvider.Close();
                return true;
            }
            else
            {
                DataProvider.Close();
                return false;
            }
        }
    }
}
