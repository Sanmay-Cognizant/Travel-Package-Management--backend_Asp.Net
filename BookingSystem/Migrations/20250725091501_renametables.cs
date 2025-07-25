using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Migrations
{
    /// <inheritdoc />
    public partial class renametables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssistanceRequests_Users_UserID",
                table: "AssistanceRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Packages_PackageID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Users_UserID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_Bookings_BookingID",
                table: "Insurances");

            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_Users_UserID",
                table: "Insurances");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Bookings_BookingID",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Packages_PackageID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserID",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Packages",
                table: "Packages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Insurances",
                table: "Insurances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssistanceRequests",
                table: "AssistanceRequests");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "tUsers");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "tReviews");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "tPayments");

            migrationBuilder.RenameTable(
                name: "Packages",
                newName: "tPackages");

            migrationBuilder.RenameTable(
                name: "Insurances",
                newName: "tInsurances");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "tBookings");

            migrationBuilder.RenameTable(
                name: "AssistanceRequests",
                newName: "tAssistanceRequests");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserID",
                table: "tReviews",
                newName: "IX_tReviews_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_PackageID",
                table: "tReviews",
                newName: "IX_tReviews_PackageID");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_BookingID",
                table: "tPayments",
                newName: "IX_tPayments_BookingID");

            migrationBuilder.RenameIndex(
                name: "IX_Insurances_UserID",
                table: "tInsurances",
                newName: "IX_tInsurances_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Insurances_BookingID",
                table: "tInsurances",
                newName: "IX_tInsurances_BookingID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_UserID",
                table: "tBookings",
                newName: "IX_tBookings_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_PackageID",
                table: "tBookings",
                newName: "IX_tBookings_PackageID");

            migrationBuilder.RenameIndex(
                name: "IX_AssistanceRequests_UserID",
                table: "tAssistanceRequests",
                newName: "IX_tAssistanceRequests_UserID");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "tUsers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "tUsers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tUsers",
                table: "tUsers",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tReviews",
                table: "tReviews",
                column: "ReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tPayments",
                table: "tPayments",
                column: "PaymentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tPackages",
                table: "tPackages",
                column: "PackageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tInsurances",
                table: "tInsurances",
                column: "InsuranceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tBookings",
                table: "tBookings",
                column: "BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tAssistanceRequests",
                table: "tAssistanceRequests",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_tUsers_ContactNumber",
                table: "tUsers",
                column: "ContactNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tUsers_Email",
                table: "tUsers",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tAssistanceRequests_tUsers_UserID",
                table: "tAssistanceRequests",
                column: "UserID",
                principalTable: "tUsers",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tBookings_tPackages_PackageID",
                table: "tBookings",
                column: "PackageID",
                principalTable: "tPackages",
                principalColumn: "PackageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tBookings_tUsers_UserID",
                table: "tBookings",
                column: "UserID",
                principalTable: "tUsers",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tInsurances_tBookings_BookingID",
                table: "tInsurances",
                column: "BookingID",
                principalTable: "tBookings",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tInsurances_tUsers_UserID",
                table: "tInsurances",
                column: "UserID",
                principalTable: "tUsers",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tPayments_tBookings_BookingID",
                table: "tPayments",
                column: "BookingID",
                principalTable: "tBookings",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tReviews_tPackages_PackageID",
                table: "tReviews",
                column: "PackageID",
                principalTable: "tPackages",
                principalColumn: "PackageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tReviews_tUsers_UserID",
                table: "tReviews",
                column: "UserID",
                principalTable: "tUsers",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tAssistanceRequests_tUsers_UserID",
                table: "tAssistanceRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_tBookings_tPackages_PackageID",
                table: "tBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_tBookings_tUsers_UserID",
                table: "tBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_tInsurances_tBookings_BookingID",
                table: "tInsurances");

            migrationBuilder.DropForeignKey(
                name: "FK_tInsurances_tUsers_UserID",
                table: "tInsurances");

            migrationBuilder.DropForeignKey(
                name: "FK_tPayments_tBookings_BookingID",
                table: "tPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_tReviews_tPackages_PackageID",
                table: "tReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_tReviews_tUsers_UserID",
                table: "tReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tUsers",
                table: "tUsers");

            migrationBuilder.DropIndex(
                name: "IX_tUsers_ContactNumber",
                table: "tUsers");

            migrationBuilder.DropIndex(
                name: "IX_tUsers_Email",
                table: "tUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tReviews",
                table: "tReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tPayments",
                table: "tPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tPackages",
                table: "tPackages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tInsurances",
                table: "tInsurances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tBookings",
                table: "tBookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tAssistanceRequests",
                table: "tAssistanceRequests");

            migrationBuilder.RenameTable(
                name: "tUsers",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "tReviews",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "tPayments",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "tPackages",
                newName: "Packages");

            migrationBuilder.RenameTable(
                name: "tInsurances",
                newName: "Insurances");

            migrationBuilder.RenameTable(
                name: "tBookings",
                newName: "Bookings");

            migrationBuilder.RenameTable(
                name: "tAssistanceRequests",
                newName: "AssistanceRequests");

            migrationBuilder.RenameIndex(
                name: "IX_tReviews_UserID",
                table: "Reviews",
                newName: "IX_Reviews_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_tReviews_PackageID",
                table: "Reviews",
                newName: "IX_Reviews_PackageID");

            migrationBuilder.RenameIndex(
                name: "IX_tPayments_BookingID",
                table: "Payments",
                newName: "IX_Payments_BookingID");

            migrationBuilder.RenameIndex(
                name: "IX_tInsurances_UserID",
                table: "Insurances",
                newName: "IX_Insurances_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_tInsurances_BookingID",
                table: "Insurances",
                newName: "IX_Insurances_BookingID");

            migrationBuilder.RenameIndex(
                name: "IX_tBookings_UserID",
                table: "Bookings",
                newName: "IX_Bookings_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_tBookings_PackageID",
                table: "Bookings",
                newName: "IX_Bookings_PackageID");

            migrationBuilder.RenameIndex(
                name: "IX_tAssistanceRequests_UserID",
                table: "AssistanceRequests",
                newName: "IX_AssistanceRequests_UserID");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "PaymentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Packages",
                table: "Packages",
                column: "PackageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Insurances",
                table: "Insurances",
                column: "InsuranceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssistanceRequests",
                table: "AssistanceRequests",
                column: "RequestID");

            migrationBuilder.AddForeignKey(
                name: "FK_AssistanceRequests_Users_UserID",
                table: "AssistanceRequests",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Packages_PackageID",
                table: "Bookings",
                column: "PackageID",
                principalTable: "Packages",
                principalColumn: "PackageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Users_UserID",
                table: "Bookings",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_Bookings_BookingID",
                table: "Insurances",
                column: "BookingID",
                principalTable: "Bookings",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_Users_UserID",
                table: "Insurances",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Bookings_BookingID",
                table: "Payments",
                column: "BookingID",
                principalTable: "Bookings",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Packages_PackageID",
                table: "Reviews",
                column: "PackageID",
                principalTable: "Packages",
                principalColumn: "PackageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserID",
                table: "Reviews",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
