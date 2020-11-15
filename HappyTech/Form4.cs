using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = Form2.SetValueForText1;
            label2.Text = Form2.SetValueForText2;
            label3.Text = Form2.SetValueForText3;
            label4.Text = Form3.SetValueText1;
            label5.Text = Form3.SetValueText2;
            label6.Text = Form3.SetValueText3;
            label7.Text = Form3.SetValueText4;

        }
    }
}
