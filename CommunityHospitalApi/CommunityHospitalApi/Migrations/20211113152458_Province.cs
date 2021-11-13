using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityHospitalApi.Migrations
{
    public partial class Province : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvinceCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceId);
                });

            ProvinceSeed(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Province");
        }

        public static void ProvinceSeed(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "AB", "Alberta" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "BC", "British Columbia" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "MB", "Manitoba" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "NB", "New Brunswick" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "NL", "Newfoundland and Labrador" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "NT", "Northwest Territories" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "NS", "Nova Scotia" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "NU", "Nunavut" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "ON", "Ontario" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "PE", "Prince Edward Island" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "QC", "Quebec" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "SK", "Saskatchewan" }
               );
            migrationBuilder.InsertData(
               table: "Province",
               columns: new[] { "ProvinceId", "ProvinceCode", "ProvinceName" },
               values: new object[] { Guid.NewGuid(), "YT", "Yukon" }
               );
        }
    }
}
