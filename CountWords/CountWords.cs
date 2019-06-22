using System;

namespace CountWords
{
    public class CountWords
    {
        public int Count(string s)
        {
            if(String.IsNullOrEmpty(s))
                return 0;

            string[] parts = s.Split(',');
            return parts.Length;
        }
    }
}
