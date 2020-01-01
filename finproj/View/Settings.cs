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
using finproj.Model.Entity;

namespace finproj.View
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //button ganti password
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Panel_Jbt.Show();
            Panel_Pass.Hide();
        }

        private void rbt_Pass_Click(object sender, EventArgs e)
        {
            Panel_Jbt.Hide();
            Panel_Pass.Show();
        }

        private void rbt_Jbt_Click(object sender, EventArgs e)
        {
            Panel_Jbt.Show();
            Panel_Pass.Hide();
        }

        private void btn_UbahJbt_Click(object sender, EventArgs e)
        {
            JabatanController controller;
            controller = new JabatanController();
            Jabatan jbt = new Jabatan();
            jbt.Nm_jbt = txt_NmJbt.ToString();
            jbt.Gaji_jbt = Convert.ToInt32(txt_GajiJbt.Text.ToString());
            jbt.Tunj_jbt = Convert.ToInt32(txt_TunjJbt.Text.ToString());
            jbt.Uang_transport = Convert.ToInt32(txt_TransportJbt.Text.ToString());
            int result = 0;
            result = controller.Create(jbt);
            if (result > 0)
            {
                txt_NmJbt.Clear();
                txt_GajiJbt.Clear();
                txt_TunjJbt.Clear();
                txt_TransportJbt.Clear();

            }
        }

        private void btn_BatalJbt_Click(object sender, EventArgs e)
        {
            Panel_Jbt.Hide();
        }

        private void btn_BatalPassword_Click(object sender, EventArgs e)
        {
            Panel_Pass.Hide();
        }
    }
}
