﻿// <auto-generated />
using System;
using EFCOREPRACTICE.SamuraiApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCOREPRACTICE.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    [Migration("20210922092439_init1")]
    partial class init1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.Clan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClanName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clans");
                });

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SamuraiId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClanId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClanId");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.Quote", b =>
                {
                    b.HasOne("EFCOREPRACTICE.SamuraiApp.Domain.Samurai", "Samurai")
                        .WithMany()
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Samurai");
                });

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.Samurai", b =>
                {
                    b.HasOne("EFCOREPRACTICE.SamuraiApp.Domain.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId");

                    b.Navigation("Clan");
                });
#pragma warning restore 612, 618
        }
    }
}
