using Microsoft.EntityFrameworkCore;
using Resourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourcing.Infrastructure.Persistence
{
    public class ResourcingDbContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Temp> Temps { get; set; }

        public ResourcingDbContext(DbContextOptions<ResourcingDbContext> options) : base(options) { }
    }
}
