using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea9_10.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sexo = table.Column<string>(type: "TEXT", nullable: true),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha_Nacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Pais_Nacimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Ciudad_Nacimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Pais_Actual = table.Column<string>(type: "TEXT", nullable: true),
                    Ciudad_Actual = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Celular = table.Column<string>(type: "TEXT", nullable: true),
                    Correo_Electronico = table.Column<string>(type: "TEXT", nullable: true),
                    Documento_Identidad = table.Column<string>(type: "TEXT", nullable: true),
                    Numero_Identidad = table.Column<string>(type: "TEXT", nullable: true),
                    Foto = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "DatosCivileses",
                columns: table => new
                {
                    DatosCivilesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Estado_Civil = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre_Pareja = table.Column<string>(type: "TEXT", nullable: true),
                    Tienes_Hijos = table.Column<string>(type: "TEXT", nullable: true),
                    Cantidad_Hijos = table.Column<int>(type: "INTEGER", nullable: false),
                    Nivel_Estudio = table.Column<string>(type: "TEXT", nullable: true),
                    Suspension_institucion = table.Column<string>(type: "TEXT", nullable: true),
                    Razon_Suspension = table.Column<string>(type: "TEXT", nullable: true),
                    Profesion = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre_Empresa = table.Column<string>(type: "TEXT", nullable: true),
                    Ocupacion_Actual = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono_Trabajo = table.Column<string>(type: "TEXT", nullable: true),
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosCivileses", x => x.DatosCivilesId);
                    table.ForeignKey(
                        name: "FK_DatosCivileses_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatosEclesiasticoses",
                columns: table => new
                {
                    DatosEclesiasticosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha_Conversion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fecha_Bautismo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fecha_Aceptado = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Denominacion = table.Column<string>(type: "TEXT", nullable: true),
                    Iglesia_Actual = table.Column<string>(type: "TEXT", nullable: true),
                    Iglesia_Antes = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre_Pastor = table.Column<string>(type: "TEXT", nullable: true),
                    Ha_Disiciplinado = table.Column<string>(type: "TEXT", nullable: true),
                    Cantidad_Disciplinado = table.Column<int>(type: "INTEGER", nullable: false),
                    Causas_Disciplinado = table.Column<string>(type: "TEXT", nullable: true),
                    Ministerios_Servido = table.Column<string>(type: "TEXT", nullable: true),
                    Ministerio_Fruto = table.Column<string>(type: "TEXT", nullable: true),
                    Razon_Fruto = table.Column<string>(type: "TEXT", nullable: true),
                    Ministerio_Llamando = table.Column<string>(type: "TEXT", nullable: true),
                    Meta = table.Column<string>(type: "TEXT", nullable: true),
                    Estas_Consciente = table.Column<string>(type: "TEXT", nullable: true),
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosEclesiasticoses", x => x.DatosEclesiasticosId);
                    table.ForeignKey(
                        name: "FK_DatosEclesiasticoses_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocupaciones",
                columns: table => new
                {
                    OcupacionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocupaciones", x => x.OcupacionId);
                    table.ForeignKey(
                        name: "FK_Ocupaciones_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre_Usuario = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatosCivileses_PersonaId",
                table: "DatosCivileses",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DatosEclesiasticoses_PersonaId",
                table: "DatosEclesiasticoses",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ocupaciones_PersonaId",
                table: "Ocupaciones",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PersonaId",
                table: "Usuarios",
                column: "PersonaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatosCivileses");

            migrationBuilder.DropTable(
                name: "DatosEclesiasticoses");

            migrationBuilder.DropTable(
                name: "Ocupaciones");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
