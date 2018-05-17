using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTTA.DAO;
using Oracle.DataAccess.Client;
using System.Data;
using QLTTTA.DTO;
namespace QLTTTA.BUS
{
   public class KhoaHocBUS
   {
      private static KhoaHocBUS instance;

      public static KhoaHocBUS Instance
      {
         get { if (instance == null) instance = new KhoaHocBUS(); return instance; }
         private set { instance = value; }
      }

      private KhoaHocBUS() { }
      public List<KhoaHoc> getListKhoaHocByMaGV(int maGV)
      {
         DataTable data = KhoaHocDAO.Instance.getListKhoaHocByMaGV(maGV);
         List<KhoaHoc> list = new List<KhoaHoc>();
         foreach (DataRow item in data.Rows)
         {
            KhoaHoc khoaHoc = new KhoaHoc(item);
            list.Add(khoaHoc);
         }

         return list;
      }
      public List<KhoaHoc> getListKhoaHoc()
      {
         DataTable data = KhoaHocDAO.Instance.getListKhoaHoc();
         List<KhoaHoc> list = new List<KhoaHoc>();
         foreach (DataRow item in data.Rows)
         {
            KhoaHoc khoaHoc = new KhoaHoc(item);
            list.Add(khoaHoc);
         }

         return list;
      }
      public List<KhoaHoc> getListKhoaHocHoanThanh()
      {
         DataTable data = KhoaHocDAO.Instance.getListKhoaHoc();
         List<KhoaHoc> list = new List<KhoaHoc>();
         foreach (DataRow item in data.Rows)
         {
            KhoaHoc khoaHoc = new KhoaHoc(item);
            if(khoaHoc.TinhTrang.Length < 12) //Hoan thanh
               list.Add(khoaHoc);
         }

         return list;
      }
      public List<KhoaHoc> getListKhoaHocChuaHoanThanh()
      {
         DataTable data = KhoaHocDAO.Instance.getListKhoaHoc();
         List<KhoaHoc> list = new List<KhoaHoc>();
         foreach (DataRow item in data.Rows)
         {
            KhoaHoc khoaHoc = new KhoaHoc(item);
            if (khoaHoc.TinhTrang.Length > 12) //Hoan thanh
               list.Add(khoaHoc);
         }

         return list;
      }
      public KhoaHoc getKhoaHoc(int maKH)
      {
         DataTable data = KhoaHocDAO.Instance.getKhoaHoc(maKH);
         foreach (DataRow item in data.Rows)
         {
            return new KhoaHoc(item);
         }
         return null;
      }
      public bool themKhoaHoc(int maKH, DateTime ngayBatDau, int soTuanHoc, string tinhTrang)
      {
         return KhoaHocDAO.Instance.them(maKH, ngayBatDau, soTuanHoc, tinhTrang);
      }
      public bool capNhatKhoaHoc(int maKH, DateTime ngayBatDau, int soTuanHoc, string tinhTrang)
      {
         return KhoaHocDAO.Instance.capNhat(maKH, ngayBatDau, soTuanHoc, tinhTrang);
      }
      public bool xoaKhoaHoc(int maKH)
      {
         return KhoaHocDAO.Instance.xoa(maKH);
      }
   }
}
