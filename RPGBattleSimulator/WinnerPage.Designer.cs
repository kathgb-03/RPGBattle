namespace RPGBattleSimulator
{
    partial class WinnerPage
    {
        // Container to hold the form components
        private System.ComponentModel.IContainer components = null;

        // Dispose of resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose(); // Dispose if components exist
            base.Dispose(disposing); // Call base class Dispose
        }

        // Method that initializes and sets up the UI components of the form
        private void InitializeComponent()
        {
            this.lblWinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWinner.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold);
            this.lblWinner.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblWinner.Location = new System.Drawing.Point(0, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(754, 374);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "🏆 Winner Here!";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinnerPage
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(754, 374);
            this.Controls.Add(this.lblWinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WinnerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle Result";
            this.ResumeLayout(false);

        }

        // Label control to display the winner
        private System.Windows.Forms.Label lblWinner;
    }
}
