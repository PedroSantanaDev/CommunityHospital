using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityHospitalApi.Migrations
{
    public partial class Vendors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchasesYtd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorId);
                    table.ForeignKey(
                        name: "FK_Vendor_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_ProvinceId",
                table: "Vendor",
                column: "ProvinceId");

           VendorSeed(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendor");
        }


       private static void VendorSeed(MigrationBuilder migrationBuilder)
       {
            migrationBuilder.InsertData(
               table: "Vendor",
               columns: new[] {     "VendorId",      "VendorName",           "StreetAddress",     "City",   "ProvinceId",                           "PostalCode", "ContactFirstName", "ContactLastName", "PurchasesYtd" },
               values: new object[] { Guid.NewGuid(), "Thomas Med Supplies", "42 Cricket Avenue", "London", "F595A875-3D0E-4C6E-9AB9-8593A68D7E15", "L5G 4R6",     "Katya",           "Kinski",           2500 }
               );

            migrationBuilder.InsertData(
               table: "Vendor",
               columns: new[] { "VendorId", "VendorName", "StreetAddress", "City", "ProvinceId", "PostalCode", "ContactFirstName", "ContactLastName", "PurchasesYtd" },
               values: new object[] { Guid.NewGuid(), "Dickson Toiletries", "15 Lauris Avenue", "Cambridge", "F595A875-3D0E-4C6E-9AB9-8593A68D7E15", "L2Q 4B6", "Tiffany", "Pratt", 1200 }
               );

            migrationBuilder.InsertData(
               table: "Vendor",
               columns: new[] { "VendorId", "VendorName", "StreetAddress", "City", "ProvinceId", "PostalCode", "ContactFirstName", "ContactLastName", "PurchasesYtd" },
               values: new object[] { Guid.NewGuid(), "Trays R Us", "275 Sterling St.", "Hamilton", "F595A875-3D0E-4C6E-9AB9-8593A68D7E15", "L8R 4G6", "Nisha", "Batra", 3000 }
               );

            migrationBuilder.InsertData(
               table: "Vendor",
               columns: new[] { "VendorId", "VendorName", "StreetAddress", "City", "ProvinceId", "PostalCode", "ContactFirstName", "ContactLastName", "PurchasesYtd" },
               values: new object[] { Guid.NewGuid(), "Franklin Medical", "725 Adelaide St.", "Toronto", "F595A875-3D0E-4C6E-9AB9-8593A68D7E15", "L2E 5W2", "Harry", "Martin", 1500 }
               );

            migrationBuilder.InsertData(
               table: "Vendor",
               columns: new[] { "VendorId", "VendorName", "StreetAddress", "City", "ProvinceId", "PostalCode", "ContactFirstName", "ContactLastName", "PurchasesYtd" },
               values: new object[] { Guid.NewGuid(), "Nutri-Tech Inc.", "2125 Lundys Lane", "Niagara Falls", "F595A875-3D0E-4C6E-9AB9-8593A68D7E15", "L2Z 4E2", "Peter", "Petrelli", 250 }
               );

            migrationBuilder.InsertData(
               table: "Vendor",
               columns: new[] { "VendorId", "VendorName", "StreetAddress", "City", "ProvinceId", "PostalCode", "ContactFirstName", "ContactLastName", "PurchasesYtd" },
               values: new object[] { Guid.NewGuid(), "Ashley Medical Supplies", "487 Hallman Ave.", "Kitchener", "F595A875-3D0E-4C6E-9AB9-8593A68D7E15", "L7Y 9M4", "Matt", "McAllister", 400 }
               );

            migrationBuilder.InsertData(
               table: "Vendor",
               columns: new[] { "VendorId", "VendorName", "StreetAddress", "City", "ProvinceId", "PostalCode", "ContactFirstName", "ContactLastName", "PurchasesYtd" },
               values: new object[] { Guid.NewGuid(), "American Medical Specialities", "3701 Jefferson Parkway", "Fort Erie", "F595A875-3D0E-4C6E-9AB9-8593A68D7E15", "L3R 1T8", "Naomi", "Julien", 300 }
               );

            migrationBuilder.InsertData(
               table: "Vendor",
               columns: new[] { "VendorId", "VendorName", "StreetAddress", "City", "ProvinceId", "PostalCode", "ContactFirstName", "ContactLastName", "PurchasesYtd" },
               values: new object[] { Guid.NewGuid(), "AMF Medical Corp.", "265 Burlington St.", "Hamilton", "F595A875-3D0E-4C6E-9AB9-8593A68D7E15", "L9F 8B4", "Julia", "Baker", 200000 }
               );
       }
    }
}
