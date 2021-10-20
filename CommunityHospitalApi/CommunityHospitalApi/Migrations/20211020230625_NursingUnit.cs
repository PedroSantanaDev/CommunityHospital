using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityHospitalApi.Migrations
{
    public partial class NursingUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NursingUnit",
                columns: table => new
                {
                    NursingUnitId = table.Column<Guid>(type: "nvarchar(10)", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beds = table.Column<int>(type: "int", nullable: false),
                    Extension = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NursingUnit", x => x.NursingUnitId);
                });

            NursingUnitSeed(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NursingUnit");
        }

        private static void NursingUnitSeed(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds" ,"Extension" },
                values: new object[] {"1EAST", "Gynecology", "Joyce", "Davenport", 10, 3217 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"1NORTH", "Pediatrics", "Marsha", "Gravis", 10, 3214 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"1SOUTH", "Maternity", "Charlene", "Spinoza", 10, 3045 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"1WEST", "General Surgery", "Ruth", "Doxtater", 10, 3209 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"2EAST", "Medicine", "Alice", "MacKenzie", 10, 3077 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"2NORTH", "Orthopedics", "Jasmine", "Fox", 10, 3185 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"2SOUTH", "Short Stay", "Barbara", "Parsons", 10, 3153 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"2WEST", "Geriatrics", "Matilda", "Henry", 10, 3748 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"3EAST", "Neurology", "Shirley", "Piasecki", 10, 3524 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"3NORTH", "Psychiatry", "Leslie", "Charlong", 10, 3562 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"3SOUTH", "Oncology", "Gail", "Brown", 10, 3519 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"3WEST", "Respirology", "Pat", "Waschuk", 10, 3548 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"CCU", "Coronary Care Unit", "Della", "Marcaccio", 5, 3149 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"ER", "Emergency Room", "Shirley", "Patterson", 5, 3033 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"ICU", "Intensive Care Unit", "Mary", "Newport", 5, 3155 }
                );
            migrationBuilder.InsertData(
                table: "NursingUnit",
                columns: new[] { "NursingUnitId", "Specialty", "ManagerFirstName", "ManagerLastName", "Beds", "Extension" },
                values: new object[] {"OR", "Operating Room", "Debra", "Brock", 5, 3029 }
                );
        }
    }
}
