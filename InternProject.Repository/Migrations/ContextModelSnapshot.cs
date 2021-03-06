﻿// <auto-generated />
using System;
using InternshipProject.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace InternshipProject.Repository.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("InternshipProject.Core.Entities.AddressModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("CEP")
                        .HasColumnType("numeric")
                        .HasMaxLength(8);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Complement")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Number")
                        .HasColumnType("integer")
                        .HasMaxLength(8);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("InternshipProject.Core.Entities.CompanyModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<decimal>("AgreementCode")
                        .HasColumnType("numeric");

                    b.Property<decimal>("CNPJ")
                        .HasColumnType("numeric")
                        .HasMaxLength(14);

                    b.Property<bool>("IsIntegratingAgent")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PersonResponsibleName")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("InternshipProject.Core.Entities.CourseModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Education")
                        .HasColumnType("integer");

                    b.Property<bool>("InternshipRequired")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Period")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("InternshipProject.Core.Entities.DocumentsModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comments")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("InternshipProject.Core.Entities.InternshipContractModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("HoursPerWeek")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("InternshipContract");
                });

            modelBuilder.Entity("InternshipProject.Core.Entities.StudentModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(8);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("character varying(11)")
                        .HasMaxLength(11);

                    b.Property<decimal>("IFPRCode")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("InternshipProject.Core.Entities.AddressModel", b =>
                {
                    b.HasOne("InternshipProject.Core.Entities.CompanyModel", "Company")
                        .WithOne("Address")
                        .HasForeignKey("InternshipProject.Core.Entities.AddressModel", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InternshipProject.Core.Entities.CourseModel", b =>
                {
                    b.HasOne("InternshipProject.Core.Entities.InternshipContractModel", "Contract")
                        .WithOne("Course")
                        .HasForeignKey("InternshipProject.Core.Entities.CourseModel", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InternshipProject.Core.Entities.DocumentsModel", b =>
                {
                    b.HasOne("InternshipProject.Core.Entities.CompanyModel", "Company")
                        .WithMany("Documents")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InternshipProject.Core.Entities.InternshipContractModel", "InternshipContract")
                        .WithOne("Document")
                        .HasForeignKey("InternshipProject.Core.Entities.DocumentsModel", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InternshipProject.Core.Entities.StudentModel", "Student")
                        .WithMany("Documents")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InternshipProject.Core.Entities.StudentModel", b =>
                {
                    b.HasOne("InternshipProject.Core.Entities.CourseModel", "Course")
                        .WithMany("Students")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
