﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using taskoffcial.Data;

#nullable disable

namespace taskoffcial.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240928140133_h1")]
    partial class h1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("taskoffcial.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("birthDay")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("taskoffcial.Models.StudentSubject", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "SubjectID");

                    b.HasIndex("SubjectID");

                    b.ToTable("StudentSubjects");
                });

            modelBuilder.Entity("taskoffcial.Models.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectID"), 1L, 1);

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectID");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectID = 1,
                            SubjectName = "Arabic"
                        },
                        new
                        {
                            SubjectID = 2,
                            SubjectName = "English"
                        },
                        new
                        {
                            SubjectID = 3,
                            SubjectName = "Math"
                        },
                        new
                        {
                            SubjectID = 4,
                            SubjectName = "Science"
                        },
                        new
                        {
                            SubjectID = 5,
                            SubjectName = "History"
                        });
                });

            modelBuilder.Entity("taskoffcial.Models.StudentSubject", b =>
                {
                    b.HasOne("taskoffcial.Models.Student", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("taskoffcial.Models.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("taskoffcial.Models.Student", b =>
                {
                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("taskoffcial.Models.Subject", b =>
                {
                    b.Navigation("StudentSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
