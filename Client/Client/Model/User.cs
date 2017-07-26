using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class User : INotifyPropertyChanged
    {
        private int id { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string avatarPath { get; set; }
        private string email { get; set; }
        private string logins { get; set; }
        private string passwords { get; set; }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string AvatarPath {
            get
            {
                return avatarPath;
            }
            set
            {
                avatarPath = value;
                OnPropertyChanged("AvatarPath");
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        public string Logins
        {
            get
            {
                return logins;
            }
            set
            {
                logins = value;
                OnPropertyChanged("Logins");
            }
        }

        public string Passwords
        {
            get
            {
                return passwords;
            }
            set
            {
                passwords = value;
                OnPropertyChanged("Passwords");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
