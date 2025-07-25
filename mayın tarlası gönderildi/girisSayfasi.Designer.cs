namespace _230229074_zehraözdemir
{
    partial class girisSayfasi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        ///
       
        protected override void Dispose(bool disposing)
        {
            // uygulamanın performansını arttırmak için kaynakları serbest bırakır
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
            this.skorpagebutton = new System.Windows.Forms.Button();
            this.mayınSayısı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridSayısı = new System.Windows.Forms.TextBox();
            this.Kazanmak = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isimKutusu = new System.Windows.Forms.TextBox();
            this.Sonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Basla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skorpagebutton
            // 
            this.skorpagebutton.Location = new System.Drawing.Point(396, 12);
            this.skorpagebutton.Name = "skorpagebutton";
            this.skorpagebutton.Size = new System.Drawing.Size(75, 23);
            this.skorpagebutton.TabIndex = 35;
            this.skorpagebutton.Text = "Skorlar";
            this.skorpagebutton.UseVisualStyleBackColor = true;
            this.skorpagebutton.Click += new System.EventHandler(this.skorpagebutton_Click_1);
            // 
            // mayınSayısı
            // 
            this.mayınSayısı.BackColor = System.Drawing.SystemColors.Info;
            this.mayınSayısı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mayınSayısı.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mayınSayısı.Location = new System.Drawing.Point(301, 334);
            this.mayınSayısı.Name = "mayınSayısı";
            this.mayınSayısı.Size = new System.Drawing.Size(107, 22);
            this.mayınSayısı.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(296, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mayın Sayısı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridSayısı
            // 
            this.gridSayısı.BackColor = System.Drawing.SystemColors.Info;
            this.gridSayısı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridSayısı.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridSayısı.Location = new System.Drawing.Point(67, 334);
            this.gridSayısı.Name = "gridSayısı";
            this.gridSayısı.Size = new System.Drawing.Size(115, 22);
            this.gridSayısı.TabIndex = 32;
            this.gridSayısı.Click += new System.EventHandler(this.gridSayısı_Click);
            // 
            // Kazanmak
            // 
            this.Kazanmak.BackColor = System.Drawing.Color.Transparent;
            this.Kazanmak.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kazanmak.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Kazanmak.Location = new System.Drawing.Point(120, 152);
            this.Kazanmak.Name = "Kazanmak";
            this.Kazanmak.Size = new System.Drawing.Size(251, 39);
            this.Kazanmak.TabIndex = 31;
            this.Kazanmak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(63, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Grid Sayısı:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(124, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Adınız :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isimKutusu
            // 
            this.isimKutusu.BackColor = System.Drawing.SystemColors.Info;
            this.isimKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isimKutusu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.isimKutusu.Location = new System.Drawing.Point(120, 235);
            this.isimKutusu.Name = "isimKutusu";
            this.isimKutusu.Size = new System.Drawing.Size(251, 22);
            this.isimKutusu.TabIndex = 25;
            this.isimKutusu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.isimKutusu_KeyDown);
            // 
            // Sonuc
            // 
            this.Sonuc.BackColor = System.Drawing.Color.Transparent;
            this.Sonuc.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sonuc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sonuc.Location = new System.Drawing.Point(123, 96);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(251, 56);
            this.Sonuc.TabIndex = 28;
            this.Sonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sonuc.Click += new System.EventHandler(this.Sonuc_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 47);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mayın Tarlası";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Basla
            // 
            this.Basla.BackColor = System.Drawing.SystemColors.Info;
            this.Basla.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Basla.Location = new System.Drawing.Point(162, 419);
            this.Basla.Name = "Basla";
            this.Basla.Size = new System.Drawing.Size(171, 33);
            this.Basla.TabIndex = 26;
            this.Basla.Text = "Başla";
            this.Basla.UseVisualStyleBackColor = false;
            this.Basla.Click += new System.EventHandler(this.Basla_Click_1);
            // 
            // girisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_230229074_zehraözdemir.Properties.Resources.baslangic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 488);
            this.Controls.Add(this.skorpagebutton);
            this.Controls.Add(this.mayınSayısı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridSayısı);
            this.Controls.Add(this.Kazanmak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isimKutusu);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Basla);
            this.Name = "girisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.girisSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // form üzerindeki araçları tanımlar
        private System.Windows.Forms.Button skorpagebutton;
        private System.Windows.Forms.TextBox mayınSayısı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gridSayısı;
        private System.Windows.Forms.Label Kazanmak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isimKutusu;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Basla;
    }
}

