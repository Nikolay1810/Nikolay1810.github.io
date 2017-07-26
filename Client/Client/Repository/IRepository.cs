using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    public interface IRepository:IDisposable
    {
        User Register(User registerUser);
        string Update(User currentUser);
        User Login(Authorize authorizaData);
    }
}
