﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12or1x
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //await Task.Run(() => 
            label1.Text = gennumbers.genMyDigits();
            label2.Text = gennumbers.genCheckedDigits();
           /* Parallel.Invoke(

                );
                */

        }
    }
}
    
