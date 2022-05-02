﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermixListing.API.Data;

#nullable disable

namespace TermixListing.API.Migrations
{
    [DbContext(typeof(termixListViewContext))]
    partial class termixListViewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TermixListing.API.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Texas",
                            ShortName = "SANA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sterling",
                            ShortName = "SL"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Penselvania",
                            ShortName = "EGS"
                        });
                });

            modelBuilder.Entity("TermixListing.API.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "1059 suvid RD",
                            CountryId = 1,
                            Name = "Corp",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 2,
                            Address = "EGS Suvid RD",
                            CountryId = 2,
                            Name = "Egs Plant",
                            Rating = 4.4000000000000004
                        },
                        new
                        {
                            Id = 3,
                            Address = "Suvid RD",
                            CountryId = 3,
                            Name = "SANA PLant",
                            Rating = 3.0
                        });
                });

            modelBuilder.Entity("TermixListing.API.Data.Hotel", b =>
                {
                    b.HasOne("TermixListing.API.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("TermixListing.API.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}