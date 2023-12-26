using Npgsql;
using System.IO;//File.Exists kullanıldı
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Diagnostics.Metrics;

namespace Pizza_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // string connectionString="Host=localhost;Port=5432;Database=Pizzaci;Username=postgres;Password=1234;";
        string connectionString = "Host=localhost;Port=5432;Database=Pizza_Firmasi;Username=postgres;Password=1234;";
        //Bağlantı kurma
        NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost;Port=5432;Database=Pizza_Firmasi;Username=postgres;Password=1234;");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onayla_Click(object sender, EventArgs e)
        {
            bilgi.Text = "Sipariş Bilgisi : ";
            string musteriAdi = textAd.Text;
            string musteriSoyad = textSoyad.Text;
            string musteriTel = TelefonNo.Text;
            string adres = richTextAdres.Text;
            string pizza_tur = pizzaTurSecenek.Text;
            string pizza_boyutu = pizza_boyut.Text;
            int Tutar = 0;

            //Tutar hesaplama
            if (pizza_tur == "Napoliten")
            {
                Tutar = 70; 
                         
            }
            else if(pizza_tur =="Pepperoni Pizza") 
            {
                Tutar = 60;

            }
            else if(pizza_tur =="Margarita")
            {
                Tutar = 60;

            }
            else if(pizza_tur =="Tavuklu Pizza")
            {
                Tutar = 80;

            }
            else if(pizza_tur =="Peynirli Pizza")
            {
                Tutar = 50;
            }
            else if(pizza_tur =="Vejetaryen Pizza")
            {
                Tutar = 40;

            }
            else if(pizza_tur =="Ton Balıklı Pizza") 
            {
                Tutar = 50;

            }
            else if(pizza_tur =="Karışık Pizza")
            {
                Tutar = 70;
            }

            if (pizza_boyutu == "Küçük") 
            {
                Tutar += 0;
            }
            else if (pizza_boyutu == "Orta")
            {
                Tutar += 20;
            }
            else if (pizza_boyutu == "Büyük")
            {
                Tutar += 30;
            }
            else if (pizza_boyutu == "Mega")
            {
                Tutar += 40;
            }

            tutarBilgisi.Text = Tutar.ToString();

            // PostgreSQL veritabanına bağlanma
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Veritabanı üzerinde bir komut oluşturma
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    //  müşteri tablosuna veri ekleme sorgusu
                    cmd.CommandText = "INSERT INTO musteri (ad, soyad, telefon_no, adres) VALUES (@musteriAdi, @musteriSoyad, @musteriTel, @adres)";
                    cmd.Parameters.AddWithValue("@musteriAdi", musteriAdi);
                    cmd.Parameters.AddWithValue("@musteriSoyad", musteriSoyad);
                    cmd.Parameters.AddWithValue("@musteriTel", musteriTel);
                    cmd.Parameters.AddWithValue("@adres", adres);

                    // Komutu çalıştırma
                    cmd.ExecuteNonQuery();
                }

                // Veritabanı üzerinde bir komut oluşturma
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    //  siparis_bilgisi tablosuna veri ekleme sorgusu
                    cmd.CommandText = "INSERT INTO siparis_bilgisi \r\n\t(musteri_ad,musteri_soyad,musteri_telefon,musteri_adres," +
                        "pizza_ad,pizza_boyut,tutar) \r\n \tVALUES (@musteriAdi,@musteriSoyad, @musteriTel, @adres, @pizza_tur,@pizza_boyutu,@Tutar);";
                    cmd.Parameters.AddWithValue("@musteriAdi", musteriAdi);
                    cmd.Parameters.AddWithValue("@musteriSoyad", musteriSoyad);
                    cmd.Parameters.AddWithValue("@musteriTel", musteriTel);
                    cmd.Parameters.AddWithValue("@adres", adres);
                    cmd.Parameters.AddWithValue("@pizza_tur", pizza_tur);
                    cmd.Parameters.AddWithValue("@pizza_boyutu", pizza_boyutu);
                    cmd.Parameters.AddWithValue("@Tutar", Tutar);

                    // Komutu çalıştırma
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            MessageBox.Show("Veri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Formu temizleme
            Temizle();

            //dataGridViewde veri gösterme
            string sorgu = "SELECT *\r\nFROM siparis_bilgisi\r\nORDER BY siparis_no DESC\r\nLIMIT 1; ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        private void Temizle()
        {
            textAd.Clear();
            textSoyad.Clear();
            TelefonNo.Clear();
            richTextAdres.Clear();
        }

        private void pizzaTurSecenek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pizzaTurSecenek.SelectedItem != null)
            {
                string itemValue = pizzaTurSecenek.SelectedItem.ToString();
                string imagePath =  $".\\..\\..\\..\\resim\\{itemValue.ToLower()}.jpg";
 
                if (File.Exists(imagePath))
                {
                    Bitmap image = new Bitmap(imagePath);

                    // Resmi PictureBox'ın boyutuna ayarlayalım
                    if (image.Width > pizza_gorsel.Width || image.Height > pizza_gorsel.Height)
                    {
                        float ratio = (float)image.Width / (float)image.Height;
                        int newWidth = pizza_gorsel.Width;
                        int newHeight = (int)(newWidth / ratio);

                        if (newHeight > pizza_gorsel.Height)
                        {
                            newHeight = pizza_gorsel.Height;
                            newWidth = (int)(newHeight * ratio);
                        }

                        Bitmap resizedImage = new Bitmap(image, new Size(newWidth, newHeight));
                        pizza_gorsel.Image = resizedImage;
                    }
                    else
                    {
                        pizza_gorsel.Image = image;
                    }
                }
                else
                {
                    MessageBox.Show($"Resim dosyası bulunamadı: {imagePath}");
                }
                baglanti.Close();
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Tum_Siparisler_Click(object sender, EventArgs e)
        {
            bilgi.Text = "Tüm Siparişler :";
            //dataGridViewde veri gösterme
            string sorgu = "SELECT *\r\nFROM siparis_bilgisi\r\nORDER BY siparis_no DESC; ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }


        private void Siparis_Arama_Click(object sender, EventArgs e)
        {
            if (int.TryParse(siparis_no.Text, out int Siparis_No))
            {
                // Eğer metin başarıyla bir tamsayıya dönüştürüldüyse devam et
                string sorgu = "SELECT * FROM siparis_bilgisi WHERE siparis_no = " + Siparis_No;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Geçerli bir sipariş numarası giriniz.");
            }
        }

        private void Siparis_Teslim_Click(object sender, EventArgs e)
        {
            if (int.TryParse(siparis_no.Text, out int Siparis_No))
            {
                try
                {
                    string sorgu = "DELETE FROM siparis_bilgisi WHERE siparis_no = @Siparis_No";

                    using (NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti))
                    {
                        command.Parameters.AddWithValue("@Siparis_No", Siparis_No);

                        baglanti.Open();
                        int etkilenenSatirSayisi = command.ExecuteNonQuery();
                        baglanti.Close();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show("Sipariş başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen ID'ye sahip sipariş bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sipariş silme işlemi sırasında bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir sipariş numarası giriniz.");
            }
        }

        private void siparis_guncelle_Click(object sender, EventArgs e)
        {
            if (int.TryParse(siparis_no.Text, out int Siparis_No))
            {
                try
                {
                    string musteriAdi = textAd.Text;
                    string musteriSoyad = textSoyad.Text;
                    string musteriTel = TelefonNo.Text;
                    string adres = richTextAdres.Text;
                    string pizza_tur = pizzaTurSecenek.Text;
                    string pizza_boyutu = pizza_boyut.Text;
                    int Tutar = 0;
                    //-----------------------
                    //Tutar hesaplama
                    if (pizza_tur == "Napoliten")
                    {
                        Tutar = 70;

                    }
                    else if (pizza_tur == "Pepperoni Pizza")
                    {
                        Tutar = 60;

                    }
                    else if (pizza_tur == "Margarita")
                    {
                        Tutar = 60;

                    }
                    else if (pizza_tur == "Tavuklu Pizza")
                    {
                        Tutar = 80;

                    }
                    else if (pizza_tur == "Peynirli Pizza")
                    {
                        Tutar = 50;
                    }
                    else if (pizza_tur == "Vejetaryen Pizza")
                    {
                        Tutar = 40;

                    }
                    else if (pizza_tur == "Ton Balıklı Pizza")
                    {
                        Tutar = 50;

                    }
                    else if (pizza_tur == "Karışık Pizza")
                    {
                        Tutar = 70;
                    }

                    if (pizza_boyutu == "Küçük")
                    {
                        Tutar += 0;
                    }
                    else if (pizza_boyutu == "Orta")
                    {
                        Tutar += 20;
                    }
                    else if (pizza_boyutu == "Büyük")
                    {
                        Tutar += 30;
                    }
                    else if (pizza_boyutu == "Mega")
                    {
                        Tutar += 40;
                    }

                    tutarBilgisi.Text = Tutar.ToString();

                    //-----------------------

                   
                    string sorgu = "UPDATE siparis_bilgisi " +
                                   "SET tutar = @Tutar, " +
                                   "musteri_ad = @musteriAdi, " +
                                   "musteri_soyad = @musteriSoyad, " +
                                   "musteri_telefon = @musteriTel, " +
                                   "musteri_adres = @adres, " +
                                   "pizza_ad = @pizza_tur, " +
                                   "pizza_boyut = @pizza_boyutu " +
                                   "WHERE siparis_no = @Siparis_No";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@musteriAdi", musteriAdi);
                        cmd.Parameters.AddWithValue("@musteriSoyad", musteriSoyad);
                        cmd.Parameters.AddWithValue("@musteriTel", musteriTel);
                        cmd.Parameters.AddWithValue("@adres", adres);
                        cmd.Parameters.AddWithValue("@pizza_tur", pizza_tur);
                        cmd.Parameters.AddWithValue("@pizza_boyutu", pizza_boyutu);
                        cmd.Parameters.AddWithValue("@Tutar", Tutar);
                        cmd.Parameters.AddWithValue("@Siparis_No", Siparis_No);



                        baglanti.Open();
                        int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
                        baglanti.Close();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show("Sipariş başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen ID'ye sahip sipariş bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sipariş güncelleme işlemi sırasında bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir sipariş numarası giriniz.");
            }
        }

    }

}
