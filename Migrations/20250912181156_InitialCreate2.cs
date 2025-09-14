using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetricSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ConversionRecords",
                table: "ConversionRecords");

            migrationBuilder.RenameTable(
                name: "ConversionRecords",
                newName: "TempConversion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TempConversion",
                table: "TempConversion",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TempConversion",
                table: "TempConversion");

            migrationBuilder.RenameTable(
                name: "TempConversion",
                newName: "ConversionRecords");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConversionRecords",
                table: "ConversionRecords",
                column: "Id");
        }
    }
}
