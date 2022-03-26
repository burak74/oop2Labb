namespace OopPreLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("ID or Password should be filled.");
            }
            else if(textBox1.Text=="admin"&& textBox2.Text=="admin"||textBox1.Text=="user"&&textBox2.Text=="user")
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrond ID or Password!");
            }
        }
    }
}