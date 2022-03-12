using System;
using Microsoft.EntityFrameworkCore;
using sabashop.Models.Entities;

namespace sabashop.Models.Context
{

    public class ShopContext : DbContext
    {

        public ShopContext(DbContextOptions<ShopContext> options): base(options){  }





        #region db sets
        public DbSet<Tbl_User> tbl_Users { get; set; }
        public DbSet<Tbl_Slider> tbl_Sliders { get; set; }
        public DbSet<Tbl_SiteCategory> tbl_SiteCategories { get; set; }
        public DbSet<Tbl_ProductComment> tbl_ProductComments { get; set; }
        public DbSet<Tbl_Product> tbl_Products { get; set; }
        public DbSet<Tbl_MoreImageProduct> tbl_MoreImageProducts { get; set; }
        public DbSet<Tbl_Favorite> tbl_Favorites { get; set; }
        public DbSet<Tbl_Factor> tbl_Factors { get; set; }
        public DbSet<Tbl_DetailFactor> tbl_DetailFactors { get; set; }
        public DbSet<Tbl_Category> tbl_Categories { get; set; }
        public DbSet<Tbl_Baner> tbl_Baners { get; set; }
        public DbSet<Tbl_Logotitle> tbl_Logotitles { get; set; }
            
        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            base.OnConfiguring(optionBuilder);
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tbl_Logotitle>().HasData(
            new Tbl_Logotitle { Id = 1, Logo = "default", Title = "Shop" });
            base.OnModelCreating(builder);
            
        }
         
    }
}

