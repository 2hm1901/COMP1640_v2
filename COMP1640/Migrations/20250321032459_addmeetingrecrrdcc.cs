using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP1640.Migrations
{
    /// <inheritdoc />
    public partial class addmeetingrecrrdcc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RecordLink",
                table: "Meetings",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2751b76-acfe-43f3-848c-b44087a65668", "AQAAAAIAAYagAAAAEI3Y4yViR/YKwfvnMDqbBOGz5u3jnzPgTgR2w5Rhm/VsehwMhjj7j+nShrYKRxUVjA==", "cc3bd1bc-dbf0-4c91-940f-28b690608a62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac44e185-e9cd-44da-a237-a96847453588", "AQAAAAIAAYagAAAAECgXut6WFJR+6zW0VaudNtKzoPHOW1tb7GMMQCjYkofW0tbK5+Bd0r3DG90BJ/m5Hg==", "76133d32-b5d0-4671-8a32-8fd74fcbacb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85cb30c2-0482-4c55-bce8-937aedcb52df", "AQAAAAIAAYagAAAAECwqZMOVbCo0hZAxeVBTYPCgqZp4LvKu4FtXsCDZYBa/5UF4eJ4Cs7FxgECAtNmydw==", "76112e00-b9b0-4e6d-bda9-c29a471917f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44f865f8-e2fc-44b8-9c3a-215444222343", "AQAAAAIAAYagAAAAEEo0zxa6mPhP5pSULkuLqFkYWTroiXPeGpgQvK3CH/tj2pkTaK8IZMhEwsH9nZehbQ==", "08e3a05c-fa7d-42cc-8064-d143bd059b0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b6a562d-1e27-4bee-8564-6ab7203a419c", "AQAAAAIAAYagAAAAEN5u5LrU/OtzJR2BFiQVRNWLInnz8CVnzLTgxAZJZocKC4LmBuqyS1sKkksHS3sPGg==", "284bf856-5cb7-47a5-8cc9-0c4e5ad71b2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdd71ea4-750a-422d-bd86-3f1fbaf8561b", "AQAAAAIAAYagAAAAEPmc4ml5mcPEC/HBYiJJg7rcksWJbcmq0d/m5p+LeuSs70BZ8ycy/+aTd7jiSP7aqw==", "e279d464-2a4d-4e68-88d2-142ec973cfc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ad698da-fc26-4b75-bbc2-d3b4dc06f003", "AQAAAAIAAYagAAAAEMq334Eqv0v1cNzlJOWXba9bK7QssJD+FEFb1v/TZikjGsBN6YTe+ggagoQtec6jzg==", "8ef61366-efd5-4336-8e38-4c8cbedc3e42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "230a4bff-cc0b-45c4-9630-128079e87a9a", "AQAAAAIAAYagAAAAEF8mBhXK7V/So+t6c1howrq1gvn3iEMqj9HRKoyyfePLWbT6CdIhXpDFz3pXm8vuvQ==", "e8a161b3-0c75-407d-9277-3fbb37680bee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6e8c00c-5c2b-49aa-9b0e-8638466f386f", "AQAAAAIAAYagAAAAEG+N84mzXXy86LFCCOAQm4exkNhV3GW+rMfAjJlWBRL/4aXcCiJAI2G6vr8e90i3Ow==", "ce5b48f1-01ba-4580-ba5e-1041ded9779e" });

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 3, 17, 58, 249, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 3, 9, 58, 249, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 2, 54, 58, 249, DateTimeKind.Utc).AddTicks(6323));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RecordLink",
                table: "Meetings",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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
    }
}
