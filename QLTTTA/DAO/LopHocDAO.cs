using System; using System.Collections.Generic; using System.Data; using System.Data.SqlClient; using System.Linq; using System.Text; using System.Threading.Tasks; using Oracle.DataAccess.Client; using QLTTTA.DTO; namespace QLTTTA.DAO {
    public class LopHocDAO
    {
        private static LopHocDAO instance;

        public static LopHocDAO Instance
        {
            get { if (instance == null) instance = new LopHocDAO(); return instance; }
            private set { instance = value; }
        }
        public LopHocDAO() { }
        public bool them(int maLH, int khoaHoc, int monHoc, int giangVien, string caHoc, string ngayHoc, string soLuongHV, int soTien)
        {
            try
            {
                string[] sqlParams = { "@MaLH","@KhoaHoc", "@MonHoc","@GiangVien", "@CaHoc","@NgayHoc", "@SoLuongHV","@SoTien"};
                Object[] parameters = { maLH, khoaHoc, monHoc, giangVien, caHoc, ngayHoc, soLuongHV, soTien };
                DataProvider.Instance.ExecuteNonQuery("EXEC Themlophoc @MaLH, @KhoaHoc, @MonHoc, @GiangVien, @CaHoc, @NgayHoc, @SoLuongHV, @SoTien", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool capNhat(int maLH, int khoaHoc, int monHoc, int giangVien, string caHoc, string ngayHoc, string soLuongHV, int soTien)
        {
            try
            {
                string[] sqlParams = {"@MaLH", "@KhoaHoc", "@MonHoc", "@GiangVien", "@CaHoc","@NgayHoc", "@SoLuongHV","@SoTien"};
                Object[] parameters = { maLH, khoaHoc, monHoc, giangVien, caHoc, ngayHoc, soLuongHV, soTien };
                DataProvider.Instance.ExecuteNonQuery("EXEC CapNhatLopHoc @MaLH, @KhoaHoc, @MonHoc, @GiangVien, @CaHoc,@NgayHoc, @SoLuongHV,@SoTien", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoa(int maLH, int khoaHoc)
        {
            try
            {
                string[] sqlParams = { "@MaLH","@KhoaHoc"};
                Object[] parameters = { maLH, khoaHoc };
                DataProvider.Instance.ExecuteNonQuery("EXEC XoaLopHoc @MaLH, @KhoaHoc", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable getLopHoc(int maLH)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from lophoc where maLH = {0}", maLH.ToString()));
        }
        public DataTable getListLopHoc()
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadlophoc"));
        }
        public DataTable getListLopHocByMaKH(int maKH)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from lophoc where khoahoc = {0}", maKH.ToString()));
        }
        public DataTable getListLopHocByMaKH_MaGV(int maKH, int maGV)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from lophoc where khoahoc = {0} and giangvien = {1}", maKH.ToString(), maGV.ToString()));
        }
    } } 