using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiServer.Models.Mapping;
using WebApiServer.Models.User;

namespace WebApiServer.Infrastructure.Context
{
    public class CabinetContext: DbContext
    {
        public CabinetContext() : base("CabinetContext")
        {
            Database.SetInitializer<CabinetContext>(new UserInitializerIfModelChanges());
        }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }

   
    public class UserInitializerIfModelChanges : DropCreateDatabaseIfModelChanges<CabinetContext>
    {
        protected override void Seed(CabinetContext context)
        {
            var user = new Users()
            {
                FirstName = "Nikolay",
                LastName = "Chernyak",
                Email = "mrblackjack1810@gmail.com",
                AvatarPath = "/Images/avatar.jpg",
                Logins = "admin",
                Passwords = "admin"
            };

            context.Users.Add(user);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}