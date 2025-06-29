using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_portfolio_api.Migrations
{
    /// <inheritdoc />
    public partial class AddFormations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ecole = table.Column<string>(type: "TEXT", nullable: false),
                    DateDebut = table.Column<int>(type: "INTEGER", nullable: false),
                    DateFin = table.Column<int>(type: "INTEGER", nullable: false),
                    Intitule = table.Column<string>(type: "TEXT", nullable: false),
                    Ville = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formations");
        }
    }
}
