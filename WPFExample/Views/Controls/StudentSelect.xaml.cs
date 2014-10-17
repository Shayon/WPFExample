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
    /// Interaction logic for StudentSelect.xaml
    /// </summary>
    public partial class StudentSelect : UserControl
    {
        public StudentSelect()
        {
            InitializeComponent();
        }

        private void ListViewItem_Click(object sender, RoutedEventArgs e)
        {
            ((MainVM) this.DataContext).CurrentStudent = (StudentVM) (((ListViewItem) sender).DataContext);
        }
    }
}
