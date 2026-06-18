using Enterprise.Domain.Entities;
using Enterprise.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Infrastructure
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<UserEntity> Users => Set<UserEntity>();
        public DbSet<BlogEntity> Blog => Set<BlogEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
