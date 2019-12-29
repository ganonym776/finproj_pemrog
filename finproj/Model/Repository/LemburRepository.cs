
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
    public class LemburRepository
    {
        private OleDbConnection _conn;

        public LemburRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Jabatan lembur)
        {
            int result = 0;

            return result;
        }

        public int delete(Lembur lembur)
        {
            int result = 0;

            return result;
        }

        public List<Lembur> ReadAll()
        {
            List<Lembur> list = new List<Lembur>();

            return list;
        }

        public List<Lembur> ReadByName()
        {
            List<Lembur> list = new List<Lembur>();

            return list;
        }
    }
}
