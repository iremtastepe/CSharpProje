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
    public partial class Form2 : Form
    {
        private DateTime secilenTarih;

        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            Guid toplanti_id = Guid.NewGuid();
            FileStream fs = File.Create(@"C:\Users\USER\Desktop\C#\toplantiuygulamasi\toplantiuygulamasi\ToplantiVeri\" + toplanti_id.ToString() + ".txt");
            fs.Close();
            StreamWriter sw = new StreamWriter(@"C:\Users\USER\Desktop\C#\toplantiuygulamasi\toplantiuygulamasi\ToplantiVeri\" + toplanti_id.ToString() + ".txt");
            sw.WriteLine(txt_Ad.Text + " " + txt_Soyad.Text + "\n" + txt_Baslik.Text + "\n" + txt_Aciklama.Text + "\n" + secilenTarih.ToString() + "\n");
            sw.Close();

            Console.WriteLine(toplanti_id.ToString());
            Form3 form3 = new Form3(txt_Ad.Text, txt_Soyad.Text, toplanti_id.ToString());
            form3.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime tarih = e.Start;
            labelTarih.Text = "Toplantı tarihiniz:" + tarih.ToString("dd.MM.yyyy");
            secilenTarih = tarih;
        }
    }
}
