using Microsoft.EntityFrameworkCore.Migrations;

namespace BAServices.Migrations
{
    public partial class asset2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "LACTUnitConfiguration",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetersID = table.Column<int>(nullable: true),
                    FacilitiesID = table.Column<int>(nullable: true),
                    PipelinesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LACTUnitConfiguration", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LACTUnitConfiguration_Facilities_FacilitiesID",
                        column: x => x.FacilitiesID,
                        principalTable: "Facilities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LACTUnitConfiguration_Meters_MetersID",
                        column: x => x.MetersID,
                        principalTable: "Meters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LACTUnitConfiguration_Pipelines_PipelinesID",
                        column: x => x.PipelinesID,
                        principalTable: "Pipelines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LACTUnitConfiguration_FacilitiesID",
                table: "LACTUnitConfiguration",
                column: "FacilitiesID");

            migrationBuilder.CreateIndex(
                name: "IX_LACTUnitConfiguration_MetersID",
                table: "LACTUnitConfiguration",
                column: "MetersID");

            migrationBuilder.CreateIndex(
                name: "IX_LACTUnitConfiguration_PipelinesID",
                table: "LACTUnitConfiguration",
                column: "PipelinesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LACTUnitConfiguration");

           
        }
    }
}
