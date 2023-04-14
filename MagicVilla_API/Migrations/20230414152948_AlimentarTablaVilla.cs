﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrado", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa", new DateTime(2023, 4, 14, 12, 29, 48, 193, DateTimeKind.Local).AddTicks(9238), new DateTime(2023, 4, 14, 12, 29, 48, 193, DateTimeKind.Local).AddTicks(9221), "", 20, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la Villa2", new DateTime(2023, 4, 14, 12, 29, 48, 193, DateTimeKind.Local).AddTicks(9242), new DateTime(2023, 4, 14, 12, 29, 48, 193, DateTimeKind.Local).AddTicks(9241), "", 40, "Villa Real2", 4, 500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
