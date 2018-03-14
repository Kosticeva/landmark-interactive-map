using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace HCI_Project
{
    class LandmarkDataValidation:ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            double revenue;
            if(Double.TryParse(value.ToString(), out revenue)){
                return new ValidationResult(true, null);
            }
            return new ValidationResult(false, "Please enter a real value.");
        }
    }
}
