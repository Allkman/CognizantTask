﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgramingCompetition.DAL;

namespace ProgramingCompetition.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210906070056_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProgramingCompetition.DAL.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RootobjectId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RootobjectId");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("ProgramingCompetition.DAL.Models.ClassificatorTaskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChallengeId")
                        .HasColumnType("int");

                    b.Property<string>("TaskDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.ToTable("ClassificatorTaskType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TaskDescription = "Write a code snippet to display first 25 fib numbers",
                            TaskTitle = "FibbonacciSequence"
                        },
                        new
                        {
                            Id = 2,
                            TaskDescription = "Write a code snippet to display first 25 primary numbers",
                            TaskTitle = "PrimaryNumber"
                        });
                });

            modelBuilder.Entity("ProgramingCompetition.DAL.Models.RootObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("clientId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clientSecret")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("script")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stdin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("versionIndex")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RootObjects");
                });

            modelBuilder.Entity("ProgramingCompetition.DAL.Models.Challenge", b =>
                {
                    b.HasOne("ProgramingCompetition.DAL.Models.RootObject", "Rootobject")
                        .WithMany()
                        .HasForeignKey("RootobjectId");

                    b.Navigation("Rootobject");
                });

            modelBuilder.Entity("ProgramingCompetition.DAL.Models.ClassificatorTaskType", b =>
                {
                    b.HasOne("ProgramingCompetition.DAL.Models.Challenge", null)
                        .WithMany("TaskTypes")
                        .HasForeignKey("ChallengeId");
                });

            modelBuilder.Entity("ProgramingCompetition.DAL.Models.Challenge", b =>
                {
                    b.Navigation("TaskTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
