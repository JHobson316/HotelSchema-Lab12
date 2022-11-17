using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelSchemaLab12.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Layout", "Name" },
                values: new object[] { 1, 2, "Presidential Suite" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
