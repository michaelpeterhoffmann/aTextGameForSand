using System;
using System.Text.RegularExpressions;

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

                Match match = Regex.Match(input,"(.*)yolo(.*)");
                if (match.Success)
                {
                    Console.WriteLine($"Thanks: You wrote {match.Groups[1]} and then {match.Groups[2]}");
                }
                else
                {
                    Console.WriteLine($"Sorry, I dont know what you mean with \"{input}\"...");
                }
                
            }

        }
    }
}
