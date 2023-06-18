using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp1.Migrations
{
    /// <inheritdoc />
    public partial class CriatedOrdersAddProductAndServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Orderid",
                table: "services",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Orderid",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_services_Orderid",
                table: "services",
                column: "Orderid");

            migrationBuilder.CreateIndex(
                name: "IX_products_Orderid",
                table: "products",
                column: "Orderid");

            migrationBuilder.AddForeignKey(
                name: "FK_products_orders_Orderid",
                table: "products",
                column: "Orderid",
                principalTable: "orders",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_services_orders_Orderid",
                table: "services",
                column: "Orderid",
                principalTable: "orders",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_orders_Orderid",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_services_orders_Orderid",
                table: "services");

            migrationBuilder.DropIndex(
                name: "IX_services_Orderid",
                table: "services");

            migrationBuilder.DropIndex(
                name: "IX_products_Orderid",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Orderid",
                table: "services");

            migrationBuilder.DropColumn(
                name: "Orderid",
                table: "products");
        }
    }
}
