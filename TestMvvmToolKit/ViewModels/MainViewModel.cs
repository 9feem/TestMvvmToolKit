using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TestMvvmToolKit.Views;

namespace TestMvvmToolKit.ViewModels
{
    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        private object contentsAll;

        public FormViewModels showFormViewModels = new();
        public ManagerViewModels showManagerViewModels = new();

        public MainViewModel()
        {
            ContentsAll = showManagerViewModels;
        }

        [RelayCommand]
        public void Manager()
        {
            ContentsAll = showManagerViewModels;
        }

        [RelayCommand]
        public void Add()
        {
            ContentsAll = showFormViewModels;
        }

        




    }
}
