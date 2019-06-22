using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class ReverseString
    {
        public string Reverse(string s)
        {
            if(String.IsNullOrEmpty(s))
                return String.Empty;
                
            return new string(s.Reverse().ToArray());
        }
    }
}
