using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Services
{
    public interface ICalculator
    {
        int Sum(int g1, int g2);
        int Subtract(int g1, int g2);
        int Multiply(int g1, int g2);
    }
}
