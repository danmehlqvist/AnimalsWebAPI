using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalsWebAPI.Migrations
{
    public partial class Seeded_Data_In_Animal_And_AnimalType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "ID", "Created", "Name", "NumberOfLegs" },
                values: new object[] { 1, new DateTime(2021, 12, 14, 11, 12, 45, 22, DateTimeKind.Local).AddTicks(2478), "Dog", 4 });

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "ID", "Created", "Name", "NumberOfLegs" },
                values: new object[] { 2, new DateTime(2021, 12, 14, 11, 12, 45, 22, DateTimeKind.Local).AddTicks(2521), "Ostrich", 2 });

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "ID", "Created", "Name", "NumberOfLegs" },
                values: new object[] { 3, new DateTime(2021, 12, 14, 11, 12, 45, 22, DateTimeKind.Local).AddTicks(2523), "Spider", 8 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "ID", "AnimalTypeID", "Created", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 12, 14, 11, 12, 45, 22, DateTimeKind.Local).AddTicks(2593), new DateTime(1975, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam" },
                    { 2, 2, new DateTime(2021, 12, 14, 11, 12, 45, 22, DateTimeKind.Local).AddTicks(2597), new DateTime(1975, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benke" },
                    { 3, 3, new DateTime(2021, 12, 14, 11, 12, 45, 22, DateTimeKind.Local).AddTicks(2598), new DateTime(1975, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camilla" },
                    { 4, 3, new DateTime(2021, 12, 14, 11, 12, 45, 22, DateTimeKind.Local).AddTicks(2600), new DateTime(1975, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniela" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
