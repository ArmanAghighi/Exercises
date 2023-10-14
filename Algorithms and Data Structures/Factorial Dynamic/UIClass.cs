using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel_Dynamic
{
    internal class UIClass
    {
        public static void ShowMessage(string numbereOfMessage , LogicClass logic)
        {
            switch (numbereOfMessage)
            {
                case "Enter Value":
                    Console.WriteLine("Ënter a Value to calculate Factoriel of :");
                    break;
                case "Show Resault":
                    Console.WriteLine("Factoriel of " + logic.number + " is equal to :" + logic.Fact(logic.number));
                    break;
                default:
                    break;
            }
        }
    }
}
