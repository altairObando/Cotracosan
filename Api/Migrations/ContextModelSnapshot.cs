﻿// <auto-generated />
using System;
using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api.Models.Abonos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoAbono")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<int>("CreditoId")
                        .HasColumnType("int");

                    b.Property<int?>("CreditosId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaDeAbono")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MontoDeAbono")
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("Id");

                    b.HasIndex("CreditosId");

                    b.ToTable("Abonos");
                });

            modelBuilder.Entity("Api.Models.Articulos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoDeArticulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("DescripcionDeArticulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("Id");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("Api.Models.Carreras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CarreraAnulada")
                        .HasColumnType("bit");

                    b.Property<string>("CodigoCarrera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConductorId")
                        .HasColumnType("int");

                    b.Property<int?>("ConductoresId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaDeCarrera")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("HoraRealDeLlegada")
                        .HasColumnType("time");

                    b.Property<int>("LugarFinalDeRecorridoId")
                        .HasColumnType("int");

                    b.Property<int?>("LugaresFinalesDelosRecorridosId")
                        .HasColumnType("int");

                    b.Property<decimal>("MontoRecaudado")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("Multa")
                        .HasColumnType("decimal(16,2)");

                    b.Property<int>("PenalizacionId")
                        .HasColumnType("int");

                    b.Property<int?>("PenalizacionesId")
                        .HasColumnType("int");

                    b.Property<int>("TurnoId")
                        .HasColumnType("int");

                    b.Property<int?>("TurnosId")
                        .HasColumnType("int");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.Property<int?>("VehiculosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConductoresId");

                    b.HasIndex("LugaresFinalesDelosRecorridosId");

                    b.HasIndex("PenalizacionesId");

                    b.HasIndex("TurnosId");

                    b.HasIndex("VehiculosId");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("Api.Models.Conductores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido1Conductor")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Apellido2Conductor")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Licencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Conductores");
                });

            modelBuilder.Entity("Api.Models.Creditos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoCredito")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("CreditoAnulado")
                        .HasColumnType("bit");

                    b.Property<bool>("EstadoDeCredito")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaDeCredito")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MontoTotal")
                        .HasColumnType("decimal(16,2)");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.Property<int?>("VehiculosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehiculosId");

                    b.ToTable("Creditos");
                });

            modelBuilder.Entity("Api.Models.DetallesDeCreditos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int?>("ArticulosId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CreditoId")
                        .HasColumnType("int");

                    b.Property<int?>("CreditosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticulosId");

                    b.HasIndex("CreditosId");

                    b.ToTable("DetallesDeCreditos");
                });

            modelBuilder.Entity("Api.Models.LugaresFinalesDelosRecorridos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoDeLugar")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("NombreDeLugar")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("LugaresFinalesDelosRecorridos");
                });

            modelBuilder.Entity("Api.Models.Penalizaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(16,2)");

                    b.Property<string>("CodigoPenalizacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Penalizaciones");
                });

            modelBuilder.Entity("Api.Models.Socios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido1Socio")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Apellido2Socio")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CodigoSocio")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Socios");
                });

            modelBuilder.Entity("Api.Models.Turnos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoDeTurno")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("HoraDeLlegada")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraDeSalida")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Turnos");
                });

            modelBuilder.Entity("Api.Models.Vehiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("SocioId")
                        .HasColumnType("int");

                    b.Property<int?>("SociosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SociosId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Api.Models.Abonos", b =>
                {
                    b.HasOne("Api.Models.Creditos", "Creditos")
                        .WithMany("Abonos")
                        .HasForeignKey("CreditosId");
                });

            modelBuilder.Entity("Api.Models.Carreras", b =>
                {
                    b.HasOne("Api.Models.Conductores", "Conductores")
                        .WithMany("Carreras")
                        .HasForeignKey("ConductoresId");

                    b.HasOne("Api.Models.LugaresFinalesDelosRecorridos", "LugaresFinalesDelosRecorridos")
                        .WithMany("Carreras")
                        .HasForeignKey("LugaresFinalesDelosRecorridosId");

                    b.HasOne("Api.Models.Penalizaciones", "Penalizaciones")
                        .WithMany("Carreras")
                        .HasForeignKey("PenalizacionesId");

                    b.HasOne("Api.Models.Turnos", "Turnos")
                        .WithMany("Carreras")
                        .HasForeignKey("TurnosId");

                    b.HasOne("Api.Models.Vehiculos", "Vehiculos")
                        .WithMany("Carreras")
                        .HasForeignKey("VehiculosId");
                });

            modelBuilder.Entity("Api.Models.Creditos", b =>
                {
                    b.HasOne("Api.Models.Vehiculos", "Vehiculos")
                        .WithMany("Creditos")
                        .HasForeignKey("VehiculosId");
                });

            modelBuilder.Entity("Api.Models.DetallesDeCreditos", b =>
                {
                    b.HasOne("Api.Models.Articulos", "Articulos")
                        .WithMany("DetallesDeCreditos")
                        .HasForeignKey("ArticulosId");

                    b.HasOne("Api.Models.Creditos", "Creditos")
                        .WithMany("DetallesDeCreditos")
                        .HasForeignKey("CreditosId");
                });

            modelBuilder.Entity("Api.Models.Vehiculos", b =>
                {
                    b.HasOne("Api.Models.Socios", "Socios")
                        .WithMany("Vehiculos")
                        .HasForeignKey("SociosId");
                });
#pragma warning restore 612, 618
        }
    }
}
