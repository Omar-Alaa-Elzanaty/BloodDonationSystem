using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;

namespace BloodDonationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account user = Login.createuser(textBox1.Text, textBox2.Text);
            if (user is Person)
            {
                this.Visible = false;
                Form4 form4 = new Form4((Person)user);
                form4.Show();
            }
            else if (user is Organization)
            {
                this.Visible = false;
                Form5 form5 = new Form5((Organization)user);
                form5.Show();
            }
            else
            {
                MessageBox.Show("please Enter your username and password again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 form3= new Form3();
            form3.Show();
        }
    }
}