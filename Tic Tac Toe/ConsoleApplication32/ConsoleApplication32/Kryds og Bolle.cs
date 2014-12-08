using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        } // The programs main method. This leads the program to the main menu.

        public static Random randomAi = new Random(); // assigns random value to "int n" in ai().

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("TIC ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("TAC ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TOE{0}", Environment.NewLine);
            Console.ResetColor();
            Console.WriteLine("[1] Human vs. Human{0}", Environment.NewLine);
            Console.WriteLine("[2] Human vs. Ai{0}", Environment.NewLine);
            Console.WriteLine("[3] Rules{0}", Environment.NewLine);
            Console.WriteLine("[4] Controls{0}", Environment.NewLine);
            Console.WriteLine("To quit the game type \"quit\"{0}", Environment.NewLine);

            string menuChoice = Console.ReadLine();
            if (menuChoice == "1")
            {
                Console.Clear();
                Game();
            }
            else if (menuChoice == "2")
            {
                for (int i = 0; i < 1; i++)
                {
                Console.Clear();
                Console.WriteLine("Choose difficulty");
                Console.WriteLine("press \"1\" for easy and \"2\" for hard");
                string easy_Hard_Choice = Console.ReadLine();
                if (easy_Hard_Choice == "1")
                {
                    AiGameEasy();
                }
                else if (easy_Hard_Choice == "2")
                {
                    AiGameHard();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("plaease choose again");
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    i--;
                }
                }
            }   
            else if (menuChoice == "3")
            {
                Console.Clear();
                Rules();
            }
            else if (menuChoice == "4")
            {
                Console.Clear();
                Controls();
            }
            else if (menuChoice == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have entered an invalid number, please try again.");
                Console.WriteLine("returning to main menu in:\n5 seconds");
                Thread.Sleep(1000);
                Console.WriteLine("4 seconds");
                Thread.Sleep(1000);
                Console.WriteLine("3 seconds");
                Thread.Sleep(1000);
                Console.WriteLine("2 seconds");
                Thread.Sleep(1000);
                Console.WriteLine("1 second");
                Thread.Sleep(1000);
                Console.Clear();
                Menu();
            }           
        }  // The games' main menu.

        public static void Rules()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("R");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("U");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("L");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("E");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("S");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!{0}", Environment.NewLine);
            Console.ResetColor();
            Console.WriteLine("Each player takes turns plasing either an \"x\" or an \"o\" on the game board.\nThe first player to get three in a row wins.\nShould no player get three in a row the game ends in a tie.{0}", Environment.NewLine);
            Console.WriteLine("To return to the menu type \"back\"{0}", Environment.NewLine);
            string backMenu = Console.ReadLine();
            if (backMenu == "back")
            {
                Console.Clear();
                Menu();
            }
        } // The rules tap, accessed from the main menu.

        public static void Controls()
        {
            Console.WriteLine("To make a move, press the coresponding combination of letter and number followedby enter.\nExample: to place an \"x\" in the bottom left corner press, a1 followed by enter{0}", Environment.NewLine);
            Console.WriteLine("To return to the menu type \"back\"{0}", Environment.NewLine);
            string backMenu = Console.ReadLine();
            if (backMenu == "back")
            {
                Console.Clear();
                Menu();
            }
        } // The controls tap, accessed from main menu.

        private static void DrawGameboard(string[] boardArr)
        {
            Console.Clear();
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("3 {0} {1} {2}", boardArr[1], boardArr[2], boardArr[3]);
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("2 {0} {1} {2}", boardArr[4], boardArr[5], boardArr[6]);
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("1 {0} {1} {2}", boardArr[7], boardArr[8], boardArr[9]);
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("  a b c");
        } // This method draws the gameboard, and fills it from the boardArr Array.

        private static int RetryQuitLoop(int i)
        {
        RetryQuitLoop: // This goto functions as error handling. If an impropper combination is entered, the player si asked to either try again, or consult the games manual 

            Console.Clear();
            Console.WriteLine("Please input a propper combination.\nTo try again type \'retry\'. If in doubt, consult the controls section from the main menu by typing \'quit\'.");
            string quit = Console.ReadLine();
            if (quit == "quit")
            {
                Console.Clear();
                Menu();
            }
            else if (quit == "retry")
            {
                i = --i;
            }
            else
            {
                goto RetryQuitLoop;
            }
            return i;
        } // This method is responsible for error handling, when typing impropper commands in the game.

        private static int CheaterLoop(int i)
        {
        CheaterLoop:

            Console.Clear();
            Console.WriteLine("A game piece has already been placed here. Please put it on an empty space.\nPress enter to continue.");
            string pressToContinue = Console.ReadLine();
            if (pressToContinue == "")
            {
                i = --i;
            }
            else
            {
                goto CheaterLoop;
            }
            return i;
        } // Stops human player cheating.

        private static int aiCheaterLoop(int i)
        {
            Console.Clear();
            i = --i;
            return i;
        } // Stops ai player cheating.

        private static string ai_Easy()
        {
            string aiChoice;
            int n = randomAi.Next(9);
            if (n == 1)
            {
                aiChoice = "a1";
            }
            else if (n == 2)
            {
                aiChoice = "a2";
            }
            else if (n == 3)
            {
                aiChoice = "a3";
            }
            else if (n == 4)
            {
                aiChoice = "b1";
            }
            else if (n == 5)
            {
                aiChoice = "b2";
            }
            else if (n == 6)
            {
                aiChoice = "b3";
            }
            else if (n == 7)
            {
                aiChoice = "c1";
            }
            else if (n == 8)
            {
                aiChoice = "c2";
            }
            else
            {
                aiChoice = "c3";
            }
            return aiChoice;
        } // The games ai. Works as a random Num Gen.

        private static string ai_Hard(string[] boardArr)
        {
            string aiChoice = null;

            if (boardArr[7] == "o" && boardArr[4] == "o" && boardArr[1] == "-")
            {
                aiChoice = "a3";
            }
            else if (boardArr[1] == "o" && boardArr[4] == "o" && boardArr[7] == "-")
            {
                aiChoice = "a1";
            }
            else if (boardArr[1] == "o" && boardArr[7] == "o" && boardArr[4] == "-")
            {
                aiChoice = "a2";
            }
            else if (boardArr[8] == "o" && boardArr[5] == "o" && boardArr[2] == "-")
            {
                aiChoice = "b3";
            }
            else if (boardArr[2] == "o" && boardArr[5] == "o" && boardArr[8] == "-")
            {
                aiChoice = "b1";
            }
            else if (boardArr[2] == "o" && boardArr[8] == "o" && boardArr[5] == "-")
            {
                aiChoice = "b2";
            }
            else if (boardArr[9] == "o" && boardArr[6] == "o" && boardArr[3] == "-")
            {
                aiChoice = "c3";
            }
            else if (boardArr[3] == "o" && boardArr[6] == "o" && boardArr[9] == "-")
            {
                aiChoice = "c1";
            }
            else if (boardArr[3] == "o" && boardArr[9] == "o" && boardArr[6] == "-")
            {
                aiChoice = "c2";
            }
            else if (boardArr[1] == "o" && boardArr[2] == "o" && boardArr[3] == "-")
            {
                aiChoice = "c3";
            }
            else if (boardArr[2] == "o" && boardArr[3] == "o" && boardArr[1] == "-")
            {
                aiChoice = "a3";
            }
            else if (boardArr[1] == "o" && boardArr[3] == "o" && boardArr[2] == "-")
            {
                aiChoice = "b3";
            }
            else if (boardArr[4] == "o" && boardArr[5] == "o" && boardArr[6] == "-")
            {
                aiChoice = "c2";
            }
            else if (boardArr[5] == "o" && boardArr[6] == "o" && boardArr[4] == "-")
            {
                aiChoice = "a2";
            }
            else if (boardArr[4] == "o" && boardArr[6] == "o" && boardArr[5] == "-")
            {
                aiChoice = "b2";
            }
            else if (boardArr[7] == "o" && boardArr[8] == "o" && boardArr[9] == "-")
            {
                aiChoice = "c1";
            }
            else if (boardArr[8] == "o" && boardArr[9] == "o" && boardArr[7] == "-")
            {
                aiChoice = "a1";
            }
            else if (boardArr[7] == "o" && boardArr[9] == "o" && boardArr[8] == "-")
            {
                aiChoice = "b1";
            }
            else if (boardArr[1] == "o" && boardArr[5] == "o" && boardArr[9] == "-")
            {
                aiChoice = "c1";
            }
            else if (boardArr[5] == "o" && boardArr[9] == "o" && boardArr[1] == "-")
            {
                aiChoice = "a3";
            }
            else if (boardArr[1] == "o" && boardArr[9] == "o" && boardArr[5] == "-")
            {
                aiChoice = "b2";
            }
            else if (boardArr[3] == "o" && boardArr[5] == "o" && boardArr[7] == "-")
            {
                aiChoice = "a1";
            }
            else if (boardArr[5] == "o" && boardArr[7] == "o" && boardArr[3] == "-")
            {
                aiChoice = "c3";
            }
                else if (boardArr[3] == "o" && boardArr[7] == "o" && boardArr[5] == "-")
            {
                aiChoice = "b2";
            }
            else if (boardArr[7] == "x" && boardArr[4] == "x" && boardArr[1] == "-")
            {
                aiChoice = "a3";
            }
            else if (boardArr[1] == "x" && boardArr[4] == "x" && boardArr[7] == "-")
            {
                aiChoice = "a1";
            }
            else if (boardArr[1] == "x" && boardArr[7] == "x" && boardArr[4] == "-")
            {
                aiChoice = "a2";
            }
            else if (boardArr[8] == "x" && boardArr[5] == "x" && boardArr[2] == "-")
            {
                aiChoice = "b3";
            }
            else if (boardArr[2] == "x" && boardArr[5] == "x" && boardArr[8] == "-")
            {
                aiChoice = "b1";
            }
            else if (boardArr[2] == "x" && boardArr[8] == "x" && boardArr[5] == "-")
            {
                aiChoice = "b2";
            }
            else if (boardArr[9] == "x" && boardArr[6] == "x" && boardArr[3] == "-")
            {
                aiChoice = "c3";
            }
            else if (boardArr[3] == "x" && boardArr[6] == "x" && boardArr[9] == "-")
            {
                aiChoice = "c1";
            }
            else if (boardArr[3] == "x" && boardArr[9] == "x" && boardArr[6] == "-")
            {
                aiChoice = "c2";
            }
            else if (boardArr[1] == "x" && boardArr[2] == "x" && boardArr[3] == "-")
            {
                aiChoice = "c3";
            }
            else if (boardArr[2] == "x" && boardArr[3] == "x" && boardArr[1] == "-")
            {
                aiChoice = "a3";
            }
            else if (boardArr[1] == "x" && boardArr[3] == "x" && boardArr[2] == "-")
            {
                aiChoice = "b3";
            }
            else if (boardArr[4] == "x" && boardArr[5] == "x" && boardArr[6] == "-")
            {
                aiChoice = "c2";
            }
            else if (boardArr[5] == "x" && boardArr[6] == "x" && boardArr[4] == "-")
            {
                aiChoice = "a2";
            }
            else if (boardArr[4] == "x" && boardArr[6] == "x" && boardArr[5] == "-")
            {
                aiChoice = "b2";
            }
            else if (boardArr[7] == "x" && boardArr[8] == "x" && boardArr[9] == "-")
            {
                aiChoice = "c1";
            }
            else if (boardArr[8] == "x" && boardArr[9] == "x" && boardArr[7] == "-")
            {
                aiChoice = "a1";
            }
            else if (boardArr[7] == "x" && boardArr[9] == "x" && boardArr[8] == "-")
            {
                aiChoice = "b1";
            }
            else if (boardArr[1] == "x" && boardArr[5] == "x" && boardArr[9] == "-")
            {
                aiChoice = "c1";
            }
            else if (boardArr[5] == "x" && boardArr[9] == "x" && boardArr[1] == "-")
            {
                aiChoice = "a3";
            }
            else if (boardArr[1] == "x" && boardArr[9] == "x" && boardArr[5] == "-")
            {
                aiChoice = "b2";
            }
            else if (boardArr[3] == "x" && boardArr[5] == "x" && boardArr[7] == "-")
            {
                aiChoice = "a1";
            }
            else if (boardArr[5] == "x" && boardArr[7] == "x" && boardArr[3] == "-")
            {
                aiChoice = "c3";
            }
                else if (boardArr[3] == "x" && boardArr[7] == "x" && boardArr[5] == "-")
            {
                aiChoice = "b2";
            }

            else
            {
                int n = randomAi.Next(9);
                if (n == 1)
                {
                    aiChoice = "a1";
                }
                else if (n == 2)
                {
                    aiChoice = "a2";
                }
                else if (n == 3)
                {
                    aiChoice = "a3";
                }
                else if (n == 4)
                {
                    aiChoice = "b1";
                }
                else if (n == 5)
                {
                    aiChoice = "b2";
                }
                else if (n == 6)
                {
                    aiChoice = "b3";
                }
                else if (n == 7)
                {
                    aiChoice = "c1";
                }
                else if (n == 8)
                {
                    aiChoice = "c2";
                }
                else
                {
                    aiChoice = "c3";
                }
            }
            return aiChoice;
 
        }

        private static void PLayerOneWinningCondition(string[] boardArr)
        {
            if (boardArr[1] == "x" && boardArr[2] == "x" & boardArr[3] == "x")
            {
                PlayerOneWins();
            }
            else if (boardArr[4] == "x" && boardArr[5] == "x" & boardArr[6] == "x")
            {
                PlayerOneWins();
            }
            else if (boardArr[7] == "x" && boardArr[8] == "x" & boardArr[9] == "x")
            {
                PlayerOneWins();
            }
            else if (boardArr[1] == "x" && boardArr[4] == "x" & boardArr[7] == "x")
            {
                PlayerOneWins();
            }
            else if (boardArr[2] == "x" && boardArr[5] == "x" & boardArr[8] == "x")
            {
                PlayerOneWins();
            }
            else if (boardArr[3] == "x" && boardArr[6] == "x" & boardArr[9] == "x")
            {
                PlayerOneWins();
            }
            else if (boardArr[1] == "x" && boardArr[5] == "x" & boardArr[9] == "x")
            {
                PlayerOneWins();
            }
            else if (boardArr[3] == "x" && boardArr[5] == "x" & boardArr[7] == "x")
            {
                PlayerOneWins();
            }

        } // Checks if a winning condition for player one has been achieved. If yes leads to PlayerOneWins()

        private static void PLayerOneEasyWinningCondition(string[] boardArr)
        {
            if (boardArr[1] == "x" && boardArr[2] == "x" & boardArr[3] == "x")
            {
                PlayerOneEasyWins();
            }
            else if (boardArr[4] == "x" && boardArr[5] == "x" & boardArr[6] == "x")
            {
                PlayerOneEasyWins();
            }
            else if (boardArr[7] == "x" && boardArr[8] == "x" & boardArr[9] == "x")
            {
                PlayerOneEasyWins();
            }
            else if (boardArr[1] == "x" && boardArr[4] == "x" & boardArr[7] == "x")
            {
                PlayerOneEasyWins();
            }
            else if (boardArr[2] == "x" && boardArr[5] == "x" & boardArr[8] == "x")
            {
                PlayerOneEasyWins();
            }
            else if (boardArr[3] == "x" && boardArr[6] == "x" & boardArr[9] == "x")
            {
                PlayerOneEasyWins();
            }
            else if (boardArr[1] == "x" && boardArr[5] == "x" & boardArr[9] == "x")
            {
                PlayerOneEasyWins();
            }
            else if (boardArr[3] == "x" && boardArr[5] == "x" & boardArr[7] == "x")
            {
                PlayerOneEasyWins();
            }

        }

        private static void PLayerOneHardWinningCondition(string[] boardArr)
        {
            if (boardArr[1] == "x" && boardArr[2] == "x" & boardArr[3] == "x")
            {
                PlayerOneHardWins();
            }
            else if (boardArr[4] == "x" && boardArr[5] == "x" & boardArr[6] == "x")
            {
                PlayerOneHardWins();
            }
            else if (boardArr[7] == "x" && boardArr[8] == "x" & boardArr[9] == "x")
            {
                PlayerOneHardWins();
            }
            else if (boardArr[1] == "x" && boardArr[4] == "x" & boardArr[7] == "x")
            {
                PlayerOneHardWins();
            }
            else if (boardArr[2] == "x" && boardArr[5] == "x" & boardArr[8] == "x")
            {
                PlayerOneHardWins();
            }
            else if (boardArr[3] == "x" && boardArr[6] == "x" & boardArr[9] == "x")
            {
                PlayerOneHardWins();
            }
            else if (boardArr[1] == "x" && boardArr[5] == "x" & boardArr[9] == "x")
            {
                PlayerOneHardWins();
            }
            else if (boardArr[3] == "x" && boardArr[5] == "x" & boardArr[7] == "x")
            {
                PlayerOneHardWins();
            }

        } 

        private static void PLayerTwoWinningCondition(string[] boardArr)
        {
            if (boardArr[1] == "o" && boardArr[2] == "o" & boardArr[3] == "o")
            {
                PlayerTwoWins();
            }
            else if (boardArr[4] == "o" && boardArr[5] == "o" & boardArr[6] == "o")
            {
                PlayerTwoWins();
            }
            else if (boardArr[7] == "o" && boardArr[8] == "o" & boardArr[9] == "o")
            {
                PlayerTwoWins();
            }
            else if (boardArr[1] == "o" && boardArr[4] == "o" & boardArr[7] == "o")
            {
                PlayerTwoWins();
            }
            else if (boardArr[2] == "o" && boardArr[5] == "o" & boardArr[8] == "o")
            {
                PlayerTwoWins();
            }
            else if (boardArr[3] == "o" && boardArr[6] == "o" & boardArr[9] == "o")
            {
                PlayerTwoWins();
            }
            else if (boardArr[1] == "o" && boardArr[5] == "o" & boardArr[9] == "o")
            {
                PlayerTwoWins();
            }
            else if (boardArr[3] == "o" && boardArr[5] == "o" & boardArr[7] == "o")
            {
                PlayerTwoWins();
            }

        } // Checks if a winning condition for player two has been achieved. If yes leads to PlayerTwoWins()

        private static void AiEasyWinningCondition(string[] boardArr)
        {
            if (boardArr[1] == "o" && boardArr[2] == "o" & boardArr[3] == "o")
            {
                AiEasyWins();
            }
            else if (boardArr[4] == "o" && boardArr[5] == "o" & boardArr[6] == "o")
            {
                AiEasyWins();
            }
            else if (boardArr[7] == "o" && boardArr[8] == "o" & boardArr[9] == "o")
            {
                AiEasyWins();
            }
            else if (boardArr[1] == "o" && boardArr[4] == "o" & boardArr[7] == "o")
            {
                AiEasyWins();
            }
            else if (boardArr[2] == "o" && boardArr[5] == "o" & boardArr[8] == "o")
            {
                AiEasyWins();
            }
            else if (boardArr[3] == "o" && boardArr[6] == "o" & boardArr[9] == "o")
            {
                AiEasyWins();
            }
            else if (boardArr[1] == "o" && boardArr[5] == "o" & boardArr[9] == "o")
            {
                AiEasyWins();
            }
            else if (boardArr[3] == "o" && boardArr[5] == "o" & boardArr[7] == "o")
            {
                AiEasyWins();
            }

        } // Checks if a winning condition for the ai has been achieved. If yes leads to AiWins()

        private static void AiHardWinningCondition(string[] boardArr)
        {
            if (boardArr[1] == "o" && boardArr[2] == "o" & boardArr[3] == "o")
            {
                AiHardWins();
            }
            else if (boardArr[4] == "o" && boardArr[5] == "o" & boardArr[6] == "o")
            {
                AiHardWins();
            }
            else if (boardArr[7] == "o" && boardArr[8] == "o" & boardArr[9] == "o")
            {
                AiHardWins();
            }
            else if (boardArr[1] == "o" && boardArr[4] == "o" & boardArr[7] == "o")
            {
                AiHardWins();
            }
            else if (boardArr[2] == "o" && boardArr[5] == "o" & boardArr[8] == "o")
            {
                AiHardWins();
            }
            else if (boardArr[3] == "o" && boardArr[6] == "o" & boardArr[9] == "o")
            {
                AiHardWins();
            }
            else if (boardArr[1] == "o" && boardArr[5] == "o" & boardArr[9] == "o")
            {
                AiHardWins();
            }
            else if (boardArr[3] == "o" && boardArr[5] == "o" & boardArr[7] == "o")
            {
                AiHardWins();
            }

        } 

        private static void PlayerOneWins()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Player one ");
            Console.ResetColor();
            Console.WriteLine("is the winner");
            GameEnd();
        } // states that player one wins. Leads to game end.

        private static void PlayerOneEasyWins()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Player one ");
            Console.ResetColor();
            Console.WriteLine("is the winner");

            Console.WriteLine("The game has finnished");
            Console.WriteLine("Do you want to play again? y/n");

            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                AiGameEasy();
            }
            else
            {
                Console.Clear();
                Menu();
            }
        }

        private static void PlayerOneHardWins()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Player one ");
            Console.ResetColor();
            Console.WriteLine("is the winner");

            Console.WriteLine("The game has finnished");
            Console.WriteLine("Do you want to play again? y/n");

            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                AiGameHard();
            }
            else
            {
                Console.Clear();
                Menu();
            }
        }

        private static void PlayerTwoWins()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Player two ");
            Console.ResetColor();
            Console.WriteLine("is the winner");
            GameEnd();
        } // states that player two wins. Leads to game end.

        private static void AiEasyWins()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("The ai ");
            Console.ResetColor();
            Console.WriteLine("is the winner");
            Console.WriteLine("The game has finnished");
            Console.WriteLine("Do you want to play again? y/n");

            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                AiGameEasy();
            }
            else
            {
                Console.Clear();
                Menu();
            }
        } // states that the ai wins. Leads to game end.

        private static void AiHardWins()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("The ai ");
            Console.ResetColor();
            Console.WriteLine("is the winner");
            Console.WriteLine("The game has finnished");
            Console.WriteLine("Do you want to play again? y/n");

            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                AiGameHard();
            }
            else
            {
                Console.Clear();
                Menu();
            }
        }

        public static void Game() // This is the main game, accessed from the main menu.
        {
            {
                string[] boardArr = new string[10];
                boardArr[0] = ("-");
                boardArr[1] = ("-");
                boardArr[2] = ("-");
                boardArr[3] = ("-");
                boardArr[4] = ("-");
                boardArr[5] = ("-");
                boardArr[6] = ("-");
                boardArr[7] = ("-");
                boardArr[8] = ("-");
                boardArr[9] = ("-");

                DrawGameboard(boardArr); //The gameboard. Each place in the array corresponds to a tile on the board

                for (int i = 0; i < 9; i++) // The loop determines if it's Green or Red's turn, as well as where the player chooses to place the brick 
                {
                    if (i % 2 == 0)
                    {

                        Console.SetCursorPosition(0, 0);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player one's turn");
                        Console.WriteLine("Make your move");
                        Console.ResetColor();

                        string player1Choice = Console.ReadLine();
                        if (player1Choice == "a1")
                        {
                            if (boardArr[7] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Green_Cheats;
                            }
                            boardArr[7] = ("x");
                        }
                        else if (player1Choice == "a2")
                        {
                            if (boardArr[4] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Green_Cheats;
                            }
                            boardArr[4] = ("x");
                        }
                        else if (player1Choice == "a3")
                        {
                            if (boardArr[1] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Green_Cheats;
                            }
                            boardArr[1] = ("x");
                        }
                        else if (player1Choice == "b1")
                        {
                            if (boardArr[8] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Green_Cheats;
                            }
                            boardArr[8] = ("x");
                        }
                        else if (player1Choice == "b2")
                        {
                            if (boardArr[5] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Green_Cheats;
                            }
                            boardArr[5] = ("x");
                        }
                        else if (player1Choice == "b3")
                        {
                            if (boardArr[2] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Green_Cheats;
                            }
                            boardArr[2] = ("x");
                        }
                        else if (player1Choice == "c1")
                        {
                            if (boardArr[9] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Green_Cheats;
                            }
                            boardArr[9] = ("x");
                        }
                        else if (player1Choice == "c2")
                        {
                            if (boardArr[6] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Green_Cheats;
                            }
                            boardArr[6] = ("x");
                        }
                        else if (player1Choice == "c3")
                        {
                            if (boardArr[3] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Green_Cheats;
                            }
                            boardArr[3] = ("x");
                        }
                        else
                        {
                            i = RetryQuitLoop(i);
                        }

                    human_Green_Cheats:

                        DrawGameboard(boardArr);
                        PLayerOneWinningCondition(boardArr);
                    }
                    else
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Player two's turn");
                        Console.WriteLine("Make your move");
                        Console.ResetColor();

                        string player2Choice = Console.ReadLine();
                        
                        if (player2Choice == "a1")
                        {
                            if (boardArr[7] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Red_Cheats;
                            }
                            boardArr[7] = ("o");
                        }
                        else if (player2Choice == "a2")
                        {
                            if (boardArr[4] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Red_Cheats;
                            }
                            boardArr[4] = ("o");
                        }
                        else if (player2Choice == "a3")
                        {
                            if (boardArr[1] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Red_Cheats;
                            }
                            boardArr[1] = ("o");
                        }
                        else if (player2Choice == "b1")
                        {
                            if (boardArr[8] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Red_Cheats;
                            }
                            boardArr[8] = ("o");
                        }
                        else if (player2Choice == "b2")
                        {
                            if (boardArr[5] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Red_Cheats;
                            }
                            boardArr[5] = ("o");
                        }
                        else if (player2Choice == "b3")
                        {
                            if (boardArr[2] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Red_Cheats;
                            }
                            boardArr[2] = ("o");
                        }
                        else if (player2Choice == "c1")
                        {
                            if (boardArr[9] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Red_Cheats;
                            }
                            boardArr[9] = ("o");
                        }
                        else if (player2Choice == "c2")
                        {
                            if (boardArr[6] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Red_Cheats;
                            }
                            boardArr[6] = ("o");
                        }
                        else if (player2Choice == "c3")
                        {
                            if (boardArr[3] != "-")
                            {
                                i = CheaterLoop(i);
                                goto human_Red_Cheats;
                            }
                            boardArr[3] = ("o");
                        }
                        else
                        {
                            i = RetryQuitLoop(i);
                        }

                    human_Red_Cheats:

                        DrawGameboard(boardArr);
                        PLayerTwoWinningCondition(boardArr);
                    }
                }
                GameEndNoWinner();
            }
        }

        private static void GameEnd()
        {
            Console.WriteLine("The game has finnished");
            Console.WriteLine("Do you want to play again? y/n");

            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                Game();
            }
            else
            {
                Console.Clear();
                Menu();
            }
        } // The endning text. States that the game is over. Choose to play again or quit.

        private static void GameEndNoWinner()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("No winner was found");
            Console.WriteLine("Do you want to play again? y/n");

            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                Game();
            }
            else
            {
                Console.Clear();
                Menu();
            }
        }

        private static void GameEndEasyNoWinner()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("No winner was found");
            Console.WriteLine("Do you want to play again? y/n");

            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                AiGameEasy();
            }
            else
            {
                Console.Clear();
                Menu();
            }
        }

        private static void GameEndHardNoWinner()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("No winner was found");
            Console.WriteLine("Do you want to play again? y/n");

            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                AiGameHard();
            }
            else
            {
                Console.Clear();
                Menu();
            }
        }// If no winner is found, this is run instead of GameEnd()

        public static void AiGameEasy()
        {
            string[] boardArr = new string[10];
            boardArr[0] = ("-");
            boardArr[1] = ("-");
            boardArr[2] = ("-");
            boardArr[3] = ("-");
            boardArr[4] = ("-");
            boardArr[5] = ("-");
            boardArr[6] = ("-");
            boardArr[7] = ("-");
            boardArr[8] = ("-");
            boardArr[9] = ("-");

            DrawGameboard(boardArr); //The gameboard. Each place in the array corresponds to a tile on the board

            for (int i = 0; i < 9; i++) // The loop determines if it's Green or Red's turn, as well as where the player chooses to place the brick 
            {
                if (i % 2 == 0)
                {

                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player one's turn");
                    Console.WriteLine("Make your move");
                    Console.ResetColor();

                    string player1Choice = Console.ReadLine();
                    if (player1Choice == "a1")
                    {
                        if (boardArr[7] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[7] = ("x");
                    }
                    else if (player1Choice == "a2")
                    {
                        if (boardArr[4] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[4] = ("x");
                    }
                    else if (player1Choice == "a3")
                    {
                        if (boardArr[1] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[1] = ("x");
                    }
                    else if (player1Choice == "b1")
                    {
                        if (boardArr[8] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[8] = ("x");
                    }
                    else if (player1Choice == "b2")
                    {
                        if (boardArr[5] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[5] = ("x");
                    }
                    else if (player1Choice == "b3")
                    {
                        if (boardArr[2] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[2] = ("x");
                    }
                    else if (player1Choice == "c1")
                    {
                        if (boardArr[9] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[9] = ("x");
                    }
                    else if (player1Choice == "c2")
                    {
                        if (boardArr[6] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[6] = ("x");
                    }
                    else if (player1Choice == "c3")
                    {
                        if (boardArr[3] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[3] = ("x");
                    }
                    else
                    {
                        i = RetryQuitLoop(i);
                    }

                human_Vs_Ai_Green_Cheats:

                    DrawGameboard(boardArr);
                    PLayerOneEasyWinningCondition(boardArr);
                }
                else
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The ai is taking a turn");
                    string aiChoice = ai_Easy();
                    Thread.Sleep(2000);
                    Console.ResetColor();

                    if (aiChoice == "a1")
                    {
                        if (boardArr[7] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[7] = ("o");
                    }
                    else if (aiChoice == "a2")
                    {
                        if (boardArr[4] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[4] = ("o");
                    }
                    else if (aiChoice == "a3")
                    {
                        if (boardArr[1] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[1] = ("o");
                    }
                    else if (aiChoice == "b1")
                    {
                        if (boardArr[8] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[8] = ("o");
                    }
                    else if (aiChoice == "b2")
                    {
                        if (boardArr[5] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[5] = ("o");
                    }
                    else if (aiChoice == "b3")
                    {
                        if (boardArr[2] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[2] = ("o");
                    }
                    else if (aiChoice == "c1")
                    {
                        if (boardArr[9] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[9] = ("o");
                    }
                    else if (aiChoice == "c2")
                    {
                        if (boardArr[6] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[6] = ("o");
                    }
                    else if (aiChoice == "c3")
                    {
                        if (boardArr[3] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[3] = ("o");
                    }
                    else
                    {
                        i = RetryQuitLoop(i);
                    }

                human_Vs_Ai_Red_Cheats:

                    DrawGameboard(boardArr);
                    AiEasyWinningCondition(boardArr);
                }
            }
            GameEndEasyNoWinner();
        } // A version of the game with a simple RNG based ai.

        public static void AiGameHard()
        {
            string[] boardArr = new string[10];
            boardArr[0] = ("-");
            boardArr[1] = ("-");
            boardArr[2] = ("-");
            boardArr[3] = ("-");
            boardArr[4] = ("-");
            boardArr[5] = ("-");
            boardArr[6] = ("-");
            boardArr[7] = ("-");
            boardArr[8] = ("-");
            boardArr[9] = ("-");

            DrawGameboard(boardArr); //The gameboard. Each place in the array corresponds to a tile on the board

            for (int i = 0; i < 9; i++) // The loop determines if it's Green or Red's turn, as well as where the player chooses to place the brick 
            {
                if (i % 2 == 0)
                {

                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player one's turn");
                    Console.WriteLine("Make your move");
                    Console.ResetColor();

                    string player1Choice = Console.ReadLine();
                    if (player1Choice == "a1")
                    {
                        if (boardArr[7] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[7] = ("x");
                    }
                    else if (player1Choice == "a2")
                    {
                        if (boardArr[4] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[4] = ("x");
                    }
                    else if (player1Choice == "a3")
                    {
                        if (boardArr[1] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[1] = ("x");
                    }
                    else if (player1Choice == "b1")
                    {
                        if (boardArr[8] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[8] = ("x");
                    }
                    else if (player1Choice == "b2")
                    {
                        if (boardArr[5] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[5] = ("x");
                    }
                    else if (player1Choice == "b3")
                    {
                        if (boardArr[2] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[2] = ("x");
                    }
                    else if (player1Choice == "c1")
                    {
                        if (boardArr[9] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[9] = ("x");
                    }
                    else if (player1Choice == "c2")
                    {
                        if (boardArr[6] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[6] = ("x");
                    }
                    else if (player1Choice == "c3")
                    {
                        if (boardArr[3] != "-")
                        {
                            i = CheaterLoop(i);
                            goto human_Vs_Ai_Green_Cheats;
                        }
                        boardArr[3] = ("x");
                    }
                    else
                    {
                        i = RetryQuitLoop(i);
                    }

                human_Vs_Ai_Green_Cheats:

                    DrawGameboard(boardArr);
                    PLayerOneHardWinningCondition(boardArr);
                }
                else
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The ai is taking a turn");
                    Thread.Sleep(2000);
                    Console.ResetColor();

                    string aiChoice = ai_Hard(boardArr);

                    if (aiChoice == "a1")
                    {
                        if (boardArr[7] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[7] = ("o");
                    }
                    else if (aiChoice == "a2")
                    {
                        if (boardArr[4] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[4] = ("o");
                    }
                    else if (aiChoice == "a3")
                    {
                        if (boardArr[1] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[1] = ("o");
                    }
                    else if (aiChoice == "b1")
                    {
                        if (boardArr[8] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[8] = ("o");
                    }
                    else if (aiChoice == "b2")
                    {
                        if (boardArr[5] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[5] = ("o");
                    }
                    else if (aiChoice == "b3")
                    {
                        if (boardArr[2] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[2] = ("o");
                    }
                    else if (aiChoice == "c1")
                    {
                        if (boardArr[9] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[9] = ("o");
                    }
                    else if (aiChoice == "c2")
                    {
                        if (boardArr[6] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[6] = ("o");
                    }
                    else if (aiChoice == "c3")
                    {
                        if (boardArr[3] != "-")
                        {
                            i = aiCheaterLoop(i);
                            goto human_Vs_Ai_Red_Cheats;
                        }
                        boardArr[3] = ("o");
                    }
                    else
                    {
                        i = RetryQuitLoop(i);
                    }

                human_Vs_Ai_Red_Cheats:

                    DrawGameboard(boardArr);
                    AiHardWinningCondition(boardArr);
                }
            }
            GameEndHardNoWinner();
        } // A version of the game with a simple RNG based ai
    }
}


