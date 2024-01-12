using System;

namespace TextAdventure
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sandmine Game: \n");

            new Programm();
        }

        public Programm()
        {
            while(true)
            {
                Console.Write("\nWhat would you like to do now?\n> ");
                string input = Console.ReadLine();

                Console.WriteLine($"Sorry, I dont know what you mean with \"{input}\"...");
            }

        }
    }
}