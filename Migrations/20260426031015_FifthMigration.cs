using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace simulacro.Migrations
{
    /// <inheritdoc />
    public partial class FifthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medicines_treatments_TreatmentId",
                table: "medicines");

            migrationBuilder.RenameColumn(
                name: "TreatmentId",
                table: "medicines",
                newName: "TreatmentMedicineId");

            migrationBuilder.RenameIndex(
                name: "IX_medicines_TreatmentId",
                table: "medicines",
                newName: "IX_medicines_TreatmentMedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_medicines_treatmentsMedicines_TreatmentMedicineId",
                table: "medicines",
                column: "TreatmentMedicineId",
                principalTable: "treatmentsMedicines",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medicines_treatmentsMedicines_TreatmentMedicineId",
                table: "medicines");

            migrationBuilder.RenameColumn(
                name: "TreatmentMedicineId",
                table: "medicines",
                newName: "TreatmentId");

            migrationBuilder.RenameIndex(
                name: "IX_medicines_TreatmentMedicineId",
                table: "medicines",
                newName: "IX_medicines_TreatmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_medicines_treatments_TreatmentId",
                table: "medicines",
                column: "TreatmentId",
                principalTable: "treatments",
                principalColumn: "Id");
        }
    }
}
