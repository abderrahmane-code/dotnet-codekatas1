using System;
using System.Linq;

namespace PalindromeChecker
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string s)
        {
            if(String.IsNullOrEmpty(s))
                return true;

            string reversed = new string(s.Reverse().ToArray());
            return s == reversed;
        }
    }
}
