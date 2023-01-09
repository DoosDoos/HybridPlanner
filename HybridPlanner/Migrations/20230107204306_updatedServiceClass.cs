using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HybridPlanner.Migrations
{
    /// <inheritdoc />
    public partial class updatedServiceClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Parties_PartyId",
                table: "Services");

            migrationBuilder.AlterColumn<int>(
                name: "PartyId",
                table: "Services",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Parties_PartyId",
                table: "Services",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Parties_PartyId",
                table: "Services");

            migrationBuilder.AlterColumn<int>(
                name: "PartyId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Parties_PartyId",
                table: "Services",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
