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
    public partial class frmDSGiangVien : Form
    {
        List<GiangVien> listGiangVien;
        List<TaiKhoan> listTaiKhoanGV;
        List<TaiKhoan> listTaiKhoanGVChuaDK;
        bool them = false;
        public frmDSGiangVien()
        {
            InitializeComponent();
        }
        private void btnThemGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            them = true;

            edtMaGV.Text = "";
            edtHoTen.Text = "";
            edtLuong.Text = "";
            dateEdtNgaySinh.Text = "";
            nmrThamNien.Value = 0;
            cbbHocVi.Text = "";
            cbbMail.Text = "";

            edtMaGV.Enabled = true;
            edtHoTen.Enabled = true;
            edtLuong.Enabled = true;
            dateEdtNgaySinh.Enabled = true;
            nmrThamNien.Enabled = true;
            cbbHocVi.Enabled = true;
            cbbMail.Enabled = true;

            if (listGiangVien.Count < 1)
            {
                return;
            }

            edtMaGV.Text = (listGiangVien[listGiangVien.Count - 1].MaGV + 1).ToString();
            edtMaGV.Enabled = false;
        }
        private void btnSuaGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            them = false;

            edtMaGV.Enabled = true;
            edtHoTen.Enabled = true;
            edtLuong.Enabled = true;
            dateEdtNgaySinh.Enabled = true;
            nmrThamNien.Enabled = true;
            cbbHocVi.Enabled = true;
            cbbMail.Enabled = true;
            edtMaGV.Focus();


        }
        private void btnXoaGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int maGV = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaGV");
            if (XtraMessageBox.Show(string.Format("Bạn có muốn xóa giảng viên {0} ?", GiangVienBUS.Instance.getGiangVien(maGV).ToString()), "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool check = GiangVienBUS.Instance.xoaGiangVien(maGV);
                if (check)
                {
                    XtraMessageBox.Show("Xóa giảng viên thành công", "OK");
                }
                else
                {
                    XtraMessageBox.Show("Có lỗi xảy ra", "Error");
                }
            }
            loadData();
        }
        private void btnLuuGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int maGV = int.Parse(edtMaGV.Text);
            string tenGV = edtHoTen.Text;
            DateTime ngaySinh = dateEdtNgaySinh.DateTime;
            int thamNien = (int)nmrThamNien.Value;
            string hocVi = cbbHocVi.Text;
            int luong = int.Parse(edtLuong.Text);
            string mail = cbbMail.Text;

            bool check;
            if (them)
            {
                check = GiangVienBUS.Instance.themGiangVien(maGV, tenGV, ngaySinh, thamNien, hocVi, luong, mail);
                if (check)
                {
                    XtraMessageBox.Show("Thêm giảng viên thành công", "OK");
                }
                else
                {
                    XtraMessageBox.Show("Có lỗi xảy ra", "Error");
                }
            }
            else
            {
                check = GiangVienBUS.Instance.capNhatGiangVien(maGV, tenGV, ngaySinh, thamNien, hocVi, luong, mail);
                if (check)
                {
                    XtraMessageBox.Show("Cập nhật giảng viên thành công", "OK");
                }
                else
                {
                    XtraMessageBox.Show("Có lỗi xảy ra", "Error");
                }
            }
            edtMaGV.Enabled = false;
            edtHoTen.Enabled = false;
            edtLuong.Enabled = false;
            dateEdtNgaySinh.Enabled = false;
            nmrThamNien.Enabled = false;
            cbbHocVi.Enabled = false;
            cbbMail.Enabled = false;
            loadData();
        }
        private void btnLammoiGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        private void frmDSGiangVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            edtMaGV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaGV").ToString();
            edtHoTen.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenGV");
            edtLuong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Luong").ToString();
            dateEdtNgaySinh.DateTime = (DateTime)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh");
            nmrThamNien.Value = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ThamNien");
            cbbHocVi.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HocVi");
            cbbMail.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mail");

            edtMaGV.Enabled = false;
            edtHoTen.Enabled = false;
            edtLuong.Enabled = false;
            dateEdtNgaySinh.Enabled = false;
            nmrThamNien.Enabled = false;
            cbbHocVi.Enabled = false;
            cbbMail.Enabled = false;

        }
        private void loadData()
        {
            listGiangVien = GiangVienBUS.Instance.getLisGiangVien();
            gcGiangVien.DataSource = listGiangVien;
            listTaiKhoanGV = TaiKhoanBUS.Instance.getListTaiKhoanGVChuaDK();
            cbbMail.Properties.Items.Clear();
            cbbMail.Properties.Items.AddRange(listTaiKhoanGV);
        }

      private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         string fileLocation = @"E:\";
         string fileName = "DSGiangVien";
         fileLocation += fileName + ".xlsx";
         ExportFileExcel.export2FileExcel(gridView1, fileLocation);
         app obj = new app();
         obj.Visible = true;
         Workbook wb = obj.Workbooks.Open(fileLocation);
      }
   }
}
