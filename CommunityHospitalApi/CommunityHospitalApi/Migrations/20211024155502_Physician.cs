using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityHospitalApi.Migrations
{
    public partial class Physician : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Physician",
                columns: table => new
                {
                    PhysicianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OHIPRegistration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Physician", x => x.PhysicianId);
                });

            PhysicianSeed(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Physician");
        }

        private static void PhysicianSeed(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty",  "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Remy", "Hadley", "Internist", "Ext. 1733", 179004 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Emmett", "Brown", "Cardiologist", "Ext. 1829", 120950 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Samantha", "Carter", "General Surgeon", "905-575-2145", 184114 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Beverly", "Crusher", "Obstetrician/Gynecologist", "Ext. 1285", 118755 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Julius", "Hibbert", "Gastroenterologist", "Ext. 1635", 105585 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Sheldon", "Cooper", "Psychiatrist", "905-684-9283", 131744 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Leonard", "Hofstadter", "Oncologist", "905-524-5635", 161380 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Leslie", "Winkle", "Neurologist", "Ext. 1772", 186542 }
               );


            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Nick", "Riviera", "Pediatrician", "Ext. 1452", 197920 }
               );


            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Dana", "Scully", "Orthopaedic Surgeon", "Ext. 1937", 119456 }
               );


            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Benjamin", "Pierce", "Respirologist", "Ext. 1635", 177863 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Abigail", "Bartlet", "Cardiovascular Surgeon", "Ext. 1539", 141605 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Gregory", "House", "Nuclear Medicine", "Ext. 1964", 132370 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Lilith", "Sternin", "Gerontologist", "Ext. 1442", 160733 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Henry", "Higgins", "Urologist", "Ext. 1658", 199255 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Henry", "Blake", "Gastroenterologist", "Ext. 2654", 105769 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Cristina", "Yang", "Nuclear Medicine", "Ext. 2918", 169301 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Yuri", "Zhivago", "Gerontologist", "Ext. 2729", 129084 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Henry", "Jones", "Oncologist", "905-555-1212", 191010 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Rajesh", "Koothrappali", "General Surgeon", "Ext. 2509", 164098 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Lisa", "Cuddy", "Obstetrician/Gynecologist", "Ext. 2921", 179194 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Simon", "Tam", "Cardiologist", "905-575-1212", 146817 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Doogie", "Howser", "Pediatrician", "Ext. 2933", 161988 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Katherine", "Pulaski", "Neurologist", "Ext. 2021", 126898 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Allison", "Cameron", "Psychiatrist", "Ext. 2338", 173752 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Wellington", "Yueh", "Cardiovascular Surgeon", "Ext. 2587", 133244 }
               );

            migrationBuilder.InsertData(
               table: "Physician",
               columns: new[] { "PhysicianId", "FirstName", "LastName", "Specialty", "Phone", "OHIPRegistration" },
               values: new object[] { Guid.NewGuid(), "Christine", "Chapel", "Respirologist", "Ext. 2285", 139551 }
               );
        }
    }
}
