﻿// <auto-generated />
using System;
using App.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace App.Context.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20241217122948_140309271559")]
    partial class _140309271559
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entites.Entites.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
