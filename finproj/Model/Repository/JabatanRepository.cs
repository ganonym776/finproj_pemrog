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

            return result;
        }

        public int update(Jabatan jbt)
        {
            int result = 0;

            return result;
        }

        public int delete(Jabatan jbt)
        {
            int result = 0;

            return result;
        }

        public List<Jabatan> ReadJbt()
        {
            List<Jabatan> list = new List<Jabatan>();

            return list;
        }
    }
}
