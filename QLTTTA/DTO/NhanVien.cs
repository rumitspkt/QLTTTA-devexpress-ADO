using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTA.DTO
{
   public class NhanVien
   {
      private int maNV;
      private string tenNV;
      private DateTime ngaySinh;
      private string gioiTinh;
      private string cmnd;
      private int luong;
      private string mail;

      public NhanVien(int maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string cmnd, int luong, string mail)
      {
         this.MaNV = maNV;
         this.TenNV = tenNV;
         this.NgaySinh = ngaySinh;
         this.GioiTinh = gioiTinh;
         this.Cmnd = cmnd;
         this.Luong = luong;
         this.Mail = mail;
      }
      public NhanVien(DataRow row)
      {
         this.MaNV = int.Parse(row["MANV"].ToString());
         this.TenNV = row["TENNV"].ToString();
         this.NgaySinh = (DateTime)row["NGAYSINH"];
         this.GioiTinh = row["GIOITINH"].ToString();
         this.Cmnd = row["CMND"].ToString();
         this.Luong = int.Parse(row["LUONG"].ToString());
         this.Mail = row["MAIL"].ToString();
      }

      public int MaNV { get => maNV; set => maNV = value; }
      public string TenNV { get => tenNV; set => tenNV = value; }
      public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
      public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
      public string Cmnd { get => cmnd; set => cmnd = value; }
      public int Luong { get => luong; set => luong = value; }
      public string Mail { get => mail; set => mail = value; }
   }
}
