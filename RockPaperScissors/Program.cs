using System;

namespace RockPaperScissors
{
    sealed class Program
    {
        private static void Main(string[] args)
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
                string OptionModified = char.ToUpper(Option![0]) + Option.Substring(1);

                if (OptionModified == RandomPick)
                {
                    Console.WriteLine($"You see both of you picking {OptionModified} is BORING! Pick Something Different");
                    Console.WriteLine();
                }
                else if (OptionModified == "Rock" && RandomPick == "Scissors" || OptionModified == "Paper" && RandomPick == "Rock" || OptionModified == "Scissors" && RandomPick == "Paper")
                {
                    Console.WriteLine($"{OptionModified} does in fact beat {RandomPick}. Congratulations!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"You know that {RandomPick} beats {OptionModified} right?");
                    Console.WriteLine();
                }
            }
        }
    }
}
