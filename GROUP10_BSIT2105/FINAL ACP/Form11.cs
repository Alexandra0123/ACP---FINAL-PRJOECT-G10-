using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACP_proj
{
    public partial class Form11 : Form
    {
          MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
        public Form11()
        {
            InitializeComponent();
            button2.Visible = false;
            textBox1.Multiline = true;
            string combine = Form2.text1 + Form3.text1 + Form4.text1 + Form5.text1 
            + Form6.text1 + Form7.text1 + Form8.text1 + Form9.text1 + Form10.text1 + Form1.text1;
            textBox1.Text = combine;
           
        }


        private void insert()
        {
            try
            {
                connection.Open();

                string insertQuery = "INSERT INTO big_brew.orderHistory (customer, orders, order_date) VALUES (@customer, @orders, @order_date)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@customer", Form1.text1);
                    cmd.Parameters.AddWithValue("@orders", textBox1.Text);
                    cmd.Parameters.AddWithValue("@order_date", DateTime.Now.Date);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order saved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save order.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            insert();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            button1.Enabled = false;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            string textToPrint =
                         "              BIG BREW PHILIPPINES \n" 
                        +"    Poblacion East Alitagtag Batangas  \n"
                        +"    Phone number: 0911-111-111  \n" +
                        "-------------------------------------------------------------------\n" +
                        "------       O F F I C I A L   R E C E I P T        ------\n" +
                        "-------------------------------------------------------------------\n" +
                        "\n" + "\n" +
                        "---------            Items  //  Quantity           ---------\n" +
                        $"{textBox1.Text}" 
                        + "\n" + "\n" + "\n" + "\n" + "\n" + "\n"
                        + "===================================\n" +"\n" 
                        + "DATE  :___________________________\n" + 
                        "GUESS COUNT :___________________\n" + "ORDER #:_________________________\n" + "\n" 
                        + "-------------------------------------------------------------------\n"
                        + "-------------------------------------------------------------------\n"
                        + "             -THANK YOU FOR BUYING!!!-             " +
                        "\n" + "THIS SERVES AS YOUR OFFICIAL RECEIPT \n"
                           + "-------------------------------------------------------------------\n"
                        + "-------------------------------------------------------------------\n"; 


            Font font = new Font("Candara", 13.8f, FontStyle.Regular);
            Brush brush = Brushes.Black;
            PointF point = new PointF(20, 20);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near; // Set to Near for left alignment

            e.Graphics.DrawString(textToPrint, font, brush, point, format);
          
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
