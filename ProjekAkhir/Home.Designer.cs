namespace ProjekAkhir
{
    partial class Home
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButtonMulai = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(102, 200);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(428, 146);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "SakuKu";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(134, 395);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(474, 112);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Atur aktivitas keuanganmu dengan SakuKu,\r\naplikasi keungan untuk kelola rencana f" +
    "inansial\r\ndengan mudah, capai tujuan target tabunganmu, \r\ndan pantau pengeluaran" +
    "mu\r\n";
            // 
            // gunaButtonMulai
            // 
            this.gunaButtonMulai.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.gunaButtonMulai.Location = new System.Drawing.Point(139, 580);
            this.gunaButtonMulai.Name = "gunaButtonMulai";
            this.gunaButtonMulai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.gunaButtonMulai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonMulai.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonMulai.OnHoverImage = null;
            this.gunaButtonMulai.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonMulai.OnPressedDepth = 15;
            this.gunaButtonMulai.Radius = 15;
            this.gunaButtonMulai.Size = new System.Drawing.Size(182, 42);
            this.gunaButtonMulai.TabIndex = 8;
            this.gunaButtonMulai.Text = "MULAI";
            this.gunaButtonMulai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonMulai.Click += new System.EventHandler(this.gunaButtonMulai_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::ProjekAkhir.Properties.Resources.Frame;
            this.gunaPictureBox1.Location = new System.Drawing.Point(756, 292);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(562, 396);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 9;
            this.gunaPictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1440, 984);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaButtonMulai);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton gunaButtonMulai;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}