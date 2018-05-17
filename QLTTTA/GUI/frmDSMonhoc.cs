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
   public partial class frmDSMonhoc : Form
   {
      List<MonHoc> listMonHoc;
      bool them = false;
      public frmDSMonhoc()
      {
         InitializeComponent();
      }

      private void btnThemMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         them = true;
         edtTenMH.Text = "";
         edtSoGioHoc.Text = "";
         edtMaMH.Text = "";
         edtTenMH.Enabled = true;
         edtSoGioHoc.Enabled = true;
         edtMaMH.Enabled = true;

         edtMaMH.Text = (listMonHoc[listMonHoc.Count - 1].MaMH + 1).ToString();
         edtMaMH.Enabled = false;
      }

      private void btnSuaMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         them = false;
         edtTenMH.Enabled = true;
         edtSoGioHoc.Enabled = true;
         edtMaMH.Enabled = true;
         
      }
      private void btnXoaMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         int maMH = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaMH");
         if (XtraMessageBox.Show(string.Format("Bạn có muốn xóa môn học {0} ?", MonHocBUS.Instance.getMonHoc(maMH).ToString()), "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         {
            bool check = MonHocBUS.Instance.xoaMonHoc(maMH);
            if (check)
            {
               XtraMessageBox.Show("Xóa môn học thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         loadData();
      }
      private void btnLuuMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         int maMH = int.Parse(edtMaMH.Text);
         string tenMH = edtTenMH.Text;
         int soGioHoc = int.Parse(edtSoGioHoc.Text);
         bool check;
         if (them)
         {
            check = MonHocBUS.Instance.themMonHoc(maMH, tenMH, soGioHoc);
            if (check)
            {
               XtraMessageBox.Show("Thêm môn học thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         else
         {
            check = MonHocBUS.Instance.capNhatMonHoc(maMH, tenMH, soGioHoc);
            if (check)
            {
               XtraMessageBox.Show("Cập nhật môn học thành công", "OK");
            }
            else
            {
               XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
         }
         edtTenMH.Enabled = false;
         edtSoGioHoc.Enabled = false;
         edtMaMH.Enabled = false;
         loadData();
      }
      private void btnLammoiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
            loadData();
      }

      private void frmDSMonhoc_Load(object sender, EventArgs e)
      {
         loadData();
      }

      private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
      {
         edtMaMH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaMH").ToString();
         edtSoGioHoc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoGioHoc").ToString();
         edtTenMH.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenMH");
         edtTenMH.Enabled = false;
         edtSoGioHoc.Enabled = false;
         edtMaMH.Enabled = false;
      }
      private void loadData()
      {
         listMonHoc = MonHocBUS.Instance.getListMonHoc();
         gcMonHoc.DataSource = listMonHoc;
      }

      private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         string fileLocation = @"E:\";
         string fileName = "DSMonHoc";
         fileLocation += fileName + ".xlsx";
         ExportFileExcel.export2FileExcel(gridView1, fileLocation);
         app obj = new app();
         obj.Visible = true;
         Workbook wb = obj.Workbooks.Open(fileLocation);
      }
   }
}
