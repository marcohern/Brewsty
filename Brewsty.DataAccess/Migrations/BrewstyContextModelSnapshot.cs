﻿// <auto-generated />
using System;
using Brewsty.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Brewsty.DataAccess.Migrations
{
    [DbContext(typeof(BrewstyContext))]
    partial class BrewstyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Brewsty.Entities.Beer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Abv")
                        .HasColumnType("float");

                    b.Property<float>("AttenuationLevel")
                        .HasColumnType("float");

                    b.Property<int?>("BoilVolumeId")
                        .HasColumnType("int");

                    b.Property<string>("BrewerTips")
                        .HasColumnType("text");

                    b.Property<string>("ContributedBy")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<float>("Ebc")
                        .HasColumnType("float");

                    b.Property<DateTime>("FirstBrewed")
                        .HasColumnType("datetime");

                    b.Property<float>("Ibu")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<int?>("IngredientsId")
                        .HasColumnType("int");

                    b.Property<int?>("MethodId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Ph")
                        .HasColumnType("float");

                    b.Property<string>("Tagline")
                        .HasColumnType("text");

                    b.Property<float>("TargetFG")
                        .HasColumnType("float");

                    b.Property<float>("TargetOG")
                        .HasColumnType("float");

                    b.Property<int?>("VolumeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BoilVolumeId");

                    b.HasIndex("IngredientsId");

                    b.HasIndex("MethodId");

                    b.HasIndex("VolumeId");

                    b.ToTable("Beers");
                });

            modelBuilder.Entity("Brewsty.Entities.Fermentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("TempId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TempId");

                    b.ToTable("Fermentation");
                });

            modelBuilder.Entity("Brewsty.Entities.FoodDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BeerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BeerId");

                    b.ToTable("FoodDescription");
                });

            modelBuilder.Entity("Brewsty.Entities.Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Yeast")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Brewsty.Entities.Malt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AmountId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("IngredientsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AmountId");

                    b.HasIndex("IngredientsId");

                    b.ToTable("Malt");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Malt");
                });

            modelBuilder.Entity("Brewsty.Entities.Method", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FermentationId")
                        .HasColumnType("int");

                    b.Property<string>("Twist")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FermentationId");

                    b.ToTable("Method");
                });

            modelBuilder.Entity("Brewsty.Entities.TempDuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Duration")
                        .HasColumnType("float");

                    b.Property<int?>("MethodId")
                        .HasColumnType("int");

                    b.Property<int?>("TempId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MethodId");

                    b.HasIndex("TempId");

                    b.ToTable("TempDuration");
                });

            modelBuilder.Entity("Brewsty.Entities.UnitValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.Property<float>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("UnitValue");
                });

            modelBuilder.Entity("Brewsty.Entities.Hop", b =>
                {
                    b.HasBaseType("Brewsty.Entities.Malt");

                    b.Property<string>("Add")
                        .HasColumnType("text");

                    b.Property<string>("Attribute")
                        .HasColumnType("text");

                    b.Property<int?>("IngredientsId1")
                        .HasColumnType("int");

                    b.HasIndex("IngredientsId1");

                    b.HasDiscriminator().HasValue("Hop");
                });

            modelBuilder.Entity("Brewsty.Entities.Beer", b =>
                {
                    b.HasOne("Brewsty.Entities.UnitValue", "BoilVolume")
                        .WithMany()
                        .HasForeignKey("BoilVolumeId");

                    b.HasOne("Brewsty.Entities.Ingredients", "Ingredients")
                        .WithMany()
                        .HasForeignKey("IngredientsId");

                    b.HasOne("Brewsty.Entities.Method", "Method")
                        .WithMany()
                        .HasForeignKey("MethodId");

                    b.HasOne("Brewsty.Entities.UnitValue", "Volume")
                        .WithMany()
                        .HasForeignKey("VolumeId");

                    b.Navigation("BoilVolume");

                    b.Navigation("Ingredients");

                    b.Navigation("Method");

                    b.Navigation("Volume");
                });

            modelBuilder.Entity("Brewsty.Entities.Fermentation", b =>
                {
                    b.HasOne("Brewsty.Entities.UnitValue", "Temp")
                        .WithMany()
                        .HasForeignKey("TempId");

                    b.Navigation("Temp");
                });

            modelBuilder.Entity("Brewsty.Entities.FoodDescription", b =>
                {
                    b.HasOne("Brewsty.Entities.Beer", null)
                        .WithMany("FoodPairing")
                        .HasForeignKey("BeerId");
                });

            modelBuilder.Entity("Brewsty.Entities.Malt", b =>
                {
                    b.HasOne("Brewsty.Entities.UnitValue", "Amount")
                        .WithMany()
                        .HasForeignKey("AmountId");

                    b.HasOne("Brewsty.Entities.Ingredients", null)
                        .WithMany("Malt")
                        .HasForeignKey("IngredientsId");

                    b.Navigation("Amount");
                });

            modelBuilder.Entity("Brewsty.Entities.Method", b =>
                {
                    b.HasOne("Brewsty.Entities.Fermentation", "Fermentation")
                        .WithMany()
                        .HasForeignKey("FermentationId");

                    b.Navigation("Fermentation");
                });

            modelBuilder.Entity("Brewsty.Entities.TempDuration", b =>
                {
                    b.HasOne("Brewsty.Entities.Method", null)
                        .WithMany("MashTemp")
                        .HasForeignKey("MethodId");

                    b.HasOne("Brewsty.Entities.UnitValue", "Temp")
                        .WithMany()
                        .HasForeignKey("TempId");

                    b.Navigation("Temp");
                });

            modelBuilder.Entity("Brewsty.Entities.Hop", b =>
                {
                    b.HasOne("Brewsty.Entities.Ingredients", null)
                        .WithMany("Hops")
                        .HasForeignKey("IngredientsId1");
                });

            modelBuilder.Entity("Brewsty.Entities.Beer", b =>
                {
                    b.Navigation("FoodPairing");
                });

            modelBuilder.Entity("Brewsty.Entities.Ingredients", b =>
                {
                    b.Navigation("Hops");

                    b.Navigation("Malt");
                });

            modelBuilder.Entity("Brewsty.Entities.Method", b =>
                {
                    b.Navigation("MashTemp");
                });
#pragma warning restore 612, 618
        }
    }
}
