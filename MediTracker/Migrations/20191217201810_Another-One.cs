using Microsoft.EntityFrameworkCore.Migrations;

namespace MediTracker.Migrations
{
    public partial class AnotherOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "ImgName",
                table: "Images",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-fffffffff123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88d8af64-5c38-45ac-8709-099783109d10", "AQAAAAEAACcQAAAAEDzg11/s5OMZDmZx/6p33Jaf0C/qDovjPnLnQ8HMlyze6UKMPsXhPAVwiBLkJuiWLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87fb7a2b-7fa4-4472-94e6-b4be58c44baf", "AQAAAAEAACcQAAAAEHtaiudVxhW6jGzB3qN9DlJYUxwpqamBoPKSe8aGLL+aJAvHcqF21A6szTojXc+MHw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgName",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-fffffffff123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3d5f00c-4fef-4f83-acba-1360fcc4b5a1", "AQAAAAEAACcQAAAAEEHAtU3Vp8czPZ/3PLIprNw0Qynyg+hYgoih2Nlp5Hgf1o81CwfkstdOFz01uSdmzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b17fbca9-04a3-4629-9a1b-0c3122e6ea53", "AQAAAAEAACcQAAAAEAzV3k6ndli0ydIu9oSppR8DcM3Hbg6H+Y/iSf/JTY0mtewODNulgX8OlnsgNfvoig==" });
        }
    }
}
