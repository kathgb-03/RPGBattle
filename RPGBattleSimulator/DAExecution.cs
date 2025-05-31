using System;

namespace RPGBattleSimulator
{
    // Base class for all player characters (Abstraction)
    public abstract class DAExecution
    {
        // Character name and health properties
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        // Set name and starting health
        public DAExecution(string name, int maxHealth)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
        }

        // Force child classes to define their own attack logic (Polymorphism)
        public abstract int Attack();

        // Reduce health when taking damage
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }
    }
}
