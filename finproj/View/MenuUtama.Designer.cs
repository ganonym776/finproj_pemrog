namespace finproj
{
    partial class MenuUtama
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            this.formutama = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_gaji = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_lembur = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_absensi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_krywn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Penggajian = new finproj.Penggajian();
            this.Lembur = new finproj.Lembur();
            this.Karyawan = new finproj.Karyawan();
            this.Home = new finproj.Home();
            this.Absensi = new finproj.Absensi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formutama
            // 
            this.formutama.ElipseRadius = 5;
            this.formutama.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_gaji);
            this.panel1.Controls.Add(this.btn_lembur);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_absensi);
            this.panel1.Controls.Add(this.btn_krywn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 513);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_logout
            // 
            this.btn_logout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_logout.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.BorderRadius = 0;
            this.btn_logout.ButtonText = "Logout";
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.DisabledColor = System.Drawing.Color.Gray;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_logout.Iconimage")));
            this.btn_logout.Iconimage_right = null;
            this.btn_logout.Iconimage_right_Selected = null;
            this.btn_logout.Iconimage_Selected = null;
            this.btn_logout.IconMarginLeft = 0;
            this.btn_logout.IconMarginRight = 0;
            this.btn_logout.IconRightVisible = true;
            this.btn_logout.IconRightZoom = 0D;
            this.btn_logout.IconVisible = true;
            this.btn_logout.IconZoom = 90D;
            this.btn_logout.IsTab = false;
            this.btn_logout.Location = new System.Drawing.Point(3, 433);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btn_logout.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_logout.selected = false;
            this.btn_logout.Size = new System.Drawing.Size(200, 34);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Textcolor = System.Drawing.Color.White;
            this.btn_logout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // btn_gaji
            // 
            this.btn_gaji.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_gaji.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btn_gaji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_gaji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_gaji.BorderRadius = 0;
            this.btn_gaji.ButtonText = "Penggajian";
            this.btn_gaji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gaji.DisabledColor = System.Drawing.Color.Gray;
            this.btn_gaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gaji.ForeColor = System.Drawing.Color.White;
            this.btn_gaji.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_gaji.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_gaji.Iconimage")));
            this.btn_gaji.Iconimage_right = null;
            this.btn_gaji.Iconimage_right_Selected = null;
            this.btn_gaji.Iconimage_Selected = null;
            this.btn_gaji.IconMarginLeft = 0;
            this.btn_gaji.IconMarginRight = 0;
            this.btn_gaji.IconRightVisible = true;
            this.btn_gaji.IconRightZoom = 0D;
            this.btn_gaji.IconVisible = true;
            this.btn_gaji.IconZoom = 90D;
            this.btn_gaji.IsTab = false;
            this.btn_gaji.Location = new System.Drawing.Point(3, 389);
            this.btn_gaji.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_gaji.Name = "btn_gaji";
            this.btn_gaji.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_gaji.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btn_gaji.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_gaji.selected = false;
            this.btn_gaji.Size = new System.Drawing.Size(200, 34);
            this.btn_gaji.TabIndex = 7;
            this.btn_gaji.Text = "Penggajian";
            this.btn_gaji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gaji.Textcolor = System.Drawing.Color.White;
            this.btn_gaji.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gaji.Click += new System.EventHandler(this.btn_gaji_Click);
            // 
            // btn_lembur
            // 
            this.btn_lembur.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_lembur.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btn_lembur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_lembur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lembur.BorderRadius = 0;
            this.btn_lembur.ButtonText = "Lembur";
            this.btn_lembur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lembur.DisabledColor = System.Drawing.Color.Gray;
            this.btn_lembur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lembur.ForeColor = System.Drawing.Color.White;
            this.btn_lembur.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_lembur.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_lembur.Iconimage")));
            this.btn_lembur.Iconimage_right = null;
            this.btn_lembur.Iconimage_right_Selected = null;
            this.btn_lembur.Iconimage_Selected = null;
            this.btn_lembur.IconMarginLeft = 0;
            this.btn_lembur.IconMarginRight = 0;
            this.btn_lembur.IconRightVisible = true;
            this.btn_lembur.IconRightZoom = 0D;
            this.btn_lembur.IconVisible = true;
            this.btn_lembur.IconZoom = 90D;
            this.btn_lembur.IsTab = false;
            this.btn_lembur.Location = new System.Drawing.Point(3, 344);
            this.btn_lembur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_lembur.Name = "btn_lembur";
            this.btn_lembur.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_lembur.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btn_lembur.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_lembur.selected = false;
            this.btn_lembur.Size = new System.Drawing.Size(200, 34);
            this.btn_lembur.TabIndex = 6;
            this.btn_lembur.Text = "Lembur";
            this.btn_lembur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lembur.Textcolor = System.Drawing.Color.White;
            this.btn_lembur.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lembur.Click += new System.EventHandler(this.btn_lembur_Click);
            // 
            // btn_home
            // 
            this.btn_home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_home.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.BorderRadius = 0;
            this.btn_home.ButtonText = "Home";
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.DisabledColor = System.Drawing.Color.Gray;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_home.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_home.Iconimage")));
            this.btn_home.Iconimage_right = null;
            this.btn_home.Iconimage_right_Selected = null;
            this.btn_home.Iconimage_Selected = null;
            this.btn_home.IconMarginLeft = 0;
            this.btn_home.IconMarginRight = 0;
            this.btn_home.IconRightVisible = true;
            this.btn_home.IconRightZoom = 0D;
            this.btn_home.IconVisible = true;
            this.btn_home.IconZoom = 90D;
            this.btn_home.IsTab = false;
            this.btn_home.Location = new System.Drawing.Point(3, 208);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btn_home.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_home.selected = false;
            this.btn_home.Size = new System.Drawing.Size(200, 35);
            this.btn_home.TabIndex = 5;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Textcolor = System.Drawing.Color.White;
            this.btn_home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_absensi
            // 
            this.btn_absensi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_absensi.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btn_absensi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_absensi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_absensi.BorderRadius = 0;
            this.btn_absensi.ButtonText = "Absensi";
            this.btn_absensi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_absensi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_absensi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_absensi.ForeColor = System.Drawing.Color.White;
            this.btn_absensi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_absensi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_absensi.Iconimage")));
            this.btn_absensi.Iconimage_right = null;
            this.btn_absensi.Iconimage_right_Selected = null;
            this.btn_absensi.Iconimage_Selected = null;
            this.btn_absensi.IconMarginLeft = 0;
            this.btn_absensi.IconMarginRight = 0;
            this.btn_absensi.IconRightVisible = true;
            this.btn_absensi.IconRightZoom = 0D;
            this.btn_absensi.IconVisible = true;
            this.btn_absensi.IconZoom = 90D;
            this.btn_absensi.IsTab = false;
            this.btn_absensi.Location = new System.Drawing.Point(3, 299);
            this.btn_absensi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_absensi.Name = "btn_absensi";
            this.btn_absensi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_absensi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btn_absensi.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_absensi.selected = false;
            this.btn_absensi.Size = new System.Drawing.Size(200, 34);
            this.btn_absensi.TabIndex = 4;
            this.btn_absensi.Text = "Absensi";
            this.btn_absensi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_absensi.Textcolor = System.Drawing.Color.White;
            this.btn_absensi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_absensi.Click += new System.EventHandler(this.btn_absensi_Click);
            // 
            // btn_krywn
            // 
            this.btn_krywn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_krywn.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btn_krywn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_krywn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_krywn.BorderRadius = 0;
            this.btn_krywn.ButtonText = "Data Karyawan";
            this.btn_krywn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_krywn.DisabledColor = System.Drawing.Color.Gray;
            this.btn_krywn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_krywn.ForeColor = System.Drawing.Color.White;
            this.btn_krywn.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_krywn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_krywn.Iconimage")));
            this.btn_krywn.Iconimage_right = null;
            this.btn_krywn.Iconimage_right_Selected = null;
            this.btn_krywn.Iconimage_Selected = null;
            this.btn_krywn.IconMarginLeft = 0;
            this.btn_krywn.IconMarginRight = 0;
            this.btn_krywn.IconRightVisible = true;
            this.btn_krywn.IconRightZoom = 0D;
            this.btn_krywn.IconVisible = true;
            this.btn_krywn.IconZoom = 90D;
            this.btn_krywn.IsTab = false;
            this.btn_krywn.Location = new System.Drawing.Point(3, 253);
            this.btn_krywn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_krywn.Name = "btn_krywn";
            this.btn_krywn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_krywn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btn_krywn.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_krywn.selected = false;
            this.btn_krywn.Size = new System.Drawing.Size(200, 34);
            this.btn_krywn.TabIndex = 3;
            this.btn_krywn.Text = "Data Karyawan";
            this.btn_krywn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_krywn.Textcolor = System.Drawing.Color.White;
            this.btn_krywn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_krywn.Click += new System.EventHandler(this.btn_krywn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(110)))), ((int)(((byte)(239)))));
            this.Header.Controls.Add(this.bunifuImageButton4);
            this.Header.Controls.Add(this.bunifuImageButton3);
            this.Header.Controls.Add(this.label1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(875, 37);
            this.Header.TabIndex = 1;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(110)))), ((int)(((byte)(239)))));
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(838, 6);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 5;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 20;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(110)))), ((int)(((byte)(239)))));
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(806, 6);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 4;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistem Penggajian Karyawan";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Penggajian);
            this.panel2.Controls.Add(this.Lembur);
            this.panel2.Controls.Add(this.Karyawan);
            this.panel2.Controls.Add(this.Home);
            this.panel2.Controls.Add(this.Absensi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(197, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 513);
            this.panel2.TabIndex = 2;
            // 
            // Penggajian
            // 
            this.Penggajian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Penggajian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Penggajian.Location = new System.Drawing.Point(0, 0);
            this.Penggajian.Name = "Penggajian";
            this.Penggajian.Size = new System.Drawing.Size(678, 513);
            this.Penggajian.TabIndex = 4;
            this.Penggajian.Visible = false;
            // 
            // Lembur
            // 
            this.Lembur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lembur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lembur.Location = new System.Drawing.Point(0, 0);
            this.Lembur.Name = "Lembur";
            this.Lembur.Size = new System.Drawing.Size(678, 513);
            this.Lembur.TabIndex = 3;
            this.Lembur.Visible = false;
            // 
            // Karyawan
            // 
            this.Karyawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Karyawan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Karyawan.Enabled = false;
            this.Karyawan.Location = new System.Drawing.Point(0, 0);
            this.Karyawan.Name = "Karyawan";
            this.Karyawan.Size = new System.Drawing.Size(678, 513);
            this.Karyawan.TabIndex = 2;
            this.Karyawan.Visible = false;
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(678, 513);
            this.Home.TabIndex = 1;
            this.Home.Visible = false;
            this.Home.Load += new System.EventHandler(this.home_Load);
            // 
            // Absensi
            // 
            this.Absensi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Absensi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Absensi.Location = new System.Drawing.Point(0, 0);
            this.Absensi.Name = "Absensi";
            this.Absensi.Size = new System.Drawing.Size(678, 513);
            this.Absensi.TabIndex = 0;
            this.Absensi.Visible = false;
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(875, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuUtama";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse formutama;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_logout;
        private Bunifu.Framework.UI.BunifuFlatButton btn_gaji;
        private Bunifu.Framework.UI.BunifuFlatButton btn_lembur;
        private Bunifu.Framework.UI.BunifuFlatButton btn_home;
        private Bunifu.Framework.UI.BunifuFlatButton btn_absensi;
        private Bunifu.Framework.UI.BunifuFlatButton btn_krywn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private Karyawan karyawan1;
        private Absensi absensi1;
        private Penggajian penggajian1;
        private Lembur lembur1;
        private Home Home;
        private Absensi Absensi;
        private Penggajian Penggajian;
        private Lembur Lembur;
        private Karyawan Karyawan;
    }
}

