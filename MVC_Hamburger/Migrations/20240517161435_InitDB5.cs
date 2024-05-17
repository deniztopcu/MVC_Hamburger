using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Hamburger.Migrations
{
    /// <inheritdoc />
    public partial class InitDB5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiparisMenuler");

            migrationBuilder.AddColumn<int>(
                name: "MenuAdedi",
                table: "Siparisler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MenuID",
                table: "Siparisler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "90ae0aad-e0f7-4207-8cc4-0b0af066ebe9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "df4678a4-0a6c-4855-ac0b-a0973db200e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef481c2d-ffbe-49c8-ab94-130aa43dc7b2", "AQAAAAIAAYagAAAAECD3zWDY9ShOMM0oCkSaZwaZj1PjJWWrlpbADP9MK/FU+LJD5C2YZcx5Mw8M3h5IhQ==", "4de22376-8246-4401-a45e-fa1764f27d56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b87438f-dd73-40b5-97ce-c6bdeae0dac3", "AQAAAAIAAYagAAAAEN079dGDWq0qDBOTjWBg7QSCYkIGVt1prQkRhOFYTRYhFW42YI08Gxi86rfrdceBLw==", "ebad3fb0-6994-4f11-9d1e-3e4e505dc4cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62f4f2b8-1ba0-4795-81f0-12d7e4f55bab", "AQAAAAIAAYagAAAAEJmHoVSjaYVP+E56KoptuvNFBZeTQdUmeWqShHCOpBRv18k4hDpp04AFCwHo75WeAQ==", "cc952fff-4440-4946-976a-e15df63630b3" });

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_MenuID",
                table: "Siparisler",
                column: "MenuID");

            migrationBuilder.AddForeignKey(
                name: "FK_Siparisler_Menuler_MenuID",
                table: "Siparisler",
                column: "MenuID",
                principalTable: "Menuler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siparisler_Menuler_MenuID",
                table: "Siparisler");

            migrationBuilder.DropIndex(
                name: "IX_Siparisler_MenuID",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "MenuAdedi",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "MenuID",
                table: "Siparisler");

            migrationBuilder.CreateTable(
                name: "SiparisMenuler",
                columns: table => new
                {
                    SiparisID = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    MenuAdedi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisMenuler", x => new { x.SiparisID, x.MenuID });
                    table.ForeignKey(
                        name: "FK_SiparisMenuler_Menuler_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menuler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisMenuler_Siparisler_SiparisID",
                        column: x => x.SiparisID,
                        principalTable: "Siparisler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "755ea385-57f0-4e70-a845-122d6a343e85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f825b9a1-fc79-497b-ba3e-595021d64840");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "481b0f2e-9e2d-40f6-ad25-960155138174", "AQAAAAIAAYagAAAAEAS/THl8G4p3BXj9khS18ltgUFbt2WrzfLQGIeagHkspEbDbXN20vkaquJ5o2JAr/w==", "15c62db9-83e5-4b9d-8715-367333e931ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c67c254-6d95-41b8-ab54-f5fe1a601885", "AQAAAAIAAYagAAAAELIq+D6glM+sFRargGjonYclSfei8r9H1CIM0pAd+4ZRt0gzb8q58hg1CVgX3yVjUQ==", "f00aa4e0-c760-4f50-911f-bd03738d15c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c25e148-f8cc-4312-8a63-0dae63a47353", "AQAAAAIAAYagAAAAEPx5IiXgEo8dSblm4Dwl52l2NSJJrIpiGIN93TukGPBjfuWryetO94uWULRe8ERrwQ==", "946c59ed-24e5-438d-887c-f41b557e39dc" });

            migrationBuilder.CreateIndex(
                name: "IX_SiparisMenuler_MenuID",
                table: "SiparisMenuler",
                column: "MenuID");
        }
    }
}
