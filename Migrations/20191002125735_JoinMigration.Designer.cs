﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University.Models;

namespace University.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20191002125735_JoinMigration")]
    partial class JoinMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("University.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CrHourse");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int?>("FacultyId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("CourseId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("University.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("UniversityId");

                    b.HasKey("FacultyId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("University.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FName")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("LName")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Profession")
                        .IsRequired();

                    b.Property<string>("Rank")
                        .IsRequired();

                    b.Property<int>("Salary");

                    b.HasKey("InstructorId");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("University.Models.Student", b =>
                {
                    b.Property<int>("StudetId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<DateTime>("DateEnrolled");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FName")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("LName")
                        .IsRequired();

                    b.HasKey("StudetId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("University.Models.Universities", b =>
                {
                    b.Property<int>("UniversityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("UniversityId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("University.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FName")
                        .IsRequired();

                    b.Property<string>("LName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("University.Models.Course", b =>
                {
                    b.HasOne("University.Models.Faculty")
                        .WithMany("CourseNo")
                        .HasForeignKey("FacultyId");
                });

            modelBuilder.Entity("University.Models.Faculty", b =>
                {
                    b.HasOne("University.Models.Universities", "university")
                        .WithMany("staff")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
