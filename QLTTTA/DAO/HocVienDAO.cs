using System; using System.Collections.Generic; using System.Data; using System.Data.SqlClient; using System.Linq; using System.Text; using System.Threading.Tasks; using Oracle.DataAccess.Client; using QLTTTA.DTO;  namespace QLTTTA.DAO {
    public class HocVienDAO
    {
        private static HocVienDAO instance;

        public static HocVienDAO Instance
        {
            get { if (instance == null) instance = new HocVienDAO(); return instance; }
            private set { instance = value; }
        }
        public HocVienDAO() { }
        public bool them(int maHV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai)
        {
            try
            {
                string[] sqlParams = {"@MaHV","@HoTen","@NgaySinh","@GioiTinh", "@DiaChi", "@SoDienThoai"};
                Object[] parameters = { maHV, hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai };
                DataProvider.Instance.ExecuteNonQuery("EXEC ThemHocVien @MaHV,@HoTen,@NgaySinh,@GioiTinh, @DiaChi, @SoDienThoai", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool capNhat(int maHV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai)
        {
            try
            {
                string[] sqlParams = { "@MaHV","@HoTen","@NgaySinh", "@GioiTinh", "@DiaChi","@SoDienThoai" };
                Object[] parameters = { maHV, hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai };
                DataProvider.Instance.ExecuteNonQuery("EXEC CapNhatHocVien @MaHV,@HoTen,@NgaySinh, @GioiTinh, @DiaChi,@SoDienThoai", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoa(int maHV)
        {
            try
            {
                string[] sqlParams = { "@MaHV" };
                Object[] parameters = { maHV };
                DataProvider.Instance.ExecuteNonQuery("EXEC XoaHocVien @MaHV", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getListHocVien()
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadhocvien"));
        }
        public DataTable getHocVien(int maHV)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from hocvien where maHV = {0}", maHV.ToString()));

        }
        public DataTable getListHocVien(int maKH, int maLH)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from hocvien where maHV  in   (Select mahocvien From bienlaihocphi Where makhoahoc = {0} And malophoc = {1})", maKH.ToString(), maLH.ToString()));
        }
    } } 