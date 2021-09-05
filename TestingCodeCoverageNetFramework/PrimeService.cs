using System;

namespace TestingCodeCoverageNetFramework
{
    public class PrimeService
    {
        public int Add(int a, int b) => a + b;
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (int divisor = 2; divisor <= Math.Sqrt(candidate); ++divisor)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
