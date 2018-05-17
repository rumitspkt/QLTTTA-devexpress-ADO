using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTTA.BUS;

namespace QLTTTA.DTO
{
   public class LopHoc
   {
      private int maLH;
      private int khoaHoc;
      private int monHoc;
      private int giangVien;
      private string caHoc;
      private string ngayHoc;
      private string soLuongHV;
      private int soTien;

      public LopHoc(int maLH, int khoaHoc, int monHoc, int giangVien, string caHoc, string ngayHoc, string soLuongHV, int soTien)
      {
         this.MaLH = maLH;
         this.KhoaHoc = khoaHoc;
         this.MonHoc = monHoc;
         this.GiangVien = giangVien;
         this.CaHoc = caHoc;
         this.NgayHoc = ngayHoc;
         this.SoLuongHV = soLuongHV;
         this.SoTien = SoTien;
      }
      public LopHoc(DataRow row)
      {
         this.MaLH = int.Parse(row["MALH"].ToString());
         this.KhoaHoc = int.Parse(row["KHOAHOC"].ToString());
         this.MonHoc = int.Parse(row["MONHOC"].ToString());
         this.GiangVien = int.Parse(row["GIANGVIEN"].ToString());
         this.CaHoc = row["CAHOC"].ToString();
         this.NgayHoc = row["NGAYHOC"].ToString();
         this.SoLuongHV = row["SOLUONGHV"].ToString();
         this.SoTien = int.Parse(row["SOTIEN"].ToString());
      }

      public int MaLH { get => maLH; set => maLH = value; }
      public int KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
      public int MonHoc { get => monHoc; set => monHoc = value; }
      public int GiangVien { get => giangVien; set => giangVien = value; }
      public string CaHoc { get => caHoc; set => caHoc = value; }
      public string NgayHoc { get => ngayHoc; set => ngayHoc = value; }
      public string SoLuongHV { get => soLuongHV; set => soLuongHV = value; }
      public int SoTien { get => soTien; set => soTien = value; }

      public override string ToString()
      {
         return string.Format("LH{0} - Môn học: {1} - Ca: {2} - Ngày học: {3} - Số lượng HV: {4} - Số tiền: {5} VNĐ", MaLH.ToString(), MonHocBUS.Instance.getMonHoc(MonHoc).TenMH, CaHoc, NgayHoc, SoLuongHV, SoTien.ToString());
      }
   }
}
