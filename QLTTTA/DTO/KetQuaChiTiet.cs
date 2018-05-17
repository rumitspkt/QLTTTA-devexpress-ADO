using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTA.DTO
{
   public class KetQuaChiTiet
   {
      private int maHV;
      private string hoTen;
      private float? diemGiuaKy;
      private float? diemCuoiKy;
      private float? diemTB;

      public KetQuaChiTiet(int maHV, string hoTen, float? diemGiuaKy, float? diemCuoiKy, float? diemTB)
      {
         this.MaHV = maHV;
         this.HoTen = hoTen;
         this.DiemGiuaKy = diemGiuaKy;
         this.DiemCuoiKy = diemCuoiKy;
         this.DiemTB = diemTB;
      }

      public int MaHV { get => maHV; set => maHV = value; }
      public string HoTen { get => hoTen; set => hoTen = value; }
      public float? DiemGiuaKy { get => diemGiuaKy; set => diemGiuaKy = value; }
      public float? DiemCuoiKy { get => diemCuoiKy; set => diemCuoiKy = value; }
      public float? DiemTB { get => diemTB; set => diemTB = value; }
   }
}
