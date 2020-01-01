namespace finproj.View
{
    partial class Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbt_Jbt = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rbt_Pass = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Panel_Pass = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.btn_UbahPassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_BatalPassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ReNew = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_New = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_Old = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel_Jbt = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.txt_NmJbt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_GajiJbt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_TunjJbt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_TransportJbt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_BatalJbt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_UbahJbt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel_Pass.SuspendLayout();
            this.Panel_Jbt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // rbt_Jbt
            // 
            this.rbt_Jbt.BorderThickness = 1;
            this.rbt_Jbt.Checked = false;
            this.rbt_Jbt.Location = new System.Drawing.Point(41, 108);
            this.rbt_Jbt.Name = "rbt_Jbt";
            this.rbt_Jbt.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rbt_Jbt.OutlineColorUnchecked = System.Drawing.Color.Gray;
            this.rbt_Jbt.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rbt_Jbt.Size = new System.Drawing.Size(21, 21);
            this.rbt_Jbt.TabIndex = 1;
            this.rbt_Jbt.Text = null;
            this.rbt_Jbt.Click += new System.EventHandler(this.rbt_Jbt_Click);
            // 
            // rbt_Pass
            // 
            this.rbt_Pass.BorderThickness = 1;
            this.rbt_Pass.Checked = true;
            this.rbt_Pass.Location = new System.Drawing.Point(245, 108);
            this.rbt_Pass.Name = "rbt_Pass";
            this.rbt_Pass.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rbt_Pass.OutlineColorUnchecked = System.Drawing.Color.Gray;
            this.rbt_Pass.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rbt_Pass.Size = new System.Drawing.Size(21, 21);
            this.rbt_Pass.TabIndex = 2;
            this.rbt_Pass.Text = null;
            this.rbt_Pass.Click += new System.EventHandler(this.rbt_Pass_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(66, 107);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(143, 20);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Tambah Jabatan";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(270, 107);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(134, 20);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Ubah Password";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // Panel_Pass
            // 
            this.Panel_Pass.BorderColor = System.Drawing.Color.Gainsboro;
            this.Panel_Pass.Controls.Add(this.label4);
            this.Panel_Pass.Controls.Add(this.label3);
            this.Panel_Pass.Controls.Add(this.label2);
            this.Panel_Pass.Controls.Add(this.btn_BatalPassword);
            this.Panel_Pass.Controls.Add(this.btn_UbahPassword);
            this.Panel_Pass.Controls.Add(this.btn_ReNew);
            this.Panel_Pass.Controls.Add(this.btn_New);
            this.Panel_Pass.Controls.Add(this.btn_Old);
            this.Panel_Pass.Location = new System.Drawing.Point(41, 149);
            this.Panel_Pass.Name = "Panel_Pass";
            this.Panel_Pass.PanelColor = System.Drawing.Color.Empty;
            this.Panel_Pass.ShadowDept = 2;
            this.Panel_Pass.ShadowTopLeftVisible = false;
            this.Panel_Pass.Size = new System.Drawing.Size(594, 298);
            this.Panel_Pass.TabIndex = 5;
            // 
            // btn_UbahPassword
            // 
            this.btn_UbahPassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_UbahPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_UbahPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UbahPassword.BorderRadius = 0;
            this.btn_UbahPassword.ButtonText = "Ubah Password";
            this.btn_UbahPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UbahPassword.DisabledColor = System.Drawing.Color.Gray;
            this.btn_UbahPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UbahPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_UbahPassword.Iconimage = null;
            this.btn_UbahPassword.Iconimage_right = null;
            this.btn_UbahPassword.Iconimage_right_Selected = null;
            this.btn_UbahPassword.Iconimage_Selected = null;
            this.btn_UbahPassword.IconMarginLeft = 0;
            this.btn_UbahPassword.IconMarginRight = 0;
            this.btn_UbahPassword.IconRightVisible = true;
            this.btn_UbahPassword.IconRightZoom = 0D;
            this.btn_UbahPassword.IconVisible = true;
            this.btn_UbahPassword.IconZoom = 90D;
            this.btn_UbahPassword.IsTab = false;
            this.btn_UbahPassword.Location = new System.Drawing.Point(359, 191);
            this.btn_UbahPassword.Name = "btn_UbahPassword";
            this.btn_UbahPassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_UbahPassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_UbahPassword.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_UbahPassword.selected = false;
            this.btn_UbahPassword.Size = new System.Drawing.Size(107, 31);
            this.btn_UbahPassword.TabIndex = 3;
            this.btn_UbahPassword.Text = "Ubah Password";
            this.btn_UbahPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_UbahPassword.Textcolor = System.Drawing.Color.White;
            this.btn_UbahPassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UbahPassword.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_BatalPassword
            // 
            this.btn_BatalPassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_BatalPassword.BackColor = System.Drawing.Color.Red;
            this.btn_BatalPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BatalPassword.BorderRadius = 0;
            this.btn_BatalPassword.ButtonText = "Batal";
            this.btn_BatalPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BatalPassword.DisabledColor = System.Drawing.Color.Gray;
            this.btn_BatalPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BatalPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_BatalPassword.Iconimage = null;
            this.btn_BatalPassword.Iconimage_right = null;
            this.btn_BatalPassword.Iconimage_right_Selected = null;
            this.btn_BatalPassword.Iconimage_Selected = null;
            this.btn_BatalPassword.IconMarginLeft = 0;
            this.btn_BatalPassword.IconMarginRight = 0;
            this.btn_BatalPassword.IconRightVisible = true;
            this.btn_BatalPassword.IconRightZoom = 0D;
            this.btn_BatalPassword.IconVisible = true;
            this.btn_BatalPassword.IconZoom = 90D;
            this.btn_BatalPassword.IsTab = false;
            this.btn_BatalPassword.Location = new System.Drawing.Point(472, 191);
            this.btn_BatalPassword.Name = "btn_BatalPassword";
            this.btn_BatalPassword.Normalcolor = System.Drawing.Color.Red;
            this.btn_BatalPassword.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_BatalPassword.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_BatalPassword.selected = false;
            this.btn_BatalPassword.Size = new System.Drawing.Size(53, 31);
            this.btn_BatalPassword.TabIndex = 4;
            this.btn_BatalPassword.Text = "Batal";
            this.btn_BatalPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_BatalPassword.Textcolor = System.Drawing.Color.Yellow;
            this.btn_BatalPassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BatalPassword.Click += new System.EventHandler(this.btn_BatalPassword_Click);
            // 
            // btn_ReNew
            // 
            this.btn_ReNew.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_ReNew.Location = new System.Drawing.Point(263, 135);
            this.btn_ReNew.Name = "btn_ReNew";
            this.btn_ReNew.Size = new System.Drawing.Size(162, 20);
            this.btn_ReNew.TabIndex = 2;
            // 
            // btn_New
            // 
            this.btn_New.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_New.Location = new System.Drawing.Point(263, 89);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(162, 20);
            this.btn_New.TabIndex = 1;
            // 
            // btn_Old
            // 
            this.btn_Old.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_Old.Location = new System.Drawing.Point(263, 43);
            this.btn_Old.Name = "btn_Old";
            this.btn_Old.Size = new System.Drawing.Size(162, 20);
            this.btn_Old.TabIndex = 0;
            this.btn_Old.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(43, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Masukkan password lama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(43, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Masukkan password baru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(43, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Re-Type password baru";
            // 
            // Panel_Jbt
            // 
            this.Panel_Jbt.BorderColor = System.Drawing.Color.Gainsboro;
            this.Panel_Jbt.Controls.Add(this.btn_BatalJbt);
            this.Panel_Jbt.Controls.Add(this.btn_UbahJbt);
            this.Panel_Jbt.Controls.Add(this.label8);
            this.Panel_Jbt.Controls.Add(this.label7);
            this.Panel_Jbt.Controls.Add(this.label6);
            this.Panel_Jbt.Controls.Add(this.label5);
            this.Panel_Jbt.Controls.Add(this.txt_TransportJbt);
            this.Panel_Jbt.Controls.Add(this.txt_TunjJbt);
            this.Panel_Jbt.Controls.Add(this.txt_GajiJbt);
            this.Panel_Jbt.Controls.Add(this.txt_NmJbt);
            this.Panel_Jbt.Location = new System.Drawing.Point(41, 149);
            this.Panel_Jbt.Name = "Panel_Jbt";
            this.Panel_Jbt.PanelColor = System.Drawing.Color.Empty;
            this.Panel_Jbt.ShadowDept = 2;
            this.Panel_Jbt.ShadowTopLeftVisible = false;
            this.Panel_Jbt.Size = new System.Drawing.Size(594, 298);
            this.Panel_Jbt.TabIndex = 6;
            // 
            // txt_NmJbt
            // 
            this.txt_NmJbt.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_NmJbt.Location = new System.Drawing.Point(172, 29);
            this.txt_NmJbt.Name = "txt_NmJbt";
            this.txt_NmJbt.Size = new System.Drawing.Size(206, 20);
            this.txt_NmJbt.TabIndex = 0;
            // 
            // txt_GajiJbt
            // 
            this.txt_GajiJbt.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_GajiJbt.Location = new System.Drawing.Point(288, 78);
            this.txt_GajiJbt.Name = "txt_GajiJbt";
            this.txt_GajiJbt.Size = new System.Drawing.Size(148, 20);
            this.txt_GajiJbt.TabIndex = 1;
            this.txt_GajiJbt.Text = "0";
            this.txt_GajiJbt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TunjJbt
            // 
            this.txt_TunjJbt.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_TunjJbt.Location = new System.Drawing.Point(288, 124);
            this.txt_TunjJbt.Name = "txt_TunjJbt";
            this.txt_TunjJbt.Size = new System.Drawing.Size(148, 20);
            this.txt_TunjJbt.TabIndex = 2;
            this.txt_TunjJbt.Text = "0";
            this.txt_TunjJbt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TransportJbt
            // 
            this.txt_TransportJbt.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_TransportJbt.Location = new System.Drawing.Point(288, 170);
            this.txt_TransportJbt.Name = "txt_TransportJbt";
            this.txt_TransportJbt.Size = new System.Drawing.Size(148, 20);
            this.txt_TransportJbt.TabIndex = 3;
            this.txt_TransportJbt.Text = "0";
            this.txt_TransportJbt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(36, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nama Jabatan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(138, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gaji Pokok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(138, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tunjangan Jabatan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(138, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Uang Transport";
            // 
            // btn_BatalJbt
            // 
            this.btn_BatalJbt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_BatalJbt.BackColor = System.Drawing.Color.Red;
            this.btn_BatalJbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BatalJbt.BorderRadius = 0;
            this.btn_BatalJbt.ButtonText = "Batal";
            this.btn_BatalJbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BatalJbt.DisabledColor = System.Drawing.Color.Gray;
            this.btn_BatalJbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BatalJbt.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_BatalJbt.Iconimage = null;
            this.btn_BatalJbt.Iconimage_right = null;
            this.btn_BatalJbt.Iconimage_right_Selected = null;
            this.btn_BatalJbt.Iconimage_Selected = null;
            this.btn_BatalJbt.IconMarginLeft = 0;
            this.btn_BatalJbt.IconMarginRight = 0;
            this.btn_BatalJbt.IconRightVisible = true;
            this.btn_BatalJbt.IconRightZoom = 0D;
            this.btn_BatalJbt.IconVisible = true;
            this.btn_BatalJbt.IconZoom = 90D;
            this.btn_BatalJbt.IsTab = false;
            this.btn_BatalJbt.Location = new System.Drawing.Point(472, 203);
            this.btn_BatalJbt.Name = "btn_BatalJbt";
            this.btn_BatalJbt.Normalcolor = System.Drawing.Color.Red;
            this.btn_BatalJbt.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_BatalJbt.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_BatalJbt.selected = false;
            this.btn_BatalJbt.Size = new System.Drawing.Size(53, 31);
            this.btn_BatalJbt.TabIndex = 9;
            this.btn_BatalJbt.Text = "Batal";
            this.btn_BatalJbt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_BatalJbt.Textcolor = System.Drawing.Color.Yellow;
            this.btn_BatalJbt.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BatalJbt.Click += new System.EventHandler(this.btn_BatalJbt_Click);
            // 
            // btn_UbahJbt
            // 
            this.btn_UbahJbt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_UbahJbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_UbahJbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UbahJbt.BorderRadius = 0;
            this.btn_UbahJbt.ButtonText = "Tambahkan";
            this.btn_UbahJbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UbahJbt.DisabledColor = System.Drawing.Color.Gray;
            this.btn_UbahJbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UbahJbt.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_UbahJbt.Iconimage = null;
            this.btn_UbahJbt.Iconimage_right = null;
            this.btn_UbahJbt.Iconimage_right_Selected = null;
            this.btn_UbahJbt.Iconimage_Selected = null;
            this.btn_UbahJbt.IconMarginLeft = 0;
            this.btn_UbahJbt.IconMarginRight = 0;
            this.btn_UbahJbt.IconRightVisible = true;
            this.btn_UbahJbt.IconRightZoom = 0D;
            this.btn_UbahJbt.IconVisible = true;
            this.btn_UbahJbt.IconZoom = 90D;
            this.btn_UbahJbt.IsTab = false;
            this.btn_UbahJbt.Location = new System.Drawing.Point(359, 203);
            this.btn_UbahJbt.Name = "btn_UbahJbt";
            this.btn_UbahJbt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_UbahJbt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_UbahJbt.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_UbahJbt.selected = false;
            this.btn_UbahJbt.Size = new System.Drawing.Size(107, 31);
            this.btn_UbahJbt.TabIndex = 8;
            this.btn_UbahJbt.Text = "Tambahkan";
            this.btn_UbahJbt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_UbahJbt.Textcolor = System.Drawing.Color.White;
            this.btn_UbahJbt.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UbahJbt.Click += new System.EventHandler(this.btn_UbahJbt_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.Panel_Jbt);
            this.Controls.Add(this.Panel_Pass);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.rbt_Pass);
            this.Controls.Add(this.rbt_Jbt);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(678, 513);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Panel_Pass.ResumeLayout(false);
            this.Panel_Pass.PerformLayout();
            this.Panel_Jbt.ResumeLayout(false);
            this.Panel_Jbt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuRadioButton rbt_Jbt;
        private Bunifu.UI.WinForms.BunifuRadioButton rbt_Pass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel Panel_Pass;
        private Bunifu.Framework.UI.BunifuFlatButton btn_UbahPassword;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel Panel_Jbt;
        private Bunifu.Framework.UI.BunifuFlatButton btn_BatalJbt;
        private Bunifu.Framework.UI.BunifuFlatButton btn_UbahJbt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_TransportJbt;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_TunjJbt;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_GajiJbt;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_NmJbt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_BatalPassword;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox btn_ReNew;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox btn_New;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox btn_Old;
    }
}
