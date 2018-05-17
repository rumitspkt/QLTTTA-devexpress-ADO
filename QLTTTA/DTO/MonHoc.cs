using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTA.DTO
{
   public class MonHoc
   {
      private int maMH;
      private string tenMH;
      private int soGioHoc;

      public MonHoc(int maMH, string tenMH, int soGioHoc)
      {
         this.MaMH = maMH;
         this.TenMH = tenMH;
         this.SoGioHoc = soGioHoc;
      }
      public MonHoc(DataRow row)
      {
         this.MaMH = int.Parse(row["MAMH"].ToString());
         this.TenMH = row["TENMH"].ToString();
         this.SoGioHoc = int.Parse(row["SOGIOHOC"].ToString());
         
      }

      public int MaMH { get => maMH; set => maMH = value; }
      public string TenMH { get => tenMH; set => tenMH = value; }
      public int SoGioHoc { get => soGioHoc; set => soGioHoc = value; }
      public override string ToString()
      {
         return string.Format("MH{0} - {1} - Số giờ {2} ", MaMH.ToString(), TenMH, SoGioHoc.ToString());
      }
   }
}
