using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubMembershipApplication.Migrations
{
    /// <inheritdoc />
    public partial class updateaddressSeondLineName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressSendedLine",
                table: "Users",
                newName: "AddressSecondLine");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressSecondLine",
                table: "Users",
                newName: "AddressSendedLine");
        }
    }
}
