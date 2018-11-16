using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights_Out
{
    public partial class Form1 : Form
    {

        //declare variables

        public string[,] arrBtnVal = new string[25, 2]; //row,column
        public List<string> lstAdjacent = new List<string>();
        public int intLevel = 1; //set default to impossible


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            HardToolStripMenuItem.Checked = true;
        }

        /*
        void Form1_Shown(Object sender, EventArgs e)
        {
            MessageBox.Show("Turn off all the lights" + "\n" + "Grey - OFF" + "\n" + "Blue - ON", "Info");
        }
        */

        private void Reset()
        {
            //populate the array
            Random rand = new Random();

            for (int i = 0; i < 25; i++)
            {

                arrBtnVal[i, 0] = "Button" + (i + 1);
                arrBtnVal[i, 1] = rand.Next(2).ToString();
                //arrBtnVal[i, 1] = "0"; //rand.Next(2).ToString(); //for testing
            }
            //change the colours
            for (int i = 0; i < 25; i++)
            {
                if (arrBtnVal[i, 1] == "0")
                {
                    this.Controls[arrBtnVal[i, 0]].BackColor = Color.DarkSlateGray;
                }
                else
                {
                    this.Controls[arrBtnVal[i, 0]].BackColor = Color.LightBlue;
                }
            }


        }

        public void Change_Colours(string[,] arrBtnVal)
        {
            bool blWon = false;
            int intCount = 0;

            for (int i = 0; i < 25; i++)
            {
                if (arrBtnVal[i, 1] == "0")
                {
                    this.Controls[arrBtnVal[i, 0]].BackColor = Color.DarkSlateGray;
                }
                else
                {
                    this.Controls[arrBtnVal[i, 0]].BackColor = Color.LightBlue;
                    intCount++;
                }
            }

            //check if game was won
            switch (intLevel)
            {
                case 1: //Hard - all lights switched off
                    if (intCount == 0)
                    {
                        blWon = true;
                    }
                    break;

                case 2: //Medium - 1 light on
                    if (intCount <= 1)
                    {
                        blWon = true;
                    }
                    break;

                case 3: //Easy - 2 lights on
                    if (intCount <= 2)
                    {
                        blWon = true;
                    }
                    break;
            }

            if (blWon == true)
            {

                for (int i = 0; i < 25; i++)
                {
                    this.Controls[arrBtnVal[i, 0]].BackColor = Color.Green;
                    // this.Controls[arrBtnVal[i, 0]].Enabled = false;
                }

                MessageBox.Show("You've won!!!", "Congratulations");
                Reset();

            }

        }
               
    
        //set the difficulty level and check\uncheck menu items
        private void HardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intLevel = 1;
            HardToolStripMenuItem.Checked = true;

            EasyToolStripMenuItem.Checked = false;
            MediumToolStripMenuItem.Checked = false;
            Reset();
        }

        private void MediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intLevel = 2;
            MediumToolStripMenuItem.Checked = true;

            EasyToolStripMenuItem.Checked = false;
            HardToolStripMenuItem.Checked = false;
            Reset();
        }

        private void EasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intLevel = 3;
            EasyToolStripMenuItem.Checked = true;

            MediumToolStripMenuItem.Checked = false;
            HardToolStripMenuItem.Checked = false;
            Reset();
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turn off all of the lights by changing them to gray." + "\n" + "Click on the light to toggle it and its adjacent lights." + 
                "\n" + "\n" + "Difficulty levels:" + "\n" + "\n" + "Hard - all lights out" + "\n" + "Medium - one light on" + "\n" + "Easy - two lights on", "Help");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            // get Button's name and extract its number
            string strButtonName = ((((Button)sender).Name).Substring(6));
            // call function to get adjacent Buttons       
            lstAdjacent = Functions.Get_Adjecent(strButtonName);
            // call function to update values in the array 
            arrBtnVal = Functions.Update_Buttons(lstAdjacent, arrBtnVal);
            // change the colours and check if it's a win
            Change_Colours(arrBtnVal);
        }

       
    }
}
