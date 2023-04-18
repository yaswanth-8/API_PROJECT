using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_PROJECT.Model;

namespace API_PROJECT.Data
{
    public class API_PROJECTContext : DbContext
    {
        public API_PROJECTContext (DbContextOptions<API_PROJECTContext> options)
            : base(options)
        {
        }

        public DbSet<API_PROJECT.Model.Employee> Employee { get; set; } = default!;
    }
}
