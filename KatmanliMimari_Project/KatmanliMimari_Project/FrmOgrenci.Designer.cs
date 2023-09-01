namespace KatmanliMimari_Project
{
    partial class FrmOgrenci
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
            this.btnListe = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBolum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNumara = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListe
            // 
            this.btnListe.Location = new System.Drawing.Point(915, 511);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(305, 62);
            this.btnListe.TabIndex = 17;
            this.btnListe.Text = "Listeleme";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(915, 443);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(305, 62);
            this.btnGüncelle.TabIndex = 16;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(915, 375);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(305, 62);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(768, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 55);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad:";
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(915, 138);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(305, 38);
            this.tbxSoyad.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(915, 307);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(305, 62);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(768, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adı:";
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(916, 80);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(304, 38);
            this.tbxAd.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(742, 420);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(768, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 55);
            this.label3.TabIndex = 21;
            this.label3.Text = "Bölüm:";
            // 
            // tbxBolum
            // 
            this.tbxBolum.Location = new System.Drawing.Point(915, 251);
            this.tbxBolum.Name = "tbxBolum";
            this.tbxBolum.Size = new System.Drawing.Size(305, 38);
            this.tbxBolum.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(768, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "Numara:";
            // 
            // tbxNumara
            // 
            this.tbxNumara.Location = new System.Drawing.Point(916, 193);
            this.tbxNumara.Name = "tbxNumara";
            this.tbxNumara.Size = new System.Drawing.Size(304, 38);
            this.tbxNumara.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(768, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 37);
            this.label6.TabIndex = 23;
            this.label6.Text = "DersID:";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(916, 23);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(304, 38);
            this.tbxID.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(31, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 37);
            this.label5.TabIndex = 25;
            this.label5.Text = "Numara";
            // 
            // tbxAra
            // 
            this.tbxAra.Location = new System.Drawing.Point(179, 23);
            this.tbxAra.Name = "tbxAra";
            this.tbxAra.Size = new System.Drawing.Size(304, 38);
            this.tbxAra.TabIndex = 24;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(178, 80);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(305, 62);
            this.btnAra.TabIndex = 26;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1256, 589);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxAra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxBolum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxNumara);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSoyad);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgrenci";
            this.Text = "FrmOgrenci";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBolum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNumara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAra;
        private System.Windows.Forms.Button btnAra;
    }
}