using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voltron.Hackathon.Models;

namespace Voltron.Hackathon.Context
{
    public class ServiceDirectoryContext : DbContext
    {
        public ServiceDirectoryContext(DbContextOptions<ServiceDirectoryContext> options)
            : base(options)
        {
        }

        public DbSet<ServiceEntity> Services { get; set; }
    }
}
