using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopPreLab2SON
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminSettings frm = new adminSettings();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            profil frm = new profil();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            about frm = new about();
            frm.ShowDialog();
        }
    }
}
