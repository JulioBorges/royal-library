﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoyalLibrary.Data;

#nullable disable

namespace RoyalLibrary.Data.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20240218202621_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RoyalLibrary.Domain.Book", b =>
                {
                    b.Property<int?>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("BookId"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("category");

                    b.Property<int>("CopiesInUse")
                        .HasColumnType("int")
                        .HasColumnName("copies_in_use");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("Isbn")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("isbn");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<int>("TotalCopies")
                        .HasColumnType("int")
                        .HasColumnName("total_copies");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("type");

                    b.HasKey("BookId");

                    b.ToTable("books");
                });
#pragma warning restore 612, 618
        }
    }
}
