using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal static class Help
    {
        static List<(int Score, string GameName)> answerList = new List<(int Score, string GameName)>();
        internal static void ShowHistory()
        {
            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("----------------------------------------");
            foreach (var score in answerList)
            {
                Console.WriteLine($"Game {score.GameName} : {score.Score} Points");
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press any key to go to menu");
            Console.ReadLine();
        }

        internal static void AddHistory(int score, string gameName)
        {
            answerList.Add((Score: score, GameName: gameName));
        }
    }
}
