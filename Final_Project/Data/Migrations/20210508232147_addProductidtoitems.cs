using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Data.Migrations
{
    public partial class addProductidtoitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Product_ProductID",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Item",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ProductID",
                table: "Item",
                newName: "IX_Item_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Product_ProductId",
                table: "Item",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Product_ProductId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Item",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ProductId",
                table: "Item",
                newName: "IX_Item_ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Product_ProductID",
                table: "Item",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
