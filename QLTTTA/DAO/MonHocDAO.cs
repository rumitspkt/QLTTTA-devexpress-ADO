using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTTA.DTO;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data.SqlClient;

namespace QLTTTA.DAO
{
    public class MonHocDAO
    {
        private static MonHocDAO instance;

        public static MonHocDAO Instance
        {
            get { if (instance == null) instance = new MonHocDAO(); return instance; }
            private set { instance = value; }
        }
        public MonHocDAO() { }
        public bool them(int maMH, string tenMH, int soGioHoc)
        {
            try
            {
                string[] sqlParams = { "@MaMH", "@TenMH", "@SoGioHoc" };
                Object[] parameters = { maMH, tenMH, soGioHoc };
                DataProvider.Instance.ExecuteNonQuery("EXEC ThemMonHoc @MaMH, @TenMH, @SoGioHoc", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool capNhat(int maMH, string tenMH, int soGioHoc)
        {
            try
            {
                string[] sqlParams = { "@MaMH","@TenMH","@SoGioHoc" };
            Object[] parameters = { maMH, tenMH, soGioHoc };
            DataProvider.Instance.ExecuteNonQuery("EXEC CAPNHATMONHOC @MaMH, @TenMH, @SoGioHoc", sqlParams, parameters);
            return true;
        }
         catch
         {
            return false;
         }
      }
    public bool xoa(int maMH)
    {
        try
        {
            string[] sqlParams = { "@MaMH", };
            Object[] parameters = { maMH };
            DataProvider.Instance.ExecuteNonQuery("EXEC XOAMONHOC @MaMH", sqlParams, parameters);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public DataTable getListMonHoc()
    {
        return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadmonhoc"));
    }
    public DataTable getMonHoc(int maMH)
    {
        return DataProvider.Instance.ExecuteQuery(string.Format("select * from monhoc where maMH = {0}", maMH));

    }

}
}
