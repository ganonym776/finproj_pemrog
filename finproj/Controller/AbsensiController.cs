
using System.Data.OleDb;
using System.Windows.Forms;
using finproj.Model.Entity;
using finproj.Model.Repository;
using finproj.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finproj.Controller
{
    public class AbsensiController
    {
        private AbsensiRepository _repository;

        public List<Model.Entity.Absensi> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Model.Entity.Absensi> list = new List<Model.Entity.Absensi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new AbsensiRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByName(nama);
            }

            return list;
        }

        public List<Model.Entity.Absensi> ReadAll()
        {
            // membuat objek collection
            List<Model.Entity.Absensi> list = new List<Model.Entity.Absensi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new AbsensiRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Model.Entity.Absensi absen)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong

            if (string.IsNullOrEmpty(absen.Id_karyawan.ToString()))
            {
                MessageBox.Show("Masukkan ID Karyawan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new AbsensiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(absen);
            }

            if (result > 0)
            {
                MessageBox.Show("Karyawan Berhasil absensi !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Karyawn Gagal Presensi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Delete(Model.Entity.Absensi absen)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(absen.Id.ToString()))
            {
                MessageBox.Show("pilih absen atau masukkan Id yg akan dihapus!!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new AbsensiRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.delete(absen);
            }

            if (result > 0)
            {
                MessageBox.Show("penghapusan berhasil !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("penghapusan gagal !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
    }
}
