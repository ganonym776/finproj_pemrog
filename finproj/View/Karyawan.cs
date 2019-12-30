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
    public partial class Karyawan : UserControl
    {
        private List<Pegawai> listOfPegawai = new List<Pegawai>();
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
            lvPegawai.View = View.Details;
            lvPegawai.Columns.Add(" ", 7, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("ID.", 60, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Nama", 130, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("NIK", 100, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Jabatan", 140, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Gender", 80, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Goldar", 50, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Agama", 80, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Ttl", 160, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Telp", 90, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Status", 80, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("alamat", 100, HorizontalAlignment.Center);
            lvPegawai.Columns.Add("Tgl Masuk", 130, HorizontalAlignment.Center);
        }

        public void LoadDataPegawai()
        {
            lvPegawai.Items.Clear();

            listOfPegawai = controller.ReadAll();

            foreach (var krywn in listOfPegawai)
            {
                var itm = new ListViewItem();
                itm.SubItems.Add("K-00" + krywn.IdKrywn.ToString());
                itm.SubItems.Add(krywn.NamaKrywn);
                itm.SubItems.Add(krywn.Nik);
                itm.SubItems.Add(krywn.Nm_jbt);
                itm.SubItems.Add(krywn.Gender);
                itm.SubItems.Add(krywn.Goldar); 
                itm.SubItems.Add(krywn.Agama);
                itm.SubItems.Add(krywn.Ttl);
                itm.SubItems.Add(krywn.Telp);
                itm.SubItems.Add(krywn.Status);
                itm.SubItems.Add(krywn.Alamat);
                itm.SubItems.Add(krywn.TglMasuk.ToShortDateString());

                lvPegawai.Items.Add(itm);
            }
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
            krywn.TglLahir = Convert.ToDateTime(dateTglLhr.Value.ToShortDateString());
            krywn.Agama = drpdAgama.Text;
            krywn.Status = drpdStatus.Text;
            krywn.TglMasuk = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            krywn.KodeJbt = drpdJabatan.SelectedIndex + 1;
            krywn.PnddkanAkhir = drpdPddkn.Text;

            int result = 0;
            result = controller.Create(krywn);
            if (result > 0)
            {
                LoadDataPegawai();
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
                LoadDataPegawai();
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
            if(lvPegawai.SelectedItems.Count > 0)
            {
                Pegawai krywn = listOfPegawai[lvPegawai.SelectedIndices[0]];
                txtNama.Text = krywn.NamaKrywn.ToString();
                txtNik.Text = krywn.Nik.ToString();
                txtTelp.Text = krywn.Telp.ToString();
                txtAlamat.Text = krywn.Alamat.ToString();
                drpdGender.Text = krywn.Gender.ToString();
                drpdGoldar.Text = krywn.Goldar.ToString();
                txtTmpLhr.Text = krywn.TmptLahir.ToString();
                drpdAgama.Text = krywn.Agama.ToString();
                drpdStatus.Text = krywn.Status.ToString();
                drpdJabatan.SelectedValue = krywn.KodeJbt.ToString();
                drpdPddkn.Text = krywn.PnddkanAkhir.ToString();
            }
            else
            {
                MessageBox.Show("Data Karyawan belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Cari_Click(object sender, EventArgs e)
        {
            lvPegawai.Items.Clear();

            listOfPegawai = controller.ReadByNama(txtCari.Text);
            foreach (var krywn in listOfPegawai)
            {
                var itm = new ListViewItem();
                itm.SubItems.Add("K-00" + krywn.IdKrywn.ToString());
                itm.SubItems.Add(krywn.NamaKrywn);
                itm.SubItems.Add(krywn.Nik);
                itm.SubItems.Add(krywn.Nm_jbt);
                itm.SubItems.Add(krywn.Gender);
                itm.SubItems.Add(krywn.Goldar);
                itm.SubItems.Add(krywn.Agama);
                itm.SubItems.Add(krywn.Ttl);
                itm.SubItems.Add(krywn.Telp);
                itm.SubItems.Add(krywn.Status);
                itm.SubItems.Add(krywn.Alamat);
                itm.SubItems.Add(krywn.TglMasuk.ToShortDateString());

                lvPegawai.Items.Add(itm);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lvPegawai.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Karyawan ini ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Pegawai krywn = listOfPegawai[lvPegawai.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(krywn);
                    if (result > 0) LoadDataPegawai();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data Karyawan belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
