using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Media;
using System.Data.OleDb;

namespace oopPreLab2SON
{
    public partial class mainScreen : Form
    {
        

        public mainScreen()
        {
            InitializeComponent();
            //MessageReceiver.DoWork += MessageReceiver_DoWork;
            //CheckForIllegalCrossThreadCalls = false;

            //if (isHost)
            //{
            //    server = new TcpListener(System.Net.IPAddress.Any, 5732);
            //    server.Start();
            //    sock = server.AcceptSocket();
            //}
            //else
            //{
            //    try
            //    {
            //        client = new TcpClient(ip, 5732);
            //        sock = client.Client;
            //        MessageReceiver.RunWorkerAsync();

            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        Close();
            //    }
            //}

        }

        //private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    int counter = x * y;
        //    for (int a = 0; a < x; a++)
        //    {
        //        for (int b = 0; b < y; b++)
        //        {
        //            if (buttons[a, b].BackgroundImage != null)
        //            {
        //                counter--;
        //            }
                    

        //        }
        //    }
        //    if (counter == 0)
        //    {
        //        return;
        //    }
        //    freezeButtons();
        //    label1.Text = "Opponent's Turn!";
        //    ReceiveMove();
        //    label1.Text = "Your Turn!";
        //    if (counter != 0)
        //    {
        //        unFreezeButtons();
        //    }
        //}

        int a, b, c, d;

        int point = 0;
        int pointSum = 0;
        int randomCounter = x * y;

        int[] scores = new int[6];

        static int x = Properties.Settings.Default.Custom1;
        static int y = Properties.Settings.Default.Custom2;


        Button[,] buttons = new Button[x, y];

        int left = 0;
        int top = 5;

        Random rndm = new Random();

        public static Color color1, color2, color3;
        Color[] colors = new Color[3];

        Button first, temp;

        //private Socket sock;

        //Image yourBackImage;
        //Color yourBackColor;

        //Image opponentBackImage;
        //Color opponentBackColor;

        //private BackgroundWorker MessageReceiver = new BackgroundWorker();
        //private TcpListener server = null;
        //private TcpClient client;

        //public bool isHost = Properties.Settings.Default.host;
        //public string ip = Properties.Settings.Default.ip;


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

            pointSum = 0;

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
                    while (buttons[a, b].BackgroundImage != null)
                    {
                        a = rndm.Next(x);
                        b = rndm.Next(y);
                    }
                }



                buttons[a, b].BackgroundImageLayout = ImageLayout.Center;
                buttons[a, b].BackgroundImage = ımageList1.Images[c];
                buttons[a, b].ImageIndex = c;
                buttons[a, b].BackColor = colors[d];
            }
        }
        
    


        private void aRandom()
        {
            for (int i = 0; i < 1; i++)
            {

                a = rndm.Next(x);
                b = rndm.Next(y);
                c = rndm.Next(3);
                d = rndm.Next(3);

                if (buttons[a, b].BackgroundImage != null)
                {
                    while (buttons[a, b].BackgroundImage != null)
                    {
                        a = rndm.Next(x);
                        b = rndm.Next(y);
                    }
                }

                


                buttons[a, b].BackgroundImageLayout = ImageLayout.Center;
                buttons[a, b].BackgroundImage = ımageList1.Images[c];
                buttons[a, b].ImageIndex = c;
                buttons[a, b].BackColor = colors[d];
            }
        }


        private void twoRandom()
        {
            for (int i = 0; i < 2; i++)
            {

                a = rndm.Next(x);
                b = rndm.Next(y);
                c = rndm.Next(3);
                d = rndm.Next(3);

                if (buttons[a, b].BackgroundImage != null)
                {
                    while (buttons[a, b].BackgroundImage != null)
                    {
                        a = rndm.Next(x);
                        b = rndm.Next(y);
                    }
                }



                buttons[a, b].BackgroundImageLayout = ImageLayout.Center;
                buttons[a, b].BackgroundImage = ımageList1.Images[c];
                buttons[a, b].ImageIndex = c;
                buttons[a, b].BackColor = colors[d];
            }
        }
       
        private void buton_Click(object sender, EventArgs e)
        {
                
            Button btn = (Button)sender;
            first = btn;

            soundEffect1();

          
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
                    btn.ImageIndex = temp.ImageIndex;

                    soundEffect2();

                    temp.BackgroundImage = null;
                    ımageList2.Images.RemoveAt(0);
                    temp.BackColor = DefaultBackColor;
                    temp = null;
                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            if (buttons[i, j].BackgroundImage != null)
                            {
                                randomCounter--;
                            }
                        }
                    }
                    if (randomCounter >= 3)
                    {
                        threeRandom();
                       
                    }
                    else if (randomCounter == 2)
                    {
                        twoRandom();
                       
                    }
                    else if (randomCounter == 1)
                    {
                        aRandom();
                        
                    }
                    //byte[] num = File.ReadAllBytes(btn.Location.ToString());
                    //sock.Send(num);
                    //MessageReceiver.RunWorkerAsync();

                    score();
                    isOver();
                }
            }
            randomCounter = x * y; 
        }
        private void soundEffect1()
        {
            SoundPlayer effect = new SoundPlayer();
            string path = Application.StartupPath + "swipe.wav";
            effect.SoundLocation = path;
            effect.Play();
        }
        private void soundEffect2()
        {
            SoundPlayer effect = new SoundPlayer();
            string path = Application.StartupPath + "swoosh.wav";
            effect.SoundLocation = path;
            effect.Play();
        }
        private void soundEffect3()
        {
            SoundPlayer effect = new SoundPlayer();
            string path = Application.StartupPath + "gameOver.wav";
            effect.SoundLocation = path;
            effect.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Application.Restart();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void soundEffect4()
        {
            SoundPlayer effect = new SoundPlayer();
            string path = Application.StartupPath + "broken.wav";
            effect.SoundLocation = path;
            effect.Play();
        }

        

        private void isOver()
        {
            int checkOver = x * y;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (buttons[i, j].BackgroundImage != null)
                    {
                        checkOver--;
                        if (checkOver == 0)
                        {
                            if (x * y == 225) 
                            {
                                scores[0] = pointSum;
                                bubbleSort(scores);
                                listingScores();
                                soundEffect3();
                                MessageBox.Show("GAME OVER! Your Score:" + pointSum);


                            }
                            if (x * y == 81)
                            {
                                scores[0] = 3 * pointSum;
                                bubbleSort(scores);
                                listingScores();
                                soundEffect3();
                                MessageBox.Show("GAME OVER! Your Score:" + (3*pointSum));

                            }
                            if (x * y == 36)
                            {
                                soundEffect3();
                                scores[0] = 5 * pointSum;
                                bubbleSort(scores);
                                listingScores();
                                MessageBox.Show("GAME OVER! Your Score:" + (5*pointSum));
                              
                            }
                            else
                            {
                                soundEffect3();
                                scores[0] = 2 * pointSum;
                                bubbleSort(scores);
                                listingScores();
                                MessageBox.Show("GAME OVER! Your Score:" + (2 * pointSum));
                                

                            }
                        }
                    }
                }
            }
            

        }
        private void bubbleSort(int[] arr)
        {
            
            int n = arr.Length-1;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
            
        }

        private void listingScores()
        {

            label3.Text = scores[4].ToString();
            label4.Text = scores[3].ToString();
            label5.Text = scores[2].ToString();
            label6.Text = scores[1].ToString();
            label7.Text = scores[0].ToString();
            
            
        }



        private void button7_Click(object sender, EventArgs e)
        {
            connect multiplayer = new connect();
            multiplayer.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
        }
        
        private void score()
        {
            int i = 0; 
            int j = 0, 
                counterX = 0, 
                counterY = 0, 
                tempI = 0, 
                tempJ = 0;
            for (i = 0; i < x; i++)
            {
                for (j = 0; j < y; j++)
                {
                    tempJ = j;
                    if (j<y-1)
                    {
                        if (buttons[i, j].BackgroundImage != null)
                        {
                            if ((buttons[i, j].ImageIndex == buttons[i , j+1].ImageIndex) && (buttons[i, j].BackColor == buttons[i, j+1].BackColor))
                            {
                                while ((buttons[i, j].ImageIndex == buttons[i, j+1].ImageIndex) && (buttons[i, j].BackColor == buttons[i, j + 1].BackColor))
                                {
                                    j++;
                                    counterY++;
                                    if (j == y - 1)
                                    {
                                        break;
                                    }
                                }
                                if (counterY >= 2)
                                {
                                    j = Math.Abs(j - counterY);
                                    for (int a = i; a < i + 1; a++)
                                    {
                                        for (int b = j; b<=j+counterY; b++)
                                        {
                                            buttons[a, b].BackColor = DefaultBackColor;
                                            buttons[a, b].BackgroundImage = null;
                                            point++;
                                            soundEffect4();
                                            //MessageBox.Show(" MATCHED!!");
                                            isOver();
                                            score();
                                          
                                        }
                                    }
                                }
                                counterY =0;
                                j = tempJ;
                            }
                        }
                        
                    }
                }
            }
            for (i = 0; i < x; i++)
            {
                for (j = 0; j < y; j++)
                {
                    tempI = i;
                    if (i < x - 1)
                    {
                        if (buttons[i, j].BackgroundImage != null)
                        {
                            if ((buttons[i,j].ImageIndex==buttons[i+1,j].ImageIndex) && (buttons[i, j].BackColor == buttons[i+1, j].BackColor))
                            {
                                while ((buttons[i, j].ImageIndex == buttons[i + 1, j].ImageIndex) && (buttons[i, j].BackColor == buttons[i+1, j].BackColor))
                                {
                                    i++;
                                    counterX++;
                                    if (i == x - 1)
                                    {
                                        break;
                                    }
                                }
                                if (counterX >= 2)
                                {
                                    i = Math.Abs(i - counterX);
                                    for (int a = i; a <= i+counterX; a++)
                                    {
                                        for (int b = j; b < j+1; b++)
                                        {
                                            buttons[a, b].BackColor = DefaultBackColor;
                                            buttons[a, b].BackgroundImage = null;
                                            point++;
                                            soundEffect4();
                                            //MessageBox.Show(" MATCHED!!");
                                            isOver();
                                            score();
                                            
                                        }
                                    }
                                }
                                counterX = 0;
                                i = tempI;
                            }
                        }
                    }
                }
            }
            pointSum += point;
            point = 0;
        }
        //private void freezeButtons()
        //{
        //    for(int a=0; a<x; a++)
        //    {
        //        for(int b=0; b<y; b++)
        //        {
        //            buttons[a, b].Enabled = false;
        //        }
        //    }
        //}
        //private void unFreezeButtons()
        //{
        //    for (int a = 0; a < x; a++)
        //    {
        //        for (int b = 0; b < y; b++)
        //        {
        //            if (buttons[a, b].BackgroundImage == null) 
        //            {
        //                buttons[a, b].Enabled = true;
        //            }
                    
        //        }
        //    }
        //}
      
        //private void ReceiveMove()
        //{
        //    byte[] buffer = new byte[1];
        //    sock.Receive(buffer);
        //    if (buffer[0] == 1)
        //    {
        //        for(int a=0; a<x; a++)
        //        {
        //            for(int b=0; b<y; b++)
        //            {
        //                buttons[a, b].BackColor = opponentBackColor;
        //                buttons[a, b].BackgroundImage = opponentBackImage;
        //            }
        //        }
        //    }
        //}
        
    }
}


