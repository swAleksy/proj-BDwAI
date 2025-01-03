using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projBDwAI.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Priorities_PriorityId",
                table: "Bugs");

            migrationBuilder.AddColumn<int>(
                name: "PriorityId1",
                table: "Bugs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_PriorityId1",
                table: "Bugs",
                column: "PriorityId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Priorities_PriorityId",
                table: "Bugs",
                column: "PriorityId",
                principalTable: "Priorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Priorities_PriorityId1",
                table: "Bugs",
                column: "PriorityId1",
                principalTable: "Priorities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Priorities_PriorityId",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Priorities_PriorityId1",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_PriorityId1",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "PriorityId1",
                table: "Bugs");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Priorities_PriorityId",
                table: "Bugs",
                column: "PriorityId",
                principalTable: "Priorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
