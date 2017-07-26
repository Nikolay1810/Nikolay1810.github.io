using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiServer.Models.User
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(200)]
        public string AvatarPath { get; set; }

        [Required]
        [MaxLength(40)]
        public string Email { get; set; }

        [Required]
        [MaxLength(40)]
        public string Logins { get; set; }

        [Required]
        [MaxLength(40)]
        public string Passwords { get; set; }
    }
}