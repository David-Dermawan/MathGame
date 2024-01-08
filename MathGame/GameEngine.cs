using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;

namespace MathGame
{

    internal class GameEngine
    {
        List<string> answerList = new List<string>();
        Stopwatch timer = new Stopwatch();

        internal void Addition(string name)
        {
            int score = 0;

            Console.WriteLine($"{name} game");
            Console.WriteLine("Choose the difficulty: (Easy/Medium/Hard)");
            string difficulty = Console.ReadLine().ToLower();
            Console.WriteLine("Please insert how many question you wanna solve");
            int question = Convert.ToInt32(Console.ReadLine());
            timer.Start();

            Random n1 = new Random();
            int num1 = 0;
            int num2 = 0;

            for (int i = 1; i <= question; i++)
            {
                Console.Clear();
                switch (difficulty)
                {
                    case "easy":
                        num1 = n1.Next(1, 11);
                        num2 = n1.Next(1, 11);
                        break;
                    case "medium":
                        num1 = n1.Next(1, 101);
                        num2 = n1.Next(1, 101);
                        break;
                    case "hard":
                        num1 = n1.Next(1, 1001);
                        num2 = n1.Next(1, 1001);
                        break;
                }
                int total = num1 + num2;

                Console.WriteLine($"{num1} + {num2} = ?");
                bool check = false;
                while (check == false)
                {
                    var answer = Console.ReadLine();
                    while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
                    {
                        Console.WriteLine("Your answer must be an integer, Try again");
                        answer = Console.ReadLine();
                    }

                    if (int.Parse(answer) == total)
                    {
                        Console.WriteLine("Your answer is true");
                        Console.WriteLine($"{num1} + {num2} = {total}");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        check = true;
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is false try again");
                    }
                }
            }
            timer.Stop();
            Console.WriteLine($"You answer all question in {timer.Elapsed}");
            Console.ReadLine();
            Help.AddHistory(score, name);
        }

        internal void Substraction(string name)
        {
            int score = 0;

            Console.WriteLine($"{name} game");
            Console.WriteLine("Choose the difficulty: (Easy/Medium/Hard)");
            string difficulty = Console.ReadLine().ToLower();
            Console.WriteLine("Please insert how many question you wanna solve");
            int question = Convert.ToInt32(Console.ReadLine());
            timer.Start();

            Random n1 = new Random();
            int num1 = 0;
            int num2 = 0;

            for (int i = 1; i <= question; i++)
            {
                Console.Clear();
                switch (difficulty)
                {
                    case "easy":
                        num1 = n1.Next(1, 11);
                        num2 = n1.Next(1, 11);
                        break;
                    case "medium":
                        num1 = n1.Next(1, 101);
                        num2 = n1.Next(1, 101);
                        break;
                    case "hard":
                        num1 = n1.Next(1, 1001);
                        num2 = n1.Next(1, 1001);
                        break;
                }
                int total = num1 - num2;

                Console.WriteLine($"{num1} - {num2} = ?");
                bool check = false;
                while (check == false)
                {
                    var answer = Console.ReadLine();
                    while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
                    {
                        Console.WriteLine("Your answer must be an integer, Try again");
                        answer = Console.ReadLine();
                    }

                    if (int.Parse(answer) == total)
                    {
                        Console.WriteLine("Your answer is true");
                        Console.WriteLine($"{num1} - {num2} = {total}");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        check = true;
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is false try again");
                    }
                }
            }
            timer.Stop();
            Console.WriteLine($"You answer all question in {timer.Elapsed}");
            Console.ReadLine();
            Help.AddHistory(score, name);
        }

        internal void Division(string name)
        {
            int score = 0;

            Console.WriteLine($"{name} game");
            Console.WriteLine("Choose the difficulty: (Easy/Medium/Hard)");
            string difficulty = Console.ReadLine().ToLower();
            Console.WriteLine("Please insert how many question you wanna solve");
            int question = Convert.ToInt32(Console.ReadLine());
            timer.Start();

            Random n1 = new Random();
            int num1 = 0;
            int num2 = 0;

            for (int i = 1; i <= question; i++)
            {
                Console.Clear();
                switch (difficulty)
                {
                    case "easy":
                        num1 = n1.Next(1, 11);
                        num2 = n1.Next(1, 11);
                        break;
                    case "medium":
                        num1 = n1.Next(1, 101);
                        num2 = n1.Next(1, 101);
                        break;
                    case "hard":
                        num1 = n1.Next(1, 1001);
                        num2 = n1.Next(1, 1001);
                        break;
                }
                int total = num1 / num2;

                Console.WriteLine($"{num1} / {num2} = ?");
                bool check = false;
                while (check == false)
                {
                    var answer = Console.ReadLine();
                    while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
                    {
                        Console.WriteLine("Your answer must be an integer, Try again");
                        answer = Console.ReadLine();
                    }

                    if (int.Parse(answer) == total)
                    {
                        Console.WriteLine("Your answer is true");
                        Console.WriteLine($"{num1} / {num2} = {total}");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        check = true;
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is false try again");
                    }
                }
            }
            timer.Stop();
            Console.WriteLine($"You answer all question in {timer.Elapsed}");
            Console.ReadLine();
            Help.AddHistory(score, name);
        }

        internal void Multiplication(string name)
        {
            int score = 0;

            Console.WriteLine($"{name} game");
            Console.WriteLine("Choose the difficulty: (Easy/Medium/Hard)");
            string difficulty = Console.ReadLine().ToLower();
            Console.WriteLine("Please insert how many question you wanna solve");
            int question = Convert.ToInt32(Console.ReadLine());
            timer.Start();

            Random n1 = new Random();
            int num1 = 0;
            int num2 = 0;

            for (int i = 1; i <= question; i++)
            {
                Console.Clear();
                switch (difficulty)
                {
                    case "easy":
                        num1 = n1.Next(1, 11);
                        num2 = n1.Next(1, 11);
                        break;
                    case "medium":
                        num1 = n1.Next(1, 101);
                        num2 = n1.Next(1, 101);
                        break;
                    case "hard":
                        num1 = n1.Next(1, 1001);
                        num2 = n1.Next(1, 1001);
                        break;
                }
                int total = num1 * num2;

                Console.WriteLine($"{num1} * {num2} = ?");
                bool check = false;
                while (check == false)
                {
                    var answer = Console.ReadLine();
                    while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
                    {
                        Console.WriteLine("Your answer must be an integer, Try again");
                        answer = Console.ReadLine();
                    }

                    if (int.Parse(answer) == total)
                    {
                        Console.WriteLine("Your answer is true");
                        Console.WriteLine($"{num1} * {num2} = {total}");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        check = true;
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is false try again");
                    }
                }
            }
            timer.Stop();
            Console.WriteLine($"You answer all question in {timer.Elapsed}");
            Console.ReadLine();
            Help.AddHistory(score, name);
        }

        internal void Random(string name)
        {
            int score = 0;

            Console.WriteLine($"{name} game");
            Console.WriteLine("Choose the difficulty: (Easy/Medium/Hard)");
            string difficulty = Console.ReadLine().ToLower();
            Console.WriteLine("Please insert how many question you wanna solve");
            int question = Convert.ToInt32(Console.ReadLine());
            timer.Start();

            Random n1 = new Random();
            int num1 = 0;
            int num2 = 0;

            for (int i = 1; i <= question; i++)
            {
                Console.Clear();
                switch (difficulty)
                {
                    case "easy":
                        num1 = n1.Next(1, 11);
                        num2 = n1.Next(1, 11);
                        break;
                    case "medium":
                        num1 = n1.Next(1, 101);
                        num2 = n1.Next(1, 101);
                        break;
                    case "hard":
                        num1 = n1.Next(1, 1001);
                        num2 = n1.Next(1, 1001);
                        break;
                }
                int total = 0;
                string answerResult = "";
                int random = n1.Next(1, 5);
                if (random == 1)
                {
                    total = num1 - num2;
                    answerResult = $"{num1} - {num2} = ?";
                    Console.WriteLine(answerResult);
                }
                else if (random == 2)
                {
                    total = num1 + num2;
                    answerResult = $"{num1} + {num2} = ?";
                    Console.WriteLine(answerResult);
                }
                else if (random == 3)
                {
                    total = num1 / num2;
                    answerResult = $"{num1} / {num2} = ?";
                    Console.WriteLine(answerResult);
                }
                else if (random == 4)
                {
                    total = num1 * num2;
                    answerResult = $"{num1} * {num2} = ?";
                    Console.WriteLine(answerResult);
                }
                bool check = false;
                while (check == false)
                {
                    var answer = Console.ReadLine();
                    while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
                    {
                        Console.WriteLine("Your answer must be an integer, Try again");
                        answer = Console.ReadLine();
                    }

                    if (int.Parse(answer) == total)
                    {
                        Console.WriteLine("Your answer is true");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        check = true;
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is false try again");
                    }
                }
            }
            timer.Stop();
            Console.WriteLine($"You answer all question in {timer.Elapsed}");
            Console.ReadLine();
            Help.AddHistory(score, name);
        }

    }
}
