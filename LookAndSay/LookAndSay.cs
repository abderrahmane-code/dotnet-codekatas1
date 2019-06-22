using System;

namespace LookAndSay
{
    public class LookAndSay
    {
        public string CalculateNextSequence(string s)
        {
            if(String.IsNullOrEmpty(s))
                return String.Empty;

            int x;
            if(!int.TryParse(s, out x))
                throw new ArgumentException();

            string result = "";
            char e = s[0];
            int occ = 0;
            foreach(char c in s){
                if(c == e)
                    occ ++;

                else{
                    result += occ + e.ToString();
                    occ = 1;
                    e = c;
                }
                
            }

            result += occ + e.ToString();
            return result;
        }
    }
}
