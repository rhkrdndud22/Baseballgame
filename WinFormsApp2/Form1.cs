using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 150;
            timer1.Start();
            textBox1.MaxLength = 3;
        }

        int duration = 0;

        private void count_down(object sender, EventArgs e)
        {

            if (duration == 2000)
            {
                timer1.Stop();

            }
            else
            {
                duration++;
                label1.Text = duration.ToString();
            }
        }
        private bool _isProcessing;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            nBtn1.Enabled = false;
        }
        

        private void subB_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
        }

        private void nBtn2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "2";
            nBtn1.Enabled = false;
        }
        private void nBtn3_Click(object sender, EventArgs e)
        {

            textBox1.Text += "3";
            nBtn3.Enabled = false;
        }
        private void nBtn4_Click(object sender, EventArgs e)
        {

            textBox1.Text += "4";
            nBtn4.Enabled = false;
        }
        private void nBtn5_Click(object sender, EventArgs e)
        {

            textBox1.Text += "5";
            nBtn5.Enabled = false;
        }
        private void nBtn6_Click(object sender, EventArgs e)
        {

            textBox1.Text += "6";
            nBtn6.Enabled = false;
        }
        private void nBtn7_Click(object sender, EventArgs e)
        {

            textBox1.Text += "7";
            nBtn7.Enabled = false;
        }
        private void nBtn8_Click(object sender, EventArgs e)
        {

            textBox1.Text += "8";
            nBtn8.Enabled = false;
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            nBtn1.Enabled = true;
            nBtn2.Enabled = true;
            nBtn3.Enabled = true;
            nBtn4.Enabled = true;
            nBtn5.Enabled = true;
            nBtn6.Enabled = true;
            nBtn7.Enabled = true;
            nBtn8.Enabled = true;
           

        }

        private void n(object sender, EventArgs e)
        {

        }
    }
}
