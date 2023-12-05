using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServer.AdaptorPatternExample.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fruits",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Description", "ExternalId", "Family", "Fat", "Genus", "Name", "Order", "Protein", "RquestedDate", "Sugar" },
                values: new object[] { 1, 96.0, 22.0, "Banana", 2, "Musaceae", 0.20000000000000001, "Musa", "Banana", "Zingiberales", 0.0, new DateTime(2023, 12, 4, 13, 12, 24, 746, DateTimeKind.Local).AddTicks(4253), 17.199999999999999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fruits",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
