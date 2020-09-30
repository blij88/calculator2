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

        List<string> calcItems = new List<string> {"first" };
        bool Euro = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }     
              
        // isolate content of final item in calItems, change it so the new number is appended
        private void button1_Click(object sender, EventArgs e)
        {
            createNumbieArray("1");
            DisplayNumbers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createNumbieArray("2");
            DisplayNumbers();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            createNumbieArray("0");
            DisplayNumbers();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            createNumbieArray("9");
            DisplayNumbers();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            createNumbieArray("8");
            DisplayNumbers();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            createNumbieArray("7");
            DisplayNumbers();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            createNumbieArray("6");
            DisplayNumbers();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            createNumbieArray("5");
            DisplayNumbers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            createNumbieArray("4");
            DisplayNumbers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            createNumbieArray("3");
            DisplayNumbers();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            List<float> theNumbers = new List<float> { };
            List<string> theMutations = new List<string> { };
            float product = float.Parse(calcItems.First());
            foreach (var item in calcItems)
            {
                if (calcItems.IndexOf(item)%2 == 0)
                {
                    theNumbers.Add(float.Parse(item));
                }
                else
                {
                    theMutations.Add(item);
                }
            }
            foreach (var item in theMutations)
            {

                if (item == "*")
                {
                    product = times(product, theNumbers[theMutations.IndexOf(item)+1]);
                }
                else if (item == "/")
                {
                    product = div(product, theNumbers[theMutations.IndexOf(item) + 1]);
                }
            }
            foreach (var item in theMutations)
            {
                if (item == "-")
                {
                    product = Minus(product, theNumbers[theMutations.IndexOf(item) + 1]);
                }
                else if (item == "+")
                {
                    product = add(product, theNumbers[theMutations.IndexOf(item) + 1]);
                }
            }
            richTextBox1.Text = product.ToString();
        }

        // the different mutation calculations

        public float times(float product, float numOne)
        {
            return product * numOne;
        }
        public float div(float product, float numOne)
        {
            return product / numOne;
        }
        public float Minus(float product, float numOne)
        {
            return product - numOne;
        }
        public float add(float product, float numOne)
        {
            return product + numOne;
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
            calcItems.Add("first");
            richTextBox1.Clear();
        }

        private void division_Click(object sender, EventArgs e)
        {
            CanBeProcessed("/");
        }

        private void product_Click(object sender, EventArgs e)
        {
            CanBeProcessed("*");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            CanBeProcessed("-");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            CanBeProcessed("+");
        }

        // creates a new array item depending on what mutation was requested
        public void CanBeProcessed( string Count)
        {
            if (calcItems.Last() != "first")
            {
                calcItems.Add(Count);
                calcItems.Add("first");
            }
        }
        // when a number is pressed changes the last item in the array to reflect that
        public void createNumbieArray(string numbie)
        {
            if (calcItems.Last() == "first")
            {
                calcItems[calcItems.FindLastIndex(ind => ind.Equals(calcItems.Last()))] =  numbie;
            }
            else
            {
                calcItems[calcItems.FindLastIndex(ind => ind.Equals(calcItems.Last()))] = calcItems.Last() + numbie;
            }
        }

        // how to properly display all the information

        public void DisplayNumbers()
        {
            if (calcItems.LongCount() == 1)
            {
                richTextBox1.Text = calcItems.Last();
            }
            else
            {
                richTextBox1.Text = calcItems.Last() + "\n";
                calcItems.Reverse();
                for (int i = 2; i < calcItems.LongCount(); i++)
                {
                    richTextBox1.Text += calcItems[i] + " ";
                }
                calcItems.Reverse();
            }
        }

    }
}
