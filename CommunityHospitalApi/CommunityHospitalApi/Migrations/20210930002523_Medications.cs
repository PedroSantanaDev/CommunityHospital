using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityHospitalApi.Migrations
{
    public partial class Medications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medication",
                columns: table => new
                {
                    MedicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicationCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PackageSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitsUsedYtd = table.Column<int>(type: "int", nullable: false),
                    LastPrescribedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medication", x => x.MedicationId);
                    table.CheckConstraint("CK_Cost", "MedicationCost >= 0");
                });

            MedicationsSeed(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medication");
        }

        private static void MedicationsSeed(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Test Med", 1.23, "50 Tablets", "10 MG", "PRN", 1231, "5/22/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Tylenol Plain", 10.5, "100 Tablets", "250 MG.", "PRN", 500, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Tylenol No. 2", 12.5, "100 Tablets", "250 MG.", "PRN", 200, "5/26/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Tylenol No. 3", 14.5, "100 Tablets", "250 MG.", "PRN", 100, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Clindamycil (IVA)", 25, "100 CC.", "50 MG.", null, 24, "5/30/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Nitrogard - SR", 15, "50 Tablets", "1 MG.", "PRN", 20, "5/30/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Colace", 7.5, "500 ML Bottle", "25 MG/TABLESPOON", "HS", 25, "5/27/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Syntocinon (IVA)", 25, "100 CC", "50 UNITS", null, 15, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Heparin", 15, "100 CC", "1000 UNITS", "TID", 100, "5/24/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Demerol", 40, "100 CC", "50 MG", "Q 2-4 H", 75, "5/24/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Digoxin", 20, "20 Tablets", "10 MG", "BID", 50, "5/26/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "KCL (IVA)", 14, "100 CC", "100 MEQ", null, 40, "5/29/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Tetanus Toxoid", 40, "100 CC", "0.5 ML", "STAT", 2, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Prednisone", 50, "25 Tablets", "10 MG", "BID", 4, "5/31/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Ampicillin (IVA)", 22, "100 CC", "250 MG", null, 40, "5/24/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Neomycin", 15, "50 Tablets", "1 GM", "QID", 5, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Atenolol", 60, "10 Tablets", "50 MG", "OD", 2, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Magnesium Sulfate (IVA)", 20, "100CC", "8 MEQ/LITRE", null, 2, "5/31/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Sodium Citrate", 8, "500ML Bottle", "30 MG", "STAT", 1, "5/30/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Penicilin (G Sodium)(IVA)", 25, "100CC", "100,000 UNITS", null, 50, "5/29/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Morphine", 75, "100CC", "10MG", "Q4H", 12, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), ".5% Silver Nitrate", 10, "1 Litre Bottle", "0.5%", "BID", 1, "5/29/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Ventolin", 14, "12 Inhalers", null, "2 PUFFS Q4H", 20, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Lasix", 18, "50 Tablets", "20MG", "OD", 50, "5/26/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Phenergine", 35, "25 Tablets", "10MG", "Q4H AC HS", 4, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Streptomyocin Sulfate", 22, "100 CC", "100 mg", "OD", 6, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Aztreonan (Foruti)", 40, "100 CC", "500 mg", "Q8-12H", 1, "5/22/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Pentamidine Isethionate", 60, "100 CC", "100 mq", "OD", 2, "5/30/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Vancomycin Hcl (IVA)", 45, "100 CC", "1 gm", "Q12H", 2, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Persantine", 42, "100 Tablets", "50 mg", "QID", 12, "5/25/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Coumadin", 25, "100 CC", "10 mg", "BID", 10, "5/24/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Pentazine Lactate (IVA)", 55, "100 CC", "30 meq/litre", null, 2, "5/22/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Gravol", 8, "100 Tablets", "50 mg", "PRN", 200, "5/27/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Nifedipine (Aka Atalat)", 24, "100 CC", "10 mg", "TID", 20, "5/29/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Nitroglycerin Sublingual", 22, "100 Tablets", "0.1 mg", "PRN", 25, "5/24/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Dilaudid", 75, "100 CC", "4 mg/ml", "4-6H PRN", 4, "5/26/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Maveran", 15, "100 CC", "5 mg/ml", "TID PRN", 1, "5/29/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Voltaren", 24, "100 Tablets", "50 mg", "TID", 15, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Cytotec", 32, "50 Tablets", "200 mg", "QID with food", 25, "5/27/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Valium (Aka Diazepam)", 30, "100 Tablets", "2.5 mg", "BID", 50, "5/26/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Percocet", 60, "100 Tablets", "260 mg", "BID", 7, "5/25/2015" }
               );


            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Marcaine", 0.25, "100 CC", "10 MG", "EVERY 3 HRS PRN", 2, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Biscodyl", 40, "50 Suppositories", "10 MG", "AFTER 2 DAYS, NO BM", 8, "5/29/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Sulfonamide", 25, "100 Tablets", "100 MG", "Q4H", 2, "5/22/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Methotrexate", 20, "100 CC", "30 MG", "Q24H FOR 5 DAYS", 4, "5/31/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Vincristine Sulphate(IVA)", 45, "100 CC", "2 MG/ML", null, 5, "5/26/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Glucagon", 30, "100 CC", "1 MG", "STAT", 4, "5/24/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Insulin Lente", 40, "100 CC", "30 UNITS", "0730 if BS > 3.6", 20, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Toronto Insulin", 45, "100 CC", "3 UNITS", "PRN if BS > 8", 18, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Cardizem", 25, "100 Tablets", "30 MG", "QID", 10, "5/30/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Acetaminophen + 30 Cod.", 25, "100 Tablets", "250 mg", "Q 3-4 h PRN", 14, "5/26/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Cefoxtin (IVA)", 42, "100 CC", "1gm", "Q6h * 2", 2, "5/22/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Zantac", 40, "100 CC", "50 mg", "Q8h", 8, "5/27/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Premarin", 22, "50 Tablets", "1.25 mg", "QID 3wk on 1 wk off", 1, "5/22/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Captopril", 15, "50 Tablets", "25 mg", "TID", 2, "5/29/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Cephalothin (IVA)", 28, "100 CC", "1 gm", "Q 4-6 H", 8, "5/30/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Chloropromozine Hcl", 60, "200 CC", "10 mg", "Q 1-4 H", 2, "5/24/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Oxymorphone Hcl (IVA)", 41, "250 CC", "0.5 mg", "Q 4-6 H", 3, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Diphenhydramine", 25, "20 Tablets", "300 mg", "OD", 1, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Meperidine", 28, "100 CC", "50 MG", "Q3H PRN", 4, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Kefzol (IVA)", 40, "100 CC", "25 MG", null, 1, "5/25/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Prochlorperazine", 30, "25 Tablets", "10 MG", "Q6H PRN", 4, "5/22/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Pitocinon (IVA)", 42, "200 CC", "20 UNITS / 500 CC", null, 2, "5/31/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Albuterol Inhaler", 125, "Case Of 12", "5 MG / ML", "Q4H", 4, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Ceclor", 75, "50 Tablets", "250 MG", "TID * 7 DAYS", 4, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Mestinon", 22, "50 Tablets", "80 MG", "BID", 7, "5/24/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Amoxicillin", 40, "150 Tablets", "250 MG", "Q6H", 30, "5/31/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Theodur", 55, "100 Tablets", "150 MG", "Q8H", 4, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Motillium", 40, "100 Tablets", "10 MG", "TID", 8, "5/22/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Docusate Salts", 35, "100 Tablets", "150 MG", "OD", 4, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Hydrazaline", 70, "50 Tablets", "400 MG", "OD", 2, "5/25/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Synthroid (Levo.Sodium)", 60, "100 Tablets", ".05 MG", "OD", 2, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Wycillin (Pen.G Proc)", 80, "100 CC", "300,000 UNITS", "Q 6-12 H", 2, "5/31/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Cotazym", 45, "50 Capsules", "10 MG", "PC (BEFORE MEALS)", 5, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Novoferrogluc", 45, "50 Tablets", "300 MG", "TID", 1, "5/31/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Ventolin Inhaler", 85, "Case Of 12", "50 MG", "V PUFFS Q4H", 12, "5/30/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Medrol", 25, "100 Tablets", "150 MG", "BID", 15, "5/25/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Trovent Inhaler", 78, "Case Of 12", "50 MG", "V PUFFS Q4H", 6, "5/27/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Decadron", 55, "100 CC", "10 MG", "Q 4-6 H * 5 DAYS", 2, "5/25/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Methyloopa", 60, "50 Tablets", "30 MG", "BID", 6, "5/31/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Hydrochlorothiazine", 90, "100 Tablets", "30 MG", "BID", 8, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Eutonyl (Maoi)", 50, "50 Tablets", "25 MG", "OD", 12, "5/22/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Librium", 25, "50 Tablets", "25 MG", "QID", 50, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Hydrocortisone (IVA)", 25, "100 CC", "1 MG/MIN", null, 2, "5/24/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Intropin (IVA)", 40, "100 CC", "3 MCG/MIN", null, 1, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Gentamycin (IVA)", 22, "100 CC", "200 MG", "QID", 10, "5/28/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Keflin (IVA)", 35, "100 CC", "1 GM", "Q8H", 20, "5/24/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Mannitol (IVA)", 50, "100 CC", "10 G", null, 5, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Lidocaine Hcl (IVA)", 80, "100 CC", "2 MG/L", null, 10, "5/29/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Famotidine (IVA)", 18, "100 CC", "10 MG/L", null, 4, "5/23/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Nipride (IVA)", 30, "100 CC", "10 MG", "20 MEQ/MIN", 2, "5/25/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Cefuxorin (IVA)", 25, "100 CC", "5000 UNITS", null, 5, "5/29/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Acyclovir", 40, "200 Tablets", "200 MG", "Q4H", 25, "5/24/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Lorazepam", 12, "10 CC", "2 MG", "Q4H", 32, "5/25/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Modecate", 5, "10 CC", "120 MG", "PRN", 50, "5/31/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Zoloft", 14, "100 Tabs", "100 MG", "TID", 55, "5/26/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Prozac", 5, "50 Tablets", "100 MG", "PRN", 200, "5/22/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Lithium", 4.95, "100 Tablets", "200 MG", "TID", 150, "5/22/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Haldol", 80, "500 CC", "2 mg", "TID", 12, "5/31/2015" }
               );

            migrationBuilder.InsertData(
               table: "Medication",
               columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
               values: new object[] { Guid.NewGuid(), "Epinephrine Inhalor", 12.95, "12 Inhalors", ".5 MG", "TWICE EVERY 5 MIN.", 22, "5/29/2015" }
               );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Isosrbide Dinitrate", 8.59, "100 Tabs", "40 MG", "QID PO", 22, "5/25/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Zoltarin", 5.07, "250 Tabs", "10 MG", "AC PO", 15, "5/25/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Prazosin", 12.86, "50 Tabs", "1 MG", "BID", 0, "5/27/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Bentylol", 18.65, "25 Tabs", "24 MG", "TID", 14, "5/29/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Ventolin", 4.95, "150 Tabs", "20 MG", "TID PO", 19, "5/26/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Lanoxin", 2.45, "50 Tabs", "30 MG", "BID PO", 40, "5/27/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Lorazepam", 1.95, "200 Tabs", "10 MG", "TID PO", 100, "5/23/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Oramorphsr", 2.25, "100 Tabs", "5 MG", "Q4H PRN", 14, "5/30/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Thoridazine", 2.95, "250 ML Bottle", ".5 MG PER 10 MLS", "10 MLS OD", 12, "5/30/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Tamoxifen", 12.95, "100 Tabs", "30 MG", "OD", 23, "5/31/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Dilantin", 4.95, "100 Tabs", "100 MG", "BID", 200, "5/28/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Primidone", 2.95, "50 Tabs", "125 MG", "BID", 12, "5/29/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Haloperidol", 9.95, "25 Tabs", "1 MG", "QHS", 22, "5/30/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Benztropine", 1.56, "20 Tabs", ".5 MG", "HS", 15, "5/31/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Sinemet", 12.98, "100 Tabs", "50 MG", "TID", 25, "5/27/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Warfarin Sodium", 4.56, "200 Tabs", "10 MG", "TID", 22, "5/27/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Furosenide", 7.89, "100 Tabs", "25 MG", "Q6H", 2, "5/30/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Haldol", 14.95, "500 Tabs", "5MG", "BID", 200, "5/23/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Ativan", 12.95, "200 Tabs", "1 MG", "PRN", 275, "5/28/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Oxazepam", 2, "100 Tabs", "30 MG", "TID", 14, "5/24/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Thorazine", 40.75, "12 Bottles", "50 MG", "Q 1 - 4 HRS", 24, "5/27/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Cyclobenzaprine", 80.95, "250 Tabs", "10 MG", "BID", 28, "5/25/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Isoproterenol", 18.95, "100 Tabs", "10 MG", "BID", 14, "5/31/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Levadopa", 14.89, "50 Tabs", "100 MG", "BID", 18, "5/30/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Diclofenac", 65, "100 Tabs", "50 MG", "QAM", 4, "5/28/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Ciprofloxacin", 29.95, "200 Tabs", "25 MG", "QHS", 5, "5/27/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Amantidine", 12.95, "100 Tabs", "50 MG", "BID", 23, "5/31/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Carbamazepine", 18.95, "100 Tabs", "200 MG", "QID", 14, "5/30/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Prepulsid", 32.49, "200 Tabs", "10 MG", "QID", 27, "5/27/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Pravachol", 18.75, "100 Tabs", "25 MG", "QID", 7, "5/31/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Dimenhydrinate", 25, "1000 Tabs", "50 MG", "PRN", 175, "5/24/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Isordil", 14.86, "100 Tabs", "20 MG", "BID", 9, "5/25/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Nitro Spray", 22, "16 Sprayers", "10 MG", "2 SPRAYS PRN", 23, "5/27/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Meperidinehcl", 25, "50 Ampoules", "50 MG", "Q3H PRN", 4, "5/31/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Chlorpromazine", 32.99, "200 Tabs", "25 MG", "Q4H PRN", 5, "5/24/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Licarbonate", 8.95, "100 Tabs", "20 MG", "BID", 40, "5/27/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Lactulose", 18.99, "100 Tabs", "25 MG", "TID", 29, "5/29/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Ancef", 9.59, "50 Tabs", "10 MG", "QAM", 2, "5/25/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Allofurinol", 45.99, "20 Tabs", "75 MG", "BID", 5, "5/28/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Calcitonin", 9.95, "200 Tabs", "100 MG", "BID", 25, "5/30/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Orphenadrine", 25.95, "100 Tabs", "25 MG", "Q6H", 15, "5/22/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Glyburide", 200, "50 Tabs", "5 MG", "BID", 22, "5/27/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Cloxacilin", 19.95, "1 Litre Bottle", "50 MG", "100 MLBID", 14, "5/30/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Paveral", 17.75, "100 Tabs", "20 MG", "Q4H", 12, "5/29/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Novasen", 25.95, "200 Tabs", "325 MG", "Q6H", 16, "5/24/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Amitriptyline", 35.95, "100 Tabs", "150 MG", "TID", 15, "5/23/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Cefuroxime", 22.95, "50 Tabs", "500 MG", "Q12H", 5, "5/22/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Nardil", 38.95, "25 Tabs", "60 MG", "OD", 7, "5/22/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Navane", 5.95, "100 Tabs", "30 MG", "OD", 16, "5/25/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Lithium Citrate", 25, "200 Tabs", "600 MG", "QID", 25, "5/27/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Phenobarbital", 10.95, "100 Tabs", "30 MG", "BID", 40, "5/28/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Humulin", 23.95, "50 Tabs", "25 UNITS", "QID", 4, "5/24/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Insulin", 18, "50 Ampoules", "12 UNITS", "QID SC", 85, "5/24/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Streptokinase", 35, "25 Ampoules", "30 UNITS", "OD IV", 14, "5/28/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Phenergan", 17.89, "12 Ampoules", "10 MG", "QID IM", 15, "5/28/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Serax", 14.95, "100 Tabs", "30 MG", "Q8HRS", 12, "5/28/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Lopressor", 28.95, "50 Tabs", "100 MG", "BID", 17, "5/24/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Lopid", 18.95, "50 Tabs", "600 MG", "BID", 14, "5/26/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Novulin", 85.95, "12 Ampoules", "12 UNITS", "TID SC", 15, "5/31/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Anapronil", 1.73, "100 Tabs", "25 MG", "BID", 4, "5/26/2015" }
              );

            migrationBuilder.InsertData(
              table: "Medication",
              columns: new[] { "MedicationId", "MedicationDescription", "MedicationCost", "PackageSize", "Strength", "Sig", "UnitsUsedYtd", "LastPrescribedDate" },
              values: new object[] { Guid.NewGuid(), "Toradol", 18, "100 CC", "30 mg", "Q6H", 2, "5/31/2015" }
              );
        }
    }
}
