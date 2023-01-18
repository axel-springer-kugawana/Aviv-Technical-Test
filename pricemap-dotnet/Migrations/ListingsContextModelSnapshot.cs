﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pricemap.Infrastructure.Database;

namespace pricemap.Migrations
{
    [DbContext(typeof(ListingsContext))]
    partial class ListingsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("pricemap.Infrastructure.Database.Models.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BedroomsCount")
                        .HasColumnType("integer")
                        .HasColumnName("bedrooms_count");

                    b.Property<string>("BuildingType")
                        .HasColumnType("text")
                        .HasColumnName("building_type");

                    b.Property<string>("City")
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<string>("ContactPhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("contact_phone_number");

                    b.Property<string>("Country")
                        .HasColumnType("text")
                        .HasColumnName("country");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PostalCode")
                        .HasColumnType("text")
                        .HasColumnName("postal_code");

                    b.Property<int>("Price")
                        .HasColumnType("integer")
                        .HasColumnName("price");

                    b.Property<DateTime>("PriceDatePosted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("price_date_posted");

                    b.Property<int>("RoomsCount")
                        .HasColumnType("integer")
                        .HasColumnName("rooms_count");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("text")
                        .HasColumnName("street_address");

                    b.Property<int>("SurfaceAreaM2")
                        .HasColumnType("integer")
                        .HasColumnName("surface_area_m2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.ToTable("listings");
                });
#pragma warning restore 612, 618
        }
    }
}
