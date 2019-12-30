using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finproj.Model.Entity
{
    public class Absensi
    {
        public int Id { get; set; }
        public int Id_karyawan { get; set; }
        public string Nm_krywn { get; set; }
        public DateTime Tanggal { get; set; }
        public DateTime Jam_masuk { get; set; }

    }
}
