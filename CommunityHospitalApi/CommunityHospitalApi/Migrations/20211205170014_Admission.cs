using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityHospitalApi.Migrations
{
    public partial class Admission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admission",
                columns: table => new
                {
                    AdmissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DischargeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrimaryDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryDiagnoses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NursingUnitId = table.Column<Guid>(type: "nvarchar(10)", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    BedNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admission", x => x.AdmissionId);
                    table.ForeignKey(
                        name: "FK_Admission_NursingUnit_NursingUnitId",
                        column: x => x.NursingUnitId,
                        principalTable: "NursingUnit",
                        principalColumn: "NursingUnitId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admission_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Admission_Physician_PhysicianId",
                        column: x => x.PhysicianId,
                        principalTable: "Physician",
                        principalColumn: "PhysicianId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admission_NursingUnitId",
                table: "Admission",
                column: "NursingUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Admission_PatientId",
                table: "Admission",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Admission_PhysicianId",
                table: "Admission",
                column: "PhysicianId");

            AdmissionSeed(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admission");
        }

        private static void AdmissionSeed(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Admission",
               columns: new[] { "AdmissionId", "PatientId", "AdmissionDate", "DischargeDate", "PrimaryDiagnosis", "SecondaryDiagnoses", "PhysicianId", "NursingUnitId", "RoomNumber", "BedNumber" },
               values: new object[] { Guid.NewGuid(), "47ACF83F-2F33-496C-A074-06F7BB922EE6", "11/2/2014", "11/4/2014", "Dementia", "Cataracts", "20320CF2-10AA-4FCC-A15A-06CC9E42B7AA", "1EAST", 4, 2 }
               );

            migrationBuilder.InsertData(
               table: "Admission",
               columns: new[] { "AdmissionId", "PatientId", "AdmissionDate", "DischargeDate", "PrimaryDiagnosis", "SecondaryDiagnoses", "PhysicianId", "NursingUnitId", "RoomNumber", "BedNumber" },
               values: new object[] { Guid.NewGuid(), "47ACF83F-2F33-496C-A074-06F7BB922EE6", "9/16/2014", "9/16/2014", "Abdominal Pain", "Inflammation Of The Gall Bladder", "20320CF2-10AA-4FCC-A15A-06CC9E42B7AA", "CCU", 2, 2 }
               );

            migrationBuilder.InsertData(
               table: "Admission",
               columns: new[] { "AdmissionId", "PatientId", "AdmissionDate", "DischargeDate", "PrimaryDiagnosis", "SecondaryDiagnoses", "PhysicianId", "NursingUnitId", "RoomNumber", "BedNumber" },
               values: new object[] { Guid.NewGuid(), "63ED633A-98EF-42C7-BA90-5B7E3B9A7219", "1/20/2015", "1/25/2015", "Child Birth", "Low Iron (Iron Defency Anemia)", "A689D7B8-0E77-4CC1-B91C-1CEAA9A4CC95", "3NORTH", 3, 1 }
               );

            migrationBuilder.InsertData(
               table: "Admission",
               columns: new[] { "AdmissionId", "PatientId", "AdmissionDate", "DischargeDate", "PrimaryDiagnosis", "SecondaryDiagnoses", "PhysicianId", "NursingUnitId", "RoomNumber", "BedNumber" },
               values: new object[] { Guid.NewGuid(), "63ED633A-98EF-42C7-BA90-5B7E3B9A7219", "10/17/2014", "10/23/2014", "Osteoarthritis Right Knee", "Total Right Knee Replacement", "E889103C-9A23-4669-A037-54BEA42EC4B8", "CCU", 5, 2 }
               );

            migrationBuilder.InsertData(
               table: "Admission",
               columns: new[] { "AdmissionId", "PatientId", "AdmissionDate", "DischargeDate", "PrimaryDiagnosis", "SecondaryDiagnoses", "PhysicianId", "NursingUnitId", "RoomNumber", "BedNumber" },
               values: new object[] { Guid.NewGuid(), "30ED9173-D6FC-4863-A71F-BEF98B1A10BE", "6/9/2014", "6/11/2014", "Pregnancy", "Abruptio Placentae", "A689D7B8-0E77-4CC1-B91C-1CEAA9A4CC95", "OR", 4, 1 }
               );

            migrationBuilder.InsertData(
               table: "Admission",
               columns: new[] { "AdmissionId", "PatientId", "AdmissionDate", "DischargeDate", "PrimaryDiagnosis", "SecondaryDiagnoses", "PhysicianId", "NursingUnitId", "RoomNumber", "BedNumber" },
               values: new object[] { Guid.NewGuid(), "30ED9173-D6FC-4863-A71F-BEF98B1A10BE", "11/4/2014", "11/5/2014", "Congestive Heart Failure", "Coronary Artery Disease", "FF51263C-40F1-4608-97BD-6F1FE3583FEC", "2EAST", 1, 1 }
               );

            migrationBuilder.InsertData(
               table: "Admission",
               columns: new[] { "AdmissionId", "PatientId", "AdmissionDate", "DischargeDate", "PrimaryDiagnosis", "SecondaryDiagnoses", "PhysicianId", "NursingUnitId", "RoomNumber", "BedNumber" },
               values: new object[] { Guid.NewGuid(), "528C579F-3DE8-49B0-A8F6-61CB5D7E159C", "6/20/2014", "6/29/2014", "Hyperemesis", "Pregnancy", "4B0CA7B3-8D6D-4D03-B077-F545E26DDA99", "1SOUTH", 1, 2 }
               );

            migrationBuilder.InsertData(
               table: "Admission",
               columns: new[] { "AdmissionId", "PatientId", "AdmissionDate", "DischargeDate", "PrimaryDiagnosis", "SecondaryDiagnoses", "PhysicianId", "NursingUnitId", "RoomNumber", "BedNumber" },
               values: new object[] { Guid.NewGuid(), "FCEA06E5-9FB2-4789-9E6E-DB18595AAAEE", "9/14/2014", "9/17/2014", "Pulmonary Edema", "Myocardial Infarction", "2F336B77-A145-4354-B95A-A76AACBBA1F3", "1WEST", 3, 1 }
               );

            migrationBuilder.InsertData(
               table: "Admission",
               columns: new[] { "AdmissionId", "PatientId", "AdmissionDate", "DischargeDate", "PrimaryDiagnosis", "SecondaryDiagnoses", "PhysicianId", "NursingUnitId", "RoomNumber", "BedNumber" },
               values: new object[] { Guid.NewGuid(), "30ED9173-D6FC-4863-A71F-BEF98B1A10BE", "2/26/2015", "3/5/2015", "Profound Depression", null, "FF51263C-40F1-4608-97BD-6F1FE3583FEC", "ICU", 4, 2 }
               );

            migrationBuilder.InsertData(
               table: "Admission",
               columns: new[] { "AdmissionId", "PatientId", "AdmissionDate", "DischargeDate", "PrimaryDiagnosis", "SecondaryDiagnoses", "PhysicianId", "NursingUnitId", "RoomNumber", "BedNumber" },
               values: new object[] { Guid.NewGuid(), "30ED9173-D6FC-4863-A71F-BEF98B1A10BE", "12/27/2014", "12/27/2014", "Cancer", "Dehydration", "0B4E76DE-0D2B-4B26-AD7D-761E6D6332D5", "ICU", 5, 1 }
               );

            migrationBuilder.InsertData(
               table: "Admission",
               columns: new[] { "AdmissionId", "PatientId", "AdmissionDate", "DischargeDate", "PrimaryDiagnosis", "SecondaryDiagnoses", "PhysicianId", "NursingUnitId", "RoomNumber", "BedNumber" },
               values: new object[] { Guid.NewGuid(), "528C579F-3DE8-49B0-A8F6-61CB5D7E159C", "12/26/2014", "1/1/2015", "Hysterectomy", null, "7F511DDC-9D33-47C6-9D4C-537E9F3A5EBB", "2WEST", 2, 1 }
               );
        }
    }
}
