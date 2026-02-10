using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAL;


namespace QuanLyThuVien.BUS
{
    class UserBUS
    {
        public UserDTO Login(string username, string password)
        {
            UserDAL dal = new UserDAL();
            return dal.Login(username, password);
        }

    }
}
