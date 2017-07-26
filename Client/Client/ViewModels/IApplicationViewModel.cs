using Client.Commands;
using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client.ViewModel
{
    public interface IApplicationViewModel
    {

        void ReqisterUser(object obj);

        void UpdateUser(object obj);

        void Login(object obj);

        bool IsEnable { get; set; }

        bool IsRegister { get; set; }

        Visibility ShowPassword { get; set; }

        Visibility HiddenPasswordBox { get; set; }

        RelayCommand ClickRegisterCommand { get; }

        RelayCommand LogIn { get; }

        RelayCommand AddUser { get; }

        RelayCommand UpdateAvatarPath { get; }

        RelayCommand UpdateCurrentUser { get; }

        RelayCommand MouseDownCommand { get; }

        RelayCommand MouseUpCommand { get; }

        Authorize AuthorizeData { get; set; }

        User CurrentUser { get; set; }
    }
}
