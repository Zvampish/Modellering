using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa ett C#-projekt med c:a 3-5 klasser.
            // Klasserna ska vara välformulerade och motsvara någon form av objekt i ett spel. 
            // Välj själv vilka klasser du ska ha med.
            // Välj också vilka egenskaper/variabler varje klass ska ha.
            // Skapa exempel-instanser i Main, och ge dem lämpliga värden.

            int blockDurability = 5;
            int enemyHp = 30;
            int enemyDmg = 5;
            int playerHp = 100;
            int playerDmg = 6;
            
            Console.WriteLine("enemyHp = " + enemyHp);
            Console.WriteLine("playerHp = " + playerHp);

            playerHp -= enemyDmg;
            enemyHp -= playerDmg;

            Console.WriteLine("The player and enemy hit eachother!");



            Console.WriteLine("Enemy hp = " + enemyHp + " and Player hp = " + playerHp);

            Console.ReadLine();
        }
    }
}
