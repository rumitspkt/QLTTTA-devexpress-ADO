using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLTTTA.BUS;

namespace QLTTTA.GUI
{
   public partial class frmDoiMK : Form
   {
      public frmDoiMK()
      {
         InitializeComponent();
         
      }

      private void btnLuuDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         bool check = TaiKhoanBUS.Instance.doiMatKhau(frmMain.taiKhoan, edtMKMoi.Text);
         if(edtMKHienTai.Text != frmMain.taiKhoan.MatKhau || edtMKMoi.Text != edtMKXacNhan.Text)
         {
            XtraMessageBox.Show("Đổi mật khẩu không thành công", "Error");
            return;
         }
         if (check)
         {
            XtraMessageBox.Show("Đổi mật khẩu thành công", "OK");
            edtMKHienTai.Text = "";
            edtMKMoi.Text = "";
            edtMKXacNhan.Text = "";
            frmMain.taiKhoan = TaiKhoanBUS.Instance.getTaiKhoan(frmMain.taiKhoan.Mail);
         }
         else
         {
            XtraMessageBox.Show("Đổi mật khẩu không thành công", "Error");
         }
         
      }
      private void btnLammoiDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         edtMKHienTai.Text = "";
         edtMKMoi.Text = "";
         edtMKXacNhan.Text = "";
      }
   }
}
