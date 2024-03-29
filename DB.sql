USE [master]
GO
/****** Object:  Database [GiuXe]    Script Date: 10/25/2021 9:28:53 PM ******/
CREATE DATABASE [GiuXe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GiuXe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TAIPHAN\MSSQL\DATA\GiuXe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GiuXe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TAIPHAN\MSSQL\DATA\GiuXe_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GiuXe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GiuXe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GiuXe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GiuXe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GiuXe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GiuXe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GiuXe] SET ARITHABORT OFF 
GO
ALTER DATABASE [GiuXe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GiuXe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GiuXe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GiuXe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GiuXe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GiuXe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GiuXe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GiuXe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GiuXe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GiuXe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GiuXe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GiuXe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GiuXe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GiuXe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GiuXe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GiuXe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GiuXe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GiuXe] SET RECOVERY FULL 
GO
ALTER DATABASE [GiuXe] SET  MULTI_USER 
GO
ALTER DATABASE [GiuXe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GiuXe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GiuXe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GiuXe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GiuXe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GiuXe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GiuXe', N'ON'
GO
ALTER DATABASE [GiuXe] SET QUERY_STORE = OFF
GO
USE [GiuXe]
GO
/****** Object:  User [QuanLi]    Script Date: 10/25/2021 9:28:54 PM ******/
CREATE USER [QuanLi] FOR LOGIN [QuanLi] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NhanVien]    Script Date: 10/25/2021 9:28:54 PM ******/
CREATE USER [NhanVien] FOR LOGIN [NhanVien] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Admin]    Script Date: 10/25/2021 9:28:54 PM ******/
CREATE USER [Admin] FOR LOGIN [Admin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [Admin]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Id] [int] NOT NULL,
	[TenNV] [nchar](20) NULL,
	[GioiTinh] [nchar](10) NULL,
	[SoDT] [nchar](12) NULL,
	[DiaChi] [text] NULL,
	[MaQL] [int] NOT NULL,
	[Username] [nchar](10) NULL,
	[Pass] [nchar](10) NULL,
	[Anh] [image] NULL,
	[NgaySinh] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[DS_NV]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[DS_NV] as
select *
from NhanVien

GO
/****** Object:  Table [dbo].[Ca]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ca](
	[ID_Ca] [int] NOT NULL,
	[Thoi_Gian_Bat_Dau] [time](7) NULL,
	[Thoi_Gian_Ket_Thuc] [time](7) NULL,
 CONSTRAINT [PK_Ca] PRIMARY KEY CLUSTERED 
(
	[ID_Ca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ca_Lam]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Ca_Lam] as
select *
from Ca

GO
/****** Object:  Table [dbo].[ChiaCa]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiaCa](
	[Id] [int] NOT NULL,
	[Ca] [int] NOT NULL,
	[Ngay] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Ca] ASC,
	[Ngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PhanCong]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[PhanCong] as
select *
from ChiaCa

GO
/****** Object:  Table [dbo].[GioLamCuaNV]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioLamCuaNV](
	[ID] [int] NOT NULL,
	[Ngay] [date] NOT NULL,
	[Check_In] [datetime] NULL,
	[Check_Out] [datetime] NULL,
	[Ca] [int] NOT NULL,
 CONSTRAINT [PK_GioLamCuaNV] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[Ngay] ASC,
	[Ca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[CheckIn_Out]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[CheckIn_Out] as
select *
from GioLamCuaNV

GO
/****** Object:  Table [dbo].[role_acc]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role_acc](
	[id_nv] [int] NOT NULL,
	[role_name] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_NV_Theo_MQL]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[f_Thong_Tin_NV_Theo_MQL](@maQL int)
returns table
as 
return (select NhanVien.Id, TenNV, GioiTinh, NgaySinh, SoDT, role_name, DiaChi,MaQL, Anh  
from NhanVien, role_acc where NhanVien.MaQL=@maQL and NhanVien.Id = role_acc.id_nv)
GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_All_NV]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[f_Thong_Tin_All_NV]()
returns table
as
	return select NhanVien.Id, TenNV, GioiTinh, NgaySinh, SoDT, role_name, DiaChi,MaQL, Anh 
	from NhanVien, role_acc
	where NhanVien.Id = role_acc.id_nv
GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_NV_Theo_ID]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[f_Thong_Tin_NV_Theo_ID](@id int)
returns table
as 
return (select NhanVien.Id, TenNV, GioiTinh, NgaySinh, SoDT, role_name, DiaChi,MaQL, Anh  
from NhanVien, role_acc where NhanVien.Id = @id and NhanVien.Id = role_acc.id_nv)
GO
/****** Object:  UserDefinedFunction [dbo].[f_thong_tin_all_QL]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[f_thong_tin_all_QL]()
returns table
as
	return select nhanvien.id, nhanvien.tennv 
			from nhanvien, role_acc 
			where nhanvien.id = role_acc.id_nv and role_acc.role_name = 'QuanLi'
GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_NV]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[f_Thong_Tin_NV](@maNV int)
returns table
as 
return (select * from NhanVien where NhanVien.Id=@maNV)
GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_NV_Lay_TheoID_HoTen]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[f_Thong_Tin_NV_Lay_TheoID_HoTen](@maNV int, @hoTenNV nchar(20))
returns table
as 
return (select * from NhanVien where NhanVien.Id=@maNV or NhanVien.TenNV=@hoTenNV)
GO
/****** Object:  Table [dbo].[Khach_hang_ngay]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach_hang_ngay](
	[BienXe] [nchar](10) NOT NULL,
	[Check_in] [datetime] NOT NULL,
	[Check_out] [datetime] NULL,
	[Anh] [image] NULL,
	[Phi] [int] NULL,
	[Phat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BienXe] ASC,
	[Check_in] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_Xe_Ve_Ngay_Trong_Bai]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[f_Thong_Tin_Xe_Ve_Ngay_Trong_Bai](@bienxe nchar(10))
returns table
as
	return select BienXe, Check_in, Anh from Khach_hang_ngay where BienXe = @bienxe and Check_out is null
GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_Xe_Ve_Ngay]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[f_Thong_Tin_Xe_Ve_Ngay](@bienXe nchar(10))
returns table
as 
return (select * from Khach_hang_ngay where Khach_hang_ngay.BienXe=@bienXe)
GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_All_Xe_Ve_Ngay_Trong_Bai]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[f_Thong_Tin_All_Xe_Ve_Ngay_Trong_Bai]()
returns table
as
	return select BienXe, Check_in, Anh from Khach_hang_ngay where Check_out is null
GO
/****** Object:  UserDefinedFunction [dbo].[f_Lay_MK_NV]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[f_Lay_MK_NV](@maNV int)
returns table
as 
return (select Username, Pass from NhanVien where NhanVien.Id=@maNV)
GO
/****** Object:  Table [dbo].[Check_in_out_Thang]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Check_in_out_Thang](
	[BienXe] [nchar](10) NOT NULL,
	[Check_in] [datetime] NOT NULL,
	[Check_out] [datetime] NULL,
	[Anh] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[BienXe] ASC,
	[Check_in] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dang_ky_Thang]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dang_ky_Thang](
	[BienXe] [nchar](10) NOT NULL,
	[Ngay_DK] [datetime] NOT NULL,
	[Ngay_Het_Han] [datetime] NULL,
	[Phi] [int] NULL,
	[Phat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BienXe] ASC,
	[Ngay_DK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khach_Hang_Thang]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach_Hang_Thang](
	[BienXe] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [text] NULL,
	[SDT] [nchar](10) NULL,
	[Anh] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[BienXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[f_thong_tin_xe_thang_trong_bai]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[f_thong_tin_xe_thang_trong_bai]()
returns table
as 
	return select kh.BienXe, kh.TenKH, kh.DiaChi, kh.SDT, kh.Anh, ch.Check_in
	from Khach_Hang_Thang as kh, Dang_ky_Thang as dk, Check_in_out_Thang as ch
	where kh.BienXe = ch.BienXe and kh.BienXe = dk.BienXe and ch.Check_out is null
GO
/****** Object:  UserDefinedFunction [dbo].[f_thong_tin_xe_thang_trong_bai_theo_bien]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[f_thong_tin_xe_thang_trong_bai_theo_bien](@bienxe nchar(10))
returns table
as 
	return select kh.BienXe, kh.TenKH, kh.DiaChi, kh.SDT, kh.Anh, ch.Check_in
	from Khach_Hang_Thang as kh, Dang_ky_Thang as dk, Check_in_out_Thang as ch
	where kh.BienXe = ch.BienXe and kh.BienXe = dk.BienXe and ch.Check_out is null and kh.BienXe = @bienxe
GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_Xe_Ve_Thang]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[f_Thong_Tin_Xe_Ve_Thang](@bienXe nchar(10))
returns table
as 
return (select * from Check_in_out_Thang
where Check_in_out_Thang.Check_out is null and Check_in_out_Thang.BienXe=@bienXe)

GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_Lich_LV_NV]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[f_Thong_Tin_Lich_LV_NV](@maNV int)
returns table
as 
return (select * from ChiaCa
where ChiaCa.ID=@maNV)

GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_CheckIn_Out_NV]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[f_Thong_Tin_CheckIn_Out_NV](@maNV int)
returns table
as 
return (select * from GioLamCuaNV
where GioLamCuaNV.ID=@maNV)

GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_DKVeThang_Xe]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[f_Thong_Tin_DKVeThang_Xe](@bienXe char(10))
returns table
as 
return (select * from Dang_ky_Thang
where Dang_ky_Thang.BienXe=@bienXe)

GO
/****** Object:  UserDefinedFunction [dbo].[f_Thong_Tin_KH_DKVeThang]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[f_Thong_Tin_KH_DKVeThang](@bienXe char(10))
returns table
as 
return (select * from Khach_Hang_Thang
where Khach_Hang_Thang.BienXe=@bienXe) 

GO
/****** Object:  View [dbo].[Xe_Gui_Theo_Ngay]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Xe_Gui_Theo_Ngay] as
select *
from Khach_hang_ngay
where Khach_hang_ngay.Check_out is null

GO
/****** Object:  View [dbo].[Xe_Gui_Theo_Thang]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Xe_Gui_Theo_Thang] as
select *
from Check_in_out_Thang
where Check_in_out_Thang.Check_out is null

GO
/****** Object:  View [dbo].[Thong_Tin_KH_DK_VeThang]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Thong_Tin_KH_DK_VeThang] as
select TenKH, DiaChi,SDT,BienXe,Anh
from Khach_Hang_Thang

GO
ALTER TABLE [dbo].[Check_in_out_Thang]  WITH CHECK ADD  CONSTRAINT [FK_Check_in_out_Thang_Khach_Hang_THang] FOREIGN KEY([BienXe])
REFERENCES [dbo].[Khach_Hang_Thang] ([BienXe])
GO
ALTER TABLE [dbo].[Check_in_out_Thang] CHECK CONSTRAINT [FK_Check_in_out_Thang_Khach_Hang_THang]
GO
ALTER TABLE [dbo].[ChiaCa]  WITH CHECK ADD  CONSTRAINT [FK_chiaca_ca] FOREIGN KEY([Ca])
REFERENCES [dbo].[Ca] ([ID_Ca])
GO
ALTER TABLE [dbo].[ChiaCa] CHECK CONSTRAINT [FK_chiaca_ca]
GO
ALTER TABLE [dbo].[ChiaCa]  WITH CHECK ADD  CONSTRAINT [FK_chiaca_nhanvien] FOREIGN KEY([Id])
REFERENCES [dbo].[NhanVien] ([Id])
GO
ALTER TABLE [dbo].[ChiaCa] CHECK CONSTRAINT [FK_chiaca_nhanvien]
GO
ALTER TABLE [dbo].[Dang_ky_Thang]  WITH CHECK ADD  CONSTRAINT [FK_Dang_ky_Thang_Khach_hang_thang] FOREIGN KEY([BienXe])
REFERENCES [dbo].[Khach_Hang_Thang] ([BienXe])
GO
ALTER TABLE [dbo].[Dang_ky_Thang] CHECK CONSTRAINT [FK_Dang_ky_Thang_Khach_hang_thang]
GO
ALTER TABLE [dbo].[GioLamCuaNV]  WITH NOCHECK ADD  CONSTRAINT [FK_GioLamCuaNV_Ca] FOREIGN KEY([Ca])
REFERENCES [dbo].[Ca] ([ID_Ca])
GO
ALTER TABLE [dbo].[GioLamCuaNV] CHECK CONSTRAINT [FK_GioLamCuaNV_Ca]
GO
ALTER TABLE [dbo].[GioLamCuaNV]  WITH CHECK ADD  CONSTRAINT [FK_GioLamCuaNV_NhanVien] FOREIGN KEY([ID])
REFERENCES [dbo].[NhanVien] ([Id])
GO
ALTER TABLE [dbo].[GioLamCuaNV] CHECK CONSTRAINT [FK_GioLamCuaNV_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NhanVien] FOREIGN KEY([MaQL])
REFERENCES [dbo].[NhanVien] ([Id])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_NhanVien]
GO
ALTER TABLE [dbo].[role_acc]  WITH CHECK ADD  CONSTRAINT [Fk_role_acc_nhanvien] FOREIGN KEY([id_nv])
REFERENCES [dbo].[NhanVien] ([Id])
GO
ALTER TABLE [dbo].[role_acc] CHECK CONSTRAINT [Fk_role_acc_nhanvien]
GO
/****** Object:  StoredProcedure [dbo].[delete_nhan_vien]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delete_nhan_vien] @id int
as
	delete from NhanVien where Id = @id
GO
/****** Object:  StoredProcedure [dbo].[delete_role_acc]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delete_role_acc] @id int
as
	delete from role_acc where id_nv = @id
GO
/****** Object:  StoredProcedure [dbo].[insert_ca]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_ca]
@id int, @tg_bat_dau time, @tg_ket_thuc time
as
	insert into Ca(ID_Ca, Thoi_Gian_Bat_Dau, Thoi_Gian_Ket_Thuc)
	values(@id, @tg_bat_dau, @tg_ket_thuc)
GO
/****** Object:  StoredProcedure [dbo].[insert_check_in_out_thang]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_check_in_out_thang] 
@bienxe nchar(10), @check_in datetime, @anh image 
as 
	insert into Check_in_out_Thang(BienXe, Check_in, Anh) values(@bienxe, @check_in, @anh)
GO
/****** Object:  StoredProcedure [dbo].[insert_chia_ca]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_chia_ca]
@id_nv int, @id_ca int, @ngay datetime
as
	insert into ChiaCa(ID, Ca, Ngay) values(@id_ca, @id_ca, @ngay)
GO
/****** Object:  StoredProcedure [dbo].[insert_dang_ky_thang]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_dang_ky_thang]
@bienxe nchar(10), @ngay_dk datetime, @ngay_het_han datetime, @phi int
as
	insert into Dang_ky_Thang(BienXe, Ngay_DK, Ngay_Het_Han, Phi)
	values(@bienxe, @ngay_dk, @ngay_het_han, @phi)
GO
/****** Object:  StoredProcedure [dbo].[insert_gio_lam_nv]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_gio_lam_nv]
@id int, @ngay date, @ca int , @check_in datetime
as 
	insert into GioLamCuaNV(ID, Ngay, Ca, Check_In)
	values(@id, @ngay, @ca, @check_in)
GO
/****** Object:  StoredProcedure [dbo].[insert_khach_hang_ngay]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_khach_hang_ngay]
@bienxe nchar(10), @check_in datetime, @anh image
as
	insert into Khach_hang_ngay(BienXe, Check_in, Anh)
	values(@bienxe, @check_in, @anh)
GO
/****** Object:  StoredProcedure [dbo].[insert_khach_hang_thang]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insert_khach_hang_thang]  (@bienxe nchar(10), @tenKH nvarchar(50), @diachi text, @sdt nchar(10), @anh image )
as
begin tran
if(@tenKH is null)
begin
raiserror('ho ten khach hang khong duoc bo trong!',16,1)
rollback
return
end
insert into Khach_Hang_Thang(BienXe,TenKH,DiaChi,SDT,Anh) values (@bienxe, @tenKH, @diachi, @sdt, @anh)

commit tran
GO
/****** Object:  StoredProcedure [dbo].[insert_nhan_vien]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_nhan_vien]
@id int, @ten nchar(20), @gioitinh nchar(10), @sdt nchar(12), @diachi text, @maql int,
@user nchar(10), @pass nchar(10), @anh image, @ngaysinh date
as
	insert into NhanVien(id, TenNV, GioiTinh, SoDT, DiaChi, MaQL, Username, Pass, Anh, NgaySinh)
	values(@id, @ten, @gioitinh, @sdt, @diachi, @maql, @user, @pass, @anh, @ngaysinh)
GO
/****** Object:  StoredProcedure [dbo].[insert_role_acc]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_role_acc]
@id_nv int, @role_name nchar(20)
as
begin
	insert into role_acc(id_nv, role_name) values(@id_nv, @role_name)
end
GO
/****** Object:  StoredProcedure [dbo].[update_account_nhan_vien]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_account_nhan_vien]
@id int, @user nchar(10), @pass nchar(10)
as
	update NhanVien set Username = @user, Pass = @pass where Id = @id
GO
/****** Object:  StoredProcedure [dbo].[update_check_in_out_thang]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_check_in_out_thang] 
@bienxe nchar(10), @check_in datetime, @check_out datetime
as 
	update  Check_in_out_Thang set Check_out = @check_out 
	where @bienxe = BienXe and @check_out = Check_out
GO
/****** Object:  StoredProcedure [dbo].[update_gio_lam_nv]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_gio_lam_nv]
@id int, @ngay date, @ca int , @check_out datetime
as 
	update GioLamCuaNV set Check_Out = @check_out
	where ID = @id and Ngay = @ngay and Ca = @ca
GO
/****** Object:  StoredProcedure [dbo].[update_khach_hang_ngay]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_khach_hang_ngay]
@bienxe nchar(10), @check_in datetime, @check_out datetime, @phi int
as
	update Khach_hang_ngay set Check_out = @check_out, Phi = @phi
	where BienXe = @bienxe and Check_in = @check_in
GO
/****** Object:  StoredProcedure [dbo].[update_pass]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_pass] @id_nv int, @pass nchar(20)
as
	update Nhanvien set Pass = @pass where id =@id_nv 
GO
/****** Object:  StoredProcedure [dbo].[update_role_acc]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_role_acc] @id int, @role_name nchar(20)
as
	update role_acc set role_name = @role_name where id_nv = @id
GO
/****** Object:  StoredProcedure [dbo].[update_thong_tin_nhan_vien]    Script Date: 10/25/2021 9:28:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_thong_tin_nhan_vien]
@id int, @ten nchar(20), @gioitinh nchar(10), @sdt nchar(12), @diachi text, @maql int,
@anh image, @ngaysinh date
as
	update NhanVien set TenNV = @ten, GioiTinh = @gioitinh, SoDT = @sdt, DiaChi = @diachi, 
						MaQL = @maql, Anh = @anh, NgaySinh = @ngaysinh
	where Id = @id
GO
USE [master]
GO
ALTER DATABASE [GiuXe] SET  READ_WRITE 
GO
