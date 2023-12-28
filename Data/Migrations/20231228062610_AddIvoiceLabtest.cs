using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthApp.Data.Migrations
{
    public partial class AddIvoiceLabtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirm",
                table: "Appointment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaymentCompleted",
                table: "Appointment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVisited",
                table: "Appointment",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirm",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "IsPaymentCompleted",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "IsVisited",
                table: "Appointment");
        }
    }
}
