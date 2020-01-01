namespace finproj
{
    partial class FormGaji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGaji));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.lvwGaji = new System.Windows.Forms.ListView();
            this.lbl_hapus = new System.Windows.Forms.LinkLabel();
            this.btn_Cari = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txt_Cari = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwGaji
            // 
            this.lvwGaji.FullRowSelect = true;
            this.lvwGaji.GridLines = true;
            this.lvwGaji.HideSelection = false;
            this.lvwGaji.Location = new System.Drawing.Point(33, 54);
            this.lvwGaji.Name = "lvwGaji";
            this.lvwGaji.Size = new System.Drawing.Size(610, 311);
            this.lvwGaji.TabIndex = 0;
            this.lvwGaji.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_hapus
            // 
            this.lbl_hapus.AutoSize = true;
            this.lbl_hapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hapus.LinkColor = System.Drawing.Color.Red;
            this.lbl_hapus.Location = new System.Drawing.Point(592, 379);
            this.lbl_hapus.Name = "lbl_hapus";
            this.lbl_hapus.Size = new System.Drawing.Size(51, 18);
            this.lbl_hapus.TabIndex = 45;
            this.lbl_hapus.TabStop = true;
            this.lbl_hapus.Text = "Hapus";
            this.lbl_hapus.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.lbl_hapus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_hapus_LinkClicked);
            // 
            // btn_Cari
            // 
            this.btn_Cari.AllowToggling = false;
            this.btn_Cari.AnimationSpeed = 200;
            this.btn_Cari.AutoGenerateColors = false;
            this.btn_Cari.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cari.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cari.BackgroundImage")));
            this.btn_Cari.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btn_Cari.ButtonText = "Cari";
            this.btn_Cari.ButtonTextMarginLeft = 0;
            this.btn_Cari.ColorContrastOnClick = 45;
            this.btn_Cari.ColorContrastOnHover = 45;
            this.btn_Cari.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Cari.CustomizableEdges = borderEdges2;
            this.btn_Cari.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Cari.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_Cari.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cari.DisabledForecolor = System.Drawing.Color.White;
            this.btn_Cari.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Cari.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_Cari.ForeColor = System.Drawing.Color.White;
            this.btn_Cari.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cari.IconMarginLeft = 11;
            this.btn_Cari.IconPadding = 10;
            this.btn_Cari.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cari.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Cari.IdleBorderRadius = 3;
            this.btn_Cari.IdleBorderThickness = 1;
            this.btn_Cari.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cari.IdleIconLeftImage = null;
            this.btn_Cari.IdleIconRightImage = null;
            this.btn_Cari.IndicateFocus = false;
            this.btn_Cari.Location = new System.Drawing.Point(540, 373);
            this.btn_Cari.Name = "btn_Cari";
            this.btn_Cari.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Cari.onHoverState.BorderRadius = 3;
            this.btn_Cari.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Cari.onHoverState.BorderThickness = 1;
            this.btn_Cari.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Cari.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Cari.onHoverState.IconLeftImage = null;
            this.btn_Cari.onHoverState.IconRightImage = null;
            this.btn_Cari.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Cari.OnIdleState.BorderRadius = 3;
            this.btn_Cari.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btn_Cari.OnIdleState.BorderThickness = 1;
            this.btn_Cari.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cari.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Cari.OnIdleState.IconLeftImage = null;
            this.btn_Cari.OnIdleState.IconRightImage = null;
            this.btn_Cari.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Cari.OnPressedState.BorderRadius = 3;
            this.btn_Cari.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Cari.OnPressedState.BorderThickness = 1;
            this.btn_Cari.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Cari.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Cari.OnPressedState.IconLeftImage = null;
            this.btn_Cari.OnPressedState.IconRightImage = null;
            this.btn_Cari.Size = new System.Drawing.Size(46, 29);
            this.btn_Cari.TabIndex = 44;
            this.btn_Cari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cari.TextMarginLeft = 0;
            this.btn_Cari.UseDefaultRadiusAndThickness = true;
            this.btn_Cari.Click += new System.EventHandler(this.btn_Cari_Click);
            // 
            // txt_Cari
            // 
            this.txt_Cari.AcceptsReturn = false;
            this.txt_Cari.AcceptsTab = false;
            this.txt_Cari.AnimationSpeed = 200;
            this.txt_Cari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Cari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Cari.BackColor = System.Drawing.Color.Transparent;
            this.txt_Cari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Cari.BackgroundImage")));
            this.txt_Cari.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_Cari.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_Cari.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_Cari.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_Cari.BorderRadius = 1;
            this.txt_Cari.BorderThickness = 1;
            this.txt_Cari.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Cari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cari.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_Cari.DefaultText = "";
            this.txt_Cari.FillColor = System.Drawing.Color.White;
            this.txt_Cari.HideSelection = true;
            this.txt_Cari.IconLeft = null;
            this.txt_Cari.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cari.IconPadding = 10;
            this.txt_Cari.IconRight = null;
            this.txt_Cari.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cari.Lines = new string[0];
            this.txt_Cari.Location = new System.Drawing.Point(363, 373);
            this.txt_Cari.MaxLength = 32767;
            this.txt_Cari.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Cari.Modified = false;
            this.txt_Cari.Multiline = false;
            this.txt_Cari.Name = "txt_Cari";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Cari.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_Cari.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Cari.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Cari.OnIdleState = stateProperties8;
            this.txt_Cari.PasswordChar = '\0';
            this.txt_Cari.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_Cari.PlaceholderText = "Search";
            this.txt_Cari.ReadOnly = false;
            this.txt_Cari.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Cari.SelectedText = "";
            this.txt_Cari.SelectionLength = 0;
            this.txt_Cari.SelectionStart = 0;
            this.txt_Cari.ShortcutsEnabled = true;
            this.txt_Cari.Size = new System.Drawing.Size(171, 29);
            this.txt_Cari.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_Cari.TabIndex = 43;
            this.txt_Cari.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Cari.TextMarginBottom = 0;
            this.txt_Cari.TextMarginLeft = 5;
            this.txt_Cari.TextMarginTop = 0;
            this.txt_Cari.TextPlaceholder = "Search";
            this.txt_Cari.UseSystemPasswordChar = false;
            this.txt_Cari.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(221, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Riwayat Penggajian";
            // 
            // FormGaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_hapus);
            this.Controls.Add(this.btn_Cari);
            this.Controls.Add(this.txt_Cari);
            this.Controls.Add(this.lvwGaji);
            this.Name = "FormGaji";
            this.Size = new System.Drawing.Size(678, 513);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwGaji;
        private System.Windows.Forms.LinkLabel lbl_hapus;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Cari;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_Cari;
        private System.Windows.Forms.Label label1;
    }
}
