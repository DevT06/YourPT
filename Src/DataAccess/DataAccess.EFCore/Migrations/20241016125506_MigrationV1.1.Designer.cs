﻿// <auto-generated />
using System;
using DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.EFCore.Migrations
{
    [DbContext(typeof(YourPTDbContext))]
    [Migration("20241016125506_MigrationV1.1")]
    partial class MigrationV11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shared.Entities.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Complete")
                        .HasColumnType("bit")
                        .HasColumnName("Complete");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<int>("GoalId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GoalId");

                    b.HasIndex("UserId");

                    b.ToTable("Assignments", (string)null);
                });

            modelBuilder.Entity("Shared.Entities.AssignmentReflection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("UserId");

                    b.ToTable("AssignmentReflections", (string)null);
                });

            modelBuilder.Entity("Shared.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasMaxLength(5000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Content");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs", (string)null);
                });

            modelBuilder.Entity("Shared.Entities.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Complete")
                        .HasColumnType("bit")
                        .HasColumnName("Complete");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Goals", (string)null);
                });

            modelBuilder.Entity("Shared.Entities.GoalReflection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<int>("GoalId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GoalId");

                    b.HasIndex("UserId");

                    b.ToTable("GoalReflections", (string)null);
                });

            modelBuilder.Entity("Shared.Entities.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Text")
                        .HasMaxLength(5000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notes", (string)null);
                });

            modelBuilder.Entity("Shared.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("DisplayName");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Username");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Shared.Entities.Assignment", b =>
                {
                    b.HasOne("Shared.Entities.Goal", "Goal")
                        .WithMany("Assignments")
                        .HasForeignKey("GoalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shared.Entities.User", "User")
                        .WithMany("Assignments")
                        .HasForeignKey("UserId");

                    b.Navigation("Goal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shared.Entities.AssignmentReflection", b =>
                {
                    b.HasOne("Shared.Entities.Assignment", "Assignment")
                        .WithMany("Reflections")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.Entities.User", "User")
                        .WithMany("AssignmentReflections")
                        .HasForeignKey("UserId");

                    b.Navigation("Assignment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shared.Entities.Blog", b =>
                {
                    b.HasOne("Shared.Entities.User", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shared.Entities.Goal", b =>
                {
                    b.HasOne("Shared.Entities.User", "User")
                        .WithMany("Goals")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shared.Entities.GoalReflection", b =>
                {
                    b.HasOne("Shared.Entities.Goal", "Goal")
                        .WithMany("Reflections")
                        .HasForeignKey("GoalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.Entities.User", "User")
                        .WithMany("GoalReflections")
                        .HasForeignKey("UserId");

                    b.Navigation("Goal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shared.Entities.Note", b =>
                {
                    b.HasOne("Shared.Entities.User", "User")
                        .WithMany("Notes")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shared.Entities.Assignment", b =>
                {
                    b.Navigation("Reflections");
                });

            modelBuilder.Entity("Shared.Entities.Goal", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Reflections");
                });

            modelBuilder.Entity("Shared.Entities.User", b =>
                {
                    b.Navigation("AssignmentReflections");

                    b.Navigation("Assignments");

                    b.Navigation("Blogs");

                    b.Navigation("GoalReflections");

                    b.Navigation("Goals");

                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
