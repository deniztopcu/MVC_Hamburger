using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Hamburger.Migrations
{
    /// <inheritdoc />
    public partial class InitDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EkstraMalzemeMenuler");

            migrationBuilder.DropTable(
                name: "LoginVM");

            migrationBuilder.DropColumn(
                name: "MenuAdet",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "Boy",
                table: "Menuler");

            migrationBuilder.DropColumn(
                name: "MenuAdet",
                table: "Menuler");

            migrationBuilder.DropColumn(
                name: "MenuAdet",
                table: "EkstraMalzemeler");

            migrationBuilder.AddColumn<int>(
                name: "MenuAdedi",
                table: "SiparisMenuler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Boy",
                table: "Siparisler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SiparisEkstraMalzemeler",
                columns: table => new
                {
                    EkstraMalzemeID = table.Column<int>(type: "int", nullable: false),
                    SiparisID = table.Column<int>(type: "int", nullable: false),
                    EkstraMalzemeAdedi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisEkstraMalzemeler", x => new { x.EkstraMalzemeID, x.SiparisID });
                    table.ForeignKey(
                        name: "FK_SiparisEkstraMalzemeler_EkstraMalzemeler_EkstraMalzemeID",
                        column: x => x.EkstraMalzemeID,
                        principalTable: "EkstraMalzemeler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisEkstraMalzemeler_Siparisler_SiparisID",
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
                value: "82f13da9-dfdc-4cfd-a32e-0f5a413abbc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "22509e60-4e1d-4711-9fc2-236f7b107a03");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3db0b96e-f976-4b97-a395-39d8ef7ff20a", "AQAAAAIAAYagAAAAEAyeFlXWdlJba0xpRXOkWWS4+r5Uy+d7xTtROudZQV9lv3RiElrgIZcFz31kZ1gj1A==", "2f08fdbb-42f3-4046-aadf-cc3412dfe8e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84744600-3114-49b5-b671-508e4b32aceb", "AQAAAAIAAYagAAAAEJ8F9yFckIMY+v/NUmZFRTXUzuHgU7YL50kkDKpjamSvp+GQIaGoFzCBJKIYyYv+qg==", "3539b586-04a5-4521-a185-05698db23187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1c0ee27-f5a0-4492-a3cf-c8da6a8c8320", "AQAAAAIAAYagAAAAEOWjzubiYrL1ELhU6+EPD767GLIkKbxvAQ8kcVP/a8Rciyi8GvJkiy2ZUgMe8N7p6w==", "e79aa308-9ce0-42ba-8cc4-4cb812a5013e" });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriID", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "İçecek" },
                    { 2, "Tatlı" },
                    { 3, "Sos" },
                    { 4, "Çıtır Lezzetler" }
                });

            migrationBuilder.InsertData(
                table: "Menuler",
                columns: new[] { "ID", "Ad", "Fiyat", "ResimYolu" },
                values: new object[,]
                {
                    { 1, "hamburger", 159m, "sfdsfa" },
                    { 2, "burger", 169m, "sfdsfa" }
                });

            migrationBuilder.InsertData(
                table: "EkstraMalzemeler",
                columns: new[] { "ID", "Ad", "Fiyat", "KategoriID" },
                values: new object[,]
                {
                    { 1, "ketçap", 20m, 1 },
                    { 2, "mayonez", 20m, 2 },
                    { 3, "Sos İstemiyorum", 0m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SiparisEkstraMalzemeler_SiparisID",
                table: "SiparisEkstraMalzemeler",
                column: "SiparisID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiparisEkstraMalzemeler");

            migrationBuilder.DeleteData(
                table: "EkstraMalzemeler",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EkstraMalzemeler",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EkstraMalzemeler",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menuler",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menuler",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "MenuAdedi",
                table: "SiparisMenuler");

            migrationBuilder.DropColumn(
                name: "Boy",
                table: "Siparisler");

            migrationBuilder.AddColumn<int>(
                name: "MenuAdet",
                table: "Siparisler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Boy",
                table: "Menuler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MenuAdet",
                table: "Menuler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MenuAdet",
                table: "EkstraMalzemeler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EkstraMalzemeMenuler",
                columns: table => new
                {
                    EkstraMalzemeID = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkstraMalzemeMenuler", x => new { x.EkstraMalzemeID, x.MenuID });
                    table.ForeignKey(
                        name: "FK_EkstraMalzemeMenuler_EkstraMalzemeler_EkstraMalzemeID",
                        column: x => x.EkstraMalzemeID,
                        principalTable: "EkstraMalzemeler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EkstraMalzemeMenuler_Menuler_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menuler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginVM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginVM", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a31a51f9-bee5-4d94-94db-1521d77bd9e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e51b5361-e994-4980-99f9-3e20702e888f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63d69a10-c748-4797-a96b-9ff548f2b1ec", "AQAAAAIAAYagAAAAEPloBVTOvz3oyOdlaSU+o6w5NIBtSGAcke/atE2N7k3hxmcoOEwTqzKP0ahL4Pa/SA==", "479d41e2-3a20-48a4-a429-5fe5edb6034c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e7d220a-7ef0-4474-aa28-51a02b319747", "AQAAAAIAAYagAAAAEBI/fjgodLgcwn8jWUd/pz1Fr108/9jDNo5YP6G7ojJbtMnai2RKSxo0pV8FNX37Eg==", "4241f8b3-5689-4aa2-83ce-5e2c7b8d102a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a09fd86e-60dd-4750-a15a-4c75b7217b4a", "AQAAAAIAAYagAAAAEL24lVPwW6skaMYJePq7XK6RWtoDx8prYIo6YjqrHjtFFsV6kL2J4IndkNbB5JTA3Q==", "db5d0f7a-4118-4d01-8724-4094eb9b302d" });

            migrationBuilder.CreateIndex(
                name: "IX_EkstraMalzemeMenuler_MenuID",
                table: "EkstraMalzemeMenuler",
                column: "MenuID");
        }
    }
}
