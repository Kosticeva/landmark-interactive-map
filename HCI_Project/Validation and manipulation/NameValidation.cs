using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace HCI_Project
{
    class NameValidation:ValidationRule
    {
       public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (!LoginModel.Users.ContainsKey(value.ToString()) && !value.Equals(""))
            {
                return new ValidationResult(false, "Please enter a valid username.");
            }

            LoginModel.Username = value.ToString();
            return new ValidationResult(true, "");
        }
    }

    class UsernameValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (LoginModel.Users.ContainsKey(value.ToString()) && !value.Equals(""))
            {
                return new ValidationResult(false, "Please choose a different username.");
            }

            LoginModel.Username = value.ToString();
            return new ValidationResult(true, "");
        }
    }

}
