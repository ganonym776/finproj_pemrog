using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using finproj.Model.Context;
using finproj.Model.Entity;
using System.Windows.Forms;


namespace finproj.Model.Repository
{
    public class PegawaiRepository
    {
        private OleDbConnection _conn;

        public PegawaiRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Pegawai krywn)
        {
            int result = 0;

            string sql = @"insert into karyawan (Nm_karyawan, Nik, Gender, Goldar, Agama, Alamat, Telp, Tmpt_lahir, Tgl_lahir, Status, Pddkn_akhir, Kd_jbt, Tgl_masuk)
                           values ('"+krywn.NamaKrywn+"', '"+krywn.Nik+ "', '"+krywn.Gender+ "', '"+krywn.Goldar+ "', '"+krywn.Agama+ "', '"+krywn.Alamat+ "', '"+krywn.Telp+ "', '"+krywn.TmptLahir+ "', '"+krywn.TglLahir+ "', '"+krywn.Status+ "', '"+krywn.PnddkanAkhir+ "', '"+krywn.KodeJbt+ "', '"+krywn.TglMasuk+"')";

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

        public int Update(Pegawai krywn)
        {
            int result = 0;

            string sql = @"update karyawan set Nm_karyawan = '" + krywn.NamaKrywn + "', Nik = '" + krywn.Nik + "', Gender = '" + krywn.Gender + "', Goldar = '" + krywn.Goldar + "' , Agama = '" + krywn.Agama + "', Alamat = '" + krywn.Alamat + "', Telp = '" + krywn.Telp + "', Tmpt_lahir = '" + krywn.TmptLahir + "', Tgl_lahir ='" + krywn.TglLahir + "', Status = '" + krywn.Status + "', Pddkn_akhir = '" + krywn.PnddkanAkhir + "', Kd_jbt = '" + krywn.KodeJbt + "'  where ID_karyawan = @Id ";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Id", krywn.IdKrywn);
                try
                {

                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show(" ' " + result + " ' ");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Pegawai> ReadAll()
        {
            List<Pegawai> list = new List<Pegawai>();
            try
            {
                string sql = @"select ID_karyawan, Nm_karyawan, Nik, Gender, Goldar, Agama, Alamat, Telp, Tmpt_lahir, Tgl_lahir, Status, Pddkn_akhir, Nm_jbt, Tgl_masuk from karyawan inner join jabatan on karyawan.Kd_jbt = jabatan.Kd_jbt";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pegawai krywn = new Pegawai();
                            krywn.IdKrywn = Convert.ToInt32(dtr["ID_karyawan"].ToString());
                            krywn.NamaKrywn = dtr["Nm_karyawan"].ToString();
                            krywn.Nik = dtr["Nik"].ToString();
                            krywn.Gender = dtr["Gender"].ToString();
                            krywn.Goldar = dtr["Goldar"].ToString();
                            krywn.Agama = dtr["Agama"].ToString();
                            krywn.Alamat = dtr["Alamat"].ToString();
                            krywn.Telp = dtr["Telp"].ToString();
                            krywn.TmptLahir = dtr["Tmpt_lahir"].ToString();
                            krywn.TglLahir = Convert.ToDateTime(dtr["Tgl_lahir"].ToString());
                            krywn.Ttl = krywn.TmptLahir +", "+ krywn.TglLahir.ToLongDateString();
                            krywn.PnddkanAkhir = dtr["Pddkn_akhir"].ToString();
                            krywn.Status = dtr["Status"].ToString();
                            krywn.Nm_jbt = dtr["Nm_jbt"].ToString();
                            krywn.TglMasuk = Convert.ToDateTime(dtr["Tgl_masuk"].ToString());
                            
                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(krywn);
                            
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

        public List<Pegawai> ReadByNama(string nama)
        {
            List<Pegawai> list = new List<Pegawai>();
            try
            {
                string sql = @"select ID_karyawan, Nm_karyawan, Nik, Gender, Goldar, Agama, Alamat, Telp, Tmpt_lahir, Tgl_lahir, Status, Pddkn_akhir, karyawan.Kd_jbt, Nm_jbt, Tgl_masuk
                           from karyawan inner join jabatan on karyawan.Kd_jbt = jabatan.Kd_jbt
                            where Nm_karyawan like @nama order by Nm_karyawan";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pegawai krywn = new Pegawai();
                            krywn.IdKrywn = Convert.ToInt32(dtr["ID_karyawan"].ToString());
                            krywn.NamaKrywn = dtr["Nm_karyawan"].ToString();
                            krywn.Nik = dtr["Nik"].ToString();
                            krywn.Gender = dtr["Gender"].ToString();
                            krywn.Goldar = dtr["Goldar"].ToString();
                            krywn.Agama = dtr["Agama"].ToString();
                            krywn.Alamat = dtr["Alamat"].ToString();
                            krywn.Telp = dtr["Telp"].ToString();
                            krywn.TmptLahir = dtr["Tmpt_lahir"].ToString();
                            krywn.TglLahir = Convert.ToDateTime(dtr["Tgl_lahir"].ToString());
                            krywn.Ttl = krywn.TmptLahir + ", " + krywn.TglLahir.ToLongDateString();
                            krywn.PnddkanAkhir = dtr["Pddkn_akhir"].ToString();
                            krywn.Status = dtr["Status"].ToString();
                            krywn.Nm_jbt = dtr["Nm_jbt"].ToString();
                            krywn.TglMasuk = Convert.ToDateTime(dtr["Tgl_masuk"].ToString());
                            list.Add(krywn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }

        public int Delete(Pegawai krywn)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from karyawan
                           where ID_karyawan = @ID_karyawan";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@ID_karyawan", krywn.IdKrywn);

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
    }
}
