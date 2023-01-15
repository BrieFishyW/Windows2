namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// plays counts the number of times they have rolled the dice since the game started
        /// </summary>
        private int plays = 0;
        /// <summary>
        /// wins counts the number of times that the player has guessed correctly
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
            SetRtbData();
            ResetPicDie();
        }


        /// <summary>
        /// SetRtbData sets the text in the component rtbData based on the information stored about past plays.
        /// </summary>
        private void SetRtbData()
        {
            rtbData.ResetText();
            rtbData.AppendText("FACE      FREQUENCY   PERCENT     GUESSES\n");
            for (int i = 0; i < 6; i++) {
                if (plays == 0)
                {
                    rtbData.AppendText(string.Format(" {0}         {1}           {2}     {3}\n",
                        i + 1, 0, "N/A    ", 0));
                }
                else
                {
                    rtbData.AppendText(string.Format($" {0}         {1}          {2}     {3}\n",
                        i + 1, rollCount[i], (guessCount[i] / plays), guessCount[i]));
                }
            }

        }


        /// <summary>
        /// ResetData resets all of the game data to 0 for a game start.
        /// </summary>
        private void ResetData()
        {
            plays= 0;
            wins= 0;
            guessCount = new int[6];
            rollCount = new int[6];

            SetRtbData();
        }

        /// <summary>
        /// ResetPicDie sets the image of component picDie to a blank die for game start.
        /// </summary>
        private void ResetPicDie()
        {
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
    }
}