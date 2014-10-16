using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample.ViewModels
{
    public class AssignmentVM : ViewModel
    {
        private string _name;
        private int _total;
        private int _grade;

        public AssignmentVM(string name, int total, int grade)
        {
            Name = name;
            Total = total;
            Grade = grade;
        }

        public string Name
        {
            get { return _name; }

            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Total
        {
            get { return _total; }

            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }
        }
        public int Grade
        {
            get { return _grade; }

            set
            {
                _grade = value;
                OnPropertyChanged("Grade");
            }
        }

    }
}
