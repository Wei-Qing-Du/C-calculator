using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4000D091_HW04
{
    public partial class Form1 : Form
    {
        int memory = 0, result = 0, button_flag = 0, button_press = 0, button_press1=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            memory=0;
            result = 0;
            button_flag = 0;
            result_label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result_label1.Text =="0" && button_flag == 0)
            {
                result_label1.Text = button1.Text;            
            }
            else if (button_press == 1 && button_press1==1)
            {
                result_label1.Text = button1.Text;
                button_press1 = 0;
            }
            else if (result_label1.Text != "0")
            {
                result_label1.Text += button1.Text;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            result_label1.Text += button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result_label1.Text += button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result_label1.Text += button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result_label1.Text += button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result_label1.Text += button5.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result_label1.Text += button8.Text;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            result_label1.Text += button7.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result_label1.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result_label1.Text += button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result_label1.Text += button9.Text;
        }


        private void add_button11_Click(object sender, EventArgs e)
        {
            if (button_flag == 0)
            {
                result = int.Parse(result_label1.Text);
                result_label1.Text = "";
            }
            if (button_flag == 2)
            {
                memory = int.Parse(result_label1.Text);
                result_label1.Text = "";
                result = result - memory; 
            }
            if (button_flag == 3)
            {
                memory = int.Parse(result_label1.Text);
                result = result*memory  ;
                result_label1.Text = "";
            }
            if ( button_flag == 1)
            {
                memory = int.Parse(result_label1.Text);
                result = result + memory;
                result_label1.Text = "";
                result_label1.Text = result.ToString();
            }

            button_flag = 1;
            button_press = 1;
            button_press1 = 1;
        }


        private void subtract_button10_Click(object sender, EventArgs e)
        {
            if (button_flag == 0)
            {
                result = int.Parse(result_label1.Text);
                result_label1.Text = "";           
            }

            if (button_flag == 1)
            {
                memory = int.Parse(result_label1.Text);
                result = result+ memory ;
                result_label1.Text = "";
            }

            if (button_flag == 3)
            {
                memory = int.Parse(result_label1.Text);
                result =result*memory  ;
                result_label1.Text = "";
            }
            if (button_flag == 2)
            {
                memory = int.Parse(result_label1.Text);
                result_label1.Text = "";
                result = result - memory;              
            }
            button_flag = 2;
        }


        private void Multiply_button12_Click(object sender, EventArgs e)
        {
            if (button_flag == 0)
            {
                result = int.Parse(result_label1.Text);
                result_label1.Text = "";
            }

            if (button_flag == 1)
            {
                memory = int.Parse(result_label1.Text);
                result = result+memory;
                result_label1.Text = "";
            }

            if (button_flag == 2)
            {
                memory = int.Parse(result_label1.Text);
                result_label1.Text = "";
                result = result - memory; 
            }

            if (button_flag == 3)
            {
                memory = int.Parse(result_label1.Text);
                result_label1.Text = "";
                result = result * memory;               
            }
            button_flag = 3;
        }



        private void enter_button9_Click(object sender, EventArgs e)
        {
            if (button_flag == 1)
            {
                memory = int.Parse(result_label1.Text);
                result_label1.Text = (result+memory).ToString();           
            }

            if (button_flag == 2)
            {
                memory = int.Parse(result_label1.Text);
                result_label1.Text = ( result-memory).ToString();
            }


            if (button_flag == 3)
            {
                memory = int.Parse(result_label1.Text);
                result_label1.Text = (result * memory).ToString();
            }

            button_flag = 0;

        }

    }
}