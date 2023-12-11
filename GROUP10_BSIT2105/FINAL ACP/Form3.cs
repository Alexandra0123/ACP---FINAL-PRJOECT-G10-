using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACP_proj
{
    public partial class Form3 : Form
    {
        public static string text1;
        private bool button14Clicked = false;
        private bool button13Clicked = false;
        private bool button12Clicked = false;
        private bool button11Clicked = false;
        private bool button10Clicked = false;
        private bool button9Clicked = false;
        private bool button8Clicked = false;

        public Form3()
        {
            InitializeComponent();
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
        
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!button14Clicked)
            {
                if (int.TryParse(textBox14.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label1.Text + "   " + textBox14.Text + "x" + Environment.NewLine;
                    button14Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox14.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox14.Clear();
                }
            }
            button14Clicked = true;
            
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(textBox14.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button14.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button14.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!button13Clicked)
            {
                if (int.TryParse(textBox13.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label2.Text + "   " + textBox13.Text + "x" + Environment.NewLine;
                    button13Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox13.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox13.Clear();
                }
            }
            button13Clicked = true;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(textBox13.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button13.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button13.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!button12Clicked)
            {
                if (int.TryParse(textBox14.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label3.Text + "   " + textBox12.Text + "x" + Environment.NewLine;
                    button12Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox12.Clear();
                }
            }
            button12Clicked = true;

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox12.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button12.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button12.Enabled = false;
            }
        }
    

        private void button11_Click(object sender, EventArgs e)
        {
            if (!button11Clicked)
            {
                if (int.TryParse(textBox11.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label4.Text + "   " + textBox11.Text + "x" + Environment.NewLine;
                    button11Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox14.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox11.Clear();
                }
            }
            button11Clicked = true;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox11.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button11.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button11.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!button10Clicked)
            {
                if (int.TryParse(textBox10.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label5.Text + "   " + textBox10.Text + "x" + Environment.NewLine;
                    button10Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox10.Clear();
                }
            }
            button10Clicked = true;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox10.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button10.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button10.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!button9Clicked)
            {
                if (int.TryParse(textBox9.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label6.Text + "   " + textBox9.Text + "x" + Environment.NewLine;
                    button9Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox9.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox9.Clear();
                }
            }
            button9Clicked = true;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox9.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button9.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button9.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!button8Clicked)
            {
                if (int.TryParse(textBox8.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label7.Text + "   " + textBox8.Text + "x" + Environment.NewLine;
                    button8Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox14.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox8.Clear();
                }
            }
            button8Clicked = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox8.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button8.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button8.Enabled = false;
            }
        }
    }
}
