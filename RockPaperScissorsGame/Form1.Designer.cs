﻿namespace RockPaperScissorsGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            RockPaperScissors = new GroupBox();
            label3 = new Label();
            label1 = new Label();
            paperButton = new Button();
            scissorButton = new Button();
            rockButton = new Button();
            RockPaperScissors.SuspendLayout();
            SuspendLayout();
            // 
            // RockPaperScissors
            // 
            RockPaperScissors.BackColor = SystemColors.ActiveCaption;
            RockPaperScissors.BackgroundImage = (Image)resources.GetObject("RockPaperScissors.BackgroundImage");
            RockPaperScissors.BackgroundImageLayout = ImageLayout.Center;
            RockPaperScissors.Controls.Add(label3);
            RockPaperScissors.Controls.Add(label1);
            RockPaperScissors.Controls.Add(paperButton);
            RockPaperScissors.Controls.Add(scissorButton);
            RockPaperScissors.Controls.Add(rockButton);
            RockPaperScissors.Location = new Point(-2, 0);
            RockPaperScissors.Margin = new Padding(3, 2, 3, 2);
            RockPaperScissors.Name = "RockPaperScissors";
            RockPaperScissors.Padding = new Padding(3, 2, 3, 2);
            RockPaperScissors.Size = new Size(704, 339);
            RockPaperScissors.TabIndex = 0;
            RockPaperScissors.TabStop = false;
            RockPaperScissors.Text = "RockPaperScissors";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 120);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 45);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Lets Play!";
            // 
            // paperButton
            // 
            paperButton.BackColor = SystemColors.ButtonHighlight;
            paperButton.Location = new Point(315, 202);
            paperButton.Margin = new Padding(3, 2, 3, 2);
            paperButton.Name = "paperButton";
            paperButton.Size = new Size(82, 22);
            paperButton.TabIndex = 2;
            paperButton.Text = "Paper";
            paperButton.UseVisualStyleBackColor = false;
            paperButton.Click += button3_Click;
            // 
            // scissorButton
            // 
            scissorButton.BackColor = SystemColors.ButtonHighlight;
            scissorButton.ForeColor = SystemColors.ActiveCaptionText;
            scissorButton.Location = new Point(477, 141);
            scissorButton.Margin = new Padding(3, 2, 3, 2);
            scissorButton.Name = "scissorButton";
            scissorButton.Size = new Size(82, 22);
            scissorButton.TabIndex = 1;
            scissorButton.Text = "Scissor";
            scissorButton.UseVisualStyleBackColor = false;
            scissorButton.Click += button2_Click;
            // 
            // rockButton
            // 
            rockButton.BackColor = SystemColors.ButtonHighlight;
            rockButton.ForeColor = SystemColors.ActiveCaptionText;
            rockButton.Location = new Point(153, 141);
            rockButton.Margin = new Padding(3, 2, 3, 2);
            rockButton.Name = "rockButton";
            rockButton.Size = new Size(82, 22);
            rockButton.TabIndex = 0;
            rockButton.Text = "Rock";
            rockButton.UseVisualStyleBackColor = false;
            rockButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(RockPaperScissors);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            RockPaperScissors.ResumeLayout(false);
            RockPaperScissors.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RockPaperScissors;
        private Button paperButton;
        private Button scissorButton;
        private Button rockButton;
        private Label label1;
        private Label label3;
    }
}