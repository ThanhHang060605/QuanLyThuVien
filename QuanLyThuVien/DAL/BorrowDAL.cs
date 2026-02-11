using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    public class BorrowDAL
    {
        // Lấy số lượng sách hiện có trong kho
        public int GetCurrentStock(string maSach)
        {
            // Viết query: SELECT SoLuong FROM Sach WHERE MaSach = @maSach
            return 10; // Giả lập dữ liệu trả về
        }

        // Lưu thông tin mượn sách vào DB
        public bool InsertBorrow(BorrowDTO borrow)
        {
            // Thực thi lệnh INSERT INTO PhieuMuon...
            return true;
        }
    }
}
