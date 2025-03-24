using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClubManage.BilliardDAO
{
    internal class DataProvider
    {
        public static string connectionStr = @"Data Source=DESKTOP-4TS178P;Initial Catalog=BilliardClub;Integrated Security=True";
        SqlConnection connect;
        private SqlCommand cmd;

        public  DataProvider()
        {
            //khởi tạo kết nối với cơ sở dữ liệu
            connect = new SqlConnection(connectionStr);
        }

        public void Connect()
        {
            //mở kết nối
            connect.Open();
        }   

        public void Close() {
            //đóng kết nối
            connect.Close();
        }

        public SqlDataReader SqlDataReader(string sql)
        {
            //thực thi câu lệnh sql trả về một SqlDataReader
            cmd = new SqlCommand(sql, connect);
            return cmd.ExecuteReader();
        }

        public int ExecuteNonQuery(string sql)
        {
            //thực thi câu lệnh sql không trả về giá trị
            cmd = new SqlCommand(sql, connect);
            return cmd.ExecuteNonQuery();
        }
    }
}
