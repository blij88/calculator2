using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        List<string> calcItems = new List<string> { };
        bool Euro = false;

        private void Form1_Load(object sender, EventArgs e)
        {
        }        
        
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 2;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 9;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 3;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            
        }

        private void euro_Click(object sender, EventArgs e)
        {
            if (Euro == false)
            {
                Euro = true;
                euro.BackColor = Color.Black;
                euro.ForeColor = Color.White;
            }
            else
            {
                Euro = false;
                euro.BackColor = Color.Gainsboro;
                euro.ForeColor = Color.Black;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            calcItems.Clear();
            richTextBox1.Clear();
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                calcItems.Add(richTextBox1.Text);
                calcItems.Add("1");
            }
        }

        private void product_Click(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {

        }
    }
}
