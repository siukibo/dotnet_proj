using Microsoft.EntityFrameworkCore.Migrations;

namespace Solution.Data.Migrations
{
    public partial class V0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Brand_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Brand_Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand_Image = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Image1.jpg")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Brand_Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Category_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Category_Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_Image = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Image1.jpg")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Prd_Detail",
                columns: table => new
                {
                    Prd_Detail_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prd_Detail_Price = table.Column<float>(type: "real", nullable: false),
                    Prd_Detail_Image = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Image1.jpg"),
                    Prd_Detail_Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prd_Detail_Quantity = table.Column<int>(type: "int", nullable: false),
                    Prd_Detail_Date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prd_Detail", x => x.Prd_Detail_Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    Brand_Id = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Cate_Id = table.Column<int>(type: "int", nullable: true),
                    Brand_Id1 = table.Column<int>(type: "int", nullable: true),
                    Category_Id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_Id);
                    table.ForeignKey(
                        name: "fk_Product_Brand",
                        column: x => x.Brand_Id,
                        principalTable: "Brand",
                        principalColumn: "Brand_Id");
                    table.ForeignKey(
                        name: "FK_Product_Brand_Brand_Id1",
                        column: x => x.Brand_Id1,
                        principalTable: "Brand",
                        principalColumn: "Brand_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Product_Category",
                        column: x => x.Cate_Id,
                        principalTable: "Category",
                        principalColumn: "Category_Id");
                    table.ForeignKey(
                        name: "FK_Product_Category_Category_Id1",
                        column: x => x.Category_Id1,
                        principalTable: "Category",
                        principalColumn: "Category_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Product_Detail",
                        column: x => x.Category_Id,
                        principalTable: "Prd_Detail",
                        principalColumn: "Prd_Detail_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_Brand_Id",
                table: "Product",
                column: "Brand_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Brand_Id1",
                table: "Product",
                column: "Brand_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Cate_Id",
                table: "Product",
                column: "Cate_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category_Id",
                table: "Product",
                column: "Category_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category_Id1",
                table: "Product",
                column: "Category_Id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Prd_Detail");
        }
    }
}
