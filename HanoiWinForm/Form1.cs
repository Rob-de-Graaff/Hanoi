using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanoiWinForm
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Button> buttonDisksDictionary;
        private Image SelectedDiskImage;
        private Button buttonCurrentDisk;
        private Button buttonPreviousDisk;
        private int moveCount = 0;
        private int clickCount = 0;
        private int Seconds;
        private string indexLetter;

        public Form1()
        {
            InitializeComponent();

            buttonPegA1.BackgroundImage = Properties.Resources.disk1;
            buttonPegA2.BackgroundImage = Properties.Resources.disk2;
            buttonPegA3.BackgroundImage = Properties.Resources.disk3;
            buttonPegA4.BackgroundImage = Properties.Resources.disk4;

            buttonDisksDictionary = new Dictionary<string, Button>();
            buttonDisksDictionary.Add("buttonPegA1", buttonPegA1);
            buttonDisksDictionary.Add("buttonPegA2", buttonPegA2);
            buttonDisksDictionary.Add("buttonPegA3", buttonPegA3);
            buttonDisksDictionary.Add("buttonPegA4", buttonPegA4);
            buttonDisksDictionary.Add("buttonPegB1", buttonPegB1);
            buttonDisksDictionary.Add("buttonPegB2", buttonPegB2);
            buttonDisksDictionary.Add("buttonPegB3", buttonPegB3);
            buttonDisksDictionary.Add("buttonPegB4", buttonPegB4);
            buttonDisksDictionary.Add("buttonPegC1", buttonPegC1);
            buttonDisksDictionary.Add("buttonPegC2", buttonPegC2);
            buttonDisksDictionary.Add("buttonPegC3", buttonPegC3);
            buttonDisksDictionary.Add("buttonPegC4", buttonPegC4);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in panelDisksButtons.Controls)
            {
                if (control is Button)
                {
                    control.Click += new System.EventHandler(Btn_Click);

                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            buttonCurrentDisk = (Button)sender;

            if (clickCount % 2 == 0 && buttonCurrentDisk.BackgroundImage != null)
            {
                if (CheckDisk(buttonCurrentDisk, clickCount))
                {
                    buttonPreviousDisk = buttonCurrentDisk;
                    SelectedDiskImage = buttonCurrentDisk.BackgroundImage;
                    clickCount++;
                }
            }
            else if(clickCount % 2 != 0 && buttonCurrentDisk.BackgroundImage == null)
            {
                if (CheckDisk(buttonCurrentDisk, clickCount))
                {
                    UpdateButtonDisks();
                    clickCount++;
                }
            }

            if (clickCount % 2 == 0)
            {
                moveCount = clickCount / 2;
                labelMoves.Text = $"Moves: {moveCount}";
            }
        }

        private void UpdateButtonDisks()
        {
            buttonCurrentDisk.Width = SelectedDiskImage.Width;
            buttonCurrentDisk.BackgroundImage = SelectedDiskImage;
            buttonPreviousDisk.BackgroundImage = null;
            switch (indexLetter)
            {
                case "A":
                    if (SelectedDiskImage.Width == 80)
                    {
                        buttonCurrentDisk.Left = 58;
                    }
                    else if (SelectedDiskImage.Width == 90)
                    {
                        buttonCurrentDisk.Left = 53;
                    }
                    else if (SelectedDiskImage.Width == 100)
                    {
                        buttonCurrentDisk.Left = 48;
                    }
                    else if (SelectedDiskImage.Width == 110)
                    {
                        buttonCurrentDisk.Left = 43;
                    }
                    break;
                case "B":
                    if (SelectedDiskImage.Width == 80)
                    {
                        buttonCurrentDisk.Left = 258;
                    }
                    else if (SelectedDiskImage.Width == 90)
                    {
                        buttonCurrentDisk.Left = 253;
                    }
                    else if (SelectedDiskImage.Width == 100)
                    {
                        buttonCurrentDisk.Left = 248;
                    }
                    else if (SelectedDiskImage.Width == 110)
                    {
                        buttonCurrentDisk.Left = 243;
                    }
                    break;
                case "C":
                    if (SelectedDiskImage.Width == 80)
                    {
                        buttonCurrentDisk.Left = 456;
                    }
                    else if (SelectedDiskImage.Width == 90)
                    {
                        buttonCurrentDisk.Left = 451;
                    }
                    else if (SelectedDiskImage.Width == 100)
                    {
                        buttonCurrentDisk.Left = 446;
                    }
                    else if (SelectedDiskImage.Width == 110)
                    {
                        buttonCurrentDisk.Left = 441;
                    }
                    break;
                case "":
                    break;
            }
        }

        private bool CheckDisk(Button selectedDisk, int status)
        {
            indexLetter = selectedDisk.Name.Substring(9,1);
            int indexNumber = Convert.ToInt32(selectedDisk.Name.Substring(10,1));
            string nextDiskName;

            if (status % 2 == 0)
            {
                indexNumber -= 1;
                nextDiskName = $"buttonPeg{indexLetter}{indexNumber}";

                // Checks if selected disk is on top
                if (buttonDisksDictionary.ContainsKey(nextDiskName))
                {
                    buttonDisksDictionary.TryGetValue(nextDiskName, out Button previousButtonDisk);
                    // Checks if previous button is filled with a disk
                    if (previousButtonDisk.BackgroundImage != null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    // selected disk is on top
                    return true;
                }
            }
            else
            {
                indexNumber += 1;
                nextDiskName = $"buttonPeg{indexLetter}{indexNumber}";

                // Checks if selected disk is on bottom
                if (buttonDisksDictionary.ContainsKey(nextDiskName))
                {
                    buttonDisksDictionary.TryGetValue(nextDiskName, out Button nextButtonDisk);
                    int valueSelectedDisk = SelectedDiskImage.Width;
                    int valueNextDisk = nextButtonDisk.BackgroundImage.Width;
                    // Checks if next button is filled with a disk
                    if (nextButtonDisk.BackgroundImage == null)
                    {
                        return false;
                    }
                    else if(valueSelectedDisk > valueNextDisk)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    // selected disk is on bottom
                    return true;
                }
            }
        }

        private void ButtonTimer_Click(object sender, EventArgs e)
        {
            if (buttonTimer.Text == "Start Timer")
            {
                buttonTimer.Name = "Stop Timer";
                timePlayed.Start();
                timePlayed.Interval = 1000;
            }
            else if (buttonTimer.Text == "Stop Timer")
            {
                buttonTimer.Name = "Start Timer";
                timePlayed.Stop();
            }
        }

        private void TimePlayed_Tick(object sender, EventArgs e)
        {
            Seconds++;
            labelTime.Text = $"Time Elapsed: {Seconds.ToString()} Seconds";
            if (Seconds == 360)
            {
                timePlayed.Stop();
                MessageBox.Show("Time is up");
            }
        }
    }
}
