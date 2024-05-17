namespace KutuphaneOtomasyon
{
    partial class UyeSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeSayfasi));
            this.btn_ara = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_yenile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_cikisYap = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapDili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimYil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.ImageList = this.ımageList1;
            this.btn_ara.Location = new System.Drawing.Point(12, 12);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(90, 30);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "loupe_428094.png");
            this.ımageList1.Images.SetKeyName(1, "sync_6711500.png");
            this.ımageList1.Images.SetKeyName(2, "log-out_10152165.png");
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(214, 12);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(85, 30);
            this.btn_yenile.TabIndex = 1;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btn_cikisYap
            // 
            this.btn_cikisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikisYap.ImageIndex = 2;
            this.btn_cikisYap.ImageList = this.ımageList1;
            this.btn_cikisYap.Location = new System.Drawing.Point(12, 328);
            this.btn_cikisYap.Name = "btn_cikisYap";
            this.btn_cikisYap.Size = new System.Drawing.Size(132, 38);
            this.btn_cikisYap.TabIndex = 4;
            this.btn_cikisYap.Text = "Çıkış Yap";
            this.btn_cikisYap.UseVisualStyleBackColor = true;
            this.btn_cikisYap.Click += new System.EventHandler(this.btn_cikisYap_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapisim,
            this.kitapYazar,
            this.kitapDili,
            this.yayinEvi,
            this.tur,
            this.adet,
            this.sayfaSayisi,
            this.basimYil});
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 245);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "Kitap Id";
            this.kitapid.Name = "kitapid";
            // 
            // kitapisim
            // 
            this.kitapisim.HeaderText = "Kitap İsim";
            this.kitapisim.Name = "kitapisim";
            // 
            // kitapYazar
            // 
            this.kitapYazar.HeaderText = "Kitap Yazar";
            this.kitapYazar.Name = "kitapYazar";
            // 
            // kitapDili
            // 
            this.kitapDili.HeaderText = "Kitap Dili";
            this.kitapDili.Name = "kitapDili";
            // 
            // yayinEvi
            // 
            this.yayinEvi.HeaderText = "Yayın Evi";
            this.yayinEvi.Name = "yayinEvi";
            // 
            // tur
            // 
            this.tur.HeaderText = "Kitap Türü";
            this.tur.Name = "tur";
            // 
            // adet
            // 
            this.adet.HeaderText = "Kitap Adedi";
            this.adet.Name = "adet";
            // 
            // sayfaSayisi
            // 
            this.sayfaSayisi.HeaderText = "Sayfa Sayısı";
            this.sayfaSayisi.Name = "sayfaSayisi";
            // 
            // basimYil
            // 
            this.basimYil.HeaderText = "Basım Yılı";
            this.basimYil.Name = "basimYil";
            // 
            // UyeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cikisYap);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_ara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UyeSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeSayfasi";
            this.Load += new System.EventHandler(this.UyeSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_cikisYap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapDili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimYil;
    }
}