﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sabashop.Models.Context;

namespace sabashop.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20220313132621_byuuuuu")]
    partial class byuuuuu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_Baner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IDBaner")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkTO")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Baners");
                });

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FatherId")
                        .HasColumnType("int");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GrandFatherId")
                        .HasColumnType("int");

                    b.Property<string>("GrandFatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Categories");
                });

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_DetailFactor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<long>("RFactor")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalPrice")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("tbl_DetailFactors");
                });

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_Factor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("PayTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<long>("RFactor")
                        .HasColumnType("bigint");

                    b.Property<bool>("StatusPay")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("tbl_Factors");
                });

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tbl_Favorites");
                });

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_Logotitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Logotitles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Logo = "default",
                            Title = "Shop"
                        });
                });

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_MoreImageProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_MoreImageProducts");
                });

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Offer")
                        .HasColumnType("int");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("SiteCategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("tbl_Products");
                });

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_ProductComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdminRespons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<bool>("ShowStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_ProductComments");
                });

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_SiteCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_SiteCategories");
                });

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkTO")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Sliders");
                });

            modelBuilder.Entity("sabashop.Models.Entities.Tbl_User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActiveCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Users");
                });
#pragma warning restore 612, 618
        }
    }
}
