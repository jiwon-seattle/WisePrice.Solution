﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WisePriceApi.Models;

namespace WisePriceApi.Migrations
{
    [DbContext(typeof(WisePriceApiContext))]
    partial class WisePriceApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WisePriceApi.Models.Deal", b =>
                {
                    b.Property<int>("DealId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DownVotes");

                    b.Property<int>("ItemId");

                    b.Property<int>("LocationId");

                    b.Property<int>("Price");

                    b.Property<DateTime>("TimeUpdated");

                    b.Property<int>("UpVotes");

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.Property<string>("UserId2");

                    b.HasKey("DealId");

                    b.HasIndex("ItemId");

                    b.HasIndex("LocationId");

                    b.HasIndex("UserId1");

                    b.HasIndex("UserId2");

                    b.ToTable("Deals");
                });

            modelBuilder.Entity("WisePriceApi.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemName");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("WisePriceApi.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<int>("ZipCode");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("WisePriceApi.Models.PinnedDeal", b =>
                {
                    b.Property<int>("PinnedDealId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DealId");

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("PinnedDealId");

                    b.HasIndex("DealId");

                    b.HasIndex("UserId1");

                    b.ToTable("PinnedDeals");
                });

            modelBuilder.Entity("WisePriceApi.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<int>("Password");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<int>("UserId");

                    b.Property<string>("UserName");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WisePriceApi.Models.Deal", b =>
                {
                    b.HasOne("WisePriceApi.Models.Item", "Item")
                        .WithMany("Deals")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WisePriceApi.Models.Location", "Location")
                        .WithMany("Deals")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WisePriceApi.Models.User")
                        .WithMany("PinnedDeals")
                        .HasForeignKey("UserId1");

                    b.HasOne("WisePriceApi.Models.User")
                        .WithMany("PostedDeals")
                        .HasForeignKey("UserId2");
                });

            modelBuilder.Entity("WisePriceApi.Models.PinnedDeal", b =>
                {
                    b.HasOne("WisePriceApi.Models.Deal", "Deal")
                        .WithMany()
                        .HasForeignKey("DealId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WisePriceApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });
#pragma warning restore 612, 618
        }
    }
}
