using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFExample.Views.Converters
{
    class LetterGradeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, Object parameter, CultureInfo culture)
        {
            if(value is double)
            {
                double percentage = (double) value;
                string gradeString="";
                if (percentage >= .90)
                {
                    gradeString = "A";
                }
                else if (percentage >= .80)
                {
                    gradeString = "B";
                }
                else if (percentage >= .70)
                {
                    gradeString = "C";
                }
                else if (percentage >= .60)
                {
                    gradeString = "D";
                }
                else if (percentage < .60)
                {
                    gradeString = "F";
                }
                if (gradeString != "F")
                {
                    if (percentage % .1 >= .07 || percentage >= 1)
                    {
                        gradeString = gradeString + "+";
                    }
                    else if (percentage % .1 <= .03)
                    {
                        gradeString = gradeString + "-";
                    }
                }
                return gradeString;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
