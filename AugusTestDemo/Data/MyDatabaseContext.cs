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
        public DbSet<Models.FeatherBean.Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AugusTestDemo.Models.Todo>().ToTable("Todo");
            //產品相關
            modelBuilder.Entity<Models.FeatherBean.FeatherImage>().ToTable("FeatherImage");
            modelBuilder.Entity<Models.FeatherBean.Product>().ToTable("Product");
            modelBuilder.Entity<Models.FeatherBean.ProductType>().ToTable("ProductType");
            //主畫面需求
            modelBuilder.Entity<Models.FeatherBean.HomePage>().ToTable("HomePage");
            //本季花色
            modelBuilder.Entity<Models.FeatherBean.ColorOfTheSeason>().ToTable("ColorOfTheSeason");
            modelBuilder.Entity<Models.FeatherBean.ColorOfTheSeasonMode>().ToTable("ColorOfTheSeasonMode");
            modelBuilder.Entity<Models.FeatherBean.ColorOfTheSeasonImage>().ToTable("ColorOfTheSeasonImage");
            //設計師手稿
            modelBuilder.Entity<Models.FeatherBean.DesignerManuscript>().ToTable("DesignerManuscript");
            modelBuilder.Entity<Models.FeatherBean.DesignerManuscriptMode>().ToTable("DesignerManuscriptMode");
            modelBuilder.Entity<Models.FeatherBean.DesignerManuscriptImage>().ToTable("DesignerManuscriptImage");
            //客製化服務
            modelBuilder.Entity<Models.FeatherBean.CustomizedService>().ToTable("CustomizedService");
            modelBuilder.Entity<Models.FeatherBean.CustomizedServiceMode>().ToTable("CustomizedServiceMode");
            modelBuilder.Entity<Models.FeatherBean.CustomizedServiceImage>().ToTable("CustomizedServiceImage");
            //最新活動
            modelBuilder.Entity<Models.FeatherBean.LatestEvents>().ToTable("LatestEvents");
            modelBuilder.Entity<Models.FeatherBean.LatestEventsMode>().ToTable("LatestEventsMode");
            modelBuilder.Entity<Models.FeatherBean.LatestEventsImage>().ToTable("LatestEventsImage");
        }
    }
}
