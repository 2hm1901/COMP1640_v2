using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP1640.Migrations
{
    /// <inheritdoc />
    public partial class removeMessageCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageCount",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f1c5771-35db-4e91-b818-d6856ead0d69", "AQAAAAIAAYagAAAAEKYKV+l0tZ1quJ7zrJ25DAZvL9APmknwe+Ev7BcEavhfDFy8IjRE2xdXDFINccUlyg==", "1499ce43-68cb-4862-abdb-4b7968488d97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64ef74e2-484b-4e03-b919-49eb3077458e", "AQAAAAIAAYagAAAAEEFVuIeTJQmAeotv1UPwePd5I33KBVpW2HabYQqxNeQdwOn7ker0P6M1SieWrFEIPA==", "78ce4930-8226-4a89-a909-749f375c02e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdfc1191-724c-4bd1-ba1d-19dc490c5470", "AQAAAAIAAYagAAAAEL+av8drbKYTzpJIwFCvJI5hl4K7rpmQHh04qgSlhQoCVtjQfXN/hOl90WvWvy0Kww==", "2ac807a2-5494-469a-a383-ae86fd35c194" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90e93624-d6fe-4036-9de8-3696ec737630", "AQAAAAIAAYagAAAAEPvErj4Kg9NWjysn8CeTZKPooSGswbdC9dLpfcTyIaQSPKC1uKuc8YxA5Ub+JRj72g==", "74de207c-b891-445e-acf9-54dee0670e54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68f96115-5acb-4f65-b141-ab10e1e71e19", "AQAAAAIAAYagAAAAEOlTxsUJV5qhoSgNnn0MRNzQZ3KXcylYFH8G3JdZv67ovYZjZZCle7y425FYRQ5F/w==", "4a5725d9-be94-47ad-bc92-0e1515be8cbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "938e2d22-cdf8-48d9-97ec-4945cd7039d1", "AQAAAAIAAYagAAAAEGUbaTOOCyOD33YogQ0ReW63UmHKDhq2LyRm4emEQZ171IPmvl1ipPWLenlHAjDGzA==", "c7961a6d-254e-470b-8fcb-a069e7d2b212" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a7601f3-adf0-4948-ae0e-39f1d728ce72", "AQAAAAIAAYagAAAAEDLPXi83FCrFUtulDc2BsEeL4PXUDJIOZCKs/zaVKF+lPf2TLImIoDFsIffvJGvdBQ==", "52eee58c-3e07-4471-89ee-01b52ed8fa15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac2dc450-3ebe-4202-a93a-7635d4a87508", "AQAAAAIAAYagAAAAEMxsXT4Cgj6Jr7z0wBPxdbGI+UDra/9XFNtWbqbIZjyIX21j4Q8jXdLElAjf9EELvQ==", "b019e641-4203-4879-96b3-ab8c1ec02f97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb66a7fd-cfb5-4d2f-8d12-67d28f9fbaa7", "AQAAAAIAAYagAAAAEG90QHxw/Y+AXwDqDuuDDpcD4neGLQXxSlK+9QZZ2sGdF0FqRLmf8R8+XdUGAj8oWA==", "e399abd1-41d5-4733-ad38-c272b98bb2c2" });

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 4, 0, 8, 675, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 3, 52, 8, 675, DateTimeKind.Utc).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 3, 37, 8, 675, DateTimeKind.Utc).AddTicks(5000));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageCount",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1001",
                columns: new[] { "ConcurrencyStamp", "MessageCount", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2751b76-acfe-43f3-848c-b44087a65668", 0, "AQAAAAIAAYagAAAAEI3Y4yViR/YKwfvnMDqbBOGz5u3jnzPgTgR2w5Rhm/VsehwMhjj7j+nShrYKRxUVjA==", "cc3bd1bc-dbf0-4c91-940f-28b690608a62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1002",
                columns: new[] { "ConcurrencyStamp", "MessageCount", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac44e185-e9cd-44da-a237-a96847453588", 0, "AQAAAAIAAYagAAAAECgXut6WFJR+6zW0VaudNtKzoPHOW1tb7GMMQCjYkofW0tbK5+Bd0r3DG90BJ/m5Hg==", "76133d32-b5d0-4671-8a32-8fd74fcbacb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1003",
                columns: new[] { "ConcurrencyStamp", "MessageCount", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85cb30c2-0482-4c55-bce8-937aedcb52df", 0, "AQAAAAIAAYagAAAAECwqZMOVbCo0hZAxeVBTYPCgqZp4LvKu4FtXsCDZYBa/5UF4eJ4Cs7FxgECAtNmydw==", "76112e00-b9b0-4e6d-bda9-c29a471917f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1004",
                columns: new[] { "ConcurrencyStamp", "MessageCount", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44f865f8-e2fc-44b8-9c3a-215444222343", 0, "AQAAAAIAAYagAAAAEEo0zxa6mPhP5pSULkuLqFkYWTroiXPeGpgQvK3CH/tj2pkTaK8IZMhEwsH9nZehbQ==", "08e3a05c-fa7d-42cc-8064-d143bd059b0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2001",
                columns: new[] { "ConcurrencyStamp", "MessageCount", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b6a562d-1e27-4bee-8564-6ab7203a419c", 350, "AQAAAAIAAYagAAAAEN5u5LrU/OtzJR2BFiQVRNWLInnz8CVnzLTgxAZJZocKC4LmBuqyS1sKkksHS3sPGg==", "284bf856-5cb7-47a5-8cc9-0c4e5ad71b2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2002",
                columns: new[] { "ConcurrencyStamp", "MessageCount", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdd71ea4-750a-422d-bd86-3f1fbaf8561b", 220, "AQAAAAIAAYagAAAAEPmc4ml5mcPEC/HBYiJJg7rcksWJbcmq0d/m5p+LeuSs70BZ8ycy/+aTd7jiSP7aqw==", "e279d464-2a4d-4e68-88d2-142ec973cfc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2003",
                columns: new[] { "ConcurrencyStamp", "MessageCount", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ad698da-fc26-4b75-bbc2-d3b4dc06f003", 100, "AQAAAAIAAYagAAAAEMq334Eqv0v1cNzlJOWXba9bK7QssJD+FEFb1v/TZikjGsBN6YTe+ggagoQtec6jzg==", "8ef61366-efd5-4336-8e38-4c8cbedc3e42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2004",
                columns: new[] { "ConcurrencyStamp", "MessageCount", "PasswordHash", "SecurityStamp" },
                values: new object[] { "230a4bff-cc0b-45c4-9630-128079e87a9a", 75, "AQAAAAIAAYagAAAAEF8mBhXK7V/So+t6c1howrq1gvn3iEMqj9HRKoyyfePLWbT6CdIhXpDFz3pXm8vuvQ==", "e8a161b3-0c75-407d-9277-3fbb37680bee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2005",
                columns: new[] { "ConcurrencyStamp", "MessageCount", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6e8c00c-5c2b-49aa-9b0e-8638466f386f", 50, "AQAAAAIAAYagAAAAEG+N84mzXXy86LFCCOAQm4exkNhV3GW+rMfAjJlWBRL/4aXcCiJAI2G6vr8e90i3Ow==", "ce5b48f1-01ba-4580-ba5e-1041ded9779e" });

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
    }
}
