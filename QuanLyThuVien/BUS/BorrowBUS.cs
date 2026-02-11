using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
    public class BorrowBUS
    {
        BorrowDAL _borrowDAL = new BorrowDAL();

        public string XuLyMuonSach(BorrowDTO borrow)
        {
            // 1. Kiểm tra nhập liệu cơ bản
            if (string.IsNullOrEmpty(borrow.MaSach) || borrow.SoLuong <= 0)
                return "Thông tin sách hoặc số lượng không hợp lệ!";

            // 2. Check số lượng sách còn trong kho (DAL)
            int soLuongHienCo = _borrowDAL.LaySoLuongSachTonKho(borrow.MaSach);
            if (soLuongHienCo < borrow.SoLuong)
                return $"Không đủ sách! Hiện chỉ còn {soLuongHienCo} cuốn.";

            // 3. Check ngày trả (Không được mượn quá 14 ngày chẳng hạn, hoặc ngày trả < ngày mượn)
            if (borrow.NgayTraDuKien <= borrow.NgayMuon)
                return "Ngày trả dự kiến phải sau ngày mượn!";

            TimeSpan duration = borrow.NgayTraDuKien - borrow.NgayMuon;
            if (duration.TotalDays > 30)
                return "Không được mượn quá 30 ngày!";

            // 4. Gọi DAL để thực hiện lưu xuống DB
            bool success = _borrowDAL.LuuPhieuMuon(borrow);
            if (success)
            {
                // Sau khi mượn thành công, phải trừ số lượng sách trong kho
                _borrowDAL.CapNhatSoLuongSach(borrow.MaSach, -borrow.SoLuong);
                return "Mượn sách thành công!";
            }
            return "Lỗi khi lưu vào cơ sở dữ liệu!";
        }

        public string XuLyTraSach(string maPhieuMuon)
        {
            // Logic trả sách: Cập nhật NgayTraThucTe và cộng lại số lượng sách vào kho
            // ... gọi các hàm từ DAL ...
            return "Trả sách thành công!";
        }
    }
}
