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
        int a, b, c, d;
        public static int x = Properties.Settings.Default.Custom1;
        public static int y = Properties.Settings.Default.Custom2;

        Button[,] buttons = new Button[x, y];

        int[,] locations = new int[x, y];

        int left = 0;
        int top = 5;

        Random rndm = new Random();

        public static Color color1, color2, color3;
        Color[] colors = new Color[3];

        Button first, temp;


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

        public void button1_Click(object sender, EventArgs e)
        {

            color1 = Properties.Settings.Default.Color1;
            color2 = Properties.Settings.Default.Color2;
            color3 = Properties.Settings.Default.Color3;

            colors[0] = color1;
            colors[1] = color2;
            colors[2] = color3;

            top = 0;

            panel1.Controls.Clear();
            panel1.Visible = true;

            createButtons();
            threeRandom();

        }
        private void createButtons()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 35;
                    buttons[i, j].Height = 35;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 35;
                    panel1.Controls.Add(buttons[i, j]);
                    buttons[i, j].Click += buton_Click;
                }
                top += 35;
                left = 0;

            }
        }
        private void threeRandom()
        {
            for (int i = 0; i < 3; i++)
            {

                a = rndm.Next(x);
                b = rndm.Next(y);
                c = rndm.Next(3);
                d = rndm.Next(3);

                if (buttons[a, b].BackgroundImage != null)
                {
                    while(buttons[a,b].BackgroundImage != null)
                    {
                        a = rndm.Next(x);
                        b = rndm.Next(y);
                    }
                }

                buttons[a, b].BackgroundImageLayout = ImageLayout.Center;
                buttons[a, b].BackgroundImage = ımageList1.Images[c];
                buttons[a, b].BackColor = colors[d];
            }
        }
        private void aRandomImage()
        {
            a = rndm.Next(x);
            b = rndm.Next(y);
            c = rndm.Next(3);
            d = rndm.Next(3);

            if (buttons[a, b].BackgroundImage != null)
            {
                while(buttons[a, b].BackgroundImage != null)
                {
                    a = rndm.Next(x);
                    b = rndm.Next(y);
                }
            }

            buttons[a, b].BackgroundImageLayout = ImageLayout.Center;
            buttons[a, b].BackgroundImage = ımageList1.Images[c];
            buttons[a, b].BackColor = colors[d];

        }
        private void buton_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            first = btn;
            if (first.BackgroundImage!=null)
            {
                if (temp == null)
                {
                    temp = first;
                    ımageList2.Images.Add(first.BackgroundImage);
                    temp.BackgroundImage = ımageList2.Images[0];
                }
            }
            if (first.BackgroundImage == null)
            {
                if (temp != null)
                {
                    btn.BackgroundImageLayout = ImageLayout.Center;
                    btn.BackgroundImage = ımageList2.Images[0];
                    btn.BackColor = temp.BackColor;
                    temp.BackgroundImage = null;
                    ımageList2.Images.RemoveAt(0);
                    temp.BackColor = DefaultBackColor;
                    temp = null;
                    aRandomImage();
                    //score(buttons);
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
        }
        //private void score(Button[,] bttn)
        //{
        //    int i = 0, j = 0, counterX=0, counterY=0, tempI=0, tempJ=0;
        //    for (i = 0; i < x; i++)
        //    {
        //        tempI = i;
        //        if (i < x - 1)
        //        {
        //            if ((bttn[i, j].BackgroundImage == bttn[i + 1, j].BackgroundImage) && (bttn[i, j].BackColor == bttn[i + 1, j].BackColor))
        //            {
        //                while (bttn[i, j].BackgroundImage == bttn[i+1, j].BackgroundImage && (bttn[i, j].BackColor == bttn[i+1, j].BackColor))
        //                {
        //                    i++;
        //                    if (i == x-1)
        //                    {
        //                        break;
        //                    }
                           
        //                    counterX++;
        //                    deleteSame(counterX, counterY, buttons);
        //                }
        //                i = tempI;
        //            }
        //        }
        //        for(j=0; j<y; j++)
        //        {
        //            tempJ = j;
        //            if (j < y - 1)
        //            {
        //                if ((bttn[i, j].BackgroundImage == bttn[i, j + 1].BackgroundImage) && (bttn[i, j].BackColor == bttn[i, j + 1].BackColor))
        //                {
        //                    while (bttn[i, j].BackgroundImage == bttn[i, j + 1].BackgroundImage && (bttn[i, j].BackColor == bttn[i, j + 1].BackColor))
        //                    {
        //                        j++;
        //                        if (j == y-1)
        //                        {
        //                            break;
        //                        }
        //                        counterY++;
        //                        deleteSame(counterX, counterY, buttons);

        //                    }
    
        //                }
        //                j = tempJ;
        //            }
        //        }
        //    }
        //}
        private void mainScreen_Load(object sender, EventArgs e)
        {

        }
        private void deleteSame(int counteRX, int counteRY, Button[,] buttoNs)
        {
            int i = 0, j = 0;
            for(i=0; i<counteRX; i++)
            {
                buttoNs[i, j].BackgroundImage = null;
                buttoNs[i, j].BackColor = DefaultBackColor;
                for(j=0; j<counteRY; j++)
                {
                    buttoNs[i, j].BackgroundImage = null;
                    buttoNs[i, j].BackColor = DefaultBackColor;
                }
            }
        }
    }
}


