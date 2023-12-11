
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
    public partial class Form1 : Form
    {
        public static string text1;
        private bool button1Clicked = false;
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            text1 = string.Empty;
        }
        bool menuExpand = false;

        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 171)
                {
                    MenuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 55)
                {
                    MenuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void Iced_cofee_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
        }
        private void MenuTransition2_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer2.Height += 10;
                if (menuContainer2.Height >= 171)
                {
                    MenuTransition2.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer2.Height -= 10;
                if (menuContainer2.Height <= 55)
                {
                    MenuTransition2.Stop();
                    menuExpand = false;
                }
            }
        }

        private void praf_Click(object sender, EventArgs e)
        {
            MenuTransition2.Start();
        }

        private void MenuTransition3_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer3.Height += 10;
                if (menuContainer3.Height >= 171)
                {
                    MenuTransition3.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer3.Height -= 10;
                if (menuContainer3.Height <= 55)
                {
                    MenuTransition3.Stop();
                    menuExpand = false;
                }
            }
        }

        private void milk_tea_Click(object sender, EventArgs e)
        {
            MenuTransition3.Start();
        }

        private void MenuTransition4_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer4.Height += 10;
                if (menuContainer4.Height >= 171)
                {
                    MenuTransition4.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer4.Height -= 10;
                if (menuContainer4.Height <= 55)
                {
                    MenuTransition4.Stop();
                    menuExpand = false;
                }
            }
        }

        private void fruit_tea_Click(object sender, EventArgs e)
        {
            MenuTransition4.Start();
        }

        private void MenuTransition5_Tick(object sender, EventArgs e)
        {
            {
                if (menuExpand == false)
                {
                    menuContainer5.Height += 10;
                    if (menuContainer5.Height >= 171)
                    {
                        MenuTransition5.Stop();
                        menuExpand = true;
                    }
                }
                else
                {
                    menuContainer5.Height -= 10;
                    if (menuContainer5.Height <= 55)
                    {
                        MenuTransition5.Stop();
                        menuExpand = false;
                    }
                }
            }
        }

        private void snacks_Click(object sender, EventArgs e)
        {
            MenuTransition5.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.TopLevel = false;
            mainpanel.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.TopLevel = false;
            mainpanel.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.TopLevel = false;
            mainpanel.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.TopLevel = false;
            mainpanel.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.TopLevel = false;
            mainpanel.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.TopLevel = false;
            mainpanel.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.TopLevel = false;
            mainpanel.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 newForm = new Form9();
            newForm.TopLevel = false;
            mainpanel.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.TopLevel = false;
            mainpanel.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }
       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!button1Clicked)
            {
                text1 += "Customer Name: " + textBox1.Text + Environment.NewLine;
                button1Clicked = true; // Set the flag to true after the first click
                Form11 form11 = new Form11();
                form11.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                button1.Enabled = true;
            }
        }
    }
}

