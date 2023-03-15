using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPractice
{
    public partial class Form1 : Form
    {
        string first = "";
        string last = "";

        public Form1()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.first = firstName.Text;
        }

     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.last = lastName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Greetings! " + first + " " + last, "Display", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
