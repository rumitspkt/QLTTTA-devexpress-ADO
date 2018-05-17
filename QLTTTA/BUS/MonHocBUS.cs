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
   public class MonHocBUS
   {
      private static MonHocBUS instance;

      public static MonHocBUS Instance
      {
         get { if (instance == null) instance = new MonHocBUS(); return instance; }
         private set { instance = value; }
      }

      private MonHocBUS() { }
      public MonHoc getMonHoc(int maMH)
      {
         DataTable data = MonHocDAO.Instance.getMonHoc(maMH);
         foreach (DataRow item in data.Rows)
         {
            return new MonHoc(item);
         }
         return null;
      }
      public List<MonHoc> getListMonHoc()
      {
         DataTable data = MonHocDAO.Instance.getListMonHoc();
         List<MonHoc> list = new List<MonHoc>();
         foreach (DataRow item in data.Rows)
         {
            MonHoc monHoc = new MonHoc(item);
            list.Add(monHoc);
         }
         return list;
      }
      public bool themMonHoc(int maMH, string tenMH, int soGioHoc)
      {
         return MonHocDAO.Instance.them(maMH, tenMH, soGioHoc);
      }
      public bool capNhatMonHoc(int maMH, string tenMH, int soGioHoc)
      {
         return MonHocDAO.Instance.capNhat(maMH, tenMH, soGioHoc);
      }
      public bool xoaMonHoc(int maMH)
      {
         return MonHocDAO.Instance.xoa(maMH);
      }
      
   }
}
