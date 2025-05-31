# RPGBattle
RPG Battle Simulator is a turn-based game where two players choose characters and battle each other.

## Character Descriptions
CodeReaper Aeron 
  - health: 120
  - attack range: 12 to 22 damage per turn
  - balanced attacker with moderate health. His damage output is consistent, making him a reliable fighter in prolonged battles

DataWrecker Jewelle
  - health: 130
  - attack range: 10 to 21 damage normally, but with a 20% chance to unleash a powerful attack
  - has solid health and a unique edge in battle. She can deal steady damage, but also has a chance to land a powerful critical hit, making her a smart and unpredictable choice

SyntaxSlayer Lara
  - health: 150
  - attack range: 15 to 25 damage
  - aggressive character with consistently high damage. She has moderate health, making her a powerful offensive player

## OOP Application
In this project, we applied the five main principles of Object-Oriented Programming: abstraction, encapsulation, inheritance, polymorphism, and exception handling to create a clear, organized, and manageable system.

We used abstraction by creating a base class called DAExecution that had a method named Attack(). This method was marked as abstract, which meant that the details of how the attack works were left to each specific character class. This helped us focus only on what each character needed to do, without showing all the details right away.

For encapsulation, we kept important data, such as Name, Health, MaxHealth, and other variables, private or protected. This means we didn’t let other parts of the code change these values directly. Instead, we used methods or properties to control how these values were used, which made our program more secure and easier to fix if there were problems.

We used inheritance by making character classes like SyntaxSlayerLara, CodeReaperAeron, and DataWreckerJewelle inherit from the base class DAExecution. This helped us avoid repeating code and allowed us to give each character their own special version of the Attack() method by using the override keyword.

Polymorphism helped us use one name for many actions. Even though each character had a different way of attacking, we could still use the same method name, Attack(), to call it. We used virtual in the base class and override in the child classes to make this work. This made our code simpler and more flexible.

Finally, we used exception handling with try-catch blocks. This helped us deal with errors, like missing images or if a player didn’t choose a character. Instead of crashing, the program showed a message using MessageBox.Show() to let the user know what went wrong.

## Challenges We Faced
One of the main challenges we faced in creating this game was that it was our first time developing a game, and we were not very knowledgeable about how to start or structure it. We struggled with understanding how game logic works, especially in designing character interactions, managing attack and health values, and ensuring that the game was balanced and fair. Applying Object-Oriented Programming (OOP) concepts in a practical context like this was also quite difficult at first. Additionally, implementing randomness in attacks while keeping the gameplay engaging and understandable was tricky. We also encountered several issues during coding and debugging, as even small mistakes in logic could affect the entire battle system. Despite these challenges, we treated them as learning opportunities, and they helped us improve our problem-solving and programming skills.

