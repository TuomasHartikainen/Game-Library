namespace Game_Library.Forms
{
    partial class Form2
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
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelComputerScore = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.labelWinner = new System.Windows.Forms.Label();
            this.labelComputerChoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRock
            // 
            this.buttonRock.Location = new System.Drawing.Point(12, 29);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(100, 100);
            this.buttonRock.TabIndex = 0;
            this.buttonRock.Text = "Rock";
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.Location = new System.Drawing.Point(118, 29);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(100, 100);
            this.buttonPaper.TabIndex = 1;
            this.buttonPaper.Text = "Paper";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonScissors
            // 
            this.buttonScissors.Location = new System.Drawing.Point(224, 29);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(100, 100);
            this.buttonScissors.TabIndex = 2;
            this.buttonScissors.Text = "Scissors";
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player choice";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(329, 29);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(327, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score:";
            // 
            // labelComputerScore
            // 
            this.labelComputerScore.AutoSize = true;
            this.labelComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelComputerScore.Location = new System.Drawing.Point(327, 72);
            this.labelComputerScore.Name = "labelComputerScore";
            this.labelComputerScore.Size = new System.Drawing.Size(90, 17);
            this.labelComputerScore.TabIndex = 6;
            this.labelComputerScore.Text = "Computer - 0";
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPlayerScore.Location = new System.Drawing.Point(327, 89);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(69, 17);
            this.labelPlayerScore.TabIndex = 7;
            this.labelPlayerScore.Text = "Player - 0";
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelWinner.Location = new System.Drawing.Point(10, 159);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(86, 25);
            this.labelWinner.TabIndex = 8;
            this.labelWinner.Text = "Winner: ";
            // 
            // labelComputerChoice
            // 
            this.labelComputerChoice.AutoSize = true;
            this.labelComputerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelComputerChoice.Location = new System.Drawing.Point(12, 132);
            this.labelComputerChoice.Name = "labelComputerChoice";
            this.labelComputerChoice.Size = new System.Drawing.Size(125, 17);
            this.labelComputerChoice.TabIndex = 9;
            this.labelComputerChoice.Text = "Computers choice:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 191);
            this.Controls.Add(this.labelComputerChoice);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.labelComputerScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Rock paper scissors";
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelComputerScore;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Label labelComputerChoice;
    }
}