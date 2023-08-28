using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.Data.Migrations
{
    /// <inheritdoc />
    public partial class attributenamechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Milage",
                table: "Items",
                newName: "Mileage");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Auctions",
                newName: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mileage",
                table: "Items",
                newName: "Milage");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Auctions",
                newName: "status");
        }
    }
}
