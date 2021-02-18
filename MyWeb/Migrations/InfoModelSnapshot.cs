﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWeb.Data;

namespace MyWeb.Migrations
{
    [DbContext(typeof(Info))]
    partial class InfoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("MyWeb.Models.Geekration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Change")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hobbies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyLife")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Your_Values")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("geeky1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("geeky2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Geekration");
                });
#pragma warning restore 612, 618
        }
    }
}
