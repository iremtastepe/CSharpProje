using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace toplantiuygulamasi
{
    public partial class Form5 : Form
    {
        private string kullaniciAd2;
        private string kullaniciSoyad2;
        public Form5(string kullaniciAd2, string kullaniciSoyad2)
        {
            InitializeComponent();
            label1.Text = "Sayın " + kullaniciAd2 + " " + kullaniciSoyad2 + " kodu ile girmiş olduğunuz toplantıya iletilen tarihte katılacaksınız";
            this.kullaniciAd2 = kullaniciAd2;
            this.kullaniciSoyad2 = kullaniciSoyad2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://calendar.google.com/calendar/u/0/r?pli=1");
        }
    }
}
