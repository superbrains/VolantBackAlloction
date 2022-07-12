using Microsoft.EntityFrameworkCore.Migrations;

namespace BAServices.Migrations
{
    public partial class assetdiag44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantID",
                table: "POS",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantID",
                table: "Pipelines",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantID",
                table: "Meters",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantID",
                table: "POS");

            migrationBuilder.DropColumn(
                name: "TenantID",
                table: "Pipelines");

            migrationBuilder.DropColumn(
                name: "TenantID",
                table: "Meters");
        }
    }
}
