using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FindYourPartyBackend.Migrations
{
    /// <inheritdoc />
    public partial class newEntityNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClubClubType_ClubType_ClubTypesId",
                table: "ClubClubType");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubMusicType_MusicType_MusicTypesId",
                table: "ClubMusicType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicType",
                table: "MusicType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClubType",
                table: "ClubType");

            migrationBuilder.RenameTable(
                name: "MusicType",
                newName: "MusicTypes");

            migrationBuilder.RenameTable(
                name: "ClubType",
                newName: "ClubTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicTypes",
                table: "MusicTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClubTypes",
                table: "ClubTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClubClubType_ClubTypes_ClubTypesId",
                table: "ClubClubType",
                column: "ClubTypesId",
                principalTable: "ClubTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubMusicType_MusicTypes_MusicTypesId",
                table: "ClubMusicType",
                column: "MusicTypesId",
                principalTable: "MusicTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClubClubType_ClubTypes_ClubTypesId",
                table: "ClubClubType");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubMusicType_MusicTypes_MusicTypesId",
                table: "ClubMusicType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicTypes",
                table: "MusicTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClubTypes",
                table: "ClubTypes");

            migrationBuilder.RenameTable(
                name: "MusicTypes",
                newName: "MusicType");

            migrationBuilder.RenameTable(
                name: "ClubTypes",
                newName: "ClubType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicType",
                table: "MusicType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClubType",
                table: "ClubType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClubClubType_ClubType_ClubTypesId",
                table: "ClubClubType",
                column: "ClubTypesId",
                principalTable: "ClubType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubMusicType_MusicType_MusicTypesId",
                table: "ClubMusicType",
                column: "MusicTypesId",
                principalTable: "MusicType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
