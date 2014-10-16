using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFExample.Views
{
    class SubListView : ListView 
    {

        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            base.PrepareContainerForItemOverride(element, item);
            if (View is GridView)
            {
                int index = ItemContainerGenerator.IndexFromContainer(element);
                ListViewItem lvi = element as ListViewItem;
                if (index % 2 == 0)
                {
                    lvi.Background = Brushes.White;
                }
                else
                {
                    lvi.Background = Brushes.Beige;
                }
            }
        }

    }
}


