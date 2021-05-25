using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCodeFirstSample.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsKioskContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kiosks",
                columns: table => new
                {
                    KioskId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KioskName = table.Column<string>(nullable: true),
                    LocationId = table.Column<long>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kiosks", x => x.KioskId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kiosks");
        }
    }
}
