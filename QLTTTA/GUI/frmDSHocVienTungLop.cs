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
   public partial class frmDSHocVienTungLop : Form
   {
      List<KhoaHoc> listKhoaHoc;
      List<LopHoc> listLopHoc;
      List<HocVien> listHocVien;
      
      public frmDSHocVienTungLop()
      {
         InitializeComponent();
      }

      private void frmDSHocVienTungLop_Load(object sender, EventArgs e)
      {
         listKhoaHoc = KhoaHocBUS.Instance.getListKhoaHocByMaGV(frmMain.giangVien.MaGV);
         cbbKhoaHoc.Properties.Items.AddRange(listKhoaHoc);
      }
      private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
      {
         KhoaHoc khoaHoc = listKhoaHoc[cbbKhoaHoc.SelectedIndex];
         listLopHoc = LopHocBUS.Instance.getListLopHocByMaKH_MaGV(khoaHoc.MaKH, frmMain.giangVien.MaGV);
         cbbLopHoc.Properties.Items.Clear();
         cbbLopHoc.Properties.Items.AddRange(listLopHoc);
      }
      private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
      {
         listHocVien = HocVienBUS.Instance.getListHocVien(listKhoaHoc[cbbKhoaHoc.SelectedIndex].MaKH, listLopHoc[cbbLopHoc.SelectedIndex].MaLH);
         gcHocVien.DataSource = listHocVien;
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
      }

        private void btnLammoiHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listKhoaHoc = KhoaHocBUS.Instance.getListKhoaHocByMaGV(frmMain.giangVien.MaGV);
            cbbKhoaHoc.Properties.Items.AddRange(listKhoaHoc);
        }

      private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         if (cbbLopHoc.SelectedIndex < 0)
         {
            XtraMessageBox.Show("Vui lòng chọn lớp");
            return;
         }
         string fileLocation = @"E:\";
         string fileName = "DSHocVienKH" + listKhoaHoc[cbbKhoaHoc.SelectedIndex].MaKH.ToString() + "-LH" + listLopHoc[cbbLopHoc.SelectedIndex].MaLH.ToString();
         fileLocation += fileName + ".xlsx";
         ExportFileExcel.export2FileExcel(gridView1, fileLocation);
         app obj = new app();
         obj.Visible = true;
         Workbook wb = obj.Workbooks.Open(fileLocation);
      }
   }
}
