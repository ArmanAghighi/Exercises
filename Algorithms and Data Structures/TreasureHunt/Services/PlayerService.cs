using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureHunt.Services;
namespace TreasureHunt
{
    public class PlayerService : IPlayerService
    {
        public void HandleInput(char input)
        {
            switch (Char.ToLower(input))
            {
                case 'w':
                    MovePlayer(-1, 0);
                    break;
                case 'a':
                    MovePlayer(0, -1);
                    break;
                case 's':
                    MovePlayer(1, 0);
                    break;
                case 'd':
                    MovePlayer(0, 1);
                    break;
                case 'h':
                    if (!Model.trapRevealed && !Model.treasureRevealed && !UIService.hKeyUsed)
                    {
                        Model.trapRevealed = true;
                        Model.treasureRevealed = true;
                    }
                    break;
                case 'q':
                    Console.WriteLine("Quitting the game...");
                    Environment.Exit(0);
                    break;
            }
        }

        public void MovePlayer(int rowOffset, int colOffset)
        {
            int gridSize = Model.grid.GetLength(0);

            int newRow = Model.playerRow + rowOffset;
            int newCol = Model.playerCol + colOffset;

            if (newRow >= 0 && newRow < gridSize && newCol >= 0 && newCol < gridSize)
            {
                Model.playerRow = newRow;
                Model.playerCol = newCol;
                Model.movesLeft--;
                UIService.hKeyUsed = true;
                if (UIService.hKeyUsed)
                {
                    Model.trapRevealed = false;
                    Model.treasureRevealed = false;
                }
            }
            else
            {
                Console.WriteLine("Invalid move. Please try again.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }
        }
    }
}
