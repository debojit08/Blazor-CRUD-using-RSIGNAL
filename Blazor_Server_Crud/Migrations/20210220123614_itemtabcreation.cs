using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor_Server_Crud.Migrations
{
    public partial class itemtabcreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "itemDetailTable",
                columns: table => new
                {
                    itemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    itemRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    mDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    eDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemDetailTable", x => x.itemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itemDetailTable");

            migrationBuilder.CreateTable(
                name: "itemTable",
                columns: table => new
                {
                    itemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    itemRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    mDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemTable", x => x.itemId);
                });
        }
    }
}
