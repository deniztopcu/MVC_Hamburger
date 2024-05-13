using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Hamburger.Migrations
{
    /// <inheritdoc />
    public partial class initDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e09ba073-155a-42df-b4ce-e43be6edfce4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a67bcf52-7460-41a7-ae80-2a3e43cf65b5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28c68912-1777-470e-85b8-3fcfe65206d3", "AQAAAAIAAYagAAAAEEmGzq2vNfEENYTl4ei5EAKwl8CNMyPRSknPpvkMC+eAyLNH2KsyaKxNaW9LDFWIGA==", "a0155478-e893-4bb6-b308-b72ab1d8b304" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92f7e033-a333-4c76-a218-b852172e75ca", "AQAAAAIAAYagAAAAEFaC3PXZDZhUy4TPeqhPsux2AFW+eQosOl8lLROsQ9ZzbhFZmvYwiCLDC3KV9pabJg==", "21c99558-1eec-4081-bcca-46cfea373da9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b9ffc7c-9dcc-41f5-a0a7-7b58b503beed", "AQAAAAIAAYagAAAAEAMOzaK81DiaMBdsj34OWySvj6mck8SwfmXmZf76GGRJUIDxRXWgez1JbI7F5OjqJQ==", "58d7e633-e7ac-4711-a707-7e0a0d48fef2" });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriID", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "İçecek" },
                    { 2, "Tatlı" },
                    { 3, "Sos" }
                });

            migrationBuilder.InsertData(
                table: "Menuler",
                columns: new[] { "ID", "Ad", "Boy", "Fiyat", "MenuAdet", "ResimYolu" },
                values: new object[,]
                {
                    { 1, "hamburger", "Kucuk", 159m, 1, "sfdsfa" },
                    { 2, "burger", "Kucuk", 169m, 1, "sfdsfa" }
                });

            migrationBuilder.InsertData(
                table: "EkstraMalzemeler",
                columns: new[] { "ID", "Ad", "Fiyat", "KategoriID", "MenuAdet" },
                values: new object[,]
                {
                    { 1, "ketçap", 20m, 1, 0 },
                    { 2, "mayonez", 20m, 2, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EkstraMalzemeler",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EkstraMalzemeler",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 3);

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
        }
    }
}
