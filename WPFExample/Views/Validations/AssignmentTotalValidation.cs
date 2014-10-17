using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFExample.Views.Validations
{
    class AssignmentTotalValidation : ValidationRule
    {
        private int _grade;

        public int Grade
        {
            get { return _grade; }

            set
            {
                _grade = value;
            }
        }


        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            int total=-1;
            try
            {
                if (((string) value).Length > 0)
                    total = Int32.Parse((String) value);
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Illegal characters or " + e.Message);
            }
            if(total <= 0)
            {
                return new ValidationResult(false, "Please enter a total greater than 0.");
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }

    }
}
