using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliceStations.WebService.Migrations
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
                    Address = table.Column<string>(nullable: true),
                    ExtraInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoliceStations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 1L, "Шубинский переулок, дом 7", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 1 по району Арбат" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 537L, "Кутузовский проспект, дом 43", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7 по району Дорогомилово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 538L, "улица Дениса Давыдова, дом 7", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №8 по району Дорогомилово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 539L, "улица Студенческая, дом 22, корпус 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №9 по району Дорогомилово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 540L, "Бережковская набережная, дом 10", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №10 по району Дорогомилово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 541L, "Осенний бульвар, дом 10, корпус 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №12 по району Крылатское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 542L, "Рублевское шоссе, дом 34, корпус 1", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №14 по району Крылатское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 543L, "улица Крылатская, дом 31, корпус 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №15 по району Крылатское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 544L, "Осенний бульвар, дом 18, корпус 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №16 по району Крылатское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 545L, "Осенний бульвар, дом 5, корпус 3", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №18 по району Крылатское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 546L, "3-й Сетуньский проезд, дом 3, квартира 123", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №58 по району Раменки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 547L, "улица Мосфильмовская, дом 30, квартира 16", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №59 по району Раменки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 548L, "Университетский проспект, дом 21, корпус 3, квартира 98", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №60 по району Раменки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 549L, "Мичуринский проспект, дом 25, корпус 3", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №61 по району Раменки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 550L, "Мичуринский проспект, дом 52", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №62 по району Раменки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 551L, "Мичуринский проспект, дом 37", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №63 по району Раменки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 552L, "улица Лобачевского, дом 100, корпус 3, квартира 702", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №64 по району Раменки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 553L, "улица Озерная, дом 10", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №45 по району Очаково-Матвеевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 554L, "улица Озерная, дом 31, корпус 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №46 по району Очаково-Матвеевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 555L, "Очаковское шоссе, дом 15, корпус 1", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №48 по району Очаково-Матвеевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 556L, "улица Матвеевская, дом 42, корпус 3, квартира 255", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №49 по району Очаково-Матвеевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 557L, "улица Нежинская, дом 13, квартира 706", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №51 по району Очаково-Матвеевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 536L, "Кутузовский проспект, дом 4/2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Дорогомилово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 558L, "улица Веерная, дом 3, корпус 2, квартира 289", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №52 по району Очаково-Матвеевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 535L, "улица Большая Дорогомиловская, дом 4", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Дорогомилово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 533L, "улица Большая Филевская, дом 23, корпус 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №85 по району Филевский Парк" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 512L, "улица Ельнинская, дом 1, корпус 1", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №24 по району Кунцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 513L, "улица Кунцевская, дом 4, корпус 1", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №25 по району Кунцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 514L, "Рублевское шоссе, дом 14, корпус 3", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №27 по району Кунцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 515L, "улица Советская, дом 11А", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №28 по району Кунцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 516L, "улица Петра Алексеева, дом 3", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №30 по району Можайский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 517L, "улица Сафоновская, дом 17", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №31 по району Можайский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 518L, "улица Гвардейская, дом 6", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №32 по району Можайский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 519L, "улица Витебская, дом 3 (прием граждан осуществляется по адресу: улица Беловежская, дом 37)", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №33 по району Можайский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 520L, "Сколковское шоссе, дом 32", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №34 по району Можайский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 521L, "улица Барвихинская, дом 4, корпус  2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №35 по району Можайский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 522L, "улица Беловежская, дом 37", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №36 по району Можайский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 523L, "улица Толбухина, дом 8", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №37 по району Можайский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 524L, "улица Гришина, дом 21, корпус 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №38 по району Можайский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 525L, "улица Малая Филевская, дом 8, корпус 1", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №87 по району Фили-Давыдково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 526L, "улица Кастанаевская, дом 27, строение 9", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 88 по району Фили-Давыдково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 527L, "улица Кастанаевская, дом 62", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №89 по району Фили-Давыдково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 528L, "улица Кременчугская, дом 7, корпус 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №90 по району Фили-Давыдково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 529L, "улица Инициативная, дом 5, корпус 1", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №91 по району Фили-Давыдково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 530L, "улица Давыдковская, дом 6", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №92 по району Фили-Давыдково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 531L, "Филевский бульвар, дом 40", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №83 по району Филевский Парк" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 532L, "улица Олеко Дундича, дом 5", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №84 по району Филевский Парк" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 534L, "улица Заречная, дом 7", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №86 по району Филевский Парк" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 559L, "улица Веерная, дом 28, корпус 2, квартира 42", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №53 по району Очаково-Матвеевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 560L, "проспект Вернадского, дом 49", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №55 по району Проспект Вернадского" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 561L, "проспект Вернадского, дом 22", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №56 по району Проспект Вернадского" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 588L, "улица Лодочная, дом 9, корпус 4", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №62 по району Южное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 589L, "улица Габричевского, дом 8, корпус 1", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №17 по району Покровское-Стрешнево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 590L, "улица Тушинская, дом 9", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №18 по району Покровское-Стрешнево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 591L, "улица Подмосковная, дом 14", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №19 по району Покровское-Стрешнево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 592L, "Волоколамский проезд, дом 1", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №20 по району Покровское-Стрешнево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 593L, "улица Твардовского, дом 18, корпус 5, квартира 175", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №42 по району Строгино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 594L, "Неманский проезд, дом 3, квартира 252", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №37 по району Строгино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 595L, "улица Кулакова, дом 15, квартира 4", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №38 по району Строгино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 596L, "улица Исаковского, дом 14, корпус 1, квартира 2", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №39 по району Строгино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 597L, "улица Исаковского, дом 28, корпус 2, квартира 768", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №40 по району Строгино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 598L, "Строгинский бульвар, дом 26, корпус 2, квартира 190А", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №41 по району Строгино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 599L, "улица Твардовского, дом 5, квартира 50", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №35 по району Строгино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 600L, "улица маршала Тухачевского, дом 22, корпус 3", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №47 по району Хорошево-Мневники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 601L, "проспект Маршала Жукова, дом 47, корпус 1", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №44 по району Хорошево-Мневники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 602L, "Новохорошевский проезд, дом 26", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №45 по району Хорошево-Мневники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 603L, "Новохорошевский проезд, дом 26", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №46 по району Хорошево-Мневники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 604L, "проспект Маршала Жукова, дом 31", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №43 по району Хорошево-Мневники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 605L, "бульвар Генерала Карбышева дом 19,  корпус 2", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №48 по району Хорошево-Мневники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 606L, "Набережная Новикова Прибоя,  дом 7, корпус 2", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №49 по району Хорошево-Мневники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 607L, "улица Авиационная, дом 68", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №50 по району Щукино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 608L, "улица Ирины Левченко, дом 2.", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №53  по району Щукино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 587L, "улица Туристская, дом 1", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №60 по району Южное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 586L, "улица Нелидовская, дом 18", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №58 по району Южное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 585L, "улица Сходненская, дом 46/14", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №57 по району Южное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 584L, "улица Планерная, дом 12, корпус 5, квартира 146", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №33 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 562L, "улица Лобачевского, дом 92, корпус 6", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №57 по району Проспект Вернадского" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 563L, "проспект Вернадского, дом 119", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №75 по району Тропарево-Никулино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 564L, "улица 26-ти Бакинских Комиссаров, дом 3, корпус 3", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №76 по району Тропарево-Никулино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 565L, "проспект Вернадского, дом 101, корпус 8", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №77 по району Тропарево-Никулино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 566L, "улица Академика Анохина, дом 38, корпус 4", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №80 по району Тропарево-Никулино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 567L, "улица Академика Анохина, дом 4, корпус 1", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №79 по району Тропарево-Никулино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 568L, "Мичуринский проспект, Олимпийская деревня, дом 10", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №81 по району Тропарево-Никулино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 569L, "проспект Вернадского, дом 89, корпус 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №78 по району Тропарево-Никулино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 570L, "улица Новопеределкинская, дом 8", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №39 по району Ново-Переделкино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 571L, "улица Новопеределкинская, дом 8", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №44 по району Ново-Переделкино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 511L, "улица Ельнинская, дом 20, корпус 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №23 по району Кунцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 572L, "Боровское шоссе, дом 30", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №40 по районуНово-Переделкино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 574L, "улица Шолохова, дом 28", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №42 по району Ново-Переделкино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 575L, "улица Скульптора Мухиной, дом 7/2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №43 по району Ново-Переделкино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 576L, "улица Интернациональная, дом 2/1", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Внуково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 577L, "улица Плотинная, дом 1/1", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Внуково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 578L, "улица Фомичёвой, дом 3, квартира 325", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №22 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 579L, "улица Туристская, дом 12, корпус 1", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №24 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 580L, "бульвар Яна Райниса, дома 14, корпус 1, квартира 45", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №27 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 581L, "улица Героев Панфиловцев, дом 22, корпус 1, квартира 194", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №29 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 582L, "улица Виллиса Лациса, дом 11, корпус 3, квартира 30", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №30 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 583L, "улица Фомичёвой, дом 16, корпус 2, квартира 1", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №32 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 573L, "улица Скульптора Мухиной, дом 12", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №41 по району Ново-Переделкино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 510L, "улица Бобруйская, дом 10, корпус 1", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №22 по району Кунцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 509L, "улица Партизанская, дом 35", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №21 по району Кунцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 508L, "улица Ярцевская, дом 23, квартира 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №19 по району Кунцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 436L, "Нахимовский проспект, дом 23, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №34 по району Котловка" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 437L, "улица Косыгина, дом 5", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7 по району Гагаринский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 438L, "Ленинский проспект, дом 39", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №8 по району Гагаринский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 439L, "Университетский проспект, дом 5", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №9 по району Гагаринский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 440L, "улица Вавилова, дом 60, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №10 по району Гагаринский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 441L, "улица Строителей, дом 4, корпус 3", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №11 по району Гагаринский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 442L, "Ломоносовский проспект, дом 7, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №12 по району Гагаринский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 443L, "улица Ратная, дом 10, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №48 по району Северное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 444L, "улица Куликовская, дом 7", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №49 по району Северное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 445L, "бульвар Дмитрия Донского, дом 16", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №50 по району Северное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 446L, "улица Грина, дом 3, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №51 по району Северное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 447L, "бульвар ДмитрияДонского, дом 9, корпус 3", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №52 по району Северное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 448L, "Севастопольский проспект, дом 65/15", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №13 по району Зюзино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 449L, "улица Одесская, дом 23, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №14 по району Зюзино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 450L, "улица Херсонская, дом 9, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №15 по району Зюзино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 451L, "улица Каховка, дом 11, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №16 по району Зюзино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 452L, "Балаклавский проспект, дом 20, корпус 4", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №17 по району Зюзино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 453L, "улица Азовская, дом 13", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №18 по району Зюзино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 454L, "Симферопольский проспект, дом 24, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №19 по району Зюзино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 455L, "улица Профсоюзная, дом 130, корпус 4", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №53 по району Теплый Стан" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 456L, "улица Профсоюзная, дом 138", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №54 по району Теплый Стан" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 435L, "Нагорный бульвар, дом 20", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №33 по району Котловка" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 434L, "улица Нагорная, дом 17, корпус 5", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №32 по району Котловка" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 433L, "улица Большая Черемушкинская, дом 3, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №31 по району Котловка" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 432L, "улица Вильнюсская, дом 17", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №92 по району Ясенево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 410L, "улица Шверника, дом 13, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Академический" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 411L, "улица Ферсмана, дом 11, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Академический" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 412L, "улица Новочеремушкинская, дом 3А, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Академический" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 413L, "улица Профсоюзная, дом 18, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Академический" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 414L, "улица Кржижановского, дом 26", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Академический" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 415L, "проспект 60-летия Октября, дом 29, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Академический" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 416L, "улица Строителей, дом 11, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №35 по району Ломоносовский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 417L, "Ленинский проспект, дом 81", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №36 по району Ломоносовский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 418L, "Ленинский проспект, дом 82", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №37 по району Ломоносовский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 419L, "улица Марии Ульяновой, дом 8", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №38 по району Ломоносовский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 457L, "улица Теплый Стан, дом 9, корпус 4", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №55 по району Теплый Стан" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 420L, "Ленинский проспект, дом 91", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №39 по району Ломоносовский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 422L, "проспект Вернадского, дом 27", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №41 по району Ломоносовский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 423L, "улица Голубинская, дом 3, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №83 по району Ясенево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 424L, "улица Голубинская, дом 3, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №84 по району Ясенево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 425L, "улица Вильнюсская, дом 7, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №85 по району Ясенево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 426L, "Литовский бульвар, дом 6, корпус 3", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №86 по району Ясенево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 427L, "Литовский бульвар, дом 11, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №87 по району Ясенево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 428L, "Новоясеневский проспект, дом 19, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №88 по району Ясенево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 429L, "улица Паустовского, дом 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №89 по району Ясенево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 430L, "улица Ясногорская, дом 13, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №90 по району Ясенево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 431L, "проезд Карамзина, дом 13, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №91 по району Ясенево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 421L, "Ленинский проспект, дом 88, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №40 по району Ломоносовский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 609L, "улица Маршала Василевского,  дом 1, корпус 2", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №51  по району Щукино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 458L, "улица Генерала Тюленева, дом 35", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №56 по району Теплый Стан" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 460L, "улица Теплый Стан, дом 21, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №58 по району Теплый Стан" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 487L, "Чечерский проезд, дом 112", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №74 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 488L, "улица Аллея Витте, дом 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №75 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 489L, "улица Адмирала Лазарева, дом 57", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №76 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 490L, "улица Южнобутовская, дом 12", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №77 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 491L, "улица Академика Понтрягина, дом 27", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №78 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 492L, "улица Адмирала Лазарева, дом 39", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №79 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 493L, "улица Адмирала Лазарева, дом 30, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №80 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 494L, "улица Маршала Савицкого, дом 8", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №81 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 495L, "улица Новаторов, дом 4, корпус 3", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №42 по району Обручевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 496L, "улица Обручева, дом 16, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №43 по району Обручевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 497L, "улица Гарибальди, дом 26, корпус 5", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №44 по району Обручевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 498L, "улица Академика Челомея, дом 8А", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №45 по району Обручевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 499L, "улица Саморы Машела, дом 4, корпус 3", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №46 по району Обручевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 500L, "улица Обручева, дом 28, корпус 7", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №47 по району Обручевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 501L, "улица Авиаторов, дом 6, корпус 2, квартира 2", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №66 по району Солнцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 502L, "улица Наро-Фоминская, дом 15, квартира 52", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №67 по району Солнцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 503L, "улица 50 лет Октября, дом 23, корпус 1, квартира 111", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №69 по району Солнцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 504L, "Солнцевский проспект, дом 23", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №71 по району Солнцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 505L, "улица Богданова, дом 48, корпус 3", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №72 по району Солнцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 506L, "улица Главмосстроя, дом 9", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №73 по району Солнцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 507L, "улица Родниковая, дом 10", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №68 по району Солнцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 486L, "улица Скобелевская, дом 1, корпус 6", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №73 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 485L, "улица Старонародная, дом 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №72 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 484L, "улица Южнобутовская, дом 81", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №71 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 483L, "улица Южнобутовская, дом 51", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №70 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 461L, "улица Академика Варги, дом 4", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №59 по району Теплый Стан" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 462L, "улица Теплый Стан, дом 12, корпус 4", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №60 по району Теплый Стан" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 463L, "Ленинский проспект, дом 129", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №61 по району Теплый Стан" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 464L, "улица Островитянова, дом 34, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №20 по району Коньково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 465L, "улица Островитянова, дом 31", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №21 по району Коньково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 466L, "улица Генерала Антонова, дом 7, корп. 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №22 по району Коньково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 467L, "улица Генерала Антонова, дом 4, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №23 по району Коньково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 468L, "улица Бутлерова, дом 40, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №24 по району Коньково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 469L, "улица Островитянова, дом 53", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №25 по району Коньково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 470L, "улица Миклухо-Маклая, дом 39, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №27 по району Коньково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 459L, "улица Генерала Тюленева, дом 25", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №57 по району Теплый Стан" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 471L, "улица Миклухо-Маклая, дом 39, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №26 по району Коньково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 473L, "улица Островитянова, дом 29/120", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №29 по району Коньково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 474L, "улица Профсоюзная, дом 93, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №30 по району Коньково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 475L, "улица Профсоюзная, дом 30, корпус 3", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №62 по району Черемушки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 476L, "улица Обручева, дом 55А", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №63 по району Черемушки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 477L, "улица Гарибальди, дом 27, корпус 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №64 по району Черемушки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 478L, "улица Профсоюзная, дом 30, корпус 3", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №65 по району Черемушки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 479L, "Севастопольский проспект, дом 30", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №66 по району Черемушки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 480L, "улица Новочеремушкинская, дом 64, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №67 по району Черемушки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 481L, "бульвар Адмирала Ушакова, дом 2", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №68 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 482L, "улица Веневская, дом 10", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №69 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 472L, "улица Миклухо-Маклая, дом 20", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №28 по району Коньково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 610L, "улица Маршала Новикова, дом 18", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №55 по району Щукино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 611L, "улица Рогова, дом 24", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №56  по району Щукино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 612L, "улица Маршала Бирюзова, дом 26", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №54  по району Щукино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 741L, " поселок Птичное, улица Центральная, дом 100", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №21 г.о. Троицк" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 742L, @"г. Москва, ул. Главмосстроя, д.22, корп.1, 1 этаж
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 74 по району Солнцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 743L, @"г. Москва, ул. Матросова, д.1, кв.2, 1 этаж
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 70 по району Солнцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 744L, @"г. Москва, ул. Полярная, д.52, к.4
", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 73 по району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 745L, @"г. Москва, Мичуринский пр-т, д.9
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 65 по району Раменки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 746L, @"г. Москва, п. Кленовское, п. Кленово, ул. Центральная, стр. 8
", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", @"Участковый пункт полиции № 11 МО МВД России ""Куриловское""
" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 747L, @"Г. Москва, п. Щаповское, п. Щапово, д. 51
", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 10 МО МВД России \"Куриловское\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 748L, @"г. Москва, п. Вороновское, п. Дом отдыха Вороново, дом 31, стр. 1
", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", @"Участковый пункт полиции № 9 МО МВД России ""Красносельское""
" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 749L, @"Г. Москва, п. Михайлово-Ярцевское, п. Шишкин Лес, д. 7, кв. 4
", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", @"Участковый пункт полиции № 8 МО МВД России ""Красносельское""
" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 750L, @"г. Москва, п. Краснопахорское, с. Красная Пахра, ул Заводская, д. 15
", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", @"Участковый пункт полиции № 7 МО МВД России ""Красносельское""
" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 751L, @"г.Москва, пос. Сосенское, п. Коммунарка, д. 20
", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 6 МО МВД России \"Коммунарский\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 752L, @"г. Москва, пос. Сосенское, ул. Александры Монаховой, д.105 (не открыт)
", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 5 МО МВД России \"Коммунарский\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 753L, @"г. Москва, пос. Воскресенское, Чечерский пр-д дом 126, корп. 1
", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 МО МВД России \"Коммунарский\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 754L, @"г. Москва, Никулинская ул., д.11
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 82 по району Тропарево-Никулино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 755L, @"г. Москва, ул. Веерная, д.12, корп.2, кв.1, 1 этаж
", "Западный административный округ", @"
ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 54 по району Очаково-Матвеевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 756L, @"г. Москва, Кутузовский пр-т, д.26
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 6 по району Дорогомилово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 757L, @"г. Москва, Резервный пр-д, д.2/8
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 11 по району Дорогомилово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 758L, @"г. Москва, ул. Крылатские холмы, д.21, 1 этаж
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 13 по району Крылатское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 759L, @"г. Москва, ул. Крылатские Холмы, д.35, корп.2, 1 этаж
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 17 по району Крылатское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 760L, @"г. Москва, ул. Академика Павлова, д.26
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 20 по району Кунцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 761L, @"г. Москва, ул. Ивана Франко, д.22, корп.4
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 26 по району Кунцево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 740L, "улица Кусковская, дом 17, корп. 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №61 по району Новогиреево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 739L, "поселок Вороновское, дом отдыха \"Вороново\", дом 31, строение 1", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №9 поселения Вороновское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 738L, "поселок Шишкин Лес, дом 7, квартира 4", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №8 поселения Михайлово-Ярцевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 737L, "село Красная Пахра, улица Заводская, дом 15", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7 поселения Краснопахорское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 715L, "корпус 1639", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Крюково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 716L, "корпус 1820", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Крюково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 717L, "корпус 2010", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Крюково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 718L, "улица Заводская, дом 10", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 7 по району Крюково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 719L, "улица Полковника Милиции Курочкина, дом 11", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №24 поселения Троицк" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 720L, "улица Солнечная, дом 10", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №19 поселения Троицк" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 721L, "улица Школьная, дом 1", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №20 поселения Троицк" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 722L, "улица Нагорная, дом 8", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №25 поселения Троицк" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 723L, "деревня Зверево, ЖК \"Борисоглебская\"", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №26 поселения Новофедоровское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 724L, "поселение Киевский, дом 24", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №23 поселения Киевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 762L, @"г. Москва, мкрн. Ленинские Горы, д.1 корп.Б, каб.17
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 29 по МГУ" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 725L, "поселение «Мосрентген», дом 32А", "Новомосковский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 поселения \"Мосрентген\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 727L, "поселок Десеновское, улица Д. Кабалевского, дом 18, корпус 1", "Новомосковский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 поселения Десеновское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 728L, "деревня Внуково, дом 50", "Новомосковский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №16 поселения Внуковское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 729L, "улица Ленина, дом 4", "Новомосковский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №14 поселения Кокошкино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 730L, "улица Пушкинская, дом 8", "Новомосковский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №27 поселения Щербинка" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 731L, "улица квартал Южный, дом 2", "Новомосковский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №29 поселения Щербинка" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 732L, "улица Астафьевская, дом 10", "Новомосковский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №28 поселения Щербинка" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 733L, "Поселок Ерино, улица Высотная, дом 2", "Новомосковский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №31 поселения Рязановское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 734L, "поселок Щапово, дом 51", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №10 поселения Щаповское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 735L, "поселок Кленово, улица Центральная, дом 8", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №11 поселения Кленовское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 736L, "поселок Рогово, улица Школьная, дом 3А", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №12 поселения Роговское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 726L, "поселение Воскресенское, дом 39", "Новомосковский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 поселения Воскресенское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 714L, "корпус 1529", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Крюково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 763L, @"г. Москва, ул. Елены Колесовой, д.4, 1 этаж
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 47 по району Очаково-Матвеевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 765L, @"г. Москва, ул. Центральная, д.21
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 3 по району Внуково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 792L, "г. Москва, ул. Соколово-Мещерская, д.24, каб.119", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Куркино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 793L, "г. Москва, ул. Донская д.6", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №74 по району Якиманка" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 794L, "   ул. Братеевская, д.16, корп.1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Братеево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 795L, "г. Москва, ул. Крымский Вал, д.8", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №73 по району Якиманка" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 796L, "УПП 37, г. Москва, Югорский пр-д, д.6", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №84 по району Ярославский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 797L, "  ул. Борисовские Пруды, д.46, корп.2", "Южный административный округ", @"
ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija
", "Участковый пункт полиции №6 по району Братеево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 798L, "г. Москва, ул. Б. Косинская, д.1А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №54 по району Косино-Ухтомский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 799L, "г. Москва, ул. Грузинский Вал, д.26", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №41 по району Пресненский " });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 800L, "г. Москва, ул. Ибрагимова, д.5, корп.1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №95 по району Соколиная Гора" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 801L, "г. Москва, ул. Героев Панфиловцев, д.19, кв.108", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №25 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 802L, "г. Москва, ул. 9 Мая, д.12А", "Восточный административный округ", @"
ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija
", "Участковый пункт полиции №21 по району Восточный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 803L, "г. Москва, ул. Малая Полянка, д.4/6", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №72 по району Якиманка" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 804L, "г. Москва, ул. Героев Панфиловцев, д.6 корп.1 кв.40", "Северо-Западный административный округ", @"
ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija
", "Участковый пункт полиции №23 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 805L, "г. Москва, Измайловское ш., д.55", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №96 по району Соколиная Гора" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 806L, "г. Москва, ул. Соколово-Мещерская, д.14/116", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Куркино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 807L, "г. Москва, Челобитьевское ш., д.2, корп. 1. ", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №77 по району Северный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 808L, "г. Москва, ул. Проходчиков, д.12", "Северо-Восточный административный округ", @"ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija
", "Участковый пункт полиции №85 по району Ярославский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 809L, "г. Москва, 1-й Тушинский пр-д., д.7", "Северо-Западный административный округ", @"
ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija
", "Участковый пункт полиции №21 по району Покровское-Стрешнево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 810L, "г. Москва, пр-т Буденного, д.22, корп.1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №91 по району Соколиная Гора" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 811L, "г. Москва, ул. Бориса Жигуленкова, д.2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №92 по району Соколиная Гора" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 812L, "г. Москва, п. Акулово, д.1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №21а" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 791L, "г. Москва, Новокуркинское ш., д.51", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Куркино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 790L, "г. Москва, ул. Вилиса Лациса, д.3, корп.1 кв.1", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №31  по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 789L, "г. Москва, ул. Хачатуряна, д.2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №58 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 788L, "г. Москва, Нащокинский пер., д.6", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №71 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 766L, @"г. Москва, ул. Кухмистерова, д.3, корп.1
", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №44 по району Печатники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 767L, @"г. Москва, Капотня, 3-й квартал, д.4, кв. 3
", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 10 по району Капотня" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 768L, @"г. Москва, Генерала Кузнецова, д.26, корп.3
", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 61 по ОП Жулебинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 769L, @"г. Москва, пр-д Шокальского, д.28А
", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 72 по району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 770L, "г. Москва, Неманский пр-д., д.7, корп.2", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №36 по району Строгино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 771L, "г. Москва, Светлогорский пр-д, д.7", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №59 по району Южное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 772L, "г. Москва, п. Роговское, п. Рогово, ул. Школьная, д. 3а", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 12 МО МВД России \"Куриловское\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 773L, "г. Москва, ул. Свободы, д.89, кв.5", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №34 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 774L, "г. Москва, пос. Рязановское, п. Фабрика, имени 1-мая, д. 5", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № МО МВД России \"Щербинский\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 775L, "г. Москва, ул. М. Тухачевского, д. 22, корп. 3", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №47 по району Хорошево-Мневники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 764L, @"г. Москва, ул. Матвеевская, д.28
", "Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 50 по району Очаково-Матвеевское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 776L, "г. Москва, г. Щербинка, ул. Барыщевская Роща, д. 2", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №30 МО МВД России \"Щербинский\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 778L, "г. Москва, ул. Василия Петушкова, д.19", "Северо-Западный административный округ", @"
ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija
", "Участковый пункт полиции №61 по району Южное Тушино " });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 779L, "г. Москва. П.Марушкинское, п.Марушкино, ул. Липовая аллея, д.5", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №15 МО МВД России \"Московский\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 780L, "г. Москва, пос. Внуковское, мкр. Солнцево-парк, ул. Авиаконструктора Пелякова дом 13, корп. 1", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №13 МО МВД России \"Московский\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 781L, "г. Москва, г. Московский, 3-й мкр, д.21", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №17 МО МВД России \"Московский\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 782L, "г. Москва, ул. Свободы, д.53", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №63 по району Южное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 783L, "г. Москва, ул. Доватора, д.3", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №69 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 784L, "г. Москва, ул. Хачатуряна, д.2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 785L, "г. Москва, ул. Остроженка, д.7", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №70 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 786L, "г. Москва, ул. Героев Панфиловцев, д.27, корп.4, кв.404", "Северо-Западный административный округ", @" 
ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija
", "Участковый пункт полиции №28 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 787L, "г. Москва, ул. Героев Панфиловцев д.1 кв.5", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №26 по району Северное Тушино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 777L, "г. Москва, пос. Марьино, д. 3", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №18 МО МВД России \"Московский\"" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 409L, "Варшавское шоссе, дом 152, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №8 по району Чертаново Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 713L, "корпус 1455", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Крюково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 711L, "корпус 1137", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №19 по району Силино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 639L, "5-ый Войковский проезд, дом 2", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №13 по району Войковский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 640L, "улица Зои и Александра Космодемьянских, дом 4", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №14 по району Войковский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 641L, "Ленинградское шоссе, дом 36, корпус 2", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №15 по району Войковский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 642L, "3-й Новоподмосковный переулок, дом 6", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 16 по району Войковский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 643L, "улица Дубнинская, дом 10, корпус 2", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №17 по району Восточное Дегунино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 644L, "улица Дубнинская, дом 20, корпус 2", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №18 по району Восточное Дегунино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 645L, "Керамический проезд, дом 45, корпус 1", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №19 по району Восточное Дегунино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 646L, "улица Дубнинская, дом 34, корпус 1", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №20 по району Восточное Дегунино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 647L, "Керамический проезд, дом 71, корпус 1", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №21 по району Восточное Дегунино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 648L, "улица Фестивальная, дом 38", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №22 по району Головинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 649L, "улица Флотская, дом 82/6", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №23 по району Головинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 650L, "Ленинграское шоссе, дом 66", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №24 по району Головинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 651L, "улица Смольная, дом 11/13", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №25 по району Головинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 652L, "Крондштадский бульвар, дом 37В", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №26 по району Головинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 653L, "3-ий Лихачёвский переулок, дом 2, корпус 2", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №27 по району Головинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 654L, "улица Яхромская, дом 4", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №28 по району Дмитровский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 655L, "улица 800-летия Москвы, дом 2, корпус 1", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №29 по району Дмитровский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 656L, "Коровинское шоссе, дом 22", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №30 по району Дмитровский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 657L, "улица Долгопрудная, дом 9", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №31 по району Дмитровский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 658L, "улица Клязьминская, дом 19", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №32 по району Дмитровский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 659L, "улица Ангарская, дом 45, корпус 2", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №33 по району Дмитровский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 638L, "Коровинское шоссе, дом 6", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №12 по району Бескудниковский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 637L, "Бескудниковский бульвар, дом 32, корпус 6", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №11 по району Бескудниковский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 636L, "улица Дубнинская, дом 27, корпус 2", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №10 по району Бескудниковский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 635L, "улица Дубнинская, дом 3", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №9 по району Бескудниковский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 613L, "улица Маршала Мерецкова, дом 5", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №52  по району Щукино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 614L, "Пятницкое шоссе, дом 11, квартира 331", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5  по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 615L, "Пятницкое шоссе, дом 41", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 616L, "Пятницкое шоссе, дом 40", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7  по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 617L, "Ангелов переулок, дом 1", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №8  по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 618L, "улица Митинская, дом 40, корпус 1", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №9 по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 619L, "улица Митинская, дом 27", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №10  по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 620L, "улица Митинская, дом 31", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №11 по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 621L, "улица Митинская, дом 44", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №12 по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 622L, "Пятницкое шоссе, дом 6", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №13 по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 660L, "улица Ивана Сусанина, дом 2, корпус 1", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №34 по району Западное Дегунино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 623L, "улица Генерала Белобородова, дом 19, корпус 1", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №14 по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 625L, "улица Барышиха, дом 21", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №16 по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 626L, "улица Воротынская, дом 16", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1  по району Куркино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 627L, "Ленинградский проспект, дом 74, корпус 6", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Аэропорт" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 628L, "улица Красноармейская, дом 9", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Аэропорт" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 629L, "улица Планетная, дом 11", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Аэропорт" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 630L, "Малый Коптевский проезд, дом 4/6", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Аэропорт" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 631L, "Малый Коптевский проезд, дом 4/6", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Аэропорт" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 632L, "1-й Боткинский проезд, дом 4", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Беговой" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 633L, "Беговая Аллея, дом 3", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7 по району Беговой" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 634L, "Ленинградский проспект, дом 14, строение 3", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №8 по району Беговой" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 624L, "Волоцкой переулок, дом 13", "Северо-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №15 по району Митино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 712L, "корпус 1424", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Крюково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 661L, "улица Ангарская, дом 22, корпус 5", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №35 по району Западное Дегунино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 663L, "улица Бусиновская Горка, дом 1, корпус 1", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №37 по району Западное Дегунино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 690L, "улица Фестивальная, дом 14, корпус 1", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №64 по району Ховрино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 691L, "улица Лавочкиная, дом 44, корпус 1", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №65 по району Ховрино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 692L, "улица Дыбенко, дом 26, корпус 1", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №66 по району Ховрино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 693L, "улица Клинская, дом 19", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №67 по району Ховрино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 694L, "улица Зеленоградская, дом 33, корпус 1", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №68 по району Ховрино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 695L, "улица Куусинена, дом 4А, корпус 4", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №69 по району Хорошевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 696L, "улица Куусинена, дом 17", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №70 по району Хорошевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 697L, "улица Острякова, дом 6", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №71 по району Хорошевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 698L, "Хорошевское шоссе, дом 11", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №72 по району Хорошевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 699L, "корпус 119", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №8 по району Матушкино и Савелки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 700L, "корпус 119", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №9 по району Матушкино и Савелки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 701L, "корпус 331", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №10 по району Матушкино и Савелки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 702L, "корпус 417", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №11 по району Матушкино и Савелки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 703L, "корпус 514А", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №12 по району Матушкино и Савелки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 704L, "корпус 602", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №13 по району Матушкино и Савелки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 705L, "корпус 834Б, квартира 1", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №14 по району Старое Крюково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 706L, "корпус 909, квартира 117", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №15 по району Старое Крюково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 707L, "корпус 1003, квартира 4", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №16 по району Силино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 708L, "корпус 1101", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №17 по району Силино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 709L, "корпус 1132", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №18 по району Силино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 710L, "корпус 1208, квартира 49", "Зеленоградский административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №20 по району Силино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 689L, "Лиственничная аллея, дом 14 (закрыт)", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 63 по району Тимирязевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 688L, "улица Астрадамская, дом 6", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №62 по району Тимирязевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 687L, "3-ий Нижнелихоборский проезд, дом 8", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №61 по району Тимирязевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 686L, "Дмитровское шоссе, дом 33, корпус 1", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №60 по району Тимирязевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 664L, "улица Зои и Александра Космодемьянских,  дом 42/19", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №38 по району Коптево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 665L, "улица Зои и Александра Космодемьянских, дом 39", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №39 по району Коптево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 666L, "улица Коптевская, дом 26, корпус 3", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №40 по району Коптево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 667L, "Михалковский переулок, дом 4А", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №41 по району Коптево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 668L, "улица Михалковская, дом 26, корпус 2", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №42 по району Коптево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 669L, "улица Большая Академическая, дом 79, корпус 4", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №43 по району Коптево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 670L, "улица Фестивальная, дом 9", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №44 по району Левобережный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 671L, "улица Смольная, дом 39", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №45 по району Левобережный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 672L, "Валдайский проезд, дом 6", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №46 по району Левобережный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 673L, "Охтинский проезд, дом 8", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №47 по району Молжаниновский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 662L, "улица Весенняя, дом 21", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №36 по району Западное Дегунино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 674L, "улица 2-я Квесисская, дом 25", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №48 по району Савеловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 676L, "улица Юннатов, дом 17, корпус 2 (закрыт)", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №50 по району Савеловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 677L, "улица Писцовая, дом 16, корпус 2", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №51 по району Савеловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 678L, "улица Бутырская, дом 93", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №52 по району Савеловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 679L, "улица Новопесчаная, дом 23", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №53 по району Сокол" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 680L, "улица Новопесчаная, дом 24", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №54 по району Сокол" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 681L, "улица Панфилова, дом 2 (закрыт)", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №55 по району Сокол" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 682L, "Волоколамское шоссе, дом 15/22", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №56 по району Сокол" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 683L, "улица Константина Царёва, дом 14", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №57 по району Сокол" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 684L, "улица Костякова, дом 8/6", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №58 по району Тимирязевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 685L, "улица Тимирязевская, дом 14", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №59 по району Тимирязевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 675L, "улица Бутырская, дом 3", "Северный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №49 по району Савеловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 408L, "Варшавское шоссе, дом 158, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7 по району Чертаново Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 407L, "улица Газопровод, дом 3, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Чертаново Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 406L, "улица Россошанская, дом 9, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Чертаново Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 130L, "3-й проезд Марьиной Рощи, дом 5", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №40 по району Марьина Роща" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 131L, "Старомарьинское шоссе, дом 18", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №41 по району Марьина Роща" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 132L, "улица Милашенкова, дом 18", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №21 по району Бутырский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 133L, "улица Милашенкова, дом 18", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №22 по району Бутырский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 134L, "улица Гончарова, дом 7А", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №23 по району Бутырский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 135L, "улица Милашенкова, дом 1", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №24 по району Бутырский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 136L, "улица Академика Королева, дом 8/2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №42 по району Останкинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 137L, "Звездный бульвар, дом 30/1", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №43 по району Останкинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 138L, "улица Цандера, дом 7", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №44 по району Останкинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 139L, "проезд Ольминского, дом 3", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №45 по району Останкинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 140L, "улица Годовикова, дом 2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №46 по району Останкинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 141L, "улица Инженерная, дом 15", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Алтуфьевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 142L, "улица Костромская, дом 4а", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Алтуфьевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 143L, "улица Снежная дом 4", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №62 по району Свиблово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 144L, "улица Снежная дом 13, корпус 1", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №63 по району Свиблово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 145L, "Берингов проезд, дом 3", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №64 по району Свиблово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 146L, "улица Вересковая, дом 1, корпус 1", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №65 по району Свиблово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 147L, "улица Малахитовая, дом 8, корпус 3", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №59 по району Ростокино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 148L, "улица Докукина, дом 5", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №60 по району Ростокино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 149L, "улица Сельскохозяйственная, дом 14", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №61 по району Ростокино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 150L, "улица Академика Комарова, дом 9", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №36 по району Марфино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 129L, "улица Стрелецкая,  дом 6", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №39 по району Марьина Роща" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 128L, "Октябрьский переулок, дом 13", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №38 по району Марьина Роща" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 127L, "проезд Дежнева, дом 25, корпус 1", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №82 по району Южное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 126L, "улица Сухонская, дом 5", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №81 по району Южное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 104L, "улица Абрамцевская, дом 8А", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №26 по району Лианозово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 105L, "улица Холмогорская, дом 7", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №83 по району Ярославский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 106L, "Ярославское шоссе, дом 134", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №86 по району Ярославский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 107L, "улица Палехская, дом 21", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №87 по району Ярославский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 108L, "улица Палехская, дом 7", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №88 по району Ярославский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 109L, "Ярославское шоссе, дом 16", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №89 по району Ярославский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 110L, "улица Изумрудная,  дом 32", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №31 по району Лосиноостровский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 111L, "улица Тайнинская,  дом 8", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №32 по району Лосиноостровский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 112L, "улица Стартовая,  дом 33", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №33 по району Лосиноостровский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 113L, "улица Малыгина,  дом 1,  корпус 2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №35 по району Лосиноостровский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 151L, "улица Комдива Орлова, дом 8", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №37 по району Марфино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 114L, "улица Ленская, дом 8, корпус 1", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7 по району Бабушкинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 116L, "Олонецкий проезд, дом 18, корпус 1", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №9 по району Бабушкинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 117L, "улица Летчика Бабушкина, дом 11/2, корпус 2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №10 по району Бабушкинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 118L, "улица Осташковская, дом 9, корпус1", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №11 по району Бабушкинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 119L, "улица Бориса Галушкина, дом 17", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Алексеевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 120L, "проспект Мира, дом 118", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Алексеевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 121L, "улица Павла Корчагина дом 16", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Алексеевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 122L, "улица Константинова, дом 11", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Алексеевский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 123L, "Ясный проезд, дом 5", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №78 по району Южное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 124L, "Ясный проезд, дом 8, корпус 1", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №79 по району Южное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 125L, "улица Полярная, дом 10", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №80 по району Южное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 115L, "улица Ленская, дом 28", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №8 по району Бабушкинский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 103L, "Алтуфьевское шоссе, дом 95Б", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №25 по району Лианозово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 152L, "улица 9-я Северная линия,  дом 1, корпус 1", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №76 по району Северный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 154L, "Заводской проезд, дом 25А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №49 по району Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 181L, "улица Уссурийская, дом 5, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №29 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 182L, "улица Красноярская, дом 13", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №30 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 183L, "улица Байкальская, дом 45", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №31 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 184L, "улица Байкальская, дом 29", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №32 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 185L, "улица Красноярская,  дом 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №33 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 186L, "улица Алтайская, дом 18", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №22 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 187L, "Федеративный проспект, дом 5,  корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №71 по району Перово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 188L, "улица 3-я Владимирская, дом 12, корп. 2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №72 по району Перово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 189L, "улица 2-я Владимирская, дом 5", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №73 по району Перово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 190L, "улица 1-я Владимирская, дом 22, корпус 2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №74 по району Перово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 191L, "улица Плющева, дом 18, корпус 2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №75 по району Перово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 192L, "улица Перовская, дом 33, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №76 по району Перово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 193L, "улица Плеханова, дом 26, корпус 4", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №77 по району Перово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 194L, "улица 13-я Парковая, дом 22, корпус 4", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №16 по району Восточное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 195L, "улица 16-я Парковая, дом 27", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №17 по району Восточное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 196L, "Измайловский проспект, дом 87", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №18 по району Восточное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 197L, "улица Первомайская, дом 110", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №19 по району Восточное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 198L, "улица 11-я Парковая, дом 24", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №20 по району Восточное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 199L, "улица Молостовых, дом 13, корпус 2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №35 по району Ивановское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 200L, "улица Сталеваров, дом 10, корпус 3", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №36 по району Ивановское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 201L, "шоссе Энтузиастов, дом 98А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №37 по району Ивановское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 180L, "улица Хабаровская, дом 23, корпус 2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №28 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 179L, "улица Байкальская, дом 44, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №27 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 178L, "Щелковское шоссе, дом 77", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №26 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 177L, "улица Уральская, дом 15", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №25 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 155L, "Измайловский бульвар, дом 36/27", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №42 по району Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 156L, "улица Верхняя Первомайская, дом 16", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №43 по району Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 157L, "улица Верхняя Первомайская, дом 23А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №44 по району Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 158L, "Измайловский проезд, дом 20, корпус 3", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №45 по району Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 159L, "Измайловский проезд, дом 6, корпус 3", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №46 по району Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 160L, "улица 2-я Прядильная, дом 5", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №47 по району Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 161L, "Открытое шоссе, дом 17, корпус 9", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №55 по району Метрогородок" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 162L, "Открытое шоссе, дом 24, корпус 13", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №56 по району Метрогородок" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 163L, "Открытое шоссе, дом 27, корпус 8", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №57 по району Метрогородок" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 164L, "улица Братская, дом 21, корпус1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №62 по району Новогиреево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 153L, "улица 3-я Парковая, дом 22А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №48 по району Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 165L, "Зеленый проспект, дом 50", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №63 по району Новогиреево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 167L, "Свободный проспект, дом 37, корпус 2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №59 по району Новогиреево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 168L, "улица Новогиреевская, дом 49/28", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №60 по району Новогиреево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 169L, "улица Буженинова, дом 22", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №78 по району Преображенский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 170L, "улица Просторная, дом 6", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №79 по району Преображенский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 171L, "улица Большая Черкизовская, дом 10, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №80 по району Преображенский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 172L, "улица Большая Черкизовская, дом 26, корп. 6", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №81 по району Преображенский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 173L, "улица Большая Черкизовская, дом 5, корпус 5", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №82 по району Преображенский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 174L, "Открытое шоссе, дом 2, корпус 3", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №83 по району Преображенский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 175L, "Щелковское шоссе, дом 19", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №23 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 176L, "улица Амурская, дом 62", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №24 по району Гольяново" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 166L, "Саперный проезд, дом 11", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №58 по району Новогиреево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 202L, "улица Челябинская, дом 8", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №38 по району Ивановское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 102L, "улица Абрамцевская, дом 9, корпус 3", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №30 по району Лианозово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 100L, "улица Псковская, дом 2, корпус 1", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №28 по району Лианозово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 28L, "Анадырский проезд, дом 63", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №34 по району Лосиноостровский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 29L, "удица Трехгорный Вал, дом 4, корпус 2", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №32 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 30L, "улица Красная Пресня, дом 44, корпус 3", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №35 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 31L, "улица Костикова, дом 5", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №36 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 32L, "Шмитовский проезд, дом 5", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №37 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 33L, "улица Подвойского, дом 20", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №38 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 34L, "Шелепихинское шоссе, дом 13", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №40 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 35L, "улица Большая Никитская, дом 22/2", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №34 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 36L, "улица Малая Бронная, дом 10", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №27 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 37L, "Большой Козихинский переулок, дом 23", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №39 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 38L, "улица Малая Никитская, дом 10", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №26 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 39L, "улица Большая Калитниковская, дом 42/5, строение 14", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №42 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 40L, "Волгоградский проспект, дом 7", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №43 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 41L, "улица Абельмановская, дом 6", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №44 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 42L, "Ковров переулок, дом 4, корпус 2", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №45 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 43L, "улица 1-я Дубровская, дом 5а", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №46 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 44L, "Краснохолмская набережная, дом 1/15", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №47 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 45L, "улица Гончарная, дом 26, корпус 1", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №48 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 46L, "2-ой крестовский проспект, дом 12", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №25 по району Мещанский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 47L, "Землянский переулок, дом 3", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №49 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 48L, "Большой Рогожский переулок, дом 10, строение 2", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №50 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 27L, "Тишинская площадь, дом 6, строение 1", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №31 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 26L, "улица Пресненский Вал, дом 38", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №30 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 25L, "улица Малая Грузинская, дом 38", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №29 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 24L, "Капельский переулок, дом 13", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №24 по району Мещанский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 2L, "Большой Николопесковский переулок, дом 3", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 2 по району Арбат" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 3L, "Новинский бульвар, дом 12", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 3 по району Арбат" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 4L, "1-й Басманный пер., д.12", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 4 по району Басманный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 5L, "Старосадский пер., д.10", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 5 по району Басманный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 6L, "Фурманный переулок, дом 13, с. 8", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 6 по району Басманный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 7L, "Лялин пер., д. 7/2, стр. 1", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 7 по району Басманный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 8L, "улица Садовая Черногрязская, дом 11/2", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 8 по району Басманный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 9L, "Лефортовский переулок, дом 12/50, стр. 2", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции № 9 по району Басманный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 10L, "улица Фридриха Энгельса, дом 37/41", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №10 по району Басманный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 11L, "улица Госпитальный Вал, дом 5, корпус 1", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №11 по району Басманный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 49L, "улица Библиотечная, дом 6", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №51 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 12L, "4-ый Сыромятнический переулок, дом 3/5", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №12 по району Басманный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 14L, "улица Павла Андреева, дом 28, корпус 2", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №14 по району Замоскворечье" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 15L, "Серпуховский переулок, дом 5", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №15 по району Замоскворечье" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 16L, "Климентовский переулок, дом 6", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №16 по району Замоскворечье" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 17L, "улица Пятницкая, дом 49", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №17 по району Замоскворечье" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 18L, "Даев переулок, дом 5", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №18 по району Красносельский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 19L, "улица Каланчаевская, дом 47", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №19 по району Красносельский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 20L, "улица Ольховская, дом 33", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №20 по району Красносельский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 21L, "3-й Красносельский переулок, дом 6", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №21 по району Красносельский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 22L, "Пушкарев переулок, дом 19", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №22 по району Мещанский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 23L, "переулок Васнецова, дом 3", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №23 по району Мещанский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 13L, "улица Большая Пионерская, дом 5", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №13 по району Замоскворечье" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 101L, "Алтуфьевское шоссе, дом 89А", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №29 по району Лианозово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 50L, "улица Новорогожская, дом 5", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №52 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 52L, "улица Новогорожская, дом 5", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №52 по району Таганский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 79L, "Алтуфьевское шоссе, дом 40Г", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №57 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 80L, "улица Мурановская, дом 3", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №12 по району Бибирево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 81L, "улица Лескова, дом 25", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №13 по району Бибирево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 82L, "улица Белозёрская, дом 9А", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №14 по району Бибирево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 83L, "улица Конёнкова, дом 9", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №15 по району Бибирево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 84L, "улица Плещеева, дом 3", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №16 по району Бибирево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 85L, "улица Плещеева, дом 20", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №17 по району Бибирево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 86L, "улица Лескова, дом 5", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №18 по району Бибирево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 87L, "улица Лескова, дом 6", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №19 по району Бибирево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 88L, "улица Коненкова, дом 15В", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №20 по району Бибирево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 89L, "проезд Шокальского, дом 59, корпус 2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №66 по району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 90L, "Студеный проезд, дом 32, корпус 2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №68 району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 91L, "Студеный проезд, дом 14", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №69 по району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 92L, "проезд Шокальского, дом 29, корпус 2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №70 по району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 93L, "проезд Шокальского, дом 29, корпус 2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №71 по району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 94L, "улица Осташковская, дом 30", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №67 по району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 95L, "улица Широкая, дом 8, корпус 2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №74 по району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 96L, "Студеный проезд, дом 14", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №75 по району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 97L, "проезд Шокальского, дом 28А", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №72 по району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 98L, "улица Полярная, дом 52, корпус 4", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №73 по району Северное Медведково" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 99L, "улица Угличская, дом 6", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №27 по району Лианозово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 78L, "улица Декабристов, дом 2, корпус 2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №56 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 77L, "Северный бульвар, дом 19", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №55 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 76L, "улица Санникова, дом 13", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №54 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 75L, "улица Декабристов, дом 20, корпус 2", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №53 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 53L, "улица Петровка, дом 26, стр. 2", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №53 по району Тверской" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 54L, "Лихов переулок, дом 5", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №54 по району Тверской" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 55L, "улица Долгоруковская, дом 35", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №55 по району Тверской" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 56L, "улица Новослободская, дом 10, строение 3", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №56 по району Тверской" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 57L, "улица Самотечная, дом 11", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №57 по району Тверской" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 58L, "Тихвинский переулок, дом 10/12, строение 1", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №58 по району Тверской" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 59L, "улица Петровка, дом 26, строение 2", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №59 по району Тверской" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 60L, "улица Плющиха, дом 43/47", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №60 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 61L, "улица Погодинская, дом 20, корпус 5", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №61 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 62L, "Пуговишников переулок, дом 8", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №62 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 51L, "улица Зоологическая, дом 30", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №28 по району Пресненский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 63L, @"Плющиха, д. 43/47
", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №63 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 65L, "Новодевичий проезд, дом 4", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №65 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 66L, "Комсомольский проспект, дом 7/3", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №66 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 67L, "Фрунзенская набережная, дом 42", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №67 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 68L, "Комсомольский проспект, дом 46", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №68 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 69L, "улица Пестеля, дом 4Б", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №47 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 70L, "улица Декабристов, дом 29А", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №48 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 71L, "улица Бестужевых, дом 17А", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №49 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 72L, "улица Бестужевых, дом 8Б", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №50 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 73L, "Алтуфьевское шоссе, дом 28", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №51 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 74L, "улица Отрадная, дом 16А", "Северо-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №52 по району Отрадное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 64L, "улица Тимура Фрунзе, дом 20, корпус 1", "Центральный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №64 по району Хамовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 813L, "г. Москва, д. Яковлевское, дом 31, участок 22", "Троицкий административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции района № 22 по району Троицк" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 203L, "улица Саянская, дом 11, корпус 2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №39 по району Ивановское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 205L, "Федеративный проспект, дом 48, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №41 по району Ивановское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 334L, "улица Борисовские Пруды, дом 12, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Братеево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 335L, "улица Борисовские Пруды, дом 22, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Братеево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 336L, "улица Братеевская, дом 21, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Братеево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 337L, "улица Братеевская, дом 10, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Братеево" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 338L, "улица Симоновский Вал, дом 8, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Даниловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 339L, "улица Ленинская Слобода, дом 4/10", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Даниловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 340L, "улица Сайкина, дом 6/5", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Даниловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 341L, "улица Малая Тульская, дом 2/1, корпус 20", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Даниловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 342L, "улица Шухова, дом 4", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Даниловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 343L, "улица Люсиновская, дом 66, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7 по району Даниловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 344L, "Даниловская набережная, дом 6/2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №8 по району Даниловский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 345L, "улица Шаболовка, дом 50", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Донской" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 346L, "улица Вавилова, дом 6", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Донской" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 347L, "Варшавское шоссе, дом 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Донской" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 348L, "Загородное шоссе,  дом 6, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Донской" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 349L, "Ореховый проезд, дом 35, корпус 3", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Зябликово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 350L, "улица Шипиловская, дом 41", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Зябликово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 351L, "улица Шипиловская, дом 53", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Зябликово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 352L, "улица Шипиловская, дом 64", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Зябликово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 353L, "Ореховый бульвар, дом 51", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Зябликово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 354L, "Каширское шоссе, дом 58, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Москворечье-Сабурово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 333L, "3-я Парковая улица, дом 44, корпус 3", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №87 по району Северное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 332L, "улица Булатниковская, дом 5, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Бирюлево Западное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 331L, "Востряковский проезд, дом 5, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Бирюлево Западное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 330L, "улица маршала Савицкого, дом 20, корпус 1", "Юго-Западный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №82 по району Южное Бутово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 308L, "улица Пронская, дом 3", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №63 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 309L, "улица Моршанская, дом 6", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №64 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 310L, "улица Авиаконструктора Миля, дом 1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №65 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 311L, "улица Генерала Кузнецова, дом 17", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №66 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 312L, "Марьинский бульвар, дом 3", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №67 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 313L, "улица Перерва, дом 56, корпус 1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №68 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 314L, "улица Поречная, дом 17/22", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №69 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 315L, "улица Поречная, дом 21", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №70 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 316L, "Мячковский бульвар, дом 9", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №71 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 317L, "улица Братиславская, дом 15, корпус 2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №72 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 355L, "Каширское шоссе, дом 55, корпус 6", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Москворечье-Сабурово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 318L, "улица Перерва, дом 45, корпус 1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №73 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 320L, "улица Марьинский парк, дом 21, корпус 1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №75 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 321L, "улица Некрасовкая, дом 5", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №76 по району Некрасовка" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 322L, "улица Бирюлевская, дом 1, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Бирюлево Восточное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 323L, "улица Бирюлевская,  дом 21, корпус 3", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Бирюлево Восточное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 324L, "улица Бирюлевская, дом 16", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Бирюлево Восточное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 325L, "улица Бирюловская, дом 52, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Бирюлево Восточное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 326L, "улица Липецкая, дом 34/25", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Бирюлево Восточное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 327L, "улица Лебедянская, дом 30", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Бирюлево Восточное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 328L, "улица Медынская, дом 4, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Бирюлево Западное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 329L, "улица Харьковская, дом 1, корпус 3", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Бирюлево Западное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 319L, "Перервинский бульвар, дом 21", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №74 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 307L, "улица Привольная, дом 7/1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №62 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 356L, "улица Кантемировская, дом 12, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Москворечье-Сабурово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 358L, "улица Новинки, дом 25", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Нагатинский Затон" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 385L, "улица Каспийская, дом 18, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Царицыно" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 386L, "улица Кантемировская, дом 33, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Царицыно" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 387L, "улица Бехтерева дом 31, корпус 3", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Царицыно" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 388L, "улица Медиков, дом 28, корпус 3", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Царицыно" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 389L, "улица Севанская, дом 52, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7 по району Царицыно" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 390L, "улица Чертановская, дом 18", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Чертаново Северное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 391L, "улица Сумская, дом 8, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Чертаново Северное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 392L, "Сумской проезд, дом 5, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Чертаново Северное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 393L, "Варшавское шоссе, дом 114, корпус 3", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Чертаново Северное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 394L, "Микрорайон Северное Чертаново, дом 2, квартира 201", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Чертаново Северное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 395L, "улица Кировоградская, дом 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Чертаново Северное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 396L, "улица Красного Маяка, дом 4, корпус 3", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Чертаново Центральное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 397L, "улица Чертановская, дом 30А", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Чертаново Центральное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 398L, "улица Днепропетровская, дом 5, корпус 3", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Чертаново Центральное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 399L, "улица Чертановская, дом 48, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Чертаново Центральное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 400L, "улица Красного Маяка, дом 3, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Чертаново Центральное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 401L, "улица Красного Маяка, дом 13А, корпус 4", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Чертаново Центральное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 402L, "улица Чертановская, дом 54, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Чертаново Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 403L, "улица Кировоградская, дом 42, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Чертаново Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 404L, "улица Подольских курсантов, дом 12, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Чертаново Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 405L, "3-й Дорожный проезд, дом 6, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Чертаново Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 384L, "Кавказский бульвар, дом 38", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Царицыно" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 383L, "улица Луганская, дом 4", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Царицыно" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 382L, "улица Тамбовская, дом 8, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7 по району Орехово-Борисово Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 381L, "Гурьевский проезд, дом 27, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Орехово-Борисово Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 359L, "улица Якорная, дом 8, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Нагатинский Затон" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 360L, "улица Новокосинская, дом 23", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №67 по району Новокосино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 361L, "улица Судостроительная, дом 40", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Нагатинский Затон" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 362L, "улица Коломенская, дом 21", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Нагатинский Затон" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 363L, "Каширское шоссе, дом 6, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Нагатино-Садовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 364L, "улица Академика Миллионщикова, дом 14, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Нагатино-Садовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 365L, "улица Нагатинская, дом 29, корпус 3", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Нагатино-Садовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 366L, "Нагатинская набережная, дом 20", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Нагатино-Садовники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 367L, "улица Криворожская, дом 19А", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Нагорный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 368L, "Варшавское шоссе, дом 71, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Нагорный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 357L, "Кленовый бульвар, дом 8, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Нагатинский Затон" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 369L, "улица Артековская, дом 7, корпус 4", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Нагорный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 371L, "улица Шипиловская, дом 20", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Орехово-Борисово Северное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 372L, "улица Шипиловская, дом 14", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Орехово-Борисово Северное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 373L, "улица Шипиловская, дом 25", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Орехово-Борисово Северное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 374L, "улица Генерала Белова, дом 21, корпус 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Орехово-Борисово Северное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 375L, "улица Шипиловская, дом 15", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Орехово-Борисово Северное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 376L, "Каширское шоссе, дом 122", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Орехово-Борисово Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 377L, "Каширское шоссе, дом 146, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Орехово-Борисово Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 378L, "Ореховый бульвар, дом 10, к. 2", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Орехово-Борисово Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 379L, "улица Елецкая, дом 11, корпус 1", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Орехово-Борисово Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 380L, "улица Елецкая, дом 18", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Орехово-Борисово Южное" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 370L, "Варшавское шоссе, дом 102", "Южный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Нагорный" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 204L, "улица Саянская, дом 10", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №40 по району Ивановское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 306L, "улица Генерала Кузнецова, дом 26, корпус 3", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №61 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 304L, "улица 1-я Дубровская, дом 8А", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №59 по району Южнопортовый" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 232L, "улица 16-я Парковая, дом 43А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №84 по району Северное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 233L, "Щелковское шоссе, дом 82, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №85 по району Северное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 234L, "улица 16-я Парковая, дом 43А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №86 по району Северное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 235L, "улица 9-я Парковая, дом 55, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №90 по району Северное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 236L, "улица Никитинская, дом 35, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №88 по району Северное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 237L, "Щелковское шоссе, дом 48, корпус 2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №89 по району Северное Измайлово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 238L, "улица Косинская, дом 26А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №8 по району Вешняки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 239L, "улица Снайперская, дом 8А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №9 по району Вешняки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 240L, "улица Вешняковская, дом 24А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №10 по району Вешняки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 241L, "улица Кетчерская, дом 2, корпус 5", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №11 по району Вешняки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 242L, "улица Вешняковская, дом 31А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №12 по району Вешняки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 243L, "улица Старый Гай, дом 10", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №13 по району Вешняки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 244L, "улица Вешняковская, дом 12Д", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №14 по району Вешняки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 245L, "улица Реутовская, дом 6, корпус 2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №15 по району Вешняки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 246L, "Рязанский проспект, дом 84/2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 247L, "Ферганский проезд, дом 7/1, квартира 111", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 248L, "Самаркандский бульвар, дом 137А, корпус 11", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 249L, "улица Ферганская, дом 18, корпус 3", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 250L, "улица Хлобыстова, дом 12/2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 251L, "улица Ферганская, дом 15, корпус 1, квартира 278", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 252L, "Волгоградский проспект, дом 170/1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 231L, "5-й проезд Подбельского, дом 4А, корпус 3", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №7 по району Богородское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 230L, "Открытое шоссе, дом 6, корпус 2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №6 по району Богородское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 229L, "улица Ивантеевская, дом 10", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №5 по району Богородское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 228L, "улица Бойцовая, дом 22, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №4 по району Богородское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 206L, "улица Чечулина, дом 11, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №34 по району Ивановское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 207L, "улица Святоозерская, дом 11", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №51 по району Косино-Ухтомский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 208L, "улица Рудневка, дом 22", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №52 по району Косино-Ухтомский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 209L, "улица Рудневка, дом 15", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №50 по району Косино-Ухтомский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 210L, "улица Лухмановская, дом 26", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №53 по району Косино-Ухтомский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 211L, "улица Кирпичная, дом 14", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №93 по району Соколиная Гора" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 212L, "Мажоров переулок, дом 8", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №94 по району Соколиная Гора" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 213L, "улица Зверинецкая, дом 25А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №97 по району Соколиная Гора" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 214L, "улица 5-я Соколиной Горы, дом 25А", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №98 по району Соколиная Гора" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 215L, "улица Маленковская, дом 7", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №99 по району Сокольники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 253L, "Рязанский проспект, дом 72, корпус 2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №8 по району Выхино-Жулебино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 216L, "улица Малая Остроумовская, дом 1Б", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №100 по району Сокольники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 218L, "улица Городецкая, дом 3", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №64 по району Новокосино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 219L, "улица Салтыковская, дом 11, корпус1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №69 по району Новокосино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 220L, "улица Новокосинская, дом 23", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №68 по району Новокосино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 221L, "улица Новокосинская, дом 23", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №67 по району Новокосино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 222L, "улица Суздальская, дом 28", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №70 по району Новокосино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 223L, "улица Суздальская, дом 10, корпус 3", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №66 по району Новокосино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 224L, "улица Городецкая, дом 8, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №65 по району Новокосино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 225L, "улица Бойцовая, дом 17, корпус 3", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №1 по району Богородское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 226L, "улица Игральная, дом 1, корпус 1", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №2 по району Богородское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 227L, "улица Краснобогатырская, дом 21", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №3 по району Богородское" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 217L, "улица Стромынка, дом 19, корпус 2", "Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №102 по району Сокольники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 305L, "улица Шарикоподшипниковская, дом 24", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №60 по району Южнопортовый" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 254L, "Капотня, 5-й квартал, дом 23, квартира 51", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №9 по району Капотня" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 256L, "улица Окская, дом 14, корпус 2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №11 по району Кузьминки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 283L, "улица Нижегородская, дом 72/2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №38 по району Нижегородский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 284L, "Перовское шоссе, дом 10, корпус 1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №39 по району Нижегородский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 285L, "улица Нижегородская, дом 90, корпус 2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №40 по району Нижегородский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 286L, "улица Полбина, дом 40", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №41 по району Печатники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 287L, "улица Шоссейная, дом 42", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №42 по району Печатники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 288L, "улица Батюнинская, дом 14", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №43 по району Печатники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 289L, "улица Кухмистерова, дом 3, корпус 1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №44 по району Печатники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 290L, "улица Полбина, дом 12", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №45 по району Печатники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 291L, "улица Полбина, дом 52", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №46 по району Печатники" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 292L, "улица 1-я Новокузьминская, дом 22/2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №47 по району Рязанский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 293L, "улица Михайлова, дом 12, корпус 1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №48 по району Рязанский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 294L, "улица 12-я Новокузьминская, дом 6,  корпус 1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №49 по району Рязанский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 295L, "Рязанский проспект, дом 71, корпус 2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №50 по району Рязанский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 296L, "улица 4-я Новокузьминская, дом 12", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №51 по району Рязанский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 297L, "улица 8-я Текстильщиков, дом 12, корпус 2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №52 по району Текстильщики" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 298L, "улица 8-я Текстильщиков, дом 15", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №53 по району Текстильщики" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 299L, "улица Чистова, дом 22", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №54 по району Текстильщики" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 300L, "Волжский бульвар, дом 4, корпус 2, квартира 112", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №55 по району Текстильщики" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 301L, "улица Саратовская, дом 18/10", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №56 по району Текстильщики" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 302L, "улица Трофимова, дом 15", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №57 по району Южнопортовый" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 303L, "улица Петра Романова, дом 14", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №58 по району Южнопортовый" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 282L, "Орехово-Зуевский проезд, дом 20", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №37 по району Нижегородский" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 281L, "Новочеркасский бульвар, дом 31", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №36 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 280L, "улица Донецкая, дом 33", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №35 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 279L, "улица Донецкая, дом 4, корпус 2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №34 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 257L, "Волгоградский проспект, дом 60, корпус 3", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №12 по району Кузьминки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 258L, "улица Зеленодольская, дом 32, корпус 4", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №13 по району Кузьминки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 259L, "улица Юных Ленинцев, дом 109, корпус 2, квартира 43", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №14 по району Кузьминки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 260L, "улица Федора Полетаева, дом 30, квартира 40", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №15 по району Кузьминки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 261L, "улица Зеленодольская, дом 36, корпус 2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №17 по району Кузьминки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 262L, "улица Маршала Чуйкова, дом 11, корпус 3", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №18 по району Кузьминки" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 263L, "улица Лонгиновская, дом 10", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №19 по району Лефортово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 264L, "Шоссе Энтузиастов, дом 18", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №20 по району Лефортово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 265L, "Средний Золоторожский переулок, дом 9", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №21 по району Лефортово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 266L, "улица Волочаевская, дом 19", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №22 по району Лефортово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 255L, "Капотня, 3-й квартал, дом 4, квартира 3", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №10 по району Капотня" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 267L, "улица Авиамоторная, дом 29", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №23 по району Лефортово" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 269L, "улица Совхозная, дом 16, корпус1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №25 по району Люблино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 270L, "улица Краснодонская, дом 1, корпус 1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №26 по району Люблино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 271L, "улица Совхозная, дом 8", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №27 по району Люблино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 272L, "улица Люблинская, дом 61", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №28 по району Люблино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 273L, "проспект 40 лет Октября, дом 23/1", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №29 по району Люблино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 274L, "улица Белореченская, дом 13, корпус 2", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №30 по району Люблино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 275L, "улица Маршала Баграмяна, дом 4", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №31 по району Люблино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 276L, "Ставропольский проезд, дом 11", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №32 по району Люблино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 277L, "Батайский проезд, дом 41", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №32 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 278L, "улица Донецкая, дом 11", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №33 по району Марьино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 268L, "улица Армавирская, дом 5", "Юго-Восточный административный округ", "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktnaja_informacija", "Участковый пункт полиции №24 по району Люблино" });

            migrationBuilder.InsertData(
                table: "PoliceStations",
                columns: new[] { "Id", "Address", "AdmArea", "ExtraInfo", "Name" },
                values: new object[] { 814L, "г. Москва, Пресненская наб, д. 2", "Центральный административный округ", null, "Участковый пункт полиции по району Пресненский №33 " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PoliceStations");
        }
    }
}
