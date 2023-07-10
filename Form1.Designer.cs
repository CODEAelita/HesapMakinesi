namespace HesapMakinesi
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
            this.labelEkran = new System.Windows.Forms.Label();
            this.buttonRakamÜç = new System.Windows.Forms.Button();
            this.buttonRakamİki = new System.Windows.Forms.Button();
            this.buttonRakamBir = new System.Windows.Forms.Button();
            this.buttonRakamAltı = new System.Windows.Forms.Button();
            this.buttonRakamBeş = new System.Windows.Forms.Button();
            this.buttonRakamDört = new System.Windows.Forms.Button();
            this.buttonRakamDokuz = new System.Windows.Forms.Button();
            this.buttonRakamSekiz = new System.Windows.Forms.Button();
            this.buttonRakamYedi = new System.Windows.Forms.Button();
            this.buttonEşittir = new System.Windows.Forms.Button();
            this.buttonRakamSıfır = new System.Windows.Forms.Button();
            this.buttonSilmeTuşu = new System.Windows.Forms.Button();
            this.buttonBölme = new System.Windows.Forms.Button();
            this.buttonÇarpma = new System.Windows.Forms.Button();
            this.buttonÇıkarma = new System.Windows.Forms.Button();
            this.buttonToplama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEkran
            // 
            this.labelEkran.BackColor = System.Drawing.Color.White;
            this.labelEkran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEkran.Location = new System.Drawing.Point(25, 9);
            this.labelEkran.Name = "labelEkran";
            this.labelEkran.Size = new System.Drawing.Size(238, 60);
            this.labelEkran.TabIndex = 0;
            this.labelEkran.Text = "0";
            this.labelEkran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonRakamÜç
            // 
            this.buttonRakamÜç.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRakamÜç.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRakamÜç.Location = new System.Drawing.Point(147, 87);
            this.buttonRakamÜç.Name = "buttonRakamÜç";
            this.buttonRakamÜç.Size = new System.Drawing.Size(55, 55);
            this.buttonRakamÜç.TabIndex = 6;
            this.buttonRakamÜç.Text = "3";
            this.buttonRakamÜç.UseVisualStyleBackColor = false;
            this.buttonRakamÜç.Click += new System.EventHandler(this.buttonRakamÜç_Click);
            // 
            // buttonRakamİki
            // 
            this.buttonRakamİki.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRakamİki.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRakamİki.Location = new System.Drawing.Point(86, 87);
            this.buttonRakamİki.Name = "buttonRakamİki";
            this.buttonRakamİki.Size = new System.Drawing.Size(55, 55);
            this.buttonRakamİki.TabIndex = 5;
            this.buttonRakamİki.Text = "2";
            this.buttonRakamİki.UseVisualStyleBackColor = false;
            this.buttonRakamİki.Click += new System.EventHandler(this.buttonRakamİki_Click);
            // 
            // buttonRakamBir
            // 
            this.buttonRakamBir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRakamBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRakamBir.Location = new System.Drawing.Point(25, 87);
            this.buttonRakamBir.Name = "buttonRakamBir";
            this.buttonRakamBir.Size = new System.Drawing.Size(55, 55);
            this.buttonRakamBir.TabIndex = 4;
            this.buttonRakamBir.Text = "1";
            this.buttonRakamBir.UseVisualStyleBackColor = false;
            this.buttonRakamBir.Click += new System.EventHandler(this.buttonRakamBir_Click);
            // 
            // buttonRakamAltı
            // 
            this.buttonRakamAltı.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRakamAltı.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRakamAltı.Location = new System.Drawing.Point(147, 148);
            this.buttonRakamAltı.Name = "buttonRakamAltı";
            this.buttonRakamAltı.Size = new System.Drawing.Size(55, 55);
            this.buttonRakamAltı.TabIndex = 9;
            this.buttonRakamAltı.Text = "6";
            this.buttonRakamAltı.UseVisualStyleBackColor = false;
            this.buttonRakamAltı.Click += new System.EventHandler(this.buttonRakamAltı_Click);
            // 
            // buttonRakamBeş
            // 
            this.buttonRakamBeş.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRakamBeş.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRakamBeş.Location = new System.Drawing.Point(86, 148);
            this.buttonRakamBeş.Name = "buttonRakamBeş";
            this.buttonRakamBeş.Size = new System.Drawing.Size(55, 55);
            this.buttonRakamBeş.TabIndex = 8;
            this.buttonRakamBeş.Text = "5";
            this.buttonRakamBeş.UseVisualStyleBackColor = false;
            this.buttonRakamBeş.Click += new System.EventHandler(this.buttonRakamBeş_Click);
            // 
            // buttonRakamDört
            // 
            this.buttonRakamDört.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRakamDört.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRakamDört.Location = new System.Drawing.Point(25, 148);
            this.buttonRakamDört.Name = "buttonRakamDört";
            this.buttonRakamDört.Size = new System.Drawing.Size(55, 55);
            this.buttonRakamDört.TabIndex = 7;
            this.buttonRakamDört.Text = "4";
            this.buttonRakamDört.UseVisualStyleBackColor = false;
            this.buttonRakamDört.Click += new System.EventHandler(this.buttonRakamDört_Click);
            // 
            // buttonRakamDokuz
            // 
            this.buttonRakamDokuz.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRakamDokuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRakamDokuz.Location = new System.Drawing.Point(147, 209);
            this.buttonRakamDokuz.Name = "buttonRakamDokuz";
            this.buttonRakamDokuz.Size = new System.Drawing.Size(55, 55);
            this.buttonRakamDokuz.TabIndex = 12;
            this.buttonRakamDokuz.Text = "9";
            this.buttonRakamDokuz.UseVisualStyleBackColor = false;
            this.buttonRakamDokuz.Click += new System.EventHandler(this.buttonRakamDokuz_Click);
            // 
            // buttonRakamSekiz
            // 
            this.buttonRakamSekiz.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRakamSekiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRakamSekiz.Location = new System.Drawing.Point(86, 209);
            this.buttonRakamSekiz.Name = "buttonRakamSekiz";
            this.buttonRakamSekiz.Size = new System.Drawing.Size(55, 55);
            this.buttonRakamSekiz.TabIndex = 11;
            this.buttonRakamSekiz.Text = "8";
            this.buttonRakamSekiz.UseVisualStyleBackColor = false;
            this.buttonRakamSekiz.Click += new System.EventHandler(this.buttonRakamSekiz_Click);
            // 
            // buttonRakamYedi
            // 
            this.buttonRakamYedi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRakamYedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRakamYedi.Location = new System.Drawing.Point(25, 209);
            this.buttonRakamYedi.Name = "buttonRakamYedi";
            this.buttonRakamYedi.Size = new System.Drawing.Size(55, 55);
            this.buttonRakamYedi.TabIndex = 10;
            this.buttonRakamYedi.Text = "7";
            this.buttonRakamYedi.UseVisualStyleBackColor = false;
            this.buttonRakamYedi.Click += new System.EventHandler(this.buttonRakamYedi_Click);
            // 
            // buttonEşittir
            // 
            this.buttonEşittir.BackColor = System.Drawing.Color.Pink;
            this.buttonEşittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEşittir.Location = new System.Drawing.Point(147, 270);
            this.buttonEşittir.Name = "buttonEşittir";
            this.buttonEşittir.Size = new System.Drawing.Size(55, 55);
            this.buttonEşittir.TabIndex = 15;
            this.buttonEşittir.Text = "=";
            this.buttonEşittir.UseVisualStyleBackColor = false;
            this.buttonEşittir.Click += new System.EventHandler(this.buttonEşittir_Click);
            // 
            // buttonRakamSıfır
            // 
            this.buttonRakamSıfır.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRakamSıfır.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRakamSıfır.Location = new System.Drawing.Point(86, 270);
            this.buttonRakamSıfır.Name = "buttonRakamSıfır";
            this.buttonRakamSıfır.Size = new System.Drawing.Size(55, 55);
            this.buttonRakamSıfır.TabIndex = 14;
            this.buttonRakamSıfır.Text = "0";
            this.buttonRakamSıfır.UseVisualStyleBackColor = false;
            this.buttonRakamSıfır.Click += new System.EventHandler(this.buttonRakamSıfır_Click);
            // 
            // buttonSilmeTuşu
            // 
            this.buttonSilmeTuşu.BackColor = System.Drawing.Color.Crimson;
            this.buttonSilmeTuşu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSilmeTuşu.ForeColor = System.Drawing.Color.White;
            this.buttonSilmeTuşu.Location = new System.Drawing.Point(25, 270);
            this.buttonSilmeTuşu.Name = "buttonSilmeTuşu";
            this.buttonSilmeTuşu.Size = new System.Drawing.Size(55, 55);
            this.buttonSilmeTuşu.TabIndex = 13;
            this.buttonSilmeTuşu.Text = "C";
            this.buttonSilmeTuşu.UseVisualStyleBackColor = false;
            this.buttonSilmeTuşu.Click += new System.EventHandler(this.buttonSilmeTuşu_Click);
            // 
            // buttonBölme
            // 
            this.buttonBölme.BackColor = System.Drawing.Color.Violet;
            this.buttonBölme.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBölme.Location = new System.Drawing.Point(208, 270);
            this.buttonBölme.Name = "buttonBölme";
            this.buttonBölme.Size = new System.Drawing.Size(55, 55);
            this.buttonBölme.TabIndex = 19;
            this.buttonBölme.Text = "/";
            this.buttonBölme.UseVisualStyleBackColor = false;
            this.buttonBölme.Click += new System.EventHandler(this.buttonBölme_Click);
            // 
            // buttonÇarpma
            // 
            this.buttonÇarpma.BackColor = System.Drawing.Color.Violet;
            this.buttonÇarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonÇarpma.Location = new System.Drawing.Point(208, 209);
            this.buttonÇarpma.Name = "buttonÇarpma";
            this.buttonÇarpma.Size = new System.Drawing.Size(55, 55);
            this.buttonÇarpma.TabIndex = 18;
            this.buttonÇarpma.Text = "X";
            this.buttonÇarpma.UseVisualStyleBackColor = false;
            this.buttonÇarpma.Click += new System.EventHandler(this.buttonÇarpma_Click);
            // 
            // buttonÇıkarma
            // 
            this.buttonÇıkarma.BackColor = System.Drawing.Color.Violet;
            this.buttonÇıkarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonÇıkarma.Location = new System.Drawing.Point(208, 148);
            this.buttonÇıkarma.Name = "buttonÇıkarma";
            this.buttonÇıkarma.Size = new System.Drawing.Size(55, 55);
            this.buttonÇıkarma.TabIndex = 17;
            this.buttonÇıkarma.Text = "-";
            this.buttonÇıkarma.UseVisualStyleBackColor = false;
            this.buttonÇıkarma.Click += new System.EventHandler(this.buttonÇıkarma_Click);
            // 
            // buttonToplama
            // 
            this.buttonToplama.BackColor = System.Drawing.Color.Violet;
            this.buttonToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonToplama.Location = new System.Drawing.Point(208, 87);
            this.buttonToplama.Name = "buttonToplama";
            this.buttonToplama.Size = new System.Drawing.Size(55, 55);
            this.buttonToplama.TabIndex = 16;
            this.buttonToplama.Text = "+";
            this.buttonToplama.UseVisualStyleBackColor = false;
            this.buttonToplama.Click += new System.EventHandler(this.buttonToplama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 340);
            this.Controls.Add(this.buttonBölme);
            this.Controls.Add(this.buttonÇarpma);
            this.Controls.Add(this.buttonÇıkarma);
            this.Controls.Add(this.buttonToplama);
            this.Controls.Add(this.buttonEşittir);
            this.Controls.Add(this.buttonRakamSıfır);
            this.Controls.Add(this.buttonSilmeTuşu);
            this.Controls.Add(this.buttonRakamDokuz);
            this.Controls.Add(this.buttonRakamSekiz);
            this.Controls.Add(this.buttonRakamYedi);
            this.Controls.Add(this.buttonRakamAltı);
            this.Controls.Add(this.buttonRakamBeş);
            this.Controls.Add(this.buttonRakamDört);
            this.Controls.Add(this.buttonRakamÜç);
            this.Controls.Add(this.buttonRakamİki);
            this.Controls.Add(this.buttonRakamBir);
            this.Controls.Add(this.labelEkran);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEkran;
        private System.Windows.Forms.Button buttonRakamÜç;
        private System.Windows.Forms.Button buttonRakamİki;
        private System.Windows.Forms.Button buttonRakamBir;
        private System.Windows.Forms.Button buttonRakamAltı;
        private System.Windows.Forms.Button buttonRakamBeş;
        private System.Windows.Forms.Button buttonRakamDört;
        private System.Windows.Forms.Button buttonRakamDokuz;
        private System.Windows.Forms.Button buttonRakamSekiz;
        private System.Windows.Forms.Button buttonRakamYedi;
        private System.Windows.Forms.Button buttonEşittir;
        private System.Windows.Forms.Button buttonRakamSıfır;
        private System.Windows.Forms.Button buttonSilmeTuşu;
        private System.Windows.Forms.Button buttonBölme;
        private System.Windows.Forms.Button buttonÇarpma;
        private System.Windows.Forms.Button buttonÇıkarma;
        private System.Windows.Forms.Button buttonToplama;
    }
}

