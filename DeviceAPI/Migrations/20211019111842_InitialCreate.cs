using Microsoft.EntityFrameworkCore.Migrations;

namespace DeviceAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceDetails",
                columns: table => new
                {
                    DeviceDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DeviceType = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    OS = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    OSVersion = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Processor = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    RAM = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceDetails", x => x.DeviceDetailID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceDetails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
