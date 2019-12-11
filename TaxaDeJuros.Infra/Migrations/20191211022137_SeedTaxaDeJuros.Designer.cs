﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaxaDeJuros.Infra.Data;

namespace TaxaDeJuros.Infra.Migrations
{
    [DbContext(typeof(TaxaDeJurosContext))]
    [Migration("20191211022137_SeedTaxaDeJuros")]
    partial class SeedTaxaDeJuros
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("TaxaDeJuros.Domain.TaxaDeJuros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TaxaDeJuros");
                });
#pragma warning restore 612, 618
        }
    }
}
