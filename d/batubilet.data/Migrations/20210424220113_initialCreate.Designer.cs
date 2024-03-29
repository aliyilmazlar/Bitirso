﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using batubilet.data.Concrete;

namespace batubilet.data.Migrations
{
    [DbContext(typeof(BiletContext))]
    [Migration("20210424220113_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("batubilet.entity.Bilet", b =>
                {
                    b.Property<int>("BiletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");

                    b.Property<double>("Fiyat")
                        .HasColumnType("REAL");

                    b.Property<int>("GuzergahId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KoltukNo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nereden")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nereye")
                        .HasColumnType("TEXT");

                    b.Property<string>("Soyad")
                        .HasColumnType("TEXT");

                    b.HasKey("BiletId");

                    b.HasIndex("GuzergahId");

                    b.ToTable("Bilets");
                });

            modelBuilder.Entity("batubilet.entity.Guzergah", b =>
                {
                    b.Property<int>("GuzergahId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Baslangic")
                        .HasColumnType("TEXT");

                    b.Property<string>("Bitis")
                        .HasColumnType("TEXT");

                    b.Property<double>("Fiyat")
                        .HasColumnType("REAL");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Saat")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tarih")
                        .HasColumnType("TEXT");

                    b.Property<string>("gz1")
                        .HasColumnType("TEXT");

                    b.Property<string>("gz2")
                        .HasColumnType("TEXT");

                    b.Property<string>("gz3")
                        .HasColumnType("TEXT");

                    b.HasKey("GuzergahId");

                    b.ToTable("Guzergahs");
                });

            modelBuilder.Entity("batubilet.entity.Sehir", b =>
                {
                    b.Property<int>("SehirId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SehirAd")
                        .HasColumnType("TEXT");

                    b.HasKey("SehirId");

                    b.ToTable("Sehirs");
                });

            modelBuilder.Entity("batubilet.entity.Bilet", b =>
                {
                    b.HasOne("batubilet.entity.Guzergah", "guzergah")
                        .WithMany("Bilets")
                        .HasForeignKey("GuzergahId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
