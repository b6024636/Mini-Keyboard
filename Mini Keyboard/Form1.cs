using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyDialogs;

namespace Mini_Keyboard
{
    public partial class Form1 : Form
    {
        //Defines the mode as false as a global variable 
        bool modePrediction = false;

        int index = -1;

        int intervalRequired = 1000;

        // Buttons. Identifies which button is being selected be the user. 
        bool[] buttonPresssed = new bool[19];

        string builtWord;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            //If the mode isn't on predictive, change it to prediction. 
            if (modePrediction == false)
            {
                modePrediction = true;
                modeStatusLbl.Text = "Predictive";
            }
            // Else if it is on predictive change it to multi.
            else
            {
                modePrediction = false;
                modeStatusLbl.Text = "Multi-Press";
            }
        }

        private void onTick(object sender, EventArgs e)
        {
            //Disables the timer after 1 second
            timer1.Enabled = false;
            wordBuilderTextBox.AppendText(globalListBox.Items[index].ToString());
            index = -1;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //Goes to the next line on the main notepad
            notepadTxt.AppendText(System.Environment.NewLine);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            //Appends the text from the text box to the main notepad section
            builtWord = wordBuilderTextBox.Text;
            notepadTxt.AppendText(builtWord + " ");
            //Clears the textbox
            wordBuilderTextBox.Clear();
        }

        private void timerRestart()
        {
            //Restarts timer
            timer1.Stop();
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                globalListBox.Items.Clear();
                for (int i = 0; i < listBox8.Items.Count; i++)
                {
                    globalListBox.Items.Add(listBox8.Items[i].ToString());
                }
                //If the timer is not enabled, set the index to 0 and enable it                       
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    index++;
                }
                //If its not the first time the button is clicked
                else
                {
                    //Restarts the timer    
                    timerRestart();
                    //Goes onto the next item
                    index++;
                    //Loops through the listBox
                    if (index == listBox8.Items.Count - 1)
                    {
                        index = 0;
                    }
                }
            }
        //End button
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                globalListBox.Items.Clear();
                for (int i = 0; i < listBox9.Items.Count; i++)
                {
                    globalListBox.Items.Add(listBox9.Items[i].ToString());
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    index++;
                }
                else
                {
                    timerRestart();
                    index++;
                    if (index == listBox9.Items.Count - 1)
                    {
                        index = 0;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                globalListBox.Items.Clear();
                for (int i = 0; i < listBox4.Items.Count; i++)
                {
                    globalListBox.Items.Add(listBox4.Items[i].ToString());
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    index++;
                }
                else
                {
                    timerRestart();
                    index++;
                    if (index == listBox4.Items.Count - 1)
                    {
                        index = 0;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                globalListBox.Items.Clear();
                for (int i = 0; i < listBox5.Items.Count; i++)
                {
                    globalListBox.Items.Add(listBox5.Items[i].ToString());
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    index++;
                }
                else
                {
                    timerRestart();
                    index++;
                    if (index == listBox5.Items.Count - 1)
                    {
                        index = 0;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                globalListBox.Items.Clear();
                for (int i = 0; i < listBox6.Items.Count; i++)
                {
                    globalListBox.Items.Add(listBox6.Items[i].ToString());
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    index++;
                }
                else
                {
                    timerRestart();
                    index++;
                    if (index == listBox6.Items.Count - 1)
                    {
                        index = 0;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                globalListBox.Items.Clear();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    globalListBox.Items.Add(listBox1.Items[i].ToString());
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    index++;
                }
                else
                {
                    timerRestart();
                    index++;
                    if (index == listBox1.Items.Count - 1)
                    {
                        index = 0;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                globalListBox.Items.Clear();
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    globalListBox.Items.Add(listBox2.Items[i].ToString());
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    index++;
                }
                else
                {
                    timerRestart();
                    index++;
                    if (index == listBox2.Items.Count - 1)
                    {
                        index = 0;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                globalListBox.Items.Clear();
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    globalListBox.Items.Add(listBox3.Items[i].ToString());
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    index++;
                }
                else
                {
                    timerRestart();
                    index++;
                    if (index == listBox3.Items.Count - 1)
                    {
                        index = 0;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                globalListBox.Items.Clear();
                for (int i = 0; i < listBox7.Items.Count; i++)
                {
                    globalListBox.Items.Add(listBox7.Items[i].ToString());
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    index++;
                }
                else
                {
                    timerRestart();
                    index++;
                    if (index == listBox7.Items.Count - 1)
                    {
                        index = 0;
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                globalListBox.Items.Clear();
                for (int i = 0; i < listBox10.Items.Count; i++)
                {
                    globalListBox.Items.Add(listBox10.Items[i].ToString());
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    index++;
                }
                else
                {
                    timerRestart();
                    index++;
                    if (index == listBox10.Items.Count - 1)
                    {
                        index = 0;
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                globalListBox.Items.Clear();
                for (int i = 0; i < listBox11.Items.Count; i++)
                {
                    globalListBox.Items.Add(listBox11.Items[i].ToString());
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    index++;
                }
                else
                {
                    timerRestart();
                    index++;
                    if (index == listBox11.Items.Count - 1)
                    {
                        index = 0;
                    }
                }
            }
        }








    } //Class
}
