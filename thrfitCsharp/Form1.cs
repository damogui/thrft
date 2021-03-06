﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using thrfitCsharp.My;

namespace thrfitCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                new HelloWorldServiceClient().startClient(textBox1.Text.Trim());
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Thread oThread = new Thread(new ThreadStart(new HelloWorldServer().startServer));
            //oThread.Start();

            Thread oThread = new Thread(new ThreadStart(new ThreadStart(new BlogServer().StartServer)));
            oThread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BlogClient().startClient();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(new ThreadStart(new BlogServer().StartServer)));//c#服务端
            thread.Start();
        }

        private void btnServerOpen_Click(object sender, EventArgs e)
        {
            Thread oThread = new Thread(new ThreadStart(new ThreadStart(new BookServer().StartServer)));
            oThread.Start();
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            new BookClient().startClient();
        }
    }
}
