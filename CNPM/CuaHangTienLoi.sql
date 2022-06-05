
use master
go
if exists(select*from sysdatabases where name='QuanLyCuaHangTienLoi')
drop database QuanLyCuaHangTienLoi
go
create database QuanLyCuaHangTienLoi
go
use QuanLyCuaHangTienLoi

if exists(select*from sysobjects where name='danhmuc')
drop table danhmuc
go
create table danhmuc
(
	madanhmuc char(5) primary key not null,
	tendanhmuc nvarchar(50),
	mieuta nvarchar(50)
)
if exists(select*from sysobjects where name='taikhoan')
drop table taikhoan
go
create table taikhoan
(
	matk int identity(1,1) primary key not null,
	tentk nvarchar(50) unique,
	matkhau nvarchar(50),
	hoten nvarchar(50),
	mucluong float,
	ngaynhanviec date,
	ngaysinh date,
	loaitk nvarchar(20)
)
if exists(select*from sysobjects where name='sanpham')
drop table sanpham
go
create table sanpham 
(
	masp char(5) primary key not null,
	tensp nvarchar(50),
	giaban float check(giaban>0),
	donvitinh nvarchar(10),
	madanhmuc char(5),
	hangtrongkho float,
	constraint Fk_SanPham_DanhMuc FOREIGN KEY (madanhmuc) REFERENCES danhmuc(madanhmuc)
)
if exists(select*from sysobjects where name='hoadon')
drop table hoadon
go
create table hoadon
(
	mahd int identity(1,1) primary key not null,
	ngayxuat datetime,
	tongtien float,
	nguoiban int,
	constraint Fk_HoaDon_Taikhoan FOREIGN KEY (nguoiban) REFERENCES taikhoan(matk)
)
if exists(select*from sysobjects where name='chitiethoadon')
drop table chitiethoadon
go
create table chitiethoadon
(
	mahd int not null,
	masp char(5) not null,
	soluong float,
	giaban float check(giaban>0),
	primary key(mahd,masp),
	constraint Fk_ChiTietHoaDon_HoaDon foreign key (mahd) references hoadon(mahd),
	constraint Fk_ChiTietHoaDon_SanPham foreign key (masp) references sanpham(masp)
)

insert into taikhoan
values ('admin','admin','Administrator',500000,'2022-06-01','2022-06-01','Admin')

