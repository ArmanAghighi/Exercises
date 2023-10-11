using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureHunt.Services;
namespace TreasureHunt
{
    internal class UIService : IUIService
    {

        public static bool hKeyUsed;
        public void ShowMessage(string message)
        {
            switch (message)
            {
                case "Welcome":
                    Console.WriteLine("wellcome Sir to the dungeon , try to find the treasure and escape");
                    Console.WriteLine();
                    break;

                case "Win":
                    Console.WriteLine("Congratulations! You found the treasure. You win!");
                    Console.WriteLine();
                    break;
                case "NoMoves":
                    Console.WriteLine("You ran out of moves! Game over.");
                    break;
                case "Help":
                    Console.WriteLine("Press 'H' to reveal hidden items.");
                    break;
                case "GameOver":
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    break;
                case "Discribtion":
                    Console.WriteLine("Moves Left: " + Model.movesLeft);
                    Console.WriteLine("Use 'W', 'A', 'S', 'D' to move. Press 'Q' to quit.");
                    break;
                default:
                    break;
            }
        }

        public void DrawGrid()
        {
            int gridSize = Model.grid.GetLength(0);

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (i == Model.playerRow && j == Model.playerCol)
                    {
                        Console.Write("|_P_|");
                    }
                    else if (i == Model.trapRow && j == Model.trapCol)
                    {
                        if (Model.trapRevealed && !hKeyUsed)
                        {
                            Console.Write("|_T_|");
                        }
                        else
                        {
                            Console.Write("|___|");
                        }
                    }
                    else if (i == Model.treasureRow && j == Model.treasureCol)
                    {
                        if (Model.treasureRevealed && !hKeyUsed)
                        {
                            Console.Write("|_$_|");
                        }
                        else
                        {
                            Console.Write("|___|");
                        }
                    }
                    else
                    {
                        Console.Write("|___|");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
