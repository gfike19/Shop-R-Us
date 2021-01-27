using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop_R_Us.Migrations
{
    public partial class addproductscustomerOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerOrderId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CustomerOrderId",
                table: "Products",
                column: "CustomerOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CustomerOrders_CustomerOrderId",
                table: "Products",
                column: "CustomerOrderId",
                principalTable: "CustomerOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CustomerOrders_CustomerOrderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CustomerOrderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CustomerOrderId",
                table: "Products");
        }
    }
}
