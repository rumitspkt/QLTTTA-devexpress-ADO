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
using Microsoft.Office.Interop.Excel;
using QLTTTA.BUS;
using QLTTTA.DTO;
using QLTTTA.Utils;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLTTTA.GUI
{
   public partial class frmDSTaiKhoan : Form
   {
      List<TaiKhoan> listTaiKhoan;
      bool them = false;
      public frmDSTaiKhoan()
      {
         InitializeComponent();
      }
      private void btnThemTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         them = true;

         edtMail.Text = "";
         edtMatKhau.Text = "";
         edtXacNhanMK.Text = "";
         rdbGiangVien.Checked = true;
         rdbAdmin.Checked = true;

         edtMail.Enabled = true;
         edtMatKhau.Enabled = true;
         edtXacNhanMK.Enabled = true;
         rdbAdmin.Enabled = true;
         rdbGiangVien.Enabled = true;
      }
      private void btnXoaTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
            string mail = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mail").ToString();
            if (XtraMessageBox.Show(string.Format("Bạn có muốn xóa tài khoản {0} ?", TaiKhoanBUS.Instance.getTaiKhoan(mail).ToString()), "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool check = TaiKhoanBUS.Instance.xoaTaiKhoan(mail);
                if (check)
                {
                    XtraMessageBox.Show("Xóa tài khoản thành công", "OK");
                }
                else
                {
                    XtraMessageBox.Show("Có lỗi xảy ra", "Error");
                }
            }
            loadData();
        }
      private void btnSuaTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         them = false;

         edtMail.Enabled = true;
         edtMatKhau.Enabled = true;
         edtXacNhanMK.Enabled = true;
         rdbAdmin.Enabled = true;
         rdbGiangVien.Enabled = true;
      }
      private void btnLuuTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         string mail = edtMail.Text;
         string matKhau = edtMatKhau.Text;
         string xacNhanMK = edtXacNhanMK.Text;
         string quyenDangNhap = rdbAdmin.Checked ? "nhanvien" : "giangvien";
         if(matKhau != xacNhanMK)
         {
            XtraMessageBox.Show("Xác nhận mật khẩu không trùng khớp", "Error");
            return;
         }
         bool check;
         if (them)
         {
            check = TaiKhoanBUS.Instance.themTaiKhoan(mail, matKhau, quyenDangNhap);
            if (check)
            {
               XtraMessageBox.Show("Thêm tài khoản thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         else
         {
            check = TaiKhoanBUS.Instance.capNhatTaiKhoan(mail, matKhau, quyenDangNhap);
            if (check)
            {
               XtraMessageBox.Show("Cập nhật tài khoản thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         edtMail.Enabled = false;
         edtMatKhau.Enabled = false;
         edtXacNhanMK.Enabled = false;
         rdbAdmin.Enabled = false;
         rdbGiangVien.Enabled = false;
         loadData();
      }
      private void btnLammoiTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
            loadData();
      }

      private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
      {
         edtMail.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mail");
         edtMatKhau.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MatKhau");
         edtXacNhanMK.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MatKhau");
         string quyenDangNhap = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "QuyenDangNhap");
         bool isGiangVien = (quyenDangNhap == "giangvien" ? true : false);
         rdbGiangVien.Checked = isGiangVien;
         rdbAdmin.Checked = !isGiangVien;

         edtMail.Enabled = false;
         edtMatKhau.Enabled = false;
         edtXacNhanMK.Enabled = false;
         rdbAdmin.Enabled = false;
         rdbGiangVien.Enabled = false;
      }
      private void loadData()
      {
         listTaiKhoan = TaiKhoanBUS.Instance.getListTaiKhoan();
         gcTaiKhoan.DataSource = listTaiKhoan;
      }

      private void frmDSTaiKhoan_Load(object sender, EventArgs e)
      {
         loadData();
      }

      private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         string fileLocation = @"E:\";
         string fileName = "DSTaiKhoan";
         fileLocation += fileName + ".xlsx";
         ExportFileExcel.export2FileExcel(gridView1, fileLocation);
         app obj = new app();
         obj.Visible = true;
         Workbook wb = obj.Workbooks.Open(fileLocation);
      }
   }


}
