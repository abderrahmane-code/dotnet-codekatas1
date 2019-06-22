using System;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        public int GetNextPrimeNumber(int i)
        {
            if(i < 2)
                return 2;

            bool isPrime;
            do{
                i++;
                isPrime = true;

                for(int j=2; j<i; j++){
                    if(i % j == 0){
                        isPrime = false;
                        break;
                    }
                        
                }

            }
            while(!isPrime);

            return i;

        }
    }
}
