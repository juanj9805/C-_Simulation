using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace simulacro.Migrations
{
    /// <inheritdoc />
    public partial class FouthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medicines_treatments_TreatmentId",
                table: "medicines");

            migrationBuilder.AlterColumn<int>(
                name: "TreatmentId",
                table: "medicines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_medicines_treatments_TreatmentId",
                table: "medicines",
                column: "TreatmentId",
                principalTable: "treatments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medicines_treatments_TreatmentId",
                table: "medicines");

            migrationBuilder.AlterColumn<int>(
                name: "TreatmentId",
                table: "medicines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_medicines_treatments_TreatmentId",
                table: "medicines",
                column: "TreatmentId",
                principalTable: "treatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
