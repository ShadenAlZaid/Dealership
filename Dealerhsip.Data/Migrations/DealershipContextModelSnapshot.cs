﻿// <auto-generated />
using Dealership.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dealership.Data.Migrations
{
    [DbContext(typeof(DealershipContext))]
    partial class DealershipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DealershipLibrary.Vehicle.Cars.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("VehicleColorId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleModelId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.HasIndex("VehicleColorId");

                    b.HasIndex("VehicleModelId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("DealershipLibrary.Vehicle.Motorcycles.Motorcycle", b =>
                {
                    b.Property<int>("MotorcycleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("VehicleColorId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleModelId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("MotorcycleId");

                    b.HasIndex("VehicleColorId");

                    b.HasIndex("VehicleModelId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Motorcycles");
                });

            modelBuilder.Entity("DealershipLibrary.Vehicle.Trucks.Truck", b =>
                {
                    b.Property<int>("TruckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("VehicleColorId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleModelId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("TruckId");

                    b.HasIndex("VehicleColorId");

                    b.HasIndex("VehicleModelId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("DealershipLibrary.Vehicle.VehicleColor", b =>
                {
                    b.Property<int>("VehicleColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleColorId");

                    b.ToTable("VehicleColors");

                    b.HasData(
                        new
                        {
                            VehicleColorId = 1,
                            Name = "Black"
                        },
                        new
                        {
                            VehicleColorId = 2,
                            Name = "White"
                        },
                        new
                        {
                            VehicleColorId = 3,
                            Name = "Red"
                        },
                        new
                        {
                            VehicleColorId = 4,
                            Name = "Blue"
                        },
                        new
                        {
                            VehicleColorId = 5,
                            Name = "Silver"
                        });
                });

            modelBuilder.Entity("DealershipLibrary.Vehicle.VehicleModel", b =>
                {
                    b.Property<int>("VehicleModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("VehicleModelId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("VehicleModels");

                    b.HasData(
                        new
                        {
                            VehicleModelId = 1,
                            Name = "Taurus",
                            VehicleTypeId = 0
                        },
                        new
                        {
                            VehicleModelId = 2,
                            Name = "Explorer",
                            VehicleTypeId = 0
                        },
                        new
                        {
                            VehicleModelId = 3,
                            Name = "Expedition",
                            VehicleTypeId = 0
                        },
                        new
                        {
                            VehicleModelId = 4,
                            Name = "Valkryie",
                            VehicleTypeId = 0
                        },
                        new
                        {
                            VehicleModelId = 5,
                            Name = "GoldWing",
                            VehicleTypeId = 0
                        },
                        new
                        {
                            VehicleModelId = 6,
                            Name = "Hurricane",
                            VehicleTypeId = 0
                        },
                        new
                        {
                            VehicleModelId = 7,
                            Name = "Silverado",
                            VehicleTypeId = 0
                        },
                        new
                        {
                            VehicleModelId = 8,
                            Name = "Tornado",
                            VehicleTypeId = 0
                        },
                        new
                        {
                            VehicleModelId = 9,
                            Name = "Ranger",
                            VehicleTypeId = 0
                        });
                });

            modelBuilder.Entity("DealershipLibrary.Vehicle.VehicleType", b =>
                {
                    b.Property<int>("VehicleTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleTypeId");

                    b.ToTable("VehicleTypes");

                    b.HasData(
                        new
                        {
                            VehicleTypeId = 1,
                            Name = "Car"
                        },
                        new
                        {
                            VehicleTypeId = 2,
                            Name = "Motorcycle"
                        },
                        new
                        {
                            VehicleTypeId = 3,
                            Name = "Truck"
                        });
                });

            modelBuilder.Entity("DealershipLibrary.Vehicle.Cars.Car", b =>
                {
                    b.HasOne("DealershipLibrary.Vehicle.VehicleColor", "VehicleColor")
                        .WithMany()
                        .HasForeignKey("VehicleColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealershipLibrary.Vehicle.VehicleModel", "VehicleModel")
                        .WithMany()
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealershipLibrary.Vehicle.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleColor");

                    b.Navigation("VehicleModel");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("DealershipLibrary.Vehicle.Motorcycles.Motorcycle", b =>
                {
                    b.HasOne("DealershipLibrary.Vehicle.VehicleColor", "VehicleColor")
                        .WithMany()
                        .HasForeignKey("VehicleColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealershipLibrary.Vehicle.VehicleModel", "VehicleModel")
                        .WithMany()
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealershipLibrary.Vehicle.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleColor");

                    b.Navigation("VehicleModel");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("DealershipLibrary.Vehicle.Trucks.Truck", b =>
                {
                    b.HasOne("DealershipLibrary.Vehicle.VehicleColor", "VehicleColor")
                        .WithMany()
                        .HasForeignKey("VehicleColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealershipLibrary.Vehicle.VehicleModel", "VehicleModel")
                        .WithMany()
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealershipLibrary.Vehicle.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleColor");

                    b.Navigation("VehicleModel");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("DealershipLibrary.Vehicle.VehicleModel", b =>
                {
                    b.HasOne("DealershipLibrary.Vehicle.VehicleType", "VehicleType")
                        .WithMany("VehicleModels")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("DealershipLibrary.Vehicle.VehicleType", b =>
                {
                    b.Navigation("VehicleModels");
                });
#pragma warning restore 612, 618
        }
    }
}
