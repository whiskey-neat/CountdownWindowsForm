using System;

namespace CountdownWindowsForm
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.lbl_enterUsername = new System.Windows.Forms.Label();
            this.txtBox_EnterUsername = new System.Windows.Forms.TextBox();
            this.picBox_CountdownLogo = new System.Windows.Forms.PictureBox();
            this.lbl_currentHighScore_Easy = new System.Windows.Forms.Label();
            this.txtBox_CurrentHS = new System.Windows.Forms.TextBox();
            this.btn_LetsGo = new System.Windows.Forms.Button();
            this.btn_Welcome = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_currentPlayer = new System.Windows.Forms.Label();
            this.btn_ExitProgram = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBox_YourNumbersDisplay = new System.Windows.Forms.TextBox();
            this.lbl_YourNumbersHeading = new System.Windows.Forms.Label();
            this.lbl_GoalNumberHeading = new System.Windows.Forms.Label();
            this.txtBox_GoalNumber = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_YourSubHeading = new System.Windows.Forms.Label();
            this.txtBox_YourSub = new System.Windows.Forms.TextBox();
            this.rdBtn_Easy = new System.Windows.Forms.RadioButton();
            this.lbl_SelectDifficulty = new System.Windows.Forms.Label();
            this.rdBtn_Hard = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_currentHighScore_Hard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CountdownLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_enterUsername
            // 
            this.lbl_enterUsername.AutoSize = true;
            this.lbl_enterUsername.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_enterUsername.Location = new System.Drawing.Point(169, 402);
            this.lbl_enterUsername.Name = "lbl_enterUsername";
            this.lbl_enterUsername.Size = new System.Drawing.Size(171, 29);
            this.lbl_enterUsername.TabIndex = 0;
            this.lbl_enterUsername.Text = "Enter Username:";
            this.lbl_enterUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox_EnterUsername
            // 
            this.txtBox_EnterUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox_EnterUsername.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_EnterUsername.Location = new System.Drawing.Point(100, 442);
            this.txtBox_EnterUsername.MaxLength = 15;
            this.txtBox_EnterUsername.Name = "txtBox_EnterUsername";
            this.txtBox_EnterUsername.Size = new System.Drawing.Size(302, 30);
            this.txtBox_EnterUsername.TabIndex = 1;
            this.txtBox_EnterUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_EnterUsername.TextChanged += new System.EventHandler(this.txtBox_Username_TextChanged);
            this.txtBox_EnterUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_UserUsername_KeyDown);
            // 
            // picBox_CountdownLogo
            // 
            this.picBox_CountdownLogo.Image = global::CountdownWindowsForm.Properties.Resources.CountdownTitle;
            this.picBox_CountdownLogo.Location = new System.Drawing.Point(100, 101);
            this.picBox_CountdownLogo.Name = "picBox_CountdownLogo";
            this.picBox_CountdownLogo.Size = new System.Drawing.Size(302, 164);
            this.picBox_CountdownLogo.TabIndex = 2;
            this.picBox_CountdownLogo.TabStop = false;
            // 
            // lbl_currentHighScore_Easy
            // 
            this.lbl_currentHighScore_Easy.AutoSize = true;
            this.lbl_currentHighScore_Easy.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentHighScore_Easy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_currentHighScore_Easy.Location = new System.Drawing.Point(128, 597);
            this.lbl_currentHighScore_Easy.Name = "lbl_currentHighScore_Easy";
            this.lbl_currentHighScore_Easy.Size = new System.Drawing.Size(248, 29);
            this.lbl_currentHighScore_Easy.TabIndex = 3;
            this.lbl_currentHighScore_Easy.Text = "Easy Current High Score:";
            // 
            // txtBox_CurrentHS
            // 
            this.txtBox_CurrentHS.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBox_CurrentHS.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CurrentHS.Location = new System.Drawing.Point(100, 639);
            this.txtBox_CurrentHS.MaxLength = 10;
            this.txtBox_CurrentHS.Name = "txtBox_CurrentHS";
            this.txtBox_CurrentHS.ReadOnly = true;
            this.txtBox_CurrentHS.Size = new System.Drawing.Size(302, 30);
            this.txtBox_CurrentHS.TabIndex = 4;
            this.txtBox_CurrentHS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_LetsGo
            // 
            this.btn_LetsGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LetsGo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LetsGo.Location = new System.Drawing.Point(168, 500);
            this.btn_LetsGo.Name = "btn_LetsGo";
            this.btn_LetsGo.Size = new System.Drawing.Size(159, 59);
            this.btn_LetsGo.TabIndex = 5;
            this.btn_LetsGo.Text = "Let\'s Go!";
            this.btn_LetsGo.UseVisualStyleBackColor = true;
            this.btn_LetsGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Welcome
            // 
            this.btn_Welcome.AutoSize = true;
            this.btn_Welcome.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Welcome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Welcome.Location = new System.Drawing.Point(150, 40);
            this.btn_Welcome.Name = "btn_Welcome";
            this.btn_Welcome.Size = new System.Drawing.Size(207, 58);
            this.btn_Welcome.TabIndex = 6;
            this.btn_Welcome.Text = "Welcome To";
            // 
            // btn_Help
            // 
            this.btn_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Help.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.Color.Red;
            this.btn_Help.Location = new System.Drawing.Point(1, 1);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(75, 35);
            this.btn_Help.TabIndex = 7;
            this.btn_Help.Text = "HELP";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(424, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 8;
            // 
            // lbl_currentPlayer
            // 
            this.lbl_currentPlayer.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentPlayer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_currentPlayer.Location = new System.Drawing.Point(550, 700);
            this.lbl_currentPlayer.Name = "lbl_currentPlayer";
            this.lbl_currentPlayer.Size = new System.Drawing.Size(851, 50);
            this.lbl_currentPlayer.TabIndex = 1;
            this.lbl_currentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_currentPlayer.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_ExitProgram
            // 
            this.btn_ExitProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExitProgram.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitProgram.ForeColor = System.Drawing.Color.Crimson;
            this.btn_ExitProgram.Location = new System.Drawing.Point(417, 1);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(75, 35);
            this.btn_ExitProgram.TabIndex = 10;
            this.btn_ExitProgram.Text = "EXIT";
            this.btn_ExitProgram.UseVisualStyleBackColor = true;
            this.btn_ExitProgram.Click += new System.EventHandler(this.btn_ExitProgram_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(498, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 9;
            // 
            // txtBox_YourNumbersDisplay
            // 
            this.txtBox_YourNumbersDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBox_YourNumbersDisplay.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtBox_YourNumbersDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBox_YourNumbersDisplay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_YourNumbersDisplay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBox_YourNumbersDisplay.Location = new System.Drawing.Point(574, 112);
            this.txtBox_YourNumbersDisplay.Name = "txtBox_YourNumbersDisplay";
            this.txtBox_YourNumbersDisplay.ReadOnly = true;
            this.txtBox_YourNumbersDisplay.Size = new System.Drawing.Size(580, 84);
            this.txtBox_YourNumbersDisplay.TabIndex = 12;
            this.txtBox_YourNumbersDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_YourNumbersDisplay.Visible = false;
            // 
            // lbl_YourNumbersHeading
            // 
            this.lbl_YourNumbersHeading.AutoSize = true;
            this.lbl_YourNumbersHeading.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YourNumbersHeading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_YourNumbersHeading.Location = new System.Drawing.Point(759, 46);
            this.lbl_YourNumbersHeading.Name = "lbl_YourNumbersHeading";
            this.lbl_YourNumbersHeading.Size = new System.Drawing.Size(223, 45);
            this.lbl_YourNumbersHeading.TabIndex = 13;
            this.lbl_YourNumbersHeading.Text = "Your Numbers";
            this.lbl_YourNumbersHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_YourNumbersHeading.Visible = false;
            // 
            // lbl_GoalNumberHeading
            // 
            this.lbl_GoalNumberHeading.AutoSize = true;
            this.lbl_GoalNumberHeading.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GoalNumberHeading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_GoalNumberHeading.Location = new System.Drawing.Point(1217, 46);
            this.lbl_GoalNumberHeading.Name = "lbl_GoalNumberHeading";
            this.lbl_GoalNumberHeading.Size = new System.Drawing.Size(84, 45);
            this.lbl_GoalNumberHeading.TabIndex = 14;
            this.lbl_GoalNumberHeading.Text = "Goal";
            this.lbl_GoalNumberHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_GoalNumberHeading.Visible = false;
            this.lbl_GoalNumberHeading.Click += new System.EventHandler(this.lbl_GoalNumberHeading_Click);
            // 
            // txtBox_GoalNumber
            // 
            this.txtBox_GoalNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBox_GoalNumber.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtBox_GoalNumber.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBox_GoalNumber.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_GoalNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBox_GoalNumber.Location = new System.Drawing.Point(1181, 112);
            this.txtBox_GoalNumber.Name = "txtBox_GoalNumber";
            this.txtBox_GoalNumber.ReadOnly = true;
            this.txtBox_GoalNumber.Size = new System.Drawing.Size(160, 84);
            this.txtBox_GoalNumber.TabIndex = 15;
            this.txtBox_GoalNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_GoalNumber.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_YourSubHeading
            // 
            this.lbl_YourSubHeading.AutoSize = true;
            this.lbl_YourSubHeading.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YourSubHeading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_YourSubHeading.Location = new System.Drawing.Point(851, 231);
            this.lbl_YourSubHeading.Name = "lbl_YourSubHeading";
            this.lbl_YourSubHeading.Size = new System.Drawing.Size(257, 45);
            this.lbl_YourSubHeading.TabIndex = 17;
            this.lbl_YourSubHeading.Text = "Your Submission";
            this.lbl_YourSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_YourSubHeading.Visible = false;
            // 
            // txtBox_YourSub
            // 
            this.txtBox_YourSub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBox_YourSub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBox_YourSub.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_YourSub.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBox_YourSub.Location = new System.Drawing.Point(845, 289);
            this.txtBox_YourSub.MaxLength = 3;
            this.txtBox_YourSub.Name = "txtBox_YourSub";
            this.txtBox_YourSub.Size = new System.Drawing.Size(275, 65);
            this.txtBox_YourSub.TabIndex = 18;
            this.txtBox_YourSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_YourSub.Visible = false;
            // 
            // rdBtn_Easy
            // 
            this.rdBtn_Easy.AutoSize = true;
            this.rdBtn_Easy.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Easy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdBtn_Easy.Location = new System.Drawing.Point(168, 333);
            this.rdBtn_Easy.Name = "rdBtn_Easy";
            this.rdBtn_Easy.Size = new System.Drawing.Size(76, 28);
            this.rdBtn_Easy.TabIndex = 19;
            this.rdBtn_Easy.TabStop = true;
            this.rdBtn_Easy.Text = "Easy";
            this.rdBtn_Easy.UseVisualStyleBackColor = true;
            // 
            // lbl_SelectDifficulty
            // 
            this.lbl_SelectDifficulty.AutoSize = true;
            this.lbl_SelectDifficulty.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectDifficulty.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_SelectDifficulty.Location = new System.Drawing.Point(187, 292);
            this.lbl_SelectDifficulty.Name = "lbl_SelectDifficulty";
            this.lbl_SelectDifficulty.Size = new System.Drawing.Size(132, 29);
            this.lbl_SelectDifficulty.TabIndex = 20;
            this.lbl_SelectDifficulty.Text = "Select Mode:";
            // 
            // rdBtn_Hard
            // 
            this.rdBtn_Hard.AutoSize = true;
            this.rdBtn_Hard.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Hard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdBtn_Hard.Location = new System.Drawing.Point(265, 333);
            this.rdBtn_Hard.Name = "rdBtn_Hard";
            this.rdBtn_Hard.Size = new System.Drawing.Size(76, 28);
            this.rdBtn_Hard.TabIndex = 21;
            this.rdBtn_Hard.TabStop = true;
            this.rdBtn_Hard.Text = "Hard";
            this.rdBtn_Hard.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 734);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(302, 30);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_currentHighScore_Hard
            // 
            this.lbl_currentHighScore_Hard.AutoSize = true;
            this.lbl_currentHighScore_Hard.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentHighScore_Hard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_currentHighScore_Hard.Location = new System.Drawing.Point(128, 690);
            this.lbl_currentHighScore_Hard.Name = "lbl_currentHighScore_Hard";
            this.lbl_currentHighScore_Hard.Size = new System.Drawing.Size(248, 29);
            this.lbl_currentHighScore_Hard.TabIndex = 22;
            this.lbl_currentHighScore_Hard.Text = "Hard Current High Score:";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1413, 802);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_currentHighScore_Hard);
            this.Controls.Add(this.rdBtn_Hard);
            this.Controls.Add(this.lbl_SelectDifficulty);
            this.Controls.Add(this.rdBtn_Easy);
            this.Controls.Add(this.txtBox_YourSub);
            this.Controls.Add(this.lbl_YourSubHeading);
            this.Controls.Add(this.txtBox_GoalNumber);
            this.Controls.Add(this.lbl_GoalNumberHeading);
            this.Controls.Add(this.lbl_YourNumbersHeading);
            this.Controls.Add(this.txtBox_YourNumbersDisplay);
            this.Controls.Add(this.lbl_currentPlayer);
            this.Controls.Add(this.btn_ExitProgram);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Welcome);
            this.Controls.Add(this.btn_LetsGo);
            this.Controls.Add(this.txtBox_CurrentHS);
            this.Controls.Add(this.lbl_currentHighScore_Easy);
            this.Controls.Add(this.picBox_CountdownLogo);
            this.Controls.Add(this.txtBox_EnterUsername);
            this.Controls.Add(this.lbl_enterUsername);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown Game";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CountdownLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtBox_Username_TextChanged(object sender, EventArgs e)
        {
            string username = txtBox_EnterUsername.Text; 
        }

        #endregion

        private System.Windows.Forms.Label lbl_enterUsername;
        private System.Windows.Forms.TextBox txtBox_EnterUsername;
        private System.Windows.Forms.PictureBox picBox_CountdownLogo;
        private System.Windows.Forms.Label lbl_currentHighScore_Easy;
        private System.Windows.Forms.TextBox txtBox_CurrentHS;
        private System.Windows.Forms.Button btn_LetsGo;
        private System.Windows.Forms.Label btn_Welcome;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_currentPlayer;
        private System.Windows.Forms.Button btn_ExitProgram;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBox_YourNumbersDisplay;
        private System.Windows.Forms.Label lbl_YourNumbersHeading;
        private System.Windows.Forms.Label lbl_GoalNumberHeading;
        private System.Windows.Forms.TextBox txtBox_GoalNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_YourSubHeading;
        private System.Windows.Forms.TextBox txtBox_YourSub;
        private System.Windows.Forms.RadioButton rdBtn_Easy;
        private System.Windows.Forms.Label lbl_SelectDifficulty;
        private System.Windows.Forms.RadioButton rdBtn_Hard;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_currentHighScore_Hard;
    }
}

