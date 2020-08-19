using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //Used to store player health
            float health = 100.0f;
            //Used to heal the player
            float healthRegen = 20;
            //Stores whether the max level has been reached
            bool maxLevelReached = false;
            //Used to store player damage
            int damage = 20;
            //Represents player's current level
            int level = 1;
            //Used to store player's current role
            string role = "peasant";

            //Prints welcome message
            Console.WriteLine("Hello traveler! What is your name?");
            string name = Console.ReadLine();

            //Asks the player to select a role from the given options
            Console.WriteLine("Welcome " + name + "! " + "Please select a role");
            Console.WriteLine("Press 1 for Knight role");
            Console.WriteLine("Press 2 for Wizard role");

            //Gets input from console, and updates player values to reflect new role.
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (input == '1')
            {
                health = 200;
                role = "Knight";
            }
            else if (input == '2')
            {
                damage = 40;
                role = "Wizard";
            }
            else
            {
                Console.WriteLine("Invalid input. Using default stats");
            }

            //Prints player stats to the screen
            Console.WriteLine("\nPlayer Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Damage: " + damage);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("You've been approached by a mysterious traveler.");
            Console.WriteLine("They offer you a strange beverage with a promise to boost your strength.");
            Console.WriteLine("Do you accept?");
            Console.WriteLine("Press 1 for yes");
            Console.WriteLine("Press 2 for no");
            input = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                health -= health * 0.5f;
                damage = 500;
                Console.WriteLine("\nYou punch a tree to test your strength. You destroy it!");
                Console.WriteLine("Unfortunately it seems like your arm is now broken...");
            }
            else if(input == '2')
            {
                Console.WriteLine("You decline and continue your journey.");
            }
            else
            {
                Console.WriteLine("You kept awkwardly stuttering and fumbling over your words.");
                Console.WriteLine("The traveler became annoyed and decided to walk away.");
                Console.WriteLine("You can hear them call you a weirdo under their breath.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You've come to a crossroad.");
            Console.WriteLine("There's a sign. Do you read it?");
            Console.WriteLine("Press 1 for yes");
            Console.WriteLine("Press 2 for no");
            input = Console.ReadKey().KeyChar;
            string direction = "none";
            if(input == '1')
            {
                Console.Clear();
                Console.WriteLine("The sign reads: 'To the west are The Far Lands. To the east is Death's Garden'");
                Console.WriteLine("Which direction do you choose?");
                Console.WriteLine("Press 1 for east");
                Console.WriteLine("Press 2 for west");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    direction = "east";
                }
                else if(input == '2')
                {
                    direction = "west";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You ignored the sign and decided to trust your " + role + " instincts instead");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    if (role == "Wizard")
                    {
                        direction = "east";
                    }
                    else if (role == "Knight")
                    {
                        direction = "west";
                    }
                    else
                    {
                        direction = "west";
                    }
                }
            }
            else if(input == '2')
            {
                Console.Clear();
                Console.WriteLine("You ignored the sign and decided to trust your " + role + " instincts instead");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                if(role == "Wizard")
                {
                    direction = "east";
                }
                else if(role == "Knight")
                {
                    direction = "west";
                }
                else
                {
                    direction = "west";
                }
            }
            if(direction == "west")
            {

            }
        }
    }
}
