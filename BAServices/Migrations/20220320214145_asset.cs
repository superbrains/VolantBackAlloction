using Microsoft.EntityFrameworkCore.Migrations;

namespace BAServices.Migrations
{
    public partial class asset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeterType = table.Column<string>(nullable: true),
                    MeterFactor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pipelines",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PipelineName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pipelines", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MeterConfiguration",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetersID = table.Column<int>(nullable: true),
                    ObjectType = table.Column<string>(nullable: true),
                    ObjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterConfiguration", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MeterConfiguration_Meters_MetersID",
                        column: x => x.MetersID,
                        principalTable: "Meters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "POS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PipelinesID = table.Column<int>(nullable: true),
                    POSName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_POS_Pipelines_PipelinesID",
                        column: x => x.PipelinesID,
                        principalTable: "Pipelines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MeterConfiguration_MetersID",
                table: "MeterConfiguration",
                column: "MetersID");

            migrationBuilder.CreateIndex(
                name: "IX_POS_PipelinesID",
                table: "POS",
                column: "PipelinesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeterConfiguration");

            migrationBuilder.DropTable(
                name: "POS");

            migrationBuilder.DropTable(
                name: "Meters");

            migrationBuilder.DropTable(
                name: "Pipelines");
        }
    }
}
