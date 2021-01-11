using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataTransformation.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VendorMapping",
                columns: table => new
                {
                    MappingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DT_XML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RO_XML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDDS_XML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RO_TRSFM_LOGIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_TRSFM_LOGIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDDS_TRSFM_LOGIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CDM_MAPPING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DB_FIELD_NM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UI_FIELD_NM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMMENTS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EDIT_DT = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorMapping", x => x.MappingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendorMapping");
        }
    }
}
