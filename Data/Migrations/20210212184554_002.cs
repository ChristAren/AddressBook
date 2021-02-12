using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AddressBook.Data.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Overview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    PersonalEmail = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    WorkEmail = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    MobilePhone = table.Column<string>(type: "text", nullable: false),
                    WorkPhone = table.Column<string>(type: "text", nullable: true),
                    HomePhone = table.Column<string>(type: "text", nullable: true),
                    Address1 = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Address2 = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    City = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    State = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Zip = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Company = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Fax = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Overview", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Overview");
        }
    }
}
