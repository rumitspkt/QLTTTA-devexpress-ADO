using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace QLTTTA.DAO
{
    public class BienLaiDAO
    {
        private static BienLaiDAO instance;

        public static BienLaiDAO Instance
        {
            get { if (instance == null) instance = new BienLaiDAO(); return instance; }
            private set { instance = value; }
        }
        public BienLaiDAO() { }

        public bool them(int maHV, int maLH, int maKH, string hoaDon)
        {
            try
            {
                String[] sqlParams = {"@MaHocVien","@MaLopHoc","@MaKhoaHoc","@HoaDon"};
                Object[] parameters = { maHV, maLH, maKH, hoaDon };
                DataProvider.Instance.ExecuteNonQuery("EXEC ThemBienLai @MaHocVien, @MaLopHoc, @MaKhoaHoc, @HoaDon" , sqlParams, parameters);
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool xoa(int maHV, int maLH, int maKH)
        {
            try
            {
                String[] sqlParams = { "@MaHocVien","@MaLopHoc", "@MaKhoaHoc"};
                Object[] parameters = { maHV, maLH, maKH };
                DataProvider.Instance.ExecuteNonQuery("EXEC XoaBienLai @MaHocVien, @MaLopHoc, @MaKhoaHoc", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable getListBienLai(int maKH)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from  bienlaihocphi where makhoahoc = {0}", maKH.ToString()));
        }
    }
}
