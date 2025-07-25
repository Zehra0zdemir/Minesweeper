using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _230229074_zehraözdemir
{
    public partial class girisSayfasi : Form
    {
        //kullanılacak değerler
        private string kullanıcıAdı;
        private int skor;
        private const int maxUzunluk = 2; // girişlerde string kontrolü
        private int tarlaBoyutu;  
        private const int minvalue = 10; // grid girişi için minimum sınır
        private const int maxvalue = 30; // grid girişi için maksimum sınır
        private bool gameisstart = false; // Oyun başlangıç kontolü


        public girisSayfasi(string username = null, int score = 0, bool kazanmaDurumu = false)
        {
            // gerekli denetlemeleri atar
            InitializeComponent();
            this.gridSayısı.KeyDown += new KeyEventHandler(gridSayısı_KeyDown);
            this.gridSayısı.GotFocus += new EventHandler(textBoxValue_GotFocus);
            this.mayınSayısı.KeyDown += new KeyEventHandler(mayınSayısı_KeyDown); 
            this.MaximizeBox = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Text = "Zehra Özdemir"; // formun üstte yazılacak isim etiketi

            // oyun sonu bildirgeleri
            if (username != null)
            {
                this.kullanıcıAdı = username;
                this.skor = score;
                if (kazanmaDurumu)
                {
                    Kazanmak.Text = "Tebrikler";
                    Sonuc.Text = char.ToUpper(username[0]) + username.Substring(1).ToLower() + " \n Skorun : " + score.ToString();
                }
                else
                {
                    Kazanmak.Text = "Kaybettiniz";
                    Sonuc.Text = char.ToUpper(username[0]) + username.Substring(1).ToLower() + " \n Skorun : " + score.ToString();
                }

                isimKutusu.MaxLength = 12; 
                isimKutusu.Text = username;
                Sonuc.Visible = true;
            }
            else
            {
                Sonuc.Text = string.Empty;
                Sonuc.Visible = false;
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxValue_GotFocus(object sender, EventArgs e)
        {
            if (gridSayısı.Text.Length > maxUzunluk)
            {
                gridSayısı.Clear();
                MessageBox.Show("Lütfen geçerli değerler arasında giriş yapınız.");
            }
        }

        private void gridSayısı_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuşuna basıldığında yapılacak işlemler
                int minValue = 10;  // Minimum sınır
                int maxValue = 30;  // Maksimum sınır

                int userInput;
                // grid sayısını alır
                bool isValid = int.TryParse(gridSayısı.Text, out userInput);

                // geçerli olup olmadığını kontrol eder
                if (isValid && userInput >= minValue && userInput <= maxValue)
                {
                    tarlaBoyutu = userInput * userInput;
                    mayınSayısı.Focus();
                }
                else
                {
                    MessageBox.Show($"Lütfen {minValue} ile {maxValue} arasında bir değer giriniz.");
                    gridSayısı.Clear();
                    gridSayısı.Focus();
                }

                e.Handled = true;  // Enter tuşunun varsayılan işlevini devre dışı bırakır
                e.SuppressKeyPress = true;
            }
        }

        private void mayınSayısı_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuşuna basıldığında yapılacak işlemler

                int minValue = 10;  // girilebilecek minimum sınır

                // tarla boyutu'nu gridSayısı kutucuğundan al
                bool istarlaBoyutuValid = int.TryParse(gridSayısı.Text, out tarlaBoyutu);

                // geçerli giriş yapılmadıysa kutuyu temizler ve kutuya odaklanır
                if (!istarlaBoyutuValid)
                {
                    MessageBox.Show("Lütfen geçerli bir tarla boyutu girin.");
                    gridSayısı.Clear();
                    gridSayısı.Focus();
                    return;
                }

                int maxValue = tarlaBoyutu;  // girilebilecek maksimum sınır

                int kullanıcıgirişi;
                // mayın sayısını alır
                bool isValid = int.TryParse(mayınSayısı.Text, out kullanıcıgirişi);  

                // istenilen aralıkta olup olmadığını kontrol eder
                if (isValid && kullanıcıgirişi >= minValue && kullanıcıgirişi < maxValue * maxValue)
                {
                    string toplammetin = string.Empty;
                    string isim = isimKutusu.Text;
                    if (string.IsNullOrEmpty(isim))
                    {
                        MessageBox.Show("Lütfen isim alanını doldurun.");
                    }
                    // grid sayısının karesini kutucukların boyutuyla çarparak tablo boyutunu ayarlar ve oyun sayfasına geçiş yapar
                    int boyut = (int)Math.Sqrt(tarlaBoyutu);
                    oyunsayfası oyun = new oyunsayfası(isim, kullanıcıgirişi, new Size(tarlaBoyutu * 20, tarlaBoyutu * 20), new Size(1200, 800));
                    oyun.Show();
                    this.Hide();
                }
                // geçersiz giriş uyarısı verir
                else
                {
                    MessageBox.Show($"Lütfen {minValue} ile {maxValue * maxValue - 1} arasında bir değer giriniz.");
                    mayınSayısı.Clear();
                    mayınSayısı.Focus();
                }

                e.Handled = true;  // Enter tuşunun varsayılan işlevini devre dışı bırakır
                e.SuppressKeyPress = true;
            }
        }

        // skorlar butonuna tıklandığında tabloyu gösterir
        private void skorpagebutton_Click_1(object sender, EventArgs e)
        {
            skortablosu skor = new skortablosu();
            skor.Show();
        }

        private void Basla_Click_1(object sender, EventArgs e)
        {
            if (gameisstart) return; // oyun başladıysa işlemi durdurur

            // girişlerin istenilen aralıkta ve geçerli olup olmadığını kontol eder
            if (string.IsNullOrEmpty(isimKutusu.Text))
            {
                MessageBox.Show("Lütfen isim alanını doldurun.");
                return;
            }

            if (!int.TryParse(gridSayısı.Text, out int tarlaboyutu) || !int.TryParse(mayınSayısı.Text, out int mayinmiktari))
            {
                MessageBox.Show("Lütfen geçerli sayılar girin.");
                return;
            }

            if (tarlaboyutu < minvalue || tarlaboyutu > maxvalue || mayinmiktari < 10 || mayinmiktari >= tarlaboyutu * tarlaboyutu)
            {
                MessageBox.Show($"Lütfen {minvalue} ile {maxvalue} arasında bir tarla boyutu ve geçerli bir mayın miktarı giriniz.");
                return;
            }

            // Oyun ekranını oluşturur ve gösterir
            oyunsayfası oyun = new oyunsayfası(isimKutusu.Text, mayinmiktari, new Size(tarlaboyutu * 20, tarlaboyutu * 20), new Size(1200, 800));
            oyun.Show();
            this.Hide(); // giriş sayfasını gizler
            gameisstart = true; // oyunun başlatıldığı bilgisini günceller
            MessageBox.Show($"{mayinmiktari} {tarlaboyutu}"); // seçilen mayın miktarı ve grid sayısını kullanıcıya bildirir
        }

        // grid alanına isim alanını doldurmadan geçmeyi engeller
        private void gridSayısı_Click(object sender, EventArgs e)
        {
            string isim = isimKutusu.Text;
            if (string.IsNullOrEmpty(isim))
            {
                MessageBox.Show("İsim alanını doldurmak zorunludur!");
                isimKutusu.Focus();
            }
            else
            {
                Sonuc.Visible = true;
                Sonuc.Text = "Merhaba " + isimKutusu.Text; // sayfanın üst kısmına kullanıcının adını yazarak selam verir
            }
        }

        // isim alanı doldurup enter tuşuna basıldığında gerekli kontrolleri yapmayı sağlar
        private void isimKutusu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // eğer kutu boşsa uyarı mesajı yazdırır
                if (string.IsNullOrWhiteSpace(isimKutusu.Text))
                {
                    MessageBox.Show("Lütfen isim alanını doldurun.");
                }
                // kutu doldurulmuşsa grid sayısını girmesi için kullanıcıyı diğer kutucuğa yönlendirir
                else
                {
                    gridSayısı.Focus(); 
                }

                e.Handled = true; // olayın daha fazla işlenmemesini sağlar
                e.SuppressKeyPress = true; // yeni satıra geçmeyi engeller
            }
        }

        private void girisSayfasi_Load(object sender, EventArgs e)
        {
            // giris sayfası yüklenmesini tanımlar
        }

        private void Sonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
