CREATE DATABASE QUANLYTHUVIEN
GO

USE [QUANLYTHUVIEN]
GO
/****** Object:  Table [dbo].[Docgia]    Script Date: 05/08/17 11:14:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Docgia](
	[DocgiaID] [int] IDENTITY(1,1) NOT NULL,
	[HehocID] [int] NULL,
	[Mathe] [varchar](10) NULL,
	[Tendocgia] [nvarchar](40) NULL,
	[Lop] [varchar](10) NULL,
	[Gioitinh] [bit] NULL,
	[Namsinh] [datetime] NULL,
	[Diachi] [nvarchar](100) NULL,
	[Ghichu] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[DocgiaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Docgia_Sach]    Script Date: 05/08/17 11:14:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docgia_Sach](
	[DocgiaID] [int] NULL,
	[SachID] [int] NULL,
	[Ngaymuon] [datetime] NULL,
	[Ngaytra] [datetime] NULL,
	[Tinhtrang] [int] NULL,
	[Ghichu] [nvarchar](200) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hehoc]    Script Date: 05/08/17 11:14:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hehoc](
	[HehocID] [int] IDENTITY(1,1) NOT NULL,
	[Tenhehoc] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[HehocID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 05/08/17 11:14:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[NhanvienID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[NhanvienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhanvien_Sach]    Script Date: 05/08/17 11:14:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien_Sach](
	[NhanvienID] [int] NULL,
	[SachID] [int] NULL,
	[Ghichu] [nvarchar](200) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhaxuatban]    Script Date: 05/08/17 11:14:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhaxuatban](
	[NhaxuatbanID] [int] IDENTITY(1,1) NOT NULL,
	[Tennhaxuatban] [nvarchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[NhaxuatbanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhomquyen]    Script Date: 05/08/17 11:14:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhomquyen](
	[NhomquyenID] [int] IDENTITY(1,1) NOT NULL,
	[Tenquyen] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[NhomquyenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sach]    Script Date: 05/08/17 11:14:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sach](
	[SachID] [int] NOT NULL,
	[NhaxuatbanID] [int] NULL,
	[VitriID] [int] NULL,
	[Tensach] [nvarchar](100) NULL,
	[Theloai] [nvarchar](30) NULL,
	[Ngonngu] [nvarchar](30) NULL,
	[Ngaycapnhat] [datetime] NULL,
	[Namxuatban] [int] NULL,
	[Hinhanh] [varchar](100) NULL,
	[Sotrang] [int] NULL,
	[Soluong] [int] NULL,
	[Gia] [real] NULL,
	[Mota] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[SachID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 05/08/17 11:14:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[TaikhoanID] [int] IDENTITY(1,1) NOT NULL,
	[NhomquyenID] [int] NULL,
	[Tentaikhoan] [nvarchar](20) NULL,
	[Matkhau] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[TaikhoanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Taikhoan_Nhanvien]    Script Date: 05/08/17 11:14:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan_Nhanvien](
	[TaikhoanID] [int] NULL,
	[NhanvienID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vitri]    Script Date: 05/08/17 11:14:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vitri](
	[VitriID] [int] IDENTITY(1,1) NOT NULL,
	[Mota] [nvarchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[VitriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Docgia] ON 

INSERT [dbo].[Docgia] ([DocgiaID], [HehocID], [Mathe], [Tendocgia], [Lop], [Gioitinh], [Namsinh], [Diachi], [Ghichu]) VALUES (1, 1, N'11111111', N'Ngô Xuân Dương', N'TH13A', 1, CAST(N'1996-01-01 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Docgia] ([DocgiaID], [HehocID], [Mathe], [Tendocgia], [Lop], [Gioitinh], [Namsinh], [Diachi], [Ghichu]) VALUES (2, 2, N'22222222', N'Đào Văn Tuyền', N'TH13B', 1, CAST(N'1996-02-02 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Docgia] ([DocgiaID], [HehocID], [Mathe], [Tendocgia], [Lop], [Gioitinh], [Namsinh], [Diachi], [Ghichu]) VALUES (3, 2, N'33333333', N'Ninh Thị Nguyên', N'TH13B', 0, CAST(N'1996-03-03 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Docgia] ([DocgiaID], [HehocID], [Mathe], [Tendocgia], [Lop], [Gioitinh], [Namsinh], [Diachi], [Ghichu]) VALUES (4, 2, N'44444444', N'Phí Thị Kim Liên', N'TH13C', 0, CAST(N'1996-05-04 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Docgia] ([DocgiaID], [HehocID], [Mathe], [Tendocgia], [Lop], [Gioitinh], [Namsinh], [Diachi], [Ghichu]) VALUES (5, 1, N'55555555', N'Hà Thị Quyết', N'TH13C', 0, CAST(N'1996-07-05 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Docgia] ([DocgiaID], [HehocID], [Mathe], [Tendocgia], [Lop], [Gioitinh], [Namsinh], [Diachi], [Ghichu]) VALUES (6, 2, N'66666666', N'Nguyễn Đức Mạnh', N'TH13C', 1, CAST(N'1996-09-07 00:00:00.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Docgia] OFF
INSERT [dbo].[Docgia_Sach] ([DocgiaID], [SachID], [Ngaymuon], [Ngaytra], [Tinhtrang], [Ghichu]) VALUES (2, 5, CAST(N'2017-01-26 00:00:00.000' AS DateTime), CAST(N'2017-06-25 00:00:00.000' AS DateTime), 0, NULL)
INSERT [dbo].[Docgia_Sach] ([DocgiaID], [SachID], [Ngaymuon], [Ngaytra], [Tinhtrang], [Ghichu]) VALUES (3, 1, CAST(N'2017-01-21 00:00:00.000' AS DateTime), CAST(N'2017-06-25 00:00:00.000' AS DateTime), 0, NULL)
INSERT [dbo].[Docgia_Sach] ([DocgiaID], [SachID], [Ngaymuon], [Ngaytra], [Tinhtrang], [Ghichu]) VALUES (5, 2, CAST(N'2017-01-27 00:00:00.000' AS DateTime), CAST(N'2017-06-25 00:00:00.000' AS DateTime), 0, NULL)
INSERT [dbo].[Docgia_Sach] ([DocgiaID], [SachID], [Ngaymuon], [Ngaytra], [Tinhtrang], [Ghichu]) VALUES (4, 3, CAST(N'2016-08-30 00:00:00.000' AS DateTime), CAST(N'2016-12-25 00:00:00.000' AS DateTime), -1, NULL)
INSERT [dbo].[Docgia_Sach] ([DocgiaID], [SachID], [Ngaymuon], [Ngaytra], [Tinhtrang], [Ghichu]) VALUES (1, 1, CAST(N'2017-01-25 00:00:00.000' AS DateTime), CAST(N'2017-06-25 00:00:00.000' AS DateTime), 0, NULL)
INSERT [dbo].[Docgia_Sach] ([DocgiaID], [SachID], [Ngaymuon], [Ngaytra], [Tinhtrang], [Ghichu]) VALUES (2, 10, CAST(N'2017-01-26 00:00:00.000' AS DateTime), CAST(N'2017-06-25 00:00:00.000' AS DateTime), 0, NULL)
INSERT [dbo].[Docgia_Sach] ([DocgiaID], [SachID], [Ngaymuon], [Ngaytra], [Tinhtrang], [Ghichu]) VALUES (2, 1, CAST(N'2017-01-26 00:00:00.000' AS DateTime), CAST(N'2017-06-25 00:00:00.000' AS DateTime), 0, NULL)
INSERT [dbo].[Docgia_Sach] ([DocgiaID], [SachID], [Ngaymuon], [Ngaytra], [Tinhtrang], [Ghichu]) VALUES (2, 3, CAST(N'2017-01-26 00:00:00.000' AS DateTime), CAST(N'2017-06-25 00:00:00.000' AS DateTime), 0, NULL)
INSERT [dbo].[Docgia_Sach] ([DocgiaID], [SachID], [Ngaymuon], [Ngaytra], [Tinhtrang], [Ghichu]) VALUES (3, 5, CAST(N'2017-01-21 00:00:00.000' AS DateTime), CAST(N'2017-06-25 00:00:00.000' AS DateTime), 0, NULL)
INSERT [dbo].[Docgia_Sach] ([DocgiaID], [SachID], [Ngaymuon], [Ngaytra], [Tinhtrang], [Ghichu]) VALUES (5, 8, CAST(N'2017-01-27 00:00:00.000' AS DateTime), CAST(N'2017-06-25 00:00:00.000' AS DateTime), 0, NULL)
INSERT [dbo].[Docgia_Sach] ([DocgiaID], [SachID], [Ngaymuon], [Ngaytra], [Tinhtrang], [Ghichu]) VALUES (4, 9, CAST(N'2016-08-30 00:00:00.000' AS DateTime), CAST(N'2016-12-25 00:00:00.000' AS DateTime), -1, NULL)
SET IDENTITY_INSERT [dbo].[Hehoc] ON 

INSERT [dbo].[Hehoc] ([HehocID], [Tenhehoc]) VALUES (1, N'Quân sự')
INSERT [dbo].[Hehoc] ([HehocID], [Tenhehoc]) VALUES (2, N'Dân sự')
SET IDENTITY_INSERT [dbo].[Hehoc] OFF
SET IDENTITY_INSERT [dbo].[Nhanvien] ON 

INSERT [dbo].[Nhanvien] ([NhanvienID], [Ten]) VALUES (1, N'Nguyễn Thị Bích Ngọc')
INSERT [dbo].[Nhanvien] ([NhanvienID], [Ten]) VALUES (2, N'Vũ Thị Thanh Hoài')
INSERT [dbo].[Nhanvien] ([NhanvienID], [Ten]) VALUES (3, N'Nguyễn Thị Mai')
INSERT [dbo].[Nhanvien] ([NhanvienID], [Ten]) VALUES (4, N'Triệu Khánh Linh')
INSERT [dbo].[Nhanvien] ([NhanvienID], [Ten]) VALUES (5, N'Nguyễn Thị Vân Ạnh')
INSERT [dbo].[Nhanvien] ([NhanvienID], [Ten]) VALUES (6, N'Phan Thị Lý')
INSERT [dbo].[Nhanvien] ([NhanvienID], [Ten]) VALUES (7, N'Nguyễn Thị Lan Anh')
INSERT [dbo].[Nhanvien] ([NhanvienID], [Ten]) VALUES (8, N'Tạ Thị Cẩm Tú')
SET IDENTITY_INSERT [dbo].[Nhanvien] OFF
INSERT [dbo].[Nhanvien_Sach] ([NhanvienID], [SachID], [Ghichu]) VALUES (1, 1, NULL)
INSERT [dbo].[Nhanvien_Sach] ([NhanvienID], [SachID], [Ghichu]) VALUES (2, 4, NULL)
INSERT [dbo].[Nhanvien_Sach] ([NhanvienID], [SachID], [Ghichu]) VALUES (3, 2, NULL)
INSERT [dbo].[Nhanvien_Sach] ([NhanvienID], [SachID], [Ghichu]) VALUES (4, 3, NULL)
INSERT [dbo].[Nhanvien_Sach] ([NhanvienID], [SachID], [Ghichu]) VALUES (5, 6, NULL)
INSERT [dbo].[Nhanvien_Sach] ([NhanvienID], [SachID], [Ghichu]) VALUES (6, 5, NULL)
INSERT [dbo].[Nhanvien_Sach] ([NhanvienID], [SachID], [Ghichu]) VALUES (7, 8, NULL)
INSERT [dbo].[Nhanvien_Sach] ([NhanvienID], [SachID], [Ghichu]) VALUES (8, 7, NULL)
INSERT [dbo].[Nhanvien_Sach] ([NhanvienID], [SachID], [Ghichu]) VALUES (1, 9, NULL)
INSERT [dbo].[Nhanvien_Sach] ([NhanvienID], [SachID], [Ghichu]) VALUES (4, 11, NULL)
INSERT [dbo].[Nhanvien_Sach] ([NhanvienID], [SachID], [Ghichu]) VALUES (2, 10, NULL)
SET IDENTITY_INSERT [dbo].[Nhaxuatban] ON 

INSERT [dbo].[Nhaxuatban] ([NhaxuatbanID], [Tennhaxuatban]) VALUES (1, N'Nhà xuất bản Giáo dục Việt Nam')
INSERT [dbo].[Nhaxuatban] ([NhaxuatbanID], [Tennhaxuatban]) VALUES (2, N'Nhà xuất bản Khoa học và Kỹ thuật')
INSERT [dbo].[Nhaxuatban] ([NhaxuatbanID], [Tennhaxuatban]) VALUES (3, N'Nhà xuất bản Đại học Quốc gia Hà Nội')
INSERT [dbo].[Nhaxuatban] ([NhaxuatbanID], [Tennhaxuatban]) VALUES (4, N'Nhà xuất bản Thông tin và Truyền thông')
INSERT [dbo].[Nhaxuatban] ([NhaxuatbanID], [Tennhaxuatban]) VALUES (5, N'Nhà xuất bản Chính trị Quốc gia')
INSERT [dbo].[Nhaxuatban] ([NhaxuatbanID], [Tennhaxuatban]) VALUES (6, N'Donna Spencer')
SET IDENTITY_INSERT [dbo].[Nhaxuatban] OFF
SET IDENTITY_INSERT [dbo].[Nhomquyen] ON 

INSERT [dbo].[Nhomquyen] ([NhomquyenID], [Tenquyen]) VALUES (1, N'Nhân viên')
INSERT [dbo].[Nhomquyen] ([NhomquyenID], [Tenquyen]) VALUES (2, N'Văn thư lưu trữ')
INSERT [dbo].[Nhomquyen] ([NhomquyenID], [Tenquyen]) VALUES (3, N'Chuyên viên thư viện - thông tin')
SET IDENTITY_INSERT [dbo].[Nhomquyen] OFF
INSERT [dbo].[Sach] ([SachID], [NhaxuatbanID], [VitriID], [Tensach], [Theloai], [Ngonngu], [Ngaycapnhat], [Namxuatban], [Hinhanh], [Sotrang], [Soluong], [Gia], [Mota]) VALUES (1, 2, 1, N'Công nghệ phần mềm', N'Giáo trình', N'Tiếng Việt', CAST(N'2016-03-04 00:00:00.000' AS DateTime), 2005, N'Anh\Cong-nghe-phan-mem.jpg', 240, 100, 42000, N'Khổ 19x27 cm, bìa màu xanh')
INSERT [dbo].[Sach] ([SachID], [NhaxuatbanID], [VitriID], [Tensach], [Theloai], [Ngonngu], [Ngaycapnhat], [Namxuatban], [Hinhanh], [Sotrang], [Soluong], [Gia], [Mota]) VALUES (2, 1, 4, N'Giáo trình Giáo dục quốc phòng - an ninh', N'Giáo trình', N'Tiếng Việt', CAST(N'2014-05-05 00:00:00.000' AS DateTime), 2011, N'Anh\Giao-duc-quoc-phong-an-ninh.jpg', 230, 400, 28000, N'Khổ 16x24 cm, bìa màu vàng')
INSERT [dbo].[Sach] ([SachID], [NhaxuatbanID], [VitriID], [Tensach], [Theloai], [Ngonngu], [Ngaycapnhat], [Namxuatban], [Hinhanh], [Sotrang], [Soluong], [Gia], [Mota]) VALUES (3, 3, 3, N'Cấu trúc dữ liệu và giải thuật', N'Sách tham khảo', N'Tiếng Việt', CAST(N'2015-03-04 00:00:00.000' AS DateTime), 2004, N'Anh\Cau-truc-du-lieu-va-giai-thuat.jpg', 310, 120, 32000, N'Khổ 16x24 cm, bìa màu xanh')
INSERT [dbo].[Sach] ([SachID], [NhaxuatbanID], [VitriID], [Tensach], [Theloai], [Ngonngu], [Ngaycapnhat], [Namxuatban], [Hinhanh], [Sotrang], [Soluong], [Gia], [Mota]) VALUES (4, 2, 2, N'Giáo trình Mạng Máy tính', N'Giáo trình', N'Tiếng Việt', CAST(N'2016-04-05 00:00:00.000' AS DateTime), 2015, N'Anh\Giao-trinh-mang-may-tinh.jpg', 200, 50, 65000, N'Khổ 16x24 cm, bìa màu đỏ')
INSERT [dbo].[Sach] ([SachID], [NhaxuatbanID], [VitriID], [Tensach], [Theloai], [Ngonngu], [Ngaycapnhat], [Namxuatban], [Hinhanh], [Sotrang], [Soluong], [Gia], [Mota]) VALUES (5, 3, 5, N'Vật lý hạt cơ bản', N'Sách tham khảo', N'Tiếng Việt', CAST(N'2916-08-07 00:00:00.000' AS DateTime), 2015, N'Anh\Vat-ly-hat-co-ban.jpg', 150, 45, 30000, N'Khổ 16x24 cm, bìa màu xanh')
INSERT [dbo].[Sach] ([SachID], [NhaxuatbanID], [VitriID], [Tensach], [Theloai], [Ngonngu], [Ngaycapnhat], [Namxuatban], [Hinhanh], [Sotrang], [Soluong], [Gia], [Mota]) VALUES (6, 3, 3, N'Toán rời rạc', N'Giáo trình', N'Tiếng Việt', CAST(N'2016-09-08 00:00:00.000' AS DateTime), 2012, N'Anh\Toan-roi-rac.jpg', 350, 450, 68000, N'Khổ 16x24 cm, bìa màu xanh, cam')
INSERT [dbo].[Sach] ([SachID], [NhaxuatbanID], [VitriID], [Tensach], [Theloai], [Ngonngu], [Ngaycapnhat], [Namxuatban], [Hinhanh], [Sotrang], [Soluong], [Gia], [Mota]) VALUES (7, 1, 1, N'Xác suất thống kê', N'Giáo trình', N'Tiếng Việt', CAST(N'2014-11-25 00:00:00.000' AS DateTime), 2010, N'Anh\Xac-suat-thong-ke.jpg', 305, 455, 42000, N'Khổ 16x24 cm, bìa màu xanh')
INSERT [dbo].[Sach] ([SachID], [NhaxuatbanID], [VitriID], [Tensach], [Theloai], [Ngonngu], [Ngaycapnhat], [Namxuatban], [Hinhanh], [Sotrang], [Soluong], [Gia], [Mota]) VALUES (8, 4, 4, N'Kỹ thuật phân tích và thiết kế Hệ thống thông tin Hướng cấu trúc', N'Sách tham khảo', N'Tiếng Việt', CAST(N'2015-06-09 00:00:00.000' AS DateTime), 2009, N'Anh\Ky-thuat-phan-tich-va-thiet-ke-he-thong-thong-tin.jpg', 270, 70, 48000, N'Khổ 16x24 cm, bìa màu xanh nhạt')
INSERT [dbo].[Sach] ([SachID], [NhaxuatbanID], [VitriID], [Tensach], [Theloai], [Ngonngu], [Ngaycapnhat], [Namxuatban], [Hinhanh], [Sotrang], [Soluong], [Gia], [Mota]) VALUES (9, 5, 2, N'Giáo trình Những nguyên lý cơ bản của chủ nghĩa Mác-Lênin', N'Giáo trình', N'Tiếng Việt', CAST(N'2016-08-07 00:00:00.000' AS DateTime), 2014, N'Anh\Giao-trinh-nhung-nguyen-ly-co-ban-cua-chu-nghia-mac-lenin.jpg', 495, 500, 36000, N'Khổ 14,5x20,5 cm, bìa màu xanh nhạt')
INSERT [dbo].[Sach] ([SachID], [NhaxuatbanID], [VitriID], [Tensach], [Theloai], [Ngonngu], [Ngaycapnhat], [Namxuatban], [Hinhanh], [Sotrang], [Soluong], [Gia], [Mota]) VALUES (10, 5, 1, N'Giáo trình Tư tưởng Hồ Chí Minh', N'Giáo trình', N'Tiếng Việt', CAST(N'2016-09-08 00:00:00.000' AS DateTime), 2009, N'Anh\Giao-trinh-tu-tuong-Ho-Chi-Minh.jpg', 290, 460, 31000, N'Khổ 13x19 cm, bìa màu đỏ nhạt')
INSERT [dbo].[Sach] ([SachID], [NhaxuatbanID], [VitriID], [Tensach], [Theloai], [Ngonngu], [Ngaycapnhat], [Namxuatban], [Hinhanh], [Sotrang], [Soluong], [Gia], [Mota]) VALUES (11, 6, 5, N'A Practical Guide to Information Architecture', N'Sách tham khảo', N'Tiếng Anh', CAST(N'2016-09-08 00:00:00.000' AS DateTime), 2010, N'Anh\A-practical-guide-to-information-architecture.jpg', 200, 30, 59000, N'Khổ 16x24 cm, bìa màu xanh nhạt')
SET IDENTITY_INSERT [dbo].[Taikhoan] ON 

INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (1, 1, N'aaa', N'111111')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (2, 3, N'bbb', N'222222')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (3, 2, N'ccc', N'333333')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (4, 1, N'ddd', N'444444')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (5, 1, N'ggg', N'555555')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (6, 2, N'hhh', N'666666')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (7, 3, N'kkk', N'777777')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (8, 3, N'mmm', N'888888')
SET IDENTITY_INSERT [dbo].[Taikhoan] OFF
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (1, 1)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (5, 2)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (2, 3)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (7, 4)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (3, 5)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (8, 6)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (4, 7)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (6, 8)
SET IDENTITY_INSERT [dbo].[Vitri] ON 

INSERT [dbo].[Vitri] ([VitriID], [Mota]) VALUES (1, N'Giá sách số 1')
INSERT [dbo].[Vitri] ([VitriID], [Mota]) VALUES (2, N'Giá sách số 2')
INSERT [dbo].[Vitri] ([VitriID], [Mota]) VALUES (3, N'Giá sách số 3')
INSERT [dbo].[Vitri] ([VitriID], [Mota]) VALUES (4, N'Giá sách số 4')
INSERT [dbo].[Vitri] ([VitriID], [Mota]) VALUES (5, N'Giá sách số 5')
SET IDENTITY_INSERT [dbo].[Vitri] OFF
ALTER TABLE [dbo].[Docgia]  WITH CHECK ADD FOREIGN KEY([HehocID])
REFERENCES [dbo].[Hehoc] ([HehocID])
GO
ALTER TABLE [dbo].[Docgia_Sach]  WITH CHECK ADD FOREIGN KEY([DocgiaID])
REFERENCES [dbo].[Docgia] ([DocgiaID])
GO
ALTER TABLE [dbo].[Docgia_Sach]  WITH CHECK ADD FOREIGN KEY([SachID])
REFERENCES [dbo].[Sach] ([SachID])
GO
ALTER TABLE [dbo].[Nhanvien_Sach]  WITH CHECK ADD FOREIGN KEY([NhanvienID])
REFERENCES [dbo].[Nhanvien] ([NhanvienID])
GO
ALTER TABLE [dbo].[Nhanvien_Sach]  WITH CHECK ADD FOREIGN KEY([SachID])
REFERENCES [dbo].[Sach] ([SachID])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([NhaxuatbanID])
REFERENCES [dbo].[Nhaxuatban] ([NhaxuatbanID])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([VitriID])
REFERENCES [dbo].[Vitri] ([VitriID])
GO
ALTER TABLE [dbo].[Taikhoan]  WITH CHECK ADD FOREIGN KEY([NhomquyenID])
REFERENCES [dbo].[Nhomquyen] ([NhomquyenID])
GO
ALTER TABLE [dbo].[Taikhoan_Nhanvien]  WITH CHECK ADD FOREIGN KEY([NhanvienID])
REFERENCES [dbo].[Nhanvien] ([NhanvienID])
GO
ALTER TABLE [dbo].[Taikhoan_Nhanvien]  WITH CHECK ADD FOREIGN KEY([TaikhoanID])
REFERENCES [dbo].[Taikhoan] ([TaikhoanID])
GO
