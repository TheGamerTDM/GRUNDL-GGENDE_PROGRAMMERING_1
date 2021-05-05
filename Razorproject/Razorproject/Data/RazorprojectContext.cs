using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Razorproject.Data
{
    public class RazorprojectContext : DbContext
    {
        public RazorprojectContext(
            DbContextOptions<RazorprojectContext> options)
            : base(options)
        {
        }

        public DbSet<Razorproject.Models.Movie> Movie { get; set; }
    }
}