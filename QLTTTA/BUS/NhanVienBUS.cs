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
   public class NhanVienBUS
   {
      private static NhanVienBUS instance;

      public static NhanVienBUS Instance
      {
         get { if (instance == null) instance = new NhanVienBUS(); return instance; }
         private set { instance = value; }
      }

      private NhanVienBUS() { }

      public NhanVien getNhanVien(string mail)
      {
         DataTable data = NhanVienDAO.Instance.getNhanVien(mail);
         foreach (DataRow item in data.Rows)
         {
            return new NhanVien(item);
         }
         return null;
      }


   }
}
