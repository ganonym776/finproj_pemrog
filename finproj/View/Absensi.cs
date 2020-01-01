using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finproj.Controller;

namespace finproj
{
    public partial class Absensi : UserControl
    {
        private List<Model.Entity.Absensi> listOfAbsensi = new List<Model.Entity.Absensi>();
        private AbsensiController controller;
        public Absensi()
        {
            InitializeComponent();
            controller = new AbsensiController();
            inisialisasiListView();
            LoadDataAbsen();
        }

        private void inisialisasiListView()
        {
            lvwAbsen.View = System.Windows.Forms.View.Details;
            lvwAbsen.Columns.Add(" ", 6, HorizontalAlignment.Center);
            lvwAbsen.Columns.Add("ID_Karyawan", 50, HorizontalAlignment.Center);
            lvwAbsen.Columns.Add("Nama", 100, HorizontalAlignment.Center);
            lvwAbsen.Columns.Add("Tanggal", 140, HorizontalAlignment.Center);
            lvwAbsen.Columns.Add("Jam Masuk", 50, HorizontalAlignment.Center);

        }

        private void LoadDataAbsen()
        {
            lvwAbsen.Items.Clear();
            listOfAbsensi = controller.ReadAll();
            foreach(var absen in listOfAbsensi)
            {
                var itm = new ListViewItem();
                itm.SubItems.Add("K-00" + (absen.Id_karyawan.ToString()));
                itm.SubItems.Add(absen.Nm_krywn);
                itm.SubItems.Add(absen.Tanggal.ToLongDateString());
                itm.SubItems.Add(absen.Jam_masuk.ToShortTimeString());
                lvwAbsen.Items.Add(itm);
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text))
            {
                MessageBox.Show("Kamu belum memasukkan ID karyawan !!!", "Peringatan",
MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Model.Entity.Absensi absen = new Model.Entity.Absensi();
                absen.Id_karyawan = Convert.ToInt32(txt_search.Text);
                absen.Tanggal = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                absen.Jam_masuk = Convert.ToDateTime(DateTime.Now.ToShortTimeString());

                int result = 0;
                result = controller.Create(absen);
                if (result > 0)
                {
                    LoadDataAbsen();
                    txt_search.Clear();
                }
            }

        }

        private void lbl_hapus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvwAbsen.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah daftar ini ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Model.Entity.Absensi absen = listOfAbsensi[lvwAbsen.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(absen);
                    if (result > 0) LoadDataAbsen();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Daftar belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Cari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Cari.Text))
            {
                LoadDataAbsen();
            }
            else
            {
                lvwAbsen.Items.Clear();
                listOfAbsensi = controller.ReadByNama(txt_Cari.Text);
                foreach (var absen in listOfAbsensi)
                {
                    var itm = new ListViewItem();
                    itm.SubItems.Add("K-00" + absen.Id_karyawan.ToString());
                    itm.SubItems.Add(absen.Nm_krywn);
                    itm.SubItems.Add(absen.Tanggal.ToLongDateString());
                    itm.SubItems.Add(absen.Jam_masuk.ToShortTimeString());
                    lvwAbsen.Items.Add(itm);
                }
            }
        }

        private void Absensi_Load(object sender, EventArgs e)
        {

        }
    }
}
