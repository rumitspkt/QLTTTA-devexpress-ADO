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
   public class LopHocBUS
   {
      private static LopHocBUS instance;

      public static LopHocBUS Instance
      {
         get { if (instance == null) instance = new LopHocBUS(); return instance; }
         private set { instance = value; }
      }

      private LopHocBUS() { }
      public List<LopHoc> getListLopHocByMaKH_MaGV(int maKH, int maGV)
      {
         DataTable data = LopHocDAO.Instance.getListLopHocByMaKH_MaGV(maKH, maGV);
         List<LopHoc> list = new List<LopHoc>();
         foreach (DataRow item in data.Rows)
         {
            LopHoc lopHoc = new LopHoc(item);
            list.Add(lopHoc);
         }
         return list;
      }
      public List<LopHoc> getListLopHoc()
      {
         DataTable data = LopHocDAO.Instance.getListLopHoc();
         List<LopHoc> list = new List<LopHoc>();
         foreach (DataRow item in data.Rows)
         {
            LopHoc lopHoc = new LopHoc(item);
            list.Add(lopHoc);
         }
         return list;
      }
      public LopHoc getLopHoc(int maLH)
      {
         DataTable data = LopHocDAO.Instance.getLopHoc(maLH);
         foreach (DataRow item in data.Rows)
         {
            return new LopHoc(item);
         }
         return null;
      }
      public bool themLopHoc(int maLH, int khoaHoc, int monHoc, int giangVien, string caHoc, string ngayHoc, string soLuongHV, int soTien)
      {
         return LopHocDAO.Instance.them(maLH, khoaHoc, monHoc, giangVien, caHoc, ngayHoc, soLuongHV, soTien);
      }
      public bool capNhatLopHoc(int maLH, int khoaHoc, int monHoc, int giangVien, string caHoc, string ngayHoc, string soLuongHV, int soTien)
      {
         return LopHocDAO.Instance.capNhat(maLH, khoaHoc, monHoc, giangVien, caHoc, ngayHoc, soLuongHV, soTien);
      }
      public bool xoaLopHoc(int maLH, int khoaHoc)
      {
         return LopHocDAO.Instance.xoa(maLH, khoaHoc);
      }
      public List<LopHoc> getListLopHoc(int maKH)
      {
         DataTable data = LopHocDAO.Instance.getListLopHocByMaKH(maKH);
         List<LopHoc> list = new List<LopHoc>();
         foreach (DataRow item in data.Rows)
         {
            LopHoc lopHoc = new LopHoc(item);
            list.Add(lopHoc);
         }
         return list;
      }
      public List<LopHocChiTiet> getListLopHocChiTiet(int maKH)
      {
         List<LopHoc> listLopHoc = LopHocBUS.Instance.getListLopHoc(maKH);
         List<LopHocChiTiet> list = new List<LopHocChiTiet>();
         foreach(LopHoc lopHoc in listLopHoc)
         {
            LopHocChiTiet lopHocChiTiet = new LopHocChiTiet(lopHoc.MaLH, MonHocBUS.Instance.getMonHoc(lopHoc.MonHoc).TenMH, lopHoc.GiangVien, lopHoc.CaHoc, lopHoc.NgayHoc, lopHoc.SoLuongHV);
            list.Add(lopHocChiTiet);
         }
         return list;
      }
      public List<LopHoc> getListLopHocChuaDK(int maHV, int maKH)
      {
         List<LopHoc> listLopHocChuaDK = new List<LopHoc>();
         List<LopHoc> listLopHoc = LopHocBUS.Instance.getListLopHoc(maKH);
         List<LopHoc> listLopHocDaDK = LopHocBUS.Instance.getListLopHocDaDK(maHV, maKH);
         
         foreach(LopHoc lopHoc in listLopHoc)
         {
            bool flag = true;
            foreach(LopHoc lopHocDaDK in listLopHocDaDK)
            {
               if(lopHoc.MaLH == lopHocDaDK.MaLH)
               {
                  flag = false;
                  break;
               }
            }
            if (flag)
            {
               listLopHocChuaDK.Add(lopHoc);
            }
         }
         return listLopHocChuaDK;
      }
      public List<LopHoc> getListLopHocDaDK(int maHV, int maKH)
      {
         List<LopHoc> listLopHocDaDK = new List<LopHoc>();
         List<BienLaiHocPhi> listBienLai = BienLaiBUS.Instance.getListBienLai(maKH);
         foreach (BienLaiHocPhi bienLai in listBienLai)
         {
            if (bienLai.MaHocVien == maHV)
            {
               listLopHocDaDK.Add(LopHocBUS.Instance.getLopHoc(bienLai.MaLopHoc));
            }
         }
         return listLopHocDaDK;
      }
   }
}
