﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using System.Threading;
using DTO;

namespace PresentationLayer
{
    public partial class HovedGUI : Form
    {
        private BL currentBL;
        private Data CurrentDTO;

        public HovedGUI(BL myBL)
        {
            currentBL = myBL;
            InitializeComponent();
        }

        private void HovedGUI_Load(object sender, EventArgs e)
        {

        }

        private void HovedGUI_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double local = CurrentDTO.AFTryk;
            textBox1.Text = Convert.ToString(local);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
