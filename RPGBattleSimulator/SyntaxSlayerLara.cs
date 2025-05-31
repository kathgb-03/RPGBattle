using RPGBattleSimulator;
using System;
namespace RPGBattleSimulator
{
    // Inherits from DAExecution (Inheritance)
    public class SyntaxSlayerLara : DAExecution
    {
        private static readonly Random rand = new Random();
        public SyntaxSlayerLara() : base("SyntaxSlayer Lara", 150) { }
        public override int Attack()
        {
            // Lara deals 15-25 damage
            return rand.Next(15, 26);
        }
    }
}