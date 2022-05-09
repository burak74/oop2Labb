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
       
        int custom1, custom2;
        public Form3()
        {
            InitializeComponent();
            
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                custom1 = 6;
                custom2 = 6;
                textBox1.Text = "6";
                textBox2.Text = "6";
                Properties.Settings.Default.Custom1 = custom1;
                Properties.Settings.Default.Custom2 = custom2;
            }
            Properties.Settings.Default.Difficulty3 = radioButton3.Checked;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                custom1 = int.Parse(textBox1.Text);
                Properties.Settings.Default.Custom1 = custom1;
               
                
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
                custom2 = int.Parse(textBox2.Text);
                Properties.Settings.Default.Custom2 = custom2;
                
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

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty4 = radioButton4.Checked;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            DialogResult renkSonuc1;
            renkSonuc1 = colorDialog1.ShowDialog();


            if (renkSonuc1 == DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;
                Properties.Settings.Default.Color1 = label1.ForeColor;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            DialogResult renkSonuc2;
            renkSonuc2 = colorDialog1.ShowDialog();


            if (renkSonuc2 == DialogResult.OK)
            {
                label2.ForeColor = colorDialog1.Color;
                Properties.Settings.Default.Color2 = label2.ForeColor;
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            DialogResult renkSonuc3;
            renkSonuc3 = colorDialog1.ShowDialog();


            if (renkSonuc3 == DialogResult.OK)
            {
                label3.ForeColor = colorDialog1.Color;
                Properties.Settings.Default.Color3 = label3.ForeColor;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox4.Visible = true;

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                custom1 = 15;
                custom2 = 15;
                textBox1.Text = "15";
                textBox2.Text = "15";
                Properties.Settings.Default.Custom1 = custom1;
                Properties.Settings.Default.Custom2 = custom2;
            }
            Properties.Settings.Default.Difficulty1 = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox1.Text = "9";
                textBox2.Text = "9";
                custom1 = 9;
                custom2 = 9;
                Properties.Settings.Default.Custom1 = custom1;
                Properties.Settings.Default.Custom2 = custom2;
            }
            Properties.Settings.Default.Difficulty2 = radioButton2.Checked;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                custom1 = 6;
                custom2 = 6;
                textBox1.Text = "6";
                textBox2.Text = "6";
                Properties.Settings.Default.Custom1 = custom1;
                Properties.Settings.Default.Custom2 = custom2;
            }
            Properties.Settings.Default.Difficulty3 = radioButton3.Checked;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty4 = radioButton4.Checked;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Shape1 = checkBox1.Checked;

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                custom1 = Int32.Parse(textBox1.Text);
                Properties.Settings.Default.Custom1 = custom1;


            }
            catch
            {
                MessageBox.Show("Somethings went wrong.");
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                custom2 = Int32.Parse(textBox2.Text);
                Properties.Settings.Default.Custom2 = custom2;

            }
            catch
            {
                MessageBox.Show("Somethings went wrong.");
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Shape2 = checkBox2.Checked;

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Shape3 = checkBox3.Checked;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}

