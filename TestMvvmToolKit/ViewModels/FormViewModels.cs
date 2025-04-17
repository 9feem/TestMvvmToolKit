using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TestMvvmToolKit.Models;

namespace TestMvvmToolKit.ViewModels
{
    public partial class FormViewModels: ObservableObject
    {
        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string surname;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string tel;


        [ObservableProperty]
        private ObservableCollection<UserModel> userList = new ObservableCollection<UserModel>
        {
            new UserModel {Name = "mama", Surname = "Yolo",Email = "15555@gmail" , Tel = "07858454"},
            new UserModel {Name = "Oppo", Surname = "Vivo",Email = "953232@gmail" , Tel = "09555143"},
        };


        /*[RelayCommand]
        public void submit()
        {
            UserModel  userModel = new()
            {
                Name = Name,
                Surname = Surname,
                Email = Email,
                Tel = Tel
            };

            UserList.Add(userModel);


        }*/

    }
}
