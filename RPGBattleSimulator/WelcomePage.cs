using System;
using System.Windows.Forms;

namespace RPGBattleSimulator
{
    public partial class WelcomePage : Form
    {
        private Button btnStart; // Declare the Start button
        private PictureBox pbBackground; // Declare the PictureBox for background

        public WelcomePage()
        {
            InitializeComponent(); // Initialize the form components
            InitializeCustomComponents(); // Call the method to initialize custom components
        }

        private void InitializeCustomComponents()
        {

            // Initialize the Start button
            btnStart = new Button
            {
                BackColor = System.Drawing.Color.Navy, // button background color
                Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F), // button font
                ForeColor = System.Drawing.Color.White, // button text color
                Location = new System.Drawing.Point(330, 280), // button position
                Name = "btnStart", //name of the button
                Size = new System.Drawing.Size(152, 57), // button size
                Text = "Start", // button text
                UseVisualStyleBackColor = false
            };
            btnStart.Click += new EventHandler(this.btnStart_Click); // attach click event handler

            this.Controls.Add(btnStart); // add Start button to the form

            pbBackground = new PictureBox
            {
                Dock = DockStyle.Fill, // fill the form with the PictureBox
                Image = global::RPGBattleSimulator.Properties.Resources.DA_ExecutION, // set the background image
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add(pbBackground); // add picturebox to the form
        }

        // event handler for the start button click
        private void btnStart_Click(object sender, EventArgs e)
        {
            // open the next form 
            PlayerDetails gameForm = new PlayerDetails();
            gameForm.Show(); // show the PlayerDetails form
            this.Hide(); // hide the welcome form
        }
    }
}
