using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Armorsmith.Api.Migrations
{
    /// <inheritdoc />
    public partial class Armor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Set = table.Column<int>(type: "int", nullable: false),
                    Slot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Defense",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefensePoints = table.Column<int>(type: "int", nullable: false),
                    ArmorName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Defense_Armors_ArmorName",
                        column: x => x.ArmorName,
                        principalTable: "Armors",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "MaterialValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ArmorName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialValue_Armors_ArmorName",
                        column: x => x.ArmorName,
                        principalTable: "Armors",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Defense_ArmorName",
                table: "Defense",
                column: "ArmorName");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialValue_ArmorName",
                table: "MaterialValue",
                column: "ArmorName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Defense");

            migrationBuilder.DropTable(
                name: "MaterialValue");

            migrationBuilder.DropTable(
                name: "Armors");
        }
    }
}
