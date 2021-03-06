// <auto-generated />
using System;
using EFCOREPRACTICE.SamuraiApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCOREPRACTICE.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    partial class SamuraiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Battles");
                });

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

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.Horse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("SamuraiId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId")
                        .IsUnique();

                    b.ToTable("Horse");
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

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.SamuraiBattle", b =>
                {
                    b.Property<int>("BattleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SamuraiId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BattleId", "SamuraiId");

                    b.HasIndex("SamuraiId");

                    b.ToTable("SamuraiBattle");
                });

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.Horse", b =>
                {
                    b.HasOne("EFCOREPRACTICE.SamuraiApp.Domain.Samurai", "Samurai")
                        .WithOne("Horse")
                        .HasForeignKey("EFCOREPRACTICE.SamuraiApp.Domain.Horse", "SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Samurai");
                });

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.Quote", b =>
                {
                    b.HasOne("EFCOREPRACTICE.SamuraiApp.Domain.Samurai", "Samurai")
                        .WithMany("Quotes")
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

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.SamuraiBattle", b =>
                {
                    b.HasOne("EFCOREPRACTICE.SamuraiApp.Domain.Battle", "Battle")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCOREPRACTICE.SamuraiApp.Domain.Samurai", "Samurai")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Battle");

                    b.Navigation("Samurai");
                });

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.Battle", b =>
                {
                    b.Navigation("SamuraiBattles");
                });

            modelBuilder.Entity("EFCOREPRACTICE.SamuraiApp.Domain.Samurai", b =>
                {
                    b.Navigation("Horse");

                    b.Navigation("Quotes");

                    b.Navigation("SamuraiBattles");
                });
#pragma warning restore 612, 618
        }
    }
}
