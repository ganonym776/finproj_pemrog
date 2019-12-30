﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace finproj.Model.Context
{
    public class DbContext : IDisposable
    {
        // deklarasi private variabel / field
        private OleDbConnection _conn;

        // deklarasi property Conn (connection), untuk menyimpan objek koneksi
        public OleDbConnection Conn {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        // Method untuk melakukan koneksi ke database
        private OleDbConnection GetOpenConnection()
        {
            OleDbConnection conn = null; // deklarasi objek connection

            try // penggunaan blok try-catch untuk penanganan error
            {
                // atur ulang lokasi database yang disesuaikan dengan
                // lokasi database perpustakaan Anda
                string startupPath = Environment.CurrentDirectory;
                string dbName = startupPath + @"\Database\DbPayroll.mdb";

                // deklarasi variabel connectionString, ref: https://www.connectionstrings.com/
                string connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='"+dbName+"'");

                conn = new OleDbConnection(connectionString); // buat objek connection
                conn.Open(); // buka koneksi ke database
            }
            // jika terjadi error di blok try, akan ditangani langsung oleh blok catch
            catch (Exception ex)
            {
                MessageBox.Show("Can't connect to data sources");
                //System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return conn;
        }

        // Method ini digunakan untuk menghapus objek koneksi dari memory ketika sudah tidak digunakan
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
