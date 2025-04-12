using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP1640.Migrations
{
    /// <inheritdoc />
    public partial class addCommnet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_AuthorId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Documents_DocumentId",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_DocumentId",
                table: "Comments",
                newName: "IX_Comments_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_AuthorId",
                table: "Comments",
                newName: "IX_Comments_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81bf107f-cb4d-4f33-9a3c-d91a49469825", "AQAAAAIAAYagAAAAEINmuIRaUe3EXbL2FJuRk5+KJReWcHCCxFdOddySQNhDb7BNHexdwy+nKAt238/c/g==", "529bcfbb-9139-4a7f-8e06-03ef485b9b7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c054e9e5-ebe4-47f0-82ab-04b3f5de5fc4", "AQAAAAIAAYagAAAAEAKfP54GTxeILskrO1LvfasFvef9u3JACRwiVozHM4SnL7hnnZyc2V1+OkpJqTMPEQ==", "14a9c060-6986-4554-8c5b-a0d5749c9217" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2e23985-7fc2-4054-a51b-202ec1dd87bb", "AQAAAAIAAYagAAAAEI9aNZTUZZwqmJqcEW/BQl/nB2ny1YgznVQ4yXmn835xxOJfxwx4ya86ljErCKH0xQ==", "7a0d2bc9-c6a3-4a06-9cba-bfdc90a540ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7515614-2a7d-416b-b365-2996a9416952", "AQAAAAIAAYagAAAAEAFJxes7tTAXKFuc4HdG6Q2kxAw512JXsfB/vcxbneHFLnKDnC26jkDhGzHw9ykgvw==", "455c0980-3836-40d1-8794-77a23bc5fbb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f61c4b92-d143-4f42-945a-57a4fbf4ed47", "AQAAAAIAAYagAAAAEEa2+iJ102CxPnbRV3PXiHMDRyBYAyBm5JaDA01uDJfgBNDjox3sy28oW7PFEJ/a4Q==", "d66073b7-7378-40f3-bb4c-719bb005db27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b69c27c5-2b91-4545-b07e-9449edcca969", "AQAAAAIAAYagAAAAEDSA59GbfV386QwyirzbaYYkfnGnc7wtJdiXPQq5NRirtrpRyTgvWzC9wfEBuwB7Fg==", "9229be66-8403-4d33-8182-d96d5a3249b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12c1c407-13b2-4dbf-adda-d4783b8661ab", "AQAAAAIAAYagAAAAEMfPmPwrM4q6rUacDx2qk9hL/B70ZAGwaKTBQFoJ0K5eEURtnCK03YfCqfH/hj8kJg==", "1c152a45-fa97-4786-b72f-7538996192a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "576f03ca-9e46-434c-9bf0-2e158cde8920", "AQAAAAIAAYagAAAAEBPjU3w4PXE687jyCtrVlDla/6fpnLmWaEC2P1HK3xwRd6t551w9SU2xKRccme8VFg==", "427e9db7-8b2c-4726-a1a2-4ef5824efa84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e284beeb-e4b5-483b-b7af-edff99cd236f", "AQAAAAIAAYagAAAAEHS8lX8ERW3vKiMf6ipdiTjYq5634juWIeCYk4J3VQFzcqdnpIOpxrkDqxXibZAAVQ==", "7e45a57f-a298-4417-980d-7d8235c54d1f" });

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 8, 51, 29, 32, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 8, 43, 29, 32, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 8, 28, 29, 32, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AuthorId",
                table: "Comments",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Documents_DocumentId",
                table: "Comments",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AuthorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Documents_DocumentId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_DocumentId",
                table: "Comment",
                newName: "IX_Comment_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AuthorId",
                table: "Comment",
                newName: "IX_Comment_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc4e2215-eefc-4387-aab4-ddbaaf2038b7", "AQAAAAIAAYagAAAAEPh2ohStbR89Yy2TXx4n3XP6s2JkwqnMGyX+ho7/xpfWgFUfnxfxLc2Oj207KWlowQ==", "ee7ded76-cd2f-4554-a90b-71b495d18c42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73ea392f-d27b-41c6-b28b-c192f06df4e1", "AQAAAAIAAYagAAAAECUfN9b8stbQzbq4NBSSyyuYJI2ge8ZPn8BqcPM206ACJ4nVKccE+giJR9lGZkswqw==", "5605cdd9-39b1-472d-a6e3-07b1bcf38355" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60a98f06-8536-4a43-a0f6-e7765fe85f17", "AQAAAAIAAYagAAAAEDZF3+aSC100pH0wKCs8izZvmaObo8qQ0N6HCoI1koghKa/i5rbq6pWjdYtXPjHNMw==", "658e8ed0-ab4f-4894-961c-758ea88d34f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a720498-5801-4144-8341-3742248a2d91", "AQAAAAIAAYagAAAAEKAtD1TbIgpyYaFxWg9U96gwKQuW7iwWlfrdRxYJPyv7a8TebLxm1b3SGQI+tkOQXQ==", "8b201b4d-bf74-444d-9208-15bfd906e6bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a7a9f27-b76d-4fbe-8902-eca567c081e3", "AQAAAAIAAYagAAAAEKGqxRxgtq1Va8N4xPGDN5zpnONexCMpZZmZav1sO78KNM/+oKTPX5J8IiHJm0WPzw==", "6c7086b8-de9d-4fa6-9737-908a02953155" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "963f77a7-09a9-43de-b777-c004de6f382a", "AQAAAAIAAYagAAAAEO157dYDvKLgdSwaakIEWiI1IILrq2x7B7ZwJsZMpfMFjnsc7mUaf20YLGmu0uQ/sg==", "eb709b7a-c2d6-41a2-9637-64c00a58ee41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d9cb40c-7137-41e6-8bf6-bf85f945adad", "AQAAAAIAAYagAAAAEBbJah/3t703DJedNonPfbVqO7zWLEgfkjtVLE/msrAxBQZEsMMEAnYYF9O5tGWTPQ==", "8274b485-5bf2-4386-b577-ef4bc96c83bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7f1a036-0048-4428-9890-2d2c2582fc82", "AQAAAAIAAYagAAAAEE1Caa5ZCQNPLwWGu7EXdVh4GKKxvf7vVBNi0QotVwSbyxfzmepAONibvfN4iaHQUw==", "007b9a4f-cc17-4c2a-9b0f-19d1660a5771" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d70a06cf-ee97-4eb3-ba13-7e48f6a44df2", "AQAAAAIAAYagAAAAECp2hQKVd1NAHcbL0Ac0pbhwcyFCxMh5/xFQgWxM/sf8ruq9X9zLDLmW0sWNO0pIOA==", "ba3290de-5137-4505-810a-54cd329a6c86" });

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 4, 16, 12, 397, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 4, 8, 12, 397, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2025, 3, 21, 3, 53, 12, 397, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_AuthorId",
                table: "Comment",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Documents_DocumentId",
                table: "Comment",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
