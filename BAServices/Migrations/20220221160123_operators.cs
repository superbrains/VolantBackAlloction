using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BAServices.Migrations
{
    public partial class operators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    ContactMobile = table.Column<string>(nullable: true),
                    ContactEmail = table.Column<string>(nullable: true),
                    RCCNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    ContactMobile = table.Column<string>(nullable: true),
                    ContactEmail = table.Column<string>(nullable: true),
                    RCCNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FacilityType = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    StartupDate = table.Column<DateTime>(nullable: false),
                    FacilityStatus = table.Column<string>(nullable: true),
                    LocationName = table.Column<string>(nullable: true),
                    Terrain = table.Column<string>(nullable: true),
                    Capacity_per_day = table.Column<double>(nullable: false),
                    Operating_Capacity_gas = table.Column<double>(nullable: false),
                    Operating_Capacity_water = table.Column<double>(nullable: false),
                    StorageCapacity = table.Column<double>(nullable: false),
                    FluidType = table.Column<string>(nullable: true),
                    CommissionDate = table.Column<DateTime>(nullable: false),
                    DPRPermitNumber = table.Column<string>(nullable: true),
                    DesignLife = table.Column<double>(nullable: false),
                    Waterdepth = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Createdby = table.Column<string>(nullable: true),
                    OperatorID = table.Column<int>(nullable: false),
                    TenantsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Facilities_Tenants_TenantsID",
                        column: x => x.TenantsID,
                        principalTable: "Tenants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldName = table.Column<string>(nullable: true),
                    FieldType = table.Column<string>(nullable: true),
                    BlockNumber = table.Column<string>(nullable: true),
                    BlockType = table.Column<string>(nullable: true),
                    BA = table.Column<string>(nullable: true),
                    NumberofWells = table.Column<int>(nullable: false),
                    FieldPointNumber = table.Column<double>(nullable: false),
                    FieldLatitude = table.Column<double>(nullable: false),
                    FieldLongitude = table.Column<double>(nullable: false),
                    FieldHydrocarbonType = table.Column<string>(nullable: true),
                    FieldStatus = table.Column<string>(nullable: true),
                    FieldDiscoveryDate = table.Column<DateTime>(nullable: false),
                    FieldMinimumWaterDepth = table.Column<double>(nullable: false),
                    FieldMaximumWaterDepth = table.Column<double>(nullable: false),
                    FieldNumberofGasReservoir = table.Column<double>(nullable: false),
                    FieldNumberOfOil_CondensateReservoir = table.Column<double>(nullable: false),
                    FieldFirstOilDateForDevelopedField = table.Column<double>(nullable: false),
                    Terrain = table.Column<string>(nullable: true),
                    STOIIP = table.Column<double>(nullable: false),
                    GIIP = table.Column<double>(nullable: false),
                    EUR = table.Column<double>(nullable: false),
                    RF = table.Column<double>(nullable: false),
                    Produced_Oil_bbl = table.Column<double>(nullable: false),
                    Produced_Condensate_bbl = table.Column<double>(nullable: false),
                    Produced_Gas_bbl = table.Column<double>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ApprovedBy = table.Column<string>(nullable: true),
                    ApprovedDate = table.Column<DateTime>(nullable: false),
                    ApproveStatus = table.Column<string>(nullable: true),
                    TenantsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Field_Tenants_TenantsID",
                        column: x => x.TenantsID,
                        principalTable: "Tenants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Well",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UWI = table.Column<string>(nullable: true),
                    FieldName = table.Column<string>(nullable: true),
                    FieldID = table.Column<int>(nullable: true),
                    OperatorID = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ProductionDate = table.Column<DateTime>(nullable: false),
                    Depth = table.Column<double>(nullable: false),
                    BlockNumber = table.Column<string>(nullable: true),
                    BlockType = table.Column<string>(nullable: true),
                    WellName = table.Column<string>(nullable: true),
                    WellAlias = table.Column<string>(nullable: true),
                    LocationName = table.Column<string>(nullable: true),
                    SurfaceCoordinateLongitude = table.Column<string>(nullable: true),
                    SurfaceCoordinateLatitude = table.Column<string>(nullable: true),
                    BottomCoordinateLongitude = table.Column<string>(nullable: true),
                    BottomCoordinateLatitude = table.Column<string>(nullable: true),
                    Terrain = table.Column<string>(nullable: true),
                    DrillPermitNo = table.Column<string>(nullable: true),
                    SpudDate = table.Column<DateTime>(nullable: false),
                    CompletionDate = table.Column<DateTime>(nullable: false),
                    WellClassification = table.Column<string>(nullable: true),
                    WellPurpose = table.Column<string>(nullable: true),
                    WellContent = table.Column<string>(nullable: true),
                    WellBoreType = table.Column<string>(nullable: true),
                    WellType = table.Column<string>(nullable: true),
                    WellStatusDate = table.Column<DateTime>(nullable: false),
                    WaterDepth = table.Column<double>(nullable: false),
                    RigType = table.Column<string>(nullable: true),
                    RigOwner = table.Column<string>(nullable: true),
                    TargetedFormation = table.Column<string>(nullable: true),
                    BottomHoleAge = table.Column<string>(nullable: true),
                    ProposedTotalDepth = table.Column<double>(nullable: false),
                    ActualMeasuredDepth = table.Column<double>(nullable: false),
                    ProposedTotalVerticalDepth = table.Column<double>(nullable: false),
                    ActualTotalVerticalDepth = table.Column<double>(nullable: false),
                    EstimatedWellCostDollar = table.Column<double>(nullable: false),
                    ActualWellCostDollar = table.Column<double>(nullable: false),
                    EstimatedWellCostNaira = table.Column<double>(nullable: false),
                    ExchangeRate = table.Column<double>(nullable: false),
                    DepthRef = table.Column<string>(nullable: true),
                    DepthRefElevation = table.Column<double>(nullable: false),
                    ConventionalCore = table.Column<string>(nullable: true),
                    SidewallCore = table.Column<string>(nullable: true),
                    GroundLevel = table.Column<string>(nullable: true),
                    TypeOfCompletion = table.Column<string>(nullable: true),
                    ProposedCompletionDays = table.Column<int>(nullable: false),
                    ActualCompletionDays = table.Column<int>(nullable: false),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Createdby = table.Column<string>(nullable: true),
                    Approvedby = table.Column<string>(nullable: true),
                    DateApproved = table.Column<DateTime>(nullable: false),
                    MeasureDepth = table.Column<double>(nullable: false),
                    WellStatus = table.Column<string>(nullable: true),
                    TenantsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Well", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Well_Field_FieldID",
                        column: x => x.FieldID,
                        principalTable: "Field",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Well_Tenants_TenantsID",
                        column: x => x.TenantsID,
                        principalTable: "Tenants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_TenantsID",
                table: "Facilities",
                column: "TenantsID");

            migrationBuilder.CreateIndex(
                name: "IX_Field_TenantsID",
                table: "Field",
                column: "TenantsID");

            migrationBuilder.CreateIndex(
                name: "IX_Well_FieldID",
                table: "Well",
                column: "FieldID");

            migrationBuilder.CreateIndex(
                name: "IX_Well_TenantsID",
                table: "Well",
                column: "TenantsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.DropTable(
                name: "Well");

            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropTable(
                name: "Tenants");
        }
    }
}
