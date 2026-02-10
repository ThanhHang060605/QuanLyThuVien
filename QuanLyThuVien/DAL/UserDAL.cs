using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data.SqlClient;


namespace QuanLyThuVien.DAL
{
    class UserDAL
    {
        public UserDTO Login(string username, string password)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM Users WHERE Username=@u AND Password=@p";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    return new UserDTO
                    {
                        Username = rd["Username"].ToString(),
                        Role = rd["Role"].ToString()
                    };
                }
            }

            return null;
        }
    }
}
