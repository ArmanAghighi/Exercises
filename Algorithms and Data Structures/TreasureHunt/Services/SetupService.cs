using System;
using TreasureHunt.Services;

namespace TreasureHunt
{
    class SetupService : ISetupService
    {
        static Random random = new Random();

        public void SetupGame(int Size, int Moves)
        {
            Model.grid = new char[Size, Size];
            Model.gridValues = new int[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Model.gridValues[i, j] = random.Next(1, 100);
                }
            }

            var maxIndex = FindMaxValueIndex(Model.gridValues);
            Model.treasureRow = maxIndex.row;
            Model.treasureCol = maxIndex.col;


            var minIndex = FindMinValueIndex(Model.gridValues);
            Model.trapRow = minIndex.row;
            Model.trapCol = minIndex.col;

            Model.playerRow = 0;
            Model.playerCol = 0;
            Model.trapRevealed = false;
            Model.treasureRevealed = false;
            UIService.hKeyUsed = false;
            Model.movesLeft = Moves;
        }

        private (int row, int col) FindMaxValueIndex(int[,] grid)
        {
            int max = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            int size = grid.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (grid[i, j] > max)
                    {
                        max = grid[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            return (maxRow, maxCol);
        }

        private (int row, int col) FindMinValueIndex(int[,] grid)
        {
            int min = int.MaxValue;
            int minRow = 0;
            int minCol = 0;

            int size = grid.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (grid[i, j] < min)
                    {
                        min = grid[i, j];
                        minRow = i;
                        minCol = j;
                    }
                }
            }

            return (minRow, minCol);
        }
    }
}