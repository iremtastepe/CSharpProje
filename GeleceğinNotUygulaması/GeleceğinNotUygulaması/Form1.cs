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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtsifre.PasswordChar = '*';
        }
        SqlConnection baglanti = new SqlConnection(@"DATA SOURCE=DESKTOP-LGMC8P4\SQLEXPRESS02;Initial Catalog = gelecegenot; Integrated Security = True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (txtsifre.PasswordChar == '\0')
            {
                
                txtsifre.PasswordChar = '*';
             
            }
            else 
            {
             
                txtsifre.PasswordChar ='\0';
              
                button.Text = "Şifreyi Gizle";
            }

        }

        private void buttonuye_Click(object sender, EventArgs e)
        {
          Form2 form2 = new Form2();
            form2.Show();
        }

        private void buttongiris_Click(object sender, EventArgs e)
        {
            


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kayit_table where kullanici_adi='" + txtkullanici.Text + "'and sifre ='" + txtsifre.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                
                 Form3 form3 = new Form3();
                 form3.Show();
                 txtkullanici.Clear();
                 txtsifre.Clear();
                 this.Hide(); 

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz.");
                txtkullanici.Clear();
                txtsifre.Clear();
            }
            baglanti.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
