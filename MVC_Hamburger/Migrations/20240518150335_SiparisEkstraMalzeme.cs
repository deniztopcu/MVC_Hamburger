using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Hamburger.Migrations
{
    /// <inheritdoc />
    public partial class SiparisEkstraMalzeme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SiparisEkstraMalzemeler",
                table: "SiparisEkstraMalzemeler");

            migrationBuilder.AddColumn<int>(
                name: "SiparisEkstraMalzemeID",
                table: "SiparisEkstraMalzemeler",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SiparisEkstraMalzemeler",
                table: "SiparisEkstraMalzemeler",
                column: "SiparisEkstraMalzemeID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "26b33612-696f-44f7-ba77-19e532765d29");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b59c5bfc-60b8-4470-a4ed-ec519bc36115");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "992d841f-721d-434d-8487-5f4eb257a687", "AQAAAAIAAYagAAAAEKqK0puf6SkOghwzJedCqRV8AnK//z/90PmwTs348YgXAbZXVmwx6MWM80IW204AzA==", "65dbeb81-a253-4c9f-87bf-43f815a04504" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f58f35e-dbf8-4e34-bfc4-dbdd48c9cf29", "AQAAAAIAAYagAAAAEPfpUSx65H2LSutx2sjRdOkhdu9H4t8AJlmHh0eezjGrKx38T8qCP0RUAxk5/WN+ng==", "8b819edd-26ce-4d70-8ebc-44ea44816f12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8d8677e-8517-4732-99cf-1bcbaa9fad0f", "AQAAAAIAAYagAAAAEPH9AsSRU7Fv/uu+7PB3pLGTrlMB04gTvxxYCdYI55Guu7nF75dBuOgf1oqzmFEhHA==", "4f857f0f-6563-4623-b204-87afe5ecfa7f" });

            migrationBuilder.CreateIndex(
                name: "IX_SiparisEkstraMalzemeler_EkstraMalzemeID",
                table: "SiparisEkstraMalzemeler",
                column: "EkstraMalzemeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SiparisEkstraMalzemeler",
                table: "SiparisEkstraMalzemeler");

            migrationBuilder.DropIndex(
                name: "IX_SiparisEkstraMalzemeler_EkstraMalzemeID",
                table: "SiparisEkstraMalzemeler");

            migrationBuilder.DropColumn(
                name: "SiparisEkstraMalzemeID",
                table: "SiparisEkstraMalzemeler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SiparisEkstraMalzemeler",
                table: "SiparisEkstraMalzemeler",
                columns: new[] { "EkstraMalzemeID", "SiparisID" });

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
        }
    }
}
