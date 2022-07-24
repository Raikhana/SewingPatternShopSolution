using Microsoft.EntityFrameworkCore;

namespace SewingPatternShop.Models
{
    public class ShopContextSew : DbContext
    {
        public ShopContextSew(DbContextOptions<ShopContextSew> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Skirt" },
                new Category { CategoryID = 2, Name = "Pants" },
                new Category { CategoryID = 3, Name = "Blouse" },
                new Category { CategoryID = 4, Name = "Dress" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    CategoryID = 1,
                    Code = "hoop",
                    Name = "Hoop skirt",
                    Price = (decimal)69.00
                },
                new Product
                {
                    ProductID = 2,
                    CategoryID = 1,
                    Code = "tutu",
                    Name = "Tutu skirt",
                    Price = (decimal)119.00
                },
                new Product
                {
                    ProductID = 3,
                    CategoryID = 1,
                    Code = "pleated",
                    Name = "Pleated skirt",
                    Price = (decimal)251.00
                },
                new Product
                {
                    ProductID = 4,
                    CategoryID = 1,
                    Code = "layered",
                    Name = "Layeres skirt",
                    Price = (decimal)48.99
                },


                new Product
                {
                    ProductID = 5,
                    CategoryID = 2,
                    Code = "bush",
                    Name = "Bush pants",
                    Price = (decimal)29.00
                },
                new Product
                {
                    ProductID = 6,
                    CategoryID = 2,
                    Code = "jogger",
                    Name = "Jogger pants",
                    Price = (decimal)41.00
                },
                new Product
                {
                    ProductID = 7,
                    CategoryID = 2,
                    Code = "cargo",
                    Name = "Cargo pants",
                    Price = (decimal)79.99
                },


                new Product
                {
                    ProductID = 8,
                    CategoryID = 3,
                    Code = "gypsy",
                    Name = "Gypsy blouse",
                    Price = (decimal)49.99
                },
                new Product
                {
                    ProductID = 9,
                    CategoryID = 3,
                    Code = "tunic",
                    Name = "Tunic blouse",
                    Price = (decimal)69.99
                },
                new Product
                {
                    ProductID = 10,
                    CategoryID = 3,
                    Code = "ruffle",
                    Name = "Ruffle front blouse",
                    Price = (decimal)79.99
                },

                new Product
                {
                    ProductID = 11,
                    CategoryID = 4,
                    Code = "sheath",
                    Name = "Sheath dress",
                    Price = (decimal)79.99
                },
                new Product
                {
                    ProductID = 12,
                    CategoryID = 4,
                    Code = "trumpet",
                    Name = "Trumpet dress",
                    Price = (decimal)49.99
                },
                new Product
                {
                    ProductID = 13,
                    CategoryID = 4,
                    Code = "wrap",
                    Name = "Wrap arount dress",
                    Price = (decimal)69.99
                },
                new Product
                {
                    ProductID = 14,
                    CategoryID = 4,
                    Code = "buble",
                    Name = "Buble dress",
                    Price = (decimal)79.99
                }
            );
        }
    }
}
