using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample.ViewModels
{
    public class StudentVM : ViewModel
    {
        private string _studentName;
        private int _perm;
        private double _grade;
        private ObservableCollection<AssignmentVM> _assignmentList = new ObservableCollection<AssignmentVM>();

        public void EvaluateGrade()
        {
            int totalGrade=0;
            int assignTotal=0;
            foreach(var assign in AssignmentList)
            {
                totalGrade += assign.Grade;
                assignTotal += assign.Total;
            }

            Grade = (double) totalGrade / assignTotal;
        }


        public StudentVM(string student, int perm, double grade)
        {
            StudentName = student;
            Perm = perm;
            Grade = grade;
            _assignmentList.Add(new AssignmentVM("sample assign", 25, 23));
        }

        public string StudentName
        {
            get { return _studentName; }

            set
            {
                _studentName = value;
                OnPropertyChanged("StudentName");
            }
        }

        public int Perm
        {
            get { return _perm; }

            set
            {
                _perm = value;
                OnPropertyChanged("Perm");
            }
        }

        public double Grade
        {
            get { return _grade; }

            set
            {
                _grade = value;
                OnPropertyChanged("Grade");
            }
        }

        public ObservableCollection<AssignmentVM> AssignmentList
        {
            get { return _assignmentList; }

        }



    }
}
