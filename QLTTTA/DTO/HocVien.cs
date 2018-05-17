using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTA.DTO
{
   public class HocVien
   {
      private int maHV;
      private string hoTen;
      private DateTime ngaySinh;
      private string gioiTinh;
      private string diaChi;
      private string soDienThoai;

      public HocVien(int maHV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai)
      {
         this.maHV = maHV;
         this.hoTen = hoTen;
         this.ngaySinh = ngaySinh;
         this.gioiTinh = gioiTinh;
         this.diaChi = diaChi;
         this.soDienThoai = soDienThoai;
      }

      public HocVien(DataRow row)
      {
         this.MaHV = int.Parse(row["MAHV"].ToString());
         this.HoTen = row["HOTEN"].ToString();
         this.NgaySinh = (DateTime)row["NGAYSINH"];
         this.GioiTinh = row["GIOITINH"].ToString();
         this.DiaChi = row["DIACHI"].ToString();
         this.SoDienThoai = row["SODIENTHOAI"].ToString();
      }

      public int MaHV { get => maHV; set => maHV = value; }
      public string HoTen { get => hoTen; set => hoTen = value; }
      public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
      public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
      public string DiaChi { get => diaChi; set => diaChi = value; }
      public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
      public override string ToString()
      {
         return string.Format("HV{0} - {1} - Ngày sinh: {2} - {3} - Địa chỉ: {4}", MaHV.ToString(), HoTen, NgaySinh.ToString(), GioiTinh, DiaChi);
      }
   }
}
