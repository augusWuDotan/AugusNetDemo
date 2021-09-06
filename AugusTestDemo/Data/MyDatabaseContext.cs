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

        public DbSet<Models.FeatherBean.FeatherImage> FeatherImages { get; set; }
        public DbSet<Models.FeatherBean.Product> Products { get; set; }
        public DbSet<Models.FeatherBean.ProductType> ProductTypes { get; set; }
        public DbSet<Models.FeatherBean.Designer> Designers { get; set; }

        public DbSet<Models.FeatherBean.HomePage> HomePage { get; set; }

        public DbSet<Models.FeatherBean.ColorOfTheSeason> ColorOfTheSeason { get; set; }
        public DbSet<Models.FeatherBean.ColorOfTheSeasonMode> ColorOfTheSeasonModes { get; set; }
        public DbSet<Models.FeatherBean.ColorOfTheSeasonImage> ColorOfTheSeasonImages { get; set; }

        public DbSet<Models.FeatherBean.DesignerManuscript> DesignerManuscript { get; set; }
        public DbSet<Models.FeatherBean.DesignerManuscriptMode> DesignerManuscriptModes { get; set; }
        public DbSet<Models.FeatherBean.DesignerManuscriptImage> DesignerManuscriptImages { get; set; }

        public DbSet<Models.FeatherBean.CustomizedService> CustomizedService { get; set; }
        public DbSet<Models.FeatherBean.CustomizedServiceMode> CustomizedServiceModes { get; set; }
        public DbSet<Models.FeatherBean.CustomizedServiceImage> CustomizedServiceImages { get; set; }

        public DbSet<Models.FeatherBean.LatestEvents> LatestEvents { get; set; }
        public DbSet<Models.FeatherBean.LatestEventsMode> LatestEventsModes { get; set; }
        public DbSet<Models.FeatherBean.LatestEventsImage> LatestEventsImages { get; set; }

        public DbSet<Models.FeatherBean.BrandStory> BrandStory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AugusTestDemo.Models.Todo>().ToTable("Todo");
            //產品相關
            modelBuilder.Entity<Models.FeatherBean.FeatherImage>().ToTable("FeatherImage");
            modelBuilder.Entity<Models.FeatherBean.Product>().ToTable("Product");
            modelBuilder.Entity<Models.FeatherBean.ProductType>().ToTable("ProductType");
            //設計師相關
            modelBuilder.Entity<Models.FeatherBean.Designer>().ToTable("Designer");
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
            //品牌故事
            modelBuilder.Entity<Models.FeatherBean.BrandStory>().ToTable("BrandStory");
        }
    }
}
