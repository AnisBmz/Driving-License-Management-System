using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD_System.Global_Classes
{
    public class clsValidation
    {

        static public bool ValidateEmail(string email)
        {

            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            return Regex.IsMatch(email, pattern);

        }

    }
}
