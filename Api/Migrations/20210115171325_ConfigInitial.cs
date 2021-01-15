using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class ConfigInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoDeArticulo = table.Column<string>(maxLength: 6, nullable: false),
                    DescripcionDeArticulo = table.Column<string>(maxLength: 50, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conductores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Licencia = table.Column<string>(maxLength: 9, nullable: false),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Apellido1Conductor = table.Column<string>(maxLength: 20, nullable: false),
                    Apellido2Conductor = table.Column<string>(maxLength: 20, nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LugaresFinalesDelosRecorridos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoDeLugar = table.Column<string>(maxLength: 6, nullable: false),
                    NombreDeLugar = table.Column<string>(maxLength: 50, nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LugaresFinalesDelosRecorridos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Penalizaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPenalizacion = table.Column<string>(nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penalizaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Socios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoSocio = table.Column<string>(maxLength: 5, nullable: false),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Apellido1Socio = table.Column<string>(maxLength: 20, nullable: false),
                    Apellido2Socio = table.Column<string>(maxLength: 20, nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoDeTurno = table.Column<string>(maxLength: 4, nullable: false),
                    HoraDeSalida = table.Column<TimeSpan>(nullable: false),
                    HoraDeLlegada = table.Column<TimeSpan>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(maxLength: 15, nullable: false),
                    SocioId = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false),
                    SociosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Socios_SociosId",
                        column: x => x.SociosId,
                        principalTable: "Socios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoCarrera = table.Column<string>(nullable: false),
                    FechaDeCarrera = table.Column<DateTime>(nullable: false),
                    HoraRealDeLlegada = table.Column<TimeSpan>(nullable: false),
                    CarreraAnulada = table.Column<bool>(nullable: false),
                    MontoRecaudado = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Multa = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    VehiculoId = table.Column<int>(nullable: false),
                    ConductorId = table.Column<int>(nullable: false),
                    PenalizacionId = table.Column<int>(nullable: false),
                    TurnoId = table.Column<int>(nullable: false),
                    LugarFinalDeRecorridoId = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false),
                    ConductoresId = table.Column<int>(nullable: true),
                    LugaresFinalesDelosRecorridosId = table.Column<int>(nullable: true),
                    PenalizacionesId = table.Column<int>(nullable: true),
                    TurnosId = table.Column<int>(nullable: true),
                    VehiculosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carreras_Conductores_ConductoresId",
                        column: x => x.ConductoresId,
                        principalTable: "Conductores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carreras_LugaresFinalesDelosRecorridos_LugaresFinalesDelosRecorridosId",
                        column: x => x.LugaresFinalesDelosRecorridosId,
                        principalTable: "LugaresFinalesDelosRecorridos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carreras_Penalizaciones_PenalizacionesId",
                        column: x => x.PenalizacionesId,
                        principalTable: "Penalizaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carreras_Turnos_TurnosId",
                        column: x => x.TurnosId,
                        principalTable: "Turnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carreras_Vehiculos_VehiculosId",
                        column: x => x.VehiculosId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Creditos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoCredito = table.Column<string>(maxLength: 20, nullable: false),
                    FechaDeCredito = table.Column<DateTime>(nullable: false),
                    MontoTotal = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    EstadoDeCredito = table.Column<bool>(nullable: false),
                    CreditoAnulado = table.Column<bool>(nullable: false),
                    VehiculoId = table.Column<int>(nullable: false),
                    VehiculosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creditos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Creditos_Vehiculos_VehiculosId",
                        column: x => x.VehiculosId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Abonos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaDeAbono = table.Column<DateTime>(nullable: false),
                    CodigoAbono = table.Column<string>(maxLength: 25, nullable: false),
                    MontoDeAbono = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    CreditoId = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false),
                    CreditosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abonos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abonos_Creditos_CreditosId",
                        column: x => x.CreditosId,
                        principalTable: "Creditos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesDeCreditos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(nullable: false),
                    CreditoId = table.Column<int>(nullable: false),
                    ArticuloId = table.Column<int>(nullable: false),
                    ArticulosId = table.Column<int>(nullable: true),
                    CreditosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesDeCreditos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesDeCreditos_Articulos_ArticulosId",
                        column: x => x.ArticulosId,
                        principalTable: "Articulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesDeCreditos_Creditos_CreditosId",
                        column: x => x.CreditosId,
                        principalTable: "Creditos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abonos_CreditosId",
                table: "Abonos",
                column: "CreditosId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_ConductoresId",
                table: "Carreras",
                column: "ConductoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_LugaresFinalesDelosRecorridosId",
                table: "Carreras",
                column: "LugaresFinalesDelosRecorridosId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_PenalizacionesId",
                table: "Carreras",
                column: "PenalizacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_TurnosId",
                table: "Carreras",
                column: "TurnosId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_VehiculosId",
                table: "Carreras",
                column: "VehiculosId");

            migrationBuilder.CreateIndex(
                name: "IX_Creditos_VehiculosId",
                table: "Creditos",
                column: "VehiculosId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDeCreditos_ArticulosId",
                table: "DetallesDeCreditos",
                column: "ArticulosId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDeCreditos_CreditosId",
                table: "DetallesDeCreditos",
                column: "CreditosId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_SociosId",
                table: "Vehiculos",
                column: "SociosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abonos");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "DetallesDeCreditos");

            migrationBuilder.DropTable(
                name: "Conductores");

            migrationBuilder.DropTable(
                name: "LugaresFinalesDelosRecorridos");

            migrationBuilder.DropTable(
                name: "Penalizaciones");

            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.DropTable(
                name: "Creditos");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Socios");
        }
    }
}
