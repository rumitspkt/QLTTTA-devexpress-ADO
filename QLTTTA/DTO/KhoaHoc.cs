using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTA.DTO
{
   public class KhoaHoc
   {
      private int maKH;
      private DateTime ngayBatDau;
      private int soTuanHoc;
      private string tinhTrang;

      public KhoaHoc(int maKH, DateTime ngayBatDau, int soTuanHoc, string tinhTrang)
      {
         this.maKH = maKH;
         this.NgayBatDau = ngayBatDau;
         this.SoTuanHoc = soTuanHoc;
         this.TinhTrang = tinhTrang;
      }
      public KhoaHoc(DataRow row)
      {
         this.maKH = int.Parse(row["MAKH"].ToString());
         this.NgayBatDau = (DateTime)row["NGAYBATDAU"];
         this.SoTuanHoc = int.Parse(row["SOTUANHOC"].ToString());
         this.TinhTrang = row["TINHTRANG"].ToString();
      }

      public int MaKH { get => maKH; set => maKH = value; }
      public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
      public int SoTuanHoc { get => soTuanHoc; set => soTuanHoc = value; }
      public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
      public override string ToString()
      {
         return string.Format("KH{0} - {1} - {2} Tuần - {3}", MaKH.ToString(), NgayBatDau.ToString(), soTuanHoc.ToString(), TinhTrang);
      }
   }
}
