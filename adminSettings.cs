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
    public partial class adminSettings : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0; Data Source = kullaniciBilgileri.accdb");
        OleDbCommandBuilder cb;
        OleDbDataAdapter adtr;
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        

        public adminSettings()
        {
           
            InitializeComponent();
            dataGridView1.DataSource = ShowData();
        }
        DataTable ShowData()
        {
            adtr = new OleDbDataAdapter("select *from kullaniciBilgileri", baglanti);
            adtr.Fill(tablo);
            return tablo;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            cb = new OleDbCommandBuilder(adtr);
            adtr.Update(tablo);
            ShowData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            signUp signupfromsettings = new signUp();
            signupfromsettings.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from kullaniciBilgileri where kullaniciAdi='" + textBox1.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            ShowData();
        }
    }
}
