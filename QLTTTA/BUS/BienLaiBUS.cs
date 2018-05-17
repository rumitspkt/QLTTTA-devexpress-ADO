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
   public class BienLaiBUS
   {
      private static BienLaiBUS instance;

      public static BienLaiBUS Instance
      {
         get { if (instance == null) instance = new BienLaiBUS(); return instance; }
         private set { instance = value; }
      }

      private BienLaiBUS() { }
      public bool themBienLai(int maHV, int maLH, int maKH, string hoaDon)
      {
         return BienLaiDAO.Instance.them(maHV, maLH, maKH, hoaDon);
      }
      public bool xoaBienLai(int maHV, int maLH, int maKH)
      {
         return BienLaiDAO.Instance.xoa(maHV, maLH, maKH);
      }
      public List<BienLaiHocPhi> getListBienLai(int maKH)
      {
         DataTable data = BienLaiDAO.Instance.getListBienLai(maKH);
         List<BienLaiHocPhi> listBienLai = new List<BienLaiHocPhi>();
         foreach(DataRow item in data.Rows)
         {
            listBienLai.Add(new BienLaiHocPhi(item));
         }
         return listBienLai;
      }
   }
}
