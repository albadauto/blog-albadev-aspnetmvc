using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogDoDautin.Migrations
{
    public partial class RenovateAuthorNewsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "News");
        }
    }
}
