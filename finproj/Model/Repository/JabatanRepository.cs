using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using finproj.Model.Context;
using finproj.Model.Entity;

namespace finproj.Model.Repository
{
    public class JabatanRepository
    {
        private OleDbConnection _conn;

        public JabatanRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Jabatan jbt)
        {
            int result = 0;
            string sql = @"insert into jabatan (Nm_jbt, Gaji_jbt, Tunj_jbt, Uang_transport) values ('"+jbt.Nm_jbt+"', '"+jbt.Gaji_jbt+"', '"+jbt.Tunj_jbt+"', '"+jbt.Uang_transport+"')";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int update(Jabatan jbt)
        {
            int result = 0;
            string sql = @"update jabatan set Nm_jbt = '"+jbt.Nm_jbt+ "', Gaji_jbt = '"+jbt.Gaji_jbt+ "', Tunj_jbt = '"+jbt.Tunj_jbt+ "', Uang_transport = '"+jbt.Uang_transport+ "' where Kd_jbt = '"+jbt.Kd_jbt+"'";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int delete(Jabatan jbt)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"delete from jabatan
                           where Kd_jbt = @Kd_jbt";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Kd_jbt", jbt.Kd_jbt);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Jabatan> ReadJbt()
        {
            List<Jabatan> list = new List<Jabatan>();
            try
            {
                string sql = @"select * from jabatan";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Jabatan jbt = new Jabatan();
                            jbt.Kd_jbt = Convert.ToInt32(dtr["Kd_jbt"].ToString());
                            jbt.Nm_jbt = dtr["Nm_jbt"].ToString();
                            jbt.Gaji_jbt = Convert.ToInt32(dtr["Gaji_jbt"].ToString());
                            jbt.Tunj_jbt = Convert.ToInt32(dtr["Tunj_jbt"].ToString());
                            jbt.Uang_transport = Convert.ToInt32(dtr["Uang_transport"].ToString());
                            list.Add(jbt);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
            }
            return list;
        }

    }
}
