using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using finproj.Model.Entity;
using finproj.Controller;

namespace finproj
{
    public partial class Penggajian : UserControl
    {
        private List<Gaji> listGaji = new List<Gaji>();
        private GajiController controller;
        admin adm = new admin();
        public Penggajian()
        {
            InitializeComponent();
            controller = new GajiController();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Kamu belum memasukkan ID karyawan !!!", "Peringatan",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int hitung = controller.ReadRiwayatGaji(Convert.ToInt32(txtSearch.Text)) + 1;
                int JamLembur = controller.HitungLembur(Convert.ToInt32(txtSearch.Text));
                lbl_jamlembur.Text = JamLembur.ToString();
                lblPeriod.Text = hitung.ToString() + ", " + DateTime.Now.ToShortDateString();
                listGaji = controller.ReadByID(Convert.ToInt32(txtSearch.Text));
                foreach(var gaji in listGaji)
                {
                    controller.ReadByID(Convert.ToInt32(txtSearch.Text));
                    lblNama.Text = gaji.Nm_krywn;
                    lblIdKrywn.Text = "K-00" + gaji.Id_karyawan.ToString();
                    lblJbt.Text = gaji.Nm_jbt;
                    lblTgl.Text = DateTime.Now.ToLongDateString();
                    txtGpokok.Text = gaji.Gaji_pokok.ToString();
                    txtTunj.Text = gaji.Tunj_jbt.ToString();
                    txtTransport.Text = gaji.Tunj_jbt.ToString();
                    int GajiLembur = 10000 * JamLembur;
                    txtLembur.Text = GajiLembur.ToString();
                    int Gtotal = gaji.Gaji_pokok + gaji.Tunj_jbt + gaji.Uang_transport + (Convert.ToInt32(txt_Bonus.Text)) + GajiLembur;
                    txtGtotal.Text = Gtotal.ToString();
                }
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
