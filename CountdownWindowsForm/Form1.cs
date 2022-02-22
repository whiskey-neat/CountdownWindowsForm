using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;

namespace CountdownWindowsForm
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }



        // SET EnterUsername TO EMPTY
        public void empty()
        {
            txtBox_EnterUsername.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        // HELP BUTTON DIALOGUE
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "                                                ----------------------------- " +
                "\n" +
                "                                                  --    HOW TO PLAY    -- " +
                "\n" +
                "                                                -----------------------------" +
                "\n" +
                "\n" +
                "Simply enter a username in the username box to the left and then click the 'Let's Go!' button underneath." +
                "\n" +
                "\n" +
                "See, not so hard..." +
                "\n" +
                "..right?");
        }

        // LETS GO BUTTON IS PRESSSED WHEN ENTER KEY IS PRESSED IN USERNAME BOX
        private void txtBox_UserUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_LetsGo.PerformClick();
            }
        }

        /*------------------------------------
         -->  WHEN LETS GO BUTTON IS PRESSED
        -------------------------------------*/
        private async void button1_Click(object sender, EventArgs e)
        {


            /*------------------------------------
            ///  IF ANY DIFFICULTY IS SELECTED
            -------------------------------------*/

            if (rdBtn_Easy.Checked | rdBtn_Hard.Checked)
            {

                // STORES USERNAME IN VARIABLE 
                string playerUsername = txtBox_EnterUsername.Text;

                SoundPlayer player = new SoundPlayer(CountdownWindowsForm.Properties.Resources.CountdownTheme_Trim);
                player.Play();

                // System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"CountdownTheme_Trim.wav");
                // player.Play();


                // DISPLAYS NAME OF CURRENT PLAYER
                lbl_currentPlayer.Text = ("GET READY ") + playerUsername;


                //CLEARS TEXT FROM EnterUsername BOX
                empty();

                await Task.Delay(TimeSpan.FromSeconds(5));
            }


            /*-------------------------------------       
            ///  IF A DIFFICULTY IS NOT SELECTED
            --------------------------------------*/

            else
            {
                MessageBox.Show(" YOU MUST SELECT A DIFFICULTY ");
            }


            /*-----------------------------------
            ///  IF HARD DIFFICULTY IS SELECTED
            ------------------------------------*/

            if (rdBtn_Hard.Checked)
            {

                /// MAKES NUMBERS VISIBLE AFTER 5 SECONDS
                lbl_YourNumbersHeading.Visible = true;
                txtBox_YourNumbersDisplay.Visible = true;


                /// CREATES RANDOM NUMBERS
                Random rnd = new Random();

                string space = " , ";
                int nums;


                // txtBox_YourNumbersDisplay.Text = nums.ToString();
                for (int i = 1; i <= 3; i++)
                {
                    nums = rnd.Next(1, 10);
                    txtBox_YourNumbersDisplay.Text = txtBox_YourNumbersDisplay.Text + nums.ToString() + space;
                }

                for (int i = 1; i <= 2; i++)
                {
                    nums = rnd.Next(11, 100);
                    txtBox_YourNumbersDisplay.Text = txtBox_YourNumbersDisplay.Text + nums.ToString() + space;

                    if (i == 2)
                    {
                        nums = rnd.Next(11, 100);
                        txtBox_YourNumbersDisplay.Text = txtBox_YourNumbersDisplay.Text + nums.ToString();
                    }
                }
                
                /// MAKE AND DISPLAY RANDOM GOAL NUMBER

                lbl_GoalNumberHeading.Visible = true;
                txtBox_GoalNumber.Visible = true;

                int goalNumber = rnd.Next(101, 999);
                txtBox_GoalNumber.Text = goalNumber.ToString();

                await Task.Delay(TimeSpan.FromSeconds(2));

                SoundPlayer timer = new SoundPlayer(CountdownWindowsForm.Properties.Resources.CountdownTheme_Full);
                timer.Play();

                await Task.Delay(TimeSpan.FromSeconds(30));

                lbl_YourSubHeading.Visible = true;
                txtBox_YourSub.Visible = true;
            }

            /*------------------------------------
            ///  IF EASY DIFFICULTY IS SELECTED
            -------------------------------------*/

            else if (rdBtn_Easy.Checked)
            {
                MessageBox.Show($" Lol, as if u wanted easy mode, loser! \n Sorry, I haven't programmed this mode yet so u better man up and go hard or go home! <3");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /*----------------
        ///  Exit Button
        -----------------*/
        private void btn_ExitProgram_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lbl_GoalNumberHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
