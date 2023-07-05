﻿// <auto-generated />
using System;
using HastaTakip.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HastaTakip.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230705081201_ThirdMigration")]
    partial class ThirdMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HastaTakip.Models.Hasta", b =>
                {
                    b.Property<int>("hasta_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("hasta_id"));

                    b.Property<DateOnly>("dogum_tarihi")
                        .HasColumnType("date");

                    b.Property<string>("hasta_ad_soyad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("hasta_tc")
                        .HasColumnType("integer");

                    b.HasKey("hasta_id");

                    b.ToTable("hastalar");
                });

            modelBuilder.Entity("HastaTakip.Models.Ziyaret", b =>
                {
                    b.Property<int>("ziyaret_")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ziyaret_"));

                    b.Property<string>("doktor_adi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("hasta_id")
                        .HasColumnType("integer");

                    b.Property<string>("sikayet")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("tedavi_sekli")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ziyaret_tarihi")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ziyaret_");

                    b.HasIndex("hasta_id");

                    b.ToTable("ziyaretler");
                });

            modelBuilder.Entity("HastaTakip.Models.Ziyaret", b =>
                {
                    b.HasOne("HastaTakip.Models.Hasta", "Hasta")
                        .WithMany()
                        .HasForeignKey("hasta_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hasta");
                });
#pragma warning restore 612, 618
        }
    }
}
