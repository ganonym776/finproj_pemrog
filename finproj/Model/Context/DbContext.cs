using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace finproj.Model.Context
{
    public class DbContext : IDisposable
    {
        private SqlConnection _conn;

        public SqlConnection Conn 
        {
            get { return _conn ?? (_conn = GetConnectionsString()); }
        }
        private SqlConnection GetConnectionsString()
        {
            SqlConnection conn = null;

            try
            {
                string dbName = @"E:\Tugas Kuliah\Semester 3\Pemrog Lanjut\finproj\finproj\finproj\bin\Debug\database\DbPerpustakaan.mdf";
                string connectionString = string.Format("Server=DESKTOP-OD6FK47\\SQLEXPRESS;" +
                                       "Trusted_Connection=true;" +
                                       "Database={0};" +
                                       "User Instance=true;" +
                                       "Connection timeout=30", dbName);
                conn = new SqlConnection(connectionString);
                conn.Open();
            }

            catch(Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
