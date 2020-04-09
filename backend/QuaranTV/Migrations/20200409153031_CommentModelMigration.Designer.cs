﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuaranTV;

namespace QuaranTV.Migrations
{
    [DbContext(typeof(QuaranTvContext))]
    [Migration("20200409153031_CommentModelMigration")]
    partial class CommentModelMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuaranTV.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("QuaranTV.Models.TvShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Season")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViewerDiscretion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TvShows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "friends.jpg",
                            Season = "10",
                            Title = "Friends",
                            ViewerDiscretion = "TV-14"
                        },
                        new
                        {
                            Id = 2,
                            Image = "gameofthrones.jpg",
                            Season = "8",
                            Title = "Game of Thrones",
                            ViewerDiscretion = "TV-MA"
                        },
                        new
                        {
                            Id = 3,
                            Image = "maisel.jpg",
                            Season = "4",
                            Title = "The Marvelous Mrs. Maisel",
                            ViewerDiscretion = "TV-MA"
                        },
                        new
                        {
                            Id = 4,
                            Image = "ozark.jpg",
                            Season = "3",
                            Title = "Ozark",
                            ViewerDiscretion = "TV-MA"
                        },
                        new
                        {
                            Id = 5,
                            Image = "freshprince.jpg",
                            Season = "6",
                            Title = "The Fresh Prince",
                            ViewerDiscretion = "TV-PG"
                        },
                        new
                        {
                            Id = 6,
                            Image = "goldengirls.jpg",
                            Season = "7",
                            Title = "The Golden Girls",
                            ViewerDiscretion = "TV-PG"
                        },
                        new
                        {
                            Id = 7,
                            Image = "tigerking.jpg",
                            Season = "1",
                            Title = "Tiger King",
                            ViewerDiscretion = "TV-MA"
                        },
                        new
                        {
                            Id = 8,
                            Image = "strangerthings.jpg",
                            Season = "4",
                            Title = "Stranger Things",
                            ViewerDiscretion = "TV-14"
                        },
                        new
                        {
                            Id = 9,
                            Image = "dearwhitepeople.jpg",
                            Season = "4",
                            Title = "Dear White People",
                            ViewerDiscretion = "TV-MA"
                        },
                        new
                        {
                            Id = 10,
                            Image = "mandalorian.jpg",
                            Season = "1",
                            Title = "The Mandalorian",
                            ViewerDiscretion = "TV-PG"
                        },
                        new
                        {
                            Id = 11,
                            Image = "atlanta.jpg",
                            Season = "3",
                            Title = "Atlanta",
                            ViewerDiscretion = "TV-MA"
                        },
                        new
                        {
                            Id = 12,
                            Image = "alteredcarbon.jpg",
                            Season = "2",
                            Title = "Altered Carbon",
                            ViewerDiscretion = "TV-MA"
                        },
                        new
                        {
                            Id = 13,
                            Image = "theamazingrace.jpg",
                            Season = "32",
                            Title = "The Amazing Race",
                            ViewerDiscretion = "TV-PG"
                        },
                        new
                        {
                            Id = 14,
                            Image = "daredevil.jpg",
                            Season = "3",
                            Title = "Daredevil",
                            ViewerDiscretion = "TV-MA"
                        },
                        new
                        {
                            Id = 15,
                            Image = "thewitcher.jpg",
                            Season = "1",
                            Title = "The Witcher",
                            ViewerDiscretion = "TV-MA"
                        });
                });

            modelBuilder.Entity("QuaranTV.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "dan.jpg",
                            Name = "Dan"
                        },
                        new
                        {
                            Id = 2,
                            Image = "nabil.jpg",
                            Name = "Nabil"
                        },
                        new
                        {
                            Id = 3,
                            Image = "tatyana.jpg",
                            Name = "Tatyana"
                        },
                        new
                        {
                            Id = 4,
                            Image = "erin.jpg",
                            Name = "Erin"
                        },
                        new
                        {
                            Id = 5,
                            Image = "eric.jpg",
                            Name = "Eric"
                        },
                        new
                        {
                            Id = 6,
                            Image = "ghassan.jpg",
                            Name = "Ghassan"
                        },
                        new
                        {
                            Id = 7,
                            Image = "karlyn.jpg",
                            Name = "Karlyn"
                        },
                        new
                        {
                            Id = 8,
                            Image = "carlton.jpg",
                            Name = "Carlton"
                        });
                });

            modelBuilder.Entity("QuaranTV.Models.Watchlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TvShowId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TvShowId");

                    b.HasIndex("UserId");

                    b.ToTable("Watchlists");
                });

            modelBuilder.Entity("QuaranTV.Models.Comment", b =>
                {
                    b.HasOne("QuaranTV.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuaranTV.Models.Watchlist", b =>
                {
                    b.HasOne("QuaranTV.Models.TvShow", "TvShow")
                        .WithMany("Watchlists")
                        .HasForeignKey("TvShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuaranTV.Models.User", "User")
                        .WithMany("Watchlists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
