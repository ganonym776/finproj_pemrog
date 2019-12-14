namespace finproj
{
    partial class loginform
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
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.login_header = new System.Windows.Forms.Panel();
            this.lb_login = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_username = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_password = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.login_header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // login_header
            // 
            this.login_header.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_header.Controls.Add(this.lb_login);
            this.login_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_header.Location = new System.Drawing.Point(0, 0);
            this.login_header.Name = "login_header";
            this.login_header.Size = new System.Drawing.Size(269, 89);
            this.login_header.TabIndex = 0;
            this.login_header.Click += new System.EventHandler(this.btn_login_Click_1);
            this.login_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.BackColor = System.Drawing.Color.Transparent;
            this.lb_login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.White;
            this.lb_login.Location = new System.Drawing.Point(98, 30);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(78, 24);
            this.lb_login.TabIndex = 7;
            this.lb_login.Text = "LOGIN";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.login_header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 259);
            this.panel1.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.AcceptsReturn = false;
            this.txt_username.AcceptsTab = false;
            this.txt_username.AnimationSpeed = 200;
            this.txt_username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_username.BackgroundImage")));
            this.txt_username.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_username.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_username.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_username.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_username.BorderRadius = 1;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.BorderThickness = 1;
            this.txt_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_username.DefaultText = "";
            this.txt_username.FillColor = System.Drawing.Color.White;
            this.txt_username.HideSelection = true;
            this.txt_username.IconLeft = null;
            this.txt_username.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.IconPadding = 10;
            this.txt_username.IconRight = null;
            this.txt_username.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Lines = new string[0];
            this.txt_username.Location = new System.Drawing.Point(34, 47);
            this.txt_username.MaxLength = 32767;
            this.txt_username.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_username.Modified = false;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_username.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnIdleState = stateProperties4;
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_username.PlaceholderText = "Username";
            this.txt_username.ReadOnly = false;
            this.txt_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.ShortcutsEnabled = true;
            this.txt_username.Size = new System.Drawing.Size(200, 35);
            this.txt_username.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_username.TabIndex = 7;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.TextMarginBottom = 0;
            this.txt_username.TextMarginLeft = 5;
            this.txt_username.TextMarginTop = 0;
            this.txt_username.TextPlaceholder = "Username";
            this.txt_username.UseSystemPasswordChar = false;
            this.txt_username.WordWrap = true;
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 20;
            this.btn_login.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_login.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_login.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 20;
            this.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_login.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_login.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_login.Location = new System.Drawing.Point(143, 175);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(91, 37);
            this.btn_login.TabIndex = 9;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.AcceptsReturn = false;
            this.txt_password.AcceptsTab = false;
            this.txt_password.AnimationSpeed = 200;
            this.txt_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_password.BackgroundImage")));
            this.txt_password.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_password.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_password.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_password.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_password.BorderRadius = 1;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.BorderThickness = 1;
            this.txt_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_password.DefaultText = "";
            this.txt_password.FillColor = System.Drawing.Color.White;
            this.txt_password.HideSelection = true;
            this.txt_password.IconLeft = null;
            this.txt_password.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.IconPadding = 10;
            this.txt_password.IconRight = null;
            this.txt_password.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(34, 111);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_password.Modified = false;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_password.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnIdleState = stateProperties8;
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.ReadOnly = false;
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(200, 35);
            this.txt_password.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_password.TabIndex = 8;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TextMarginBottom = 0;
            this.txt_password.TextMarginLeft = 5;
            this.txt_password.TextMarginTop = 0;
            this.txt_password.TextPlaceholder = "Password";
            this.txt_password.UseSystemPasswordChar = false;
            this.txt_password.WordWrap = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveBorderThickness = 1;
            this.btn_cancel.ActiveCornerRadius = 20;
            this.btn_cancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_cancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.ButtonText = "Cancel";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.IdleBorderThickness = 1;
            this.btn_cancel.IdleCornerRadius = 20;
            this.btn_cancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cancel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.Location = new System.Drawing.Point(34, 175);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 37);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(269, 348);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.login_header.ResumeLayout(false);
            this.login_header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel login_header;
        private System.Windows.Forms.Label lb_login;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_username;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_password;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancel;
    }
}