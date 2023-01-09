using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HybridPlanner.Migrations
{
    /// <inheritdoc />
    public partial class ChangeServiceClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Locations_LocationId",
                table: "Services");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Services",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PartyId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartyId",
                table: "Parties",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_PartyId",
                table: "Services",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Parties_PartyId",
                table: "Parties",
                column: "PartyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parties_Parties_PartyId",
                table: "Parties",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Locations_LocationId",
                table: "Services",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Parties_PartyId",
                table: "Services",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parties_Parties_PartyId",
                table: "Parties");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Locations_LocationId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Parties_PartyId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_PartyId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Parties_PartyId",
                table: "Parties");

            migrationBuilder.DropColumn(
                name: "PartyId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "PartyId",
                table: "Parties");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Locations_LocationId",
                table: "Services",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
