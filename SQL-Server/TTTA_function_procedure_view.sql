
USE TTTA_DB
-- LoadData ---------------------------------------------------------------
CREATE View LoadKhoaHoc As SELECT * From KhoaHoc

CREATE View LoadMonHoc As Select * From MonHoc;

CREATE View LoadGiangVien As Select *  From GiangVien;

Create View LoadNhanVien As Select *  From NhanVien;

Create View LoadDangNhap As Select * From DangNhap;

Create View LoadLopHoc As Select * From LopHoc;

Create  View LoadHocVien As Select * From HocVien;

Create View LoadBienLaiHocPhi As Select * FROM BienLaiHocPhi;

Create View LoadKetQua As Select * From KetQua;
-- Procedures
-- THEM
-- KHOAHOC------------------------------------------------------------------
ALTER Procedure ThemKhoaHoc(@MaKH int, @NgayBatDau date, 
							 @SoTuanHoc int, @TinhTrang varchar(20))
As
Begin
  Insert into KhoaHoc VALUES (@MaKH,@NgayBatDau,@SoTuanHoc,@TinhTrang)
End
-- MONHOC-------------------------------------------------------------------------------
ALTER Procedure ThemMonHoc (@MaMH int, @TenMH varchar(20), @SoGioHoc int)
As
Begin 
  Insert into MonHoc VALUES (@MaMH,@TenMH,@SoGioHoc);
End
-- LOPHOC--------------------------------------------------------------------------------
ALTER Procedure ThemLopHoc(@MaLH int,@KhoaHoc int,@MonHoc int,@GiangVien int,@CaHoc varchar(20),
							@NgayHoc varchar(20),@SoLuongHV varchar(20),@SoTien int)
As
Begin
  Insert into LopHoc VALUES (@MaLH,@KhoaHoc,@MonHoc,@GiangVien,@CaHoc,@NgayHoc,@SoLuongHV,@SoTien);
End
-- HOCVIEN-------------------------------------------------------------------------------
ALTER Procedure ThemHocVien(@MaHV int, @HoTen  varchar(50), @NgaySinh date,
				@GioiTinh varchar(20), @DiaChi  varchar(20), @SoDienThoai varchar(20))
As
Begin
  Insert into HocVien VALUES (@MaHV, @Hoten, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai);
End
-- DANGNHAP-------------------------------------------------------------------------------

ALTER Procedure ThemDangNhap(@Mail varchar(30), @MatKhau varchar(30),@QuyenDangNhap varchar(20))
As
Begin
  Insert into DangNhap VALUES (@Mail,@MatKhau,@QuyenDangNhap);
End
-- GIANGVIEN-------------------------------------------------------------------------------

ALTER Procedure ThemGiangVien(@MaGV int, @TenGV varchar, @NgaySinh date, 
		@ThamNien int, @HocVi varchar(20), @Luong INT, @Mail varchar(30))
As
Begin
  Insert into GiangVien VALUES (@MaGV, @TenGV, @NgaySinh, @ThamNien, @HocVi, @Luong, @Mail);
End

-- THEMNHANVIEN-------------------------------------------------------------------------------
ALTER Procedure ThemNhanVien(@MaNV  int, @TenNV  varchar(50), @NgaySinh  date, 
@GioiTinh  varchar(10), @CMND  varchar(20), @Luong  int, @Mail  varchar(30))
As
Begin
  insert into NhanVien VALUES (@MaNV, @TenNV, @NgaySinh, @GioiTinh, @CMND, @Luong, @Mail);
End


-- BIENLAI-------------------------------------------------------------------------------
ALTER Procedure ThemBienLai (@MaHocVien int, @MaLopHoc int, 
				@MaKhoaHoc int, @HoaDon varchar(20))
As
Begin
  Insert into BienLaiHocPhi VALUES (@MaHocVien, @MaLopHoc, @MaKhoaHoc, @HoaDon);
End


-- KETQUA-------------------------------------------------------------------------------
ALTER Procedure ThemKetQua (@MaHocVien int, @MaLopHoc int, @MaKhoaHoc int, 
@DiemGiuaKy float, @DiemCuoiKy float, @DiemTB  float)
As
Begin
  Insert into KetQua values (@MaHocVien, @MaLopHoc, @MaKhoaHoc, @DiemGiuaKy, @DiemCuoiKy, @DiemTB);
End


-- UPDATE-------------------------------------------------------------------------------
-- KHOAHOC-------------------------------------------------------------------------------
ALTER Procedure CapNhatKhoaHoc(@MaKH  int, @NgayBatDau date, 
									@SoTuanHoc int, @TinhTrang varchar(20))
As
Begin
  Update KhoaHoc
  Set MaKH=@MaKH, NgayBatDau=@NgayBatDau,
  SoTuanHoc=@SoTuanHoc, TinhTrang=@TinhTrang
  Where MaKH=@MaKH;
End

-- MONHOC-------------------------------------------------------------------------------
ALTER Procedure CapNhatMonHoc(@MaMH  int, @TenMH varchar(20), 
											@SoGioHoc  int)
As
Begin 
  Update MonHoc SET MaMH=@MaMH, TenMH=@TenMH, SoGioHoc=@SoGioHoc
  Where MaMH=@MaMH;
End

-- LOPHOC-------------------------------------------------------------------------------

ALTER Procedure CapNhatLopHoc(@MaLH int,@KhoaHoc int,@MonHoc int,@GiangVien int,
					@CaHoc varchar(20),@NgayHoc varchar(20),@SoLuongHV varchar(20),@SoTien int)
As
Begin
  UpDate LopHoc SET MaLH=@MaLH, KhoaHoc=@KhoaHoc, MonHoc=@MonHoc, GiangVien=@GiangVien,
			CaHoc=@CaHoc, NgayHoc=@NgayHoc, SoLuongHV=@SoLuongHV, SoTien=@SoTien
  Where MaLH=@MaLH and KhoaHoc=@KhoaHoc;
End


-- HOCVIEN-------------------------------------------------------------------------------
ALTER Procedure CapNhatHocVien
(@MaHV int, @HoTen  varchar(50), @NgaySinh  date,
 @GioiTinh  varchar(20), @DiaChi  varchar(20), @SoDienThoai  varchar(20))
As
Begin
  Update HocVien
  Set MaHV=@MaHV, HoTen=@HoTen, NgaySinh=@NgaySinh, 
  GioiTinh=@GioiTinh, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai
  Where MaHV=@MaHV;
End



-- DANGNHAP-------------------------------------------------------------------------------
ALTER Procedure CapNhatDangNhap
(@Mail varchar(30), @MatKhau varchar(30),@QuyenDangNhap  varchar(20))
As
Begin
  Update DangNhap
  Set Mail=@Mail, MatKhau=@MatKhau, QuyenDangNhap=@QuyenDangNhap
  Where Mail=@Mail;
End 

-- GIANGVIEN-------------------------------------------------------------------------------
ALTER Procedure CapNhatGiangVien
(@MaGV int, @TenGV  varchar(20), @NgaySinh date, 
@ThamNien int, @HocVi varchar(20), @Luong int, @Mail varchar(30))
As
Begin
  Update GiangVien
  Set MaGV=@MaGV, TenGV=@TenGV, NgaySinh=@NgaySinh, 
  ThamNien=@ThamNien, HocVi=@HocVi, Luong=@Luong, Mail=@Mail
  Where MaGV=@MaGV;
End

-- NHANVIEN-------------------------------------------------------------------------------
ALTER Procedure CapNhatNhanVien
(@MaNV  int, @TenNV varchar(20), @NgaySinh date, 
@GioiTinh varchar(20), @CMND varchar(20), @Luong int, @Mail varchar(30))
As
Begin
  Update NhanVien
  Set MaNV=@MaNV, TenNV=@TenNV, NgaySinh=@NgaySinh, 
  GioiTinh=@GioiTinh, CMND=@CMND, Luong=@Luong, Mail=@Mail
  Where MaNV=@MaNV;
End

-- KETQUA-------------------------------------------------------------------------------
ALTER Procedure CapNhatKetQua
(@MaHocVien int, @MaLopHoc  int, @MaKhoaHoc int, 
@DiemGiuaKy float, @DiemCuoiKy float, @DiemTB float)
As
Begin
  Update KetQua
  Set MaHocVien=@MaHocVien, MaLopHoc=@MaLopHoc, MaKhoaHoc=@MaKhoaHoc, 
  DiemGiuaKy=@DiemGiuaKy, DiemCuoiKy=@DiemCuoiKy, DiemTB=@DiemTB
  Where MaHocVien=@MaHocVien and MaLopHoc=@MaLopHoc
  and MaKhoaHoc=@MaKhoaHoc;
End

-- DELETE-------------------------------------------------------------------------------
-- KHOAHOC-------------------------------------------------------------------------------
ALTER Procedure XoaKhoaHoc(@MaKH int)
As
Begin
  Delete
  From KhoaHoc
  Where MaKH=@MaKH;
End
-- MONHOC-------------------------------------------------------------------------------
ALTER Procedure XoaMonHoc(@MaMH int)
As
Begin
  Delete
  From MonHoc
  Where MaMH=@MaMH;
End
-- LOPHOC-------------------------------------------------------------------------------
ALTER  Procedure XoaLopHoc(@MaLH  int,@KhoaHoc int)
As
Begin
  Delete
  From LopHoc
  Where MaLH=@MaLH and KhoaHoc=@KhoaHoc;
End

-- HOCVIEN-------------------------------------------------------------------------------
ALTER Procedure XoaHocVien(@MaHV  int)
As
Begin
  Delete
  From HocVien
  Where MaHV=@MaHV;
End 
-- DANGNHAP-------------------------------------------------------------------------------
ALTER Procedure XoaDangNhap(@Mail varchar(30))
As
Begin
  Delete
  From DangNhap
  Where Mail=@Mail;
End

-- GIANGVIEN-------------------------------------------------------------------------------
ALTER Procedure XoaGiangVien(@MaGV int)
As
Begin
  Delete
  From GiangVien
  Where MaGV=@MaGV;
End

-- NHANVIEN-------------------------------------------------------------------------------
ALTER Procedure XoaNhanVien(@MaNV int)
As
Begin
  Delete 
  From NhanVien 
  Where MaNV=@MaNV;
End


-- BIENLAI-------------------------------------------------------------------------------
ALTER Procedure XoaBienLai(@MaHocVien int, @MaLopHoc int, @MaKhoaHoc int)
As
Begin
  Delete
  From BienLaiHocPhi
  Where MaHocVien=@MaHocVien and MaLopHoc=@MaLopHoc
  and MaKhoaHoc=@MaKhoaHoc;
End
-- KETQUA-------------------------------------------------------------------------------
ALTER Procedure XoaKetQua
(@MaHocVien int, @MaLopHoc int, @MaKhoaHoc int)
As
Begin
  Delete
  From KetQua
  Where MaHocVien=@MaHocVien and MaLopHoc=@MaLopHoc
  and MaKhoaHoc=@MaKhoaHoc;
End

--KIEMTRADANGNHAP-------------------------------------------------------------------------------
ALTER Procedure KiemTraDangNhap
(@i_Mail varchar, @i_MatKhau varchar, @i_Quyen varchar,
@o_Mail varchar, @o_MatKhau varchar, @o_Quyen varchar)
As
Begin
  Select DangNhap.Mail o_Mail, DangNhap.MatKhau o_MatKhau, DangNhap.QuyenDangNhap o_Quyen
  From DangNhap
  Where Mail=@i_Mail and MatKhau=@i_MatKhau and QuyenDangNhap=@i_Quyen;
END


---- TRIGGER --------------------------------------------------------------------------------------------------------------------------------
USE TTTA_DB go
--TRIGGER
--DROP TRIGGER TG_ThemKetQua

ALTER TRIGGER TG_ThemKetQua
ON BienLaiHocPhi AFTER INSERT 
AS
BEGIN
DECLARE
  @MaHocVien INT,
  @MaLopHoc INT,
  @MaKhoaHoc INT
SELECT @MaHocVien= ins.MaHocVien,
	   @MaLopHoc= ins.MaLopHoc,
	   @MaKhoaHoc= ins.MaKhoaHoc
FROM INSERTED INS
  INSERT INTO KetQua(MaHocVien,MaLopHoc,MaKhoaHoc) 
  VALUES (@MaHocVien, @MaLopHoc,@MaKhoaHoc)
END 
----------------------------------------------
DROP TRIGGER TG_XoaKetQua go

ALTER TRIGGER TG_XoaKetQua
ON BienLaiHocPhi AFTER DELETE
AS
BEGIN
DECLARE
  @MaHocVien INT,
  @MaLopHoc INT,
  @MaKhoaHoc INT
  SELECT @MaHocVien= DEL.MaHocVien,
		 @MaLopHoc= DEL.MaLopHoc,
		 @MaKhoaHoc= DEL.MaKhoaHoc
  FROM DELETED DEL
  DELETE FROM dbo.KetQua 
  WHERE MaHocVien=@MaHocVien 
  AND MaLopHoc=@MaLopHoc
  AND MaKhoaHoc=@MaKhoaHoc;
END
-----------------------------------------------
DROP TRIGGER XoaBienLaiLopHoc go
ALTER TRIGGER XoaBienLaiLopHoc
ON LopHoc AFTER DELETE 
AS
BEGIN
DECLARE
  @MaLopHoc INT,
  @MaKhoaHoc INT
  SELECT @MaLopHoc= DEL.MaLH,
		 @MaKhoaHoc= DEL.KhoaHoc
  FROM DELETED DEL
  DELETE FROM dbo.BienLaiHocPhi 
  Where MaLopHoc=@MaLopHoc 
  AND MaKhoaHoc=@MaKhoaHoc
End

--FUNCTION ------------------------------------------------------
CREATE FUNCTION NhanVienNu(@MaNV int)
RETURNS varchar AS
Begin
DECLARE @NhanVienNu VARCHAR(20)=NULL
     Select @NhanVienNu=NhanVien.TenNV
     From   NhanVien
     Where  NhanVien.MaNV=@MaNV and NhanVien.GioiTinh = 'Nu';
  Return @NhanVienNu
End;

CREATE FUNCTION TimNhanVien(@MaNV int)
RETURNS varchar AS
BEGIN
DECLARE  @NhanVien VARCHAR(20)=NULL
     Select @NhanVien=NhanVien.TenNV
     From   NhanVien
     Where  NhanVien.MaNV=@MaNV;
  Return @NhanVien;
End;

CREATE FUNCTION TimGiangVien(@MaGV int)
RETURNS varchar AS
BEGIN
DECLARE  @GiangVien VARCHAR(20)=NULL
     Select @GiangVien=GiangVien.TenGV
     From   GiangVien
     Where  GiangVien.MaGV=@MaGV;

  Return @GiangVien;
End;

CREATE FUNCTION ThongKeHocVien(@MaKH int)
RETURNS INT AS
BEGIN
DECLARE @SoLuong INT=0
     Select @SoLuong=COUNT(Distinct MaHocVien)
     From   BienLaiHocPhi
     Where  BienLaiHocPhi.MaKhoaHoc=@MaKH;
  RETURN @SoLuong
End;

CREATE FUNCTION TinhDiemTB(@DiemGiuaKy float, @DiemCuoiKy float)
RETURNS INT AS
BEGIN
DECLARE  @DiemTB INT;
    SET @DiemTB = (@DiemGiuaKy+@DiemCuoiKy)/2;
  Return @DiemTB;
End;

CREATE FUNCTION TinhTongDoanhThu(@MaKH int)
RETURNS INT AS
BEGIN
DECLARE @DoanhThu INT
     Select @DoanhThu=SUM(lh.SoTien)
     From   LopHoc lh, BienLaiHocPhi bl
     Where  bl.MaKhoaHoc=@MaKH and bl.MaLopHoc=lh.MaLH;
  Return @DoanhThu;
End
