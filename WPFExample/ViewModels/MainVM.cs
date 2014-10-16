using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample.ViewModels
{
    public class MainVM : ViewModel
    {
        private ObservableCollection<StudentVM> _studentList = new ObservableCollection<StudentVM>();
        private StudentVM _currentStudent;
        public MainVM()
        {
            _studentList.Add(new StudentVM("Mark",1,"A"));
            _studentList.Add(new StudentVM("Steve",2,"B+"));
            _studentList.Add(new StudentVM("Lewis", 3, "D-"));
        }

        public StudentVM CurrentStudent
        {
            get { return _currentStudent; }

            set
            {
                _currentStudent = value;
                OnPropertyChanged("CurrentStudent");
            }
        }
        public ObservableCollection<StudentVM> StudentList
        {
            get { return _studentList; }
        }
    }
}
