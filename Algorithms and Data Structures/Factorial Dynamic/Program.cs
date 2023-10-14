using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel_Dynamic
{
    internal class Programm
    {
        public static void Main()
        {

            UIClass.ShowMessage("Enter Value" , null);
            LogicClass logic = new LogicClass();
            UIClass.ShowMessage("Show Resault" , logic);
        }
    }
}