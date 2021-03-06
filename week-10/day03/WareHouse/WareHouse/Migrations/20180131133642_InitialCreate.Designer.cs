﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using WareHouse.Entities;

namespace WareHouse.Migrations
{
    [DbContext(typeof(ClothesContext))]
    [Migration("20180131133642_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WareHouse.Models.Clothes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Category");

                    b.Property<long>("ItemName");

                    b.Property<long>("Manufacturer");

                    b.Property<long>("Size");

                    b.Property<long>("UnitPrice");

                    b.HasKey("Id");

                    b.ToTable("WarehouseDB");
                });
#pragma warning restore 612, 618
        }
    }
}
