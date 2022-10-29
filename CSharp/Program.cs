using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        static int highscore = 340;
        static string highscorePlayer = "Mark";

        public static void Main(string[] args)
        {
            CheckHighscore(200, "Timon");
            CheckHighscore(350, "Anna");
            CheckHighscore(375, "Benjamin");
            CheckHighscore(335, "Lydia");

            Console.Read();
        }

        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);

            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still "
                    + highscore + " and held by " + highscorePlayer);
            }
        }
    }
}
