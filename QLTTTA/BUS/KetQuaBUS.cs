using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTTA.DAO;
using QLTTTA.DTO;

namespace QLTTTA.BUS
{
   public class KetQuaBUS
   {
      private static KetQuaBUS instance;

      public static KetQuaBUS Instance
      {
         get { if (instance == null) instance = new KetQuaBUS(); return instance; }
         private set { instance = value; }
      }

      private KetQuaBUS() { }
      public KetQua getKetQua(int maHV, int maLH, int maKH)
      {
         DataTable data = KetQuaDAO.Instance.getKetQua(maHV, maLH, maKH);
         foreach (DataRow item in data.Rows)
         {
            return new KetQua(item);
         }
         return null;
      }
      public bool themKetQua(int maHV, int maLH, int maKH, float? diemGiuaKy, float? diemCuoiKy, float? diemTB)
      {
         return KetQuaDAO.Instance.them(maHV, maLH, maKH, diemGiuaKy, diemCuoiKy, diemTB);
      }
      public bool capNhatKetQua(int maHV, int maLH, int maKH, float? diemGiuaKy, float? diemCuoiKy, float? diemTB)
      {
         return KetQuaDAO.Instance.capNhat(maHV, maLH, maKH, diemGiuaKy, diemCuoiKy, diemTB);
      }
      public bool xoaKetQua(int maHV, int maLH, int maKH)
      {
         return KetQuaDAO.Instance.xoa(maHV, maLH, maKH);
      }
      public List<KetQuaChiTiet> getListKetQuaChiTiet(int maKH, int maLH)
      {
         List<KetQuaChiTiet> list = new List<KetQuaChiTiet>();
         List<HocVien> listHV = HocVienBUS.Instance.getListHocVien(maKH, maLH);
         foreach(HocVien hocVien in listHV)
         {
            KetQua ketQua = KetQuaBUS.Instance.getKetQua(hocVien.MaHV, maLH, maKH);
            list.Add(new KetQuaChiTiet(hocVien.MaHV, hocVien.HoTen, ketQua.DiemGiuaKy, ketQua.DiemCuoiKy, ketQua.DiemTB));
         }
         return list;
      }
      public bool tinhDiemTB(int maLH, int maKH)
      {
         return KetQuaDAO.Instance.capNhatDiemTB(maLH, maKH);
      }
   }
}
