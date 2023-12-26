namespace Pizza_Sistemi
{
    partial class Form1
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
            this.siparis = new System.Windows.Forms.GroupBox();
            this.pizzaBilgileri = new System.Windows.Forms.GroupBox();
            this.tutarBilgisi = new System.Windows.Forms.Label();
            this.Tutar = new System.Windows.Forms.Label();
            this.pizza_boyut = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.onayla = new System.Windows.Forms.Button();
            this.pizzaTurSecenek = new System.Windows.Forms.ComboBox();
            this.PizzaTur = new System.Windows.Forms.Label();
            this.musteri = new System.Windows.Forms.GroupBox();
            this.TelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.richTextAdres = new System.Windows.Forms.RichTextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.Label();
            this.telNo = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.pizza_gorsel = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bilgi = new System.Windows.Forms.Label();
            this.Tum_Siparisler = new System.Windows.Forms.Button();
            this.Siparis_Arama = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.siparis_no = new System.Windows.Forms.TextBox();
            this.Siparis_Teslim = new System.Windows.Forms.Button();
            this.siparis_guncelle = new System.Windows.Forms.Button();
            this.siparis.SuspendLayout();
            this.pizzaBilgileri.SuspendLayout();
            this.musteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_gorsel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // siparis
            // 
            this.siparis.Controls.Add(this.pizzaBilgileri);
            this.siparis.Controls.Add(this.musteri);
            this.siparis.Location = new System.Drawing.Point(440, 13);
            this.siparis.Margin = new System.Windows.Forms.Padding(4);
            this.siparis.Name = "siparis";
            this.siparis.Padding = new System.Windows.Forms.Padding(4);
            this.siparis.Size = new System.Drawing.Size(925, 286);
            this.siparis.TabIndex = 0;
            this.siparis.TabStop = false;
            this.siparis.Text = "Sipariş Bilgileri";
            // 
            // pizzaBilgileri
            // 
            this.pizzaBilgileri.Controls.Add(this.tutarBilgisi);
            this.pizzaBilgileri.Controls.Add(this.Tutar);
            this.pizzaBilgileri.Controls.Add(this.pizza_boyut);
            this.pizzaBilgileri.Controls.Add(this.label2);
            this.pizzaBilgileri.Controls.Add(this.onayla);
            this.pizzaBilgileri.Controls.Add(this.pizzaTurSecenek);
            this.pizzaBilgileri.Controls.Add(this.PizzaTur);
            this.pizzaBilgileri.Location = new System.Drawing.Point(511, 23);
            this.pizzaBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.pizzaBilgileri.Name = "pizzaBilgileri";
            this.pizzaBilgileri.Padding = new System.Windows.Forms.Padding(4);
            this.pizzaBilgileri.Size = new System.Drawing.Size(404, 172);
            this.pizzaBilgileri.TabIndex = 5;
            this.pizzaBilgileri.TabStop = false;
            this.pizzaBilgileri.Text = "Pizza Bilgileri";
            // 
            // tutarBilgisi
            // 
            this.tutarBilgisi.AutoSize = true;
            this.tutarBilgisi.Location = new System.Drawing.Point(290, 112);
            this.tutarBilgisi.Name = "tutarBilgisi";
            this.tutarBilgisi.Size = new System.Drawing.Size(46, 16);
            this.tutarBilgisi.TabIndex = 28;
            this.tutarBilgisi.Text = ".............";
            // 
            // Tutar
            // 
            this.Tutar.AutoSize = true;
            this.Tutar.BackColor = System.Drawing.Color.Salmon;
            this.Tutar.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutar.Location = new System.Drawing.Point(194, 111);
            this.Tutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tutar.Name = "Tutar";
            this.Tutar.Size = new System.Drawing.Size(68, 17);
            this.Tutar.TabIndex = 27;
            this.Tutar.Text = "Tutar:";
            // 
            // pizza_boyut
            // 
            this.pizza_boyut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizza_boyut.FormattingEnabled = true;
            this.pizza_boyut.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük",
            "Mega"});
            this.pizza_boyut.Location = new System.Drawing.Point(214, 67);
            this.pizza_boyut.Margin = new System.Windows.Forms.Padding(4);
            this.pizza_boyut.Name = "pizza_boyut";
            this.pizza_boyut.Size = new System.Drawing.Size(160, 24);
            this.pizza_boyut.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pizza Boyut Seçimi:";
            // 
            // onayla
            // 
            this.onayla.Location = new System.Drawing.Point(32, 112);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(136, 39);
            this.onayla.TabIndex = 23;
            this.onayla.Text = "ONAYLA";
            this.onayla.UseVisualStyleBackColor = true;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // pizzaTurSecenek
            // 
            this.pizzaTurSecenek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizzaTurSecenek.FormattingEnabled = true;
            this.pizzaTurSecenek.Items.AddRange(new object[] {
            "Napoliten",
            "Pepperoni Pizza",
            "Margarita",
            "Tavuklu Pizza",
            "Peynirli Pizza",
            "Vejetaryen Pizza",
            "Ton Balıklı Pizza",
            "Karışık Pizza"});
            this.pizzaTurSecenek.Location = new System.Drawing.Point(214, 32);
            this.pizzaTurSecenek.Margin = new System.Windows.Forms.Padding(4);
            this.pizzaTurSecenek.Name = "pizzaTurSecenek";
            this.pizzaTurSecenek.Size = new System.Drawing.Size(160, 24);
            this.pizzaTurSecenek.TabIndex = 2;
            this.pizzaTurSecenek.SelectedIndexChanged += new System.EventHandler(this.pizzaTurSecenek_SelectedIndexChanged);
            // 
            // PizzaTur
            // 
            this.PizzaTur.AutoSize = true;
            this.PizzaTur.BackColor = System.Drawing.Color.Salmon;
            this.PizzaTur.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaTur.Location = new System.Drawing.Point(8, 37);
            this.PizzaTur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PizzaTur.Name = "PizzaTur";
            this.PizzaTur.Size = new System.Drawing.Size(138, 17);
            this.PizzaTur.TabIndex = 1;
            this.PizzaTur.Text = "Pizza Seçimi:";
            // 
            // musteri
            // 
            this.musteri.Controls.Add(this.TelefonNo);
            this.musteri.Controls.Add(this.richTextAdres);
            this.musteri.Controls.Add(this.textSoyad);
            this.musteri.Controls.Add(this.textAd);
            this.musteri.Controls.Add(this.adres);
            this.musteri.Controls.Add(this.telNo);
            this.musteri.Controls.Add(this.soyad);
            this.musteri.Controls.Add(this.ad);
            this.musteri.Location = new System.Drawing.Point(27, 23);
            this.musteri.Margin = new System.Windows.Forms.Padding(4);
            this.musteri.Name = "musteri";
            this.musteri.Padding = new System.Windows.Forms.Padding(4);
            this.musteri.Size = new System.Drawing.Size(476, 240);
            this.musteri.TabIndex = 4;
            this.musteri.TabStop = false;
            this.musteri.Text = "Müşteri Bilgileri";
            // 
            // TelefonNo
            // 
            this.TelefonNo.Location = new System.Drawing.Point(131, 107);
            this.TelefonNo.Mask = "(999) 000-0000";
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.Size = new System.Drawing.Size(133, 22);
            this.TelefonNo.TabIndex = 8;
            // 
            // richTextAdres
            // 
            this.richTextAdres.Location = new System.Drawing.Point(131, 155);
            this.richTextAdres.Margin = new System.Windows.Forms.Padding(4);
            this.richTextAdres.Name = "richTextAdres";
            this.richTextAdres.Size = new System.Drawing.Size(236, 73);
            this.richTextAdres.TabIndex = 7;
            this.richTextAdres.Text = "";
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(131, 60);
            this.textSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(132, 22);
            this.textSoyad.TabIndex = 5;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(131, 15);
            this.textAd.Margin = new System.Windows.Forms.Padding(4);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(133, 22);
            this.textAd.TabIndex = 4;
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.BackColor = System.Drawing.Color.Salmon;
            this.adres.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adres.Location = new System.Drawing.Point(8, 155);
            this.adres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(68, 17);
            this.adres.TabIndex = 3;
            this.adres.Text = "Adres:";
            // 
            // telNo
            // 
            this.telNo.AutoSize = true;
            this.telNo.BackColor = System.Drawing.Color.Salmon;
            this.telNo.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telNo.Location = new System.Drawing.Point(8, 112);
            this.telNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telNo.Name = "telNo";
            this.telNo.Size = new System.Drawing.Size(88, 17);
            this.telNo.TabIndex = 2;
            this.telNo.Text = "Telefon:";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.BackColor = System.Drawing.Color.Salmon;
            this.soyad.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyad.Location = new System.Drawing.Point(8, 69);
            this.soyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(68, 17);
            this.soyad.TabIndex = 1;
            this.soyad.Text = "Soyad:";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.BackColor = System.Drawing.Color.Salmon;
            this.ad.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.Location = new System.Drawing.Point(8, 23);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(38, 17);
            this.ad.TabIndex = 0;
            this.ad.Text = "Ad:";
            // 
            // pizza_gorsel
            // 
            this.pizza_gorsel.Location = new System.Drawing.Point(60, 59);
            this.pizza_gorsel.Name = "pizza_gorsel";
            this.pizza_gorsel.Size = new System.Drawing.Size(274, 149);
            this.pizza_gorsel.TabIndex = 2;
            this.pizza_gorsel.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pizza Görseli";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 356);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(984, 275);
            this.dataGridView2.TabIndex = 4;
            // 
            // bilgi
            // 
            this.bilgi.AutoSize = true;
            this.bilgi.Location = new System.Drawing.Point(23, 328);
            this.bilgi.Name = "bilgi";
            this.bilgi.Size = new System.Drawing.Size(100, 16);
            this.bilgi.TabIndex = 6;
            this.bilgi.Text = "Tüm Siparişler :";
            this.bilgi.Click += new System.EventHandler(this.label5_Click);
            // 
            // Tum_Siparisler
            // 
            this.Tum_Siparisler.Location = new System.Drawing.Point(1143, 565);
            this.Tum_Siparisler.Name = "Tum_Siparisler";
            this.Tum_Siparisler.Size = new System.Drawing.Size(168, 36);
            this.Tum_Siparisler.TabIndex = 7;
            this.Tum_Siparisler.Text = "Tüm Siparişleri Listele";
            this.Tum_Siparisler.UseVisualStyleBackColor = true;
            this.Tum_Siparisler.Click += new System.EventHandler(this.Tum_Siparisler_Click);
            // 
            // Siparis_Arama
            // 
            this.Siparis_Arama.Location = new System.Drawing.Point(1143, 481);
            this.Siparis_Arama.Name = "Siparis_Arama";
            this.Siparis_Arama.Size = new System.Drawing.Size(168, 36);
            this.Siparis_Arama.TabIndex = 8;
            this.Siparis_Arama.Text = "Sipariş Arama";
            this.Siparis_Arama.UseVisualStyleBackColor = true;
            this.Siparis_Arama.Click += new System.EventHandler(this.Siparis_Arama_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Location = new System.Drawing.Point(1078, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sipariş No: ";
            // 
            // siparis_no
            // 
            this.siparis_no.Location = new System.Drawing.Point(1175, 444);
            this.siparis_no.Margin = new System.Windows.Forms.Padding(4);
            this.siparis_no.Name = "siparis_no";
            this.siparis_no.Size = new System.Drawing.Size(133, 22);
            this.siparis_no.TabIndex = 11;
            this.siparis_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Siparis_Teslim
            // 
            this.Siparis_Teslim.Location = new System.Drawing.Point(1143, 523);
            this.Siparis_Teslim.Name = "Siparis_Teslim";
            this.Siparis_Teslim.Size = new System.Drawing.Size(168, 36);
            this.Siparis_Teslim.TabIndex = 24;
            this.Siparis_Teslim.Text = "Sipariş Teslim Et";
            this.Siparis_Teslim.UseVisualStyleBackColor = true;
            this.Siparis_Teslim.Click += new System.EventHandler(this.Siparis_Teslim_Click);
            // 
            // siparis_guncelle
            // 
            this.siparis_guncelle.Location = new System.Drawing.Point(1143, 607);
            this.siparis_guncelle.Name = "siparis_guncelle";
            this.siparis_guncelle.Size = new System.Drawing.Size(168, 36);
            this.siparis_guncelle.TabIndex = 25;
            this.siparis_guncelle.Text = "Sipariş Güncelle";
            this.siparis_guncelle.UseVisualStyleBackColor = true;
            this.siparis_guncelle.Click += new System.EventHandler(this.siparis_guncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 664);
            this.Controls.Add(this.siparis_guncelle);
            this.Controls.Add(this.Siparis_Teslim);
            this.Controls.Add(this.siparis_no);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Siparis_Arama);
            this.Controls.Add(this.Tum_Siparisler);
            this.Controls.Add(this.bilgi);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pizza_gorsel);
            this.Controls.Add(this.siparis);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PİZZA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.siparis.ResumeLayout(false);
            this.pizzaBilgileri.ResumeLayout(false);
            this.pizzaBilgileri.PerformLayout();
            this.musteri.ResumeLayout(false);
            this.musteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_gorsel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox siparis;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.Label telNo;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.GroupBox musteri;
        private System.Windows.Forms.RichTextBox richTextAdres;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.GroupBox pizzaBilgileri;
        private System.Windows.Forms.Label PizzaTur;
        private System.Windows.Forms.ComboBox pizzaTurSecenek;
        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pizza_boyut;
        private System.Windows.Forms.Label tutarBilgisi;
        private System.Windows.Forms.Label Tutar;
        private System.Windows.Forms.MaskedTextBox TelefonNo;
        private System.Windows.Forms.PictureBox pizza_gorsel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label bilgi;
        private System.Windows.Forms.Button Tum_Siparisler;
        private System.Windows.Forms.Button Siparis_Arama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox siparis_no;
        private System.Windows.Forms.Button Siparis_Teslim;
        private System.Windows.Forms.Button siparis_guncelle;
    }
}

