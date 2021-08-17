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

        public DbSet<AugusTestDemo.Models.Todo> Todo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AugusTestDemo.Models.Todo>().ToTable("Todo");
        }
    }
}
