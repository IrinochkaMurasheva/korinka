using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp1.Migrations
{
    /// <inheritdoc />
    public partial class CriatedSellerAddListServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "services",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_services_SellerId",
                table: "services",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_services_sellers_SellerId",
                table: "services",
                column: "SellerId",
                principalTable: "sellers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_services_sellers_SellerId",
                table: "services");

            migrationBuilder.DropIndex(
                name: "IX_services_SellerId",
                table: "services");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "services");
        }
    }
}
