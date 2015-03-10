using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LogInApp.Models
{
    public class Gateway : DbContext

    {
        public Gateway() : base("LogIn")
        {
        }

        public DbSet<User> Users { set; get; }
    }
}