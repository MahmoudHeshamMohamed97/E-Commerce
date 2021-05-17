using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Data.Migrations
{
    public partial class edirtingitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Order_OrderID",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Item",
                newName: "Order_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Item_OrderID",
                table: "Item",
                newName: "IX_Item_Order_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Order_Order_Id",
                table: "Item",
                column: "Order_Id",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Order_Order_Id",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "Order_Id",
                table: "Item",
                newName: "OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Item_Order_Id",
                table: "Item",
                newName: "IX_Item_OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Order_OrderID",
                table: "Item",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
