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
        Random rs = new Random();
        public Form1()
        {
            InitializeComponent();


            counttimer();
            MathRandom();
           
        }

        int duration = 0;
        ArrayList array = new ArrayList();
        ArrayList array2 = new ArrayList();

        string arr = "";

        private void MathRandom()
        {

            do
            {




                int com = rs.Next(10);

                int indexvalue = arr.IndexOf(com.ToString());

                if (indexvalue == -1)
                {
                    arr += com;
                    array.Add(com);
                }


            } while (array.Count < 3);




        }


        private void Shuffle()
        {

            
            count = 0;
            textBox1.Text = "";
            arr = "";
            duration = 0;
            answerB.Text = "정답은";

            nbtn0.Enabled = true;
            nBtn1.Enabled = true;
            nBtn2.Enabled = true;
            nBtn3.Enabled = true;
            nBtn4.Enabled = true;
            nBtn5.Enabled = true;
            nBtn6.Enabled = true;
            nBtn7.Enabled = true;
            nBtn8.Enabled = true;
            nBtn9.Enabled = true;
            listBox1.Items.Clear();
            do
            {




                int com = rs.Next(10);

                int indexvalue = arr.IndexOf(com.ToString());

                if (indexvalue == -1)
                {

                    arr += com;
                    array2.Add(com);

                }


            } while (array2.Count < 3);
        }

        private void counttimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 150;
            timer1.Start();
            textBox1.MaxLength = 3;
        }
        private void count_down(object sender, EventArgs e)
        {

            if (duration == 2000)
            {
                timer1.Stop();
                MessageBox.Show("Game over");

            }


            else
            {
                duration++;
                label1.Text = duration.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            nBtn1.Enabled = false;
        }

        int count = 0;
        private void subB_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.Length > 3)
            {
                MessageBox.Show("3개만 입력해주세요");
                textBox1.Text = "";
                return;
            }

            count++;
            if (arr == textBox1.Text)
            {
                MessageBox.Show("정답을 맞혔습니다");
                Shuffle();

            }

            else if (textBox1.Text == "" || textBox1.Text.Length<3)
            {
                MessageBox.Show("값을 제대로 적어 주세요");
                return;

            }

            else
            {

                
                
                char[] aor;
                aor = new char[] { arr[0], arr[1], arr[2] };

                int strike = 0;
                int ball = 0;

                nbtn0.Enabled = true;
                nBtn1.Enabled = true;
                nBtn2.Enabled = true;
                nBtn3.Enabled = true;
                nBtn4.Enabled = true;
                nBtn5.Enabled = true;
                nBtn6.Enabled = true;
                nBtn7.Enabled = true;
                nBtn8.Enabled = true;
                nBtn9.Enabled = true;
                for (int j = 0; j < textBox1.Text.Length; j++)
                {
                    int num = Array.IndexOf(aor, textBox1.Text[j]);
                    if (num != -1)
                    {
                        if (arr[j] == textBox1.Text[j])
                        {
                            strike++;
                        }
                        else
                        {

                            ball++;
                        }
                    }


                }

                if (ball == 0 && strike == 0)
                {

                    MessageBox.Show("OUT");

                    nbtn0.Enabled = true;
                    nBtn1.Enabled = true;
                    nBtn2.Enabled = true;
                    nBtn3.Enabled = true;
                    nBtn4.Enabled = true;
                    nBtn5.Enabled = true;
                    nBtn6.Enabled = true;
                    nBtn7.Enabled = true;
                    nBtn8.Enabled = true;
                    nBtn9.Enabled = true;

                }

                MessageBox.Show("오답입니다." + "\n" + "스트라이크:" + strike + "\n" + "볼:" + ball);
                listBox1.Items.Add("[" + textBox1.Text + "]" + strike + "S" + ball + "B");
                textBox1.Text = "";
                Button[] btn = new Button[] { nbtn0, nBtn1, nBtn2, nBtn3, nBtn4, nBtn5, nBtn6, nBtn7, nBtn8, nBtn9 };
              




                if (count == 3)
                {
                    int checkNum = rs.Next(10);
                    
                    string[] aor1 = new string[] { arr[0].ToString(), arr[1].ToString(),arr[2].ToString() };

                    int detect = Array.IndexOf(aor1,checkNum.ToString());

                    
                    while (detect != -1)
                    {

                        checkNum = rs.Next(10);
                        detect = Array.IndexOf(aor, checkNum+"");

                    }

                    
                    btn[checkNum].Visible = false;
                }
                else if (count == 5)
                {
                    int checkNum = rs.Next(10);

                    string[] aor1 = new string[] { arr[0].ToString(), arr[1].ToString(), arr[2].ToString() };

                    int detect = Array.IndexOf(aor1, checkNum.ToString());


                    while (detect != -1)
                    {

                        checkNum = rs.Next(10);
                        detect = Array.IndexOf(aor, checkNum + "");

                    }


                    btn[checkNum].Visible = false;

                }
                else if (count == 7)
                {
                    int checkNum = rs.Next(10);

                    string[] aor1 = new string[] { arr[0].ToString(), arr[1].ToString(), arr[2].ToString() };

                    int detect = Array.IndexOf(aor1, checkNum.ToString());


                    while (detect != -1)
                    {

                        checkNum = rs.Next(10);
                        detect = Array.IndexOf(aor, checkNum + "");

                    }


                    btn[checkNum].Visible = false;

                }
                else if (count == 8)
                {
                    int checkNum = rs.Next(10);

                    string[] aor1 = new string[] { arr[0].ToString(), arr[1].ToString(), arr[2].ToString() };

                    int detect = Array.IndexOf(aor1, checkNum.ToString());


                    while (detect != -1)
                    {

                        checkNum = rs.Next(10);
                        detect = Array.IndexOf(aor, checkNum + "");

                    }


                    btn[checkNum].Visible = false;

                }

                if (count >= 9)
                {
                    MessageBox.Show("Game over"+"\n"+"정답은"+arr+"입니다");
                    Shuffle();
                }
               
            }
            /*int a= (int)array[0];
            int b=(int)
            MessageBox.Show(a.ToString());*/

        }


        private void nBtn2_Click(object sender, EventArgs e)
        {

            textBox1.Text += "2";
            nBtn2.Enabled = false;
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
            nbtn0.Enabled = true;
            nBtn1.Enabled = true;
            nBtn2.Enabled = true;
            nBtn3.Enabled = true;
            nBtn4.Enabled = true;
            nBtn5.Enabled = true;
            nBtn6.Enabled = true;
            nBtn7.Enabled = true;
            nBtn8.Enabled = true;
            nBtn9.Enabled = true;


        }

        private void answerB_Click(object sender, EventArgs e)
        {
            array2.Clear();
            answerB.Text = "정답은" + arr;
        }

        private void nBtn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            nbtn0.Enabled = false;
        }

        private void nBtn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            nBtn9.Enabled = false;
        }
    }
}
