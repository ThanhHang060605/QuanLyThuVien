USE QuanLyThuVienDB;
GO

--------------------------------------------------
-- READERS
--------------------------------------------------
INSERT INTO Readers (FullName, Phone, Email, Address)
VALUES
(N'Nguyễn Văn A', '0901111111', 'a@gmail.com', N'Quảng Bình'),
(N'Trần Thị B', '0902222222', 'b@gmail.com', N'Đà Nẵng'),
(N'Lê Văn C', '0903333333', 'c@gmail.com', N'Hà Nội');

--------------------------------------------------
-- BOOKS
--------------------------------------------------
INSERT INTO Books (Title, AuthorID, CategoryID, Quantity, YearPublished)
VALUES
(N'Mắt Biếc', 1, 3, 10, 2010),
(N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', 1, 3, 8, 2015),
(N'Clean Code', 2, 1, 5, 2008),
(N'Agile Development', 2, 1, 6, 2012);

--------------------------------------------------
-- BORROW TICKETS
--------------------------------------------------
INSERT INTO BorrowTickets (ReaderID, BookID, BorrowDate, ReturnDate)
VALUES
(1, 1, '2026-02-01', '2026-02-10'),
(2, 3, '2026-02-05', '2026-02-15'),
(3, 2, '2026-02-06', '2026-02-20');
