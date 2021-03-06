﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace finproj.Model.Entity
{
    public class Gaji
    {
        public int Id_penggajian { get; set; }
        public int Id_karyawan { get; set; }
        public string Nm_krywn { get; set; }
        public string Nm_adm { get; set; }
        public string Nm_jbt { get; set; }
        public int Kd_jbt { get; set; }
        public int Id_adm { get; set; }
        public int Period_ke { get; set; }
        public DateTime period_tahun { get; set; }
        public DateTime Tanggal { get; set; }
        public int Gaji_pokok { get; set; }
        public string Nik_karyawan { get; set; }
        public int Tunj_jbt { get; set; }
        public int Uang_transport { get; set; }
        public int Bonus { get; set; }
        public int Lembur { get; set; }
        public int Gaji_total { get; set; }
    }
}
