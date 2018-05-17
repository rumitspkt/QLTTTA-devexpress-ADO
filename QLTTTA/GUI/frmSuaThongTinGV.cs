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
using QLTTTA.DTO;
namespace QLTTTA.GUI
{
   public partial class frmSuaThongTinGV : Form
   {
      public frmSuaThongTinGV()
      {
         InitializeComponent();
         edtHoTen.Text = frmMain.giangVien.TenGV;
         dateEdtNgaySinh.DateTime = frmMain.giangVien.NgaySinh;
      }
      private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         bool check = GiangVienBUS.Instance.suaThongTinGV(frmMain.giangVien, edtHoTen.Text, dateEdtNgaySinh.DateTime);
         if (check)
         {
            XtraMessageBox.Show("Sửa thông tin thành công", "OK");
            frmMain.giangVien = GiangVienBUS.Instance.getGiangVien(frmMain.giangVien.Mail);
         }
         else
         {
            XtraMessageBox.Show("Sửa thông tin không thành công", "Error");
         }
            

      }
   }
}
