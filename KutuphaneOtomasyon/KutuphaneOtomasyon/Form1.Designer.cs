namespace KutuphaneOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.txtbx_kullaniciadi = new System.Windows.Forms.TextBox();
            this.txtbx_sifre = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(223, 74);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(124, 25);
            this.lbl_kullaniciadi.TabIndex = 1;
            this.lbl_kullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // txtbx_kullaniciadi
            // 
            this.txtbx_kullaniciadi.Location = new System.Drawing.Point(353, 74);
            this.txtbx_kullaniciadi.Multiline = true;
            this.txtbx_kullaniciadi.Name = "txtbx_kullaniciadi";
            this.txtbx_kullaniciadi.Size = new System.Drawing.Size(218, 25);
            this.txtbx_kullaniciadi.TabIndex = 2;
            this.txtbx_kullaniciadi.TextChanged += new System.EventHandler(this.txtbx_kullaniciadi_TextChanged);
            // 
            // txtbx_sifre
            // 
            this.txtbx_sifre.Location = new System.Drawing.Point(353, 137);
            this.txtbx_sifre.Multiline = true;
            this.txtbx_sifre.Name = "txtbx_sifre";
            this.txtbx_sifre.PasswordChar = '*';
            this.txtbx_sifre.Size = new System.Drawing.Size(218, 25);
            this.txtbx_sifre.TabIndex = 4;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(291, 137);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(56, 25);
            this.lbl_sifre.TabIndex = 3;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_girisyap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_girisyap.Location = new System.Drawing.Point(363, 198);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(96, 42);
            this.btn_girisyap.TabIndex = 5;
            this.btn_girisyap.Text = "Giriş Yap";
            this.btn_girisyap.UseVisualStyleBackColor = true;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Location = new System.Drawing.Point(475, 198);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(96, 42);
            this.btn_temizle.TabIndex = 6;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 280);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.txtbx_sifre);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.txtbx_kullaniciadi);
            this.Controls.Add(this.lbl_kullaniciadi);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.TextBox txtbx_kullaniciadi;
        private System.Windows.Forms.TextBox txtbx_sifre;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.Button btn_temizle;
    }
}

