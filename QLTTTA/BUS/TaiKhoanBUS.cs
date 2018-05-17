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
   public class TaiKhoanBUS
   {
      private static TaiKhoanBUS instance;

      public static TaiKhoanBUS Instance
      {
         get { if (instance == null) instance = new TaiKhoanBUS(); return instance; }
         private set { instance = value; }
      }

      private TaiKhoanBUS() { }
      public TaiKhoan xacThuc(string mail, string matKhau, string quyenDangNhap)
      {
         bool check = TaiKhoanDAO.Instance.dangNhap(mail, matKhau, quyenDangNhap);
         if (check)
            return new TaiKhoan(mail, matKhau, quyenDangNhap);
         return null;
      }
      public bool doiMatKhau(TaiKhoan taiKhoan, string matKhauMoi)
      {
         return TaiKhoanDAO.Instance.capNhat(taiKhoan.Mail, matKhauMoi, taiKhoan.QuyenDangNhap);
      }
      public TaiKhoan getTaiKhoan(string mail)
      {
         DataTable data = TaiKhoanDAO.Instance.getTaiKhoan(mail);
         foreach (DataRow item in data.Rows)
         {
            return new TaiKhoan(item);
         }
         return null;
      }
      public List<TaiKhoan> getListTaiKhoan()
      {
         DataTable data = TaiKhoanDAO.Instance.getListTaiKhoan();
         List<TaiKhoan> list = new List<TaiKhoan>();
         foreach (DataRow item in data.Rows)
         {
            TaiKhoan taiKhoan = new TaiKhoan(item);
            list.Add(taiKhoan);
         }
         return list;
      }
      public List<TaiKhoan> getListTaiKhoanGV()
      {
         DataTable data = TaiKhoanDAO.Instance.getListTaiKhoan();
         List<TaiKhoan> list = new List<TaiKhoan>();
         foreach (DataRow item in data.Rows)
         {
            TaiKhoan taiKhoan = new TaiKhoan(item);
            if(taiKhoan.QuyenDangNhap == "giangvien")
               list.Add(taiKhoan);
         }
         return list;
      }
      public List<TaiKhoan> getListTaiKhoanGVChuaDK()
      {
         List<TaiKhoan> listTaiKhoan = TaiKhoanBUS.Instance.getListTaiKhoanGV();
         List<GiangVien> listGiangVien = GiangVienBUS.Instance.getLisGiangVien();
         List<TaiKhoan> listTaiKhoancChuaDK = new List<TaiKhoan>();
         for(int i = 0; i < listTaiKhoan.Count; i++)
         {
            bool flag = true;
            for(int j = 0; j < listGiangVien.Count; j++)
            {
               if(listTaiKhoan[i].Mail == listGiangVien[j].Mail)
               {
                  flag = false;
                  break;
               }
            }
            if (flag)
            {
               listTaiKhoancChuaDK.Add(listTaiKhoan[i]);
            }
         }
         return listTaiKhoancChuaDK;
      }
      public bool themTaiKhoan(string mail, string matKhau, string quyenDangNhap)
      {
         return TaiKhoanDAO.Instance.them(mail, matKhau, quyenDangNhap);
      }
      public bool capNhatTaiKhoan(string mail, string matKhau, string quyenDangNhap)
      {
         return TaiKhoanDAO.Instance.capNhat(mail, matKhau, quyenDangNhap);
      }
      public bool xoaTaiKhoan(string mail)
      {
         return TaiKhoanDAO.Instance.xoa(mail);
      }
   }
}
