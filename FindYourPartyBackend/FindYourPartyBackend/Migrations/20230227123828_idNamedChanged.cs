using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FindYourPartyBackend.Migrations
{
    /// <inheritdoc />
    public partial class idNamedChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    ClubId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ClubType = table.Column<string>(type: "text", nullable: false),
                    ClubSize = table.Column<int>(type: "integer", nullable: false),
                    NumberOfRooms = table.Column<int>(type: "integer", nullable: false),
                    MusicType = table.Column<string>(type: "text", nullable: true),
                    Links = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.ClubId);
                });

            migrationBuilder.CreateTable(
                name: "ClubAddress",
                columns: table => new
                {
                    ClubId = table.Column<int>(type: "integer", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubAddress", x => x.ClubId);
                    table.ForeignKey(
                        name: "FK_ClubAddress_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubOpeningHours",
                columns: table => new
                {
                    ClubId = table.Column<int>(type: "integer", nullable: false),
                    Monday = table.Column<string>(type: "text", nullable: false),
                    Tuesday = table.Column<string>(type: "text", nullable: false),
                    Wednesday = table.Column<string>(type: "text", nullable: false),
                    Thursday = table.Column<string>(type: "text", nullable: false),
                    Friday = table.Column<string>(type: "text", nullable: false),
                    Saturday = table.Column<string>(type: "text", nullable: false),
                    Sunday = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubOpeningHours", x => x.ClubId);
                    table.ForeignKey(
                        name: "FK_ClubOpeningHours_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EventHours = table.Column<string>(type: "text", nullable: false),
                    ClubId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_Id",
                table: "Clubs",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_ClubId",
                table: "Events",
                column: "ClubId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubAddress");

            migrationBuilder.DropTable(
                name: "ClubOpeningHours");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Clubs");
        }
    }
}
