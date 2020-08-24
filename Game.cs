using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        string CombineWords(string word1, string word2 )
        {
            string result = word1 + word2;
            return result;
        }
        int SumTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        void ChangeName(string oldName,string newName)
        {
            oldName = newName;
        }
        void PrintStats(string name, float playerHealth, int damage, int level, string role)
        {
            Console.WriteLine("\nPlayer Name: " + name);
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Player Damage: " + damage);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        int GetPlayerInput(string context, string choice1, string choice2)
        {
            Console.WriteLine(context);
            char input = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                Console.WriteLine(choice1);
                return 1;

            }
            else if(input == '2')
            {
                Console.WriteLine(choice2);
                return 2;
            }
            return 0;
        }
        public void Run()
        {
            string newWord = CombineWords("Peanut", "butter");
            bool gameOver = false;
            while(gameOver == false)
            {
                //Used to store player health
                float playerHealth = 100.0f;
                //Used to heal the player
                float healthRegen = 20;
                //Stores whether the max level has been reached
                bool maxLevelReached = false;
                //Used to store player damage
                int damage = 20;
                int defense = 40;
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
                char input = ' ';
                Console.WriteLine();
                while (input != '1' && input != '2')
                {
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        playerHealth = 200;
                        role = "Knight";
                    }
                    else if (input == '2')
                    {
                        damage = 40;
                        role = "Wizard";
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }


                //Prints player stats to the screen
                PrintStats(name, playerHealth, damage, level, role);
                ChangeName(name, "New Name");
                PrintStats(name, playerHealth, damage, level, role);
                Console.Clear();


                //First decision
                Console.WriteLine("You've been approached by a mysterious traveler.");
                Console.WriteLine("They offer you a strange beverage with a promise to boost your strength.");
                Console.WriteLine("Do you accept?");
                Console.WriteLine("Press 1 for yes");
                Console.WriteLine("Press 2 for no");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    playerHealth = 0;
                    damage = 500;
                    Console.WriteLine("\nYou just drank poison! You lose!");
                    gameOver = true;
                    break;
                }
                else if (input == '2')
                {
                    Console.Clear();
                    Console.WriteLine();
                    string context = "You decline and traveler is offended. He challanges you to a fight.";

                    //Initialize enemy stats
                    int travelerHealth = 60;
                    int travelerDamage = 25;
                    while(playerHealth > 0 && travelerHealth >0)
                    {
                        //Display player and enemy stats
                        //Player stats:
                        Console.WriteLine("\nPlayer Name: " + name);
                        Console.WriteLine("Player Health: " + playerHealth);
                        Console.WriteLine("Player Damage: " + damage);
                        Console.WriteLine("Player Level: " + level);
                        Console.WriteLine("Player Role: " + role);
                        //Enemy stats:
                        Console.WriteLine("\nTraveler: " );
                        Console.WriteLine("Traveler Health: " + travelerHealth);
                        Console.WriteLine("Traveler Damage: " + travelerDamage);
                        Console.WriteLine("Traveler Role: Potion Seller");
                        //Get input from player
                        int choice = GetPlayerInput(context, "You hit them with a mean right hook. The traveler took " + damage + " damage", "You raised your guard. Your shield took " + travelerDamage + " damage");
                        if(choice == 1)
                        {
                            travelerHealth -= damage;
                        }
                        else if(choice == 2)
                        {
                            defense -= travelerDamage;
                            Console.ReadKey();
                            continue;
                        }
                        else if(input == '3')
                        {
                            Console.WriteLine("Your dog bit them");
                        }
                        
                        playerHealth -= travelerDamage;
                        Console.WriteLine("They punched in your face. You took " + travelerDamage + " damage");
                        Console.ReadKey();
                        Console.Clear();
                    }
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

                
                string guess = " ";
                
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("You approach a door. On it is a riddle. It says: How much wood could a woodchuck chuck if a woodchuck could chuck wood?");
                    Console.WriteLine("You have " + (5 - i) + " tries remaining");
                    guess = Console.ReadLine();
                    if (guess == "Yes")
                    {
                        Console.WriteLine("You have answered correctly! The door slowly opens");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You hear a loud buzzing noise. You figure it must mean you are wrong.");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }


                //second decision
                Console.WriteLine("You've come to a crossroad.");
                Console.WriteLine("There's a sign. Do you read it?");
                Console.WriteLine("Press 1 for yes");
                Console.WriteLine("Press 2 for no");
                input = Console.ReadKey().KeyChar;
                string direction = "none";
                if (input == '1')
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
                    else if (input == '2')
                    {
                        direction = "west";
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    }
                }
                else if (input == '2')
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
                if (direction == "west")
                {

                }
            }
            
        }
    }
}
