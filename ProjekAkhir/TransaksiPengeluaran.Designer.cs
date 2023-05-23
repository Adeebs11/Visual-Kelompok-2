namespace ProjekAkhir
{
    partial class TransaksiPengeluaran
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
            this.gunaDataGridViewPengeluaran = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButtonHapus = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonEdit = new Guna.UI.WinForms.GunaButton();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewPengeluaran)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDataGridViewPengeluaran
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewPengeluaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridViewPengeluaran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaDataGridViewPengeluaran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewPengeluaran.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridViewPengeluaran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewPengeluaran.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewPengeluaran.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewPengeluaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridViewPengeluaran.ColumnHeadersHeight = 50;
            this.gunaDataGridViewPengeluaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kategori,
            this.Tanggal,
            this.Jumlah,
            this.Deskripsi});
            this.gunaDataGridViewPengeluaran.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridViewPengeluaran.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridViewPengeluaran.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewPengeluaran.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewPengeluaran.Location = new System.Drawing.Point(99, 152);
            this.gunaDataGridViewPengeluaran.Name = "gunaDataGridViewPengeluaran";
            this.gunaDataGridViewPengeluaran.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewPengeluaran.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridViewPengeluaran.RowHeadersVisible = false;
            this.gunaDataGridViewPengeluaran.RowHeadersWidth = 51;
            this.gunaDataGridViewPengeluaran.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gunaDataGridViewPengeluaran.RowTemplate.DividerHeight = 1;
            this.gunaDataGridViewPengeluaran.RowTemplate.Height = 30;
            this.gunaDataGridViewPengeluaran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewPengeluaran.Size = new System.Drawing.Size(978, 536);
            this.gunaDataGridViewPengeluaran.TabIndex = 1;
            this.gunaDataGridViewPengeluaran.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridViewPengeluaran.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewPengeluaran.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridViewPengeluaran.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewPengeluaran.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewPengeluaran.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewPengeluaran.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewPengeluaran.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewPengeluaran.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            this.gunaDataGridViewPengeluaran.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridViewPengeluaran.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewPengeluaran.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewPengeluaran.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridViewPengeluaran.ThemeStyle.HeaderStyle.Height = 50;
            this.gunaDataGridViewPengeluaran.ThemeStyle.ReadOnly = false;
            this.gunaDataGridViewPengeluaran.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewPengeluaran.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewPengeluaran.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewPengeluaran.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewPengeluaran.ThemeStyle.RowsStyle.Height = 30;
            this.gunaDataGridViewPengeluaran.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.gunaDataGridViewPengeluaran.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 1;
            this.gunaElipse1.TargetControl = this.gunaDataGridViewPengeluaran;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(369, 63);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(456, 41);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Tampilan Transaksi Pengeluaran";
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
            this.gunaButtonHapus.TabIndex = 5;
            this.gunaButtonHapus.Text = "Hapus";
            this.gunaButtonHapus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.gunaButtonEdit.TabIndex = 4;
            this.gunaButtonEdit.Text = "Edit";
            this.gunaButtonEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // TransaksiPengeluaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1159, 896);
            this.Controls.Add(this.gunaButtonHapus);
            this.Controls.Add(this.gunaButtonEdit);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaDataGridViewPengeluaran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransaksiPengeluaran";
            this.Text = "TransaksiPengeluaran";
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewPengeluaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewPengeluaran;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButtonHapus;
        private Guna.UI.WinForms.GunaButton gunaButtonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deskripsi;
    }
}