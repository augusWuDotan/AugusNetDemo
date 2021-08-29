using System;
using Microsoft.EntityFrameworkCore;

namespace AugusTestDemo.Data
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Todo> Todo { get; set; }
        public DbSet<Models.FeatherBean.FeatherImage> FeatherImage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AugusTestDemo.Models.Todo>().ToTable("Todo");
            modelBuilder.Entity<Models.FeatherBean.FeatherImage>().ToTable("FeatherImage");
        }
    }
}
