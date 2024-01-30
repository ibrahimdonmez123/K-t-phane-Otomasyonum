namespace Kütüphane_Otomasyonum
{
    partial class ÜyeSayfası
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
            this.btn_kitap_ara = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_kitap_yenile = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kitapdili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yayınevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sayfasayısı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basımyılı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kitap_ara
            // 
            this.btn_kitap_ara.Location = new System.Drawing.Point(12, 12);
            this.btn_kitap_ara.Name = "btn_kitap_ara";
            this.btn_kitap_ara.Size = new System.Drawing.Size(80, 30);
            this.btn_kitap_ara.TabIndex = 0;
            this.btn_kitap_ara.Text = "Ara";
            this.btn_kitap_ara.UseVisualStyleBackColor = true;
            this.btn_kitap_ara.Click += new System.EventHandler(this.btn_kitap_ara_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_kitap_yenile
            // 
            this.btn_kitap_yenile.Location = new System.Drawing.Point(204, 12);
            this.btn_kitap_yenile.Name = "btn_kitap_yenile";
            this.btn_kitap_yenile.Size = new System.Drawing.Size(80, 30);
            this.btn_kitap_yenile.TabIndex = 0;
            this.btn_kitap_yenile.Text = "Yenile";
            this.btn_kitap_yenile.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kitapid,
            this.Kitapisim,
            this.Kitapyazar,
            this.Kitapdili,
            this.Yayınevi,
            this.Tur,
            this.Adet,
            this.Sayfasayısı,
            this.Basımyılı});
            this.dataGridView2.Location = new System.Drawing.Point(12, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(751, 330);
            this.dataGridView2.TabIndex = 4;
            // 
            // Kitapid
            // 
            this.Kitapid.HeaderText = "KİTAPID";
            this.Kitapid.Name = "Kitapid";
            // 
            // Kitapisim
            // 
            this.Kitapisim.HeaderText = "KİTAP İSİM";
            this.Kitapisim.Name = "Kitapisim";
            // 
            // Kitapyazar
            // 
            this.Kitapyazar.HeaderText = "KİTAP YAZAR";
            this.Kitapyazar.Name = "Kitapyazar";
            // 
            // Kitapdili
            // 
            this.Kitapdili.HeaderText = "KİTAP DİLİ";
            this.Kitapdili.Name = "Kitapdili";
            // 
            // Yayınevi
            // 
            this.Yayınevi.HeaderText = "YAYINEVİ";
            this.Yayınevi.Name = "Yayınevi";
            // 
            // Tur
            // 
            this.Tur.HeaderText = "TÜR";
            this.Tur.Name = "Tur";
            // 
            // Adet
            // 
            this.Adet.HeaderText = "ADET";
            this.Adet.Name = "Adet";
            // 
            // Sayfasayısı
            // 
            this.Sayfasayısı.HeaderText = "SAYFASAYISI";
            this.Sayfasayısı.Name = "Sayfasayısı";
            // 
            // Basımyılı
            // 
            this.Basımyılı.HeaderText = "BASIM YILI";
            this.Basımyılı.Name = "Basımyılı";
            // 
            // ÜyeSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_kitap_yenile);
            this.Controls.Add(this.btn_kitap_ara);
            this.Name = "ÜyeSayfası";
            this.Text = "ÜyeSayfası";
            this.Load += new System.EventHandler(this.ÜyeSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kitap_ara;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_kitap_yenile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitapdili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yayınevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sayfasayısı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basımyılı;
    }
}