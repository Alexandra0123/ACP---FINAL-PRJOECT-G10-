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
    public partial class Form10 : Form
    {
        public static string text1;
        private bool button1Clicked = false;
        private bool button2Clicked = false;
        private bool button3Clicked = false;
        public Form10()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!button1Clicked)
            {
                if (int.TryParse(textBox1.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label1.Text + "   " + textBox1.Text + "x" + Environment.NewLine;
                    button1Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox14.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox1.Clear();
                }
            }
            button1Clicked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button1.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!button2Clicked)
            {
                if (int.TryParse(textBox2.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label2.Text + "   " + textBox2.Text + "x" + Environment.NewLine;
                    button2Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox2.Clear();
                }
            }
            button2Clicked = true;
        
    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button2.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!button3Clicked)
            {
                if (int.TryParse(textBox3.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label3.Text + "   " + textBox3.Text + "x" + Environment.NewLine;
                    button3Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox3.Clear();
                }
            }
            button3Clicked = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button3.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button3.Enabled = false;
            }
        }
    }
}
