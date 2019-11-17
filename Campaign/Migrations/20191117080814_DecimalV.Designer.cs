﻿// <auto-generated />
using Campaign.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Campaign.Migrations
{
    [DbContext(typeof(CampaignContext))]
    [Migration("20191117080814_DecimalV")]
    partial class DecimalV
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("Campaign.Models.Campaign1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Bid")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Fund")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Keywords");

                    b.Property<string>("Name");

                    b.Property<int>("Radius");

                    b.Property<bool>("Status");

                    b.Property<string>("Town");

                    b.HasKey("Id");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("Campaign.Models.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Towns");

                    b.HasData(
                        new { Id = 1, Name = "Rzeszów" },
                        new { Id = 2, Name = "Kraków" },
                        new { Id = 3, Name = "Warszawa" },
                        new { Id = 4, Name = "Katowice" },
                        new { Id = 5, Name = "Gdańsk" },
                        new { Id = 6, Name = "Lublin" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}