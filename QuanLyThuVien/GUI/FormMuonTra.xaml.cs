using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanLyThuVien.GUI
{
    /// <summary>
    /// Interaction logic for FormMuonTra.xaml
    /// </summary>
    public partial class FormMuonTra : Window
    {
        public FormMuonTra()
        {
            InitializeComponent();
        }

        private void BtnMuon_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Gom dữ liệu từ giao diện vào DTO
                BorrowDTO borrow = new BorrowDTO
                {
                    MaDocGia = txtMaDocGia.Text,
                    MaSach = txtMaSach.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    NgayMuon = DateTime.Now,
                    NgayTraDuKien = dpNgayTra.SelectedDate ?? DateTime.Now.AddDays(7)
                };

                // Gọi lớp BUS để xử lý nghiệp vụ
                BorrowBUS bus = new BorrowBUS();
                string ketQua = bus.XuLyMuonSach(borrow);

                // Hiển thị kết quả
                lblThongBao.Text = ketQua;
                if (ketQua == "Mượn sách thành công!")
                {
                    lblThongBao.Foreground = Brushes.Green;
                }
                else
                {
                    lblThongBao.Foreground = Brushes.Red;
                }
            }
            catch (Exception ex)
            {
                lblThongBao.Text = "Lỗi định dạng dữ liệu đầu vào!";
            }
        }

        
    }
}
