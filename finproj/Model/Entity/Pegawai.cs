using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace finproj.Model.Entity
{
    public class Pegawai
    {
        public int IdKrywn { get; set; }
        public string NamaKrywn { get; set; }
        public string Nik { get; set; }
        public string Gender { get; set; }
        public string Goldar { get; set; }
        public string Agama { get; set; }
        public string Alamat { get; set; }
        public string Telp { get; set; }
        public string TmptLahir { get; set; }
        public DateTime TglLahir { get; set; }
        public string Status { get; set; }
        public string PnddkanAkhir { get; set; }
        public int KodeJbt { get; set; }
        public DateTime TglMasuk { get; set; }
        public string Ttl { get; set; }
    }
}
