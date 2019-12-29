
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

        public int Create(Penggajian gaji)
        {
            int result = 0;
            string sql = @"insert into penggajian (Id_karyawan, Kd_jbt, Id_adm, Period_ke, Period_tahun, Tanggal, Bonus, Lembur, Gaji_total)
                           values()";

            return result;
        }

        public int delete(Penggajian gaji)
        {
            int result = 0;

            return result;
        }

        public List<Penggajian> ReadHistory()
        {
            List<Penggajian> list = new List<Penggajian>();

            return list;
        }
    }
}
