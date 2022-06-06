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
            komut.CommandText = "Select * From kullaniciBilgileri ";
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
                textBox1.Text = oku["kullaniciAdi"].ToString();
                textBox2.Text = oku["sifre"].ToString();
                textBox3.Text = oku["name_surname"].ToString();
                textBox4.Text = oku["phoneNumber"].ToString();
                textBox5.Text = oku["adress"].ToString();
                textBox6.Text = oku["city"].ToString();
                textBox7.Text = oku["country"].ToString();
                textBox8.Text = oku["email"].ToString();
            }
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            getData();
            groupBox1.Visible = true;

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into kullaniciBilgileri (kullaniciAdi, sifre, name_surname, phoneNumber, adress, city, country, email) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
