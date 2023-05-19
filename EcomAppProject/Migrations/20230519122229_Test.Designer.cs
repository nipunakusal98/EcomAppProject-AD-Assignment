﻿// <auto-generated />
using System;
using EcomApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcomAppProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230519122229_Test")]
    partial class Test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcomAppProject.Models.AntivirusSoftware", b =>
                {
                    b.Property<int>("AntivirusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AntivirusID"));

                    b.Property<string>("AntivirusDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AntivirusPrice")
                        .HasColumnType("int");

                    b.HasKey("AntivirusID");

                    b.ToTable("AntivirusSoftwares");
                });

            modelBuilder.Entity("EcomAppProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EcomAppProject.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EcomAppProject.Models.CustomerConfiguration", b =>
                {
                    b.Property<int>("CustomerConfigID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerConfigID"));

                    b.Property<int>("AntivirusID")
                        .HasColumnType("int");

                    b.Property<int>("ConfigurationPrice")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("MemoryID")
                        .HasColumnType("int");

                    b.Property<int>("ModelID")
                        .HasColumnType("int");

                    b.Property<int>("ProcessorID")
                        .HasColumnType("int");

                    b.Property<int>("VGAID")
                        .HasColumnType("int");

                    b.HasKey("CustomerConfigID");

                    b.HasIndex("AntivirusID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("MemoryID");

                    b.HasIndex("ModelID");

                    b.HasIndex("ProcessorID");

                    b.HasIndex("VGAID");

                    b.ToTable("CustomerConfigurations");
                });

            modelBuilder.Entity("EcomAppProject.Models.CustomerConfiguredModelOrder", b =>
                {
                    b.Property<int>("CustomerConfiguredModelOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerConfiguredModelOrderID"));

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConfigurationPrice")
                        .HasColumnType("int");

                    b.Property<int>("CustomerConfigID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShippingMethod")
                        .HasColumnType("int");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.HasKey("CustomerConfiguredModelOrderID");

                    b.HasIndex("CustomerConfigID");

                    b.ToTable("CustomerConfiguredModelOrders");
                });

            modelBuilder.Entity("EcomAppProject.Models.CustomerConfiguredModelPayment", b =>
                {
                    b.Property<int>("CustomerConfiguredModelPaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerConfiguredModelPaymentID"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CustomerConfiguredModelOrderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.HasKey("CustomerConfiguredModelPaymentID");

                    b.HasIndex("CustomerConfiguredModelOrderID");

                    b.ToTable("CustomerConfiguredModelPayments");
                });

            modelBuilder.Entity("EcomAppProject.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("EmployeeEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeePassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeType")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EcomAppProject.Models.Memory", b =>
                {
                    b.Property<int>("MemoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemoryID"));

                    b.Property<string>("MemoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemoryPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemoryPrice")
                        .HasColumnType("int");

                    b.HasKey("MemoryID");

                    b.ToTable("Memories");
                });

            modelBuilder.Entity("EcomAppProject.Models.Model", b =>
                {
                    b.Property<int>("ModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModelID"));

                    b.Property<string>("DefaultAntivirus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DefaultModelPrice")
                        .HasColumnType("int");

                    b.Property<string>("DefaultOS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefaultProcessor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefaultRAM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefaultVGA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesID")
                        .HasColumnType("int");

                    b.HasKey("ModelID");

                    b.HasIndex("SeriesID");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("EcomAppProject.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("ModelID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShippingMethod")
                        .HasColumnType("int");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ModelID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EcomAppProject.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.HasIndex("OrderID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("EcomAppProject.Models.Processor", b =>
                {
                    b.Property<int>("ProcessorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProcessorID"));

                    b.Property<string>("ProcessorDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessorPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessorPrice")
                        .HasColumnType("int");

                    b.HasKey("ProcessorID");

                    b.ToTable("Processors");
                });

            modelBuilder.Entity("EcomAppProject.Models.Series", b =>
                {
                    b.Property<int>("SeriesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeriesID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("SeriesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeriesPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeriesID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("EcomAppProject.Models.VGA", b =>
                {
                    b.Property<int>("VGAID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VGAID"));

                    b.Property<string>("VGADescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VGAPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VGAPrice")
                        .HasColumnType("int");

                    b.HasKey("VGAID");

                    b.ToTable("VGAs");
                });

            modelBuilder.Entity("EcomAppProject.Models.CustomerConfiguration", b =>
                {
                    b.HasOne("EcomAppProject.Models.AntivirusSoftware", "Antivirus")
                        .WithMany("CustomerConfigurations")
                        .HasForeignKey("AntivirusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcomAppProject.Models.Customer", "Customer")
                        .WithMany("CustomerConfigurations")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcomAppProject.Models.Memory", "Memory")
                        .WithMany("CustomerConfigurations")
                        .HasForeignKey("MemoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcomAppProject.Models.Model", "Model")
                        .WithMany("CustomerConfigurations")
                        .HasForeignKey("ModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcomAppProject.Models.Processor", "Processor")
                        .WithMany("CustomerConfigurations")
                        .HasForeignKey("ProcessorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcomAppProject.Models.VGA", "VGA")
                        .WithMany("CustomerConfigurations")
                        .HasForeignKey("VGAID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Antivirus");

                    b.Navigation("Customer");

                    b.Navigation("Memory");

                    b.Navigation("Model");

                    b.Navigation("Processor");

                    b.Navigation("VGA");
                });

            modelBuilder.Entity("EcomAppProject.Models.CustomerConfiguredModelOrder", b =>
                {
                    b.HasOne("EcomAppProject.Models.CustomerConfiguration", "CustomerConfiguration")
                        .WithMany()
                        .HasForeignKey("CustomerConfigID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerConfiguration");
                });

            modelBuilder.Entity("EcomAppProject.Models.CustomerConfiguredModelPayment", b =>
                {
                    b.HasOne("EcomAppProject.Models.CustomerConfiguredModelOrder", "CustomerConfiguredModelOrder")
                        .WithMany("CustomerConfiguredModelPayment")
                        .HasForeignKey("CustomerConfiguredModelOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerConfiguredModelOrder");
                });

            modelBuilder.Entity("EcomAppProject.Models.Model", b =>
                {
                    b.HasOne("EcomAppProject.Models.Series", "Series")
                        .WithMany("Models")
                        .HasForeignKey("SeriesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Series");
                });

            modelBuilder.Entity("EcomAppProject.Models.Order", b =>
                {
                    b.HasOne("EcomAppProject.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EcomAppProject.Models.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("EcomAppProject.Models.Payment", b =>
                {
                    b.HasOne("EcomAppProject.Models.Order", "Order")
                        .WithMany("Payments")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("EcomAppProject.Models.Series", b =>
                {
                    b.HasOne("EcomAppProject.Models.Category", "Category")
                        .WithMany("Series")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EcomAppProject.Models.AntivirusSoftware", b =>
                {
                    b.Navigation("CustomerConfigurations");
                });

            modelBuilder.Entity("EcomAppProject.Models.Category", b =>
                {
                    b.Navigation("Series");
                });

            modelBuilder.Entity("EcomAppProject.Models.Customer", b =>
                {
                    b.Navigation("CustomerConfigurations");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("EcomAppProject.Models.CustomerConfiguredModelOrder", b =>
                {
                    b.Navigation("CustomerConfiguredModelPayment");
                });

            modelBuilder.Entity("EcomAppProject.Models.Memory", b =>
                {
                    b.Navigation("CustomerConfigurations");
                });

            modelBuilder.Entity("EcomAppProject.Models.Model", b =>
                {
                    b.Navigation("CustomerConfigurations");
                });

            modelBuilder.Entity("EcomAppProject.Models.Order", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("EcomAppProject.Models.Processor", b =>
                {
                    b.Navigation("CustomerConfigurations");
                });

            modelBuilder.Entity("EcomAppProject.Models.Series", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("EcomAppProject.Models.VGA", b =>
                {
                    b.Navigation("CustomerConfigurations");
                });
#pragma warning restore 612, 618
        }
    }
}
