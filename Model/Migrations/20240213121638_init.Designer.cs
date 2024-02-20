﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(DBApiContext))]
    [Migration("20240213121638_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Model.Modules.CategoryModel.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                            Name = "category name  16"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                            Name = "category name  30"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                            Name = "category name  45"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                            Name = "category name  41"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                            Name = "category name  23"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                            Name = "category name  29"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                            Name = "category name  2"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                            Name = "category name  45"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                            Name = "category name  10"
                        });
                });

            modelBuilder.Entity("Model.Modules.OrderModel.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                            Status = 0,
                            Time = new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9395),
                            UserId = "79640b64-94d3-4cb2-89c8-a5fefe3c2051"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                            Status = 0,
                            Time = new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9397),
                            UserId = "79640b64-94d3-4cb2-89c8-a5fefe3c2052"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                            Status = 0,
                            Time = new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9399),
                            UserId = "79640b64-94d3-4cb2-89c8-a5fefe3c2053"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                            Status = 0,
                            Time = new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9399),
                            UserId = "79640b64-94d3-4cb2-89c8-a5fefe3c2054"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                            Status = 0,
                            Time = new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9400),
                            UserId = "79640b64-94d3-4cb2-89c8-a5fefe3c2055"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                            Status = 0,
                            Time = new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9402),
                            UserId = "79640b64-94d3-4cb2-89c8-a5fefe3c2056"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                            Status = 0,
                            Time = new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9403),
                            UserId = "79640b64-94d3-4cb2-89c8-a5fefe3c2057"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                            Status = 0,
                            Time = new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9404),
                            UserId = "79640b64-94d3-4cb2-89c8-a5fefe3c2058"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                            Status = 0,
                            Time = new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9405),
                            UserId = "79640b64-94d3-4cb2-89c8-a5fefe3c2059"
                        });
                });

            modelBuilder.Entity("Model.Modules.ProductModel.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                            CategoryId = "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                            Description = "Mô tả điện thoại",
                            Image = "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8",
                            Name = "ProductName 42",
                            Price = 2569m
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                            CategoryId = "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                            Description = "Mô tả điện thoại",
                            Image = "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8",
                            Name = "ProductName 47",
                            Price = 2543m
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                            CategoryId = "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                            Description = "Mô tả điện thoại",
                            Image = "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8",
                            Name = "ProductName 12",
                            Price = 2551m
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                            CategoryId = "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                            Description = "Mô tả điện thoại",
                            Image = "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8",
                            Name = "ProductName 7",
                            Price = 2579m
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                            CategoryId = "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                            Description = "Mô tả điện thoại",
                            Image = "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8",
                            Name = "ProductName 43",
                            Price = 2538m
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                            CategoryId = "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                            Description = "Mô tả điện thoại",
                            Image = "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8",
                            Name = "ProductName 19",
                            Price = 2572m
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                            CategoryId = "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                            Description = "Mô tả điện thoại",
                            Image = "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8",
                            Name = "ProductName 49",
                            Price = 2581m
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                            CategoryId = "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                            Description = "Mô tả điện thoại",
                            Image = "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8",
                            Name = "ProductName 38",
                            Price = 2581m
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                            CategoryId = "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                            Description = "Mô tả điện thoại",
                            Image = "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8",
                            Name = "ProductName 40",
                            Price = 2580m
                        });
                });

            modelBuilder.Entity("Model.Modules.ProductOrderModel.ProductOrder", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("ProductOrders");

                    b.HasData(
                        new
                        {
                            ProductId = "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                            OrderId = "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                            Quantity = 12
                        },
                        new
                        {
                            ProductId = "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                            OrderId = "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                            OrderId = "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                            Quantity = 34
                        },
                        new
                        {
                            ProductId = "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                            OrderId = "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                            Quantity = 45
                        },
                        new
                        {
                            ProductId = "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                            OrderId = "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                            Quantity = 47
                        },
                        new
                        {
                            ProductId = "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                            OrderId = "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                            Quantity = 36
                        },
                        new
                        {
                            ProductId = "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                            OrderId = "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                            Quantity = 37
                        },
                        new
                        {
                            ProductId = "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                            OrderId = "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                            Quantity = 39
                        },
                        new
                        {
                            ProductId = "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                            OrderId = "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                            Quantity = 37
                        });
                });

            modelBuilder.Entity("Model.Modules.UserModel.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                            AccessFailedCount = 0,
                            Address = "Dia chi 49",
                            ConcurrencyStamp = "8f0f4b1c-34e5-4e1f-88e5-35951a4f0e90",
                            Email = "user42@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "nguyen",
                            LastName = "19",
                            LockoutEnabled = false,
                            PasswordHash = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4b495378-da7d-49b2-a9bb-9b891e2f79d6",
                            TwoFactorEnabled = false,
                            UserName = "nguyen14"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                            AccessFailedCount = 0,
                            Address = "Dia chi 46",
                            ConcurrencyStamp = "9849b1b4-79aa-44a3-bf6a-9e4dffd75989",
                            Email = "user37@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "nguyen",
                            LastName = "24",
                            LockoutEnabled = false,
                            PasswordHash = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "16a69000-2900-4e1e-9bf0-5e27810d1415",
                            TwoFactorEnabled = false,
                            UserName = "nguyen10"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                            AccessFailedCount = 0,
                            Address = "Dia chi 31",
                            ConcurrencyStamp = "d25b25ad-f552-4550-9c1b-b716b0551bb2",
                            Email = "user17@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "nguyen",
                            LastName = "37",
                            LockoutEnabled = false,
                            PasswordHash = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "57fb86d3-efaa-4474-af00-c13e478f9eea",
                            TwoFactorEnabled = false,
                            UserName = "nguyen44"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                            AccessFailedCount = 0,
                            Address = "Dia chi 9",
                            ConcurrencyStamp = "d3a4cd1e-125d-4c04-a4e2-d240c520656c",
                            Email = "user22@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "nguyen",
                            LastName = "47",
                            LockoutEnabled = false,
                            PasswordHash = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "980e7af4-c68c-4ce3-8ee5-a91f956c73e4",
                            TwoFactorEnabled = false,
                            UserName = "nguyen43"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                            AccessFailedCount = 0,
                            Address = "Dia chi 16",
                            ConcurrencyStamp = "a8cbefe4-cd82-442e-8143-2617f5d6cd38",
                            Email = "user49@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "nguyen",
                            LastName = "38",
                            LockoutEnabled = false,
                            PasswordHash = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "45f1741d-ab19-4368-824e-ed96b637b9a5",
                            TwoFactorEnabled = false,
                            UserName = "nguyen3"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                            AccessFailedCount = 0,
                            Address = "Dia chi 30",
                            ConcurrencyStamp = "2a3cb63e-34c4-41a8-af69-7d0edaf72a15",
                            Email = "user25@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "nguyen",
                            LastName = "16",
                            LockoutEnabled = false,
                            PasswordHash = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd4a1c0d-b34a-487e-9921-98abd96f1b56",
                            TwoFactorEnabled = false,
                            UserName = "nguyen28"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                            AccessFailedCount = 0,
                            Address = "Dia chi 40",
                            ConcurrencyStamp = "4c37f16e-ebaf-40c2-9db6-3c54c04a60e6",
                            Email = "user43@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "nguyen",
                            LastName = "30",
                            LockoutEnabled = false,
                            PasswordHash = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "55d4d275-2782-4f06-90ab-57d39b5b3508",
                            TwoFactorEnabled = false,
                            UserName = "nguyen16"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                            AccessFailedCount = 0,
                            Address = "Dia chi 5",
                            ConcurrencyStamp = "76232e95-753e-4d7a-ad3d-582d5047f16d",
                            Email = "user9@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "nguyen",
                            LastName = "3",
                            LockoutEnabled = false,
                            PasswordHash = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c5faaaf6-c479-4dc4-a876-e9bdf72c5571",
                            TwoFactorEnabled = false,
                            UserName = "nguyen26"
                        },
                        new
                        {
                            Id = "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                            AccessFailedCount = 0,
                            Address = "Dia chi 42",
                            ConcurrencyStamp = "b6eaf532-4c37-48f0-9840-aebba7a47f91",
                            Email = "user6@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "nguyen",
                            LastName = "23",
                            LockoutEnabled = false,
                            PasswordHash = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dd024905-9b47-4462-b894-36e07322a7d4",
                            TwoFactorEnabled = false,
                            UserName = "nguyen23"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Model.Modules.UserModel.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Model.Modules.UserModel.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Modules.UserModel.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Model.Modules.UserModel.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Modules.OrderModel.Order", b =>
                {
                    b.HasOne("Model.Modules.UserModel.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Model.Modules.ProductModel.Product", b =>
                {
                    b.HasOne("Model.Modules.CategoryModel.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Model.Modules.ProductOrderModel.ProductOrder", b =>
                {
                    b.HasOne("Model.Modules.OrderModel.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Modules.ProductModel.Product", "Product")
                        .WithMany("ProductOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Model.Modules.CategoryModel.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Model.Modules.OrderModel.Order", b =>
                {
                    b.Navigation("ProductOrders");
                });

            modelBuilder.Entity("Model.Modules.ProductModel.Product", b =>
                {
                    b.Navigation("ProductOrders");
                });

            modelBuilder.Entity("Model.Modules.UserModel.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}