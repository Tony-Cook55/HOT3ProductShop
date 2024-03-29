﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductShop.Models;

#nullable disable

namespace ProductShop.Migrations
{
    [DbContext(typeof(RecordContext))]
    [Migration("20240222222332_InitialPC")]
    partial class InitialPC
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductShop.Models.Record", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordId"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("RecordName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RecordId");

                    b.ToTable("Records");

                    b.HasData(
                        new
                        {
                            RecordId = 1,
                            ArtistName = "Andy William",
                            ImageFileName = "andy_williams__youve_got_a_friend.jpg",
                            Price = 15.0,
                            RecordName = "You've Got A Friend"
                        },
                        new
                        {
                            RecordId = 2,
                            ArtistName = "Dean Martin",
                            ImageFileName = "dean_martin__gentle_on_my_mind.jpg",
                            Price = 25.0,
                            RecordName = "Gentle On My Mind"
                        },
                        new
                        {
                            RecordId = 3,
                            ArtistName = "Frank Sinatra",
                            ImageFileName = "frank_sinatra__sinatras_sinatra.jpg",
                            Price = 30.0,
                            RecordName = "Sinatra's Sinatra"
                        },
                        new
                        {
                            RecordId = 4,
                            ArtistName = "Paul Anka",
                            ImageFileName = "paul_anka__anka.jpg",
                            Price = 10.0,
                            RecordName = "Anka"
                        },
                        new
                        {
                            RecordId = 5,
                            ArtistName = "Perry Como",
                            ImageFileName = "perry_como__its_impossible.jpg",
                            Price = 17.0,
                            RecordName = "It's Impossible"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
