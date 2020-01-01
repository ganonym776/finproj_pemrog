using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using finproj.Model.Entity;
using finproj.Model.Repository;
using finproj.Model.Context;

namespace finproj.Controller
{
    public class GajiController
    {
        private GajiRepository _repository;
        /// <param name="nama"></param>
        public List<Gaji> ReadAll()
        {
            // membuat objek collection
            List<Gaji> list = new List<Gaji>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new GajiRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadHistory();
            }

            return list;
        }

        public int Create(Gaji gaji)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong

            if (string.IsNullOrEmpty(gaji.Id_karyawan.ToString()) || string.IsNullOrEmpty(gaji.Bonus.ToString())) 
            {
                MessageBox.Show("Semua kolom harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new GajiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(gaji);
            }

            if (result > 0)
            {
                MessageBox.Show("Data penggajian berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data penggajian gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Gaji gaji)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(gaji.Id_penggajian.ToString()))
            {
                MessageBox.Show("Tuliskan ID Penggajian !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new GajiRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.delete(gaji);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Penggajian berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Penggajian gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int ReadRiwayatGaji(int gaji)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new GajiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.ReadRiwayatGaji(gaji);
            }
            return result;

        }

        public int HitungLembur(int id)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new GajiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.HitungLembur(id);
            }
            return result;

        }

        public List<Gaji> ReadByNameOrId(string nama)
        {
            List<Gaji> list = new List<Gaji>();
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new GajiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                list = _repository.ReadByNameOrId(nama);
            }
            return list;
        }

        public List<Gaji> ReadByID(int ID)
        {
            List<Gaji> list = new List<Gaji>();
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new GajiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                list = _repository.ReadByID(ID);
            }
            return list;
        }
    }
}
