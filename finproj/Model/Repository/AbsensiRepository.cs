
using System.Data.OleDb;
using finproj.Model.Context;
using finproj.Model.Entity;
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

        public int Create(Absensi absensi)
        {
            int result = 0;

            return result;
        }

        public int delete(Absensi absensi)
        {
            int result = 0;

            return result;
        }

        public List<Absensi> ReadAll()
        {
            List<Absensi> list = new List<Absensi>();

            return list;
        }

        public List<Absensi> ReadByName()
        {
            List<Absensi> list = new List<Absensi>();

            return list;
        }
    }
}
