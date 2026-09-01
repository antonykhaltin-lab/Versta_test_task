using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Versta_test_project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    senderCity = table.Column<string>(type: "TEXT", nullable: false),
                    senderAddress = table.Column<string>(type: "TEXT", nullable: false),
                    recipientCity = table.Column<string>(type: "TEXT", nullable: false),
                    recipientAddress = table.Column<string>(type: "TEXT", nullable: false),
                    packageWeight = table.Column<double>(type: "REAL", nullable: true),
                    collectionDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
