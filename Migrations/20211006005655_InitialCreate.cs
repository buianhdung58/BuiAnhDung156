using Microsoft.EntityFrameworkCore.Migrations;

namespace BuiAnhDung156.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BAD0156",
                columns: table => new
                {
                    NVNId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    NVNName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NVNGender = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAD0156", x => x.NVNId);
                });

            migrationBuilder.CreateTable(
                name: "PersonBAD156",
                columns: table => new
                {
                    PersonId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonBAD156", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BAD0156");

            migrationBuilder.DropTable(
                name: "PersonBAD156");
        }
    }
}
