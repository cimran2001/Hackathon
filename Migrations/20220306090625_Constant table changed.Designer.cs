﻿// <auto-generated />
using System;
using Hackathon.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hackathon.Migrations
{
    [DbContext(typeof(FarmDbContext))]
    [Migration("20220306090625_Constant table changed")]
    partial class Constanttablechanged
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hackathon.Models.AutumnPloughing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<double>("AppliedHA")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("Depth")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("AutumnPloughings");
                });

            modelBuilder.Entity("Hackathon.Models.Constant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Constants");
                });

            modelBuilder.Entity("Hackathon.Models.Cultivation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<double>("AppliedHA")
                        .HasColumnType("float");

                    b.Property<long>("NumberOfTimes")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Cultivations");
                });

            modelBuilder.Entity("Hackathon.Models.Efficiency", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("Tons")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Efficiencies");
                });

            modelBuilder.Entity("Hackathon.Models.Farm", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long?>("AutumnPloughingId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CultivationId")
                        .HasColumnType("bigint");

                    b.Property<long?>("EfficiencyId")
                        .HasColumnType("bigint");

                    b.Property<long?>("FarmerId")
                        .HasColumnType("bigint");

                    b.Property<long?>("FertilizingId")
                        .HasColumnType("bigint");

                    b.Property<double>("HA")
                        .HasColumnType("float");

                    b.Property<long?>("IrrigationId")
                        .HasColumnType("bigint");

                    b.Property<long>("NumberOfFields")
                        .HasColumnType("bigint");

                    b.Property<long?>("PlantingId")
                        .HasColumnType("bigint");

                    b.Property<long?>("QualityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SeedingId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SpringPloughingId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ToppingId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AutumnPloughingId");

                    b.HasIndex("CultivationId");

                    b.HasIndex("EfficiencyId");

                    b.HasIndex("FarmerId");

                    b.HasIndex("FertilizingId");

                    b.HasIndex("IrrigationId");

                    b.HasIndex("PlantingId");

                    b.HasIndex("QualityId");

                    b.HasIndex("SeedingId");

                    b.HasIndex("SpringPloughingId");

                    b.HasIndex("ToppingId");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("Hackathon.Models.Farmer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Farmers");
                });

            modelBuilder.Entity("Hackathon.Models.Fertilizing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<double>("AppliedHA")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Integrity")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Fertilizings");
                });

            modelBuilder.Entity("Hackathon.Models.Irrigation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<double>("AppliedHA")
                        .HasColumnType("float");

                    b.Property<long>("NumberOfTimes")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Irrigations");
                });

            modelBuilder.Entity("Hackathon.Models.Planting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<double>("AppliedHA")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("PlantPopulation")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Plantings");
                });

            modelBuilder.Entity("Hackathon.Models.Quality", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("Score")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Qualities");
                });

            modelBuilder.Entity("Hackathon.Models.Seeding", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("IntervalCM")
                        .HasColumnType("bigint");

                    b.Property<bool>("Standart")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Seedings");
                });

            modelBuilder.Entity("Hackathon.Models.SpringPloughing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<double>("AppliedHA")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("Depth")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("SpringPloughings");
                });

            modelBuilder.Entity("Hackathon.Models.Topping", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<double>("AppliedHA")
                        .HasColumnType("float");

                    b.Property<bool>("Spraying")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Toppings");
                });

            modelBuilder.Entity("Hackathon.Models.Farm", b =>
                {
                    b.HasOne("Hackathon.Models.AutumnPloughing", "AutumnPloughing")
                        .WithMany()
                        .HasForeignKey("AutumnPloughingId");

                    b.HasOne("Hackathon.Models.Cultivation", "Cultivation")
                        .WithMany()
                        .HasForeignKey("CultivationId");

                    b.HasOne("Hackathon.Models.Efficiency", "Efficiency")
                        .WithMany()
                        .HasForeignKey("EfficiencyId");

                    b.HasOne("Hackathon.Models.Farmer", "Farmer")
                        .WithMany()
                        .HasForeignKey("FarmerId");

                    b.HasOne("Hackathon.Models.Fertilizing", "Fertilizing")
                        .WithMany()
                        .HasForeignKey("FertilizingId");

                    b.HasOne("Hackathon.Models.Irrigation", "Irrigation")
                        .WithMany()
                        .HasForeignKey("IrrigationId");

                    b.HasOne("Hackathon.Models.Planting", "Planting")
                        .WithMany()
                        .HasForeignKey("PlantingId");

                    b.HasOne("Hackathon.Models.Quality", "Quality")
                        .WithMany()
                        .HasForeignKey("QualityId");

                    b.HasOne("Hackathon.Models.Seeding", "Seeding")
                        .WithMany()
                        .HasForeignKey("SeedingId");

                    b.HasOne("Hackathon.Models.SpringPloughing", "SpringPloughing")
                        .WithMany()
                        .HasForeignKey("SpringPloughingId");

                    b.HasOne("Hackathon.Models.Topping", "Topping")
                        .WithMany()
                        .HasForeignKey("ToppingId");

                    b.Navigation("AutumnPloughing");

                    b.Navigation("Cultivation");

                    b.Navigation("Efficiency");

                    b.Navigation("Farmer");

                    b.Navigation("Fertilizing");

                    b.Navigation("Irrigation");

                    b.Navigation("Planting");

                    b.Navigation("Quality");

                    b.Navigation("Seeding");

                    b.Navigation("SpringPloughing");

                    b.Navigation("Topping");
                });
#pragma warning restore 612, 618
        }
    }
}
