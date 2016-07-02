using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.WebApp;

namespace WebApp.Models
{
    public class WebAppDbContext : DbContext
    {
        public WebAppDbContext (DbContextOptions<WebAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<JobInfo> JobInfo { get; set; }
    }
}
