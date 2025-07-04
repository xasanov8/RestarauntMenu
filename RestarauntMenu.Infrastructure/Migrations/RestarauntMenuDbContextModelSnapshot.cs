﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RestarauntMenu.Infrastructure.Persistance;

#nullable disable

namespace RestarauntMenu.Infrastructure.Migrations
{
    [DbContext(typeof(RestarauntMenuDbContext))]
    partial class RestarauntMenuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.Food", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Allergens")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("MenuSectionId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("MenuSectionId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.Menu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("RestarauntId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RestarauntId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.MenuSection", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("MenuId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuSections");
                });

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.Restaraunt", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("AdminId")
                        .HasColumnType("bigint");

                    b.Property<string>("LogoPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WorkTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AdminId")
                        .IsUnique();

                    b.ToTable("Restaraunts");
                });

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2025, 6, 22, 6, 37, 27, 693, DateTimeKind.Utc).AddTicks(2067),
                            Name = "Default Super Admin",
                            PasswordHash = "AQAAAAIAAYagAAAAEMHpoPU8rWQC0YuXCtRsZ4ZwWfPfoMEZAPuxZnRA7VF41todQWeADvi5q15+d8/lKg==",
                            PhoneNumber = "+998774194249",
                            Role = 2
                        });
                });

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.Food", b =>
                {
                    b.HasOne("RestarauntMenu.Domain.Entities.MenuSection", "MenuSection")
                        .WithMany("Foods")
                        .HasForeignKey("MenuSectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuSection");
                });

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.Menu", b =>
                {
                    b.HasOne("RestarauntMenu.Domain.Entities.Restaraunt", "Restaraunt")
                        .WithMany()
                        .HasForeignKey("RestarauntId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaraunt");
                });

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.MenuSection", b =>
                {
                    b.HasOne("RestarauntMenu.Domain.Entities.Menu", "Menu")
                        .WithMany("Sections")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.Restaraunt", b =>
                {
                    b.HasOne("RestarauntMenu.Domain.Entities.User", "Admin")
                        .WithOne("Restaraunt")
                        .HasForeignKey("RestarauntMenu.Domain.Entities.Restaraunt", "AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.Menu", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.MenuSection", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("RestarauntMenu.Domain.Entities.User", b =>
                {
                    b.Navigation("Restaraunt");
                });
#pragma warning restore 612, 618
        }
    }
}
