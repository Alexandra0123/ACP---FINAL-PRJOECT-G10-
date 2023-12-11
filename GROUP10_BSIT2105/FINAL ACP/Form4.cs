using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ACP_proj
{
    public partial class Form4 : Form
    {
        public static string text1;
        private bool button1Clicked = false;
        private bool button2Clicked = false;
        private bool button3Clicked = false;
        private bool button4Clicked = false;
        private bool button5Clicked = false;
        private bool button6Clicked = false;
        private bool button7Clicked = false;
        private bool button8Clicked = false;
        private bool button9Clicked = false;
        private bool button10Clicked = false;
        private bool button11Clicked = false;
      
        public Form4()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
         

        }
        
       

        private void label10_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {

            if (!button4Clicked)
            {
                if (int.TryParse(textBox4.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label4.Text + "   " + textBox4.Text + "x" + Environment.NewLine;
                    button4Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox4.Clear();
                }
            }
            button4Clicked = true;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button4.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (!button5Clicked)
            {
                if (int.TryParse(textBox5.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label5.Text + "   " + textBox5.Text + "x" + Environment.NewLine;
                    button5Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox5.Clear();
                }
            }
            button5Clicked = true;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox5.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button5.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button5.Enabled = false;
            }
        }
            private void button6_Click(object sender, EventArgs e)
        {

            if (!button6Clicked)
            {
                if (int.TryParse(textBox6.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label6.Text + "   " + textBox6.Text + "x" + Environment.NewLine;
                    button6Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox14.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox6.Clear();
                }
            }
            button6Clicked = true;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox6.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button6.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (!button7Clicked)
            {
                if (int.TryParse(textBox7.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label7.Text + "   " + textBox7.Text + "x" + Environment.NewLine;
                    button7Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox7.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the textbox
                    textBox7.Clear();
                }
            }
            button7Clicked = true;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox7.Text, out _))
            {
                // The content of textBox14 can be parsed into an integer
                button7.Enabled = true;
            }
            else
            {
                // The content of textBox14 is not a valid integer
                button7.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (!button8Clicked)
            {
                if (int.TryParse(textBox8.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label8.Text + "   " + textBox8.Text + "x" + Environment.NewLine;
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (!button9Clicked)
            {
                if (int.TryParse(textBox9.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label9.Text + "   " + textBox9.Text + "x" + Environment.NewLine;
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

        private void button10_Click(object sender, EventArgs e)
        {

            if (!button10Clicked)
            {
                if (int.TryParse(textBox10.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label10.Text + "   " + textBox10.Text + "x" + Environment.NewLine;
                    button10Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox14.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void button11_Click(object sender, EventArgs e)
        {

            if (!button11Clicked)
            {
                if (int.TryParse(textBox11.Text, out _))
                {
                    // The content of textBox14 can be parsed into an integer
                    text1 += label11.Text + "   " + textBox11.Text + "x" + Environment.NewLine;
                    button11Clicked = true; // Set the flag to true after the first click
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Please enter a valid integer in textBox11.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
