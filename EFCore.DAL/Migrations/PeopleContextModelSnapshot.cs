﻿// <auto-generated />
using System;
using EFCore.DAL.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.DAL.Migrations
{
    [DbContext(typeof(PeopleContext))]
    partial class PeopleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.DAL.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("PersonId");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("EFCore.DAL.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int?>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("EmailAdresses");
                });

            modelBuilder.Entity("EFCore.DAL.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("EFCore.DAL.Models.Address", b =>
                {
                    b.HasOne("EFCore.DAL.Models.Person")
                        .WithMany("Addresses")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("EFCore.DAL.Models.Email", b =>
                {
                    b.HasOne("EFCore.DAL.Models.Person")
                        .WithMany("EmailAdresses")
                        .HasForeignKey("PersonId");
                });
#pragma warning restore 612, 618
        }
    }
}
