using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FindYourPartyBackend.Migrations
{
    /// <inheritdoc />
    public partial class clubEntityModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MusicType",
                table: "Clubs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Links",
                table: "Clubs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Clubs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "ClubAddress",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "ClubAddress");

            migrationBuilder.AlterColumn<string>(
                name: "MusicType",
                table: "Clubs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Links",
                table: "Clubs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
