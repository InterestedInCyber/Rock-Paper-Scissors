using System;

namespace RockPaperScissors
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;

            Console.WriteLine("Welcome to Rock Paper Scissors");

            while (playing)
            {
                string[] RSP = { "Rock", "Paper", "Scissors" };
                Random Pick = new Random();
                int PickIndex = Pick.Next(RSP.Length);
                string RandomPick = RSP[PickIndex];

                Console.Write("Pick Your Poison (Rock, Paper or Scissors)? ");
                string? Option = Console.ReadLine();

                if (Option == RandomPick)
                {
                    Console.WriteLine($"You see both of you picking {Option} is BORING! Pick Something Different");
                }
                else if (Option == "Rock" && RandomPick == "Scissors" || Option == "Paper" && RandomPick == "Rock" || Option == "Scissors" && RandomPick == "Paper")
                {
                    Console.WriteLine($"{Option} does in fact beat {RandomPick}. Congratulations!");
                }
                else
                {
                    Console.WriteLine($"You know that {RandomPick} beats {Option} right?");
                    Console.WriteLine();
                }
            }
        }
    }
}