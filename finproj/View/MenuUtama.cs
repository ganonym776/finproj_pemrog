using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finproj
{
    public partial class MenuUtama : Form
    {
        loginform login = new loginform();

        
        public MenuUtama()
        {
            InitializeComponent();
            
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.Show();
            login.ShowDialog();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        internal static FormStartPosition MousePosition()
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            if(login.Visible == true)
            {
                login.Close();
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (login.Visible == true)
            {
                login.Hide();
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            login.Show();
        }

        private void karyawan1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Karyawan.Visible = false;
            Penggajian.Visible = false;
            Home.Visible = true;
            Absensi.Visible = false;
            Lembur.Visible = false;
        }

        private void btn_krywn_Click(object sender, EventArgs e)
        {
            Karyawan.Enabled = true;
            Karyawan.Visible = true;
            Penggajian.Visible = false;
            Home.Visible = false;
            Absensi.Visible = false;
            Lembur.Visible = false;
        }

        private void btn_absensi_Click(object sender, EventArgs e)
        {
            Karyawan.Visible = false;
            Penggajian.Visible = false;
            Home.Visible = false;
            Absensi.Visible = true;
            Lembur.Visible = false;
        }

        private void btn_gaji_Click(object sender, EventArgs e)
        {
            Karyawan.Visible = false;
            Penggajian.Visible = true;
            Home.Visible = false;
            Absensi.Visible = false;
            Lembur.Visible = false;
        }

        private void btn_lembur_Click(object sender, EventArgs e)
        {
            Karyawan.Visible = false;
            Penggajian.Visible = false;
            Home.Visible = false;
            Absensi.Visible = false;
            Lembur.Visible = true;
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
