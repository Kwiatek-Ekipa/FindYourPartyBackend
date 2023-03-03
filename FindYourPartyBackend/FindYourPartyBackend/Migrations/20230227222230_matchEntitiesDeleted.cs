using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FindYourPartyBackend.Migrations
{
    /// <inheritdoc />
    public partial class matchEntitiesDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubMatchClubToClubType");

            migrationBuilder.DropTable(
                name: "ClubMatchClubToMusicType");

            migrationBuilder.DropTable(
                name: "ClubTypeMatchClubToClubType");

            migrationBuilder.DropTable(
                name: "MatchClubToMusicTypeMusicType");

            migrationBuilder.DropTable(
                name: "MatchClubToClubType");

            migrationBuilder.DropTable(
                name: "MatchClubToMusicType");

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
                        name: "FK_ClubClubType_ClubType_ClubTypesId",
                        column: x => x.ClubTypesId,
                        principalTable: "ClubType",
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
                        name: "FK_ClubMusicType_MusicType_MusicTypesId",
                        column: x => x.MusicTypesId,
                        principalTable: "MusicType",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubClubType");

            migrationBuilder.DropTable(
                name: "ClubMusicType");

            migrationBuilder.CreateTable(
                name: "MatchClubToClubType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClubId = table.Column<int>(type: "integer", nullable: false),
                    ClubTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchClubToClubType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchClubToMusicType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClubId = table.Column<int>(type: "integer", nullable: false),
                    MusicTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchClubToMusicType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClubMatchClubToClubType",
                columns: table => new
                {
                    ClubsClubId = table.Column<int>(type: "integer", nullable: false),
                    MatchClubToClubTypesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubMatchClubToClubType", x => new { x.ClubsClubId, x.MatchClubToClubTypesId });
                    table.ForeignKey(
                        name: "FK_ClubMatchClubToClubType_Clubs_ClubsClubId",
                        column: x => x.ClubsClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubMatchClubToClubType_MatchClubToClubType_MatchClubToClub~",
                        column: x => x.MatchClubToClubTypesId,
                        principalTable: "MatchClubToClubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubTypeMatchClubToClubType",
                columns: table => new
                {
                    ClubTypesId = table.Column<int>(type: "integer", nullable: false),
                    MatchClubToClubTypesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubTypeMatchClubToClubType", x => new { x.ClubTypesId, x.MatchClubToClubTypesId });
                    table.ForeignKey(
                        name: "FK_ClubTypeMatchClubToClubType_ClubType_ClubTypesId",
                        column: x => x.ClubTypesId,
                        principalTable: "ClubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubTypeMatchClubToClubType_MatchClubToClubType_MatchClubTo~",
                        column: x => x.MatchClubToClubTypesId,
                        principalTable: "MatchClubToClubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubMatchClubToMusicType",
                columns: table => new
                {
                    ClubsClubId = table.Column<int>(type: "integer", nullable: false),
                    MatchClubToMusicTypesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubMatchClubToMusicType", x => new { x.ClubsClubId, x.MatchClubToMusicTypesId });
                    table.ForeignKey(
                        name: "FK_ClubMatchClubToMusicType_Clubs_ClubsClubId",
                        column: x => x.ClubsClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubMatchClubToMusicType_MatchClubToMusicType_MatchClubToMu~",
                        column: x => x.MatchClubToMusicTypesId,
                        principalTable: "MatchClubToMusicType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MatchClubToMusicTypeMusicType",
                columns: table => new
                {
                    MatchClubToMusicTypesId = table.Column<int>(type: "integer", nullable: false),
                    MusicTypesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchClubToMusicTypeMusicType", x => new { x.MatchClubToMusicTypesId, x.MusicTypesId });
                    table.ForeignKey(
                        name: "FK_MatchClubToMusicTypeMusicType_MatchClubToMusicType_MatchClu~",
                        column: x => x.MatchClubToMusicTypesId,
                        principalTable: "MatchClubToMusicType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchClubToMusicTypeMusicType_MusicType_MusicTypesId",
                        column: x => x.MusicTypesId,
                        principalTable: "MusicType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubMatchClubToClubType_MatchClubToClubTypesId",
                table: "ClubMatchClubToClubType",
                column: "MatchClubToClubTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubMatchClubToMusicType_MatchClubToMusicTypesId",
                table: "ClubMatchClubToMusicType",
                column: "MatchClubToMusicTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubTypeMatchClubToClubType_MatchClubToClubTypesId",
                table: "ClubTypeMatchClubToClubType",
                column: "MatchClubToClubTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchClubToMusicTypeMusicType_MusicTypesId",
                table: "MatchClubToMusicTypeMusicType",
                column: "MusicTypesId");
        }
    }
}
