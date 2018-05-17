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
   public partial class frmDSLopHoc : Form
   {
      List<KhoaHoc> listKhoaHoc;
      List<GiangVien> listGiangVien;
      List<MonHoc> listMonHoc;
      List<LopHoc> listLopHoc;
      bool them = false;
      public frmDSLopHoc()
      {
         InitializeComponent();
      }
      private void btnThemLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         them = true;
         edtMaLH.Enabled = true;
         edtCaHoc.Enabled = true;
         edtNgayHoc.Enabled = true;
         nmrSoLuong.Enabled = true;
         cbbGiangVien.Enabled = true;
         cbbKhoaHoc.Enabled = true;
         cbbMonHoc.Enabled = true;
         edtSoTien.Enabled = true;

         edtMaLH.Text = "";
         edtCaHoc.Text = "";
         edtNgayHoc.Text = "";
         nmrSoLuong.Value = 0;
         cbbGiangVien.SelectedIndex = -1;
         cbbKhoaHoc.SelectedIndex = -1;
         cbbMonHoc.SelectedIndex = -1;

         edtMaLH.Focus();
      }
      private void btnXoaLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         int maLH = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaLH");
         int khoaHoc = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KhoaHoc");
         if (XtraMessageBox.Show(string.Format("Bạn có muốn xóa lớp học {0} ?", LopHocBUS.Instance.getLopHoc(maLH).ToString()), "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         {
            bool check = LopHocBUS.Instance.xoaLopHoc(maLH, khoaHoc);
            if (check)
            {
               XtraMessageBox.Show("Xóa lớp học thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         loadData();
         
      }
      private void btnSuaLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         them = false;
         edtMaLH.Enabled = true;
         edtCaHoc.Enabled = true;
         edtNgayHoc.Enabled = true;
         nmrSoLuong.Enabled = true;
         cbbGiangVien.Enabled = true;
         cbbKhoaHoc.Enabled = true;
         cbbMonHoc.Enabled = true;
         edtSoTien.Enabled = true;
         int maKH = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KhoaHoc");
         int maMH = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MonHoc");
         int maGV = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GiangVien");
         cbbGiangVien.SelectedIndex = indexGiangVien(maGV);
         cbbKhoaHoc.SelectedIndex = indexKhoaHoc(maKH);
         cbbMonHoc.SelectedIndex = indexMonHoc(maMH);

      }
      private void btnLuuLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         int maLH = int.Parse(edtMaLH.Text);
         int khoaHoc = listKhoaHoc[cbbKhoaHoc.SelectedIndex].MaKH;
         int monHoc = listMonHoc[cbbMonHoc.SelectedIndex].MaMH;
         int giangVien = listGiangVien[cbbGiangVien.SelectedIndex].MaGV;
         string caHoc = edtCaHoc.Text;
         string ngayHoc = edtNgayHoc.Text;
         string soLuongHV = nmrSoLuong.Value.ToString();
         int soTien = int.Parse(edtSoTien.Text);
         if (them)
         {
            bool check = LopHocBUS.Instance.themLopHoc(maLH, khoaHoc, monHoc, giangVien, caHoc, ngayHoc, soLuongHV, soTien);
            if (check)
            {
               XtraMessageBox.Show("Thêm lớp học thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         else
         {
            bool check = LopHocBUS.Instance.capNhatLopHoc(maLH, khoaHoc, monHoc, giangVien, caHoc, ngayHoc, soLuongHV, soTien);
            if (check)
            {
               XtraMessageBox.Show("Cập nhật lớp học thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         edtMaLH.Enabled = false;
         edtCaHoc.Enabled = false;
         edtNgayHoc.Enabled = false;
         nmrSoLuong.Enabled = false;
         cbbGiangVien.Enabled = false;
         cbbKhoaHoc.Enabled = false;
         cbbMonHoc.Enabled = false;
         edtSoTien.Enabled = false;
         loadData();
      }
      private void btnLammoiLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         listKhoaHoc = KhoaHocBUS.Instance.getListKhoaHoc();
         listGiangVien = GiangVienBUS.Instance.getLisGiangVien();
         listMonHoc = MonHocBUS.Instance.getListMonHoc();
         cbbKhoaHoc.Properties.Items.AddRange(listKhoaHoc);
         cbbMonHoc.Properties.Items.AddRange(listMonHoc);
         cbbGiangVien.Properties.Items.AddRange(listGiangVien);
         loadData();
      }

      private void frmDSLopHoc_Load(object sender, EventArgs e)
      {
         listKhoaHoc = KhoaHocBUS.Instance.getListKhoaHoc();
         listGiangVien = GiangVienBUS.Instance.getLisGiangVien();
         listMonHoc = MonHocBUS.Instance.getListMonHoc();
         cbbKhoaHoc.Properties.Items.AddRange(listKhoaHoc);
         cbbMonHoc.Properties.Items.AddRange(listMonHoc);
         cbbGiangVien.Properties.Items.AddRange(listGiangVien);
         loadData();
      }

      private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
      {
         
      }

      private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
      {
         edtMaLH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaLH").ToString();
         edtCaHoc.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CaHoc");
         edtNgayHoc.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayHoc");
         nmrSoLuong.Value = int.Parse((string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoLuongHV"));
         edtSoTien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoTien").ToString();
         int maKH = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KhoaHoc");
         int maMH = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MonHoc");
         int maGV = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GiangVien");
         cbbGiangVien.Text = GiangVienBUS.Instance.getGiangVien(maGV).ToString();
         cbbKhoaHoc.Text = KhoaHocBUS.Instance.getKhoaHoc(maKH).ToString();
         cbbMonHoc.Text = MonHocBUS.Instance.getMonHoc(maMH).ToString();
         if (edtCaHoc.Enabled)
         {
            edtMaLH.Enabled = false;
            edtCaHoc.Enabled = false;
            edtNgayHoc.Enabled = false;
            nmrSoLuong.Enabled = false;
            cbbGiangVien.Enabled = false;
            cbbKhoaHoc.Enabled = false;
            cbbMonHoc.Enabled = false;
            edtSoTien.Enabled = false;
         }
      }
      private void loadData()
      {
         listLopHoc = LopHocBUS.Instance.getListLopHoc();
         gcLopHoc.DataSource = listLopHoc;
      }
      private int indexKhoaHoc(int maKH)
      {
         for(int i = 0; i < listKhoaHoc.Count; i++)
         {
            if(listKhoaHoc[i].MaKH == maKH)
            {
               return i;
            }
         }
         return -1;
      }
      private int indexMonHoc(int maMH)
      {
         for (int i = 0; i < listMonHoc.Count; i++)
         {
            if (listMonHoc[i].MaMH == maMH)
            {
               return i;
            }
         }
         return -1;
      }
      private int indexGiangVien(int maGV)
      {
         for (int i = 0; i < listGiangVien.Count; i++)
         {
            if (listGiangVien[i].MaGV == maGV)
            {
               return i;
            }
         }
         return -1;
      }

      private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         string fileLocation = @"E:\";
         string fileName = "DSLopHoc";
         fileLocation += fileName + ".xlsx";
         ExportFileExcel.export2FileExcel(gridView1, fileLocation);
         app obj = new app();
         obj.Visible = true;
         Workbook wb = obj.Workbooks.Open(fileLocation);
      }
   }
}
