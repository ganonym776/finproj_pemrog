
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
    public class GajiRepository
    {
        private OleDbConnection _conn;

        public GajiRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Gaji gaji)
        {
            int result = 0;
            string sql = @"insert into penggajian (Id_karyawan, Kd_jbt, Id_adm, Period_ke, Period_tahun, Tanggal, Bonus, Lembur, Gaji_total)
                           values('"+gaji.Id_karyawan+ "','"+gaji.Kd_jbt+ "','"+gaji.Id_adm+ "','"+gaji.Period_ke+ "','"+gaji.period_tahun+ "','"+gaji.Tanggal+ "','"+gaji.Bonus+ "','"+gaji.Lembur+ "','"+gaji.Gaji_total+"')";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int delete(Gaji gaji)
        {
            int result = 0;
            string sql = @"delete from penggajian where Id_penggajian = @Id_penggajian";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Id_penggajian", gaji.Id_penggajian);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Gaji> ReadHistory()
        {
            List<Gaji> list = new List<Gaji>();
            try
            {
                string sql = @"select Id_penggajian, karyawan.Nm_karyawan, jabatan.Nm_jbt, admin.Nm_adm, Period_ke, Period_tahun, Tanggal, Gaji_total
                               from penggajian join karyawan on penggajian.Id_karyawan=karyawan.ID_karyawan join jabatan on penggajian.Kd_jbt=jabatan.Kd_jbt join admin on penggajian.Id_adm=admin.ID_adm";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Gaji gaji = new Gaji();
                            gaji.Id_penggajian = int.Parse(dtr["Id_penggajian"].ToString());
                            gaji.Nm_krywn = dtr["karyawan.Nm_karyawan"].ToString();
                            gaji.Nm_jbt = dtr["jabatan.Nm_jbt"].ToString();
                            gaji.Nm_adm = dtr["admin.Nm_adm"].ToString();
                            gaji.Period_ke = int.Parse(dtr["Period_ke"].ToString());
                            gaji.period_tahun = int.Parse(dtr["Period_tahun"].ToString());
                            gaji.Tanggal = DateTime.Parse(dtr["Tanggal"].ToString());
                            gaji.Gaji_total = int.Parse(dtr["Gaji_total"].ToString());

                            list.Add(gaji);

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
