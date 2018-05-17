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
   public partial class frmDSKhoaHoc : Form
   {
      List<KhoaHoc> listKhoaHoc;
      bool them = false;
      public frmDSKhoaHoc()
      {
         InitializeComponent();
      }

      private void btnThemKH_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         them = true;
         edtMaKH.Text = "";
         nmrSoTuanHoc.Value = 0;
         dateEdtNgayBD.Text = "";
         cbbTinhTrang.Text = "";
         edtMaKH.Enabled = true;
         nmrSoTuanHoc.Enabled = true;
         dateEdtNgayBD.Enabled = true;
         cbbTinhTrang.Enabled = true;

         edtMaKH.Text = (listKhoaHoc[listKhoaHoc.Count - 1].MaKH + 1).ToString();
         edtMaKH.Enabled = false;
      }
      private void btnXoaKH_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         int maKH = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH");
         if (XtraMessageBox.Show(string.Format("Bạn có muốn xóa khóa học {0} ?", KhoaHocBUS.Instance.getKhoaHoc(maKH).ToString()), "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         {
            bool check = KhoaHocBUS.Instance.xoaKhoaHoc(maKH);
            if (check)
            {
               XtraMessageBox.Show("Xóa khóa học thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         loadData();
      }
      private void btnSuaKH_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         them = false;
         edtMaKH.Enabled = true;
         nmrSoTuanHoc.Enabled = true;
         dateEdtNgayBD.Enabled = true;
         cbbTinhTrang.Enabled = true;
         edtMaKH.Focus();
      }
      private void btnLuuKH_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         int maKH = int.Parse(edtMaKH.Text);
         DateTime ngayBatDau = dateEdtNgayBD.DateTime;
         int soTuanHoc = (int)nmrSoTuanHoc.Value;
         string tinhTrang = cbbTinhTrang.Text;
         bool check;
         if (them)
         {
            check = KhoaHocBUS.Instance.themKhoaHoc(maKH, ngayBatDau, soTuanHoc, tinhTrang);
            if (check)
            {
               XtraMessageBox.Show("Thêm khóa học thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         else
         {
            check = KhoaHocBUS.Instance.capNhatKhoaHoc(maKH, ngayBatDau, soTuanHoc, tinhTrang);
            if (check)
            {
               XtraMessageBox.Show("Cập nhật khóa học thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         edtMaKH.Enabled = false;
         nmrSoTuanHoc.Enabled = false;
         dateEdtNgayBD.Enabled = false;
         cbbTinhTrang.Enabled = false;
         loadData();
      }
      private void btnLammoiKH_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
            //MessageBox.Show("hello");
            loadData();
      }

      private void frmDSKhoaHoc_Load(object sender, EventArgs e)
      {
         loadData();
      }

      private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
      {
         edtMaKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
         nmrSoTuanHoc.Value = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoTuanHoc");
         dateEdtNgayBD.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayBatDau").ToString();
         cbbTinhTrang.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TinhTrang");
         edtMaKH.Enabled = false;
         nmrSoTuanHoc.Enabled = false;
         dateEdtNgayBD.Enabled = false;
         cbbTinhTrang.Enabled = false;
      }
      private void loadData()
      {
         listKhoaHoc = KhoaHocBUS.Instance.getListKhoaHoc();
         gcKhoaHoc.DataSource = listKhoaHoc;
      }

      private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         string fileLocation = @"E:\";
         string fileName = "DSKhoaHoc";
         fileLocation += fileName + ".xlsx";
         ExportFileExcel.export2FileExcel(gridView1, fileLocation);
         app obj = new app();
         obj.Visible = true;
         Workbook wb = obj.Workbooks.Open(fileLocation);
      }
   }
}
