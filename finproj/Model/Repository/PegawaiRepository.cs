using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using finproj.Model.Context;
using finproj.Model.Entity;

namespace finproj.Model.Repository
{
    public class PegawaiRepository
    {
        private SqlConnection _conn;

        public PegawaiRepository(DbContext context)
        {
            _conn = context.Conn;
        }
    }
}
