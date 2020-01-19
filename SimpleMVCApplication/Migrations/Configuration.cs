namespace SimpleMVCApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SimpleMVCApplication.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleApplication>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SimpleApplication context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            if (!context.Categories.Any())
            {
                context.Categories.AddOrUpdate(
                        new Category { Id = 1, CategoryName = "Motherboard" },
                        new Category { Id = 2, CategoryName = "CPU" },
                        new Category { Id = 3, CategoryName = "Graphics Card" }
                    );
                context.SaveChanges();
            }

            // if we don't have any Products, then run Seeder
            if (!context.Products.Any())
            {
                context.Products.AddOrUpdate(
                    new Product { Name = "MSI B250 Mortar Arctic", CategoryId = 1, Description = "Featuring heavy plated heat sinks and fierce looks, MSI ARSENAL GAMING motherboards are packed with gaming features for a refined gaming experience.", Image = "https://asset.msi.com/resize/image/global/product/product_7_20170113171624_58789ae8c92d6.png62405b38c58fe0f07fcef2367d8a9ba1/1024.png", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new Product { Name = "INTEL® CORE™ i9-9900K PROCESSOR", CategoryId = 2, Description = "Intel® Core™ i9-9900K Processor The Intel® Z390 chipset paired with an Intel® Core™ i9-9900K processor are fast and powerful out of the box—and still let you custom tune for even higher performance.", Image = "https://images.idgesg.net/images/article/2018/10/intel-9th-gen-core-13-100775938-large.jpg", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new Product { Name = "GEFORCE RTX 2080 Ti", CategoryId = 3, Description = "NVIDIA’s newest flagship graphics card is a revolution in gaming realism and performance. Its powerful NVIDIA Turing™ GPU architecture, breakthrough technologies, and 11 GB of next-gen, ultra-fast GDDR6 memory make it the world’s ultimate gaming GPU.", Image = "https://oyster.ignimgs.com/wordpress/stg.ign.com/2018/09/geforce-rtx-2080-ti-web-tech-shot-630-u.png", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
                    );
                context.SaveChanges();
            }
        }
    }
}
