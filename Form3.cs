using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace oopPreLab2SON
{
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

            DialogResult renkSonuc1;
            renkSonuc1 = colorDialog1.ShowDialog();


            if (renkSonuc1 == DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;
                Properties.Settings.Default.Color1 = label1.ForeColor;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult renkSonuc2;
            renkSonuc2 = colorDialog1.ShowDialog();


            if (renkSonuc2== DialogResult.OK)
            {
                label2.ForeColor = colorDialog1.Color;
                Properties.Settings.Default.Color2 = label2.ForeColor;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult renkSonuc3;
            renkSonuc3 = colorDialog1.ShowDialog();


            if (renkSonuc3 == DialogResult.OK)
            {
                label3.ForeColor = colorDialog1.Color;
                Properties.Settings.Default.Color3 = label3.ForeColor;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            Properties.Settings.Default.Difficulty4 = radioButton4.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Properties.Settings.Default.Color1;
            label2.ForeColor = Properties.Settings.Default.Color2;
            label3.ForeColor = Properties.Settings.Default.Color3;
            radioButton1.Checked = Properties.Settings.Default.Difficulty1;
            radioButton2.Checked = Properties.Settings.Default.Difficulty2;
            radioButton3.Checked = Properties.Settings.Default.Difficulty3;
            radioButton4.Checked = Properties.Settings.Default.Difficulty4;
            textBox1.Text = Properties.Settings.Default.Custom1.ToString();
            textBox2.Text = Properties.Settings.Default.Custom2.ToString();
            checkBox1.Checked = Properties.Settings.Default.Shape1;
            checkBox2.Checked = Properties.Settings.Default.Shape2;
            checkBox3.Checked = Properties.Settings.Default.Shape3;
            if (groupBox2.Visible == false)
            {
                groupBox3.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty1 = radioButton1.Checked;
            groupBox3.Hide();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.Difficulty2 = radioButton2.Checked;
            groupBox3.Hide();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.Difficulty3 = radioButton3.Checked;
            groupBox3.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                Properties.Settings.Default.Custom1 = a;
            }
            catch
            {
                MessageBox.Show("Somethings went wrong.");
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int b = int.Parse(textBox2.Text);
                Properties.Settings.Default.Custom2 = b;
            }
            catch
            {
                MessageBox.Show("Somethings went wrong.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Shape1 = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Shape2 = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Shape3 = checkBox3.Checked;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

