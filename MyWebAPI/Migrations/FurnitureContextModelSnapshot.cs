﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebAPI.Entities;

namespace MyWebAPI.Migrations
{
    [DbContext(typeof(FurnitureContext))]
    partial class FurnitureContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyWebAPI.Entities.Furniture", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Cost")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Cost");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.ToTable("FurnitureTable");
                });
#pragma warning restore 612, 618
        }
    }
}
