USE [master]
GO
/****** Object:  Database [Quanlidoansinhvien]    Script Date: 11/22/2021 4:24:05 PM ******/
CREATE DATABASE [Quanlidoansinhvien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quanlidoansinhvien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Quanlidoansinhvien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Quanlidoansinhvien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Quanlidoansinhvien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Quanlidoansinhvien] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quanlidoansinhvien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quanlidoansinhvien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quanlidoansinhvien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quanlidoansinhvien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quanlidoansinhvien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quanlidoansinhvien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Quanlidoansinhvien] SET  MULTI_USER 
GO
ALTER DATABASE [Quanlidoansinhvien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quanlidoansinhvien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quanlidoansinhvien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quanlidoansinhvien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quanlidoansinhvien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quanlidoansinhvien] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Quanlidoansinhvien] SET QUERY_STORE = OFF
GO
USE [Quanlidoansinhvien]
GO
/****** Object:  Table [dbo].[BaoCao]    Script Date: 11/22/2021 4:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao](
	[IDBaoCao] [nchar](10) NOT NULL,
	[IDDeTai] [nvarchar](50) NULL,
	[LanBaoCao] [int] NULL,
	[TaiLieu] [nvarchar](100) NULL,
	[NhanXet] [nvarchar](500) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_NhanXetTheoTuan] PRIMARY KEY CLUSTERED 
(
	[IDBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeTai]    Script Date: 11/22/2021 4:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeTai](
	[ID] [nvarchar](50) NOT NULL,
	[TenDeTai] [nvarchar](50) NULL,
	[LoaiDeTai] [nvarchar](50) NULL,
	[GiaoVienHuongDan] [nvarchar](50) NULL,
	[MoTa] [nvarchar](1000) NULL,
	[SoLuongSinhVien] [int] NULL,
	[ThoiGianBatDau] [date] NULL,
	[ThoiGianKetThuc] [date] NULL,
	[SoLanBaoCao] [int] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_DeTai] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 11/22/2021 4:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[ID] [nvarchar](50) NOT NULL,
	[HoiDong] [nvarchar](50) NULL,
	[Diem] [int] NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 11/22/2021 4:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[ID] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoiDong]    Script Date: 11/22/2021 4:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoiDong](
	[ID] [nvarchar](50) NOT NULL,
	[Detai] [nvarchar](50) NULL,
	[NgayBC] [date] NULL,
	[SoNguoiHD] [int] NULL,
	[NhanXet] [nvarchar](150) NULL,
 CONSTRAINT [PK_HoiDong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDeTai]    Script Date: 11/22/2021 4:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDeTai](
	[ID] [nvarchar](50) NOT NULL,
	[LoaiDeTai] [nvarchar](50) NULL,
	[MoTa] [nvarchar](200) NULL,
 CONSTRAINT [PK_LoaiDeTai] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 11/22/2021 4:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Login_1] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 11/22/2021 4:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[ID] [nvarchar](100) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
	[DeTai] [nvarchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BaoCao] ([IDBaoCao], [IDDeTai], [LanBaoCao], [TaiLieu], [NhanXet], [TrangThai]) VALUES (N'đasa      ', N'dt2', 1, N'đá', N'đâsd', 1)
INSERT [dbo].[BaoCao] ([IDBaoCao], [IDDeTai], [LanBaoCao], [TaiLieu], [NhanXet], [TrangThai]) VALUES (N'dsdad     ', N'dt2', 1, N'đasadad', N'đasads', 1)
GO
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [LoaiDeTai], [GiaoVienHuongDan], [MoTa], [SoLuongSinhVien], [ThoiGianBatDau], [ThoiGianKetThuc], [SoLanBaoCao], [TinhTrang]) VALUES (N'dt1', N'Đề tài 1', N'DACK', N'gv1', N'không có gì', 2, CAST(N'2021-11-14' AS Date), CAST(N'2021-11-20' AS Date), 5, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [LoaiDeTai], [GiaoVienHuongDan], [MoTa], [SoLuongSinhVien], [ThoiGianBatDau], [ThoiGianKetThuc], [SoLanBaoCao], [TinhTrang]) VALUES (N'dt2', N'dsdsads', N'DACK', N'gv1', N'đasadsadas', 3, CAST(N'2021-11-21' AS Date), CAST(N'2021-11-30' AS Date), 5, 1)
GO
INSERT [dbo].[Diem] ([ID], [HoiDong], [Diem]) VALUES (N'diem1', N'hd1', 9)
GO
INSERT [dbo].[GiaoVien] ([ID], [Ten], [NgaySinh], [GioiTinh], [ChucVu], [DiaChi], [Sdt]) VALUES (N'gv1', N'giao viên 1', CAST(N'1993-06-15' AS Date), 1, N'Giảng viên', N'123 test', N'097824656')
GO
INSERT [dbo].[HoiDong] ([ID], [Detai], [NgayBC], [SoNguoiHD], [NhanXet]) VALUES (N'hd1', N'dt1', CAST(N'2021-11-30' AS Date), 4, N'dsaf')
GO
INSERT [dbo].[LoaiDeTai] ([ID], [LoaiDeTai], [MoTa]) VALUES (N'DACK', N'Đồ án cuối kỳ', N'Đánh giá kiến thức của 1 môn học')
INSERT [dbo].[LoaiDeTai] ([ID], [LoaiDeTai], [MoTa]) VALUES (N'KLTN', N'Khóa Luận Tốt Nghiệp', N'Đánh giá năng lực của sinh viên đã đủ để tốt nghiệp chưa. ')
INSERT [dbo].[LoaiDeTai] ([ID], [LoaiDeTai], [MoTa]) VALUES (N'TLCN', N'Tiểu Luận Chuyên Ngành', N'Đánh giá chuyên ngành sinh viên theo học')
GO
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'admin', N'123')
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'sinhvien', N'123')
GO
INSERT [dbo].[SinhVien] ([ID], [Ten], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [DeTai]) VALUES (N'21321321', N'nguyễn a', 1, CAST(N'2000-06-14' AS Date), N'123 abc', N'036568656', N'dt1')
GO
ALTER TABLE [dbo].[BaoCao]  WITH CHECK ADD  CONSTRAINT [FK_BaoCao_DeTai] FOREIGN KEY([IDDeTai])
REFERENCES [dbo].[DeTai] ([ID])
GO
ALTER TABLE [dbo].[BaoCao] CHECK CONSTRAINT [FK_BaoCao_DeTai]
GO
ALTER TABLE [dbo].[DeTai]  WITH CHECK ADD  CONSTRAINT [FK_DeTai_GiaoVien] FOREIGN KEY([GiaoVienHuongDan])
REFERENCES [dbo].[GiaoVien] ([ID])
GO
ALTER TABLE [dbo].[DeTai] CHECK CONSTRAINT [FK_DeTai_GiaoVien]
GO
ALTER TABLE [dbo].[DeTai]  WITH CHECK ADD  CONSTRAINT [FK_DeTai_LoaiDeTai] FOREIGN KEY([LoaiDeTai])
REFERENCES [dbo].[LoaiDeTai] ([ID])
GO
ALTER TABLE [dbo].[DeTai] CHECK CONSTRAINT [FK_DeTai_LoaiDeTai]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_HoiDong] FOREIGN KEY([HoiDong])
REFERENCES [dbo].[HoiDong] ([ID])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_HoiDong]
GO
ALTER TABLE [dbo].[HoiDong]  WITH CHECK ADD  CONSTRAINT [FK_HoiDong_DeTai] FOREIGN KEY([Detai])
REFERENCES [dbo].[DeTai] ([ID])
GO
ALTER TABLE [dbo].[HoiDong] CHECK CONSTRAINT [FK_HoiDong_DeTai]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_DeTai] FOREIGN KEY([DeTai])
REFERENCES [dbo].[DeTai] ([ID])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_DeTai]
GO
USE [master]
GO
ALTER DATABASE [Quanlidoansinhvien] SET  READ_WRITE 
GO
