using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _230229074_zehraözdemir
{
    public partial class skortablosu : Form
    { 
        
        private List<PlayerScore> playerScores; // kullanıcı skorları
        private string csvFilePath; // dosyaya erişim sağlar

        public skortablosu()
        {
            InitializeComponent();
            InitializePlayerScores();
            DisplayPlayerScores();
        }

        private void InitializePlayerScores()
        {
            playerScores = new List<PlayerScore>();
            csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "skorlar.csv"); // dosya yolu


            try
            {
                var lines = File.ReadAllLines(csvFilePath);

                foreach (var line in lines.Skip(1))  // İlk satır başlık olduğu için atlanıyor
                {
                    var values = line.Split(',');
                    playerScores.Add(new PlayerScore(values[0], Convert.ToInt32(values[1])));
                }

                // skorları azalan sırayla dizer ve en yüksek 10 skoru alır
                playerScores = playerScores.OrderByDescending(s => s.Score).Take(10).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void DisplayPlayerScores()
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.DataSource = playerScores;
            this.Controls.Add(dataGridView);

            this.Text = "TOP 10";
            this.Size = new Size(400, 300); // tablo boyutu
        }

        private void skorboard_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }

    public class PlayerScore
    {
        // kullanıcının adını ve skorunu saklamak için atamaları yapar
        public string Name { get; set; }
        public int Score { get; set; }

        public PlayerScore(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}

