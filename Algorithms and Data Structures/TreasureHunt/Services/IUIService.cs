using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureHunt.Services
{
    internal interface IUIService
    {
        public void ShowMessage(string message);
        public void DrawGrid();
    }
}
