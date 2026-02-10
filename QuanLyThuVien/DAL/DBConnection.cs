using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAL
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyThuVienDB;Integrated Security=True;");
        }
    }
}
