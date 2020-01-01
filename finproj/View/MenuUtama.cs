using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finproj.Model.Entity;
using finproj.Controller;

namespace finproj
{
    public partial class MenuUtama : Form
    {
        
        public MenuUtama()
        {
            InitializeComponent();
            LoadMenuUtama();
        }

        private void LoadMenuUtama()
        {
            Karyawan.Visible = false;
            Penggajian.Visible = false;
            Home.Visible = true;
            Absensi.Visible = false;
            Lembur.Visible = false;
            settings1.Visible = false;
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Karyawan.Visible = false;
            Penggajian.Visible = false;
            Home.Visible = false;
            Absensi.Visible = false;
            Lembur.Visible = false;
            settings1.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Karyawan.Visible = false;
            Penggajian.Visible = false;
            Home.Visible = true;
            Absensi.Visible = false;
            Lembur.Visible = false;
            settings1.Visible = false;
        }

        private void btn_krywn_Click(object sender, EventArgs e)
        {
            Karyawan.Enabled = true;
            Karyawan.Visible = true;
            Penggajian.Visible = false;
            Home.Visible = false;
            Absensi.Visible = false;
            Lembur.Visible = false;
            settings1.Visible = false;
        }

        private void btn_absensi_Click(object sender, EventArgs e)
        {
            Karyawan.Visible = false;
            Penggajian.Visible = false;
            Home.Visible = false;
            Absensi.Visible = true;
            Lembur.Visible = false;
            settings1.Visible = false;
        }

        private void btn_gaji_Click(object sender, EventArgs e)
        {
            Karyawan.Visible = false;
            Penggajian.Visible = true;
            Home.Visible = false;
            Absensi.Visible = false;
            Lembur.Visible = false;
            settings1.Visible = false;
        }

        private void btn_lembur_Click(object sender, EventArgs e)
        {
            Karyawan.Visible = false;
            Penggajian.Visible = false;
            Home.Visible = false;
            Absensi.Visible = false;
            Lembur.Visible = true;
            settings1.Visible = false;
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
