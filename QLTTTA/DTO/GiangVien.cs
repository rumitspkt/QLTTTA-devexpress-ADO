using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTA.DTO
{
   public class GiangVien
   {
      private int maGV;
      private string tenGV;
      private DateTime ngaySinh;
      private int thamNien;
      private string hocVi;
      private int luong;
      private string mail;

      public GiangVien(int maGV, string tenGV, DateTime ngaySinh, int thamNien, string hocVi, int luong, string mail)
      {
         this.maGV = maGV;
         this.tenGV = tenGV;
         this.ngaySinh = ngaySinh;
         this.thamNien = thamNien;
         this.hocVi = hocVi;
         this.luong = luong;
         this.mail = mail;
      }
      public GiangVien(DataRow row)
      {
         this.MaGV = int.Parse(row["MAGV"].ToString());
         this.TenGV = row["TENGV"].ToString();
         this.NgaySinh = (DateTime)row["NGAYSINH"];
         this.ThamNien = int.Parse(row["THAMNIEN"].ToString());
         this.HocVi = row["HOCVI"].ToString();
         this.Luong = int.Parse(row["LUONG"].ToString());
         this.Mail = row["MAIL"].ToString();
      }

      public int MaGV { get => maGV; set => maGV = value; }
      public string TenGV { get => tenGV; set => tenGV = value; }
      public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
      public int ThamNien { get => thamNien; set => thamNien = value; }
      public string HocVi { get => hocVi; set => hocVi = value; }
      public int Luong { get => luong; set => luong = value; }
      public string Mail { get => mail; set => mail = value; }
      public override string ToString()
      {
         return string.Format("GV{0} - {1} - Học vị {2} - Thâm niên {3} năm", MaGV.ToString(), TenGV, HocVi, ThamNien.ToString());
      }
   }
}
