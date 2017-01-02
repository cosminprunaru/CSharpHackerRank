using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class MyCalculator : IArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0)
                    sum += i;   
            
            sum += n;
            return sum;
        }
    }
}
