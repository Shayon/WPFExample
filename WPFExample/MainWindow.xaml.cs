using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFExample.ViewModels;

namespace WPFExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListViewItem_Click(object sender, RoutedEventArgs e)
        {
            ((MainVM)this.DataContext).CurrentStudent = (StudentVM)(((ListViewItem)sender).DataContext);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AssignmentFormVM form = (AssignmentFormVM) (((Button)sender).DataContext);
            AssignmentVM assign = new AssignmentVM(form.FormNameField, form.FormTotalField, form.FormGradeField);
            ((MainVM)this.DataContext).CurrentStudent.AssignmentList.Add(assign);
            ((MainVM)this.DataContext).CurrentStudent.EvaluateGrade();
        }
    }
}
