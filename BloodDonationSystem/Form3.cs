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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account organization = new Organization(textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text,textBox5.Text);
            if (organization.runsignup()==true)
            {
                this.Visible = false;
                Form1 form1 = new Form1();
                form1.Show();
                return;
            }
            MessageBox.Show("invalid Sign up operation....\n, please try again");
            
        }
    }
}
