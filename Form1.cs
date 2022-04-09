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
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0; Data Source = kullaniciBilgileri.accdb");
        public static string id, password, nameSurname, tel, adress, city, country, email, yetki;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            signUp signup = new signUp();
            signup.Show();

        }

        bool check = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from KullaniciBilgiler",baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read()==true)
            {
                if(oku["kullaniciAdi"].ToString()==textBox1.Text && oku["sifre"].ToString() == textBox2.Text && oku["yetki"].ToString()== "admin")
                {
                    check = true;
                    id = oku.GetValue(0).ToString();
                    nameSurname = oku.GetValue(1).ToString();
                    tel = oku.GetValue(2).ToString();
                    adress = oku.GetValue(3).ToString();
                    city = oku.GetValue(4).ToString();
                    country = oku.GetValue(5).ToString();
                    password = oku.GetValue(6).ToString();
                    email = oku.GetValue(7).ToString();
                    yetki = oku.GetValue(8).ToString();
                    mainScreen mainScreen = new mainScreen();
                    mainScreen.Show();
                    mainScreen.button3.Visible = true;
                    this.Hide();
                    break;
                }
                if (oku["kullaniciAdi"].ToString() == textBox1.Text && oku["sifre"].ToString() == textBox2.Text && oku["yetki"].ToString() == "user")
                {
                    check = true;
                    id = oku.GetValue(0).ToString();
                    nameSurname = oku.GetValue(1).ToString();
                    tel = oku.GetValue(2).ToString();
                    adress = oku.GetValue(3).ToString();
                    city = oku.GetValue(4).ToString();
                    country = oku.GetValue(5).ToString();
                    password = oku.GetValue(6).ToString();
                    email = oku.GetValue(7).ToString();
                    yetki = oku.GetValue(8).ToString();
                    mainScreen mainScreen = new mainScreen();
                    mainScreen.Show();
                    mainScreen.button3.Visible = false;
                    
                    this.Hide();
                    break;
                }
            }
            baglanti.Close();
        }
    }
}
