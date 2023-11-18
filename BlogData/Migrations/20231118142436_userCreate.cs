using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogData.Migrations
{
    /// <inheritdoc />
    public partial class userCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7e5f940d-488c-4831-8389-0f53518fa2bb"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("857c9f7a-1bf2-48fc-9089-34f62b478df1"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("77965fcb-b385-4153-93c0-fa9cc1701b25"), new Guid("696b9001-aad9-43c1-8286-6cf3495b31f5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nulla aliquet enim tortor at auctor urna nunc id cursus. Mi eget mauris pharetra et. Morbi enim nunc faucibus a pellentesque sit amet porttitor eget. Neque laoreet suspendisse interdum consectetur. Ac placerat vestibulum lectus mauris. In hac habitasse platea dictumst vestibulum rhoncus est pellentesque. At in tellus integer feugiat. Orci phasellus egestas tellus rutrum. Quam pellentesque nec nam aliquam sem. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Ac tortor dignissim convallis aenean et tortor at. Quis viverra nibh cras pulvinar mattis. Integer vitae justo eget magna fermentum iaculis eu non. Sollicitudin nibh sit amet commodo nulla. Quis auctor elit sed vulputate mi sit amet. Ipsum suspendisse ultrices gravida dictum fusce. Dictum at tempor commodo ullamcorper a lacus. Tempor id eu nisl nunc mi ipsum.\r\n\r\nMassa eget egestas purus viverra accumsan in nisl nisi scelerisque. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque. Euismod lacinia at quis risus sed. Lacus vestibulum sed arcu non. Vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras. Netus et malesuada fames ac turpis egestas maecenas pharetra. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices. Elementum nisi quis eleifend quam adipiscing vitae proin. Pulvinar elementum integer enim neque volutpat ac tincidunt. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi.", "Admin Test", new DateTime(2023, 11, 18, 17, 24, 35, 673, DateTimeKind.Local).AddTicks(2743), null, null, new Guid("3f2e9acb-6ae5-47d0-9d08-a24120068307"), null, null, "Asp .net Core Deneme Makalesi", 15, false },
                    { new Guid("b009eb36-03fb-419c-b7b5-ae3caf913844"), new Guid("1fe393e9-0a0e-413e-96b7-cde88666be44"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nulla aliquet enim tortor at auctor urna nunc id cursus. Mi eget mauris pharetra et. Morbi enim nunc faucibus a pellentesque sit amet porttitor eget. Neque laoreet suspendisse interdum consectetur. Ac placerat vestibulum lectus mauris. In hac habitasse platea dictumst vestibulum rhoncus est pellentesque. At in tellus integer feugiat. Orci phasellus egestas tellus rutrum. Quam pellentesque nec nam aliquam sem. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Ac tortor dignissim convallis aenean et tortor at. Quis viverra nibh cras pulvinar mattis. Integer vitae justo eget magna fermentum iaculis eu non. Sollicitudin nibh sit amet commodo nulla. Quis auctor elit sed vulputate mi sit amet. Ipsum suspendisse ultrices gravida dictum fusce. Dictum at tempor commodo ullamcorper a lacus. Tempor id eu nisl nunc mi ipsum.\r\n\r\nMassa eget egestas purus viverra accumsan in nisl nisi scelerisque. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque. Euismod lacinia at quis risus sed. Lacus vestibulum sed arcu non. Vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras. Netus et malesuada fames ac turpis egestas maecenas pharetra. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices. Elementum nisi quis eleifend quam adipiscing vitae proin. Pulvinar elementum integer enim neque volutpat ac tincidunt. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi.", "Admin Test", new DateTime(2023, 11, 18, 17, 24, 35, 673, DateTimeKind.Local).AddTicks(2775), null, null, new Guid("dc03addb-368f-467d-b9ee-44b3ff55690c"), null, null, "Visual Studio Deneme Makalesi 1", 15, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("20338605-fbe0-4a16-aae4-2115ba236534"), "4b7fbd14-b8d9-4ffb-beae-efda60d0e24a", "User", "USER" },
                    { new Guid("78fc7306-f8de-40c7-94a6-549927879e5e"), "b1444321-66cc-4428-a28d-4d88c50273f5", "Admin", "ADMIN" },
                    { new Guid("f015a37a-bc1f-4155-a900-49f3c46b58cc"), "b5f93344-5ee4-435e-ba1b-c188e69f8a1a", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("70d1acae-20a4-41bf-a054-a7b9b8b4ea5f"), 0, "445091d1-997c-4c4e-8c3a-84ebc3ffbd47", "superadmin@gmail.com", true, "İlker", "Şenel", false, null, "SUPERADMİN@GMAİL.COM", "SUPERADMİN@GMAİL.COM", "AQAAAAIAAYagAAAAEJNnbfGwId5BL6Qe41/QrO0NN8XeWyUWr6rJxJ1V7RMvAVE7PdWZJrmPbJ3VjHEslw==", "+05389999999", true, "ca59158d-0a1a-458b-a546-c360edfe189f", false, "superadmin@gmail.com" },
                    { new Guid("dbb6f4e2-16e7-4f92-908f-bbee39c524f9"), 0, "ac927b72-534c-4fcf-9613-97a43229b76e", "admin@gmail.com", false, "Ahmet", "Şenel", false, null, "ADMİN@GMAİL.COM", "ADMİN@GMAİL.COM", "AQAAAAIAAYagAAAAENbv+6RTE8QuJFrI7FnFow50EgE+Z1dStl8JMid+L9W5YrQZD5N1TGPGrgzxt0qehA==", "+05388888888", false, "8aef54a8-1aee-41f3-b65c-360e095ff6e3", false, "admin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fe393e9-0a0e-413e-96b7-cde88666be44"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 18, 17, 24, 35, 673, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("696b9001-aad9-43c1-8286-6cf3495b31f5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 18, 17, 24, 35, 673, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3f2e9acb-6ae5-47d0-9d08-a24120068307"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 18, 17, 24, 35, 673, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("dc03addb-368f-467d-b9ee-44b3ff55690c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 18, 17, 24, 35, 673, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f015a37a-bc1f-4155-a900-49f3c46b58cc"), new Guid("70d1acae-20a4-41bf-a054-a7b9b8b4ea5f") },
                    { new Guid("78fc7306-f8de-40c7-94a6-549927879e5e"), new Guid("dbb6f4e2-16e7-4f92-908f-bbee39c524f9") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("77965fcb-b385-4153-93c0-fa9cc1701b25"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b009eb36-03fb-419c-b7b5-ae3caf913844"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("7e5f940d-488c-4831-8389-0f53518fa2bb"), new Guid("1fe393e9-0a0e-413e-96b7-cde88666be44"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nulla aliquet enim tortor at auctor urna nunc id cursus. Mi eget mauris pharetra et. Morbi enim nunc faucibus a pellentesque sit amet porttitor eget. Neque laoreet suspendisse interdum consectetur. Ac placerat vestibulum lectus mauris. In hac habitasse platea dictumst vestibulum rhoncus est pellentesque. At in tellus integer feugiat. Orci phasellus egestas tellus rutrum. Quam pellentesque nec nam aliquam sem. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Ac tortor dignissim convallis aenean et tortor at. Quis viverra nibh cras pulvinar mattis. Integer vitae justo eget magna fermentum iaculis eu non. Sollicitudin nibh sit amet commodo nulla. Quis auctor elit sed vulputate mi sit amet. Ipsum suspendisse ultrices gravida dictum fusce. Dictum at tempor commodo ullamcorper a lacus. Tempor id eu nisl nunc mi ipsum.\r\n\r\nMassa eget egestas purus viverra accumsan in nisl nisi scelerisque. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque. Euismod lacinia at quis risus sed. Lacus vestibulum sed arcu non. Vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras. Netus et malesuada fames ac turpis egestas maecenas pharetra. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices. Elementum nisi quis eleifend quam adipiscing vitae proin. Pulvinar elementum integer enim neque volutpat ac tincidunt. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi.", "Admin Test", new DateTime(2023, 11, 17, 13, 48, 51, 402, DateTimeKind.Local).AddTicks(8519), null, null, new Guid("dc03addb-368f-467d-b9ee-44b3ff55690c"), null, null, "Visual Studio Deneme Makalesi 1", 15, false },
                    { new Guid("857c9f7a-1bf2-48fc-9089-34f62b478df1"), new Guid("696b9001-aad9-43c1-8286-6cf3495b31f5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nulla aliquet enim tortor at auctor urna nunc id cursus. Mi eget mauris pharetra et. Morbi enim nunc faucibus a pellentesque sit amet porttitor eget. Neque laoreet suspendisse interdum consectetur. Ac placerat vestibulum lectus mauris. In hac habitasse platea dictumst vestibulum rhoncus est pellentesque. At in tellus integer feugiat. Orci phasellus egestas tellus rutrum. Quam pellentesque nec nam aliquam sem. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Ac tortor dignissim convallis aenean et tortor at. Quis viverra nibh cras pulvinar mattis. Integer vitae justo eget magna fermentum iaculis eu non. Sollicitudin nibh sit amet commodo nulla. Quis auctor elit sed vulputate mi sit amet. Ipsum suspendisse ultrices gravida dictum fusce. Dictum at tempor commodo ullamcorper a lacus. Tempor id eu nisl nunc mi ipsum.\r\n\r\nMassa eget egestas purus viverra accumsan in nisl nisi scelerisque. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque. Euismod lacinia at quis risus sed. Lacus vestibulum sed arcu non. Vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras. Netus et malesuada fames ac turpis egestas maecenas pharetra. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices. Elementum nisi quis eleifend quam adipiscing vitae proin. Pulvinar elementum integer enim neque volutpat ac tincidunt. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi.", "Admin Test", new DateTime(2023, 11, 17, 13, 48, 51, 402, DateTimeKind.Local).AddTicks(8511), null, null, new Guid("3f2e9acb-6ae5-47d0-9d08-a24120068307"), null, null, "Asp .net Core Deneme Makalesi", 15, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fe393e9-0a0e-413e-96b7-cde88666be44"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 17, 13, 48, 51, 403, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("696b9001-aad9-43c1-8286-6cf3495b31f5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 17, 13, 48, 51, 403, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3f2e9acb-6ae5-47d0-9d08-a24120068307"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 17, 13, 48, 51, 403, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("dc03addb-368f-467d-b9ee-44b3ff55690c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 17, 13, 48, 51, 403, DateTimeKind.Local).AddTicks(3070));
        }
    }
}
