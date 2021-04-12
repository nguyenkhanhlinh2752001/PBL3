create database qlchungcu
use qlchungcu

create table khu
(
	makhu int primary key,
	huong nvarchar(50) not null
)
go

create table hogiadinh
(
	maho int primary key,
)
go

create table canho
(
	macanho int primary key,
	makhu int foreign key (makhu) references khu(makhu),
	maho int foreign key (maho) references hogiadinh(maho),
	loaicanho nvarchar(100) not null,
	trangthai nvarchar(100) not null
)
go

create table thanhvien
(
	mathanhvien int primary key,
	maho int foreign key (maho) references hogiadinh(maho),
	tenthanhvien nvarchar(100) not null,
	ngaysinh date not null,
	dantoc nvarchar(50) not null,
	nghenghiep nvarchar(100) not null,
	gioitinh bit not null, -- 1-nam, 0-nu
	cmnd varchar(20) not null,
	chuho bit not null, -- 1-chu ho, 0- ko la chu ho
)
go

create table chucvu
(
	machucvu int primary key,
	tenchucvu nvarchar(100) not null,
)
go

create table nhanvien
(
	manhanvien int primary key,
	machucvu int foreign key (machucvu) references chucvu(machucvu),
	tennhanvien nvarchar(100) not null,
	gioitinh bit not null, -- 1-nam, 0-nu
	cmnd varchar(20) not null,
	sdt varchar(20) not null,
	ngaysinh date not null,
)
go

create table taikhoan
(
	tendangnhap nvarchar primary key,
	manhanvien int foreign key (manhanvien) references nhanvien(manhanvien),
	matkhau nvarchar(100) not null,
	quyen nvarchar(20) not null,
)
go

create table dichvu
(
	madichvu int primary key,
	tendichvu nvarchar(100) not null,
	gia float not null default 0,
)
go

create table hoadondichvu
(
	mahoadon int primary key,
	macanho int foreign key (macanho) references canho(macanho),
	manhanvien int foreign key (manhanvien) references nhanvien(manhanvien),
	tongtien float not null default 0,
	dathanhtoan bit not null, -- 1-da thanh toan, 0-chua thanh toan
	ngaythanhtoan date,
)
go

create table chitiethoadon
(
	mahoadon int foreign key (mahoadon) references hoadondichvu(mahoadon),
	madichvu int foreign key (madichvu) references dichvu(madichvu),
	soluong int not null default 0,
)
go

create table hopdong
(
	mahopdong int primary key,
	manhanvien int foreign key (manhanvien) references nhanvien(manhanvien),
	macanho int foreign key (macanho) references canho(macanho),
	maho int foreign key (maho) references hogiadinh(maho),
	tenhopdong nvarchar(100) not null,
	loaihopdong nvarchar(100) not null,
	giatien float not null default 0,
	thoihan nvarchar(100) not null,
	ngayki date not null,
	dahuy bit not null, -- 1-da huy,0- chua huy
)
go

create table chitietcanho
(
	macanho int foreign key (macanho) references canho(macanho),
	vatdung nvarchar(100) not null,
	soluong int not null,
	dongia float not null
)
go
