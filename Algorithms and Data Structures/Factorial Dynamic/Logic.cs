using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib_dynamic
{
    internal class Logic
    {
        public int n;
        public Logic(int newNumber = 1)
        {
            n = newNumber; 
            n = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
            Fib(n);
        }
        public double Fib(int number)
        {
            if (number == 1 || number == 2)
                return 1;
            double[] bottomUP = new double[number + 1];
            bottomUP[1] = 1;
            bottomUP[2] = 1;
            for (int i = 3; i <= number; i++)
                bottomUP[i] = bottomUP[i - 1] + bottomUP[i - 2];
            return bottomUP[number]; 
        }
    }
}
