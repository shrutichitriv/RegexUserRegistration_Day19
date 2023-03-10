using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    internal class Password_1_Uppercase
    {
        //writing the expression as we are needed
        public static string reg = "(?=.*[A-Z]).{8}";
        public static bool validate(string word)
        {
            //return true if the word matches the regex
            return Regex.IsMatch(word, reg);
        }
    }
}
