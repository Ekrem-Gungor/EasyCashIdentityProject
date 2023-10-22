using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    public partial class mig_add_ralation_cA_aU : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserId",
                table: "CustomerAccounts");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "CustomerAccounts",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccounts_AppUserId",
                table: "CustomerAccounts",
                newName: "IX_CustomerAccounts_AppUserID");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserID",
                table: "CustomerAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserID",
                table: "CustomerAccounts",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserID",
                table: "CustomerAccounts");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "CustomerAccounts",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccounts_AppUserID",
                table: "CustomerAccounts",
                newName: "IX_CustomerAccounts_AppUserId");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "CustomerAccounts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserId",
                table: "CustomerAccounts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
