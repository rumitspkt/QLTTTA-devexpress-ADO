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
    public partial class frmDangKyMonHoc : Form
    {
        List<HocVien> listHocVien;
        List<KhoaHoc> listKhoaHoc;
        List<LopHoc> listLopHoc;

        public frmDangKyMonHoc()
        {
            InitializeComponent();
        }

        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            listHocVien = HocVienBUS.Instance.getListHocVien();
            listKhoaHoc = KhoaHocBUS.Instance.getListKhoaHocChuaHoanThanh();
            cbbHocVien.Properties.Items.AddRange(listHocVien);
            cbbKhoaHoc.Properties.Items.AddRange(listKhoaHoc);
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhoaHoc khoaHoc = listKhoaHoc[cbbKhoaHoc.SelectedIndex];
            HocVien hocVien = listHocVien[cbbHocVien.SelectedIndex];
            listLopHoc = LopHocBUS.Instance.getListLopHocChuaDK(hocVien.MaHV, khoaHoc.MaKH);
            cbbLopHoc.Properties.Items.AddRange(listLopHoc);
            //XtraMessageBox.Show(listLopHoc.Count.ToString(), "OK");
        }

        private void btnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(cbbHocVien.Text==""||cbbLopHoc.Text==""||cbbKhoaHoc.Text=="")
            {
                XtraMessageBox.Show("Vui lòng nhập đủ thông tin", "Error");
                return;
            }
            int maHV = listHocVien[cbbHocVien.SelectedIndex].MaHV;
            int maLH = listLopHoc[cbbLopHoc.SelectedIndex].MaLH;
            int maKH = listKhoaHoc[cbbKhoaHoc.SelectedIndex].MaKH;
            string hoaDon = "Da thanh toan";
            
            bool check = BienLaiBUS.Instance.themBienLai(maHV, maLH, maKH, hoaDon);
            if (check)
            {
                KhoaHoc khoaHoc = listKhoaHoc[cbbKhoaHoc.SelectedIndex];
                HocVien hocVien = listHocVien[cbbHocVien.SelectedIndex];
                listLopHoc = LopHocBUS.Instance.getListLopHocChuaDK(hocVien.MaHV, khoaHoc.MaKH);
                cbbLopHoc.Properties.Items.Clear();
                cbbLopHoc.Properties.Items.AddRange(listLopHoc);
                cbbLopHoc.SelectedIndex = -1;
                XtraMessageBox.Show("Đăng ký lớp thành công", "OK");
            }
            else
            {
                XtraMessageBox.Show("Có lỗi xảy ra", "Error");
            }

        }
    }
}
