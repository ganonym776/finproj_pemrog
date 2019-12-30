using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finproj.Model.Entity
{
    public class Lembur
    {
        public int Id { get; set; }
        public int Id_karyawan { get; set; }
        public string Nm_karyawan { get; set; }
        public int Total_jam { get; set; }
        public DateTime Mulai_lembur { get; set; }
        public string keterangan { get; set; }

    }
}
