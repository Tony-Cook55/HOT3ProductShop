using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductShop.Migrations
{
    /// <inheritdoc />
    public partial class DoubleToDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Records",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchase_Records_RecordId",
                        column: x => x.RecordId,
                        principalTable: "Records",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 1,
                column: "Price",
                value: 15m);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 2,
                column: "Price",
                value: 25m);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 3,
                column: "Price",
                value: 30m);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 4,
                column: "Price",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 5,
                column: "Price",
                value: 17m);

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_RecordId",
                table: "Purchase",
                column: "RecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Records",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 1,
                column: "Price",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 2,
                column: "Price",
                value: 25.0);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 3,
                column: "Price",
                value: 30.0);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 4,
                column: "Price",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 5,
                column: "Price",
                value: 17.0);
        }
    }
}
