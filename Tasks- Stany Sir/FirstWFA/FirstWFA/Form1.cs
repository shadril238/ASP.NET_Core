using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Exit Application
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            lbl1.Text = "You typed: " + txt1.Text; //Whatever typing in TextBox, will automatically change the label
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            lbl2.Text = "You typed: " + txt2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int x1= Int32.Parse(txt1.Text);
            int x2= Int32.Parse(txt2.Text);
            int sum = x1 + x2;
            lbl3.Text = "Sum = " + sum;//When button clicked, the label is also changed
            MessageBox.Show("Sum = " + sum);
        }

        
    }
}
