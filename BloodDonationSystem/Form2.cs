using System;
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
            comboBox1.DataSource = new List<string>() { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" };
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account person = new Person(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,comboBox1.Text);
            if (person.runsignup() == false)
            {
                MessageBox.Show("invalid Sign up operation....\n, please try again");
            }
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
