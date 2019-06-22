using System;
using System.Collections.Generic;

namespace ChangeReturn
{
    public class ChangeReturn
    {
        public List<Change> GetChange(decimal cost, decimal paid)
        {
            List<Change> result = new List<Change>();
            if(paid > cost){
                decimal change = paid - cost;

                int hundredDollars = (int)(change / 100);
                if(hundredDollars > 0){
                    result.Add(new Change{Denomination = Denomination.HundredDollar, Number = hundredDollars});
                    change -= hundredDollars * 100;
                }

                int fiftyDollars = (int)(change / 50);
                if(fiftyDollars > 0){
                    result.Add(new Change{Denomination = Denomination.FiftyDollar, Number = fiftyDollars});
                    change -= fiftyDollars * 50;
                }

                int twentyDollars = (int)(change / 20);
                if(twentyDollars > 0){
                    result.Add(new Change{Denomination = Denomination.TwentyDollar, Number = twentyDollars});
                    change -= twentyDollars * 20;
                }

                int tenDollars = (int)(change / 10);
                if(tenDollars > 0){
                    result.Add(new Change{Denomination = Denomination.TenDollar, Number = tenDollars});
                    change -= tenDollars * 10;
                }

                int fiveDollars = (int)(change / 5);
                if(fiveDollars > 0){
                    result.Add(new Change{Denomination = Denomination.FiveDollar, Number = fiveDollars});
                    change -= fiveDollars * 5;
                }

                int oneDollars = (int)change;
                if(oneDollars > 0){
                    result.Add(new Change{Denomination = Denomination.OneDollar, Number = oneDollars});
                    change -= oneDollars;
                }

                int halfDollars = (int)(change / (decimal)0.5);
                if(halfDollars > 0){
                    result.Add(new Change{Denomination = Denomination.HalfDollar, Number = halfDollars});
                    change -= (decimal)(halfDollars * 0.5);
                }

                int quarters = (int)(change / (decimal)0.25);
                if(quarters > 0){
                    result.Add(new Change{Denomination = Denomination.Quarter, Number = quarters});
                    change -= (decimal)(quarters * 0.25);
                }

                int dimes = (int)(change / (decimal)0.10);
                if(dimes > 0){
                    result.Add(new Change{Denomination = Denomination.Dime, Number = dimes});
                    change -= (decimal)(dimes * 0.10);
                }

                int nickels = (int)(change / (decimal)0.05);
                if(nickels > 0){
                    result.Add(new Change{Denomination = Denomination.Nickel, Number = nickels});
                    change -= (decimal)(nickels * 0.05);
                }

                int cents = (int)(change / (decimal)0.01);
                if(cents > 0){
                    result.Add(new Change{Denomination = Denomination.Cent, Number = cents});
                    change -= (decimal)(cents * 0.01);
                }
            }

            return result;
        }
    }
}
