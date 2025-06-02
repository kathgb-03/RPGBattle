using RPGBattleSimulator;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPGBattleSimulator
{
    public partial class BattlePage : Form
    {
        private readonly DAExecution player1;
        private readonly DAExecution player2;
        private readonly Image player1Image;
        private readonly Image player2Image;
        private readonly string player1Name;
        private readonly string player2Name;
        private bool player1Turn = true;
        private readonly Random rand = new Random();

        // Animation variables
        private Timer attackEffectTimer = new Timer();
        private PictureBox targetToShake;
        private int originalX;
        private int shakeCount = 0;
        private int flashCount = 0;
        private Color originalBackColor;

        public BattlePage(string player1Name, DAExecution player1, Image player1Image,
                          string player2Name, DAExecution player2, Image player2Image)
        {
            InitializeComponent();

            this.player1Name = player1Name;
            this.player1 = player1;
            this.player1Image = player1Image;

            this.player2Name = player2Name;
            this.player2 = player2;
            this.player2Image = player2Image;

            SetupUI();
            UpdateUI();
        }

        private void SetupUI()
        {
            lblPlayer1Name.Text = player1Name + " (" + player1.Name + ")";
            pbPlayer1.Image = player1Image;
            pbPlayer1.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlayer1.BorderStyle = BorderStyle.FixedSingle;

            lblPlayer2Name.Text = player2Name + " (" + player2.Name + ")";
            pbPlayer2.Image = player2Image;
            pbPlayer2.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlayer2.BorderStyle = BorderStyle.FixedSingle;

            progressBarPlayer1.Maximum = player1.MaxHealth;
            progressBarPlayer1.Value = player1.Health;
            progressBarPlayer2.Maximum = player2.MaxHealth;
            progressBarPlayer2.Value = player2.Health;

            lblBattleLog.Text = "Click 'Attack' to start the battle!";
        }

        private void UpdateUI()
        {
            progressBarPlayer1.Value = player1.Health;
            progressBarPlayer2.Value = player2.Health;
            lblPlayer1Health.Text = $"HP: {player1.Health}/{player1.MaxHealth}";
            lblPlayer2Health.Text = $"HP: {player2.Health}/{player2.MaxHealth}";
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (player1.Health == 0 || player2.Health == 0) return;

            string log;
            int damage;

            if (player1Turn)
            {
                damage = player1.Attack();
                player2.TakeDamage(damage);
                log = $"{player1Name} ({player1.Name}) attacks {player2Name} ({player2.Name}) for {damage} damage!";
                AnimateHit(pbPlayer2);
            }
            else
            {
                damage = player2.Attack();
                player1.TakeDamage(damage);
                log = $"{player2Name} ({player2.Name}) attacks {player1Name} ({player1.Name}) for {damage} damage!";
                AnimateHit(pbPlayer1);
            }

            lblBattleLog.Text = log;
            UpdateUI();

            if (player1.Health == 0 || player2.Health == 0)
            {
                string winner = player1.Health > 0 ? player1Name : player2Name;
                WinnerPage winnerForm = new WinnerPage(winner);
                winnerForm.ShowDialog();
                btnAttack.Enabled = false;
                return;
            }

            player1Turn = !player1Turn;
        }

        // Animation for hit: shake + flash
        private void AnimateHit(PictureBox target)
        {
            targetToShake = target;
            originalX = target.Left;
            originalBackColor = target.BackColor;
            shakeCount = 0;
            flashCount = 0;

            attackEffectTimer.Interval = 40;
            attackEffectTimer.Tick -= AttackEffectTimer_Tick;
            attackEffectTimer.Tick += AttackEffectTimer_Tick;
            attackEffectTimer.Start();
        }

        private void AttackEffectTimer_Tick(object sender, EventArgs e)
        {
            if (shakeCount < 6)
            {
                targetToShake.Left = (shakeCount % 2 == 0) ? originalX + 5 : originalX - 5;
                shakeCount++;

                // Flash red
                if (flashCount % 2 == 0)
                    targetToShake.BackColor = Color.LightCoral;
                else
                    targetToShake.BackColor = originalBackColor;

                flashCount++;
            }
            else
            {
                attackEffectTimer.Stop();
                targetToShake.Left = originalX;
                targetToShake.BackColor = originalBackColor;
            }
        }
    }
}
