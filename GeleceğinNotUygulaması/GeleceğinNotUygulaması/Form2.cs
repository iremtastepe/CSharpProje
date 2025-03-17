using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeleceğinNotUygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"DATA SOURCE=DESKTOP-LGMC8P4\SQLEXPRESS02;Initial Catalog = gelecegenot; Integrated Security = True");

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonuye_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into kayit_table(kullanici_adi,sifre,mail_adres)values(@kullanici_adi,@sifre ,@mail_adres)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kullanici_adi", txtkullanici.Text);
            komut.Parameters.AddWithValue("@sifre", textBox1.Text);
            komut.Parameters.AddWithValue("@mail_adres", txtmail.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız başarıyla oluşturuldu.");
            txtkullanici.Clear();
            textBox1.Clear();
            txtmail.Clear();
            baglanti.Close();
        }

        private void txtkullanici_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
