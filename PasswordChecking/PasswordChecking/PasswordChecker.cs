using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordChecking
{
    public class PasswordChecker
    {
        public static int GetPasswordStrength(string password)
        {
            int strength = 0;

            // check if password contains any digit 
            if(Regex.IsMatch(password, @"\d"))
            {
                strength++;
            }

            // check if password contains any lowercase letter
            if (Regex.IsMatch(password, "[a-z]"))
            {
                strength++;
            }

            //  check if password contains any uppercase letter
            if (Regex.IsMatch(password, "[A-Z]"))
            {
                strength++;
            }

            // check if password contains any special letter
            if (Regex.IsMatch(password, @"[\W_]"))
            {
                strength++;
            }

            // check if password longer than 7 letters
            if (password.Length > 7)
            {
                strength++;
            }

            return strength;
        }
    }
}
