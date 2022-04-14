using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDataAccess.Migrations
{
    public partial class RenameEmailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Email_People_PersonId",
                table: "Email");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Email",
                table: "Email");

            migrationBuilder.RenameTable(
                name: "Email",
                newName: "Emails");

            migrationBuilder.RenameIndex(
                name: "IX_Email_PersonId",
                table: "Emails",
                newName: "IX_Emails_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_People_PersonId",
                table: "Emails",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_People_PersonId",
                table: "Emails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.RenameTable(
                name: "Emails",
                newName: "Email");

            migrationBuilder.RenameIndex(
                name: "IX_Emails_PersonId",
                table: "Email",
                newName: "IX_Email_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Email",
                table: "Email",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Email_People_PersonId",
                table: "Email",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }
    }
}
