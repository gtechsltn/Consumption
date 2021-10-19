﻿// <auto-generated />
using System;
using Consumption.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Consumption.EFCore.Migrations
{
    [DbContext(typeof(ConsumptionContext))]
    [Migration("20211019162516_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Consumption.Shared.DataModel.AuthItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthKind")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AuthValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AuthItems");
                });

            modelBuilder.Entity("Consumption.Shared.DataModel.Basic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NativeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Basics");
                });

            modelBuilder.Entity("Consumption.Shared.DataModel.BasicType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BasicTypes");
                });

            modelBuilder.Entity("Consumption.Shared.DataModel.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Consumption.Shared.DataModel.GroupFunc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Auth")
                        .HasColumnType("int");

                    b.Property<string>("GroupCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GroupFuncs");
                });

            modelBuilder.Entity("Consumption.Shared.DataModel.GroupUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GroupUsers");
                });

            modelBuilder.Entity("Consumption.Shared.DataModel.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MenuAuth")
                        .HasColumnType("int");

                    b.Property<string>("MenuCaption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuNameSpace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Consumption.Shared.DataModel.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlagAdmin")
                        .HasColumnType("int");

                    b.Property<string>("FlagOnline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsLocked")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastLogouTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoginCounter")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Consumption.Shared.DataModel.UserConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ExpectedIn")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ExpectedOut")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("UserConfigs");
                });

            modelBuilder.Entity("Consumption.Shared.DataModel.UserLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
