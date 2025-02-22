﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Telefon Açıklaması",
                            ImageUrl = "1.jpg",
                            IsActive = true,
                            Name = "Iphone 15",
                            Price = 70000m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            Description = "Telefon Açıklaması",
                            ImageUrl = "2.jpg",
                            IsActive = true,
                            Name = "Iphone 16",
                            Price = 80000m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 3,
                            Description = "Telefon Açıklaması",
                            ImageUrl = "3.jpg",
                            IsActive = true,
                            Name = "Iphone 16 Pro",
                            Price = 90000m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 4,
                            Description = "Telefon Açıklaması",
                            ImageUrl = "4.jpg",
                            IsActive = true,
                            Name = "Iphone 16 Pro Max",
                            Price = 100000m,
                            Stock = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
