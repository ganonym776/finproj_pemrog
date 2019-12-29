using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finproj.Model.Entity;
using finproj.Controller;

namespace finproj
{
    public partial class Karyawan : UserControl
    {
        private List<Pegawai> listPegawai = new List<Pegawai>();
        private PegawaiController controller;
        public Karyawan()
        {
            InitializeComponent();
            controller = new PegawaiController();
            InisialisasiListView();
            LoadDataPegawai();
        }
        private void InisialisasiListView()
        {
            lvPegawai.View = System.Windows.Forms.View.Details;
            lvPegawai.FullRowSelect = true;
            lvPegawai.GridLines = true;

            lvPegawai.Columns.Add("ID.", 60, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Nama", 130, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Jabatan", 140, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Gender", 50, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Goldar", 50, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Agama", 80, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Ttl", 150, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Telp", 80, HorizontalAlignment.Center);
        }

        private void LoadDataPegawai()
        {
            lvPegawai.Items.Clear();
            listPegawai = controller.ReadAll();

            foreach (var krywn in listPegawai)
            {
                var item = new ListViewItem();
                item.SubItems.Add(krywn.IdKrywn.ToString());
                item.SubItems.Add(krywn.NamaKrywn);
                item.SubItems.Add(krywn.KodeJbt.ToString());
                item.SubItems.Add(krywn.Gender.ToString());
                item.SubItems.Add(krywn.Goldar.ToString());
                item.SubItems.Add(krywn.Agama);
                item.SubItems.Add(krywn.Ttl);
                item.SubItems.Add(krywn.Telp.ToString());

                lvPegawai.Items.Add(item);
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Status_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Pegawai krywn = new Pegawai();
            krywn.NamaKrywn = txtNama.Text;
            krywn.Nik = txtNik.Text;
            krywn.Telp = txtTelp.Text;
            krywn.Alamat = txtAlamat.Text;
            krywn.Gender = drpdGender.Text;
            krywn.Goldar = drpdGoldar.Text;
            krywn.TmptLahir = txtTmpLhr.Text;
            krywn.TglLahir = dateTglLhr.Value;
            krywn.Agama = drpdAgama.Text;
            krywn.Status = drpdStatus.Text;
            krywn.TglMasuk = DateTime.Now;
            krywn.KodeJbt = drpdJabatan.SelectedIndex + 1;
            krywn.PnddkanAkhir = drpdPddkn.Text;

            int result = 0;
            result = controller.Create(krywn);
            if (result > 0)
            {
                txtAlamat.Clear();
                txtNik.Clear();
                txtNama.Clear();
                txtTelp.Clear();
                txtAlamat.Clear();
                txtTmpLhr.Clear();
                drpdAgama.Text = "Agama";
                drpdGender.Text = "Gender";
                drpdGoldar.Text = "Goldar";
                drpdJabatan.Text = "jabatan";
                drpdStatus.Text = "status";
                drpdPddkn.Text = "pddkn akhir";
                txtNama.Focus();
            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Pegawai krywn = new Pegawai();
            krywn.NamaKrywn = txtNama.Text;
            krywn.Nik = txtNik.Text;
            krywn.Telp = txtTelp.Text;
            krywn.Alamat = txtAlamat.Text;
            krywn.Gender = drpdGender.Text;
            krywn.Goldar = drpdGoldar.Text;
            krywn.TmptLahir = txtTmpLhr.Text;
            krywn.TglLahir = dateTglLhr.Value;
            krywn.Agama = drpdAgama.Text;
            krywn.Status = drpdStatus.Text;
            krywn.KodeJbt = drpdJabatan.SelectedIndex + 1;
            krywn.PnddkanAkhir = drpdPddkn.Text;

            int result = 0;
            result = controller.Update(krywn);
            if (result > 0)
            {
                txtAlamat.Clear();
                txtNik.Clear();
                txtNama.Clear();
                txtTelp.Clear();
                txtAlamat.Clear();
                txtTmpLhr.Clear();
                drpdAgama.Text = "Agama";
                drpdGender.Text = "Gender";
                drpdGoldar.Text = "Goldar";
                drpdJabatan.Text = "jabatan";
                drpdStatus.Text = "status";
                drpdPddkn.Text = "pddkn akhir";
                txtNama.Focus();
            }
        }

        private void btn_Ubah_Click(object sender, EventArgs e)
        {
            lvPegawai.SelectedItems;
        }
    }
}
