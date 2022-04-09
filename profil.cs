using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace oopPreLab2SON 
{
    public partial class profil : Form
    {
        public profil()
        {
            InitializeComponent();
            getData();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0; Data Source = kullaniciBilgileri.accdb");

        private void getData()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From KullaniciBilgiler ";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kullaniciAdi"].ToString();
                ekle.SubItems.Add(oku["sifre"].ToString());
                ekle.SubItems.Add(oku["name_surname"].ToString());
                ekle.SubItems.Add(oku["adress"].ToString());
                ekle.SubItems.Add(oku["city"].ToString());
                ekle.SubItems.Add(oku["country"].ToString());
                ekle.SubItems.Add(oku["email"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Form1.id;
            textBox2.Text = Form1.password;
            textBox3.Text = Form1.nameSurname;
            textBox4.Text = Form1.tel;
            textBox5.Text = Form1.adress;
            textBox6.Text = Form1.city;
            textBox7.Text = Form1.country;
            textBox8.Text = Form1.email;
            groupBox1.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.id = textBox1.Text;
            Form1.password = textBox2.Text;
            Form1.nameSurname = textBox3.Text;
            Form1.tel = textBox4.Text;
            Form1.adress = textBox5.Text;
            Form1.city = textBox6.Text;
            Form1.country = textBox7.Text;
            Form1.email = textBox8.Text;
        }
    }
}
