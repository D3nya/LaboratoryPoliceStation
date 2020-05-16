using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliceStation.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PoliceStations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    AdmArea = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ExtraInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoliceStations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "District", "ExtraInfo", "Name" },
                values: new object[] { 1L, "Шубинский переулок, дом 7", "Центральный административный округ", "район Арбат", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktn…", "Участковый пункт полиции № 1 по району Арбат" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PoliceStations");
        }
    }
}
