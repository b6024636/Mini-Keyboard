using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using MyDialogs;

namespace Mini_Keyboard
{
    public partial class Form1 : Form
    {
        //Defines the mode as false as a global variable 
        bool modePrediction = false;

        int index = -1;

        int intervalRequired = 1000;

        bool requiresSaving = false;

        // Buttons. Identifies which button is being selected be the user. 
        bool[] buttonPresssed = new bool[19];

        string builtWord;

        //Adds variables for opening and saving file dialog
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();

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
            //This means that the file has been edited and therefore needs to be saved
            requiresSaving = true;
        }

        private void timerRestart()
        {
            //Restarts timer
            timer1.Stop();
            timer1.Start();

       
        }

        //The code for each button is similar to eachother with only the listbox being changed depending on which button is pressed

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (modePrediction == false)
            {
                buttonPresssed[8] = true;

                //Adds the corresonding listbox content to the global list box through the for loop
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
                    if (index == listBox8.Items.Count)
                    {
                        index = 0;
                    }
                }
                //Displays what the current index letter is
                listBoxLetterLbl.Text = globalListBox.Items[index].ToString();
            }
        //End button
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                buttonPresssed[9] = true;

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
                listBoxLetterLbl.Text = globalListBox.Items[index].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                buttonPresssed[4] = true;

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
                listBoxLetterLbl.Text = globalListBox.Items[index].ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                buttonPresssed[5] = true;

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
                listBoxLetterLbl.Text = globalListBox.Items[index].ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                buttonPresssed[6] = true;

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
                listBoxLetterLbl.Text = globalListBox.Items[index].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                buttonPresssed[1] = true;

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
                listBoxLetterLbl.Text = globalListBox.Items[index].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                buttonPresssed[2] = true;

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
                listBoxLetterLbl.Text = globalListBox.Items[index].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                buttonPresssed[3] = true;

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
                listBoxLetterLbl.Text = globalListBox.Items[index].ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                buttonPresssed[7] = true;

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
                listBoxLetterLbl.Text = globalListBox.Items[index].ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                buttonPresssed[10] = true;

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
                listBoxLetterLbl.Text = globalListBox.Items[index].ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (modePrediction == false)
            {
                buttonPresssed[11] = true;

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
                listBoxLetterLbl.Text = globalListBox.Items[index].ToString();
            }
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Allows the user to change the timer interval 
            intervalRequired = Convert.ToInt32(My_Dialogs.InputBox("Please enter the delay value you require. 1000 is equal to 1 second delay. The delay is currently at " + intervalRequired));
            timer1.Interval = intervalRequired;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Text File |*.txt";
            //If save is clicked
            if (sfd.ShowDialog() == DialogResult.OK)
            { 
                //Makes sure the file name isn't left blank
                if(sfd.FileName != "")
                {
                    //Writes the text in the notepad to a file
                    using(StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.Write(notepadTxt.Text);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // This gets us the location where the Application is being
            string applicationPath = Directory.GetCurrentDirectory() + "\\";

            // Creates a file at the application path called Notepad.txt
            StreamWriter outputStream = File.CreateText(applicationPath + "Text.txt");
            outputStream.WriteLine(notepadTxt.Text);

            //Closes the file
            outputStream.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clears the current text
            notepadTxt.Clear();
            string lineOfText;
            //Ensures the user can only open .txt files
            ofd.Filter = "Text File|*.txt";
           //Only runs the code if Ok is selected
           if (ofd.ShowDialog() == DialogResult.OK)
           {
               //Reads the selected file
               StreamReader inputStream = File.OpenText(ofd.FileName);

               //lineOfText = inputStream.ReadLine();

               while(inputStream.ReadLine() != null)
               {
                   lineOfText = inputStream.ReadLine();
                   notepadTxt.AppendText(lineOfText + Environment.NewLine);
                   
               }
               //Closes the stream
               inputStream.Close();
           }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes the program
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            wordBuilderTextBox.Clear();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (requiresSaving == true)
            {
                if (notepadTxt.Text != "")
                {
                    sfd.Filter = "Text File|*.txt";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (sfd.FileName != "")
                        {
                           using (StreamWriter sw = new StreamWriter(sfd.FileName))
                            {
                                sw.Write(notepadTxt.Text);
                            }
                        }

                        //Clears the notepad and wordbuiler text boxes
                        notepadTxt.Clear();
                        wordBuilderTextBox.Clear();
                    }
                }
            }
            else
            {
                notepadTxt.Clear();
                wordBuilderTextBox.Clear();
            }
        }


        private void loadDictionary()
        {
            string filePath = Directory.GetCurrentDirectory() + "\\";
            
            if(File.Exists(filePath + "Dictionary.txt"))
            {
              
            }
            else
            {
                StreamWriter outputStream = File.CreateText(filePath + "Dictionary.txt");
                outputStream.Close();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           loadDictionary(); 
        }





    } //End of Class
}
