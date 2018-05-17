using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTA.DTO
{
   public class TaiKhoan
   {
      private string mail;
      private string matKhau;
      private string quyenDangNhap;

      public TaiKhoan(string mail, string matKhau, string quyenDangNhap)
      {
         this.mail = mail;
         this.matKhau = matKhau;
         this.quyenDangNhap = quyenDangNhap;
      }

      public TaiKhoan(DataRow row)
      {
         this.Mail = row["MAIL"].ToString();
         this.MatKhau = row["MATKHAU"].ToString();
         this.QuyenDangNhap = row["QUYENDANGNHAP"].ToString();
      }

      public string Mail { get => mail; set => mail = value; }
      public string MatKhau { get => matKhau; set => matKhau = value; }
      public string QuyenDangNhap { get => quyenDangNhap; set => quyenDangNhap = value; }
      public override string ToString()
      {
         return Mail;
      }
   }
}
