--TRIGGER
Create or Replace 
Trigger ThemKetQua
After Insert on BienLaiHocPhi
Referencing New as newest
For Each Row
Declare
  v_MaHocVien int;
  v_MaLopHoc int;
  v_MaKhoaHoc int;
Begin
  v_MaHocVien:= :newest.MaHocVien;
  v_MaLopHoc:= :newest.MaLopHoc;
  v_MaKhoaHoc:= :newest.MaKhoaHoc;
  INSERT INTO KetQua
  (mahocvien, malophoc,makhoahoc) 
  VALUES 
  (v_MaHocVien, v_MaLopHoc,v_MaKhoaHoc);
End;

create or replace 
Trigger XoaKetQua
After Delete on BienLaiHocPhi
Referencing Old as oldest
For Each Row
Declare
  v_MaHocVien int;
  v_MaLopHoc int;
  v_MaKhoaHoc int;
Begin
  v_MaHocVien:= :oldest.MaHocVien;
  v_MaLopHoc:= :oldest.MaLopHoc;
  v_MaKhoaHoc:= :oldest.MaKhoaHoc;
  Delete 
  From KetQua 
  Where MaHocVien=v_MaHocVien and MaLopHoc=v_MaLopHoc
  and MaKhoaHoc=v_MaKhoaHoc;
End;

Create or Replace 
Trigger XoaBienLaiLopHoc
Before Delete on LopHoc
Referencing Old as oldest
For Each Row
Declare
  v_MaLopHoc int;
  v_MaKhoaHoc int;
Begin
  v_MaLopHoc:= :oldest.MaLH;
  v_MaKhoaHoc:= :oldest.KhoaHoc;
  Delete 
  From BienLaiHocPhi 
  Where MaLopHoc=v_MaLopHoc and MaKhoaHoc=v_MaKhoaHoc;
End;
--FUNCTION
Create Or Replace Function NhanVienNu(p_MaNV int)
  Return varchar2 As
  v_NhanVienNu NhanVien.TenNV%Type;
Begin
  Begin
     Select NhanVien.TenNV
     Into   v_NhanVienNu
     From   NhanVien
     Where  NhanVien.MaNV=p_MaNV and NhanVien.GioiTinh = 'Nu';
  Exception
     When No_Data_Found Then
        v_NhanVienNu := Null;
  End;
  Return v_NhanVienNu;
End;

Create Or Replace Function TimNhanVien(p_MaNV int)
  Return varchar2 As
  v_NhanVien NhanVien.TenNV%Type;
Begin
  Begin
     Select NhanVien.TenNV
     Into   v_NhanVien
     From   NhanVien
     Where  NhanVien.MaNV=p_MaNV;
  Exception
     When No_Data_Found Then
        v_NhanVien := Null;
  End;
  Return v_NhanVien;
End;

Create Or Replace Function TimGiangVien(p_MaGV int)
  Return varchar2 As
  v_GiangVien GiangVien.TenGV%Type;
Begin
  Begin
     Select GiangVien.TenGV
     Into   v_GiangVien
     From   GiangVien
     Where  GiangVien.MaGV=p_MaGV;
  Exception
     When No_Data_Found Then
        v_GiangVien := Null;
  End;
  Return v_GiangVien;
End;

Create or Replace Function ThongKeHocVien(p_MaKH int)
  Return number As
  v_SoLuong number;
Begin
  Begin
     Select Count(Distinct MaHocVien)
     Into   v_SoLuong
     From   BienLaiHocPhi
     Where  BienLaiHocPhi.MaKhoaHoc=p_MaKH;
  Exception
     When No_Data_Found Then
        v_SoLuong := Null;
  End;
  Return v_SoLuong;
End;

Create or Replace 
Function TinhDiemTB(DiemGiuaKy float, DiemCuoiKy float)
  Return number As
  v_DiemTB number;
Begin
  Begin
    v_DiemTB := (DiemGiuaKy+DiemCuoiKy)/2;
  Exception
     When No_Data_Found Then
        v_DiemTB := Null;
  End;
  Return v_DiemTB;
End;

Create or Replace Function TinhTongDoanhThu(p_MaKH int)
  Return number As
  v_DoanhThu number;
Begin
  Begin
     Select SUM(lh.SoTien) AS "Tong Tien"
     Into   v_DoanhThu
     From   LopHoc lh, BienLaiHocPhi bl
     Where  bl.MaKhoaHoc=p_MaKH and bl.MaLopHoc=lh.MaLH;
  Exception
     When No_Data_Found Then
        v_DoanhThu := Null;
  End;
  Return v_DoanhThu;
End;
alter session set "_ORACLE_SCRIPT"=true; 

-- T?o nhóm quy?n Nhân viên
CREATE ROLE QuyenNhanVien;
-- c?p quy?n
GRANT CONNECT, RESOURCE TO QuyenNhanVien;
GRANT CREATE USER TO QuyenNhanVien;
GRANT DROP USER TO QuyenNhanVien;
GRANT ALTER USER TO QuyenNhanVien;
GRANT CREATE ROLE TO  QuyenNhanVien;
-----------------------------
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.BIENLAIHOCPHI TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.DANGNHAP TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.GIANGVIEN TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.HOCVIEN TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.KETQUA TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.KHOAHOC TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOPHOC TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.MONHOC TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.NHANVIEN TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADBIENLAIHOCPHI TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADDANGNHAP TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADGIANGVIEN TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADHOCVIEN TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADKETQUA TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADKHOAHOC TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADLOPHOC TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADMONHOC TO QuyenNhanVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADNHANVIEN TO QuyenNhanVien;
-- th?c thi các stored
GRANT EXECUTE ON TRUNGLE97.THEMKHOAHOC TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.THEMLOPHOC TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.THEMBIENLAI TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.THEMDANGNHAP TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.THEMGIANGVIEN TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.THEMHOCVIEN TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.THEMKETQUA TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.THEMMONHOC TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.THEMNHANVIEN TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.CAPNHATKHOAHOC TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.CAPNHATLOPHOC TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.CAPNHATDANGNHAP TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.CAPNHATGIANGVIEN TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.CAPNHATHOCVIEN TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.CAPNHATKETQUA TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.CAPNHATMONHOC TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.CAPNHATNHANVIEN TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.XOAKHOAHOC TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.XOALOPHOC TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.XOABIENLAI TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.XOADANGNHAP TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.XOAGIANGVIEN TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.XOAHOCVIEN TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.XOAKETQUA TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.XOAMONHOC TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.XOANHANVIEN TO QuyenNhanVien;
-- Th?c Thi Function
GRANT EXECUTE ON TRUNGLE97.NHANVIENNU TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.THONGKEHOCVIEN TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.TIMGIANGVIEN TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.TIMNHANVIEN TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.TINHDIEMTB TO QuyenNhanVien;
GRANT EXECUTE ON TRUNGLE97.TINHTONGDOANHTHU TO QuyenNhanVien;
-- t?o user
CREATE USER rum IDENTIFIED BY 123456;
-- Gán quy?n cho user
GRANT QuyenNhanVien TO rum;
alter session set "_ORACLE_SCRIPT"=true; 
-- T?o nhóm quy?n Gi?ng viên
CREATE ROLE QuyenGiangVien;
-- C?p quy?n
GRANT CONNECT, RESOURCE TO QuyenGiangVien;
GRANT CREATE USER TO QuyenGiangVien;
GRANT DROP USER TO QuyenGiangVien;
GRANT ALTER USER TO QuyenGiangVien;
GRANT CREATE ROLE TO  QuyenGiangVien;
-----------------------------
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.HOCVIEN TO QuyenGiangVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.KETQUA TO QuyenGiangVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADGIANGVIEN TO QuyenGiangVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADHOCVIEN TO QuyenGiangVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADKETQUA TO QuyenGiangVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADKHOAHOC TO QuyenGiangVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADLOPHOC TO QuyenGiangVien;
GRANT SELECT,INSERT,DELETE,UPDATE ON TRUNGLE97.LOADMONHOC TO QuyenGiangVien;
-- Th?c thi các stored
GRANT EXECUTE ON TRUNGLE97.THEMKETQUA TO QuyenGiangVien;
GRANT EXECUTE ON TRUNGLE97.CAPNHATKETQUA TO QuyenGiangVien;
GRANT EXECUTE ON TRUNGLE97.XOAKETQUA TO QuyenGiangVien;
-- Th?c Thi Function
GRANT EXECUTE ON TRUNGLE97.THONGKEHOCVIEN TO QuyenGiangVien;
GRANT EXECUTE ON TRUNGLE97.TIMGIANGVIEN TO QuyenGiangVien;
GRANT EXECUTE ON TRUNGLE97.TIMNHANVIEN TO QuyenGiangVien;
GRANT EXECUTE ON TRUNGLE97.TINHDIEMTB TO QuyenGiangVien;
-- T?o user
CREATE USER trung IDENTIFIED BY 123456;
-- Gán quy?n cho user
GRANT QuyenNhanVien TO trung;

