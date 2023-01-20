using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventVerse.Migrations
{
    public partial class merch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MerchVariantId",
                table: "Merchandise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Merchandise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Merchandise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MerchVariant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchVariant", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Merchandise_MerchVariantId",
                table: "Merchandise",
                column: "MerchVariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Merchandise_MerchVariant_MerchVariantId",
                table: "Merchandise",
                column: "MerchVariantId",
                principalTable: "MerchVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Merchandise_MerchVariant_MerchVariantId",
                table: "Merchandise");

            migrationBuilder.DropTable(
                name: "MerchVariant");

            migrationBuilder.DropIndex(
                name: "IX_Merchandise_MerchVariantId",
                table: "Merchandise");

            migrationBuilder.DropColumn(
                name: "MerchVariantId",
                table: "Merchandise");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Merchandise");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Merchandise");
        }
    }
}
