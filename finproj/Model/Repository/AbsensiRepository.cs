
using System.Data.OleDb;
using finproj.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finproj.Model.Repository
{
    public class AbsensiRepository
    {
        private OleDbConnection _conn;

        public AbsensiRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Entity.Absensi absen)
        {
            int result = 0;

            string sql = @"insert into absensi (Id_krywn, Tanggal, Jam_masuk) values ('"+absen.Id_karyawan+"', '"+absen.Tanggal+"', '"+absen.Jam_masuk+"')";
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

        public int delete(Entity.Absensi absen)
        {
            int result = 0;

            string sql = @"delete from absensi where ID = @Id";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Id", absen.Id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Entity.Absensi> ReadAll()
        {
            List<Entity.Absensi> list = new List<Entity.Absensi>();

            try
            {
                string sql = @"select ID, Id_karyawan, Nm_karyawan, absensi.Tanggal, absensi.Jam_masuk from absensi inner join karyawan on absensi.Id_karyawan=karyawan.Id_karyawan order by Nm_karyawan";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Entity.Absensi absen = new Entity.Absensi();
                            absen.Id = Convert.ToInt32(dtr["ID"].ToString());
                            absen.Id_karyawan = Convert.ToInt32(dtr["Id_karyawan"].ToString());
                            absen.Nm_krywn = dtr["Nm_karyawan"].ToString();
                            absen.Tanggal = Convert.ToDateTime(dtr["absensi.Tanggal"].ToString());
                            absen.Jam_masuk = Convert.ToDateTime(dtr["Jam_masuk"].ToString());

                            list.Add(absen);
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

        public List<Entity.Absensi> ReadByName(string nama)
        {
            List<Entity.Absensi> list = new List<Entity.Absensi>();

            try
            {
                string sql = @"select ID, Id_karyawan, Nm_karyawan, absensi.Tanggal, absensi.Jam_masuk from absensi inner join karyawan on absensi.Id_karyawan=karyawan.Id_karyawan where Nm_karyawan='"+nama+"'";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Entity.Absensi absen = new Entity.Absensi();
                            absen.Id = Convert.ToInt32(dtr["ID"].ToString());
                            absen.Id_karyawan = Convert.ToInt32(dtr["Id_karyawan"].ToString());
                            absen.Nm_krywn = dtr["Nm_karyawan"].ToString();
                            absen.Tanggal = Convert.ToDateTime(dtr["absensi.Tanggal"].ToString());
                            absen.Jam_masuk = Convert.ToDateTime(dtr["Jam_masuk"].ToString());

                            list.Add(absen);
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
    }
}
