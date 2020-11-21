using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RefreshToken_Vaqueiro.Migrations
{
    public partial class WebApplicationModelsUserContext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LoginModels",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.InsertData(
                table: "LoginModels",
                columns: new[] { "Id", "Password", "RefreshToken", "RefreshTokenExpiryTime", "UserName" },
                values: new object[] { 2L, "ignacio123", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ignacio@hotmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LoginModels",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.InsertData(
                table: "LoginModels",
                columns: new[] { "Id", "Password", "RefreshToken", "RefreshTokenExpiryTime", "UserName" },
                values: new object[] { 1L, "ignacio123", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ignacio" });
        }
    }
}
