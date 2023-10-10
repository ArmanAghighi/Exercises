using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib_dynamic
{
    internal class Program
    {
        public static void Main()
        {
            UIClass.ShowMessage();
            Logic logic = new Logic();
            UIClass.ShowResualt(logic);
        }
    }
}