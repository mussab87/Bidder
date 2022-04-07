using Microsoft.EntityFrameworkCore.Migrations;

namespace Bidder.Business.Migrations
{
    public partial class RemoveNumberOfCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfCandidate",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfCandidate",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
