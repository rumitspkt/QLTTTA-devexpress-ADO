using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTTA.DTO;
using QLTTTA.DAO;
using System.Data;

namespace QLTTTA.BUS
{
   public class GiangVienBUS
   {
      private static GiangVienBUS instance;

      public static GiangVienBUS Instance
      {
         get { if (instance == null) instance = new GiangVienBUS(); return instance; }
         private set { instance = value; }
      }

      private GiangVienBUS() { }
      public bool suaThongTinGV(GiangVien gv, string hoTen, DateTime ngaySinh)
      {
         return GiangVienDAO.Instance.capNhat(gv.MaGV, hoTen, ngaySinh, gv.ThamNien, gv.HocVi, gv.Luong, gv.Mail);
      } 
      public GiangVien getGiangVien(string mail)
      {
         DataTable data = GiangVienDAO.Instance.getGiangVien(mail);
         foreach (DataRow item in data.Rows)
         {
            return new GiangVien(item);
         }
         return null;
      }
      public GiangVien getGiangVien(int maGV)
      {
         DataTable data = GiangVienDAO.Instance.getGiangVien(maGV);
         foreach (DataRow item in data.Rows)
         {
            return new GiangVien(item);
         }
         return null;
      }
      public bool themGiangVien(int maGV, string tenGV, DateTime ngaySinh, int thamNien, string hocVi, int luong, string mail)
      {
         return GiangVienDAO.Instance.them(maGV, tenGV, ngaySinh, thamNien, hocVi, luong, mail);
      }
      public bool capNhatGiangVien(int maGV, string tenGV, DateTime ngaySinh, int thamNien, string hocVi, int luong, string mail)
      {
         return GiangVienDAO.Instance.capNhat(maGV, tenGV, ngaySinh, thamNien, hocVi, luong, mail);
      }
      public bool xoaGiangVien(int maGV)
      {
         return GiangVienDAO.Instance.xoa(maGV);
      }
      public List<GiangVien> getLisGiangVien()
      {
         List<GiangVien> list = new List<GiangVien>();
         DataTable data = GiangVienDAO.Instance.getListGiangVien();
         foreach(DataRow row in data.Rows)
         {
            GiangVien giangVien = new GiangVien(row);
            list.Add(giangVien);
         }
         return list;
      }
   }
}
