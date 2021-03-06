﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerApp.Models;

namespace ServerApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ServerApp.Models.ImageFileName", b =>
                {
                    b.Property<long>("ImageFileNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ProductId")
                        .HasColumnType("bigint");

                    b.HasKey("ImageFileNameId");

                    b.HasIndex("ProductId");

                    b.ToTable("ImageFileNames");
                });

            modelBuilder.Entity("ServerApp.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("QuantityOnHand")
                        .HasColumnType("int");

                    b.Property<long?>("SupplierId")
                        .HasColumnType("bigint");

                    b.HasKey("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("ServerApp.Models.Rating", b =>
                {
                    b.Property<long>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.HasIndex("ProductId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("ServerApp.Models.Supplier", b =>
                {
                    b.Property<long>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ServerApp.Models.Needles", b =>
                {
                    b.HasBaseType("ServerApp.Models.Product");

                    b.Property<bool>("IsInterchangeable")
                        .HasColumnType("bit");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("NeedlesType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SizeUS")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Needles");
                });

            modelBuilder.Entity("ServerApp.Models.Yarn", b =>
                {
                    b.HasBaseType("ServerApp.Models.Product");

                    b.Property<string>("Collection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrochetGauge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FiberBlend")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsWashable")
                        .HasColumnType("bit");

                    b.Property<string>("KnittingGauge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Yardage")
                        .HasColumnType("float");

                    b.Property<string>("YarnType")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Yarn");
                });

            modelBuilder.Entity("ServerApp.Models.ImageFileName", b =>
                {
                    b.HasOne("ServerApp.Models.Product", "Product")
                        .WithMany("ImageFiles")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ServerApp.Models.Product", b =>
                {
                    b.HasOne("ServerApp.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("ServerApp.Models.Rating", b =>
                {
                    b.HasOne("ServerApp.Models.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ServerApp.Models.Product", b =>
                {
                    b.Navigation("ImageFiles");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("ServerApp.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
