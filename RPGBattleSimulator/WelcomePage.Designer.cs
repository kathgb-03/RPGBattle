namespace RPGBattleSimulator
{
    // Partial class definition for the WelcomeForm
    partial class WelcomePage
    {
        // Container to hold form components (e.g., controls, resources)
        private System.ComponentModel.IContainer components = null;

        // Override Dispose to clean up any resources being used
        protected override void Dispose(bool disposing)
        {
            // If disposing is true and components are not null, dispose them
            if (disposing && (components != null))
            {
                components.Dispose(); // Release component resources
            }
            base.Dispose(disposing); // Call base class Dispose method
        }

        // Method to initialize and configure the form and its components
        private void InitializeComponent()
        {
            // Suspend layout logic while form controls are being added and configured
            this.SuspendLayout();

            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Set DPI scaling dimensions
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Set scaling mode based on font
            this.ClientSize = new System.Drawing.Size(1062, 553); // Set form size (width x height in pixels)
            this.Name = "WelcomePage"; // Internal name of the form
            this.Text = "Welcome"; // Title text shown on the form's title bar
            this.ResumeLayout(false); // Resume layout logic after setup
        }
    }
}
