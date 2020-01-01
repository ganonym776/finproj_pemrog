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
    public partial class FormGaji : UserControl
    {
        private List<Gaji> listOfRiwayatGaji = new List<Gaji>();
        private GajiController controller;
        public FormGaji()
        {
            InitializeComponent();
            controller = new GajiController();
            InisialisasiListView();
            LoadDataRiwayatGaji();
        }

        private void InisialisasiListView()
        {
            lvwGaji.View = System.Windows.Forms.View.Details;
            lvwGaji.Columns.Add(" ", 7, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("Id.", 30, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("Tanggal", 120, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("Nama", 100, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("Jabatan", 80, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("Periode", 30, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("Gaji Pokok", 80, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("Tunjangan", 80, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("Uang Transport", 80, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("Bonus", 80, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("Lembur", 80, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("TOTAL", 80, HorizontalAlignment.Center);
            lvwGaji.Columns.Add("Admin", 80, HorizontalAlignment.Center);
        }

        private void LoadDataRiwayatGaji()
        {
            lvwGaji.Items.Clear();
            listOfRiwayatGaji = controller.ReadAll();

            foreach(var gaji in listOfRiwayatGaji)
            {
                var itm = new ListViewItem();
                itm.SubItems.Add("PRYLL-00" + gaji.Id_penggajian.ToString());
                itm.SubItems.Add(gaji.Tanggal.ToLongDateString());
                itm.SubItems.Add(gaji.Nm_krywn);
                itm.SubItems.Add(gaji.Nm_jbt);
                itm.SubItems.Add((gaji.Period_ke.ToString()) +", "+ (gaji.period_tahun.ToShortDateString()));
                itm.SubItems.Add(gaji.Gaji_pokok.ToString());
                itm.SubItems.Add(gaji.Tunj_jbt.ToString());
                itm.SubItems.Add(gaji.Uang_transport.ToString());
                itm.SubItems.Add(gaji.Bonus.ToString());
                itm.SubItems.Add(gaji.Lembur.ToString());
                itm.SubItems.Add(gaji.Gaji_total.ToString());
                itm.SubItems.Add(gaji.Nm_adm.ToString());
                lvwGaji.Items.Add(itm);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cari_Click(object sender, EventArgs e)
        {
            lvwGaji.Items.Clear();
            listOfRiwayatGaji = controller.ReadByNameOrId(txt_Cari.Text);

            foreach (var gaji in listOfRiwayatGaji)
            {
                var itm = new ListViewItem();
                itm.SubItems.Add("PRYLL-00" + gaji.Id_penggajian.ToString());
                itm.SubItems.Add(gaji.Tanggal.ToLongDateString());
                itm.SubItems.Add(gaji.Nm_krywn);
                itm.SubItems.Add(gaji.Nm_jbt);
                itm.SubItems.Add((gaji.Period_ke.ToString()) + ", " + (gaji.period_tahun.ToShortDateString()));
                itm.SubItems.Add(gaji.Gaji_pokok.ToString());
                itm.SubItems.Add(gaji.Tunj_jbt.ToString());
                itm.SubItems.Add(gaji.Uang_transport.ToString());
                itm.SubItems.Add(gaji.Bonus.ToString());
                itm.SubItems.Add(gaji.Lembur.ToString());
                itm.SubItems.Add(gaji.Gaji_total.ToString());
                itm.SubItems.Add(gaji.Nm_adm.ToString());
                lvwGaji.Items.Add(itm);
            }
        }

        private void lbl_hapus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvwGaji.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Penggajian ini ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Gaji gaji = listOfRiwayatGaji[lvwGaji.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(gaji);
                    if (result > 0) LoadDataRiwayatGaji();
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
