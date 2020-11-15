using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HappyTech
{
    public partial class Form3 : Form
    {
        public static string SetValueText1 = "";
        public static string SetValueText2 = "";
        public static string SetValueText3 = "";
        public static string SetValueText4 = "";
        public Form3()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                //SqlConnection feedb = new SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HappyTechData.mdf;Integrated Security=True");
            
                //feedb.Open();

                //SqlCommand feedb1 = new SqlCommand("Insert feedback =@Feedback_Name", feedb);

                //int i = feedb1.ExecuteNonQuery();
                //if(i!=0)
                //{
                //    MessageBox.Show("Saved");
                //}
                //else
                //{
                //    MessageBox.Show("Please enter a feedback");
                //}

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SetValueText1 = textBox1.Text;
            }
            if (checkBox5.Checked)
            {
                SetValueText2 = textBox2.Text;
            }
            if (checkBox2.Checked)
            {
                SetValueText3 = textBox3.Text;
            }
            if (checkBox3.Checked)
            {
                SetValueText4 = textBox4.Text;
            }
            Form4 f4 = new Form4();
            f4.Show();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
        }
    }
}
