using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel_Dynamic
{
    internal class LogicClass
    {
        public int number;
        public LogicClass(int factNum = 0)
        {
            if (number < 0)
                throw new ArgumentException("Input must be a non-negative integer.");
            number = factNum;
            number = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
            Fact(number);
        }
        public double Fact(int number)
        {
            double[] num = new double[number + 1];
            num[0] = 1;

            for (int i = 1; i <= number; i++)
            {
                num[i] = i * num[i - 1];
            }

            return num[number];
        }
    }
}
