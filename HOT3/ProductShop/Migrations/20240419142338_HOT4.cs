using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductShop.Migrations
{
    /// <inheritdoc />
    public partial class HOT4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ArtistName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.RecordId);
                });

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

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "RecordId", "ArtistName", "ImageFileName", "Price", "RecordName" },
                values: new object[,]
                {
                    { 1, "Andy William", "andy_williams__youve_got_a_friend.jpg", 15m, "You've Got A Friend" },
                    { 2, "Dean Martin", "dean_martin__gentle_on_my_mind.jpg", 25m, "Gentle On My Mind" },
                    { 3, "Frank Sinatra", "frank_sinatra__sinatras_sinatra.jpg", 30m, "Sinatra's Sinatra" },
                    { 4, "Paul Anka", "paul_anka__anka.jpg", 10m, "Anka" },
                    { 5, "Perry Como", "perry_como__its_impossible.jpg", 17m, "It's Impossible" }
                });

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

            migrationBuilder.DropTable(
                name: "Records");
        }
    }
}
