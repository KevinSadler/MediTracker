using Microsoft.EntityFrameworkCore.Migrations;

namespace MediTracker.Migrations
{
    public partial class Thirdary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-fffffffff123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e495d17c-8393-4e50-94a0-d45060ec9698", "AQAAAAEAACcQAAAAEBTcV2dlKtermQ5H/xb39AzCikCVqmXv85TsRjkeV5bXLjMs9285RAORqNLoLb63Hw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae2ba2fb-e0f9-4a20-bf2b-84441a507f65", "AQAAAAEAACcQAAAAEBKHNHGOwiMmetVS5LFIprheREfHDC3dPuPygECTYJO0EAF0HD7r0X5qDUcVOBGYag==" });

            migrationBuilder.CreateIndex(
                name: "IX_Images_EntryId",
                table: "Images",
                column: "EntryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Entries_EntryId",
                table: "Images",
                column: "EntryId",
                principalTable: "Entries",
                principalColumn: "EntryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Entries_EntryId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_EntryId",
                table: "Images");

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
    }
}
