using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureHunt.Services;
namespace TreasureHunt
{
    internal class SetupService : ISetupService
    {
        static Random random = new Random();

        public void SetupGame(int Size, int Moves)
        {
            Model.grid = new char[Size, Size];

            Model.playerRow = random.Next(0, Size);
            Model.playerCol = random.Next(0, Size);

            Model.trapRow = random.Next(0, Size);
            Model.trapCol = random.Next(0, Size);

            Model.treasureRow = random.Next(0, Size);
            Model.treasureCol = random.Next(0, Size);

            Model.trapRevealed = false;
            Model.treasureRevealed = false;
            UIService.hKeyUsed = false;

            Model.movesLeft = Moves;
        }
    }
}
