using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryProject
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter DA;
        public Form1()
        {
            InitializeComponent();
        }

        void Kitap()
        {
            //baglanti = new SqlConnection("server=.;Initial Catalog=LİBRARYMANAGEMENT;Integrated Security=SSPI");
            baglanti = new SqlConnection("Data Source = DESKTOP-LGMC8P4\\SQLEXPRESS ;Initial Catalog=LİBRARYMANAGEMENT;Integrated Security=SSPI");
            baglanti.Open();
            DA = new SqlDataAdapter("SELECT *FROM Book_Table" , baglanti);
            DataTable Tablo = new DataTable();
            DA.Fill(Tablo);
            dataGridView1.DataSource = Tablo;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Kitap();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxYazar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxISBN.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string Sorgu = "INSERT INTO Book_Table(Title,Author,ISBN) VALUES (@Title,@Author,@ISBN)";
            komut = new SqlCommand(Sorgu, baglanti);
            komut.Parameters.AddWithValue("@Title", textBoxAd.Text);
            komut.Parameters.AddWithValue("@Author", textBoxYazar.Text);
            komut.Parameters.AddWithValue("@ISBN", textBoxISBN.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kitap();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            string Sorgu = "DELETE FROM Book_Table WHERE Title=@Title";
            komut = new SqlCommand(Sorgu, baglanti);
            komut.Parameters.AddWithValue("@Title", textBoxAd.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kitap();
        }
    }
}
