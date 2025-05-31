using RPGBattleSimulator;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPGBattleSimulator
{
    public partial class BattlePage : Form
    {
        // Player instances for the two combatants
        private readonly DAExecution player1;
        private readonly DAExecution player2;

        // Images for the players
        private readonly Image player1Image;
        private readonly Image player2Image;

        // Names of the players
        private readonly string player1Name;
        private readonly string player2Name;

        // Boolean to track whose turn it is
        private bool player1Turn = true;

        // Random number generator for any random events
        private readonly Random rand = new Random();

        // Constructor to initialize the battle form with player details
        public BattlePage(string player1Name, DAExecution player1, Image player1Image,
                          string player2Name, DAExecution player2, Image player2Image)
        {
            InitializeComponent(); // Initialize the form components

            // Assign player names and instances
            this.player1Name = player1Name;
            this.player1 = player1;
            this.player1Image = player1Image;

            this.player2Name = player2Name;
            this.player2 = player2;
            this.player2Image = player2Image;

            SetupUI(); // Set up the user interface
            UpdateUI(); // Update the UI with initial values
        }

        // Method to set up the user interface elements
        private void SetupUI()
        {
            // Set player names and images in the UI
            lblPlayer1Name.Text = player1Name + " (" + player1.Name + ")";
            pbPlayer1.Image = player1Image;
            pbPlayer1.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlayer1.BorderStyle = BorderStyle.FixedSingle;

            lblPlayer2Name.Text = player2Name + " (" + player2.Name + ")";
            pbPlayer2.Image = player2Image;
            pbPlayer2.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlayer2.BorderStyle = BorderStyle.FixedSingle;

            // Set the maximum health for the progress bars
            progressBarPlayer1.Maximum = player1.MaxHealth;
            progressBarPlayer1.Value = player1.Health;
            progressBarPlayer2.Maximum = player2.MaxHealth;
            progressBarPlayer2.Value = player2.Health;

            // Initialize the battle log
            lblBattleLog.Text = "Click 'Attack' to start the battle!";
        }

        // Method to update the UI with current health values
        private void UpdateUI()
        {
            // Update health progress bars and labels
            progressBarPlayer1.Value = player1.Health;
            progressBarPlayer2.Value = player2.Health;
            lblPlayer1Health.Text = $"HP: {player1.Health}/{player1.MaxHealth}";
            lblPlayer2Health.Text = $"HP: {player2.Health}/{player2.MaxHealth}";
        }

        // Event handler for the attack button click
        private void btnAttack_Click(object sender, EventArgs e)
        {
            // Check if either player is already defeated
            if (player1.Health == 0 || player2.Health == 0)
                return;

            string log; // Log message for the battle
            int damage; // Damage dealt in the attack

            // Determine which player's turn it is and perform the attack
            if (player1Turn)
            {
                damage = player1.Attack(); // Player 1 attacks
                player2.TakeDamage(damage); // Player 2 takes damage
                log = $"{player1Name} ({player1.Name}) attacks {player2Name} ({player2.Name}) for {damage} damage!";
            }
            else
            {
                damage = player2.Attack(); // Player 2 attacks
                player1.TakeDamage(damage); // Player 1 takes damage
                log = $"{player2Name} ({player2.Name}) attacks {player1Name} ({player1.Name}) for {damage} damage!";
            }

            // Update the battle log with the attack message
            lblBattleLog.Text = log;
            UpdateUI(); // Refresh the UI to show updated health

            // Check if the battle has ended
            if (player1.Health == 0 || player2.Health == 0)
            {
                // Determine the winner and show the winner form
                string winner = player1.Health > 0 ? player1Name : player2Name;
                WinnerPage winnerForm = new WinnerPage(winner);
                winnerForm.ShowDialog(); // Show the winner dialog

                btnAttack.Enabled = false; // Disable the attack button
                return;
            }

            // Switch turns
            player1Turn = !player1Turn;
        }
    }
}
