using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP1640.Migrations
{
    /// <inheritdoc />
    public partial class addmeeting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Topic",
                table: "Meetings",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "ScheduledTime",
                table: "Meetings",
                newName: "Deadline");

            migrationBuilder.RenameColumn(
                name: "OrganizerId",
                table: "Meetings",
                newName: "StudentId");

            migrationBuilder.AddColumn<string>(
                name: "MeetingLink",
                table: "Meetings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Meetings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "470f8b47-c38e-4090-9ceb-5241a9d0b21f", "AQAAAAIAAYagAAAAEDM3a1hv+QDg/TgIam8SDw4FAd962sjUnZFrxrYIUV2e/VTAaARzMVqw5NTjBUT0iA==", "03dccd83-c725-4e0d-950e-4769f6a65bc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5a49b8a-074d-4a31-8d18-6fb13c4aa1ad", "AQAAAAIAAYagAAAAEFBxZtxSsKf2GSBE0h9FzTykpUvbUoT+2O+RoWVupfXSkZt5GK4mj5aszu5hJjs04A==", "5ec47238-f797-46e3-b5a3-81d5c1acef5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72022aaf-120d-437a-a094-df305c355ac9", "AQAAAAIAAYagAAAAENJtd8hm8z9DtLv8bQbCHUWBTQHIHvRKp5FTrIFDdZggb1g4SIyEeeXVuwb8z5/xfA==", "ca374f9e-ed8f-42a6-b622-afb8e0034a04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8d11138-2ca1-429d-873d-e1ea605c62e1", "AQAAAAIAAYagAAAAEESYUGvvtvLdV567zGZmZUwe/92o6oQADDXYZg2IIzQ6jetyiXasT814RJ5IBPB48w==", "014b5529-9afa-410e-bb6d-f8c88178fc55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db35a21b-8098-4a27-b0f8-e59ad6cc140d", "AQAAAAIAAYagAAAAEO33fklruefZW/kJbdiOKUQIAN/9x9O/adgaY8qtfj0cvmFJOWiD/U+i/3Y/OLya1w==", "94fd903e-e406-405c-a824-a07a3e396681" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "897c1264-c642-493c-81b2-6018a72b35be", "AQAAAAIAAYagAAAAEALX6SSrfyRSD7tgbrU0WeP2cqvkPnRuY2USf2RTfOD+dVSQSN1VfEpL7FvmKlDjgQ==", "7581ee43-e6bb-4cd6-86c5-0a07978701a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47d44162-a658-4a70-adb8-0961e1e42d73", "AQAAAAIAAYagAAAAEG6n1eH6dkJqEdIF7gzjRKtDyajvqhQYikIT8EEcP7LccfQFwiSkpFqcu0XlIjy2hg==", "bef36bc6-9fd6-4700-aadb-a7672479ca3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8ef9235-0fc9-4e6d-b56c-1f55da861a92", "AQAAAAIAAYagAAAAEFCfY4Lu/JvgK9DjSVbKHW5RJ4sX8c5hHRSaYvPgqT4afsklczsdT0wjBSHdNJ+Vgw==", "62d92d40-1aca-467a-8c31-7705ead8f600" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d169fad5-884e-4979-a3f5-c8603e6687cf", "AQAAAAIAAYagAAAAEP2hd/FRPs8x+If0SXsqeA58a3409LnCLntHpI4Bj+MZsgML0wl1WoQ5o0m7H3dMGQ==", "22863a14-d86c-46e6-aa5f-d7fcf90321b8" });

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 2, 28, 56, 377, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 2, 20, 56, 377, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 2, 5, 56, 377, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_StudentId",
                table: "Meetings",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_TeacherId",
                table: "Meetings",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_AspNetUsers_StudentId",
                table: "Meetings",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_AspNetUsers_TeacherId",
                table: "Meetings",
                column: "TeacherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_AspNetUsers_StudentId",
                table: "Meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_AspNetUsers_TeacherId",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_StudentId",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_TeacherId",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "MeetingLink",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Meetings");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Meetings",
                newName: "Topic");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Meetings",
                newName: "OrganizerId");

            migrationBuilder.RenameColumn(
                name: "Deadline",
                table: "Meetings",
                newName: "ScheduledTime");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b742c3fe-74b8-4a52-bd01-1785eb88ede0", "AQAAAAIAAYagAAAAECWuooRe6WUQq8zityyotPgVMxGsHg2wMhq9l6BkfWCzTU4HC1At2unMBGn/owf40A==", "5282096f-0271-48db-b437-0708db8ab577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83edc306-3199-4b4b-880a-94a39647303c", "AQAAAAIAAYagAAAAEGLSs/VWx9LLwJkMhOPbgmj357iMwVAFe22pd2Wzg0Mj/Oj62USF5fxoT6TUoqkQDA==", "a75cfc6f-b34c-47f8-a4e8-23714bdb939b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9797d0b-d20a-45c6-8155-25e03872356c", "AQAAAAIAAYagAAAAEECVnvTYkiV+khJO+eSY7fpTasz30bgzgjkmZoR5euaXML7IuFujLop8QDKdyDqF5g==", "766f87fe-a587-47d6-bd7f-b70b43c10c45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bee82a22-7977-430e-ab5a-a11180776c1a", "AQAAAAIAAYagAAAAEKS/iuwPMzIcq6q66S6v9q5T/Z6VsGWx+9nOxEWOZkjqwNB66PbFGwkZYHYKcsZ2XA==", "a7530f3c-cf55-42eb-97c8-cdf21120d67b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95551c19-cdb0-44ef-91b0-8613366ff382", "AQAAAAIAAYagAAAAEP+/y2a9ecI2QgN8h2V71ToPHg1RO3yiL7TzUz2ZO8dSIQ+RPV4N3NDWCULfYgOrSA==", "104b8f42-1905-4dc4-9e31-8e6aae89e80c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c412d730-613e-4cde-868b-79e584cebfc8", "AQAAAAIAAYagAAAAEAnW2RzupGQsiSsX8qLCFhQgeGJVPP4c+oniTW6hv7xtlI4Ybvbr5gPJ6WDTxkgLhg==", "ec300780-084f-4f97-b3f4-fab595c9ee17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdf8b7f8-0d8d-4fed-8b70-86b6580dfa68", "AQAAAAIAAYagAAAAEPi6TQZpFxjiE530dQLkuIP84millwahsNiqVRKI+El6QgASJy3OBUvGbIanuEthAg==", "b2fbd59f-75ea-407a-8f99-71bcaf70ece5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cd25d51-5e94-451f-a243-5a919623ace7", "AQAAAAIAAYagAAAAEOmJ+zdgxcAalKGhsOqV43cgifHJZZlexK0ffrC5JL/AtPsAwYc83AulWghlK5mH3w==", "c929f5e0-cf6c-44d2-99fa-102d8e4f80ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "805802f8-33c1-480a-ab88-a7a5558339a8", "AQAAAAIAAYagAAAAECJ2LK6+Vh1ltuL2pIA0pJ22+mssdqC9e3NX/jgkoPmW8OI6C2YGCaaFSReMafs5yQ==", "67e10387-cb2c-48cf-b91c-384e7a671689" });

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2025, 3, 20, 2, 36, 20, 152, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2025, 3, 20, 2, 28, 20, 152, DateTimeKind.Utc).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2025, 3, 20, 2, 13, 20, 152, DateTimeKind.Utc).AddTicks(1740));
        }
    }
}
