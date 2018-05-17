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
    public partial class frmXemDiem : Form
    {
        List<KhoaHoc> listKhoaHoc;
        List<LopHoc> listLopHoc;
        List<HocVien> listHocVien;
        public frmXemDiem()
        {
            InitializeComponent();

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
            gcXemDiem.DataSource = KetQuaBUS.Instance.getListKetQuaChiTiet(listKhoaHoc[cbbKhoaHoc.SelectedIndex].MaKH, listLopHoc[cbbLopHoc.SelectedIndex].MaLH);
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            edtDiemCuoiKy.Enabled = false;
            edtDiemGiuaKy.Enabled = false;

            edtMaHV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHV").ToString();
            edtHoTen.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HoTen");

            object diemTB = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiemTB");
            object diemGiuaKy = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiemGiuaKy");
            object diemCuoiKy = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiemCuoiKy");
            if (diemTB != null)
            {
                edtDiemTB.Text = diemTB.ToString();
            }
            else
            {
                edtDiemTB.Text = "";
            }
            if (diemGiuaKy != null)
            {
                edtDiemGiuaKy.Text = diemGiuaKy.ToString();
            }
            else
            {
                edtDiemGiuaKy.Text = "";
            }
            if (diemCuoiKy != null)
            {
                edtDiemCuoiKy.Text = diemCuoiKy.ToString();
            }
            else
            {
                edtDiemCuoiKy.Text = "";
            }
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            listKhoaHoc = KhoaHocBUS.Instance.getListKhoaHocByMaGV(frmMain.giangVien.MaGV);
            cbbKhoaHoc.Properties.Items.AddRange(listKhoaHoc);
        }

        private void btnTinhDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = KetQuaBUS.Instance.tinhDiemTB(listLopHoc[cbbLopHoc.SelectedIndex].MaLH, listKhoaHoc[cbbKhoaHoc.SelectedIndex].MaKH);
            if (check)
            {
                XtraMessageBox.Show("Hoàn tất tính điểm", "OK");
            }
            else
            {
                XtraMessageBox.Show("Tính điểm thất bại", "Error");
            }
            gcXemDiem.DataSource = KetQuaBUS.Instance.getListKetQuaChiTiet(listKhoaHoc[cbbKhoaHoc.SelectedIndex].MaKH, listLopHoc[cbbLopHoc.SelectedIndex].MaLH);
        }

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edtDiemGiuaKy.Enabled = true;
            edtDiemCuoiKy.Enabled = true;
            edtDiemGiuaKy.Focus();
        }

        private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int maHV = int.Parse(edtMaHV.Text);
            int maLH = listLopHoc[cbbLopHoc.SelectedIndex].MaLH;
            int maKH = listKhoaHoc[cbbKhoaHoc.SelectedIndex].MaKH;
            float diemGiuaKy = float.Parse(edtDiemGiuaKy.Text);
            float diemCuoiKy = float.Parse(edtDiemCuoiKy.Text);


            bool check;
            if (edtDiemTB.Text == "")
            {
                check = KetQuaBUS.Instance.capNhatKetQua(maHV, maLH, maKH, diemGiuaKy, diemCuoiKy, null);
            }
            else
            {
                float diemTB = float.Parse(edtDiemTB.Text);
                check = KetQuaBUS.Instance.capNhatKetQua(maHV, maLH, maKH, diemGiuaKy, diemCuoiKy, diemTB);
            }


            if (check)
            {
                edtDiemGiuaKy.Enabled = false;
                edtDiemCuoiKy.Enabled = false;
                gcXemDiem.DataSource = KetQuaBUS.Instance.getListKetQuaChiTiet(listKhoaHoc[cbbKhoaHoc.SelectedIndex].MaKH, listLopHoc[cbbLopHoc.SelectedIndex].MaLH);
            }
            else
            {
                XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }
        }

      private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         if (cbbLopHoc.SelectedIndex < 0)
         {
            XtraMessageBox.Show("Vui lòng chọn lớp");
            return;
         }
         string fileLocation = @"E:\";
         string fileName = "BangDiemKH" + listKhoaHoc[cbbKhoaHoc.SelectedIndex].MaKH.ToString() + "-LH" + listLopHoc[cbbLopHoc.SelectedIndex].MaLH.ToString();
         fileLocation += fileName + ".xlsx";
         ExportFileExcel.export2FileExcel(gridView1, fileLocation);
         app obj = new app();
         obj.Visible = true;
         Workbook wb = obj.Workbooks.Open(fileLocation);
      }
   }
}
