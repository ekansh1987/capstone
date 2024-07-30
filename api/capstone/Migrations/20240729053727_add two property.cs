using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace capstone.Migrations
{
    public partial class addtwoproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ServiceNumber",
                table: "Customers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SimNumber",
                table: "Customers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581470L, 1472583690963L });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581471L, 1472583690964L });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581472L, 1472583690965L });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581473L, 1472583690966L });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581474L, 1472583690966L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SimNumber",
                table: "Customers");
        }
    }
}
