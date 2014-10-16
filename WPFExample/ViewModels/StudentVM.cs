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
        private string _grade;
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

            double percentage = (double) totalGrade / assignTotal;

            if (percentage >= .90)
            {
                Grade = "A";
            }
            else if (percentage >= .80)
            {
                Grade = "B";
            }
            else if (percentage >= .70)
            {
                Grade = "C";
            }
            else if (percentage >= .60)
            {
                Grade = "D";
            }
            else if (percentage < .60)
            {
                Grade = "F";
            }
            if (Grade != "F")
            {
                if (percentage % .1 >= .07 || percentage >= 1)
                {
                    Grade = Grade + "+";
                }
                else if (percentage % .1 <= .03)
                {
                    Grade = Grade + "-";
                }
            }
        }


        public StudentVM(string student, int perm, string grade)
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

        public string Grade
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
