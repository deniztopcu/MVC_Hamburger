using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Hamburger.Migrations
{
    /// <inheritdoc />
    public partial class ekstra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EkstraMalzemeler",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EkstraMalzemeler",
                keyColumn: "ID",
                keyValue: 2);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "EkstraMalzemeler",
                columns: new[] { "ID", "Ad", "Fiyat", "KategoriID" },
                values: new object[,]
                {
                    { 1, "ketçap", 20m, 1 },
                    { 2, "mayonez", 20m, 2 }
                });
        }
    }
}
