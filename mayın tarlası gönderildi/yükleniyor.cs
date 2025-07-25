using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _230229074_zehraözdemir
{
    public partial class yükleniyor : Form
    {
        public yükleniyor()
        {
            //sayfanın görünüm özellikleri
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;

            //girişte gösterilecek fotoğraf ve kaydedildiği yer
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = global::_230229074_zehraözdemir.Resources.welcome;
            pictureBox.Size = this.ClientSize;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackColor = Color.Transparent;

            this.Controls.Add(pictureBox);
        }
        int loadingcounter = 0;
        

        private void yükleniyor_Load(object sender, EventArgs e)
        {
            // giriş yapıldığında zamanlayıcı başlatılacak
            timer1.Start();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //yükleniyordan giriş sayfasına geçiş
            if (loadingcounter != 60)
            {
                loadingcounter++;
            }
            else
            {
                girisSayfasi startscreen = new girisSayfasi();
                timer1.Stop();
                startscreen.Show();
                this.Hide();
            }
        }
        }
    }
