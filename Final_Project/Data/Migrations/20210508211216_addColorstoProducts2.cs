using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Data.Migrations
{
    public partial class addColorstoProducts2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColor_Product_ProductID",
                table: "ProductColor");

            migrationBuilder.DropIndex(
                name: "IX_ProductColor_ProductID",
                table: "ProductColor");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ProductColor");

            migrationBuilder.CreateTable(
                name: "ProductProductColor",
                columns: table => new
                {
                    ProductColorsID = table.Column<int>(type: "int", nullable: false),
                    ProductsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductColor", x => new { x.ProductColorsID, x.ProductsID });
                    table.ForeignKey(
                        name: "FK_ProductProductColor_Product_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductColor_ProductColor_ProductColorsID",
                        column: x => x.ProductColorsID,
                        principalTable: "ProductColor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductColor_ProductsID",
                table: "ProductProductColor",
                column: "ProductsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductProductColor");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "ProductColor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductColor_ProductID",
                table: "ProductColor",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColor_Product_ProductID",
                table: "ProductColor",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
