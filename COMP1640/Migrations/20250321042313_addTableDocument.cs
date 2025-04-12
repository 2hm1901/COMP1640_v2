using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace COMP1640.Migrations
{
    /// <inheritdoc />
    public partial class addTableDocument : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "UploadedBy",
                table: "Documents",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Documents",
                newName: "FilePath");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Documents",
                newName: "DateUploaded");

            migrationBuilder.AddColumn<string>(
                name: "DocumentName",
                table: "Documents",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TutorId",
                table: "Documents",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AuthorId = table.Column<string>(type: "text", nullable: false),
                    DocumentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Documents_StudentId",
                table: "Documents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_TutorId",
                table: "Documents",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AuthorId",
                table: "Comment",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_DocumentId",
                table: "Comment",
                column: "DocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_AspNetUsers_StudentId",
                table: "Documents",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_AspNetUsers_TutorId",
                table: "Documents",
                column: "TutorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_AspNetUsers_StudentId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_AspNetUsers_TutorId",
                table: "Documents");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Documents_StudentId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_TutorId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "DocumentName",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Documents",
                newName: "UploadedBy");

            migrationBuilder.RenameColumn(
                name: "FilePath",
                table: "Documents",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "DateUploaded",
                table: "Documents",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Documents",
                type: "text",
                nullable: false,
                defaultValue: "");

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
    }
}
