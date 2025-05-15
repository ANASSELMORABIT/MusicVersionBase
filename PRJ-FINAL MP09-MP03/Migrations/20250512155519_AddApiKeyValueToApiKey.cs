using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRJ_FINAL_MP09_MP03.Migrations
{
    /// <inheritdoc />
    public partial class AddApiKeyValueToApiKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApiKeyValue",
                table: "ApiKeys",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiKeyValue",
                table: "ApiKeys");
        }
    }
}
