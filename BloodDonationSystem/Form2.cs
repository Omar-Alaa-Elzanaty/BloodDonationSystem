﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonationSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.DataSource=new List<string>() { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" };
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}