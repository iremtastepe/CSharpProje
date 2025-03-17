using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace toplantiuygulamasi
{
    public partial class Form3 : Form
    {
        private string kullaniciAd;
        private string kullaniciSoyad;
        private string baslik;
        private string toplanti_id;
        public static string rastgeleKod;
        public Form3(string kullaniciAd, string kullaniciSoyad, string toplanti_id)
        {
            InitializeComponent();
            label1.Text = "Sayın " + kullaniciAd + " " + kullaniciSoyad + " toplantınız seçmiş olduğunuz tarihte açılacaktır";

            this.kullaniciAd = kullaniciAd;
            this.kullaniciSoyad = kullaniciSoyad;
            this.toplanti_id = toplanti_id;
        }

        private void KodAlButon_Click(object sender, EventArgs e)
        {
            Random randomkod = new Random();
            rastgeleKod = Convert.ToString(randomkod.Next(1000, 9999));
            //label2.Text = rastgeleKod.ToString("Toplantı Kodunuz:" + rastgeleKod);
            txt_giriskodu.Text = rastgeleKod.ToString();
            File.AppendAllText(@"C:\Users\USER\Desktop\C#\toplantiuygulamasi\toplantiuygulamasi\ToplantiVeri\" + toplanti_id + ".txt", txt_giriskodu.Text + "\n");
            /*StreamWriter sw = new StreamWriter(@"C:\Users\USER\Desktop\C#\toplantiuygulamasi\toplantiuygulamasi\ToplantiVeri\" + toplanti_id + ".txt");
            
            sw.WriteLine(txt_giriskodu.Text + "\n");
            sw.Close();*/
            Form4 form4 = new Form4(toplanti_id.ToString());

        }

        private void AnasayfaButon_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }
    }
}
