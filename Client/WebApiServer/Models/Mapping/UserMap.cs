using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApiServer.Models.User;

namespace WebApiServer.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<Users>
    {
        public UserMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.FirstName).IsRequired().HasMaxLength(40);
            this.Property(t => t.LastName).IsRequired().HasMaxLength(40);
            this.Property(t => t.Email).IsRequired().HasMaxLength(40);
            this.Property(t => t.AvatarPath).IsRequired().HasMaxLength(200);
            this.Property(t => t.Logins).IsRequired().HasMaxLength(40);
            this.Property(t => t.Passwords).IsRequired().HasMaxLength(40);

            this.ToTable("Users");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.AvatarPath).HasColumnName("AvatarPath");
            this.Property(t => t.Logins).HasColumnName("Logins");
            this.Property(t => t.Passwords).HasColumnName("Passwords");

        }
    }
}