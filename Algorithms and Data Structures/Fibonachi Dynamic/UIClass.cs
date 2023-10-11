using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib_dynamic
{
    internal class UIClass
    {
        public static void ShowMessage()
        {
            Console.WriteLine("Please enter a number to calculate : ");
        }
        public static void ShowResualt(Logic logic)
        {
            Console.WriteLine("Fib of " + logic.n + " is : " + logic.Fib(logic.n));
        }
    }
}
