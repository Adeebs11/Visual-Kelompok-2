namespace ProjekAkhir
{
    partial class EditPengeluaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPengeluaran));
            this.gunaButtonMulai = new Guna.UI.WinForms.GunaButton();
            this.gunaComboKategoriPglr = new Guna.UI.WinForms.GunaComboBox();
            this.gunaDateTimePickerPglr = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaTextBoxDeskPglr = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBoxJmlPglr = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaBtnClose = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaButtonMulai
            // 
            this.gunaButtonMulai.AnimationHoverSpeed = 0.07F;
            this.gunaButtonMulai.AnimationSpeed = 0.03F;
            this.gunaButtonMulai.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonMulai.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            this.gunaButtonMulai.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonMulai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButtonMulai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonMulai.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonMulai.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonMulai.ForeColor = System.Drawing.Color.White;
            this.gunaButtonMulai.Image = null;
            this.gunaButtonMulai.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonMulai.Location = new System.Drawing.Point(324, 547);
            this.gunaButtonMulai.Name = "gunaButtonMulai";
            this.gunaButtonMulai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.gunaButtonMulai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonMulai.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonMulai.OnHoverImage = null;
            this.gunaButtonMulai.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonMulai.OnPressedDepth = 15;
            this.gunaButtonMulai.Radius = 15;
            this.gunaButtonMulai.Size = new System.Drawing.Size(182, 42);
            this.gunaButtonMulai.TabIndex = 40;
            this.gunaButtonMulai.Text = "SIMPAN";
            this.gunaButtonMulai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonMulai.Click += new System.EventHandler(this.gunaButtonMulai_Click);
            // 
            // gunaComboKategoriPglr
            // 
            this.gunaComboKategoriPglr.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboKategoriPglr.BaseColor = System.Drawing.Color.White;
            this.gunaComboKategoriPglr.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboKategoriPglr.BorderSize = 0;
            this.gunaComboKategoriPglr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboKategoriPglr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboKategoriPglr.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboKategoriPglr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboKategoriPglr.ForeColor = System.Drawing.Color.Black;
            this.gunaComboKategoriPglr.FormattingEnabled = true;
            this.gunaComboKategoriPglr.Items.AddRange(new object[] {
            "Makanan dan Minuman",
            "Transportasi",
            "Kebutuhan Rumah",
            "Perawatan Pribadi",
            "Belanja",
            "Kesehatan",
            "Pendidikan",
            "Lainnya"});
            this.gunaComboKategoriPglr.Location = new System.Drawing.Point(78, 161);
            this.gunaComboKategoriPglr.Name = "gunaComboKategoriPglr";
            this.gunaComboKategoriPglr.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.gunaComboKategoriPglr.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            this.gunaComboKategoriPglr.Size = new System.Drawing.Size(428, 31);
            this.gunaComboKategoriPglr.TabIndex = 39;
            // 
            // gunaDateTimePickerPglr
            // 
            this.gunaDateTimePickerPglr.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePickerPglr.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePickerPglr.BorderSize = 0;
            this.gunaDateTimePickerPglr.CustomFormat = null;
            this.gunaDateTimePickerPglr.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePickerPglr.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            this.gunaDateTimePickerPglr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePickerPglr.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePickerPglr.Location = new System.Drawing.Point(78, 246);
            this.gunaDateTimePickerPglr.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePickerPglr.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePickerPglr.Name = "gunaDateTimePickerPglr";
            this.gunaDateTimePickerPglr.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePickerPglr.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            this.gunaDateTimePickerPglr.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            this.gunaDateTimePickerPglr.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePickerPglr.Size = new System.Drawing.Size(428, 31);
            this.gunaDateTimePickerPglr.TabIndex = 38;
            this.gunaDateTimePickerPglr.Text = "Saturday, 13 May 2023";
            this.gunaDateTimePickerPglr.Value = new System.DateTime(2023, 5, 13, 12, 3, 27, 3);
            // 
            // gunaTextBoxDeskPglr
            // 
            this.gunaTextBoxDeskPglr.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxDeskPglr.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxDeskPglr.BorderSize = 0;
            this.gunaTextBoxDeskPglr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxDeskPglr.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxDeskPglr.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            this.gunaTextBoxDeskPglr.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxDeskPglr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxDeskPglr.Location = new System.Drawing.Point(78, 416);
            this.gunaTextBoxDeskPglr.Multiline = true;
            this.gunaTextBoxDeskPglr.Name = "gunaTextBoxDeskPglr";
            this.gunaTextBoxDeskPglr.PasswordChar = '\0';
            this.gunaTextBoxDeskPglr.SelectedText = "";
            this.gunaTextBoxDeskPglr.Size = new System.Drawing.Size(428, 88);
            this.gunaTextBoxDeskPglr.TabIndex = 37;
            // 
            // gunaTextBoxJmlPglr
            // 
            this.gunaTextBoxJmlPglr.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxJmlPglr.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxJmlPglr.BorderSize = 0;
            this.gunaTextBoxJmlPglr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxJmlPglr.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxJmlPglr.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            this.gunaTextBoxJmlPglr.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxJmlPglr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxJmlPglr.Location = new System.Drawing.Point(78, 331);
            this.gunaTextBoxJmlPglr.Name = "gunaTextBoxJmlPglr";
            this.gunaTextBoxJmlPglr.PasswordChar = '\0';
            this.gunaTextBoxJmlPglr.SelectedText = "";
            this.gunaTextBoxJmlPglr.Size = new System.Drawing.Size(428, 31);
            this.gunaTextBoxJmlPglr.TabIndex = 36;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(85, 381);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(73, 21);
            this.gunaLabel6.TabIndex = 35;
            this.gunaLabel6.Text = "Deskripsi";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(85, 296);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(59, 21);
            this.gunaLabel5.TabIndex = 34;
            this.gunaLabel5.Text = "Jumlah";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(85, 211);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(62, 21);
            this.gunaLabel4.TabIndex = 33;
            this.gunaLabel4.Text = "Tanggal";
            // 
            // gunaBtnClose
            // 
            this.gunaBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaBtnClose.AnimationHoverSpeed = 0.07F;
            this.gunaBtnClose.AnimationSpeed = 0.03F;
            this.gunaBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.gunaBtnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaBtnClose.BorderColor = System.Drawing.Color.Black;
            this.gunaBtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaBtnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaBtnClose.FocusedColor = System.Drawing.Color.Empty;
            this.gunaBtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaBtnClose.ForeColor = System.Drawing.Color.White;
            this.gunaBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("gunaBtnClose.Image")));
            this.gunaBtnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaBtnClose.ImageSize = new System.Drawing.Size(24, 25);
            this.gunaBtnClose.Location = new System.Drawing.Point(537, 12);
            this.gunaBtnClose.Name = "gunaBtnClose";
            this.gunaBtnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(140)))), ((int)(((byte)(190)))));
            this.gunaBtnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaBtnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaBtnClose.OnHoverImage = null;
            this.gunaBtnClose.OnPressedColor = System.Drawing.Color.Black;
            this.gunaBtnClose.Radius = 5;
            this.gunaBtnClose.Size = new System.Drawing.Size(36, 35);
            this.gunaBtnClose.TabIndex = 32;
            this.gunaBtnClose.Click += new System.EventHandler(this.gunaBtnClose_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(85, 126);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(68, 21);
            this.gunaLabel3.TabIndex = 31;
            this.gunaLabel3.Text = "Kategori";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(32, 29);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(172, 28);
            this.gunaLabel1.TabIndex = 30;
            this.gunaLabel1.Text = "Edit Pengeluaran";
            // 
            // EditPengeluaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(585, 702);
            this.Controls.Add(this.gunaButtonMulai);
            this.Controls.Add(this.gunaComboKategoriPglr);
            this.Controls.Add(this.gunaDateTimePickerPglr);
            this.Controls.Add(this.gunaTextBoxDeskPglr);
            this.Controls.Add(this.gunaTextBoxJmlPglr);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaBtnClose);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPengeluaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPengeluaran";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButtonMulai;
        private Guna.UI.WinForms.GunaComboBox gunaComboKategoriPglr;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePickerPglr;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxDeskPglr;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxJmlPglr;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton gunaBtnClose;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}