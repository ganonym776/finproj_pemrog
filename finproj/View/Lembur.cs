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
    public partial class Lembur : UserControl
    {
        private List<Model.Entity.Lembur> listOfLembur = new List<Model.Entity.Lembur>();
        private LemburController controller;
        public Lembur()
        {
            InitializeComponent();
            controller = new LemburController();
            InisialisasiListView();
            LoadDaftarLembur();
        }

        private void InisialisasiListView()
        {
            lvwLembur.View = System.Windows.Forms.View.Details;
            lvwLembur.Columns.Add(" ", 7, HorizontalAlignment.Center);
            lvwLembur.Columns.Add("ID_Karyawan", 50, HorizontalAlignment.Center);
            lvwLembur.Columns.Add("Nama", 130, HorizontalAlignment.Center);
            lvwLembur.Columns.Add("Waktu", 100, HorizontalAlignment.Center);
            lvwLembur.Columns.Add("Total Jam", 40, HorizontalAlignment.Center);
            lvwLembur.Columns.Add("Keterangan", 150, HorizontalAlignment.Center);
        }

        public void LoadDaftarLembur()
        {
            lvwLembur.Items.Clear();
            listOfLembur = controller.ReadAll();
            foreach(var lmbr in listOfLembur)
            {
                var itm = new ListViewItem();
                itm.SubItems.Add("K-00"+lmbr.Id_karyawan.ToString());
                itm.SubItems.Add(lmbr.Nm_karyawan);
                itm.SubItems.Add(lmbr.Mulai_lembur.ToShortDateString());
                itm.SubItems.Add(lmbr.Total_jam.ToString());
                itm.SubItems.Add(lmbr.keterangan);
                lvwLembur.Items.Add(itm);
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Model.Entity.Lembur lmbr = new Model.Entity.Lembur();
            lmbr.Id_karyawan = Convert.ToInt32(txt_IdKrywn.Text);
            lmbr.Total_jam = Convert.ToInt32(drpd_Waktu.Text);
            lmbr.keterangan = txb_Ktrgn.Text;

            int result = 0;
            result = controller.Create(lmbr);
            if(result > 0)
            {
                LoadDaftarLembur();
                txt_IdKrywn.Clear();
                txb_Ktrgn.Clear();
                drpd_Waktu.Text = "Total Jam";
                txt_IdKrywn.Focus();
            }
        }

        private void btn_Cari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cari.Text))
            {
                LoadDaftarLembur();
            }
            else
            {
                lvwLembur.Items.Clear();
                listOfLembur = controller.ReadByNama(txt_cari.Text);
                foreach (var lmbr in listOfLembur)
                {
                    var itm = new ListViewItem();
                    itm.SubItems.Add("K-00" + lmbr.Id_karyawan.ToString());
                    itm.SubItems.Add(lmbr.Nm_karyawan);
                    itm.SubItems.Add(lmbr.Mulai_lembur.ToShortDateString());
                    itm.SubItems.Add(lmbr.Total_jam.ToString());
                    itm.SubItems.Add(lmbr.keterangan);
                    lvwLembur.Items.Add(itm);
                }
            }
        }

        private void lbl_hapus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvwLembur.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah daftar ini ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Model.Entity.Lembur lmbr = listOfLembur[lvwLembur.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(lmbr);
                    if (result > 0) LoadDaftarLembur();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Daftar belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
