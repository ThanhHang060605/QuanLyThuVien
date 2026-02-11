using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class BorrowDTO
    {
        public string MaPhieuMuon { get; set; }
        public string MaDocGia { get; set; }
        public string MaSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTraDuKien { get; set; }
        public DateTime? NgayTraThucTe { get; set; }
        public int SoLuong { get; set; }
        public string TinhTrang { get; set; } // "Đang mượn", "Đã trả", "Quá hạn"
    }