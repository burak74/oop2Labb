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
    public partial class signUp : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0; Data Source = kullaniciBilgileri.accdb");

        public signUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into kullaniciBilgileri (kullaniciAdi, sifre, name_surname, phoneNumber, adress, city, country, email, yetki) values ('"+textBox1.Text.ToString()+ "','" + textBox2.Text.ToString() +"','"+textBox3.Text.ToString()+ "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "','" + textBox9.Text.ToString() + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.Hide();


        }
    }
}
