﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VolantBackAlloction.Models;

namespace BAServices.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20220320214145_asset")]
    partial class asset
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BAServices.Models.MeterConfiguration", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MetersID")
                        .HasColumnType("int");

                    b.Property<int>("ObjectID")
                        .HasColumnType("int");

                    b.Property<string>("ObjectType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MetersID");

                    b.ToTable("MeterConfiguration");
                });

            modelBuilder.Entity("BAServices.Models.Operators", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RCCNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Operators");
                });

            modelBuilder.Entity("BAServices.Models.POS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("POSName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PipelinesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PipelinesID");

                    b.ToTable("POS");
                });

            modelBuilder.Entity("BAServices.Models.Tenants", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RCCNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("VolantBackAlloction.Models.Facilities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Capacity_per_day")
                        .HasColumnType("float");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Createdby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DPRPermitNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DesignLife")
                        .HasColumnType("float");

                    b.Property<string>("FacilityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FluidType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Operating_Capacity_gas")
                        .HasColumnType("float");

                    b.Property<double>("Operating_Capacity_water")
                        .HasColumnType("float");

                    b.Property<int>("OperatorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartupDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("StorageCapacity")
                        .HasColumnType("float");

                    b.Property<int?>("TenantsID")
                        .HasColumnType("int");

                    b.Property<string>("Terrain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Waterdepth")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("TenantsID");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("VolantBackAlloction.Models.Field", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApproveStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ApprovedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlockNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlockType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<double>("EUR")
                        .HasColumnType("float");

                    b.Property<DateTime>("FieldDiscoveryDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("FieldFirstOilDateForDevelopedField")
                        .HasColumnType("float");

                    b.Property<string>("FieldHydrocarbonType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FieldLatitude")
                        .HasColumnType("float");

                    b.Property<double>("FieldLongitude")
                        .HasColumnType("float");

                    b.Property<double>("FieldMaximumWaterDepth")
                        .HasColumnType("float");

                    b.Property<double>("FieldMinimumWaterDepth")
                        .HasColumnType("float");

                    b.Property<string>("FieldName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FieldNumberOfOil_CondensateReservoir")
                        .HasColumnType("float");

                    b.Property<double>("FieldNumberofGasReservoir")
                        .HasColumnType("float");

                    b.Property<double>("FieldPointNumber")
                        .HasColumnType("float");

                    b.Property<string>("FieldStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GIIP")
                        .HasColumnType("float");

                    b.Property<int>("NumberofWells")
                        .HasColumnType("int");

                    b.Property<double>("Produced_Condensate_bbl")
                        .HasColumnType("float");

                    b.Property<double>("Produced_Gas_bbl")
                        .HasColumnType("float");

                    b.Property<double>("Produced_Oil_bbl")
                        .HasColumnType("float");

                    b.Property<double>("RF")
                        .HasColumnType("float");

                    b.Property<double>("STOIIP")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TenantsID")
                        .HasColumnType("int");

                    b.Property<string>("Terrain")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TenantsID");

                    b.ToTable("Field");
                });

            modelBuilder.Entity("VolantBackAlloction.Models.Meters", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("MeterFactor")
                        .HasColumnType("float");

                    b.Property<string>("MeterType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Meters");
                });

            modelBuilder.Entity("VolantBackAlloction.Models.Pipelines", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PipelineName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Pipelines");
                });

            modelBuilder.Entity("VolantBackAlloction.Models.Well", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActualCompletionDays")
                        .HasColumnType("int");

                    b.Property<double>("ActualMeasuredDepth")
                        .HasColumnType("float");

                    b.Property<double>("ActualTotalVerticalDepth")
                        .HasColumnType("float");

                    b.Property<double>("ActualWellCostDollar")
                        .HasColumnType("float");

                    b.Property<string>("Approvedby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlockNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlockType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BottomCoordinateLatitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BottomCoordinateLongitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BottomHoleAge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConventionalCore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Createdby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateApproved")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<double>("Depth")
                        .HasColumnType("float");

                    b.Property<string>("DepthRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DepthRefElevation")
                        .HasColumnType("float");

                    b.Property<string>("DrillPermitNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EstimatedWellCostDollar")
                        .HasColumnType("float");

                    b.Property<double>("EstimatedWellCostNaira")
                        .HasColumnType("float");

                    b.Property<double>("ExchangeRate")
                        .HasColumnType("float");

                    b.Property<int?>("FieldID")
                        .HasColumnType("int");

                    b.Property<string>("FieldName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroundLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MeasureDepth")
                        .HasColumnType("float");

                    b.Property<string>("OperatorID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProposedCompletionDays")
                        .HasColumnType("int");

                    b.Property<double>("ProposedTotalDepth")
                        .HasColumnType("float");

                    b.Property<double>("ProposedTotalVerticalDepth")
                        .HasColumnType("float");

                    b.Property<string>("RigOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RigType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SidewallCore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SpudDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurfaceCoordinateLatitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurfaceCoordinateLongitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetedFormation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TenantsID")
                        .HasColumnType("int");

                    b.Property<string>("Terrain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfCompletion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UWI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WaterDepth")
                        .HasColumnType("float");

                    b.Property<string>("WellAlias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WellBoreType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WellClassification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WellContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WellName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WellPurpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WellStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WellStatusDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WellType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("FieldID");

                    b.HasIndex("TenantsID");

                    b.ToTable("Well");
                });

            modelBuilder.Entity("BAServices.Models.MeterConfiguration", b =>
                {
                    b.HasOne("VolantBackAlloction.Models.Meters", "Meters")
                        .WithMany()
                        .HasForeignKey("MetersID");
                });

            modelBuilder.Entity("BAServices.Models.POS", b =>
                {
                    b.HasOne("VolantBackAlloction.Models.Pipelines", "Pipelines")
                        .WithMany()
                        .HasForeignKey("PipelinesID");
                });

            modelBuilder.Entity("VolantBackAlloction.Models.Facilities", b =>
                {
                    b.HasOne("BAServices.Models.Tenants", "Tenants")
                        .WithMany()
                        .HasForeignKey("TenantsID");
                });

            modelBuilder.Entity("VolantBackAlloction.Models.Field", b =>
                {
                    b.HasOne("BAServices.Models.Tenants", "Tenants")
                        .WithMany()
                        .HasForeignKey("TenantsID");
                });

            modelBuilder.Entity("VolantBackAlloction.Models.Well", b =>
                {
                    b.HasOne("VolantBackAlloction.Models.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldID");

                    b.HasOne("BAServices.Models.Tenants", "Tenants")
                        .WithMany()
                        .HasForeignKey("TenantsID");
                });
#pragma warning restore 612, 618
        }
    }
}
