using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Hamburger.Migrations
{
    /// <inheritdoc />
    public partial class icerik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResimYolu",
                table: "Menuler",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Icerik",
                table: "Menuler",
                type: "varchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "17ec04c8-b3e0-4d36-9283-511af28545b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2e552509-6ac8-4452-9a3c-66cc4372d391");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1cb0da1-d085-4e5f-adf3-b62662ff1778", "AQAAAAIAAYagAAAAEEmm9+KM+Niuc6BFRcJtY9xXgj1UG0pn5dz24+HYf2IP7xs8WEXhuJSO7g7hLL+zng==", "4d79d09b-f374-4e2a-9131-e0786f355f4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdf014c6-4702-40be-a2f8-227c4a1e4a2d", "AQAAAAIAAYagAAAAEPnfNoPKYZ5QLoQoVC3m/ZQM3rJKpjivPAXqYCNIgYKf6lC92KOVN+5qTltholgraA==", "8c842b66-02c1-4998-97a4-7ff41d1f7043" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9bdc3b2-3c09-4eca-bf7e-393ad8a08083", "AQAAAAIAAYagAAAAEIkYNmlvDGlzH17i1p9Kf4LE8JOAAsDz7XEFpOVgTdsTuOvV+3zS6D0eY9+pT06shQ==", "530bca12-df33-4af4-b20b-c9a9b6760f4f" });

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "ID",
                keyValue: 1,
                column: "Icerik",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "ID",
                keyValue: 2,
                column: "Icerik",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icerik",
                table: "Menuler");

            migrationBuilder.AlterColumn<string>(
                name: "ResimYolu",
                table: "Menuler",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

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
        }
    }
}
