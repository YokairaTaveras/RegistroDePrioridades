﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace RegistroDePrioridades.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230902040801_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Prioridades", b =>
                {
                    b.Property<int>("PrioridadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DiasCompromiso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PrioridadId");

                    b.ToTable("Prioridades");
                });
#pragma warning restore 612, 618
        }
    }
}
