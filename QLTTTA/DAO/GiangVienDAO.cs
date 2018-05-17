using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using QLTTTA.DTO;
namespace QLTTTA.DAO
{
    public class GiangVienDAO
    {
        private static GiangVienDAO instance;

        public static GiangVienDAO Instance
        {
            get { if (instance == null) instance = new GiangVienDAO(); return instance; }
            private set { instance = value; }
        }
        public GiangVienDAO() { }
        public bool them(int maGV, string tenGV, DateTime ngaySinh, int thamNien, string hocVi, int luong, string mail)
        {
            try
            {
                string[] sqlParams = { "@MaGV","@TenGV","@NgaySinh","@ThamNien","@HocVi","@Luong","@Mail"};
                Object[] parameters = { maGV, tenGV, ngaySinh, thamNien, hocVi, luong, mail };
                DataProvider.Instance.ExecuteNonQuery("EXEC ThemGiangVien @MaGV, @TenGV, @NgaySinh, @ThamNien, @HocVi, @Luong, @Mail", sqlParams, parameters);
                return true;
            }

            catch
            {
                return false;
            }
        }
        public bool capNhat(int maGV, string tenGV, DateTime ngaySinh, int thamNien, string hocVi, int luong, string mail)
        {
            try
            {
                string[] sqlParams = { "@MaGV","@TenGV", "@NgaySinh","@ThamNien", "@HocVi", "@Luong", "@Mail"};
                Object[] parameters = { maGV, tenGV, ngaySinh, thamNien, hocVi, luong, mail };
                DataProvider.Instance.ExecuteNonQuery("EXEC CapNhatGiangVien @MaGV,@TenGV, @NgaySinh,@ThamNien, @HocVi, @Luong, @Mail", sqlParams, parameters);
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool xoa(int maGV)
        {
            try
            {
                string[] sqlParams = { "@MaGV" };
                Object[] parameters = { maGV };
                DataProvider.Instance.ExecuteNonQuery("EXEC XoaGiangVien @MaGV", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getListGiangVien()
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadgiangvien"));
        }
        public DataTable getGiangVien(string mail)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from giangvien where mail = '{0}'", mail));
        }
        public DataTable getGiangVien(int maGV)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from giangvien where maGV = {0}", maGV.ToString()));
        }
    }
}
