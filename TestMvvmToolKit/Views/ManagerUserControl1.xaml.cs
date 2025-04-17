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
using TestMvvmToolKit.ViewModels;

namespace TestMvvmToolKit.Views
{
    /// <summary>
    /// Interaction logic for ManagerUserControl1.xaml
    /// </summary>
    public partial class ManagerUserControl1 : UserControl
    {
        public ManagerUserControl1()
        {
            InitializeComponent();
            DataContext = new FormViewModels();
        }
    }
}
