
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
    public class LemburController
    {
        private LemburRepository _repository;

        public List<Model.Entity.Lembur> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Model.Entity.Lembur> list = new List<Model.Entity.Lembur>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new LemburRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByName(nama);
            }

            return list;
        }

        public List<Model.Entity.Lembur> ReadAll()
        {
            // membuat objek collection
            List<Model.Entity.Lembur> list = new List<Model.Entity.Lembur>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new LemburRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Model.Entity.Lembur lembur)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong

            if (string.IsNullOrEmpty(lembur.Id_karyawan.ToString()) || string.IsNullOrEmpty(lembur.Total_jam.ToString()) || string.IsNullOrEmpty(lembur.keterangan))
            {
                MessageBox.Show("Semua kolom harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new LemburRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(lembur);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Lembur berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Lembur gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Model.Entity.Lembur lembur)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(lembur.Id.ToString()))
            {
                MessageBox.Show("Pilih Data Lembur yg akan dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new LemburRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.delete(lembur);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Lembur berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Lembur gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
