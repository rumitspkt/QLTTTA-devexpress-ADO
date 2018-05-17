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
   public class HocVienBUS
   {
      private static HocVienBUS instance;

      public static HocVienBUS Instance
      {
         get { if (instance == null) instance = new HocVienBUS(); return instance; }
         private set { instance = value; }
      }

      private HocVienBUS() { }
      public List<HocVien> getListHocVien(int maKH, int maLH)
      {
         DataTable data = HocVienDAO.Instance.getListHocVien(maKH, maLH);
         List<HocVien> list = new List<HocVien>();
         foreach (DataRow item in data.Rows)
         {
            HocVien hocVien = new HocVien(item);
            list.Add(hocVien);
         }
         return list;
      }
      public HocVien getHocVien(int maHV)
      {
         DataTable data = HocVienDAO.Instance.getHocVien(maHV);
         foreach (DataRow item in data.Rows)
         {
            return new HocVien(item);
         }
         return null;
      }
      public bool themHocVien(int maHV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai)
      {
         return HocVienDAO.Instance.them(maHV, hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai);
      }
      public bool capNhatHocVien(int maHV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai)
      {
         return HocVienDAO.Instance.capNhat(maHV, hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai);
      }
       public bool xoaHocVien(int maHV)
      {
         return HocVienDAO.Instance.xoa(maHV);
      }
      public List<HocVien> getListHocVien()
      {
         DataTable data = HocVienDAO.Instance.getListHocVien();
         List<HocVien> list = new List<HocVien>();
         foreach (DataRow item in data.Rows)
         {
            HocVien hocVien = new HocVien(item);
            list.Add(hocVien);
         }
         return list;
      }
   }
}
