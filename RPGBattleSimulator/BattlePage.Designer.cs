namespace RPGBattleSimulator
{
    partial class BattlePage
    {
        // Container for the form's components
        private System.ComponentModel.IContainer components = null;

        // Method to dispose of resources
        protected override void Dispose(bool disposing)
        {
            // Dispose of components if they are not null
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Method to initialize the form's components
        private void InitializeComponent()
        {
            // Initialize UI components
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblBattleLog = new System.Windows.Forms.Label();
            this.groupBoxPlayer1 = new System.Windows.Forms.GroupBox();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.progressBarPlayer1 = new System.Windows.Forms.ProgressBar();
            this.lblPlayer1Health = new System.Windows.Forms.Label();
            this.groupBoxPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.progressBarPlayer2 = new System.Windows.Forms.ProgressBar();
            this.lblPlayer2Health = new System.Windows.Forms.Label();

            // Begin initialization of PictureBox for Player 1
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            // Begin initialization of PictureBox for Player 2
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            // Begin initialization of GroupBox for Player 1
            this.groupBoxPlayer1.SuspendLayout();
            // Begin initialization of GroupBox for Player 2
            this.groupBoxPlayer2.SuspendLayout();
            // Suspend layout to optimize performance during initialization
            this.SuspendLayout();

            // 
            // pbPlayer1
            // 
            this.pbPlayer1.BackColor = System.Drawing.Color.Transparent; // Set background to transparent
            this.pbPlayer1.Location = new System.Drawing.Point(47, 316); // Set position on the form
            this.pbPlayer1.Name = "pbPlayer1"; // Name of the PictureBox
            this.pbPlayer1.Size = new System.Drawing.Size(211, 206); // Set size of the PictureBox
            this.pbPlayer1.TabIndex = 2; // Tab index for focus order
            this.pbPlayer1.TabStop = false; // Indicates that the PictureBox cannot be selected

            // 
            // pbPlayer2
            // 
            this.pbPlayer2.BackColor = System.Drawing.Color.Transparent; // Set background to transparent
            this.pbPlayer2.Location = new System.Drawing.Point(772, 41); // Set position on the form
            this.pbPlayer2.Name = "pbPlayer2"; // Name of the PictureBox
            this.pbPlayer2.Size = new System.Drawing.Size(211, 206); // Set size of the PictureBox
            this.pbPlayer2.TabIndex = 3; // Tab index for focus order
            this.pbPlayer2.TabStop = false; // Indicates that the PictureBox cannot be selected

            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); // Set button background color
            this.btnAttack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); // Set button font
            this.btnAttack.Location = new System.Drawing.Point(716, 316); // Set position on the form
            this.btnAttack.Name = "btnAttack"; // Name of the button
            this.btnAttack.Size = new System.Drawing.Size(267, 206); // Set size of the button
            this.btnAttack.TabIndex = 8; // Tab index for focus order
            this.btnAttack.Text = "Attack"; // Button text
            this.btnAttack.UseVisualStyleBackColor = false; // Use the specified background color
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click); // Attach click event handler

            // 
            // lblBattleLog
            // 
            this.lblBattleLog.BackColor = System.Drawing.Color.Transparent; // Set background to transparent
            this.lblBattleLog.Font = new System.Drawing.Font("Segoe UI", 10F); // Set label font
            this.lblBattleLog.Location = new System.Drawing.Point(20, 20); // Set position on the form
            this.lblBattleLog.Name = "lblBattleLog"; // Name of the label
            this.lblBattleLog.Size = new System.Drawing.Size(400, 80); // Set size of the label
            this.lblBattleLog.TabIndex = 9; // Tab index for focus order

            // 
            // groupBoxPlayer1
            // 
            this.groupBoxPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))); // Set background color
            this.groupBoxPlayer1.Controls.Add(this.lblPlayer1Name); // Add player name label to group box
            this.groupBoxPlayer1.Controls.Add(this.progressBarPlayer1); // Add health progress bar to group box
            this.groupBoxPlayer1.Controls.Add(this.lblPlayer1Health); // Add health label to group box
            this.groupBoxPlayer1.Location = new System.Drawing.Point(273, 316); // Set position on the form
            this.groupBoxPlayer1.Name = "groupBoxPlayer1"; // Name of the group box
            this.groupBoxPlayer1.Size = new System.Drawing.Size(277, 117); // Set size of the group box
            this.groupBoxPlayer1.TabIndex = 10; // Tab index for focus order
            this.groupBoxPlayer1.TabStop = false; // Indicates that the group box can be selected
            this.groupBoxPlayer1.Text = "Player 1"; // Group box title

            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Set label font
            this.lblPlayer1Name.Location = new System.Drawing.Point(10, 20); // Set position in the group box
            this.lblPlayer1Name.Name = "lblPlayer1Name"; // Name of the label
            this.lblPlayer1Name.Size = new System.Drawing.Size(250, 24); // Set size of the label
            this.lblPlayer1Name.TabIndex = 0; // Tab index for focus order
            this.lblPlayer1Name.Text = "Player 1"; // Default text for the label

            // 
            // progressBarPlayer1
            // 
            this.progressBarPlayer1.Location = new System.Drawing.Point(10, 50); // Set position in the group box
            this.progressBarPlayer1.Name = "progressBarPlayer1"; // Name of the progress bar
            this.progressBarPlayer1.Size = new System.Drawing.Size(250, 29); // Set size of the progress bar
            this.progressBarPlayer1.TabIndex = 1; // Tab index for focus order

            // 
            // lblPlayer1Health
            // 
            this.lblPlayer1Health.Location = new System.Drawing.Point(10, 82); // Set position in the group box
            this.lblPlayer1Health.Name = "lblPlayer1Health"; // Name of the label
            this.lblPlayer1Health.Size = new System.Drawing.Size(250, 20); // Set size of the label
            this.lblPlayer1Health.TabIndex = 2; // Tab index for focus order
            this.lblPlayer1Health.Text = "HP:"; // Default text for the label

            // 
            // groupBoxPlayer2
            // 
            this.groupBoxPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))); // Set background color
            this.groupBoxPlayer2.Controls.Add(this.lblPlayer2Name); // Add player name label to group box
            this.groupBoxPlayer2.Controls.Add(this.progressBarPlayer2); // Add health progress bar to group box
            this.groupBoxPlayer2.Controls.Add(this.lblPlayer2Health); // Add health label to group box
            this.groupBoxPlayer2.Location = new System.Drawing.Point(489, 41); // Set position on the form
            this.groupBoxPlayer2.Name = "groupBoxPlayer2"; // Name of the group box
            this.groupBoxPlayer2.Size = new System.Drawing.Size(277, 117); // Set size of the group box
            this.groupBoxPlayer2.TabIndex = 11; // Tab index for focus order
            this.groupBoxPlayer2.TabStop = false; // Indicates that the group box can be selected
            this.groupBoxPlayer2.Text = "Player 2"; // Group box title

            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Set label font
            this.lblPlayer2Name.Location = new System.Drawing.Point(10, 20); // Set position in the group box
            this.lblPlayer2Name.Name = "lblPlayer2Name"; // Name of the label
            this.lblPlayer2Name.Size = new System.Drawing.Size(250, 24); // Set size of the label
            this.lblPlayer2Name.TabIndex = 0; // Tab index for focus order
            this.lblPlayer2Name.Text = "Player 2"; // Default text for the label

            // 
            // progressBarPlayer2
            // 
            this.progressBarPlayer2.Location = new System.Drawing.Point(10, 50); // Set position in the group box
            this.progressBarPlayer2.Name = "progressBarPlayer2"; // Name of the progress bar
            this.progressBarPlayer2.Size = new System.Drawing.Size(250, 29); // Set size of the progress bar
            this.progressBarPlayer2.TabIndex = 1; // Tab index for focus order

            // 
            // lblPlayer2Health
            // 
            this.lblPlayer2Health.Location = new System.Drawing.Point(10, 82); // Set position in the group box
            this.lblPlayer2Health.Name = "lblPlayer2Health"; // Name of the label
            this.lblPlayer2Health.Size = new System.Drawing.Size(250, 20); // Set size of the label
            this.lblPlayer2Health.TabIndex = 2; // Tab index for focus order
            this.lblPlayer2Health.Text = "HP:"; // Default text for the label

            // 
            // BattleForm
            // 
            this.BackgroundImage = global::RPGBattleSimulator.Properties.Resources.battle_bg; // Set background image for the form
            this.ClientSize = new System.Drawing.Size(1062, 553); // Set size of the form
            this.Controls.Add(this.groupBoxPlayer1); // Add Player 1 group box to the form
            this.Controls.Add(this.groupBoxPlayer2); // Add Player 2 group box to the form
            this.Controls.Add(this.pbPlayer1); // Add Player 1 PictureBox to the form
            this.Controls.Add(this.pbPlayer2); // Add Player 2 PictureBox to the form
            this.Controls.Add(this.btnAttack); // Add Attack button to the form
            this.Controls.Add(this.lblBattleLog); // Add battle log label to the form
            this.Name = "BattleForm"; // Set the name of the form
            this.Text = "Battle Arena"; // Set the title of the form
            // End initialization of PictureBox for Player 1
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            // End initialization of PictureBox for Player 2
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            // End initialization of GroupBox for Player 1
            this.groupBoxPlayer1.ResumeLayout(false);
            // End initialization of GroupBox for Player 2
            this.groupBoxPlayer2.ResumeLayout(false);
            // Resume layout after initialization
            this.ResumeLayout(false);
        }

        #endregion

        // UI components declaration
        private System.Windows.Forms.PictureBox pbPlayer1; // PictureBox for Player 1
        private System.Windows.Forms.PictureBox pbPlayer2; // PictureBox for Player 2
        private System.Windows.Forms.Button btnAttack; // Button to initiate an attack
        private System.Windows.Forms.Label lblBattleLog; // Label to display battle log messages
        private System.Windows.Forms.GroupBox groupBoxPlayer1; // GroupBox for Player 1's UI elements
        private System.Windows.Forms.Label lblPlayer1Name; // Label for Player 1's name
        private System.Windows.Forms.ProgressBar progressBarPlayer1; // ProgressBar for Player 1's health
        private System.Windows.Forms.Label lblPlayer1Health; // Label for Player 1's health status
        private System.Windows.Forms.GroupBox groupBoxPlayer2; // GroupBox for Player 2's UI elements
        private System.Windows.Forms.Label lblPlayer2Name; // Label for Player 2's name
        private System.Windows.Forms.ProgressBar progressBarPlayer2; // ProgressBar for Player 2's health
        private System.Windows.Forms.Label lblPlayer2Health; // Label for Player 2's health status
    }
}
