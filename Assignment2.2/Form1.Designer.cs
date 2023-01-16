namespace Assignment2._2
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
            this.gbxGameInfo = new System.Windows.Forms.GroupBox();
            this.lblLostNum = new System.Windows.Forms.Label();
            this.lblWonNum = new System.Windows.Forms.Label();
            this.lblPlayedNum = new System.Windows.Forms.Label();
            this.lblTimesLost = new System.Windows.Forms.Label();
            this.lblTimesWon = new System.Windows.Forms.Label();
            this.lblTimesPlayed = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.picDie = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.gbxGameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxGameInfo
            // 
            this.gbxGameInfo.Controls.Add(this.lblLostNum);
            this.gbxGameInfo.Controls.Add(this.lblWonNum);
            this.gbxGameInfo.Controls.Add(this.lblPlayedNum);
            this.gbxGameInfo.Controls.Add(this.lblTimesLost);
            this.gbxGameInfo.Controls.Add(this.lblTimesWon);
            this.gbxGameInfo.Controls.Add(this.lblTimesPlayed);
            this.gbxGameInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxGameInfo.Name = "gbxGameInfo";
            this.gbxGameInfo.Size = new System.Drawing.Size(250, 125);
            this.gbxGameInfo.TabIndex = 0;
            this.gbxGameInfo.TabStop = false;
            this.gbxGameInfo.Text = "Game Info";
            // 
            // lblLostNum
            // 
            this.lblLostNum.AutoSize = true;
            this.lblLostNum.Location = new System.Drawing.Point(210, 102);
            this.lblLostNum.Name = "lblLostNum";
            this.lblLostNum.Size = new System.Drawing.Size(17, 20);
            this.lblLostNum.TabIndex = 2;
            this.lblLostNum.Text = "0";
            // 
            // lblWonNum
            // 
            this.lblWonNum.AutoSize = true;
            this.lblWonNum.Location = new System.Drawing.Point(210, 64);
            this.lblWonNum.Name = "lblWonNum";
            this.lblWonNum.Size = new System.Drawing.Size(17, 20);
            this.lblWonNum.TabIndex = 4;
            this.lblWonNum.Text = "0";
            // 
            // lblPlayedNum
            // 
            this.lblPlayedNum.AutoSize = true;
            this.lblPlayedNum.Location = new System.Drawing.Point(210, 23);
            this.lblPlayedNum.Name = "lblPlayedNum";
            this.lblPlayedNum.Size = new System.Drawing.Size(17, 20);
            this.lblPlayedNum.TabIndex = 1;
            this.lblPlayedNum.Text = "0";
            // 
            // lblTimesLost
            // 
            this.lblTimesLost.AutoSize = true;
            this.lblTimesLost.Location = new System.Drawing.Point(6, 102);
            this.lblTimesLost.Name = "lblTimesLost";
            this.lblTimesLost.Size = new System.Drawing.Size(158, 20);
            this.lblTimesLost.TabIndex = 3;
            this.lblTimesLost.Text = "Number of Times Lost:";
            // 
            // lblTimesWon
            // 
            this.lblTimesWon.AutoSize = true;
            this.lblTimesWon.Location = new System.Drawing.Point(6, 64);
            this.lblTimesWon.Name = "lblTimesWon";
            this.lblTimesWon.Size = new System.Drawing.Size(161, 20);
            this.lblTimesWon.TabIndex = 2;
            this.lblTimesWon.Text = "Number of Times Won:";
            // 
            // lblTimesPlayed
            // 
            this.lblTimesPlayed.AutoSize = true;
            this.lblTimesPlayed.Location = new System.Drawing.Point(6, 23);
            this.lblTimesPlayed.Name = "lblTimesPlayed";
            this.lblTimesPlayed.Size = new System.Drawing.Size(175, 20);
            this.lblTimesPlayed.TabIndex = 1;
            this.lblTimesPlayed.Text = "Number of Times Played:";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(18, 155);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(156, 20);
            this.lblGuess.TabIndex = 1;
            this.lblGuess.Text = "Enter your guess (1-6):";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(203, 152);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(59, 27);
            this.txtGuess.TabIndex = 2;
            // 
            // picDie
            // 
            this.picDie.Location = new System.Drawing.Point(18, 198);
            this.picDie.Name = "picDie";
            this.picDie.Size = new System.Drawing.Size(128, 128);
            this.picDie.TabIndex = 3;
            this.picDie.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(181, 198);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(94, 29);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(181, 260);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // rtbData
            // 
            this.rtbData.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbData.Location = new System.Drawing.Point(18, 345);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(461, 247);
            this.rtbData.TabIndex = 6;
            this.rtbData.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 604);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picDie);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.gbxGameInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxGameInfo.ResumeLayout(false);
            this.gbxGameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbxGameInfo;
        private Label lblLostNum;
        private Label lblWonNum;
        private Label lblPlayedNum;
        private Label lblTimesLost;
        private Label lblTimesWon;
        private Label lblTimesPlayed;
        private Label lblGuess;
        private TextBox txtGuess;
        private PictureBox picDie;
        private Button btnRoll;
        private Button btnReset;
        private RichTextBox rtbData;
    }
}