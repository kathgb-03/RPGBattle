using RPGBattleSimulator;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPGBattleSimulator
{
    public partial class PlayerDetails : Form
    {
        // Arrays to hold PictureBoxes and Labels for both players
        private PictureBox[] player1Characters;
        private PictureBox[] player2Characters;
        private Label[] player1Labels;
        private Label[] player2Labels;

        // Indexes to track selected character per player
        private int selectedPlayer1Index = -1;
        private int selectedPlayer2Index = -1;

        // Character names and image storage
        private string[] characterNames = { "SyntaxSlayer Lara", "CodeReaper Aeron", "DataWrecker Jewelle" };
        private Image[] characterImages;

        // Constructor
        public PlayerDetails()
        {
            InitializeComponent();
            Load += PlayerDetailsForm_Load; // Hook form load event
        }

        // Runs when the form is loaded
        private void PlayerDetailsForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(245, 245, 255); // Set form background color

            int offsetY = 50;

            try
            {
                // Load character images from the images folder
                characterImages = new Image[]
                {
                    Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "images", "lara.png")),
                    Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "images", "aeron.png")),
                    Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "images", "jiwil.png"))
                };
            }
            catch (Exception ex)
            {
                // Display error if images can't be loaded
                MessageBox.Show("Error loading character images: " + ex.Message, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dimensions and spacing for character images
            int imageWidth = 100;
            int imageHeight = 100;
            int spacing = 30;

            // Create and add label for Player 1
            Label lblPlayer1 = new Label
            {
                Text = "Player 1",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.MediumSlateBlue,
                Left = textBoxPlayer1Name.Left,
                Top = textBoxPlayer1Name.Top - 30 + offsetY
            };
            Controls.Add(lblPlayer1);

            // Create and add label for Player 2
            Label lblPlayer2 = new Label
            {
                Text = "Player 2",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.MediumSlateBlue,
                Left = textBoxPlayer2Name.Left,
                Top = textBoxPlayer2Name.Top - 30 + offsetY
            };
            Controls.Add(lblPlayer2);

            // Adjust position and style of player name text boxes
            textBoxPlayer1Name.Top += offsetY;
            textBoxPlayer2Name.Top += offsetY;

            textBoxPlayer1Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxPlayer2Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            // Label for Player 1's characters
            Label lblPlayer1Characters = new Label
            {
                Text = "Characters",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.MediumSlateBlue,
                Left = textBoxPlayer1Name.Left,
                Top = textBoxPlayer1Name.Bottom + 10
            };
            Controls.Add(lblPlayer1Characters);

            // Initialize and layout Player 1's characters and labels
            int player1StartX = textBoxPlayer1Name.Left;
            int player1StartY = lblPlayer1Characters.Bottom + 5;

            player1Characters = new PictureBox[characterImages.Length];
            player1Labels = new Label[characterImages.Length];

            for (int i = 0; i < characterImages.Length; i++)
            {
                // Character image (clickable)
                PictureBox pb = new PictureBox
                {
                    Image = characterImages[i],
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = imageWidth,
                    Height = imageHeight,
                    Left = player1StartX + i * (imageWidth + spacing),
                    Top = player1StartY,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Tag = i // Store index
                };
                pb.Click += Player1Character_Click; // Add click handler
                Controls.Add(pb);
                player1Characters[i] = pb;

                // Character name label
                Label lbl = new Label
                {
                    Text = characterNames[i],
                    Font = new Font("Segoe UI", 6F, FontStyle.Regular),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Top = pb.Bottom + 5,
                    Left = pb.Left,
                    Width = pb.Width
                };
                Controls.Add(lbl);
                player1Labels[i] = lbl;
            }

            // Label for Player 2's characters
            Label lblPlayer2Characters = new Label
            {
                Text = "Characters",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.MediumSlateBlue,
                Left = textBoxPlayer2Name.Left,
                Top = textBoxPlayer2Name.Bottom + 10
            };
            Controls.Add(lblPlayer2Characters);

            // Initialize and layout Player 2's characters and labels
            int player2StartX = textBoxPlayer2Name.Left;
            int player2StartY = lblPlayer2Characters.Bottom + 5;

            player2Characters = new PictureBox[characterImages.Length];
            player2Labels = new Label[characterImages.Length];

            for (int i = 0; i < characterImages.Length; i++)
            {
                PictureBox pb = new PictureBox
                {
                    Image = characterImages[i],
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = imageWidth,
                    Height = imageHeight,
                    Left = player2StartX + i * (imageWidth + spacing),
                    Top = player2StartY,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Tag = i
                };
                pb.Click += Player2Character_Click;
                Controls.Add(pb);
                player2Characters[i] = pb;

                Label lbl = new Label
                {
                    Text = characterNames[i],
                    Font = new Font("Segoe UI", 6F, FontStyle.Regular),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Top = pb.Bottom + 5,
                    Left = pb.Left,
                    Width = pb.Width
                };
                Controls.Add(lbl);
                player2Labels[i] = lbl;
            }

            // Style and position the Start Battle button
            buttonStartBattle.Text = "Start Battle";
            buttonStartBattle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonStartBattle.BackColor = Color.MediumSlateBlue;
            buttonStartBattle.ForeColor = Color.White;
            buttonStartBattle.FlatStyle = FlatStyle.Flat;
            buttonStartBattle.Width = 220;
            buttonStartBattle.Height = 55;
            buttonStartBattle.Top = player2Labels[0].Bottom + 50;
            buttonStartBattle.Left = (this.ClientSize.Width - buttonStartBattle.Width) / 2 + 10;
        }

        // Handles character selection for Player 1
        private void Player1Character_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox clicked)
            {
                selectedPlayer1Index = (int)clicked.Tag;
                UpdateSelectionBorders(player1Characters, selectedPlayer1Index); // Highlight selected
            }
        }

        // Handles character selection for Player 2
        private void Player2Character_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox clicked)
            {
                selectedPlayer2Index = (int)clicked.Tag;
                UpdateSelectionBorders(player2Characters, selectedPlayer2Index); // Highlight selected
            }
        }

        // Updates the border style of selected/unselected character images
        private void UpdateSelectionBorders(PictureBox[] characterBoxes, int selectedIndex)
        {
            for (int i = 0; i < characterBoxes.Length; i++)
            {
                characterBoxes[i].BorderStyle = i == selectedIndex ? BorderStyle.Fixed3D : BorderStyle.FixedSingle;
            }
        }

        // Handles logic when Start Battle button is clicked
        private void buttonStartBattle_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure both players have selected characters
                if (selectedPlayer1Index == -1 || selectedPlayer2Index == -1)
                {
                    MessageBox.Show("Both players must select a character.", "Selection Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Prevent both players from choosing the same character
                if (selectedPlayer1Index == selectedPlayer2Index)
                {
                    MessageBox.Show("Players must choose different characters.", "Duplicate Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Retrieve and validate player names
                string player1Name = textBoxPlayer1Name.Text.Trim();
                string player2Name = textBoxPlayer2Name.Text.Trim();

                if (string.IsNullOrWhiteSpace(player1Name) || string.IsNullOrWhiteSpace(player2Name))
                {
                    MessageBox.Show("Both players must enter their names.", "Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Instantiate selected characters
                DAExecution player1Char = null;
                DAExecution player2Char = null;

                switch (selectedPlayer1Index)
                {
                    case 0: player1Char = new SyntaxSlayerLara(); break;
                    case 1: player1Char = new CodeReaperAeron(); break;
                    case 2: player1Char = new DataWreckerJewelle(); break;
                }

                switch (selectedPlayer2Index)
                {
                    case 0: player2Char = new SyntaxSlayerLara(); break;
                    case 1: player2Char = new CodeReaperAeron(); break;
                    case 2: player2Char = new DataWreckerJewelle(); break;
                }

                // Open the BattleForm and pass in character objects and images
                BattlePage battleForm = new BattlePage(
                    player1Name, player1Char, characterImages[selectedPlayer1Index],
                    player2Name, player2Char, characterImages[selectedPlayer2Index]
                );
                this.Hide(); // Hide current form
                battleForm.ShowDialog(); // Show battle form modally
                this.Show(); // Show current form again after battle
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show("An error occurred while starting the battle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
