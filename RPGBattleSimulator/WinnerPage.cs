using System;
using System.Windows.Forms;

namespace RPGBattleSimulator
{
    // Partial class definition for the WinnerForm
    public partial class WinnerPage : Form
    {
        // Constructor that accepts the winner's name as a parameter
        public WinnerPage(string winnerName)
        {
            InitializeComponent(); // Initialize UI components
            lblWinner.Text = $"🏆 {winnerName} wins!"; // Set the label to display the winner's name with a trophy emoji
        }
    }
}
