﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SewingPatternShop.Models;

namespace SewingPatternShop.Migrations
{
    [DbContext(typeof(ShopContextSew))]
    partial class ShopContextSewModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SewingPatternShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "Skirt"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "Pants"
                        },
                        new
                        {
                            CategoryID = 3,
                            Name = "Blouse"
                        },
                        new
                        {
                            CategoryID = 4,
                            Name = "Dress"
                        });
                });

            modelBuilder.Entity("SewingPatternShop.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 1,
                            Code = "hoop",
                            Name = "Hoop skirt",
                            Price = 69m
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 1,
                            Code = "tutu",
                            Name = "Tutu skirt",
                            Price = 119m
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryID = 1,
                            Code = "pleated",
                            Name = "Pleated skirt",
                            Price = 251m
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryID = 1,
                            Code = "layered",
                            Name = "Layeres skirt",
                            Price = 48.99m
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryID = 2,
                            Code = "bush",
                            Name = "Bush pants",
                            Price = 29m
                        },
                        new
                        {
                            ProductID = 6,
                            CategoryID = 2,
                            Code = "jogger",
                            Name = "Jogger pants",
                            Price = 41m
                        },
                        new
                        {
                            ProductID = 7,
                            CategoryID = 2,
                            Code = "cargo",
                            Name = "Cargo pants",
                            Price = 79.99m
                        },
                        new
                        {
                            ProductID = 8,
                            CategoryID = 3,
                            Code = "gypsy",
                            Name = "Gypsy blouse",
                            Price = 49.99m
                        },
                        new
                        {
                            ProductID = 9,
                            CategoryID = 3,
                            Code = "tunic",
                            Name = "Tunic blouse",
                            Price = 69.99m
                        },
                        new
                        {
                            ProductID = 10,
                            CategoryID = 3,
                            Code = "ruffle",
                            Name = "Ruffle front blouse",
                            Price = 79.99m
                        },
                        new
                        {
                            ProductID = 11,
                            CategoryID = 4,
                            Code = "sheath",
                            Name = "Sheath dress",
                            Price = 79.99m
                        },
                        new
                        {
                            ProductID = 12,
                            CategoryID = 4,
                            Code = "trumpet",
                            Name = "Trumpet dress",
                            Price = 49.99m
                        },
                        new
                        {
                            ProductID = 13,
                            CategoryID = 4,
                            Code = "wrap",
                            Name = "Wrap arount dress",
                            Price = 69.99m
                        },
                        new
                        {
                            ProductID = 14,
                            CategoryID = 4,
                            Code = "buble",
                            Name = "Buble dress",
                            Price = 79.99m
                        });
                });

            modelBuilder.Entity("SewingPatternShop.Models.Product", b =>
                {
                    b.HasOne("SewingPatternShop.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}