using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTA.DTO
{
   public class BienLaiHocPhi
   {
      private int maHocVien;
      private int maLopHoc;
      private int maKhoaHoc;
      private string hoaDon;

      public BienLaiHocPhi(int maHocVien, int maLopHoc, int maKhoaHoc, string hoaDon)
      {
         this.MaHocVien = maHocVien;
         this.MaLopHoc = maLopHoc;
         this.MaKhoaHoc = maKhoaHoc;
         this.HoaDon = hoaDon;
      }
      public BienLaiHocPhi(DataRow row)
      {
         this.MaHocVien = int.Parse(row["MAHOCVIEN"].ToString());
         this.MaLopHoc = int.Parse(row["MALOPHOC"].ToString());
         this.MaKhoaHoc = int.Parse(row["MAKHOAHOC"].ToString());
         this.HoaDon = row["HOADON"].ToString();
      }

      public int MaHocVien { get => maHocVien; set => maHocVien = value; }
      public int MaLopHoc { get => maLopHoc; set => maLopHoc = value; }
      public int MaKhoaHoc { get => maKhoaHoc; set => maKhoaHoc = value; }
      public string HoaDon { get => hoaDon; set => hoaDon = value; }
   }
}
