using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialPC : Migration
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
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.RecordId);
                });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "RecordId", "ArtistName", "ImageFileName", "Price", "RecordName" },
                values: new object[,]
                {
                    { 1, "Andy William", "andy_williams__youve_got_a_friend.jpg", 15.0, "You've Got A Friend" },
                    { 2, "Dean Martin", "dean_martin__gentle_on_my_mind.jpg", 25.0, "Gentle On My Mind" },
                    { 3, "Frank Sinatra", "frank_sinatra__sinatras_sinatra.jpg", 30.0, "Sinatra's Sinatra" },
                    { 4, "Paul Anka", "paul_anka__anka.jpg", 10.0, "Anka" },
                    { 5, "Perry Como", "perry_como__its_impossible.jpg", 17.0, "It's Impossible" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");
        }
    }
}
