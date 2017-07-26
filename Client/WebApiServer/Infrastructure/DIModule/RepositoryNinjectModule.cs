using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiServer.Infrastructure.Context;
using WebApiServer.Infrastructure.Repository;
using WebApiServer.Models.User;

namespace WebApiServer.Infrastructure.DIModule
{
    public class RepositoryNinjectModule: NinjectModule
    {
        public override void Load()
        {
            this.Bind<IRepository<Users>>().To<CabinetRepository<Users>>();
        }
    }
}