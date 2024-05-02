﻿// <auto-generated />
using System;
using BudgetBills.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BudgetBills.Migrations
{
    [DbContext(typeof(BudgetBillsContext))]
    [Migration("20240428200447_Category")]
    partial class Category
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BudgetBills.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BillId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Bills");

                    b.HasData(
                        new
                        {
                            BillId = 1,
                            Amount = 1369.0,
                            CategoryId = 1,
                            Description = "Mortgage",
                            DueDate = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BillId = 2,
                            Amount = 267.0,
                            CategoryId = 2,
                            Description = "Car Payment",
                            DueDate = new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BillId = 3,
                            Amount = 130.0,
                            CategoryId = 2,
                            Description = "Car Insurance",
                            DueDate = new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BudgetBills.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description1 = "Housing/Utilities",
                            Description2 = "Needs"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description1 = "Transportation",
                            Description2 = "Needs"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description1 = "Subscriptions",
                            Description2 = "Wants"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description1 = "Pets",
                            Description2 = "Needs"
                        },
                        new
                        {
                            CategoryId = 6,
                            Description1 = "Medical",
                            Description2 = "Needs"
                        },
                        new
                        {
                            CategoryId = 7,
                            Description1 = "Personal",
                            Description2 = "Wants"
                        });
                });

            modelBuilder.Entity("BudgetBills.Models.Bill", b =>
                {
                    b.HasOne("BudgetBills.Models.Category", "Category")
                        .WithMany("Bills")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BudgetBills.Models.Category", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
