-- LoadData
Create or Replace View LoadKhoaHoc 
As 
Select *    
From KhoaHoc;
Create or Replace View LoadMonHoc 
As 
Select *    
From MonHoc;
Create or Replace View LoadGiangVien 
As 
Select *    
From GiangVien;
Create or Replace View LoadNhanVien 
As 
Select *    
From NhanVien;
Create or Replace View LoadDangNhap 
As 
Select *    
From DangNhap;
Create or Replace View LoadLopHoc
As 
Select *    
From LopHoc;
Create or Replace View LoadHocVien 
As 
Select *    
From HocVien;
Create or Replace View LoadBienLaiHocPhi
As 
Select *    
From BienLaiHocPhi;
Create or Replace View LoadKetQua
As 
Select *    
From KetQua;
-- Procedures
-- THEM
-- KHOAHOC
Create or Replace Procedure ThemKhoaHoc
(v_MaKH in int, v_NgayBatDau in date, 
v_SoTuanHoc in int, v_TinhTrang in varchar)
As
Begin
  Insert into KhoaHoc
  values (v_MaKH,v_NgayBatDau,v_SoTuanHoc,v_TinhTrang);
End ThemKhoaHoc;
-- MONHOC
Create or Replace Procedure ThemMonHoc
(v_MaMH in int, v_TenMH in varchar, 
v_SoGioHoc in int)
As
Begin 
  Insert into MonHoc
  values (v_MaMH,v_TenMH,v_SoGioHoc);
End ThemMonHoc;
-- LOPHOC
Create or Replace Procedure ThemLopHoc
(v_MaLH in int,v_KhoaHoc in int,v_MonHoc in int,v_GiangVien in int,
v_CaHoc in varchar,v_NgayHoc in varchar,v_SoLuongHV in varchar,v_SoTien in number)
As
Begin
  Insert into LopHoc
  values (v_MaLH,v_KhoaHoc,v_MonHoc,v_GiangVien,v_CaHoc,v_NgayHoc,v_SoLuongHV,v_SoTien);
End ThemLopHoc;
-- HOCVIEN
Create or Replace Procedure ThemHocVien
(v_MaHV in int, v_HoTen in varchar, v_NgaySinh in date,
 v_GioiTinh in varchar, v_DiaChi in varchar, v_SoDienThoai in varchar)
As
Begin
  Insert into HocVien
  values (v_MaHV, v_Hoten, v_NgaySinh, v_GioiTinh, v_DiaChi, v_SoDienThoai);
End ThemHocVien;
-- DANGNHAP
Create or Replace Procedure ThemDangNhap
(v_Mail in varchar, v_MatKhau in varchar,v_QuyenDangNhap in varchar)
As
Begin
  Insert into DangNhap
  values (v_Mail,v_MatKhau,v_QuyenDangNhap);
End ThemDangNhap;
-- GIANGVIEN
Create or Replace Procedure ThemGiangVien
(v_MaGV in int, v_TenGV in varchar, v_NgaySinh in date, 
v_ThamNien in int, v_HocVi in varchar, v_Luong in number, v_Mail in varchar)
As
Begin
  Insert into GiangVien
  values (v_MaGV, v_TenGV, v_NgaySinh, v_ThamNien, v_HocVi, v_Luong, v_Mail);
End ThemGiangVien;
-- THEMNHANVIEN
Create or Replace Procedure ThemNhanVien
(v_MaNV in int, v_TenNV in varchar, v_NgaySinh in date, 
v_GioiTinh in varchar, v_CMND in varchar, v_Luong in number, v_Mail in varchar)
As
Begin
  Insert into NhanVien
  values (v_MaNV, v_TenNV, v_NgaySinh, v_GioiTinh, v_CMND, v_Luong, v_Mail);
End ThemNhanVien;
-- BIENLAI
Create or Replace Procedure ThemBienLai
(v_MaHocVien in int, v_MaLopHoc in int, 
v_MaKhoaHoc in varchar, v_HoaDon in varchar)
As
Begin
  Insert into BienLaiHocPhi
  values (v_MaHocVien, v_MaLopHoc, v_MaKhoaHoc, v_HoaDon);
End ThemBienLai;
-- KETQUA
Create or Replace Procedure ThemKetQua
(v_MaHocVien in int, v_MaLopHoc in int, v_MaKhoaHoc in varchar, 
v_DiemGiuaKy in number, v_DiemCuoiKy in number, v_DiemTB in number)
As
Begin
  Insert into KetQua
  values (v_MaHocVien, v_MaLopHoc, v_MaKhoaHoc, v_DiemGiuaKy, v_DiemCuoiKy, v_DiemTB);
End ThemKetQua;
-- UPDATE
-- KHOAHOC
Create or Replace Procedure CapNhatKhoaHoc
(v_MaKH in int, v_NgayBatDau in date, 
v_SoTuanHoc in int, v_TinhTrang in varchar)
As
Begin
  Update KhoaHoc
  Set MaKH=v_MaKH, NgayBatDau=v_NgayBatDau,
  SoTuanHoc=v_SoTuanHoc, TinhTrang=v_TinhTrang
  Where MaKH=v_MaKH;
End CapNhatKhoaHoc;
-- MONHOC
Create or Replace Procedure CapNhatMonHoc
(v_MaMH in int, v_TenMH in varchar, 
v_SoGioHoc in int)
As
Begin 
  Update MonHoc
  Set MaMH=v_MaMH, TenMH=v_TenMH, 
  SoGioHoc=v_SoGioHoc
  Where MaMH=v_MaMH;
End CapNhatMonHoc;
-- LOPHOC
Create or Replace Procedure CapNhatLopHoc
(v_MaLH in int,v_KhoaHoc in int,v_MonHoc in int,v_GiangVien in int,
v_CaHoc in varchar,v_NgayHoc in varchar,v_SoLuongHV in varchar,v_SoTien in number)
As
Begin
  UpDate LopHoc
  Set MaLH=v_MaLH, KhoaHoc=v_KhoaHoc, MonHoc=v_MonHoc, GiangVien=v_GiangVien,
  CaHoc=v_CaHoc, NgayHoc=v_NgayHoc, SoLuongHV=v_SoLuongHV, SoTien=v_SoTien
  Where MaLH=v_MaLH and KhoaHoc=v_KhoaHoc;
End CapNhatLopHoc;
-- HOCVIEN
Create or Replace Procedure CapNhatHocVien
(v_MaHV in int, v_HoTen in varchar, v_NgaySinh in date,
 v_GioiTinh in varchar, v_DiaChi in varchar, v_SoDienThoai in varchar)
As
Begin
  Update HocVien
  Set MaHV=v_MaHV, HoTen=v_HoTen, NgaySinh=v_NgaySinh, 
  GioiTinh=v_GioiTinh, DiaChi=v_DiaChi, SoDienThoai=v_SoDienThoai
  Where MaHV=v_MaHV;
End CapNhatHocVien;
-- DANGNHAP
Create or Replace Procedure CapNhatDangNhap
(v_Mail in varchar, v_MatKhau in varchar,v_QuyenDangNhap in varchar)
As
Begin
  Update DangNhap
  Set Mail=v_Mail, MatKhau=v_MatKhau, QuyenDangNhap=v_QuyenDangNhap
  Where Mail=v_Mail;
End CapNhatDangNhap;
-- GIANGVIEN
Create or Replace Procedure CapNhatGiangVien
(v_MaGV in int, v_TenGV in varchar, v_NgaySinh in date, 
v_ThamNien in int, v_HocVi in varchar, v_Luong in number, v_Mail in varchar)
As
Begin
  Update GiangVien
  Set MaGV=v_MaGV, TenGV=v_TenGV, NgaySinh=v_NgaySinh, 
  ThamNien=v_ThamNien, HocVi=v_HocVi, Luong=v_Luong, Mail=v_Mail
  Where MaGV=v_MaGV;
End CapNhatGiangVien;
-- NHANVIEN
Create or Replace Procedure CapNhatNhanVien
(v_MaNV in int, v_TenNV in varchar, v_NgaySinh in date, 
v_GioiTinh in varchar, v_CMND in varchar, v_Luong in number, v_Mail in varchar)
As
Begin
  Update NhanVien
  Set MaNV=v_MaNV, TenNV=v_TenNV, NgaySinh=v_NgaySinh, 
  GioiTinh=v_GioiTinh, CMND=v_CMND, Luong=v_Luong, Mail=v_Mail
  Where MaNV=v_MaNV;
End CapNhatNhanVien;
-- KETQUA
Create or Replace Procedure CapNhatKetQua
(v_MaHocVien in int, v_MaLopHoc in int, v_MaKhoaHoc in varchar, 
v_DiemGiuaKy in number, v_DiemCuoiKy in number, v_DiemTB in number)
As
Begin
  Update KetQua
  Set MaHocVien=v_MaHocVien, MaLopHoc=v_MaLopHoc, MaKhoaHoc=v_MaKhoaHoc, 
  DiemGiuaKy=v_DiemGiuaKy, DiemCuoiKy=v_DiemCuoiKy, DiemTB=v_DiemTB
  Where MaHocVien=v_MaHocVien and MaLopHoc=v_MaLopHoc
  and MaKhoaHoc=v_MaKhoaHoc;
End CapNhatKetQua;
-- DELETE
-- KHOAHOC
Create or Replace Procedure XoaKhoaHoc
(v_MaKH in int)
As
Begin
  Delete
  From KhoaHoc
  Where MaKH=v_MaKH;
End XoaKhoaHoc;
-- MONHOC
Create or Replace Procedure XoaMonHoc
(v_MaMH in int)
As
Begin
  Delete
  From MonHoc
  Where MaMH=v_MaMH;
End XoaMonHoc;
-- LOPHOC
Create or Replace Procedure XoaLopHoc
(v_MaLH in int,v_KhoaHoc in int)
As
Begin
  Delete
  From LopHoc
  Where MaLH=v_MaLH and KhoaHoc=v_KhoaHoc;
End XoaLopHoc;
-- HOCVIEN
Create or Replace Procedure XoaHocVien
(v_MaHV in int)
As
Begin
  Delete
  From HocVien
  Where MaHV=v_MaHV;
End XoaHocVien;
-- DANGNHAP
Create or Replace Procedure XoaDangNhap
(v_Mail in varchar, v_MatKhau in varchar,v_QuyenDangNhap in varchar)
As
Begin
  Delete
  From DangNhap
  Where Mail=v_Mail;
End XoaDangNhap;
-- GIANGVIEN
Create or Replace Procedure XoaGiangVien
(v_MaGV in int)
As
Begin
  Delete
  From GiangVien
  Where MaGV=v_MaGV;
End XoaGiangVien;
-- NHANVIEN
Create or Replace Procedure XoaNhanVien
(v_MaNV in int)
As
Begin
  Delete 
  From NhanVien 
  Where MaNV=v_MaNV;
End XoaNhanVien;
-- BIENLAI
Create or Replace Procedure XoaBienLai
(v_MaHocVien in int, v_MaLopHoc in int, v_MaKhoaHoc in varchar)
As
Begin
  Delete
  From BienLaiHocPhi
  Where MaHocVien=v_MaHocVien and MaLopHoc=v_MaLopHoc
  and MaKhoaHoc=v_MaKhoaHoc;
End XoaBienLai;
-- KETQUA
Create or Replace Procedure XoaKetQua
(v_MaHocVien in int, v_MaLopHoc in int, v_MaKhoaHoc in varchar)
As
Begin
  Delete
  From KetQua
  Where MaHocVien=v_MaHocVien and MaLopHoc=v_MaLopHoc
  and MaKhoaHoc=v_MaKhoaHoc;
End XoaKetQua;
--KIEMTRADANGNHAP
Create or Replace Procedure KiemTraDangNhap
(i_Mail in varchar, i_MatKhau in varchar, i_Quyen in varchar,
o_Mail out varchar, o_MatKhau out varchar, o_Quyen out varchar)
As
Begin
  Select DangNhap.Mail, DangNhap.MatKhau, DangNhap.QuyenDangNhap
  Into o_Mail, o_MatKhau, o_Quyen
  From DangNhap
  Where Mail=i_Mail and MatKhau=i_MatKhau and QuyenDangNhap=i_Quyen;
End KiemTraDangNhap;