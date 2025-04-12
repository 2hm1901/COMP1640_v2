using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP1640.Migrations
{
    /// <inheritdoc />
    public partial class addmeetingrecrrd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecordLink",
                table: "Meetings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0acc19a9-dd56-47e4-844a-1acbf171294c", "AQAAAAIAAYagAAAAEEEOhX40y0gIgapG/9/mHOTSLkEjd4k+Ocj9afnGkF+0zR4LUVSGOCqVmcXf7wjTfw==", "40ae2f26-eda5-4418-b344-a09f20b34d63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "882c702e-29fb-4092-bfdc-6ce13dd1f434", "AQAAAAIAAYagAAAAECd3ymHlSe9DkhePWCE4SbPY9IXlxCSQ3GXMCiRduPgpry0MYzW8A44E4D+3UuADcg==", "8fa7faed-183d-4b13-a692-5e0967d07aa0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a913f1a3-9908-44f9-9ef3-d66e62c042bb", "AQAAAAIAAYagAAAAELLlWjWZC/J8NprRj/QNO9QaTRWYIG2wVlXbWYhz6ocaxl9fE5Z/ODDTPmg8i7IGWg==", "514c06c7-b88a-45cc-b92a-a888a171d02b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22b9b64b-dc28-4bd2-b127-89da98d874a3", "AQAAAAIAAYagAAAAEGw3AJeyNZAwTEc7DBCDQz12Wf5H/9AHY/j6h2r9E9wCWYUyBWqubufF13RgOea0hg==", "d6d90a65-19ad-485b-b9a7-7f438c1bf25c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f14bce95-eb94-4bae-8c45-50cbebf31550", "AQAAAAIAAYagAAAAEO0Zvum2334bJTtlpIzkVpu6Luue+X1BhqMBBMAND2YH7M6bRk2UAweSd+zzgq8lcw==", "0abf20b3-dc7d-4350-9454-acfe359e5dcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ce2a0b0-c190-4db0-9f69-b817345c7d5c", "AQAAAAIAAYagAAAAEIoxJr/9HP1P4PiCfF9alIKWkYMtFqdVjnGbYdk3hdGH9KH7Ir4pVZc/tnhbPiNfnA==", "fcebfac4-f7b3-4210-81e9-4616c28064e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "254e264c-dcc0-412a-9f42-d45223839378", "AQAAAAIAAYagAAAAEMEmDHAhgOUG/mj0j7760IHf/VZ3EwPIvHyVRBE8MeBwnE8IcKO+MzZ3/r01mLk7vA==", "7d305058-fde5-429c-8721-d9f82de2d559" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7563e02-71ed-4600-9712-914fa58cea3d", "AQAAAAIAAYagAAAAEEWXMZTKsPnOJReUEtbcGezkP7NncJuzxAyltnEl/L/62e2Gl2mudkSzcTIKy2FC5w==", "d59fc286-7618-4319-96bb-e22e16b2bb19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "130854c9-2e40-4a97-bca6-326715e91b34", "AQAAAAIAAYagAAAAEBG+AugMHTmXMJ1UyLHZAfCDRZU2Jz+aDYGMkXylgU5cUlqWYPiN9c3ZUDshw+BQ8g==", "66e6cfd0-8a64-425e-b356-6f3da83726c8" });

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 3, 9, 58, 530, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 3, 1, 58, 530, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 2, 46, 58, 530, DateTimeKind.Utc).AddTicks(8084));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecordLink",
                table: "Meetings");

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
        }
    }
}
