﻿// <auto-generated />
using AddTrainerApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AddTrainerApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AddTrainerApi.Trainer", b =>
                {
                    b.Property<int>("TrainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerId"), 1L, 1);

                    b.Property<int>("SkillCode")
                        .HasColumnType("int");

                    b.Property<string>("TrainerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainerId");

                    b.ToTable("Trainers");
                });
#pragma warning restore 612, 618
        }
    }
}