using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using finproj.Model.Entity;
using finproj.Model.Repository;
using finproj.Model.Context;
using System.Windows.Forms;

namespace finproj.Controller
{
    public class PegawaiController
    {
        private PegawaiRepository _repository;
        /// <param name="nama"></param>
        public List<Pegawai> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Pegawai> list = new List<Pegawai>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PegawaiRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }

        public List<Pegawai> ReadAll()
        {
            // membuat objek collection
            List<Pegawai> list = new List<Pegawai>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PegawaiRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Pegawai krywn)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong

            if (string.IsNullOrEmpty(krywn.Nik) || string.IsNullOrEmpty(krywn.NamaKrywn) || string.IsNullOrEmpty(krywn.Gender) || string.IsNullOrEmpty(krywn.Goldar) || string.IsNullOrEmpty(krywn.Agama) || string.IsNullOrEmpty(krywn.Alamat) || string.IsNullOrEmpty(krywn.Telp) || string.IsNullOrEmpty(krywn.TmptLahir) || string.IsNullOrEmpty(krywn.TglLahir.ToString()) || string.IsNullOrEmpty(krywn.Status) || string.IsNullOrEmpty(krywn.KodeJbt.ToString()) || string.IsNullOrEmpty(krywn.PnddkanAkhir))
            {
                MessageBox.Show("Semua kolom harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PegawaiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(krywn);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pegawai berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pegawai gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Pegawai krywn)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(krywn.Nik) || string.IsNullOrEmpty(krywn.NamaKrywn) || string.IsNullOrEmpty(krywn.Gender) || string.IsNullOrEmpty(krywn.Goldar) || string.IsNullOrEmpty(krywn.Agama) || string.IsNullOrEmpty(krywn.Alamat) || string.IsNullOrEmpty(krywn.Telp) || string.IsNullOrEmpty(krywn.TmptLahir) || string.IsNullOrEmpty(krywn.TglLahir.ToString()) || string.IsNullOrEmpty(krywn.Status) || string.IsNullOrEmpty(krywn.KodeJbt.ToString()) || string.IsNullOrEmpty(krywn.PnddkanAkhir))
            {
                MessageBox.Show("Semua kolom harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PegawaiRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(krywn);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pegawai berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pegawai gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Pegawai krywn)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(krywn.IdKrywn.ToString()))
            {
                MessageBox.Show("Tuliskan ID Karyawan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PegawaiRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(krywn);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pegawai berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pegawai gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
