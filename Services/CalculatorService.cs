using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Services
{
    public class CalculatorService : ICalculator
    {
        public int Multiply(int g1, int g2)
        {
            var result = g1 * g2;
            return result;

            throw new NotImplementedException();
        }

        public int Subtract(int g1, int g2)
        {
            var result = g1 - g2;
            return result;

            throw new NotImplementedException();
        }

        public int Sum(int g1, int g2)
        {
            var result = g1 + g2;
            return result;

            throw new NotImplementedException();
        }

        public object Multiply(Random random1, Random random2)
        {
            throw new NotImplementedException();
        }
    }
}
