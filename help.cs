﻿using System;
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
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
            this.Close();
        }
    }
}