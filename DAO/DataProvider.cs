using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DAO
{
   public class DataProvider
   {
      private static string host;
      private static int port;
      private static string sid;
      private static string password;
      private static string username;



      private static DataProvider instance; 

      public static DataProvider Instance
      {
         get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
         private set { DataProvider.instance = value; }
      }

      public string Host { get => host; set => host = value; }
      public int Port { get => port; set => port = value; }
      public string Sid { get => sid; set => sid = value; }
      public string Password { get => password; set => password = value; }
      public string Username { get => username; set => username = value; }

      private DataProvider() { }

      private string connectionSTR = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
              + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
              + sid + ")));Password=" + password + ";User ID=" + username;

      public DataTable ExecuteQuery(string query, OracleParameter[] oracleParameters = null, object[] parameters = null)
      {
         DataTable data = new DataTable();

         using (OracleConnection connection = new OracleConnection(connectionSTR))
         {
            connection.Open();

            OracleCommand command = new OracleCommand(query, connection);
            
               
            if (parameters != null)
            {                    
               foreach (object parameter in parameters)
               {
                  int i = 0;
                  command.Parameters.Add(oracleParameters[i++]).Value = parameter;
               }
            }

            //OracleParameter op = new OracleParameter("hello", OracleDbType.Array);
            //command.Parameters.Add(op);

            OracleDataAdapter adapter = new OracleDataAdapter(command);

            adapter.Fill(data);

            connection.Close();
         }

         return data;
      }

      public int ExecuteNonQuery(string query, OracleParameter[] oracleParameters = null , object[] parameters = null)
      {
         int data = 0;

         using (OracleConnection connection = new OracleConnection(connectionSTR))
         {
            connection.Open();

            OracleCommand command = new OracleCommand(query, connection);

            if (parameters != null)
            {
               foreach (object parameter in parameters)
               {
                  int i = 0;
                  command.Parameters.Add(oracleParameters[i++]).Value = parameter;
               }
            }

            data = command.ExecuteNonQuery();

            connection.Close();
         }

         return data;
      }

      public object ExecuteScalar(string query, OracleParameter[] oracleParameters = null, object[] parameters = null)
      {
         object data = 0;

         using (OracleConnection connection = new OracleConnection(connectionSTR))
         {
            connection.Open();

            OracleCommand command = new OracleCommand(query, connection);

            if (parameters != null)
            {
               foreach (object parameter in parameters)
               {
                  int i = 0;
                  command.Parameters.Add(oracleParameters[i++]).Value = parameter;
               }
            }

            data = command.ExecuteScalar();

            connection.Close();
         }

         return data;
      }
   }
}
