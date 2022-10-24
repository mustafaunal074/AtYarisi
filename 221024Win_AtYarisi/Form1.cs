using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _221024Win_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            kellikinaye.Left += rnd.Next(1, 5);
            delibey.Left += rnd.Next(1, 5);
            akkacan.Left += rnd.Next(1, 5);
            midas.Left += rnd.Next(1, 5);
            karasimsek.Left += rnd.Next(1, 5);

            AtKontrol(kellikinaye);
            AtKontrol(delibey);
            AtKontrol(akkacan);
            AtKontrol(midas);
            AtKontrol(karasimsek);
        }
        void AtKontrol(PictureBox at)
        {
            if (at.Right > label2.Left) // atlardan birinin kazandığını tespit edildiği yer
            {
                timer1.Stop();
                AtDurumDegistir(false, at);
                //sesci.Stop();
                MessageBox.Show(at.Name + " Kazandı");
            }
        }
        void AtDurumDegistir(bool durum, PictureBox kazanan)
        {
            kellikinaye.Enabled = delibey.Enabled = akkacan.Enabled = midas.Enabled = karasimsek.Enabled = durum;
            kazanan.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            SoundPlayer sesci = new SoundPlayer();
            sesci.SoundLocation = "ses.wav";
            sesci.Play();
            AtDurumDegistir(true, kellikinaye);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //kellikinaye.Left = delibey.Left = akkacan.Left = midas.Left = karasimsek.Left = 83;
            Application.Restart();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkimizda hayirlisi = new Hakkimizda();
            hayirlisi.Show();
        }
    }
}
