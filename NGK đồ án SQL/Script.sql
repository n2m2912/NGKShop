/*
Created		3/24/2018
Modified		3/24/2018
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/
DROP DATABASE NGK
GO
create database NGK
GO
USE NGK
go

Create table [KHACHHANG]
(
	[MaKH] INT IDENTITY(1,1) NOT NULL,
	[TenKH] Nvarchar(30) NOT NULL,
	[SDT] Char(10) NOT NULL,
	[DiaChi] Nvarchar(100) NOT NULL,
	[email] Nvarchar(50) NOT NULL,
	[TenDN] VARCHAR(50) NOT NULL,
	[MatKhau] VARCHAR(50) NOT NULL,
Primary Key ([MaKH])
) 
go

Create table [HOADON]
(
	[MaHD] INT IDENTITY(1,1) NOT NULL,
	[NGAYLAPHD] Datetime NOT NULL,
	[Ngaygiaohang] Datetime,
	[TONGTIEN] Money NOT NULL,
	[MaKH] INT NOT NULL,
	[Dathanhtoan] BIT ,
Primary Key ([MaHD])
) 
go

Create table [MATHANG]
(
	[MaMH] INT IDENTITY(1,1) NOT NULL,
	[MaLH] INT NOT NULL,
	[TenMH] Nvarchar(30) NOT NULL,
	[DonViTinh] Nvarchar(30) NOT NULL,
	[MoTa] Nvarchar(4000) NULL,
	[GiaBan] Money NOT NULL,
	[HinhSP] Nvarchar(30) ,
	[KhuyenMai] float not null
Primary Key ([MaMH])
) 
go

Create table [CHITIETHD]
(
	[MaHD] INT  NOT NULL,
	[MaMH] INT NOT NULL,
	[DonGia] MONEY NOT NULL,
	[SL] Integer NOT NULL,
Primary Key ([MaHD],[MaMH])
) 
go

Create table [LOAINGK]
(
	[MaLH] INT IDENTITY(1,1) NOT NULL,
	[TenLH] Nvarchar(30) NOT NULL,
	[MaNCC] INT NOT NULL,
Primary Key ([MaLH])
) 
go

Create table [NCC]
(
	[MaNCC] INT IDENTITY(1,1) NOT NULL,
	[TenNCC] Nvarchar(30) NOT NULL,
	[DiaChiNCC] nvarchar(50),
	[SDTNCC] varchar(11),
Primary Key ([MaNCC])
) 
go

CREATE TABLE [Admin]
(
	[UserAdmin] VARCHAR(50) NOT NULL,
	[PassAdmin] VARCHAR(50) NOT NULL,
	[Hoten] NVARCHAR(50) NOT NULL
)

GO

Alter table [HOADON] add  foreign key([MaKH]) references [KHACHHANG] ([MaKH])  on update no action on delete no action 
go
Alter table [CHITIETHD] add  foreign key([MaHD]) references [HOADON] ([MaHD])  on update no action on delete no action 
go
Alter table [CHITIETHD] add  foreign key([MaMH]) references [MATHANG] ([MaMH])  on update no action on delete no action 
go
Alter table [MATHANG] add  foreign key([MaLH]) references [LOAINGK] ([MaLH])  on update no action on delete no action 
go
Alter table [LOAINGK] add  foreign key([MaNCC]) references [NCC] ([MaNCC])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go
