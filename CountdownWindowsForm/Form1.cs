using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;

namespace CountdownWindowsForm
{
    public partial class form1 : Form
    {
        PlayerModel player = new PlayerModel();
        SoundPlayer letsgo = new SoundPlayer(CountdownWindowsForm.Properties.Resources.CountdownTheme_Trim);
        SoundPlayer timer = new SoundPlayer(CountdownWindowsForm.Properties.Resources.CountdownTheme_Full);

        public form1()
        {
            InitializeComponent();
        }

        private void btn_ExitProgram_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        } // EXIT BUTTON
        

        /// HELP BUTTON
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
                "Step 1" +
                "\n------" +
                "\nEnter a username in the Username box and then click the 'Let's Go!' button underneath." +
                "\n" +
                "\nStep 2" +
                "\n--------" +
                "\nYour numbers will appear in the left hand box. Use these numbers to try and reach the goal number on the right." +
                "\n" +
                "\nStep 3" +
                "\n--------" +
                "\nAfter the countdown timer has finished a \"Your Submission\" box will appear. Enter the number you got to here." +
                "\n" +
                "\nStep 4" +
                "\n--------" +
                "\nThats it! Your score will be logged. Have fun :D");
        }

        
        public void empty()
        {
            txtBox_EnterUsername.Text = ""; // SET EnterUsername TO EMPTY
        }
        
        private void txtBox_UserUsername_KeyDown(object sender, KeyEventArgs e) // Let's Go button is pressed when enter key is pressed
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_LetsGo.PerformClick();
            }
        }

        
        private void txtBox_Submission_KeyDown_1(object sender, KeyEventArgs e) // Submit button is pressed when enter key is pressed
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SubmitNum.PerformClick();
            }
        }


        ///  WHEN LETS GO BUTTON IS PRESSED
        
        private async void button1_Click(object sender, EventArgs e)
        {
            player.Username = txtBox_EnterUsername.Text; // STORES USERNAME IN VARIABLE

            if (string.IsNullOrEmpty(player.Username))
            {
                MessageBox.Show("Name can't be empty!");
            }

            ///  IF A DIFFICULTY IS SELECTED
            else if (rdBtn_Easy.Checked | rdBtn_Hard.Checked)
            {
                letsgo.Play();

                lbl_currentPlayer.Text = ("GET READY ") + player.Username; // DISPLAYS NAME OF CURRENT PLAYER

                await Task.Delay(TimeSpan.FromSeconds(5));
            }
       

            ///  IF A DIFFICULTY IS NOT SELECTED
            else
            {
                MessageBox.Show(" YOU MUST SELECT A DIFFICULTY ");
            }


                ///  IF HARD DIFFICULTY IS SELECTED
                if (rdBtn_Hard.Checked)
                {
                    
                    /// CREATES RANDOM NUMBERS
                    Random rnd = new Random();

                    string space = " , ";
                    int nums;

                    for (int i = 1; i <= 3; i++)  // GENERATE 3 SMALL NUMBERS
                    {
                        nums = rnd.Next(1, 10);
                        txtBox_YourNumbersDisplay.Text = txtBox_YourNumbersDisplay.Text + nums.ToString() + space;
                    }

                    for (int i = 1; i <= 2; i++)  // GENERATE 2 BIG NUMBERS
                    {
                        nums = rnd.Next(11, 100);
                        txtBox_YourNumbersDisplay.Text = txtBox_YourNumbersDisplay.Text + nums.ToString() + space;

                        if (i == 2)
                        {
                            nums = rnd.Next(11, 100);  // GENERATE 3RD BIG NUMBER AND FORMATS STRING PROPERLY
                            txtBox_YourNumbersDisplay.Text = txtBox_YourNumbersDisplay.Text + nums.ToString();
                        }
                    }

                    int goalNumber = rnd.Next(101, 999);
                    txtBox_GoalNumber.Text = goalNumber.ToString();

                    lbl_YourNumbersHeading.Visible = true;
                    txtBox_YourNumbersDisplay.Visible = true;
                    lbl_GoalNumberHeading.Visible = true;
                    txtBox_GoalNumber.Visible = true;

                    lbl_YourSubHeading.Visible = true;
                    txtBox_Submission.Visible = true;
                    btn_SubmitNum.Visible = true;
                    lbl_currentPlayer.Visible = false;

                    await Task.Delay(TimeSpan.FromSeconds(2));  // Wait 2 seconds before carrying on

                    timer.Play();

                    await Task.Delay(TimeSpan.FromSeconds(30)); // Wait 30 seconds before carrying on
                }

                ///  IF EASY DIFFICULTY IS SELECTED
                else if (rdBtn_Easy.Checked)
                {
                    MessageBox.Show($" Lol, as if u wanted easy mode, loser! \n Sorry, I haven't programmed this mode yet so u better man up and go hard or go home! <3");
                }
        }

        private void btn_SubmitNum_Click(object sender, EventArgs e) // USER PRESSES SUBMIT
        {
            timer.Stop();

            string userSub = txtBox_Submission.Text;  // STORES USER SUBMISSION


            int userNumber;
            if (int.TryParse(userSub, out userNumber)) // VALIDATING USER INPUT
            {
                int goalNumber2 = Int32.Parse(txtBox_GoalNumber.Text); // CONVERTS GOAL NUMBER TO INTEGER
                string yourScoreIs = "Your Score is: ";

                int highestNumber = Math.Max(userNumber, goalNumber2);
                int lowestNumber = Math.Min(userNumber, goalNumber2);

                player.Score = highestNumber - lowestNumber; //CREATES SCORE

                txtBox_DisplayScore.Text = yourScoreIs + player.Score.ToString(); //DISPLAYS SCORE ON SCREEN
            }
            
            else
            {
                MessageBox.Show("Enter a number!");
            }

            // WRITING THE USERNAME AND SCORE TO A FILE
            string scoreOutput = player.Score.ToString();

            string outputData = "Score: " + scoreOutput + " " + "Username: " + player.Username;

            string pathToFile = Path.Combine(Directory.GetCurrentDirectory(), "scores.txt");
            using (StreamWriter sw = File.AppendText(pathToFile))
            {
                sw.WriteLine(outputData);
            }   

        }

        private void btn_ViewScores_Click(object sender, EventArgs e)
        {
            string pathToFile = Path.Combine(Directory.GetCurrentDirectory(), "scores.txt");

            try
            {
                string fileData = File.ReadAllText(pathToFile);
                MessageBox.Show(fileData);
            }
            catch (IOException ex)
            {
                MessageBox.Show(":( The file could not be read:" + ex.Message);
            }
        }
    }
}
