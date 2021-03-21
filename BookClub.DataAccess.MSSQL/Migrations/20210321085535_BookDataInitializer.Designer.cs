﻿// <auto-generated />
using BookClub.DataAccess.MSSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookClub.DataAccess.MSSQL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210321085535_BookDataInitializer")]
    partial class BookDataInitializer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BookClub.Domain.Models.Book", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = "4ab73c18-ef9d-4642-89be-986a7a2e8b4f",
                            Author = "Александр Грин",
                            Name = "Алые паруса"
                        },
                        new
                        {
                            Id = "ccfcb146-797d-4f34-8947-526ea848aa70",
                            Author = "Стивен Кинг",
                            Name = "11/22/63"
                        },
                        new
                        {
                            Id = "2994537b-3283-45d8-bbb1-596e97c3ea8e",
                            Author = "Аркадий Стругацкий и др.",
                            Name = "Пикник на обочине"
                        },
                        new
                        {
                            Id = "717fbd01-5149-46d0-8edc-ed579792812a",
                            Author = "Айн Рэнд",
                            Name = "Источник"
                        },
                        new
                        {
                            Id = "85c0d171-b147-46cf-90bc-9214003c31d2",
                            Author = "О` Генри",
                            Name = "Дары волхвов"
                        },
                        new
                        {
                            Id = "090198a5-85ea-4931-945c-22c667497689",
                            Author = "Иоганн Вольфганг Гете",
                            Name = "Фауст"
                        },
                        new
                        {
                            Id = "b8fc6973-cc94-4943-8e73-4a661eaf5baf",
                            Author = "Виктор Гюго",
                            Name = "Отверженные"
                        },
                        new
                        {
                            Id = "374cf051-c3f9-49ce-b4dc-e84b7146a605",
                            Author = "Артур Конан Дойл",
                            Name = "Собака Баскервилей"
                        });
                });

            modelBuilder.Entity("BookClub.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookUser", b =>
                {
                    b.Property<string>("ReadBooksId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UsersWhoReadBookId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ReadBooksId", "UsersWhoReadBookId");

                    b.HasIndex("UsersWhoReadBookId");

                    b.ToTable("ReadBooks");
                });

            modelBuilder.Entity("BookUser", b =>
                {
                    b.HasOne("BookClub.Domain.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("ReadBooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookClub.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersWhoReadBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}