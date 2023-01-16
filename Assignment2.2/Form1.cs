namespace Assignment2._2
{
    using System;
    using System.Globalization;
    using System.Drawing;

    public partial class Form1 : Form
    {
        /// <summary>
        /// plays counts the number of times they have rolled the dice since the game started.
        /// </summary>
        private int plays = 0;
        /// <summary>
        /// wins counts the number of times that the player has guessed correctly.
        /// </summary>
        private int wins = 0;
        /// <summary>
        /// guessCount counts the number of times the player has guessed each number
        /// [0] for 1, [1] for 2, and so on.
        /// </summary>
        private int[] guessCount = new int[6];
        /// <summary>
        /// rollCount counts the number of times each number has been rolled
        /// [0] for 1, [1] for 2, and so on.
        /// </summary>
        private int[] rollCount = new int[6];
        /// <summary>
        /// die is used to generate a random number when the die is rolled.
        /// </summary>
        private Random die = new Random();


        /// <summary>
        /// Sets up the Form and sets all data to game start.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ResetEverything();
        }

        /// <summary>
        /// Calls the functions that reset each part of game data/display to game start.
        /// </summary>
        private void ResetEverything()
        {
            ResetData();
            ResetPicDie();
        }


        /// <summary>
        /// SetRtbData sets the text in the component rtbData based on the information stored about past plays.
        /// </summary>
        private void SetRtbData()
        {
            rtbData.ResetText();
            rtbData.AppendText("FACE      FREQUENCY   PERCENT     GUESSES\n");
            for (int i = 0; i < 6; i++)
            {
                // Make sure "Frequency" is always the same length
                string frequency = rollCount[i].ToString();
                while (frequency.Length < 4) { frequency = String.Concat(frequency, " "); }
                // Format the Percent and make sure it's always the same length
                double percent = (plays == 0) ? 0 : (double)rollCount[i] / (double)plays;
                string dPercent = string.Format("{0:P2}", percent);
                while (dPercent.Length < 7) { dPercent = String.Concat(dPercent, " "); }
                rtbData.AppendText(string.Format(" {0}         {1}        {2}     {3}\n",
                    i + 1, frequency, dPercent, guessCount[i]));
            }

        }


        /// <summary>
        /// ResetData resets all of the game data to 0 for a game start.
        /// </summary>
        private void ResetData()
        {
            plays = 0;
            wins = 0;
            guessCount = new int[6];
            rollCount = new int[6];

            lblPlayedNum.Text = plays.ToString();
            lblWonNum.Text = wins.ToString();
            lblLostNum.Text = (plays - wins).ToString();

            SetRtbData();
        }

        /// <summary>
        /// ResetPicDie sets the image of component picDie to a blank die for game start.
        /// </summary>
        private void ResetPicDie()
        {
            picDie.SizeMode = PictureBoxSizeMode.StretchImage;
            picDie.Image = Image.FromFile("blank.png");
        }

        /// <summary>
        /// Calls ResetEverything to reset the form back to Game Start.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetEverything();
        }

        /// <summary>
        /// Rolls the dice, then updates the necessary game information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRoll_Click(object sender, EventArgs e)
        {
            // Make the error text invisible if it wasn't already
            lblError.Visible = false;

            // Pick a random number 1-6
            int roll = die.Next(1, 7);

            // Get user input and validate
            String input = txtGuess.Text;
            try
            {
                int guess = Convert.ToInt32(input);

                // Make sure the number fits the range
                if (guess < 1 || guess > 6) 
                {
                    lblError.Visible = true;
                    return;
                }
                
                // TODO: Simulate rolling
                // Set the picture to show the correct die face
                String dieFile = String.Concat(roll, ".png");
                picDie.Image = Image.FromFile(dieFile);

                // Update the game data
                plays++;
                if (guess == roll) wins++;
                guessCount[guess - 1]++;
                rollCount[roll - 1]++;

                // Update the data display
                lblPlayedNum.Text = plays.ToString();
                lblWonNum.Text = wins.ToString();
                lblLostNum.Text = (plays - wins).ToString();
                SetRtbData();
            } catch
            {
                // If we can't get a proper number, show the error
                lblError.Visible = true;
            }
        }
    }

}