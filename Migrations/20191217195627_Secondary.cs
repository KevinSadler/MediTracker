using Microsoft.EntityFrameworkCore.Migrations;

namespace MediTracker.Migrations
{
    public partial class Secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-fffffffff123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba98813d-aad3-4fe2-add4-b357f091aeb2", "AQAAAAEAACcQAAAAECmN+7W+vnvjpgL2mut3WQeJNxGcdUbkxeZ2eRdsScBGYygYIBg9q42Jrg3AaFu1Vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4546105-20e0-44ab-969c-45277781879c", "AQAAAAEAACcQAAAAEHPaS5RX8Kqt54956yvaCRvx+yxNDnqmoQHBCji0fD91jFbyaOFKHuxNWmwTVCJTMQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-fffffffff123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d9fcc7e-5160-4f6d-b145-4ee177204385", "AQAAAAEAACcQAAAAENyoACU4POOAekOqp/OWVIJbofCoNgyJ7UK4A6ccdT6eWhU/KHSyXEBjTsv/IknpoQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5991c637-874d-4901-82e6-d9304dd1446e", "AQAAAAEAACcQAAAAEP/lQxTJHEGTC7wtf8HWmFaHJ6Gf4iOYJj9DjiHO5MSVWycAEFZ0BoVksyr2J98myw==" });
        }
    }
}
