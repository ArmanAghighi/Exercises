using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureHunt.Services
{
    internal interface IPlayerService 
    {
        public void HandleInput(char input);
        public void MovePlayer(int rowOffset, int colOffset);
    }
}
