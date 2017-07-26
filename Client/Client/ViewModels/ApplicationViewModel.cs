using Client.Commands;
using Client.DIModule;
using Client.Model;
using Client.ViewModel;
using Microsoft.Win32;
using Newtonsoft.Json;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client.ViewModels
{
    public class ApplicationViewModel : IApplicationViewModel, INotifyPropertyChanged
    {
        private IRepository repository;
        public ApplicationViewModel()
        {
            CurrentUser = new User();
            AuthorizeData = new Authorize();
            var AppKernal = new StandardKernel(new ApplicationNinjectModule());
            repository = AppKernal.Get<Repository>();

            ShowPassword = Visibility.Hidden;
        }

        private bool IsValidAuthorizeData()
        {
            if (string.IsNullOrEmpty(AuthorizeData?.Login))
            {
                MessageBox.Show("Введите логин пользователя");
                return false;
            }
            if (string.IsNullOrEmpty(AuthorizeData?.Password))
            {
                MessageBox.Show("Введите пароль пользователя");
                return false;
            }
            return true;
        }

        private bool IsValidCurrentUser()
        {
            if (string.IsNullOrEmpty(CurrentUser?.FirstName))
            {
                MessageBox.Show("Введите имя пользователя");
                return false;
            }
            if (string.IsNullOrEmpty(CurrentUser?.LastName))
            {
                MessageBox.Show("Введите фамилию пользователя");
                return false;
            }
            if (string.IsNullOrEmpty(CurrentUser?.Email))
            {
                MessageBox.Show("Введите Email пользователя");
                return false;
            }
            if (string.IsNullOrEmpty(CurrentUser?.Logins))
            {
                MessageBox.Show("Введите логин пользователя");
                return false;
            }
            if (string.IsNullOrEmpty(CurrentUser?.Passwords))
            {
                MessageBox.Show("Введите пароль пользователя");
                return false;
            }
            if (string.IsNullOrEmpty(CurrentUser?.AvatarPath))
            {
                MessageBox.Show("Выберете фото для пользователя");
                return false;
            }
            else
            {
                FileInfo file = new FileInfo(CurrentUser.AvatarPath);
                if (file.Exists)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Выберете корректный путь к фотографии");
                    return false;
                }
            }
        }

        public void ReqisterUser(object obj)
        {
            try
            {

                CurrentUser = repository.Register(CurrentUser);
                if (CurrentUser?.FirstName != null)
                {
                    IsEnable = true;
                }
                else
                {
                    MessageBox.Show("Во время регистрации возникла ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateUser(object obj)
        {
            try
            {
                if (CurrentUser != null)
                {
                    if (CurrentUser.Id == 0)
                    {
                        MessageBox.Show("Введите пароль пользователя");
                        return;
                    }
                    if (!IsValidCurrentUser())
                    {
                        return;
                    }
                    var answer = repository.Update(CurrentUser);
                    if (answer != "NoContent")
                    {
                        MessageBox.Show("При обновлении произошла ошибка");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь успешно изменен");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void Login(object obj)
        {
            try
            {
                if (!IsValidAuthorizeData())
                {
                    return;
                }
                CurrentUser = repository.Login(AuthorizeData);
                

                if (CurrentUser?.FirstName != null)
                {
                    IsEnable = true;
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином и паролем не найден");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void UpdatePhoto(object obj)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == true)
                {
                    CurrentUser.AvatarPath = file.FileName;
                }
                else
                {
                    MessageBox.Show("Во время открытия диологового окна произошла ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClickRegister(object obj)
        {
            IsRegister = true;
        }

        private void OnMouseDown(object obj)
        {
            ShowPassword = Visibility.Visible;
            HiddenPasswordBox = Visibility.Hidden;
        }

        private void OnMouseUp(object obj)
        {
            ShowPassword = Visibility.Hidden;
            HiddenPasswordBox = Visibility.Visible;
        }

        private bool isEnable;
        public bool IsEnable
        {
            get
            {
                return isEnable;
            }
            set
            {
                isEnable = value;
                OnPropertyChanged("IsEnable");
            }
        }

        private bool isRegister;
        public bool IsRegister
        {
            get
            {
                return isRegister;
            }
            set
            {
                isRegister = value;
                OnPropertyChanged("IsRegister");
            }
        }

        private Visibility showPassword;
        public Visibility ShowPassword
        {
            get
            {
                return showPassword;
            }
            set
            {
                showPassword = value;
                OnPropertyChanged("ShowPassword");
            }
        }

        private Visibility hiddenPasswordBox;
        public Visibility HiddenPasswordBox
        {
            get
            {
                return hiddenPasswordBox;
            }
            set
            {
                hiddenPasswordBox = value;
                OnPropertyChanged("HiddenPasswordBox");
            }
        }

        private User currentUser;
        private Authorize authorizeData;


        public Authorize AuthorizeData
        {
            get
            {
                return authorizeData;
            }
            set
            {
                authorizeData = value;
                OnPropertyChanged("AuthorizeData");
            }
        }

        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
                OnPropertyChanged("CurrentUser");
            }
        }

        private RelayCommand login;
        public RelayCommand LogIn
        {
            get
            {
                if (login == null)
                {
                    Action<object> action = new Action<object>(Login);
                    login = new RelayCommand(action);
                }
                return login;
            }

        }

        private RelayCommand addUser;
        public RelayCommand AddUser
        {
            get
            {
                if (addUser == null)
                {
                    Action<object> action = new Action<object>(ReqisterUser);
                    addUser = new RelayCommand(action);
                }
                return addUser;
            }
        }



        private RelayCommand updateAvatarPath;
        public RelayCommand UpdateAvatarPath
        {
            get
            {
                if (updateAvatarPath == null)
                {
                    Action<object> action = new Action<object>(UpdatePhoto);
                    updateAvatarPath = new RelayCommand(action);
                }
                return updateAvatarPath;
            }
        }

        private RelayCommand updateCurrentUser;
        public RelayCommand UpdateCurrentUser
        {
            get
            {
                if (updateCurrentUser == null)
                {
                    Action<object> action = new Action<object>(UpdateUser);
                    updateCurrentUser = new RelayCommand(action);
                }
                return updateCurrentUser;
            }
        }

        private RelayCommand clickRegisterCommand;
        public RelayCommand ClickRegisterCommand
        {
            get
            {
                if(clickRegisterCommand == null)
                {
                    clickRegisterCommand = new RelayCommand(ClickRegister);
                }
                return clickRegisterCommand;
            }
        }

        private RelayCommand mouseDownCommand;
        public RelayCommand MouseDownCommand
        {
            get
            {
                if(mouseDownCommand == null)
                {
                    mouseDownCommand = new RelayCommand(OnMouseDown);
                }
                return mouseDownCommand;
            }
        }

        private RelayCommand mouseUpCommand;
        public RelayCommand MouseUpCommand
        {
            get
            {
                if(mouseUpCommand == null)
                {
                    mouseUpCommand = new RelayCommand(OnMouseUp);
                }
                return mouseUpCommand;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
