using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Helper
{
    public class Regexp
    {
        public static bool checkForMail(String Email)
        {
            bool isValid = false;
            Regex regex = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                                     + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                                     + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            if (regex.IsMatch(Email))
                isValid = true;
            return isValid;
        }

        public static bool checkPhone(String sdt)
        {
            bool valid = false;
            Regex r = new Regex(@"^(0\d{9,10})$");
            if (r.IsMatch(sdt))
                valid = true;
            return valid;
        }
    }
}
