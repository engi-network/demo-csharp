using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate <= 1)
            {
                return false;
            }
            int limit = candidate/2;
            for(int i = 2 ; i<=limit ; i++)
            {
                if(candidate%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}