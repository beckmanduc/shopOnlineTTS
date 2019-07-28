namespace ShopOnlineTTS.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopOnlineTTS.Data.ShopOnlineTTSDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopOnlineTTS.Data.ShopOnlineTTSDbContext context)
        {
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ShopOnlineTTSDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ShopOnlineTTSDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "anhduc",
            //    Email = "levuanhduc1996@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Technology Education"

            //};

            //manager.Create(user, "123654$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("levuanhduc1996@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });

        }

        private void CreateProductCategorySample(ShopOnlineTTS.Data.ShopOnlineTTSDbContext context)
        {
            if(context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name = "Bút viết",Alias = "but-viet",Status =true },
                new ProductCategory() { Name = "Sổ sách",Alias = "so-sach",Status =true },
                new ProductCategory() { Name = "Hồ sơ",Alias = "ho-so",Status =true },
                new ProductCategory() { Name = "Máy tính",Alias = "may-tinh",Status =true }
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
           
        }
    }
}
