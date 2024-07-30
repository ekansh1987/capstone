using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace capstone.Migrations
{
    public partial class addthreeproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PinCode",
                table: "Customers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "PinCode", "State" },
                values: new object[] { "Ghaziabad", 2013078L, "UttarPradesh" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "PinCode", "State" },
                values: new object[] { "Noida", 201301L, "UttarPradesh" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "PinCode", "State" },
                values: new object[] { "Mathura", 281403L, "UttarPradesh" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "PinCode", "State" },
                values: new object[] { "Baliya", 201309L, "UttarPradesh" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "PinCode", "State" },
                values: new object[] { "Ghaziabad", 201308L, "UttarPradesh" });

            migrationBuilder.UpdateData(
                table: "offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581470L, 1472583690963L });

            migrationBuilder.UpdateData(
                table: "offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581470L, 1472583690963L });

            migrationBuilder.UpdateData(
                table: "offers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581470L, 1472583690963L });

            migrationBuilder.UpdateData(
                table: "offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581470L, 1472583690963L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PinCode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581471L, 1472583690964L });

            migrationBuilder.UpdateData(
                table: "offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581472L, 1472583690965L });

            migrationBuilder.UpdateData(
                table: "offers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581473L, 1472583690966L });

            migrationBuilder.UpdateData(
                table: "offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ServiceNumber", "SimNumber" },
                values: new object[] { 3692581474L, 1472583690967L });
        }
    }
}
