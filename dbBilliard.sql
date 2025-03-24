USE [master]
GO
/****** Object:  Database [BilliardClub]    Script Date: 24/03/2025 12:26:57 PM ******/
CREATE DATABASE [BilliardClub]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BilliardClub', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BilliardClub.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BilliardClub_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BilliardClub_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BilliardClub] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BilliardClub].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BilliardClub] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BilliardClub] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BilliardClub] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BilliardClub] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BilliardClub] SET ARITHABORT OFF 
GO
ALTER DATABASE [BilliardClub] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BilliardClub] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BilliardClub] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BilliardClub] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BilliardClub] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BilliardClub] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BilliardClub] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BilliardClub] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BilliardClub] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BilliardClub] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BilliardClub] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BilliardClub] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BilliardClub] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BilliardClub] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BilliardClub] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BilliardClub] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BilliardClub] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BilliardClub] SET RECOVERY FULL 
GO
ALTER DATABASE [BilliardClub] SET  MULTI_USER 
GO
ALTER DATABASE [BilliardClub] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BilliardClub] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BilliardClub] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BilliardClub] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BilliardClub] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BilliardClub] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BilliardClub', N'ON'
GO
ALTER DATABASE [BilliardClub] SET QUERY_STORE = ON
GO
ALTER DATABASE [BilliardClub] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BilliardClub]
GO
/****** Object:  Table [dbo].[ban]    Script Date: 24/03/2025 12:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ban](
	[IDban] [nchar](10) NOT NULL,
	[Tenban] [nvarchar](20) NULL,
	[Tinhtrang] [bit] NULL,
	[Khuvuc] [nchar](10) NULL,
	[GioBD] [datetime] NULL,
	[GioKT] [datetime] NULL,
	[Dongia] [money] NULL,
	[Loaiban] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitietHoadon]    Script Date: 24/03/2025 12:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietHoadon](
	[IDhoadon] [nchar](10) NOT NULL,
	[IDban] [nchar](10) NULL,
	[IDhanghoa] [nchar](10) NULL,
	[Soluong] [int] NULL,
	[Sogiochoi] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hanghoa]    Script Date: 24/03/2025 12:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hanghoa](
	[IDhanghoa] [nchar](10) NOT NULL,
	[Tenhanghoa] [nvarchar](30) NULL,
	[Donvi] [int] NULL,
	[Gia] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDhanghoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 24/03/2025 12:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[IDhoadon] [nchar](10) NOT NULL,
	[Ngaylap] [datetime] NULL,
	[Tongtien] [money] NULL,
	[Trangthai] [bit] NULL,
	[IDkh] [nchar](10) NULL,
	[IDnv] [nchar](10) NOT NULL,
 CONSTRAINT [PK__hoadon__8F9CB309F871292B] PRIMARY KEY CLUSTERED 
(
	[IDhoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 24/03/2025 12:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[IDkh] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[Sdt] [int] NULL,
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[IDkh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kho]    Script Date: 24/03/2025 12:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kho](
	[IDhanghoa] [nchar](10) NOT NULL,
	[Soluong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 24/03/2025 12:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[IDnv] [nchar](10) NOT NULL,
	[Ho] [nvarchar](20) NULL,
	[Ten] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[Gioitinh] [bit] NULL,
	[Chucvu] [nchar](10) NULL,
	[Matkhau] [nchar](50) NOT NULL,
 CONSTRAINT [PK__nhanvien__B87ECD8AFDD9E92B] PRIMARY KEY CLUSTERED 
(
	[IDnv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[chitietHoadon]  WITH CHECK ADD  CONSTRAINT [FK_chitietHoadon_ban] FOREIGN KEY([IDban])
REFERENCES [dbo].[ban] ([IDban])
GO
ALTER TABLE [dbo].[chitietHoadon] CHECK CONSTRAINT [FK_chitietHoadon_ban]
GO
ALTER TABLE [dbo].[chitietHoadon]  WITH CHECK ADD  CONSTRAINT [FK_chitietHoadon_hanghoa] FOREIGN KEY([IDhanghoa])
REFERENCES [dbo].[hanghoa] ([IDhanghoa])
GO
ALTER TABLE [dbo].[chitietHoadon] CHECK CONSTRAINT [FK_chitietHoadon_hanghoa]
GO
ALTER TABLE [dbo].[chitietHoadon]  WITH CHECK ADD  CONSTRAINT [FK_chitietHoadon_hoadon] FOREIGN KEY([IDhoadon])
REFERENCES [dbo].[hoadon] ([IDhoadon])
GO
ALTER TABLE [dbo].[chitietHoadon] CHECK CONSTRAINT [FK_chitietHoadon_hoadon]
GO
ALTER TABLE [dbo].[hoadon]  WITH NOCHECK ADD  CONSTRAINT [FK_hoadon_khachhang] FOREIGN KEY([IDkh])
REFERENCES [dbo].[khachhang] ([IDkh])
GO
ALTER TABLE [dbo].[hoadon] NOCHECK CONSTRAINT [FK_hoadon_khachhang]
GO
ALTER TABLE [dbo].[hoadon]  WITH NOCHECK ADD  CONSTRAINT [FK_hoadon_nhanvien] FOREIGN KEY([IDnv])
REFERENCES [dbo].[nhanvien] ([IDnv])
GO
ALTER TABLE [dbo].[hoadon] NOCHECK CONSTRAINT [FK_hoadon_nhanvien]
GO
ALTER TABLE [dbo].[kho]  WITH CHECK ADD  CONSTRAINT [FK_kho_hanghoa] FOREIGN KEY([IDhanghoa])
REFERENCES [dbo].[hanghoa] ([IDhanghoa])
GO
ALTER TABLE [dbo].[kho] CHECK CONSTRAINT [FK_kho_hanghoa]
GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVienNgauNhien]    Script Date: 24/03/2025 12:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNhanVienNgauNhien]
AS
BEGIN
    DECLARE @i INT = 1;
    DECLARE @Ho NVARCHAR(50);
    DECLARE @Ten NVARCHAR(50);

    DECLARE @DanhSachHo NVARCHAR(MAX) = N'Nguyen,Tran,Le,Pham,Hoang,Vu,Vo,Phan,Do,Dao,Ho,Dang,Bui,Duong,Trinh,Thai,Tu,Chau';
    DECLARE @DanhSachTen NVARCHAR(MAX) = N'An,Binh,Chau,Duy,Giang,Hai,Hoang,Kim,Linh,Minh,Nam,Phong,Quyen,Sang,Son,Thao,Trang,Vu';

    WHILE @i <= 10
    BEGIN
        -- Lấy Họ ngẫu nhiên
        SELECT @Ho = LTRIM(RTRIM(value))
        FROM STRING_SPLIT(@DanhSachHo, ',')
        ORDER BY NEWID();

        -- Lấy Tên ngẫu nhiên
        SELECT @Ten = LTRIM(RTRIM(value))
        FROM STRING_SPLIT(@DanhSachTen, ',')
        ORDER BY NEWID();

        -- Thêm dữ liệu ngẫu nhiên vào bảng NhanVien
        INSERT INTO NhanVien (IDnv, Ho, Ten, Ngaysinh, Gioitinh, Chucvu, Matkhau)
        VALUES (
            LEFT(NEWID(), 4),                             -- IDnv ngẫu nhiên
            @Ho,                                           -- Họ ngẫu nhiên
            @Ten,                                          -- Tên ngẫu nhiên
            DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 10000), GETDATE()), -- Ngày sinh ngẫu nhiên
            CASE WHEN RAND() < 0.5 THEN N'Nam' ELSE N'Nữ' END,       -- Giới tính ngẫu nhiên
            CASE WHEN RAND() < 0.2 THEN N'admin' ELSE N'staff' END,  -- Chức vụ ngẫu nhiên (20% admin)
            LEFT(NEWID(), 4)                                        -- Mật khẩu ngẫu nhiên
        );

        SET @i = @i + 1;
    END;
END;
GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVienNgauNhien1]    Script Date: 24/03/2025 12:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNhanVienNgauNhien1]
AS
BEGIN
    DECLARE @i INT = 1;
    DECLARE @Ho NVARCHAR(50);
    DECLARE @Ten NVARCHAR(50);

    DECLARE @DanhSachHo NVARCHAR(MAX) = N'Nguyen,Tran,Le,Pham,Hoang,Vu,Vo,Phan,Do,Dao,Ho,Dang,Bui,Duong,Trinh,Thai,Tu,Chau';
    DECLARE @DanhSachTen NVARCHAR(MAX) = N'An,Binh,Chau,Duy,Giang,Hai,Hoang,Kim,Linh,Minh,Nam,Phong,Quyen,Sang,Son,Thao,Trang,Vu';

    WHILE @i <= 10
    BEGIN
        -- Lấy Họ ngẫu nhiên
        SELECT @Ho = LTRIM(RTRIM(value))
        FROM STRING_SPLIT(@DanhSachHo, ',')
        ORDER BY NEWID();

        -- Lấy Tên ngẫu nhiên
        SELECT @Ten = LTRIM(RTRIM(value))
        FROM STRING_SPLIT(@DanhSachTen, ',')
        ORDER BY NEWID();

        -- Thêm dữ liệu ngẫu nhiên vào bảng NhanVien
        INSERT INTO NhanVien (IDnv, Ho, Ten, Ngaysinh, Gioitinh, Chucvu, Matkhau)
        VALUES (
            LEFT(NEWID(), 4),                             -- IDnv ngẫu nhiên
            @Ho,                                           -- Họ ngẫu nhiên
            @Ten,                                          -- Tên ngẫu nhiên
            DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 10000), GETDATE()), -- Ngày sinh ngẫu nhiên
            CASE WHEN RAND() < 0.5 THEN 0 ELSE 1 END,       -- Giới tính ngẫu nhiên
            CASE WHEN RAND() < 0.2 THEN N'admin' ELSE N'staff' END,  -- Chức vụ ngẫu nhiên (20% admin)
            LEFT(NEWID(), 4)                                        -- Mật khẩu ngẫu nhiên
        );

        SET @i = @i + 1;
    END;
END;
GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVienNgauNhien2]    Script Date: 24/03/2025 12:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNhanVienNgauNhien2]
AS
BEGIN
    DECLARE @i INT = 1;
    DECLARE @Ho NVARCHAR(50);
    DECLARE @Ten NVARCHAR(50);

    DECLARE @DanhSachHo NVARCHAR(MAX) = N'Nguyen,Tran,Le,Pham,Hoang,Vu,Vo,Phan,Do,Dao,Ho,Dang,Bui,Duong,Trinh,Thai,Tu,Chau';
    DECLARE @DanhSachTen NVARCHAR(MAX) = N'An,Binh,Chau,Duy,Giang,Hai,Hoang,Kim,Linh,Minh,Nam,Phong,Quyen,Sang,Son,Thao,Trang,Vu';

    WHILE @i <= 10
    BEGIN
        -- Lấy Họ ngẫu nhiên
        SELECT @Ho = LTRIM(RTRIM(value))
        FROM STRING_SPLIT(@DanhSachHo, ',')
        ORDER BY NEWID();

        -- Lấy Tên ngẫu nhiên
        SELECT @Ten = LTRIM(RTRIM(value))
        FROM STRING_SPLIT(@DanhSachTen, ',')
        ORDER BY NEWID();

        -- Thêm dữ liệu ngẫu nhiên vào bảng NhanVien
        INSERT INTO NhanVien (IDnv, Ho, Ten, Ngaysinh, Gioitinh, Chucvu, Matkhau)
        VALUES (
            @i,                             -- IDnv ngẫu nhiên
            @Ho,                                           -- Họ ngẫu nhiên
            @Ten,                                          -- Tên ngẫu nhiên
            DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 10000), GETDATE()), -- Ngày sinh ngẫu nhiên
            CASE WHEN RAND() < 0.5 THEN 0 ELSE 1 END,       -- Giới tính ngẫu nhiên
            CASE WHEN RAND() < 0.2 THEN N'admin' ELSE N'staff' END,  -- Chức vụ ngẫu nhiên (20% admin)
            LEFT(NEWID(), 4)                                        -- Mật khẩu ngẫu nhiên
        );

        SET @i = @i + 1;
    END;
END;
GO
USE [master]
GO
ALTER DATABASE [BilliardClub] SET  READ_WRITE 
GO
