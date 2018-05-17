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
   public partial class frmDSHocVien : Form
   {
      List<HocVien> listHocVien;
      bool them = false;
      public frmDSHocVien()
      {
         InitializeComponent();
      }

      private void btnThemHV_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         them = true;

         edtMaHV.Enabled = true;
         edtHoTen.Enabled = true;
         dateEdtNgaySinh.Enabled = true;
         edtDiaChi.Enabled = true;
         edtSoDT.Enabled = true;
         edtGioiTinh.Enabled = true;

         edtMaHV.Text = "";
         edtHoTen.Text = "";
         dateEdtNgaySinh.Text = "";
         edtDiaChi.Text = "";
         edtSoDT.Text = "";

         edtMaHV.Text = (listHocVien[listHocVien.Count - 1].MaHV + 1).ToString();
         edtMaHV.Enabled = false;


      }
      private void btnXoaHV_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         int maHV = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHV");
         if (XtraMessageBox.Show(string.Format("Bạn có muốn xóa học viên {0} ?", HocVienBUS.Instance.getHocVien(maHV).ToString()), "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         {
            bool check = HocVienBUS.Instance.xoaHocVien(maHV);
            if (check)
            {
               XtraMessageBox.Show("Xóa học viên thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         loadData();
      }
      private void btnSuaHV_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         them = false;

         edtMaHV.Enabled = true;
         edtHoTen.Enabled = true;
         dateEdtNgaySinh.Enabled = true;
         edtDiaChi.Enabled = true;
         edtGioiTinh.Enabled = true;
         edtSoDT.Enabled = true;

         edtMaHV.Focus();
      }
      private void btnLuuHV_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         int maHV = int.Parse(edtMaHV.Text);
         string hoTen = edtHoTen.Text;
         DateTime ngaySinh = dateEdtNgaySinh.DateTime;
         string gioiTinh = edtGioiTinh.Text;
         string diaChi = edtDiaChi.Text;
         string soDienThoai = edtSoDT.Text;
         bool check;
         if (them)
         {
            check = HocVienBUS.Instance.themHocVien(maHV, hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai);
            if (check)
            {
               XtraMessageBox.Show("Thêm học viên thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         else
         {
            check = HocVienBUS.Instance.capNhatHocVien(maHV, hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai);
            if (check)
            {
               XtraMessageBox.Show("Cập nhật học viên thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         edtMaHV.Enabled = false;
         edtHoTen.Enabled = false;
         dateEdtNgaySinh.Enabled = false;
         edtDiaChi.Enabled = false;
         edtGioiTinh.Enabled = false;
         edtSoDT.Enabled = false;

         loadData();
      }
      private void btnLammoiHV_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
            loadData();
      }
      private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
      private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
      {
         loadData();
         //MessageBox.Show(listHocVien.Count.ToString());
      }
      private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
      {
         int maHV = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHV");
         HocVien hocVien = HocVienBUS.Instance.getHocVien(maHV);
         edtMaHV.Text = hocVien.MaHV.ToString();
         edtHoTen.Text = hocVien.HoTen;
         dateEdtNgaySinh.DateTime = hocVien.NgaySinh;
         edtDiaChi.Text = hocVien.DiaChi;
         edtSoDT.Text = hocVien.SoDienThoai;
         edtGioiTinh.Text = hocVien.GioiTinh;
         if (edtMaHV.Enabled)
         {
            edtMaHV.Enabled = false;
            edtHoTen.Enabled = false;
            dateEdtNgaySinh.Enabled = false;
            edtDiaChi.Enabled = false;
            edtGioiTinh.Enabled = false;
            edtSoDT.Enabled = false;
         }
         
      }

      private void frmDSHocVien_Load(object sender, EventArgs e)
      {
         loadData();
      }

      private void loadData()
      {
         listHocVien = HocVienBUS.Instance.getListHocVien();
         gcHocVien.DataSource = listHocVien;
      }

      private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         string fileLocation = @"E:\";
         string fileName = "DSHocVien";
         fileLocation += fileName + ".xlsx";
         ExportFileExcel.export2FileExcel(gridView1, fileLocation);
         app obj = new app();
         obj.Visible = true;
         Workbook wb = obj.Workbooks.Open(fileLocation);
      }
   }
}
