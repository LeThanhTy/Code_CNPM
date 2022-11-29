using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class SqlConnectionData {
        // Tạo chuỗi kết nối cơ sở dữ liệu SQL sever
        public static SqlConnection Connect()
        {
            string strcon = "Data Source=QUYNH;Initial Catalog=QLHS_Login;Integrated Security=True";
            SqlConnection connect = new SqlConnection(strcon); // khởi tạo connect
            return connect;
        }
    }
    public class DatabaseAccess
    {
        public static string CheckLogicDTO(TaiKhoan taiKhoan)
        {
            // Hàm conncet tới CSDL
            string user = null;
            SqlConnection connect = SqlConnectionData.Connect();
            connect.Open();
            SqlCommand command = new SqlCommand("proc_logic", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taiKhoan.TK);
            command.Parameters.AddWithValue("@pass", taiKhoan.MK);
           
            // Kiểm tra quyển 
            command.Connection= connect;
            SqlDataReader reader= command.ExecuteReader();
            if (reader.HasRows) { 
                while(reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                connect.Close();
            }
            else
            {

                return "Không chính xác!";
            }
            return user;
        }
    }
}
