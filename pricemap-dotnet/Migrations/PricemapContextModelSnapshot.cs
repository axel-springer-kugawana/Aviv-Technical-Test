﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pricemap.Infrastructure.Database;

namespace pricemap.Migrations
{
    [DbContext(typeof(PricemapContext))]
    partial class PricemapContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("pricemap.Infrastructure.Database.Model.GeoPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("geo_place");
                });

            modelBuilder.Entity("pricemap.Infrastructure.Database.Model.Listing", b =>
                {
                    b.Property<string>("ListingId")
                        .HasColumnType("text")
                        .HasColumnName("listing_id");

                    b.Property<int>("Area")
                        .HasColumnType("integer")
                        .HasColumnName("area");

                    b.Property<int>("PlaceId")
                        .HasColumnType("integer")
                        .HasColumnName("place_id");

                    b.Property<int>("Price")
                        .HasColumnType("integer")
                        .HasColumnName("price");

                    b.Property<int>("RoomCount")
                        .HasColumnType("integer")
                        .HasColumnName("room_count");

                    b.HasKey("ListingId");

                    b.ToTable("listings");
                });

            modelBuilder.Entity("pricemap.Infrastructure.Database.Model.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ListingId")
                        .HasColumnType("text")
                        .HasColumnName("listing_id");

                    b.Property<DateTime>("PriceDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("price_date");

                    b.Property<int>("PriceValue")
                        .HasColumnType("integer")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("prices");
                });

            modelBuilder.Entity("pricemap.Infrastructure.Database.Model.View", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ListingId")
                        .HasColumnType("text")
                        .HasColumnName("listing_id");

                    b.Property<DateTime>("ViewDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("view_date");

                    b.HasKey("Id");

                    b.ToTable("views");
                });
#pragma warning restore 612, 618
        }
    }
}
