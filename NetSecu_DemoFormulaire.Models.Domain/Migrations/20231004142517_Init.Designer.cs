﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetSecu_DemoFormulaire.Models.Domain;

#nullable disable

namespace NetSecu_DemoFormulaire.Models.Domain.Migrations
{
    [DbContext(typeof(SampleDbContext))]
    [Migration("20231004142517_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NetSecu_DemoFormulaire.Models.Entities.Utilisateur", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(75)");

                    b.Property<byte[]>("Passwd")
                        .IsRequired()
                        .HasColumnType("BINARY(64)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(384)");

                    b.HasKey("Id");

                    b.ToTable("Utilisateur", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}