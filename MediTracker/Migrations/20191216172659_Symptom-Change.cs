using Microsoft.EntityFrameworkCore.Migrations;

namespace MediTracker.Migrations
{
    public partial class SymptomChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-fffffffff123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef9245ce-f1f5-423f-ae6e-b4ee799e944d", "AQAAAAEAACcQAAAAEBgbIEuQcYBmub9nSImIYAYcLYDodj/9cPQkyhnjHevJ3vlbV6uJ0fBTEovBbOKaUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "add9573d-58ca-4350-a20a-02bd3c16d830", "AQAAAAEAACcQAAAAEGSI4tjV0arnkjVNDvQOB6KL/m1+P3hUSVWyt0gTPAOpJlquDHhrYPmcahHmFbgSwQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-fffffffff123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24086e47-eb80-402e-ba97-24db8e1504be", "AQAAAAEAACcQAAAAEJQe6x4lIG2Q1IDO/71kkRanZrQDSNVoE3u19A2dWp2ncVvumw8kxAKiKo20PbMHUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "accc4874-cf98-4970-bea9-2a443c921aef", "AQAAAAEAACcQAAAAECR1oyEhfk1s3zhzDdFn8N8jtXSeBFqG5lqDA3lGr49EdXCn5kvkFfvhnfWFgtAkww==" });
        }
    }
}
