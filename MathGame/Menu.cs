using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Menu
    {
        bool gameOn = true;
        GameEngine engine = new GameEngine();
        internal void ShowMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Choose An Operation: ");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Substraction");
                Console.WriteLine("3.Division");
                Console.WriteLine("4.Multiplication");
                Console.WriteLine("5.Random");
                Console.WriteLine("6.Check the history");
                Console.WriteLine("7.Quit the program");

                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        engine.Addition("Addition");
                        break;
                    case 2:
                        engine.Substraction("Substraction");
                        break;
                    case 3:
                        engine.Division("Division");
                        break;
                    case 4:
                        engine.Multiplication("Multiplication");
                        break;
                    case 5:
                        engine.Random("Random");
                        break;
                    case 6:
                        Help.ShowHistory();
                        break;
                    case 7:
                        Console.WriteLine("Exit from the program");
                        gameOn = false;
                        break;
                    default:
                        break;
                }
            } while (gameOn);
        }
    }
}
