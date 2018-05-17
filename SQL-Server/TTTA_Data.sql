
USE TTTA_DB

-- Data
-- KHOAHOC
insert into KhoaHoc values (1,'10-03-2017' ,15,'Hoan Thanh');
insert into KhoaHoc values (2,'10-07-2017' ,15,'Chua Hoan Thanh');
-- MONHOC
insert into MonHoc values (1,'Toeic',150);
insert into MonHoc values (2,'Ielts',150);
insert into MonHoc values (3,'TA Giao Tiep',150);
insert into MonHoc values (4,'TOEFL',150);
insert into MonHoc values (6,'TOEFL aa',150);
update MonHoc
set TenMH='Toei'
Where MaMH=6;
-- GIANGVIEN
-- Mail
Insert into DangNhap values ('gv1@abc.com','123456','giangvien');
Insert into DangNhap values ('gv2@abc.com','123456','giangvien');
Insert into DangNhap values ('gv3@abc.com','123456','giangvien');
Insert into DangNhap values ('gv4@abc.com','123456','giangvien');
Insert into DangNhap values ('gv5@abc.com','123456','giangvien');
Insert into DangNhap values ('gv6@abc.com','123456','giangvien');
Insert into DangNhap values ('gv7@abc.com','123456','giangvien');
Insert into DangNhap values ('gv8@abc.com','123456','giangvien');
-- Info
insert into GiangVien values (1,'John Rune','1990-02-17',8,'Thac Si',10000000,'gv1@abc.com');
insert into GiangVien values (2,'Mary Sue','1987-05-8',12,'Thac Si',11000000,'gv2@abc.com');
insert into GiangVien values (3,'Ben Watson','1988-11-21',8,'Thac Si',13000000,'gv3@abc.com');
insert into GiangVien values (4,'Michael John','1992-01-18',7,'Thac Si',9000000,'gv4@abc.com');
insert into GiangVien values (5,'Adam Mills','1991-01-26',11,'Thac Si',10000000,'gv5@abc.com');
insert into GiangVien values (6,'Scott Parker','1993-03-19',8,'Thac Si',9000000,'gv6@abc.com');
insert into GiangVien values (7,'Peter Parker','1994-10-07',8,'Thac Si',9000000,'gv7@abc.com');
insert into GiangVien values (8,'Tony Stark','1993-05-21',7,'Thac Si',9000000,'gv8@abc.com');
-- NHANVIEN
-- Mail
Insert into DangNhap values ('nv1@abc.com','123456','nhanvien');
Insert into DangNhap values ('nv2@abc.com','123456','nhanvien');
Insert into DangNhap values ('nv3@abc.com','123456','nhanvien');
Insert into DangNhap values ('nv4@abc.com','123456','nhanvien');
-- Info
insert into NhanVien values (1,'Tran Dieu Linh','1990-02-17','Nu','341932010',7000000,'nv1@abc.com');
insert into NhanVien values (2,'Nguyen Thi Phuong','1990-02-17','Nu','341925054',7000000,'nv2@abc.com');
insert into NhanVien values (3,'Nguyen Hoang Nam','1990-02-17','Nam','341923064',7000000,'nv3@abc.com');
insert into NhanVien values (4,'Tran Quoc Tuan','1990-02-17','Nam','341932063',7000000,'nv4@abc.com');
-- HOCVIEN
insert into HocVien values (1,'Le Vinh Trung','1997-03-10','Nam','Thu Duc','0909684578');
insert into HocVien values (2,'Nguyen Rum','1998-05-15','Nam','Binh Thanh','0907456821');
insert into HocVien values (3,'Huynh Uyen Phuong','1997-04-21','Nu','Tan Phu','0907852963');
insert into HocVien values (4,'Le Vu Hoang Hiep','1997-06-07','Nam','Thu Duc','0983147598');
insert into HocVien values (5,'Ngo Van Huy','1997-03-10','Nam','Tan Binh','0902358854');
insert into HocVien values (6,'Nguyen Thuy Uyen','1997-06-12','Nu','Quan 1','0981471517');
insert into HocVien values (7,'Le Phuong Thao','1997-08-08','Nu','Quan 9','0942365985');
insert into HocVien values (8,'Nguyen Thanh Son','1997-09-02','Nam','Thu Duc','0978415235');
insert into HocVien values (9,'Nguyen Quang Hai','1997-10-08','Nam','Quan 9','0908365985');
insert into HocVien values (10,'Vu Van Thanh','1997-11-02','Nam','Thu Duc','0993415235');
insert into HocVien values (11,'Nguyen Thuy Uyen','1997-06-12','Nu','Quan 1','0981471512');
insert into HocVien values (12,'Le Thao','1997-08-08','Nu','Quan 9','0942365958');
insert into HocVien values (13,'Nguyen Son','1997-09-02','Nam','Thu Duc','0978415244');
insert into HocVien values (14,'Bui Tien Dung','1997-10-08','Nam','Quan 9','0908365910');
insert into HocVien values (15,'Nguyen Trong Dai','1997-11-02','Nam','Thu Duc','0993415115');
insert into HocVien values (16,'Nguyen Viet Thang','1997-03-10','Nam','Thu Duc','0903684578');
insert into HocVien values (17,'Nguyen Thanh Nha','1998-05-15','Nam','Binh Thanh','0989335412');
insert into HocVien values (18,'Nguyen Thi Y Nhi','1997-04-21','Nu','Tan Phu','0987852365');
insert into HocVien values (19,'Pham Dang Hiep','1997-06-07','Nam','Thu Duc','0981417845');
insert into HocVien values (20,'Ngo Van Hung','1997-03-10','Nam','Tan Binh','0986412557');
insert into HocVien values (21,'Nguyen Phuong Nhu','1997-06-12','Nu','Quan 1','0951245874');
insert into HocVien values (22,'Le Thi Phuong Thao','1997-08-08','Nu','Quan 9','0982165985');
insert into HocVien values (23,'Nguyen Son Thanh','1997-09-02','Nam','Thu Duc','0978455235');
insert into HocVien values (24,'Nguyen Minh Phuong','1997-10-08','Nam','Quan 9','0908295985');
insert into HocVien values (25,'Vu Van Thanh','1997-11-02','Nam','Thu Duc','0908615235');
insert into HocVien values (26,'Nguyen Thi Thuy ','1997-06-12','Nu','Quan 1','0981491512');
insert into HocVien values (27,'Le Thao','1997-08-08','Nu','Quan 9','0957365668');
insert into HocVien values (28,'Nguyen Son','1997-09-02','Nam','Thu Duc','0909468244');
insert into HocVien values (29,'Ha Duc Chinh','1997-10-08','Nam','Quan 9','0981655910');
insert into HocVien values (30,'Nguyen Cong Phuong','1997-11-02','Nam','Thu Duc','0908444115');
-- KHOAHOC 1
-- LOPHOC
-- Toeic
insert into LopHoc values (1,1,1,1,'Sang','2-4-6',10,3000000);
insert into LopHoc values (2,1,1,1,'Chieu','2-4-6',10,3000000);
insert into LopHoc values (3,1,1,2,'Toi','2-4-6',10,3000000);
-- Ielts
insert into LopHoc values (4,1,2,2,'Sang','2-4-6',10,7000000);
insert into LopHoc values (5,1,2,3,'Chieu','2-4-6',10,7000000);
insert into LopHoc values (6,1,2,3,'Chieu','2-4-6',10,7000000);
-- TA Giao Tiep
insert into LopHoc values (7,1,3,4,'Sang','3-5-7',10,7000000);
insert into LopHoc values (8,1,3,4,'Chieu','3-5-7',10,7000000);
insert into LopHoc values (9,1,3,5,'Chieu','3-5-7',10,7000000);
-- TOEFL
insert into LopHoc values (10,1,4,6,'Sang','3-5-7',10,10000000);
insert into LopHoc values (11,1,4,7,'Chieu','3-5-7',10,10000000);
insert into LopHoc values (12,1,4,8,'Toi','3-5-7',10,10000000);

--BIENLAIHOCPHI
-- Toeic 1
insert into BienLaiHocPhi values (1,1,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (2,1,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (3,1,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (4,1,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (5,1,1,'Da Thanh Toan');
-- Toeic 2
insert into BienLaiHocPhi values (6,2,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (7,2,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (8,2,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (9,2,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (10,2,1,'Da Thanh Toan');
-- Toeic 3
insert into BienLaiHocPhi values (11,3,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (12,3,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (13,3,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (14,3,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (15,3,1,'Da Thanh Toan');
-- Ielts 1
insert into BienLaiHocPhi values (1,4,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (3,4,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (5,4,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (7,4,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (9,4,1,'Da Thanh Toan');
-- Ielts 2
insert into BienLaiHocPhi values (2,5,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (4,5,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (6,5,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (8,5,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (10,5,1,'Da Thanh Toan');
-- Ielts 3
insert into BienLaiHocPhi values (11,6,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (12,6,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (13,6,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (14,6,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (15,6,1,'Da Thanh Toan');
-- TA Giao Tiep 1
insert into BienLaiHocPhi values (1,7,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (4,7,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (7,7,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (10,7,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (13,7,1,'Da Thanh Toan');
-- TA Giao Tiep 2
insert into BienLaiHocPhi values (2,8,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (5,8,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (8,8,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (11,8,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (14,8,1,'Da Thanh Toan');
-- TA Giao Tiep 3
insert into BienLaiHocPhi values (3,9,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (6,9,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (9,9,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (12,9,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (15,9,1,'Da Thanh Toan');
-- TOEFL 1
insert into BienLaiHocPhi values (1,10,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (15,10,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (2,10,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (14,10,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (3,10,1,'Da Thanh Toan');
-- TOEFL 2
insert into BienLaiHocPhi values (13,11,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (4,11,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (12,11,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (5,11,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (11,11,1,'Da Thanh Toan');
-- TOEFL 3
insert into BienLaiHocPhi values (6,12,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (10,12,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (7,12,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (9,12,1,'Da Thanh Toan');
insert into BienLaiHocPhi values (8,12,1,'Da Thanh Toan');
-- KETQUA
-- Toeic 1
insert into KetQua values (1,1,1,7,9,8);
insert into KetQua values (2,1,1,10,9,9.5);
insert into KetQua values (3,1,1,7,9,8);
insert into KetQua values (4,1,1,8,9,8.5);
insert into KetQua values (5,1,1,8.5,9.5,9);
-- Toeic 2
insert into KetQua values (6,2,1,7,9,8);
insert into KetQua values (7,2,1,9,7,8);
insert into KetQua values (8,2,1,8,9,8.5);
insert into KetQua values (9,2,1,7,9,8);
insert into KetQua values (10,2,1,8.5,9.5,9);
-- Toeic 3
insert into KetQua values (11,3,1,8.5,9.5,9);
insert into KetQua values (12,3,1,7,8,7.5);
insert into KetQua values (13,3,1,7,9,8);
insert into KetQua values (14,3,1,7,8,7.5);
insert into KetQua values (15,3,1,7,9,8);
-- Ielts 1
insert into KetQua values (1,4,1,10,8,9);
insert into KetQua values (3,4,1,7,9,8);
insert into KetQua values (5,4,1,7.5,9,8.25);
insert into KetQua values (7,4,1,8,9,8.5);
insert into KetQua values (9,4,1,7,8,7.5);
-- Ielts 2
insert into KetQua values (2,5,1,7,9,8);
insert into KetQua values (4,5,1,7,8,7.5);
insert into KetQua values (6,5,1,7,9,8);
insert into KetQua values (8,5,1,8,9,8.5);
insert into KetQua values (10,5,1,8.5,9.5,9);
-- Ielts 3
insert into KetQua values (11,6,1,8,9,8.5);
insert into KetQua values (12,6,1,7,9,8);
insert into KetQua values (13,6,1,7,9,8);
insert into KetQua values (14,6,1,9,9.5,9.25);
insert into KetQua values (15,6,1,8,9,8.5);
-- TA Giao Tiep 1
insert into KetQua values (1,7,1,7,9,8);
insert into KetQua values (4,7,1,8,9,8.5);
insert into KetQua values (7,7,1,7,8,7.5);
insert into KetQua values (10,7,1,8,9,8.5);
insert into KetQua values (13,7,1,7,9,8);
-- TA Giao Tiep 2
insert into KetQua values (2,8,1,8.5,9.5,9);
insert into KetQua values (5,8,1,8,9,8.5);
insert into KetQua values (8,8,1,7,9,8);
insert into KetQua values (11,8,1,7,9,8);
insert into KetQua values (14,8,1,9,9.5,9.25);
-- TA Giao Tiep 3
insert into KetQua values (3,9,1,8,9,8.5);
insert into KetQua values (6,9,1,7,9,8);
insert into KetQua values (9,9,1,8.5,9.5,9);
insert into KetQua values (12,9,1,9,9.5,9.25);
insert into KetQua values (15,9,1,7,9,8);
-- TOEFL 1
insert into KetQua values (1,10,1,7,9,8);
insert into KetQua values (15,10,1,8,9,8.5);
insert into KetQua values (2,10,1,8.5,9.5,9);
insert into KetQua values (14,10,1,7,9,8);
insert into KetQua values (3,10,1,8.5,9.5,9);
-- TOEFL 2
insert into KetQua values (13,11,1,7,8,7.5);
insert into KetQua values (4,11,1,7,9,8);
insert into KetQua values (12,11,1,8,9,8.5);
insert into KetQua values (5,11,1,8.5,9.5,9);
insert into KetQua values (11,11,1,7,9,8);
-- TOEFL 3
insert into KetQua values (6,12,1,8,9,8.5);
insert into KetQua values (10,12,1,8,9,8.5);
insert into KetQua values (7,12,1,7,9,8);
insert into KetQua values (9,12,1,8.5,9.5,9);
insert into KetQua values (8,12,1,7,9,8);

-- KhoaHoc2
-- LOPHOC
insert into LopHoc values (1,2,1,1,'Sang','2-4-6',10,3000000);
insert into LopHoc values (2,2,1,1,'Chieu','2-4-6',10,3000000);
insert into LopHoc values (3,2,1,2,'Toi','2-4-6',10,3000000);
-- Ielts
insert into LopHoc values (4,2,2,2,'Sang','2-4-6',10,7000000);
insert into LopHoc values (5,2,2,3,'Chieu','2-4-6',10,7000000);
insert into LopHoc values (6,2,2,3,'Chieu','2-4-6',10,7000000);
-- TA Giao Tiep
insert into LopHoc values (7,2,3,4,'Sang','3-5-7',10,7000000);
insert into LopHoc values (8,2,3,4,'Chieu','3-5-7',10,7000000);
insert into LopHoc values (9,2,3,5,'Chieu','3-5-7',10,7000000);
-- TOEFL
insert into LopHoc values (10,2,4,6,'Sang','3-5-7',10,10000000);
insert into LopHoc values (11,2,4,7,'Chieu','3-5-7',10,10000000);
insert into LopHoc values (12,2,4,8,'Toi','3-5-7',10,10000000);
--BIENLAIHOCPHI
-- Toeic 1
insert into BienLaiHocPhi values (16,1,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (17,1,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (18,1,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (19,1,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (20,1,2,'Da Thanh Toan');
-- Toeic 2
insert into BienLaiHocPhi values (21,2,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (22,2,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (23,2,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (24,2,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (25,2,2,'Da Thanh Toan');
-- Toeic 3
insert into BienLaiHocPhi values (26,3,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (27,3,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (28,3,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (29,3,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (30,3,2,'Da Thanh Toan');
-- Ielts 1
insert into BienLaiHocPhi values (16,4,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (18,4,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (20,4,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (22,4,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (24,4,2,'Da Thanh Toan');
-- Ielts 2
insert into BienLaiHocPhi values (17,5,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (19,5,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (21,5,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (23,5,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (25,5,2,'Da Thanh Toan');
-- Ielts 3
insert into BienLaiHocPhi values (26,6,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (27,6,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (28,6,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (29,6,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (30,6,2,'Da Thanh Toan');
-- TA Giao Tiep 1
insert into BienLaiHocPhi values (16,7,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (19,7,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (22,7,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (25,7,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (28,7,2,'Da Thanh Toan');
-- TA Giao Tiep 2
insert into BienLaiHocPhi values (17,8,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (20,8,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (23,8,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (26,8,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (29,8,2,'Da Thanh Toan');
-- TA Giao Tiep 3
insert into BienLaiHocPhi values (18,9,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (21,9,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (24,9,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (27,9,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (30,9,2,'Da Thanh Toan');
-- TOEFL 1
insert into BienLaiHocPhi values (16,10,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (30,10,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (17,10,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (29,10,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (18,10,2,'Da Thanh Toan');
-- TOEFL 2
insert into BienLaiHocPhi values (28,11,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (19,11,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (27,11,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (20,11,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (26,11,2,'Da Thanh Toan');
-- TOEFL 3
insert into BienLaiHocPhi values (21,12,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (25,12,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (22,12,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (24,12,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (23,12,2,'Da Thanh Toan');
insert into BienLaiHocPhi values (23,11,2,'Da Thanh Toan');

SELECT * FROM BienLaiHocPhi
SELECT * FROM DangNhap
SELECT * FROM GiangVien
SELECT * FROM HocVien
SELECT * FROM KetQua
SELECT * FROM KhoaHoc
SELECT * FROM LopHoc
SELECT * FROM MonHoc
SELECT * FROM NhanVien
----------------------------
DROP TABLE BienLaiHocPhi
DROP TABLE KetQua
DROP TABLE LopHoc
DROP TABLE MonHoc
DROP TABLE NhanVien
DROP TABLE GiangVien
DROP TABLE HocVien
DROP TABLE KhoaHoc
DROP TABLE DangNhap




