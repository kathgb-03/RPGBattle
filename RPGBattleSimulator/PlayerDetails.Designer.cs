namespace RPGBattleSimulator
{
    partial class PlayerDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2Name = new System.Windows.Forms.TextBox();
            this.buttonStartBattle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPlayer1Name
            // 
            this.textBoxPlayer1Name.Location = new System.Drawing.Point(20, 45);
            this.textBoxPlayer1Name.Name = "textBoxPlayer1Name";
            this.textBoxPlayer1Name.Size = new System.Drawing.Size(205, 22);
            this.textBoxPlayer1Name.TabIndex = 2;
            // 
            // textBoxPlayer2Name
            // 
            this.textBoxPlayer2Name.Location = new System.Drawing.Point(565, 45);
            this.textBoxPlayer2Name.Name = "textBoxPlayer2Name";
            this.textBoxPlayer2Name.Size = new System.Drawing.Size(205, 22);
            this.textBoxPlayer2Name.TabIndex = 3;
            // 
            // buttonStartBattle
            // 
            this.buttonStartBattle.Location = new System.Drawing.Point(380, 390);
            this.buttonStartBattle.Name = "buttonStartBattle";
            this.buttonStartBattle.Size = new System.Drawing.Size(137, 32);
            this.buttonStartBattle.TabIndex = 4;
            this.buttonStartBattle.Text = "Start Battle";
            this.buttonStartBattle.UseVisualStyleBackColor = true;
            this.buttonStartBattle.Click += new System.EventHandler(this.buttonStartBattle_Click);
            // 
            // PlayerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.buttonStartBattle);
            this.Controls.Add(this.textBoxPlayer2Name);
            this.Controls.Add(this.textBoxPlayer1Name);
            this.Name = "PlayerDetails";
            this.Text = "Player Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxPlayer1Name;
        private System.Windows.Forms.TextBox textBoxPlayer2Name;
        private System.Windows.Forms.Button buttonStartBattle;
    }
}
