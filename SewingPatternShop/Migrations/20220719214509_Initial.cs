using Microsoft.EntityFrameworkCore.Migrations;

namespace SewingPatternShop.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "Skirt" },
                    { 2, "Pants" },
                    { 3, "Blouse" },
                    { 4, "Dress" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "hoop", "Hoop skirt", 69m },
                    { 2, 1, "tutu", "Tutu skirt", 119m },
                    { 3, 1, "pleated", "Pleated skirt", 251m },
                    { 4, 1, "layered", "Layeres skirt", 48.99m },
                    { 5, 2, "bush", "Bush pants", 29m },
                    { 6, 2, "jogger", "Jogger pants", 41m },
                    { 7, 2, "cargo", "Cargo pants", 79.99m },
                    { 8, 3, "gypsy", "Gypsy blouse", 49.99m },
                    { 9, 3, "tunic", "Tunic blouse", 69.99m },
                    { 10, 3, "ruffle", "Ruffle front blouse", 79.99m },
                    { 11, 4, "sheath", "Sheath dress", 79.99m },
                    { 12, 4, "trumpet", "Trumpet dress", 49.99m },
                    { 13, 4, "wrap", "Wrap arount dress", 69.99m },
                    { 14, 4, "buble", "Buble dress", 79.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
