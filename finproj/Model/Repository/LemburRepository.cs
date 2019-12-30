
using System.Data.OleDb;
using finproj.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finproj.Model.Repository
{
    public class LemburRepository
    {
        private OleDbConnection _conn;

        public LemburRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Entity.Lembur lembur)
        {
            int result = 0;

            string sql = @"insert into lembur (Id_karyawan, Total_jam, waktu, keterangan) values ('"+lembur.Id_karyawan+"', '"+lembur.Total_jam+"', '"+lembur.Mulai_lembur+"', '"+lembur.keterangan+"')";
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

        public int delete(Entity.Lembur lembur)
        {
            int result = 0;
            string sql = @"delete from lembur where ID = @Id";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Id", lembur.Id);
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

        public List<Entity.Lembur> ReadAll()
        {
            List<Entity.Lembur> list = new List<Entity.Lembur>();
            try
            {
                string sql = @"select Id_karyawan, Nm_karyawan, Total_jam, Waktu, Keterangan from lembur inner join karyawan on lembur.Id_karyawan=karyawan.Id_karyawan order by waktu";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Entity.Lembur lembur = new Entity.Lembur();
                            lembur.Id = Convert.ToInt32(dtr["ID"].ToString());
                            lembur.Id_karyawan = Convert.ToInt32(dtr["Id_karyawan"].ToString());
                            lembur.Nm_karyawan = dtr["Nm_karyawan"].ToString();
                            lembur.Total_jam = Convert.ToInt32(dtr["Total_jam"].ToString());
                            lembur.Mulai_lembur = Convert.ToDateTime(dtr["Waktu"].ToString());
                            lembur.keterangan = dtr["Keterangan"].ToString();

                            list.Add(lembur);
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

        public List<Entity.Lembur> ReadByName(string nama)
        {
            List<Entity.Lembur> list = new List<Entity.Lembur>();
            try
            {
                string sql = @"select Id_karyawan, Nm_karyawan, Total_jam, Waktu, Keterangan from lembur inner join karyawan on lembur.Id_karyawan=karyawan.Id_karyawan where Nm_karyawan = '"+nama+"'";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Entity.Lembur lembur = new Entity.Lembur();
                            lembur.Id = Convert.ToInt32(dtr["ID"].ToString());
                            lembur.Id_karyawan = Convert.ToInt32(dtr["Id_karyawan"].ToString());
                            lembur.Nm_karyawan = dtr["Nm_karyawan"].ToString();
                            lembur.Total_jam = Convert.ToInt32(dtr["Total_jam"].ToString());
                            lembur.Mulai_lembur = Convert.ToDateTime(dtr["Waktu"].ToString());
                            lembur.keterangan = dtr["Keterangan"].ToString();

                            list.Add(lembur);
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
