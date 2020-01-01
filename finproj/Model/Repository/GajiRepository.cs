
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using finproj.Model.Context;
using System.Windows.Forms;
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
                string sql = @"select penggajian.Id_penggajian, penggajian.Tanggal, karyawan.Nm_karyawan, jabatan.Nm_jbt, penggajian.Period_ke, penggajian.Period_tahun, jabatan.Gaji_jbt, jabatan.Tunj_jbt, jabatan.Uang_transport, penggajian.Bonus, penggajian.Lembur, penggajian.Gaji_total, admin.Nm_adm 
                               from ((penggajian inner join karyawan on penggajian.Id_karyawan=karyawan.ID_karyawan) inner join jabatan on penggajian.Kd_jbt=jabatan.Kd_jbt) inner join admin on penggajian.Id_adm=admin.ID_adm";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Gaji gaji = new Gaji();
                            gaji.Id_penggajian = Convert.ToInt32(dtr["Id_penggajian"].ToString());
                            gaji.Nm_krywn = dtr["Nm_karyawan"].ToString();
                            gaji.Nm_jbt = dtr["Nm_jbt"].ToString();
                            gaji.Nm_adm = dtr["Nm_adm"].ToString();
                            gaji.Period_ke = Convert.ToInt32(dtr["Period_ke"].ToString());
                            gaji.period_tahun = Convert.ToDateTime(dtr["Period_tahun"].ToString());
                            gaji.Tanggal = Convert.ToDateTime(dtr["Tanggal"].ToString());
                            gaji.Gaji_total = Convert.ToInt32(dtr["Gaji_total"].ToString());
                            gaji.Gaji_pokok = Convert.ToInt32(dtr["Gaji_jbt"].ToString());
                            gaji.Tunj_jbt = Convert.ToInt32(dtr["Tunj_jbt"].ToString());
                            gaji.Uang_transport = Convert.ToInt32(dtr["Uang_transport"].ToString());
                            gaji.Bonus = Convert.ToInt32(dtr["Bonus"].ToString());
                            gaji.Lembur = Convert.ToInt32(dtr["Lembur"].ToString());
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

        public List<Gaji> ReadByNameOrId(string nama)
        {
            List<Gaji> list = new List<Gaji>();
            try
            {
                string sql = @"select penggajian.Id_penggajian, penggajian.Tanggal, karyawan.Nm_karyawan, jabatan.Nm_jbt, penggajian.Period_ke, penggajian.Period_tahun, jabatan.Gaji_jbt, jabatan.Tunj_jbt, jabatan.Uang_transport, penggajian.Bonus, penggajian.Lembur, penggajian.Gaji_total, admin.Nm_adm 
                               from ((penggajian inner join karyawan on penggajian.Id_karyawan=karyawan.ID_karyawan) inner join jabatan on penggajian.Kd_jbt=jabatan.Kd_jbt) inner join admin on penggajian.Id_adm=admin.ID_adm where karyawan.Nm_karyawan like @Nama or penggajian.Id_karyawan like @Id";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", "%"+nama+"%");
                    cmd.Parameters.AddWithValue("@Id", "%"+nama+"%");
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Gaji gaji = new Gaji();
                            gaji.Id_penggajian = Convert.ToInt32(dtr["Id_penggajian"].ToString());
                            gaji.Nm_krywn = dtr["Nm_karyawan"].ToString();
                            gaji.Nm_jbt = dtr["Nm_jbt"].ToString();
                            gaji.Nm_adm = dtr["Nm_adm"].ToString();
                            gaji.Period_ke = Convert.ToInt32(dtr["Period_ke"].ToString());
                            gaji.period_tahun = Convert.ToDateTime(dtr["Period_tahun"].ToString());
                            gaji.Tanggal = Convert.ToDateTime(dtr["Tanggal"].ToString());
                            gaji.Gaji_total = Convert.ToInt32(dtr["Gaji_total"].ToString());
                            gaji.Gaji_pokok = Convert.ToInt32(dtr["Gaji_jbt"].ToString());
                            gaji.Tunj_jbt = Convert.ToInt32(dtr["Tunj_jbt"].ToString());
                            gaji.Uang_transport = Convert.ToInt32(dtr["Uang_transport"].ToString());
                            gaji.Bonus = Convert.ToInt32(dtr["Bonus"].ToString());
                            gaji.Lembur = Convert.ToInt32(dtr["Lembur"].ToString());
                            list.Add(gaji);

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
            }
            return list;
        }

        public List<Gaji> ReadByID(int ID)
        {
            List<Gaji> list = new List<Gaji>();
            try
            {
                string sql = @"select karyawan.Id_karyawan, karyawan.Nik, karyawan.Nm_karyawan, jabatan.Nm_jbt, jabatan.Gaji_jbt, jabatan.Tunj_jbt, jabatan.Uang_transport
                               from karyawan inner join jabatan on karyawan.Kd_jbt=jabatan.Kd_jbt where karyawan.ID_karyawan=@Id";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Id", ID);
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Gaji gaji = new Gaji();
                            gaji.Id_karyawan = Convert.ToInt32(dtr["Id_karyawan"].ToString());
                            gaji.Nik_karyawan = dtr["Nik"].ToString();
                            gaji.Nm_krywn = dtr["Nm_karyawan"].ToString();
                            gaji.Nm_jbt = dtr["Nm_jbt"].ToString();
                            gaji.Gaji_pokok = Convert.ToInt32(dtr["Gaji_jbt"].ToString());
                            gaji.Tunj_jbt = Convert.ToInt32(dtr["Tunj_jbt"].ToString());
                            gaji.Uang_transport = Convert.ToInt32(dtr["Uang_transport"].ToString());
                            list.Add(gaji);

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Karyawan dengan ID '"+ID+"' tidak ditemukan !!");
                System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
            }
            return list;
        }

        public int ReadRiwayatGaji(int id)
        {
            int result = 0;
            try
            {
                string sql = @"select * from penggajian where Id_karyawan = @Id";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            result++;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
            }
            return result;
        }

        public int HitungLembur(int id)
        {
            int result = 0;
            try
            {
                string sql = @"select Total_jam from lembur where Id_karyawan=@Id";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            result = result + (Convert.ToInt32(dtr["Total_jam"].ToString()));
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
            }
            return result;
        }
    }
}
