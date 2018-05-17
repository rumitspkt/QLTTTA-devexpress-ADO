Create Table KhoaHoc
( 
  MaKH int not null,
  NgayBatDau date not null,
  SoTuanHoc int not null,
  TinhTrang varchar(20),
  primary key (MaKH)
);
Create Table MonHoc
(
  MaMH int not null,
  TenMH varchar(20) not null,
  SoGioHoc int not null,
  primary key (MaMH)
);
Create Table DangNhap
(
  Mail varchar(30) not null,
  MatKhau varchar(30) not null,
  QuyenDangNhap varchar(20) not null,
  primary key (Mail)
);
Create Table GiangVien
(
  MaGV int not null,
  TenGV varchar(50) not null,
  NgaySinh date not null,
  ThamNien int not null,
  HocVi varchar(20) not null,
  Luong number not null,
  Mail varchar(30) references DangNhap(Mail) on delete set null,
  constraint uni_MailGV unique (Mail),
  primary key (MaGV)
);

Create Table NhanVien
(
  MaNV int not null,
  TenNV varchar(50) not null,
  NgaySinh date not null,
  GioiTinh varchar(10),
  CMND varchar(20) not null ,
  Luong number not null,
  Mail varchar(30) references DangNhap(Mail) on delete set null,
  constraint uni_CMND unique (CMND),
  constraint uni_MailNV unique (Mail),
  constraint check_GT check (GioiTinh='Nam' or GioiTinh='Nu'),
  primary key (MaNV)
);
Create Table LopHoc
(
  MaLH int not null,
  KhoaHoc int references KhoaHoc(MaKH),
  MonHoc int references MonHoc(MaMH) on delete set null,
  GiangVien int references GiangVien(MaGV) on delete set null,
  CaHoc varchar(20) not null,
  NgayHoc varchar(20) not null,
  SoLuongHV varchar(20) not null,
  SoTien number not null,
  primary key (MaLH,KhoaHoc)
);
Create Table HocVien
(
  MaHV int not null,
  HoTen varchar(50) not null,
  NgaySinh date not null,
  GioiTinh varchar(20),
  DiaChi varchar(20) not null,
  SoDienThoai varchar(20),
  constraint check_GTHV check (GioiTinh='Nam' or GioiTinh='Nu'),
  constraint uni_SDT unique (SoDienThoai),
  primary key (MaHV)
);
Create Table BienLaiHocPhi
(
  MaHocVien int references HocVien(MaHV),
  MaLopHoc int not null,
  MaKhoaHoc int not null,
  HoaDon varchar(20),
  primary key (MaHocVien,MaLopHoc,MaKhoaHoc),
  foreign key (MaLopHoc, MaKhoaHoc) references LopHoc(MaLH, KhoaHoc)
);
Create Table KetQua
(
  MaHocVien int references HocVien(MaHV),
  MaLopHoc int not null,
  MaKhoaHoc int not null,
  DiemGiuaKy float,
  DiemCuoiKy float,
  DiemTB float,
  primary key (MaHocVien,MaLopHoc,MaKhoaHoc),
  foreign key (MaLopHoc, MaKhoaHoc) references LopHoc(MaLH, KhoaHoc),
  constraint check_DiemGiuaKy Check (DiemGiuaKy>=0 and DiemGiuaKy<=10),
  constraint check_DiemCuoiKy Check (DiemCuoiKy>=0 and DiemCuoiKy<=10),
  constraint check_DiemTB Check (DiemTB>=0 and DiemTB<=10)
);


drop table "TRUNGLE97"."BIENLAIHOCPHI" cascade constraints;
drop table "TRUNGLE97"."DANGNHAP" cascade constraints;
drop table "TRUNGLE97"."GIANGVIEN" cascade constraints;
drop table "TRUNGLE97"."HOCVIEN" cascade constraints;
drop table "TRUNGLE97"."KETQUA" cascade constraints;
drop table "TRUNGLE97"."KHOAHOC" cascade constraints;
drop table "TRUNGLE97"."LOPHOC" cascade constraints;
drop table "TRUNGLE97"."MONHOC" cascade constraints;
drop table "TRUNGLE97"."NHANVIEN" cascade constraints;