﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Practice2025_Gusev;

#nullable disable

namespace Practice2025_Gusev.Migrations
{
    [DbContext(typeof(Practice2025Context))]
    [Migration("20250421100154_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Practice2025_Gusev.Models.Group", b =>
                {
                    b.Property<int>("group_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("group_id"));

                    b.Property<string>("group_number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("institut_id")
                        .HasColumnType("integer");

                    b.Property<int>("specialty_id")
                        .HasColumnType("integer");

                    b.HasKey("group_id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Practice2025_Gusev.Models.Institute", b =>
                {
                    b.Property<int>("institut_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("institut_id"));

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name_institute")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title_dean")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("institut_id");

                    b.ToTable("Institutes");
                });

            modelBuilder.Entity("Practice2025_Gusev.Models.Specialty", b =>
                {
                    b.Property<int>("specialty_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("specialty_id"));

                    b.Property<int>("institut_id")
                        .HasColumnType("integer");

                    b.Property<int>("specialty_identifier")
                        .HasColumnType("integer");

                    b.Property<string>("specialty_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("specialty_id");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("Practice2025_Gusev.Models.Students", b =>
                {
                    b.Property<int>("student_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("student_id"));

                    b.Property<DateTime>("date_birth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<char>("full_name")
                        .HasColumnType("character(1)");

                    b.Property<int>("group_id")
                        .HasColumnType("integer");

                    b.Property<int>("year_admission")
                        .HasColumnType("integer");

                    b.HasKey("student_id");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
