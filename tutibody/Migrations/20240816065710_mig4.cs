using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tutibody.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
