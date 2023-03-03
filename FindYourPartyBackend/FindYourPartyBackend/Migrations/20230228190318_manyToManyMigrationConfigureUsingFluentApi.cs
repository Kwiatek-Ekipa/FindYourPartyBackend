using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FindYourPartyBackend.Migrations
{
    /// <inheritdoc />
    public partial class manyToManyMigrationConfigureUsingFluentApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubClubType");

            migrationBuilder.DropTable(
                name: "ClubMusicType");

            migrationBuilder.CreateTable(
                name: "ClubClubTypes",
                columns: table => new
                {
                    ClubTypeId = table.Column<int>(type: "integer", nullable: false),
                    ClubId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubClubTypes", x => new { x.ClubTypeId, x.ClubId });
                    table.ForeignKey(
                        name: "FK_ClubClubTypes_ClubTypes_ClubTypeId",
                        column: x => x.ClubTypeId,
                        principalTable: "ClubTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubClubTypes_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubMusicTypes",
                columns: table => new
                {
                    MusicTypeId = table.Column<int>(type: "integer", nullable: false),
                    ClubId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubMusicTypes", x => new { x.MusicTypeId, x.ClubId });
                    table.ForeignKey(
                        name: "FK_ClubMusicTypes_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubMusicTypes_MusicTypes_MusicTypeId",
                        column: x => x.MusicTypeId,
                        principalTable: "MusicTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubClubTypes_ClubId",
                table: "ClubClubTypes",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubMusicTypes_ClubId",
                table: "ClubMusicTypes",
                column: "ClubId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubClubTypes");

            migrationBuilder.DropTable(
                name: "ClubMusicTypes");

            migrationBuilder.CreateTable(
                name: "ClubClubType",
                columns: table => new
                {
                    ClubTypesId = table.Column<int>(type: "integer", nullable: false),
                    ClubsClubId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubClubType", x => new { x.ClubTypesId, x.ClubsClubId });
                    table.ForeignKey(
                        name: "FK_ClubClubType_ClubTypes_ClubTypesId",
                        column: x => x.ClubTypesId,
                        principalTable: "ClubTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubClubType_Clubs_ClubsClubId",
                        column: x => x.ClubsClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubMusicType",
                columns: table => new
                {
                    ClubsClubId = table.Column<int>(type: "integer", nullable: false),
                    MusicTypesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubMusicType", x => new { x.ClubsClubId, x.MusicTypesId });
                    table.ForeignKey(
                        name: "FK_ClubMusicType_Clubs_ClubsClubId",
                        column: x => x.ClubsClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubMusicType_MusicTypes_MusicTypesId",
                        column: x => x.MusicTypesId,
                        principalTable: "MusicTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubClubType_ClubsClubId",
                table: "ClubClubType",
                column: "ClubsClubId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubMusicType_MusicTypesId",
                table: "ClubMusicType",
                column: "MusicTypesId");
        }
    }
}
