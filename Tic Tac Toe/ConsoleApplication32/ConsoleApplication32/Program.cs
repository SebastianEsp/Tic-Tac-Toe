using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string choiceA1 = ("a1");
                string choiceA2 = ("a2");
                string choiceA3 = ("a3");
                string choiceB1 = ("b1");
                string choiceB2 = ("b2");
                string choiceB3 = ("b3");
                string choiceC1 = ("c1");
                string choiceC2 = ("c2");
                string choiceC3 = ("c3");

               string[] boardArr = new string[9];
               boardArr[0] = ("-");
               boardArr[1] = ("-");
               boardArr[2] = ("-");
               boardArr[3] = ("-");
               boardArr[4] = ("-");
               boardArr[5] = ("-");
               boardArr[6] = ("-");
               boardArr[7] = ("-");
               boardArr[8] = ("-");

                //The gameboard. Each place in the array corresponds to a tile on the board
               Console.SetCursorPosition(50, 10);
               Console.WriteLine("3 {0} {1} {2}", boardArr[0], boardArr[1], boardArr[2]);
               Console.SetCursorPosition(50, 12);
               Console.WriteLine("2 {0} {1} {2}", boardArr[3], boardArr[4], boardArr[5]);
               Console.SetCursorPosition(50, 14);
               Console.WriteLine("1 {0} {1} {2}", boardArr[6], boardArr[7], boardArr[8]);
               Console.SetCursorPosition(50, 15);
               Console.WriteLine("  a b c");

               for (int i = 0; i < 9; i++)
               {
                   if (i %2 == 0)
                   {
                       Console.SetCursorPosition(0, 0);
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine("Player one's turn");
                       Console.WriteLine("Make your move");
                       Console.ResetColor();
                       if (Console.ReadLine() == choiceA1)
                       {
                           boardArr[6] = ("x");
                       }
                       else if (Console.ReadLine() == choiceA2)
                       {
                           boardArr[7] = ("x");
                       }
                       Console.Clear();
                       Console.SetCursorPosition(50, 10);
                       Console.WriteLine("3 {0} {1} {2}", boardArr[0], boardArr[1], boardArr[2]);
                       Console.SetCursorPosition(50, 12);
                       Console.WriteLine("2 {0} {1} {2}", boardArr[3], boardArr[4], boardArr[5]);
                       Console.SetCursorPosition(50, 14);
                       Console.WriteLine("1 {0} {1} {2}", boardArr[6], boardArr[7], boardArr[8]);
                       Console.SetCursorPosition(50, 15);
                       Console.WriteLine("  a b c");
                   }
                   else
                   {
                       Console.SetCursorPosition(0, 0);
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine("Player two's turn");
                       Console.WriteLine("Make your move");
                       Console.ResetColor();
                       if (Console.ReadLine() == choiceA1)
                       {
                           boardArr[6] = ("o");
                       }
                       Console.Clear();
                       Console.SetCursorPosition(50, 10);
                       Console.WriteLine("3 {0} {1} {2}", boardArr[0], boardArr[1], boardArr[2]);
                       Console.SetCursorPosition(50, 12);
                       Console.WriteLine("2 {0} {1} {2}", boardArr[3], boardArr[4], boardArr[5]);
                       Console.SetCursorPosition(50, 14);
                       Console.WriteLine("1 {0} {1} {2}", boardArr[6], boardArr[7], boardArr[8]);
                       Console.SetCursorPosition(50, 15);
                       Console.WriteLine("  a b c");
                   }
               }
            }
        }
    }
}
