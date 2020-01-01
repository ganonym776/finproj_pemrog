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
    public class JabatanController
    {
        private JabatanRepository _repository;

        public int Create(Jabatan jbt)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong

            if (string.IsNullOrEmpty(jbt.Nm_jbt) || string.IsNullOrEmpty(jbt.Gaji_jbt.ToString()) || string.IsNullOrEmpty(jbt.Tunj_jbt.ToString()) || string.IsNullOrEmpty(jbt.Uang_transport.ToString()))
            {
                MessageBox.Show("Semua kolom harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new JabatanRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(jbt);
            }

            if (result > 0)
            {
                MessageBox.Show("Jabatan berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Jabatan gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Jabatan jbt)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(jbt.Nm_jbt) || string.IsNullOrEmpty(jbt.Gaji_jbt.ToString()) || string.IsNullOrEmpty(jbt.Tunj_jbt.ToString()) || string.IsNullOrEmpty(jbt.Uang_transport.ToString()))
            {
                MessageBox.Show("Semua kolom harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new JabatanRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.update(jbt);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Jabatan berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Jabatan gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Jabatan jbt)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(jbt.Kd_jbt.ToString()))
            {
                MessageBox.Show("Tuliskan KODE Jabatan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new JabatanRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.delete(jbt);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Jabatan berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Jabatan gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public List<Jabatan> ReadJbt()
        {
            List<Jabatan> list = new List<Jabatan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new JabatanRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadJbt();
            }

            return list;
        }
    }
}
