using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelSchemaLab12.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "City", "Country", "Name", "Phone", "State", "streetAddress" },
                values: new object[] { 1, "Memphis", "USA", "The Andalusian", "901-555-1999", "TN", "2014 Sam Cooper Blvd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
