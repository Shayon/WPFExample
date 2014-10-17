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

namespace WPFExample.Views.Controls
{
    /// <summary>
    /// Interaction logic for AddAsignmentControl.xaml
    /// </summary>
    public partial class AddAsignmentControl : UserControl
    {
        public AddAsignmentControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AssignmentFormVM form = (AssignmentFormVM) (((Button) sender).DataContext);
            AssignmentVM assign = new AssignmentVM(form.FormNameField, form.FormTotalField, form.FormGradeField);
            ((StudentVM) this.DataContext).AssignmentList.Add(assign);
            ((StudentVM) this.DataContext).EvaluateGrade();
        }
    }
}
