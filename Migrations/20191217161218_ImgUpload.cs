using Microsoft.EntityFrameworkCore.Migrations;

namespace MediTracker.Migrations
{
    public partial class ImgUpload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    EntryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-fffffffff123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "150c2652-30a3-4684-b7b9-300403acd25e", "AQAAAAEAACcQAAAAEBvXcbXSsfwDblbCcaEfvA6Vuam4UBLhRDESVDd6WK8CiHs+fjkH5dy/yVjDp6Yg7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6b5203f-b1df-4c08-86a5-6106f288ad23", "AQAAAAEAACcQAAAAELDhCGNWsF/uFXzkY64f0MKVSkPpPvLST0dnpOPk37BDTASfaQcgH5nqG7lA/boGAw==" });
        }
    }
}
