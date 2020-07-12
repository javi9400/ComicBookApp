﻿// <auto-generated />
using System;
using ComicBook.Api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ComicBook.Api.Migrations
{
    [DbContext(typeof(ComicBookContext))]
    [Migration("20200712050243_RegisteringDefaultDataForDb")]
    partial class RegisteringDefaultDataForDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ComicBook.Api.Entities.ComicBook", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Issue")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ComicBooks");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateOfCreation = new DateTime(2020, 7, 11, 23, 2, 42, 543, DateTimeKind.Local).AddTicks(2444),
                            Description = "Test comic for pollo",
                            Issue = 69,
                            ReleaseDate = new DateTime(2020, 7, 11, 23, 2, 42, 542, DateTimeKind.Local).AddTicks(1480),
                            Title = "Venganza del toro vince part 1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
