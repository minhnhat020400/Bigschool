using Bigschool.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

 

namespace Bigschool.Models
{
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public DbSet<Soure> soures { get; set; }
            public DbSet<Category> categories { get; set; }

            public ApplicationDbContext()
                : base("DefaultConnection", throwIfV1Schema: false)
            {

            }

            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }

        }
}