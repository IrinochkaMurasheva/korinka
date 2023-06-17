using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp1.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_buyers_BuyerId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_status_statusId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_sellers_SellerId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_services_categories_CategoryId",
                table: "services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_services",
                table: "services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sellers",
                table: "sellers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_buyers",
                table: "buyers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admins",
                table: "admins");

            migrationBuilder.RenameTable(
                name: "services",
                newName: "service");

            migrationBuilder.RenameTable(
                name: "sellers",
                newName: "seller");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "product");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "order");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "categorie");

            migrationBuilder.RenameTable(
                name: "buyers",
                newName: "buyer");

            migrationBuilder.RenameTable(
                name: "admins",
                newName: "admin");

            migrationBuilder.RenameIndex(
                name: "IX_services_CategoryId",
                table: "service",
                newName: "IX_service_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_products_SellerId",
                table: "product",
                newName: "IX_product_SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryId",
                table: "product",
                newName: "IX_product_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_statusId",
                table: "order",
                newName: "IX_order_statusId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_BuyerId",
                table: "order",
                newName: "IX_order_BuyerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_service",
                table: "service",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_seller",
                table: "seller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                table: "product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order",
                table: "order",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categorie",
                table: "categorie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_buyer",
                table: "buyer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admin",
                table: "admin",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_buyer_BuyerId",
                table: "order",
                column: "BuyerId",
                principalTable: "buyer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_status_statusId",
                table: "order",
                column: "statusId",
                principalTable: "status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_categorie_CategoryId",
                table: "product",
                column: "CategoryId",
                principalTable: "categorie",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_seller_SellerId",
                table: "product",
                column: "SellerId",
                principalTable: "seller",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_service_categorie_CategoryId",
                table: "service",
                column: "CategoryId",
                principalTable: "categorie",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_buyer_BuyerId",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_status_statusId",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_product_categorie_CategoryId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_seller_SellerId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_service_categorie_CategoryId",
                table: "service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_service",
                table: "service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_seller",
                table: "seller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                table: "product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order",
                table: "order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categorie",
                table: "categorie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_buyer",
                table: "buyer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admin",
                table: "admin");

            migrationBuilder.RenameTable(
                name: "service",
                newName: "services");

            migrationBuilder.RenameTable(
                name: "seller",
                newName: "sellers");

            migrationBuilder.RenameTable(
                name: "product",
                newName: "products");

            migrationBuilder.RenameTable(
                name: "order",
                newName: "orders");

            migrationBuilder.RenameTable(
                name: "categorie",
                newName: "categories");

            migrationBuilder.RenameTable(
                name: "buyer",
                newName: "buyers");

            migrationBuilder.RenameTable(
                name: "admin",
                newName: "admins");

            migrationBuilder.RenameIndex(
                name: "IX_service_CategoryId",
                table: "services",
                newName: "IX_services_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_product_SellerId",
                table: "products",
                newName: "IX_products_SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_product_CategoryId",
                table: "products",
                newName: "IX_products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_order_statusId",
                table: "orders",
                newName: "IX_orders_statusId");

            migrationBuilder.RenameIndex(
                name: "IX_order_BuyerId",
                table: "orders",
                newName: "IX_orders_BuyerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_services",
                table: "services",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sellers",
                table: "sellers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_buyers",
                table: "buyers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admins",
                table: "admins",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_buyers_BuyerId",
                table: "orders",
                column: "BuyerId",
                principalTable: "buyers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_status_statusId",
                table: "orders",
                column: "statusId",
                principalTable: "status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_sellers_SellerId",
                table: "products",
                column: "SellerId",
                principalTable: "sellers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_services_categories_CategoryId",
                table: "services",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id");
        }
    }
}
