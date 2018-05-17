using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTA.DTO
{
   public class LopHocChiTiet
   {
      private int maLH;
      private string tenMonHoc;
      private int giangVien;
      private string caHoc;
      private string ngayHoc;
      private string soLuongHV;

      public LopHocChiTiet(int maLH, string tenMonHoc, int giangVien, string caHoc, string ngayHoc, string soLuongHV)
      {
         this.MaLH = maLH;
         this.TenMonHoc = tenMonHoc;
         this.GiangVien = giangVien;
         this.CaHoc = caHoc;
         this.NgayHoc = ngayHoc;
         this.SoLuongHV = soLuongHV;
      }

      public int MaLH { get => maLH; set => maLH = value; }
      public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
      public int GiangVien { get => giangVien; set => giangVien = value; }
      public string CaHoc { get => caHoc; set => caHoc = value; }
      public string NgayHoc { get => ngayHoc; set => ngayHoc = value; }
      public string SoLuongHV { get => soLuongHV; set => soLuongHV = value; }
   }
}
