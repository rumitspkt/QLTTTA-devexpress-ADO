using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTA.DTO
{
   public class KetQua
   {
      private int maHocVien;
      private int maLopHoc;
      private int maKhoaHoc;
      private float? diemGiuaKy;
      private float? diemCuoiKy;
      private float? diemTB;

      public int MaHocVien { get => maHocVien; set => maHocVien = value; }
      public int MaLopHoc { get => maLopHoc; set => maLopHoc = value; }
      public int MaKhoaHoc { get => maKhoaHoc; set => maKhoaHoc = value; }
      public float? DiemGiuaKy { get => diemGiuaKy; set => diemGiuaKy = value; }
      public float? DiemCuoiKy { get => diemCuoiKy; set => diemCuoiKy = value; }
      public float? DiemTB { get => diemTB; set => diemTB = value; }

      public KetQua(int maHocVien, int maLopHoc, int maKhoaHoc, float? diemGiuaKy, float? diemCuoiKy, float? diemTB)
      {
         this.MaHocVien = maHocVien;
         this.MaLopHoc = maLopHoc;
         this.MaKhoaHoc = maKhoaHoc;
         this.DiemGiuaKy = diemGiuaKy;
         this.DiemCuoiKy = diemCuoiKy;
         this.DiemTB = diemTB;
      }
      public KetQua(DataRow row)
      {
         this.MaHocVien = int.Parse(row["MAHOCVIEN"].ToString());
         this.MaLopHoc = int.Parse(row["MALOPHOC"].ToString());
         this.MaKhoaHoc = int.Parse(row["MAKHOAHOC"].ToString());
         //if (row["DIEMGIUAKY"] != null)
         //{
         //   this.DiemGiuaKy = float.Parse(row["DIEMGIUAKY"].ToString());
         //}
         //else
         //{
         //   this.DiemGiuaKy = null;
         //}
         //if (row["DIEMCUOIKY"] != null)
         //{
         //   this.DiemCuoiKy = float.Parse(row["DIEMCUOIKY"].ToString());
         //}
         //else
         //{
         //   this.DiemCuoiKy = null;
         //}
         //if (row["DIEMTB"] != null)
         //{
         //   this.DiemTB = float.Parse(row["DIEMTB"].ToString());
         //}
         //else
         //{
         //   this.DiemTB = null;
         //}
         if (!row.IsNull("DIEMGIUAKY"))
         {
            this.DiemGiuaKy = float.Parse(row["DIEMGIUAKY"].ToString());
         }
         if (!row.IsNull("DIEMCUOIKY"))
         {
            this.DiemCuoiKy = float.Parse(row["DIEMCUOIKY"].ToString());
         }
         if (!row.IsNull("DIEMTB"))
         {
            this.DiemTB = float.Parse(row["DIEMTB"].ToString());
         }
         //this.DiemGiuaKy = float.Parse(row["DIEMGIUAKY"].ToString());
         //this.DiemCuoiKy = float.Parse(row["DIEMCUOIKY"].ToString());
         //this.DiemTB = float.Parse(row["DIEMTB"].ToString());
      }


   }
}
