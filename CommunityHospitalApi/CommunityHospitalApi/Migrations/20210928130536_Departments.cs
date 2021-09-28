using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityHospitalApi.Migrations
{
    public partial class Departments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            DepartmentsSeed(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department");
        }  


        private static void DepartmentsSeed(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentName", "ManagerFirstName", "ManagerLastName", "DateCreated" },
                values: new object[] { Guid.NewGuid(), "Nursing Administration", "Awhina", "Broughton", DateTime.Now }
                );

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentName", "ManagerFirstName", "ManagerLastName", "DateCreated" },
                values: new object[] { Guid.NewGuid(), "Housekeeping", "Ellen", "Crozier",  DateTime.Now }
                );

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentName", "ManagerFirstName", "ManagerLastName", "DateCreated" },
                values: new object[] { Guid.NewGuid(), "Maintenance", "Hillary", "Bauer",  DateTime.Now }
                );

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentName", "ManagerFirstName", "ManagerLastName", "DateCreated" },
                values: new object[] { Guid.NewGuid(), "Accounting And Finance", "Judy", "Brownlee",  DateTime.Now }
                );

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentName", "ManagerFirstName", "ManagerLastName", "DateCreated" },
                values: new object[] { Guid.NewGuid(), "Supply, Processing & Dist.", "Alison", "Rayner", DateTime.Now }
                );

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentName", "ManagerFirstName", "ManagerLastName", "DateCreated" },
                values: new object[] { Guid.NewGuid(), "Radiology", "Bryan", "Nolan",  DateTime.Now }
                );

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentName", "ManagerFirstName", "ManagerLastName", "DateCreated" },
                values: new object[] { Guid.NewGuid(), "Laboratory", "Linda", "Cooper",  DateTime.Now }
                );

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentName", "ManagerFirstName", "ManagerLastName", "DateCreated" },
                values: new object[] { Guid.NewGuid(), "Occupational Therapy", "Audrey", "March",  DateTime.Now }
                );

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentName", "ManagerFirstName", "ManagerLastName", "DateCreated" },
                values: new object[] { Guid.NewGuid(), "Nuclear Medicine", "Jesse", "Brewer",  DateTime.Now }
                );

            migrationBuilder.InsertData(
               table: "Department",
               columns: new[] { "DepartmentId", "DepartmentName", "ManagerFirstName", "ManagerLastName", "DateCreated" },
               values: new object[] { Guid.NewGuid(), "Food Services", "Gary", "Fraser", DateTime.Now }
               );
        }
    }
}
