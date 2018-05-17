using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTTTA.DTO;
using QLTTTA.BUS;

namespace QLTTTA.GUI
{
   public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      public static TaiKhoan taiKhoan;
      public static GiangVien giangVien = null;
      public static NhanVien nhanVien = null;
      public frmMain(TaiKhoan taiKhoan)
      {
         InitializeComponent();
         frmMain.taiKhoan = taiKhoan;
         if(taiKhoan.QuyenDangNhap == "giangvien")
         {
            //gv
            btnSuaThongTin.Enabled = true;
            btnDSHocVienGV.Enabled = true;
            btnXemDiem.Enabled = true;
            //nv ql
            btnDSMonHoc.Enabled = false;
            btnDSKhoaHoc.Enabled = false;
            btnDSLopHoc.Enabled = false;
            btnDSHocVienQL.Enabled = false;
            btnDKMH.Enabled = false;
            btnDSGiangVien.Enabled = false;
            btnDSTaiKhoan.Enabled = false;
            frmMain.giangVien = GiangVienBUS.Instance.getGiangVien(taiKhoan.Mail);
         }
         else
         { 
            //gv
            btnSuaThongTin.Enabled = false;
            btnDSHocVienGV.Enabled = false;
            btnXemDiem.Enabled = false;
            //nv ql
            btnDSMonHoc.Enabled = true;
            btnDSKhoaHoc.Enabled = true;
            btnDSLopHoc.Enabled = true;
            btnDSHocVienQL.Enabled = true;
            btnDKMH.Enabled = true;
            btnDSGiangVien.Enabled = true;
            btnDSTaiKhoan.Enabled = true;
            frmMain.nhanVien = NhanVienBUS.Instance.getNhanVien(taiKhoan.Mail);
         }
      }

      private void ribbonControl1_Click(object sender, EventArgs e)
      {
         
      }

      private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {

      }

      private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {

      }

      private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.kiemTraTonTai(typeof(frmDoiMK));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmDoiMK f = new frmDoiMK();
            f.MdiParent = this;
            f.Show();
         }
      }

      //Dang xuat
      private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         frmMain.taiKhoan = null;
         frmMain.giangVien = null;
         frmMain.nhanVien = null;
         this.Close();
      }

      private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {

      }

      private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {

      }

      private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.kiemTraTonTai(typeof(frmDSKhoaHoc));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmDSKhoaHoc f = new frmDSKhoaHoc();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void btnXemdiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {

      }

      private void barButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.kiemTraTonTai(typeof(frmDSMonhoc));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmDSMonhoc f = new frmDSMonhoc();
            f.MdiParent = this;
            f.Show();
         }
      }

      
      //btn_danhSach
      private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.kiemTraTonTai(typeof(frmDSHocVienTungLop));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmDSHocVienTungLop f = new frmDSHocVienTungLop();
            f.MdiParent = this;
            f.Show();
         }
      }
      private Form kiemTraTonTai(Type fType)
      {
         foreach (Form f in this.MdiChildren)
         {
            if (f.GetType() == fType)
            {
               return f;
            }
         }
         return null;
      }

      private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.kiemTraTonTai(typeof(frmDSLopHoc));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmDSLopHoc f = new frmDSLopHoc();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.kiemTraTonTai(typeof(frmDSHocVien));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmDSHocVien f = new frmDSHocVien();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.kiemTraTonTai(typeof(frmDSGiangVien));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmDSGiangVien f = new frmDSGiangVien();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.kiemTraTonTai(typeof(frmDSTaiKhoan));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmDSTaiKhoan f = new frmDSTaiKhoan();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void suaThongtinBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.kiemTraTonTai(typeof(frmSuaThongTinGV));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmSuaThongTinGV f = new frmSuaThongTinGV();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.kiemTraTonTai(typeof(frmXemDiem));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmXemDiem f = new frmXemDiem();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.kiemTraTonTai(typeof(frmDangKyMonHoc));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmDangKyMonHoc f = new frmDangKyMonHoc();
            f.MdiParent = this;
            f.Show();
         }
      }
   }
}
