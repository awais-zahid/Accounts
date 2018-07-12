﻿// <auto-generated />
using System;
using AccountApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountApi.Migrations
{
    [DbContext(typeof(AccountsDbContext))]
    partial class AccountsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccountApi.Models.User", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("AccountId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}