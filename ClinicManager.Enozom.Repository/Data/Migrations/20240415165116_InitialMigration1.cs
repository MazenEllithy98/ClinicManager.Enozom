using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicManager.Enozom.Repository.Data.Migrations
{
    public partial class InitialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Mohamed" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Ahmed" });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "DayOfWeek", "DoctorId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, "Monday", 1, "13:00", "9:00" },
                    { 2, "Monday", 1, "18:00", "2:00" },
                    { 3, "Tuesday", 1, "13:00", "9:00" },
                    { 4, "Tuesday", 1, "18:00", "2:00" },
                    { 5, "Tuesday", 1, "21:00", "20:00" },
                    { 6, "Wednesday", 1, "13:00", "9:00" },
                    { 7, "Wednesday", 1, "18:00", "02:00" },
                    { 8, "Thursday", 1, "18:00", "02:00" },
                    { 9, "Friday", 1, "13:00", "9:00" },
                    { 10, "Monday", 2, "17:00", "9:00" },
                    { 11, "Tuesday", 2, "13:00", "9:00" },
                    { 12, "Tuesday", 2, "21:00", "20:00" },
                    { 13, "Thursday", 2, "18:00", "02:00" },
                    { 14, "Friday", 2, "13:00", "09:00" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
