using RPGBattleSimulator;
using System;

namespace RPGBattleSimulator
{
    // Inherits from DAExecution (Inheritance)
    public class DataWreckerJewelle : DAExecution
    {
        private static readonly Random rand = new Random();

        // Set name and health
        public DataWreckerJewelle() : base("DataWrecker Jewelle", 130) { }

        // 20% chance to deal 40–60 damage, else 10–20 (Polymorphism)
        public override int Attack()
        {
            if (rand.NextDouble() < 0.2)
                return rand.Next(40, 61);
            else
                return rand.Next(10, 21);
        }
    }
}
