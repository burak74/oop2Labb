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
using System.Net;
using System.IO;
using System.Text.Json.Serialization;

namespace oopPreLab2SON
{
    public partial class multiplayerGame : Form
    {
        public multiplayerGame(bool isHost, IPAddress ip)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if (isHost)
            {
                //serverBackColor=first.BackColor;
                //serverBackImage = first.BackgroundImage;
                server = new TcpListener(IPAddress.Loopback, 0);
                server.Start();
                sock = server.AcceptSocket();
            }
            else
            {
                //clientBackColor = serverBackColor;
                //clientBackImage = serverBackImage;
                try
                {
                    client = new TcpClient(ip.ToString(), 0);
                    sock = client.Client;
                    MessageReceiver.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;

        static int serverPortNum = Properties.Settings.Default.port;


        //private void client()
        //{
        //IPEndPoint clientEndPoint = new System.Net.IPEndPoint(IPAddress.Loopback, 445);
        //Socket clientSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        //clientSocket.Bind(clientEndPoint);

        //IPEndPoint serverEndPoint = new System.Net.IPEndPoint(IPAddress.Loopback, 445);
        //try
        //{
        //    clientSocket.Connect(serverEndPoint);
        //}
        //catch(Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //    Close();
        //}


        //byte[] bytesToSend=ObjectToByteArray(yourBackColor);
        //clientSocket.Send(bytesToSend);

        //byte[] buffer = new byte[1024];
        //int numberOfBytesReceived = clientSocket.Receive(buffer);
        //byte[] receivedBytes = new byte[numberOfBytesReceived];
        //Array.Copy(buffer, receivedBytes, numberOfBytesReceived);
        //yourBackColor=(Color)ByteArrayToObject(receivedBytes);
        //}

        //private void server() 
        //{
        //    IPEndPoint serverEndPoint = new System.Net.IPEndPoint(IPAddress.Parse("127.0.0.1"), 50128);
        //    Socket welcomingSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        //    welcomingSocket.Bind(serverEndPoint);
        //    welcomingSocket.Listen();

        //    Socket connectionSocket = welcomingSocket.Accept();


        //    byte[] buffer = new byte[1024];
        //    int numberOfBytesReceived = connectionSocket.Receive(buffer);
        //    byte[] receivedBytes = new byte[numberOfBytesReceived];
        //    Array.Copy(buffer, receivedBytes, numberOfBytesReceived);

        //    yourBackColor = (Color)ByteArrayToObject(receivedBytes);

        //}
        
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public Image byteArrayImageDonustur(byte[] byteDizisi)
        {
            using (MemoryStream ms = new MemoryStream(byteDizisi))
            {
                return Image.FromStream(ms);
            }
        }

        Random rndm = new Random();

   

        int a, b, c, d;

        int point = 0;
        int randomCounter = x * y;

        Button first, temp;


        public static int x = 9;
        public static int y = 9;

        Button[,] buttons = new Button[x, y];

        int left = 0;
        int top = 5;

        public static Color color1, color2, color3;
        Color[] colors = new Color[3];

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

        private void multiplayerGame_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                buttons[a, b].BackColor = colors[d];
            }
        }

        private void multiplayerGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageReceiver.WorkerSupportsCancellation = true;
            MessageReceiver.CancelAsync();
            if (server != null)
            {
                server.Stop();
            }
        }

        //private void freezeButtons()
        //{
        //    for (int a = 0; a < x; a++)
        //    {
        //        for (int b = 0; b < y; b++)
        //        {
        //            buttons[a, b].Enabled = false;
        //        }
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 settings = new Form3();
            settings.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Environment.Exit(0);        
        }

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
        //        for (int a = 0; a < x; a++)
        //        {
        //            for (int b = 0; b < y; b++)
        //            {
        //                buttons[a, b].BackColor = opponentBackColor;
        //                buttons[a, b].BackgroundImage = opponentBackImage;
        //            }
        //        }
        //    }
        //}

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
                    if (j < y - 1)
                    {
                        if (buttons[i, j].BackgroundImage != null)
                        {
                            if ((buttons[i, j].ImageIndex == buttons[i, j + 1].ImageIndex) && (buttons[i, j].BackColor == buttons[i, j + 1].BackColor))
                            {
                                while ((buttons[i, j].ImageIndex == buttons[i, j + 1].ImageIndex) && (buttons[i, j].BackColor == buttons[i, j + 1].BackColor))
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
                                        for (int b = j; b <= j + counterY; b++)
                                        {
                                            buttons[a, b].BackColor = DefaultBackColor;
                                            buttons[a, b].BackgroundImage = null;
                                            point++;
                                            MessageBox.Show(point.ToString() + " POINT!!");
                                        }
                                    }
                                }
                                point = 0;
                                counterY = 0;
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
                            if ((buttons[i, j].ImageIndex == buttons[i + 1, j].ImageIndex) && (buttons[i, j].BackColor == buttons[i + 1, j].BackColor))
                            {
                                while ((buttons[i, j].ImageIndex == buttons[i + 1, j].ImageIndex) && (buttons[i, j].BackColor == buttons[i + 1, j].BackColor))
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
                                    for (int a = i; a <= i + counterX; a++)
                                    {
                                        for (int b = j; b < j + 1; b++)
                                        {
                                            buttons[a, b].BackColor = DefaultBackColor;
                                            buttons[a, b].BackgroundImage = null;
                                            point++;
                                            MessageBox.Show(point.ToString() + " POINT!!");
                                        }
                                    }
                                }
                                point = 0;
                                counterX = 0;
                                i = tempI;
                            }
                        }
                    }
                }
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
                buttons[a, b].BackColor = colors[d];
            }
        }

        private void buton_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            first = btn;



            if (first.BackgroundImage != null)
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
                    sock.Send(ImageToByte(ımageList1.Images[0]));
                    MessageReceiver.RunWorkerAsync();
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
                        MessageBox.Show("GAME OVER");
                    }

                    score();
                }
            }
            randomCounter = x * y;
        }
    }
}
