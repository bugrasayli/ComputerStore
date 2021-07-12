using Microsoft.EntityFrameworkCore.Migrations;

namespace Computer.Infrastucture.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GraphicCard",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphicCard", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RamID = table.Column<int>(type: "int", nullable: false),
                    GraphicCardID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Computers_GraphicCard_RamID",
                        column: x => x.RamID,
                        principalTable: "GraphicCard",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computers_Rams_GraphicCardID",
                        column: x => x.GraphicCardID,
                        principalTable: "Rams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Computers_GraphicCardID",
                table: "Computers",
                column: "GraphicCardID");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_RamID",
                table: "Computers",
                column: "RamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "GraphicCard");

            migrationBuilder.DropTable(
                name: "Rams");
        }
    }
}
