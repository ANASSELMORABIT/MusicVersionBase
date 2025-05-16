using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRJ_FINAL_MP09_MP03.Migrations
{
    /// <inheritdoc />
    public partial class AddUrlsToPlaylist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdTrack",
                table: "Playlists",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UrlDescarga",
                table: "Playlists",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UrlImg",
                table: "Playlists",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UrlMusica",
                table: "Playlists",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdTrack",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "UrlDescarga",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "UrlImg",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "UrlMusica",
                table: "Playlists");
        }
    }
}
