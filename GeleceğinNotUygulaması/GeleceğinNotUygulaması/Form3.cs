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

namespace GeleceğinNotUygulaması
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        DateTime hedefzaman;

      
        public Form3()
        {
            
            InitializeComponent();
        }
        //baglanti = new SqlConnection(@"DATA SOURCE=DESKTOP-LGMC8P4\SQLEXPRESS02;Initial Catalog = gelecegenot; Integrated Security = True");
        void MesajGetir()
        {
            baglanti = new SqlConnection(@"DATA SOURCE=DESKTOP-LGMC8P4\SQLEXPRESS02;Initial Catalog = gelecegenot; Integrated Security = True");
            da = new SqlDataAdapter("SELECT * FROM geleceknot_table WHERE display_date < GETDATE()", baglanti); // Geçmiş notları getir
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void GelecekNotGetir()
        {
            baglanti = new SqlConnection(@"DATA SOURCE=DESKTOP-LGMC8P4\SQLEXPRESS02;Initial Catalog = gelecegenot; Integrated Security = True");
            da = new SqlDataAdapter("SELECT * FROM geleceknot_table WHERE display_date > GETDATE()", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MesajGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"DATA SOURCE=DESKTOP-LGMC8P4\SQLEXPRESS02;Initial Catalog = gelecegenot; Integrated Security = True");
            string Sorgu = "INSERT INTO geleceknot_table(mesaj,display_date,created_at) VALUES (@mesaj, @display_date, @created_at)";
            komut = new SqlCommand(Sorgu, baglanti);
            komut.Parameters.AddWithValue("@mesaj" , textBox1.Text);
            komut.Parameters.AddWithValue("@display_date", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@created_at", DateTime.Now);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            hedefzaman = dateTimePicker1.Value;

        
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime simdikizaman = DateTime.Now;

           
            TimeSpan kalanzaman = hedefzaman - simdikizaman;

          
            if (simdikizaman >= hedefzaman)
            {
                
                timer1.Stop();

                
                MessageBox.Show("Hatırlatma Zamanı Geldi: " + textBox1.Text, "Hatırlatma");

              
                hedefzaman = DateTime.MinValue;

                
                label6.Text = "Yeni Bir Mesajın var:";
            }
            else
            {
                
                label6.Text = "Mesaja Kalan Zaman: " + kalanzaman.ToString(@"dd\.hh\:mm\:ss");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GelecekNotGetir();
        }
    }
}
