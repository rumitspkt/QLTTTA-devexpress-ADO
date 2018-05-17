using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace QLTTTA.DAO
{
    public class DataProvider
    {
        //private static string host;
        //private static int port;
        //private static string sid;
        //private static string password;
        //private static string username;



        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        //public string Host { get => host; set => host = value; }
        //public int Port { get => port; set => port = value; }
        //public string Sid { get => sid; set => sid = value; }
        //public string Password { get => password; set => password = value; }
        //public string Username { get => username; set => username = value; }

        private DataProvider() { }

        private string connectionSTR = null;
        //public void setConnectionSTR(string host, int port, string sid, string username, string password)
        //{
        //    connectionSTR = string.Format("Data Source=(local);" +
        //                    "Initial Catalog=TTTA_DB;" +
        //                 "Integrated Security=True");
        //}
        public void setConnectionSTR()
        {
            connectionSTR = string.Format("Data Source=(local);" +
                            "Initial Catalog=TTTA_DB;" +
                         "Integrated Security=True");
        }
        public DataTable ExecuteQuery(string query, SqlParameter[] sqlParameters = null, object[] parameters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                if (parameters != null)
                {
                    int i = 0;
                    //command.CommandType = CommandType.StoredProcedure;
                    foreach (object parameter in parameters)
                    {
                        command.Parameters.Add(sqlParameters[i++]).Value = parameter;
                    }
                }

                //OracleParameter op = new OracleParameter("hello", OracleDbType.Array);
                //command.Parameters.Add(op);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
               
                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, String[] sqlParameters = null, object[] parameters = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    int i = 0;
                    //command.CommandType = CommandType.StoredProcedure;
                    foreach (object parameter in parameters)
                    {
                        command.Parameters.AddWithValue(sqlParameters[i++],parameter);
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, SqlParameter[] sqlParameters = null, object[] parameters = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                int i = 0;
                if (parameters != null)
                {
                    foreach (object parameter in parameters)
                    {
                        command.Parameters.Add(sqlParameters[i++]).Value = parameter;
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
