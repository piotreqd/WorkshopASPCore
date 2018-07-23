﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WorkshopAsp.Models.DomainModel;

namespace WorkshopAsp.Migrations
{
    [DbContext(typeof(WorkshopContext))]
    [Migration("20180723153437_DbSets")]
    partial class DbSets
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkshopAsp.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("LaborPrice");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<int>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("WorkshopAsp.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Mark");

                    b.Property<string>("Model");

                    b.Property<int>("OwnerId");

                    b.Property<string>("Registration");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("WorkshopAsp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Car");

                    b.Property<int>("CarId");

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WorkshopAsp.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("WorkshopAsp.Models.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityId");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("WorkshopAsp.Models.Activity", b =>
                {
                    b.HasOne("WorkshopAsp.Models.Order")
                        .WithMany("Activities")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkshopAsp.Models.Car", b =>
                {
                    b.HasOne("WorkshopAsp.Models.Owner", "Owner")
                        .WithMany("Cars")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkshopAsp.Models.Order", b =>
                {
                    b.HasOne("WorkshopAsp.Models.Car")
                        .WithMany("Orders")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkshopAsp.Models.Part", b =>
                {
                    b.HasOne("WorkshopAsp.Models.Activity", "Activity")
                        .WithMany("Parts")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
