using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample.ViewModels
{
    class AssignmentFormVM : ViewModel
    {
        private string _formNameField;
        private int _formTotalField;
        private int _formGradeField;

        public AssignmentFormVM()
        {
            FormNameField = "Assignment Name";
            FormTotalField = 1;
            FormGradeField = 1;
        }

        public string FormNameField
        {
            get { return _formNameField; }

            set
            {
                _formNameField = value;
                OnPropertyChanged("FormNameField");
            }
        }

        public int FormTotalField
        {
            get { return _formTotalField; }

            set
            {
                _formTotalField = value;
                OnPropertyChanged("FormTotalField");
            }
        }

        public int FormGradeField
        {
            get { return _formGradeField; }

            set
            {
                _formGradeField = value;
                OnPropertyChanged("FormGradeField");
            }
        }

    }
}
