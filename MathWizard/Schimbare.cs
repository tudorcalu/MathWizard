﻿using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manigu
{
    public partial class Schimbare : UserControl
    {
        public Schimbare()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.kind = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.kind = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.kind = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.kind = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.kind = 4;
        }
    }
}
