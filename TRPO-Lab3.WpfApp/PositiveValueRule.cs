using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TRPO_Lab3.WpfApp
{
    public class PositiveValueRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is string stringValue)
            {
                if (double.TryParse(stringValue, out double doubleValue))
                {
                    if (doubleValue > 0)
                    {
                        return ValidationResult.ValidResult;
                    }
                }
            }

            return new ValidationResult(false, "Допустимы только значения больше 0");
        }
    }
}
