﻿// <auto-generated />
using Juliusz_Final.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Juliusz_Final.Migrations
{
    [DbContext(typeof(EFCDbContext))]
    [Migration("20171129093238_003")]
    partial class _003
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Juliusz_Final.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RentDivider");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Juliusz_Final.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BirthDate");

                    b.Property<int?>("Height");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("Skill");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Juliusz_Final.Models.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<double>("Condition");

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<decimal>("Value");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Juliusz_Final.Models.Rent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerID");

                    b.Property<DateTime?>("ExpirationDate");

                    b.Property<double>("ItemCondition");

                    b.Property<int>("ItemId");

                    b.Property<DateTime>("RentDate");

                    b.Property<DateTime?>("ReturnDate");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ItemId");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("Juliusz_Final.Models.Item", b =>
                {
                    b.HasOne("Juliusz_Final.Models.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Juliusz_Final.Models.Rent", b =>
                {
                    b.HasOne("Juliusz_Final.Models.Customer", "Customer")
                        .WithMany("Rents")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Juliusz_Final.Models.Item", "Item")
                        .WithMany("Rents")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
