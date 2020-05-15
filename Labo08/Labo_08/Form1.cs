﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_08_UCandTL
{
    public partial class Form1 : Form
    {

        private UserControl current;
        private Register rg = new Register();
        public Form1()
        {
            InitializeComponent();
            current = login1;
            DoubleBuffered = true;
        }

        private void Login_Click(object sender, EventArgs e)
        {
             tableLayoutPanel1.Controls.Remove(current);
             tableLayoutPanel1.Controls.Add(login1,1,0 );
             current = login1;
             tableLayoutPanel1.SetRowSpan(current,4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(rg,1,0 );
            current = rg;
            tableLayoutPanel1.SetRowSpan(current,4);
        }
    }
}