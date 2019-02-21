using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{

    public partial class Form1 : Form
    {
        bool p1t = true;
        int turns = 9;
        int p1score = 0;
        int p2score = 0;

        public Form1()
        {
            InitializeComponent();
            button1.Text = ("");
            button2.Text = ("");
            button3.Text = ("");
            button4.Text = ("");
            button5.Text = ("");
            button6.Text = ("");
            button7.Text = ("");
            button8.Text = ("");
            button9.Text = ("");
        }


        public void reset()
        {
            button1.Text = ("");
            button2.Text = ("");
            button3.Text = ("");
            button4.Text = ("");
            button5.Text = ("");
            button6.Text = ("");
            button7.Text = ("");
            button8.Text = ("");
            button9.Text = ("");
            turns = 9;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            turns = turns - 1;
            if (button1.Text == ("X") || button1.Text == ("O"))
            {
            }
            else
            {
                if (p1t == true)
                {
                    button1.Text = ("X");
                    p1t = false;
                }
                else
                {
                    button1.Text = ("O");
                    p1t = true;
                }
                CheckWin();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            turns = turns - 1;
            if (button2.Text == ("X") || button2.Text == ("O"))
            {
            }
            else
            {
                if (p1t == true)
                {
                    button2.Text = ("X");
                    p1t = false;
                }
                else
                {
                    button2.Text = ("O");
                    p1t = true;
                }
                CheckWin();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            turns = turns - 1;
            if (button3.Text == ("X") || button3.Text == ("O"))
            {
            }
            else
            {
                if (p1t == true)
                {
                    button3.Text = ("X");
                    p1t = false;
                }
                else
                {
                    button3.Text = ("O");
                    p1t = true;
                }
                CheckWin();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            turns = turns - 1;
            if (button4.Text == ("X") || button4.Text == ("O"))
            {
            }
            else
            {
                if (p1t == true)
                {
                    button4.Text = ("X");
                    p1t = false;
                }
                else
                {
                    button4.Text = ("O");
                    p1t = true;
                }
                CheckWin();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            turns = turns - 1;
            if (button5.Text == ("X") || button5.Text == ("O"))
            {
            }
            else
            {
                if (p1t == true)
                {
                    button5.Text = ("X");
                    p1t = false;
                }
                else
                {
                    button5.Text = ("O");
                    p1t = true;
                }
                CheckWin();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            turns = turns - 1;
            if (button6.Text == ("X") || button6.Text == ("O"))
            {
            }
            else
            {
                if (p1t == true)
                {
                    button6.Text = ("X");
                    p1t = false;
                }
                else
                {
                    button6.Text = ("O");
                    p1t = true;
                }
                CheckWin();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            turns = turns - 1;
            if (button7.Text == ("X") || button7.Text == ("O"))
            {
            }
            else
            {
                if (p1t == true)
                {
                    button7.Text = ("X");
                    p1t = false;
                }
                else
                {
                    button7.Text = ("O");
                    p1t = true;
                }
                CheckWin();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            turns = turns - 1;
            if (button8.Text == ("X") || button8.Text == ("O"))
            {
            }
            else
            {
                if (p1t == true)
                {
                    button8.Text = ("X");
                    p1t = false;
                }
                else
                {
                    button8.Text = ("O");
                    p1t = true;
                }
                CheckWin();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            turns = turns - 1;
            if (button9.Text == ("X") || button9.Text == ("O"))
            {
            }
            else
            {
                if (p1t == true)
                {
                    button9.Text = ("X");
                    p1t = false;
                }
                else
                {
                    button9.Text = ("O");
                    p1t = true;
                }
                CheckWin();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reset();
            p1score = 0;
            p2score = 0;
            label1.Text = ("" + p1score);
            label2.Text = ("" + p2score);
        }

        public void CheckWin()
        {
            if (button5.Text == button1.Text && button5.Text == button9.Text)
            {
                if (button5.Text == ("X"))
                {
                    MessageBox.Show("Player 1 wins!");
                    p1score = p1score + 1;
                    label1.Text = ("" + p1score);
                    reset();
                }
                else if (button5.Text == ("O"))
                {
                    MessageBox.Show("Player 2 wins!");
                    p2score = p2score + 1;
                    label2.Text = ("" + p2score);
                    reset();
                }
            }
            if (button5.Text == button2.Text && button5.Text == button8.Text)
            {
                if (button5.Text == ("X"))
                {
                    MessageBox.Show("Player 1 wins!");
                    p1score = p1score + 1;
                    label1.Text = ("" + p1score);
                    reset();
                }
                else if (button5.Text == ("O"))
                {
                    MessageBox.Show("Player 2 wins!");
                    p2score = p2score + 1;
                    label2.Text = ("" + p2score);
                    reset();
                }
            }
            if (button5.Text == button3.Text && button5.Text == button7.Text)
            {
                if (button5.Text == ("X"))
                {
                    MessageBox.Show("Player 1 wins!");
                    p1score = p1score + 1;
                    label1.Text = ("" + p1score);
                    reset();
                }
                else if (button5.Text == ("O"))
                {
                    MessageBox.Show("Player 2 wins!");
                    p2score = p2score + 1;
                    label2.Text = ("" + p2score);
                    reset();
                }
            }
            if (button5.Text == button4.Text && button5.Text == button6.Text)
            {
                if (button5.Text == ("X"))
                {
                    MessageBox.Show("Player 1 wins!");
                    p1score = p1score + 1;
                    label1.Text = ("" + p1score);
                    reset();
                }
                else if (button5.Text == ("O"))
                {
                    MessageBox.Show("Player 2 wins!");
                    p2score = p2score + 1;
                    label2.Text = ("" + p2score);
                    reset();
                }
            }
            if (button1.Text == button4.Text && button1.Text == button7.Text)
            {
                if (button1.Text == ("X"))
                {
                    MessageBox.Show("Player 1 wins!");
                    p1score = p1score + 1;
                    label1.Text = ("" + p1score);
                    reset();
                }
                else if (button1.Text == ("O"))
                {
                    MessageBox.Show("Player 2 wins!");
                    p2score = p2score + 1;
                    label2.Text = ("" + p2score);
                    reset();
                }
            }
            if (button1.Text == button2.Text && button1.Text == button3.Text)
            {
                if (button1.Text == ("X"))
                {
                    MessageBox.Show("Player 1 wins!");
                    p1score = p1score + 1;
                    label1.Text = ("" + p1score);
                    reset();
                }
                else if (button1.Text == ("O"))
                {
                    MessageBox.Show("Player 2 wins!");
                    p2score = p2score + 1;
                    label2.Text = ("" + p2score);
                    reset();
                }
            }
            if (button9.Text == button6.Text && button9.Text == button3.Text)
            {
                if (button9.Text == ("X"))
                {
                    MessageBox.Show("Player 1 wins!");
                    p1score = p1score + 1;
                    label1.Text = ("" + p1score);
                    reset();
                }
                else if (button9.Text == ("O"))
                {
                    MessageBox.Show("Player 2 wins!");
                    p2score = p2score + 1;
                    label2.Text = ("" + p2score);
                    reset();
                }
            }
            if (button9.Text == button8.Text && button9.Text == button7.Text)
            {
                if (button9.Text == ("X"))
                {
                    MessageBox.Show("Player 1 wins!");
                    p1score = p1score + 1;
                    label1.Text = ("" + p1score);
                    reset();
                }
                else if (button9.Text == ("O"))
                {
                    MessageBox.Show("Player 2 wins!");
                    p2score = p2score + 1;
                    label2.Text = ("" + p2score);
                    reset();
                }
            }

            if (turns == 0)
            {

                MessageBox.Show("Tie!");
                p1score = p1score + 1;
                p2score = p2score + 1;
                label1.Text = ("" + p1score);
                label2.Text = ("" + p2score);
                reset();
            }
        }
    }
}
