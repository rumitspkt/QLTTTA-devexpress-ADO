using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using QLTTTA.DTO;
namespace QLTTTA.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        public NhanVienDAO() { }
        public bool them(int maNV, string tenNV, DateTime? ngaySinh, string gioiTinh, string cmnd, int luong, string mail)
        {
            try
            {
                string[] sqlParams = {"@MaNV","@TenNV", "@NgaySinh", "@GioiTinh", "@CMND", "@Luong", "@Mail"};
                Object[] parameters = { maNV, tenNV, ngaySinh, gioiTinh, cmnd, luong, mail };
                DataProvider.Instance.ExecuteNonQuery("EXEC ThemNhanVien @MaNV,@TenNV, @NgaySinh, @GioiTinh, @CMND, @Luong, @Mail", sqlParams, parameters);
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool capNhat(int maNV, string tenNV, DateTime? ngaySinh, string gioiTinh, string cmnd, int luong, string mail)
        {
            try
            {
                string[] sqlParams = {"@MaNV", "@TenNV","@NgaySinh", "@GioiTinh", "@CMND", "@Luong", "@Mail"};
                Object[] parameters = { maNV, tenNV, ngaySinh, gioiTinh, cmnd, luong, mail };
                DataProvider.Instance.ExecuteNonQuery("EXEC CapNhatNhanVien @MaNV, @TenNV,@NgaySinh, @GioiTinh, @CMND, @Luong, @Mail", sqlParams, parameters);
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool xoa(int maNV)
        {
            try
            {
                string[] sqlParams = { "@MaNV" };
                Object[] parameters = { maNV };
                DataProvider.Instance.ExecuteNonQuery("EXEC XoaNhanVien @MaNV", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getListNhanVien()
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadnhanvien"));
        }
        public DataTable getNhanVien(string mail)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from nhanvien where mail = '{0}'", mail));

        }

    }
}
