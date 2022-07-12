using Microsoft.EntityFrameworkCore.Migrations;

namespace BAServices.Migrations
{
    public partial class assetdiag2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    from = table.Column<int>(nullable: false),
                    to = table.Column<int>(nullable: false),
                    TenantID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Nodes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    size = table.Column<string>(nullable: true),
                    key = table.Column<int>(nullable: false),
                    location = table.Column<string>(nullable: true),
                    TenantID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nodes", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Nodes");
        }
    }
}
