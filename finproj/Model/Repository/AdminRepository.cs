using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finproj.Model.Context;
using finproj.Model.Entity;
using System.Data.OleDb;

namespace finproj.Model.Repository
{
    public class AdminRepository
    {
        private OleDbConnection _conn;
        public AdminRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public bool ReadAdmin(string Uname, string Pass)
        {
            
            bool result = false;
            try
            {
                
                string sql = @"select * from admin where Username='"+Uname+"' AND Password='"+Pass+"'";


                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    //cmd.Parameters.AddWithValue("@Uname", "%"+ Uname +"%");
                    //cmd.Parameters.AddWithValue("@Pass", "%" + Pass + "%");
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            admin adm = new admin();
                            adm.id_adm = int.Parse(dtr["ID_adm"].ToString());
                            adm.Nm_admin = dtr["Nm_adm"].ToString();
                            result = true;
                        } 
                    }
                } 
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
            }
            return result;
        }
    }
}
