using Microsoft.EntityFrameworkCore.Migrations;

namespace Bidder.Business.Migrations
{
    public partial class AddWeaponNumberOfCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfCandidate",
                table: "Weapons",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfCandidate",
                table: "Weapons");
        }
    }
}
