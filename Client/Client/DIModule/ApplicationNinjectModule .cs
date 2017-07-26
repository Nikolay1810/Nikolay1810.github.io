using Client.Commands;
using Client.ViewModel;
using Client.ViewModels;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DIModule
{
    public class ApplicationNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IRepository>().To<Repository>();
            this.Bind<IApplicationViewModel>().To<ApplicationViewModel>();
        }
    }
}
