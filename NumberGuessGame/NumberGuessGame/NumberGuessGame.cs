using System;
using System.Drawing;
using System.Windows.Forms;
using NumberGuessGameService.ServiceReference1;

namespace NumberGuessGame
{
    //This is a windows form coding page where all the logic has been implemented for buttons to generate the secret number and 
    // play button
    public partial class NumberGuessGame : Form
    {
        // Here we initialized the service reference and variables
        private NumberGuessGameServiceClient client;
        private int secretNumber;
        private int attempts;
        public NumberGuessGame()
        {
            InitializeComponent();
            // we created a new instance of the referenced service
            client = new NumberGuessGameServiceClient();
        }
        //Logic to generate the secret number using lower limit and upper limit
        private void btnGenerateSecretNumber_Click(object sender, EventArgs e)
        {
            int lower, upper;
            if(int.TryParse(txtLowerLimit.Text, out lower) && int.TryParse(txtUpperLimit.Text, out upper))
            {// here we called a function called SecretNumber that has been implemented in the service after passing the upper and lower limit
                secretNumber = client.SecretNumber(lower, upper);
                attempts = 0;
                lblAttempts.Text = "Attempts: 0";
                lblNumberIs.Text = "";
            }
            else
            {
                // if the limit values are not appropriate then we prompt this message box
                MessageBox.Show("Please enter valid numbers for limits.");
            }
        }
        // Logic to make number guessing and provide feedback and let us know in how many attempts we have guessed the number right.
        private void btnPlay_Click(object sender, EventArgs e)
        {
            int userGuess;
            if(int.TryParse(txtMakeAGuess.Text, out userGuess))
            {
                // here we called the referenced function CheckNumber in which it passes the secret number and user number.
                attempts++;
                lblAttempts.Text = $"Attempts: {attempts}";
                lblNumberIs.Text = client.CheckNumber(userGuess, secretNumber);
            }
            else
            {
                // if the guess value is not appropriate then we prompt this message box
                MessageBox.Show("Please enter a valid number to guess.");
            }
        }

        private void btnGenerateSecretNumber_MouseHover(object sender, EventArgs e)
        {
            // this will change the colour of the Generate Secret Number button on mouseHover
            btnGenerateSecretNumber.BackColor =Color.Cornsilk;
        }

        private void btnGenerateSecretNumber_MouseLeave(object sender, EventArgs e)
        {
            // this will change the colour of the Generate Secret Number button on mouseLeave
            btnGenerateSecretNumber.BackColor = Color.White;
        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {// this will change the colour of the Play button on mouseHover
            btnPlay.BackColor = Color.Cornsilk;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {// this will change the colour of the Play button on mouseLeave
            btnPlay.BackColor = Color.White;
        }
    }
}
