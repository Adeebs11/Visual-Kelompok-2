namespace ProjekAkhir
{
    partial class TransaksiPemasukan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaDataGridViewPemasukan = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButtonEdit = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonHapus = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewPemasukan)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDataGridViewPemasukan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewPemasukan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridViewPemasukan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaDataGridViewPemasukan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewPemasukan.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridViewPemasukan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewPemasukan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewPemasukan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewPemasukan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridViewPemasukan.ColumnHeadersHeight = 50;
            this.gunaDataGridViewPemasukan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kategori,
            this.Tanggal,
            this.Jumlah,
            this.Deskripsi});
            this.gunaDataGridViewPemasukan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridViewPemasukan.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridViewPemasukan.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewPemasukan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewPemasukan.Location = new System.Drawing.Point(99, 152);
            this.gunaDataGridViewPemasukan.Name = "gunaDataGridViewPemasukan";
            this.gunaDataGridViewPemasukan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewPemasukan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridViewPemasukan.RowHeadersVisible = false;
            this.gunaDataGridViewPemasukan.RowHeadersWidth = 51;
            this.gunaDataGridViewPemasukan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gunaDataGridViewPemasukan.RowTemplate.DividerHeight = 1;
            this.gunaDataGridViewPemasukan.RowTemplate.Height = 30;
            this.gunaDataGridViewPemasukan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewPemasukan.Size = new System.Drawing.Size(978, 536);
            this.gunaDataGridViewPemasukan.TabIndex = 0;
            this.gunaDataGridViewPemasukan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridViewPemasukan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewPemasukan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridViewPemasukan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewPemasukan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewPemasukan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewPemasukan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewPemasukan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewPemasukan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            this.gunaDataGridViewPemasukan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridViewPemasukan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewPemasukan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewPemasukan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridViewPemasukan.ThemeStyle.HeaderStyle.Height = 50;
            this.gunaDataGridViewPemasukan.ThemeStyle.ReadOnly = false;
            this.gunaDataGridViewPemasukan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewPemasukan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewPemasukan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewPemasukan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewPemasukan.ThemeStyle.RowsStyle.Height = 30;
            this.gunaDataGridViewPemasukan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.gunaDataGridViewPemasukan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewPemasukan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 1;
            this.gunaElipse1.TargetControl = this.gunaDataGridViewPemasukan;
            // 
            // Kategori
            // 
            this.Kategori.HeaderText = "Kategori";
            this.Kategori.MinimumWidth = 6;
            this.Kategori.Name = "Kategori";
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 6;
            this.Tanggal.Name = "Tanggal";
            // 
            // Jumlah
            // 
            this.Jumlah.HeaderText = "Jumlah";
            this.Jumlah.MinimumWidth = 6;
            this.Jumlah.Name = "Jumlah";
            // 
            // Deskripsi
            // 
            this.Deskripsi.HeaderText = "Deskripsi";
            this.Deskripsi.MinimumWidth = 6;
            this.Deskripsi.Name = "Deskripsi";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(369, 63);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(440, 41);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Tampilan Transaksi Pemasukan";
            // 
            // gunaButtonEdit
            // 
            this.gunaButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaButtonEdit.AnimationHoverSpeed = 0.07F;
            this.gunaButtonEdit.AnimationSpeed = 0.03F;
            this.gunaButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(179)))), ((int)(((byte)(18)))));
            this.gunaButtonEdit.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButtonEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonEdit.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonEdit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonEdit.ForeColor = System.Drawing.Color.White;
            this.gunaButtonEdit.Image = null;
            this.gunaButtonEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonEdit.Location = new System.Drawing.Point(99, 739);
            this.gunaButtonEdit.Name = "gunaButtonEdit";
            this.gunaButtonEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(211)))), ((int)(((byte)(26)))));
            this.gunaButtonEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonEdit.OnHoverImage = null;
            this.gunaButtonEdit.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonEdit.Radius = 10;
            this.gunaButtonEdit.Size = new System.Drawing.Size(133, 42);
            this.gunaButtonEdit.TabIndex = 2;
            this.gunaButtonEdit.Text = "Edit";
            this.gunaButtonEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButtonHapus
            // 
            this.gunaButtonHapus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaButtonHapus.AnimationHoverSpeed = 0.07F;
            this.gunaButtonHapus.AnimationSpeed = 0.03F;
            this.gunaButtonHapus.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonHapus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.gunaButtonHapus.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButtonHapus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonHapus.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonHapus.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonHapus.ForeColor = System.Drawing.Color.White;
            this.gunaButtonHapus.Image = null;
            this.gunaButtonHapus.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonHapus.Location = new System.Drawing.Point(263, 739);
            this.gunaButtonHapus.Name = "gunaButtonHapus";
            this.gunaButtonHapus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.gunaButtonHapus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonHapus.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonHapus.OnHoverImage = null;
            this.gunaButtonHapus.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonHapus.Radius = 10;
            this.gunaButtonHapus.Size = new System.Drawing.Size(133, 42);
            this.gunaButtonHapus.TabIndex = 3;
            this.gunaButtonHapus.Text = "Hapus";
            this.gunaButtonHapus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TransaksiPemasukan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1159, 896);
            this.Controls.Add(this.gunaButtonHapus);
            this.Controls.Add(this.gunaButtonEdit);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaDataGridViewPemasukan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransaksiPemasukan";
            this.Text = "Transaksi";
            this.Shown += new System.EventHandler(this.Transaksi_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewPemasukan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewPemasukan;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deskripsi;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButtonEdit;
        private Guna.UI.WinForms.GunaButton gunaButtonHapus;
    }
}