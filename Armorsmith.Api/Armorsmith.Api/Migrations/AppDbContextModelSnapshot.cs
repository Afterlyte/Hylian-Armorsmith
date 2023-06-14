﻿// <auto-generated />
using Armorsmith.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Armorsmith.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Armorsmith.Api.Data.Armor", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Set")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Armors");
                });

            modelBuilder.Entity("Armorsmith.Api.Data.Defense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArmorName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DefensePoints")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArmorName");

                    b.ToTable("Defense");
                });

            modelBuilder.Entity("Armorsmith.Api.Data.MaterialValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArmorName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArmorName");

                    b.ToTable("MaterialValue");
                });

            modelBuilder.Entity("Armorsmith.Api.Data.Defense", b =>
                {
                    b.HasOne("Armorsmith.Api.Data.Armor", null)
                        .WithMany("DefensePoints")
                        .HasForeignKey("ArmorName");
                });

            modelBuilder.Entity("Armorsmith.Api.Data.MaterialValue", b =>
                {
                    b.HasOne("Armorsmith.Api.Data.Armor", null)
                        .WithMany("UpgradeMaterials")
                        .HasForeignKey("ArmorName");
                });

            modelBuilder.Entity("Armorsmith.Api.Data.Armor", b =>
                {
                    b.Navigation("DefensePoints");

                    b.Navigation("UpgradeMaterials");
                });
#pragma warning restore 612, 618
        }
    }
}
