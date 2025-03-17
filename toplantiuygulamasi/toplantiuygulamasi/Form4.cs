using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toplantiuygulamasi
{
    public partial class Form4 : Form
        //private string toplanti_id;
    {
        public Form4(string toplanti_id)
        {
            InitializeComponent();
        //this.toplanti_id = toplanti_id;
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GirişButon_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\USER\Desktop\C#\toplantiuygulamasi\toplantiuygulamasi\ToplantiVeri\" + txt_toplantiID.Text + ".txt");
            string Veri = txt_toplantiID.Text;
            sr.Close();

            string girilenkod = txt_toplantiID.Text;

            //if (Form3.rastgeleKod.Contains(girilenkod))
            //{
                MessageBox.Show("Giriş Başarılı");
                Form5 yenisayfa2 = new Form5(textBox1.Text, textBox2.Text);
                yenisayfa2.Show();
                this.Hide();
            //}
            //else
            //{
              //  MessageBox.Show("Girdiğiniz Kod Hatalı. Lütfen Tekrar Deneyin.");
            //}
        }
    }
}
