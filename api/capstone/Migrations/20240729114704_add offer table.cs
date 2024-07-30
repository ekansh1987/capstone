using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace capstone.Migrations
{
    public partial class addoffertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Simstatus",
                table: "Customers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateTable(
                name: "offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SimNumber = table.Column<long>(type: "bigint", nullable: false),
                    ServiceNumber = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    NetData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Validity = table.Column<long>(type: "bigint", nullable: false),
                    Otherbenifits = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_offers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "SimNumber",
                value: 1472583690967L);

            migrationBuilder.InsertData(
                table: "offers",
                columns: new[] { "Id", "NetData", "Otherbenifits", "Price", "ServiceNumber", "SimNumber", "Sms", "Validity" },
                values: new object[,]
                {
                    { 1, "1 GB/day data & unlimited calls", "VI movies and TV, Netflix subscription free for 1 year", 99L, 3692581470L, 1472583690963L, "1000 SMS per day", 28L },
                    { 2, "1.5 GB/day data & unlimited calls", "VI movies and TV, Netflix subscription free for 1 year", 299L, 3692581471L, 1472583690964L, "2000 SMS per day", 28L },
                    { 3, "2 GB/day data & unlimited calls", "VI movies and TV, Netflix subscription free for 1 year", 399L, 3692581472L, 1472583690965L, "1000 SMS per day", 45L },
                    { 4, "3 GB/day data & unlimited calls", "VI movies and TV, Netflix subscription free for 1 year", 499L, 3692581473L, 1472583690966L, "2000 SMS per day", 72L },
                    { 5, "100 GB/day data & unlimited calls", "VI movies and TV, Netflix subscription free for 1 year", 2267L, 3692581474L, 1472583690967L, "10000 SMS per day", 365L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "offers");

            migrationBuilder.AlterColumn<bool>(
                name: "Simstatus",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "SimNumber",
                value: 1472583690966L);
        }
    }
}
