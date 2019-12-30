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
            string sql = @"";
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
