namespace CountdownWindowsForm
{
    partial class form_Help
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
            this.lbl_HowToPlay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_HowToPlay
            // 
            this.lbl_HowToPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_HowToPlay.AutoSize = true;
            this.lbl_HowToPlay.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HowToPlay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_HowToPlay.Location = new System.Drawing.Point(288, 38);
            this.lbl_HowToPlay.Name = "lbl_HowToPlay";
            this.lbl_HowToPlay.Size = new System.Drawing.Size(239, 43);
            this.lbl_HowToPlay.TabIndex = 0;
            this.lbl_HowToPlay.Text = "How To Play";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(77, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Step 1";
            // 
            // form_Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(823, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_HowToPlay);
            this.Name = "form_Help";
            this.Text = "HELP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HowToPlay;
        private System.Windows.Forms.Label label2;
    }
}