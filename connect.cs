using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;

namespace oopPreLab2SON
{
    public partial class connect : Form
    {
        public connect()
        {
            InitializeComponent();
            
        }

    
        
        public void button1_Click(object sender, EventArgs e)
        {
            
            multiplayerGame newGame = new multiplayerGame(true, IPAddress.Loopback);
            Visible = false;
            if (!newGame.IsDisposed)
            {   
                newGame.ShowDialog();
            }
            Visible = true;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            multiplayerGame newgame = new multiplayerGame(false, IPAddress.Loopback);
            Visible = false;
            if (!newgame.IsDisposed)
            {
                newgame.ShowDialog();
            }
            Visible = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void connect_Load(object sender, EventArgs e)
        {
        }
    }
}
