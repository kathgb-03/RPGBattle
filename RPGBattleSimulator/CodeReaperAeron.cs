using RPGBattleSimulator;
using System;

namespace RPGBattleSimulator
{
    // Inherits from DAExecution (Inheritance)
    public class CodeReaperAeron : DAExecution
    {
        private static readonly Random rand = new Random();

        // Set name and health in base class
        public CodeReaperAeron() : base("CodeReaper Aeron", 120) { }

        // Override attack to deal 12–22 damage (Polymorphism)
        public override int Attack()
        {
            return rand.Next(12, 23);
        }
    }
}
