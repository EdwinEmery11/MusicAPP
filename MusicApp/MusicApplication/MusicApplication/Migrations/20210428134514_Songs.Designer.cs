﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicApplicationWebLibrary.Data;

namespace MusicApplication.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210428134514_Songs")]
    partial class Songs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MusicApplication.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Information")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PictureURL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Tracks")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("MusicApplication.Models.Songs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AlbumID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Information")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PictureURL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Song")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Tracks")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AlbumID");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("MusicApplication.Models.Songs", b =>
                {
                    b.HasOne("MusicApplication.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumID");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MusicApplication.Models.Album", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
