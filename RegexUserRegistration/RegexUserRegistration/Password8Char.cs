using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    internal class Password8Char
    {
        public static string reg = "[A-Za-z1-9]{8}";
        public static bool validate(string word)
        {
            //return true if the word matches the regex
            return Regex.IsMatch(word, reg);
        }
    }
}
