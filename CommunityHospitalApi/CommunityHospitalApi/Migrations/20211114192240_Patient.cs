using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityHospitalApi.Migrations
{
    public partial class Patient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientHeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PatientWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patient_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_ProvinceId",
                table: "Patient",
                column: "ProvinceId");

            PatientSeed(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient");
        }

        private static void PatientSeed(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Patient",
               columns: new[] { "PatientId", "FirstName", "LastName", "Gender", "BirthDate", "StreetAddress", "City", "PostalCode", "HealthCard", "Allergies", "PatientHeight", "PatientWeight", "ProvinceId" },
               values: new object[] { Guid.NewGuid(), "Miyuki", "Riviera", "F", "12/6/1950", "44 Chatman St.", "Hamilton", "L8M 3P1", "8005509465", "NKA", 181, 93, Guid.Parse("F595A875-3D0E-4C6E-9AB9-8593A68D7E15") }
               );

            migrationBuilder.InsertData(
               table: "Patient",
               columns: new[] { "PatientId", "FirstName", "LastName", "Gender", "BirthDate", "StreetAddress", "City", "PostalCode", "HealthCard", "Allergies", "PatientHeight", "PatientWeight", "ProvinceId" },
               values: new object[] { Guid.NewGuid(), "Deunan", "Knute", "F", "4/24/1934", "452 Balmoral Apt 21", "Hamilton",  "L2E 4Y9", "1576918385", "Pork", 172, 100, Guid.Parse("F595A875-3D0E-4C6E-9AB9-8593A68D7E15") }
               );
            migrationBuilder.InsertData(
               table: "Patient",
               columns: new[] { "PatientId", "FirstName", "LastName", "Gender", "BirthDate", "StreetAddress", "City", "PostalCode", "HealthCard", "Allergies", "PatientHeight", "PatientWeight", "ProvinceId" },
               values: new object[] { Guid.NewGuid(), "Lois", "McAllister", "F", "9/2/2008", "27 Birchwood Place", "Carisle",  "L0R 2H0", "7043136016", "NKA", 101, 31, Guid.Parse("F595A875-3D0E-4C6E-9AB9-8593A68D7E15") }
               );

            migrationBuilder.InsertData(
              table: "Patient",
              columns: new[] { "PatientId", "FirstName", "LastName", "Gender", "BirthDate", "StreetAddress", "City", "PostalCode", "HealthCard", "Allergies", "PatientHeight", "PatientWeight", "ProvinceId" },
              values: new object[] { Guid.NewGuid(), "Will", "Powers", "M", "11/16/1976", "28 Park Road", "Orangeville", "L3M 4T9", "9859808912", "Demerol", 199, 97, Guid.Parse("F595A875-3D0E-4C6E-9AB9-8593A68D7E15") }
              );

            migrationBuilder.InsertData(
              table: "Patient",
              columns: new[] { "PatientId", "FirstName", "LastName", "Gender", "BirthDate", "StreetAddress", "City", "PostalCode", "HealthCard", "Allergies", "PatientHeight", "PatientWeight", "ProvinceId" },
              values: new object[] { Guid.NewGuid(), "Agnes", "Eckhart", "F", "1/29/1980", "1 Main Street", "Hamilton",  "L0R 125", "3126615214", "NKA", 167, 103, Guid.Parse("F595A875-3D0E-4C6E-9AB9-8593A68D7E15") }
              );

            migrationBuilder.InsertData(
              table: "Patient",
              columns: new[] { "PatientId", "FirstName", "LastName", "Gender", "BirthDate", "StreetAddress", "City", "PostalCode", "HealthCard", "Allergies", "PatientHeight", "PatientWeight", "ProvinceId" },
              values: new object[] { Guid.NewGuid(), "Jim", "Haruko", "M", "1/2/1966", "1 John Street", "Hamilton", "L8K 3J2", "1045665928", "Penicillin", 202, 107, Guid.Parse("F595A875-3D0E-4C6E-9AB9-8593A68D7E15") }
              );

            migrationBuilder.InsertData(
              table: "Patient",
              columns: new[] { "PatientId", "FirstName", "LastName", "Gender", "BirthDate", "StreetAddress", "City", "PostalCode", "HealthCard", "Allergies", "PatientHeight", "PatientWeight", "ProvinceId" },
              values: new object[] { Guid.NewGuid(), "Jonathan", "Capone", "M", "12/5/1945", "14 Maple Street", "Hamilton", "L9C 2S9", "8489928659", "NKA", 191, 122, Guid.Parse("F595A875-3D0E-4C6E-9AB9-8593A68D7E15") }
              );
        }
    }
}
