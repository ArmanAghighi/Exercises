using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureHunt.Services
{
    internal interface ISetupService
    {
        public void SetupGame(int Size, int Moves);
    }
}
