using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "d7491175-30f4-4426-a515-7bfad81a0073");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2594c0a-2b86-47bf-8663-73cb27ca3c1c", "AQAAAAEAACcQAAAAECSMkmmSvvxIThfYnMJr87y00HP7V29EiMoA5QENmXZoFzgT/6x19vhU+AmqpI2YGg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 25, 17, 27, 3, 277, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 25, 17, 27, 3, 277, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "CodeWord", "DateAdded" },
                values: new object[] { "PageServices", new DateTime(2023, 6, 25, 17, 27, 3, 277, DateTimeKind.Utc).AddTicks(4301) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "f7e67446-8a1c-4309-a76f-27a4063453a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33df916a-9c89-4b22-994d-5b3883c8f75d", "AQAAAAEAACcQAAAAELi95i7bbiJ68nWH249Uf3wa0fhDzFSIN62yO75oruMH7WbemPOBcOZ070iz6mmmZA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 25, 17, 12, 37, 529, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 25, 17, 12, 37, 528, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "CodeWord", "DateAdded" },
                values: new object[] { "PageService", new DateTime(2023, 6, 25, 17, 12, 37, 529, DateTimeKind.Utc).AddTicks(623) });
        }
    }
}
