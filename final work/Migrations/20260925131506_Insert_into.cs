using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace final_work.Migrations
{
    /// <inheritdoc />
    public partial class Insert_into : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Positions_PositionsId",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Directors_PositionsId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "PositionsId",
                table: "Directors");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "Poland" },
                    { 3, "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Building", "Name" },
                values: new object[,]
                {
                    { 1, "B A", "Programming" },
                    { 2, "B B", "Design" },
                    { 3, "B C", "Management" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "PV-21", 3 },
                    { 2, "PV-22", 2 },
                    { 3, "PV-23", 1 }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                column: "Id",
                values: new object[]
                {
                    1,
                    2,
                    3
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "C#" },
                    { 2, "Database" },
                    { 3, "FireWork" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Name", "PositionId" },
                values: new object[] { 1, "Mykola", 1 });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Name", "PositionId" },
                values: new object[,]
                {
                    { 1, "Oleksa", 2 },
                    { 2, "Olena", 2 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "GroupsId", "Name", "Rating", "StudAdmission", "Surname" },
                values: new object[,]
                {
                    { 1, 1, "Andri", 99, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melnyk" },
                    { 2, 2, "Maria", 76, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shevchenko" },
                    { 3, 3, "Dmytro", 91, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bondar" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Birthdate", "CountryId", "Hiring", "ManagersId", "Name", "Patronymic", "PositionId", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ivan", "Ivanov", 3, "Petren" },
                    { 2, new DateTime(1990, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Oksana", "Petriv", 3, "Koval" },
                    { 3, new DateTime(1988, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Adam", "Novakchuk", 3, "Nowak" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Directors_PositionId",
                table: "Directors",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Positions_PositionId",
                table: "Directors",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Positions_PositionId",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Directors_PositionId",
                table: "Directors");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "PositionsId",
                table: "Directors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Directors_PositionsId",
                table: "Directors",
                column: "PositionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Positions_PositionsId",
                table: "Directors",
                column: "PositionsId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
