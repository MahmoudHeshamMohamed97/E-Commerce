using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Data.Migrations
{
    public partial class addingbrandmaterialandstores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductProductColor");

            migrationBuilder.DropTable(
                name: "ProductProductSize");

            migrationBuilder.DropTable(
                name: "ProductColor");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "brand",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoretId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Store_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_StoretId",
                table: "Item",
                column: "StoretId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_ProductId",
                table: "Store",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Store_StoretId",
                table: "Item",
                column: "StoretId",
                principalTable: "Store",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Store_StoretId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Item_StoretId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "brand",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "StoretId",
                table: "Item");

            migrationBuilder.CreateTable(
                name: "ProductColor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "ProductProductSize",
                columns: table => new
                {
                    ProductSizesID = table.Column<int>(type: "int", nullable: false),
                    ProductsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductSize", x => new { x.ProductSizesID, x.ProductsID });
                    table.ForeignKey(
                        name: "FK_ProductProductSize_Product_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductSize_ProductSize_ProductSizesID",
                        column: x => x.ProductSizesID,
                        principalTable: "ProductSize",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductColor_ProductsID",
                table: "ProductProductColor",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductSize_ProductsID",
                table: "ProductProductSize",
                column: "ProductsID");
        }
    }
}
