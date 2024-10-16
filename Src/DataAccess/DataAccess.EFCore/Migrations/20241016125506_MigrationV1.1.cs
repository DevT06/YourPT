using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class MigrationV11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentReflections_Assignments_AssignmentId",
                table: "AssignmentReflections");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Goals_GoalId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_GoalReflections_Goals_GoalId",
                table: "GoalReflections");

            migrationBuilder.DropIndex(
                name: "IX_GoalReflections_GoalId",
                table: "GoalReflections");

            migrationBuilder.DropIndex(
                name: "IX_AssignmentReflections_AssignmentId",
                table: "AssignmentReflections");

            migrationBuilder.AlterColumn<int>(
                name: "GoalId",
                table: "GoalReflections",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GoalId",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssignmentId",
                table: "AssignmentReflections",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GoalReflections_GoalId",
                table: "GoalReflections",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentReflections_AssignmentId",
                table: "AssignmentReflections",
                column: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentReflections_Assignments_AssignmentId",
                table: "AssignmentReflections",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Goals_GoalId",
                table: "Assignments",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GoalReflections_Goals_GoalId",
                table: "GoalReflections",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentReflections_Assignments_AssignmentId",
                table: "AssignmentReflections");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Goals_GoalId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_GoalReflections_Goals_GoalId",
                table: "GoalReflections");

            migrationBuilder.DropIndex(
                name: "IX_GoalReflections_GoalId",
                table: "GoalReflections");

            migrationBuilder.DropIndex(
                name: "IX_AssignmentReflections_AssignmentId",
                table: "AssignmentReflections");

            migrationBuilder.AlterColumn<int>(
                name: "GoalId",
                table: "GoalReflections",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GoalId",
                table: "Assignments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AssignmentId",
                table: "AssignmentReflections",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_GoalReflections_GoalId",
                table: "GoalReflections",
                column: "GoalId",
                unique: true,
                filter: "[GoalId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentReflections_AssignmentId",
                table: "AssignmentReflections",
                column: "AssignmentId",
                unique: true,
                filter: "[AssignmentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentReflections_Assignments_AssignmentId",
                table: "AssignmentReflections",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Goals_GoalId",
                table: "Assignments",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GoalReflections_Goals_GoalId",
                table: "GoalReflections",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "Id");
        }
    }
}
