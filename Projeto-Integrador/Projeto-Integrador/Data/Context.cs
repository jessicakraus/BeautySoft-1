using static WebApp.BeautySoft.Data.Context;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApp.BeautySoft.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace WebApp.BeautySoft.Data
{
    public class Context : IdentityDbContext<IdentityUser>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<UserModel> Users { get; set; }

        
    }
    
}
