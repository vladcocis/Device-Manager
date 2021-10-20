using Microsoft.EntityFrameworkCore.Migrations;

namespace DeviceAPI.Migrations
{
    public partial class UpdatedRAMfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RAM",
                table: "DeviceDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RAM",
                table: "DeviceDetails",
                type: "nvarchar(2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
