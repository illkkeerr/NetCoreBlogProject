using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogData.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7573377c-8007-4bf9-8464-013abf5cb2cd"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bfd9a437-bd35-456b-8e94-7b1b00a16491"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("1d62a31b-4f79-4b0b-92c7-3619d801f89d"), new Guid("696b9001-aad9-43c1-8286-6cf3495b31f5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nulla aliquet enim tortor at auctor urna nunc id cursus. Mi eget mauris pharetra et. Morbi enim nunc faucibus a pellentesque sit amet porttitor eget. Neque laoreet suspendisse interdum consectetur. Ac placerat vestibulum lectus mauris. In hac habitasse platea dictumst vestibulum rhoncus est pellentesque. At in tellus integer feugiat. Orci phasellus egestas tellus rutrum. Quam pellentesque nec nam aliquam sem. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Ac tortor dignissim convallis aenean et tortor at. Quis viverra nibh cras pulvinar mattis. Integer vitae justo eget magna fermentum iaculis eu non. Sollicitudin nibh sit amet commodo nulla. Quis auctor elit sed vulputate mi sit amet. Ipsum suspendisse ultrices gravida dictum fusce. Dictum at tempor commodo ullamcorper a lacus. Tempor id eu nisl nunc mi ipsum.\r\n\r\nMassa eget egestas purus viverra accumsan in nisl nisi scelerisque. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque. Euismod lacinia at quis risus sed. Lacus vestibulum sed arcu non. Vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras. Netus et malesuada fames ac turpis egestas maecenas pharetra. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices. Elementum nisi quis eleifend quam adipiscing vitae proin. Pulvinar elementum integer enim neque volutpat ac tincidunt. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi.", "Admin Test", new DateTime(2023, 11, 19, 14, 22, 46, 465, DateTimeKind.Local).AddTicks(8033), null, null, new Guid("3f2e9acb-6ae5-47d0-9d08-a24120068307"), null, null, "Asp .net Core Deneme Makalesi", new Guid("70d1acae-20a4-41bf-a054-a7b9b8b4ea5f"), 15, false },
                    { new Guid("7cf4afc0-90b0-4826-b359-0f9a01fbf300"), new Guid("1fe393e9-0a0e-413e-96b7-cde88666be44"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nulla aliquet enim tortor at auctor urna nunc id cursus. Mi eget mauris pharetra et. Morbi enim nunc faucibus a pellentesque sit amet porttitor eget. Neque laoreet suspendisse interdum consectetur. Ac placerat vestibulum lectus mauris. In hac habitasse platea dictumst vestibulum rhoncus est pellentesque. At in tellus integer feugiat. Orci phasellus egestas tellus rutrum. Quam pellentesque nec nam aliquam sem. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Ac tortor dignissim convallis aenean et tortor at. Quis viverra nibh cras pulvinar mattis. Integer vitae justo eget magna fermentum iaculis eu non. Sollicitudin nibh sit amet commodo nulla. Quis auctor elit sed vulputate mi sit amet. Ipsum suspendisse ultrices gravida dictum fusce. Dictum at tempor commodo ullamcorper a lacus. Tempor id eu nisl nunc mi ipsum.\r\n\r\nMassa eget egestas purus viverra accumsan in nisl nisi scelerisque. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque. Euismod lacinia at quis risus sed. Lacus vestibulum sed arcu non. Vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras. Netus et malesuada fames ac turpis egestas maecenas pharetra. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices. Elementum nisi quis eleifend quam adipiscing vitae proin. Pulvinar elementum integer enim neque volutpat ac tincidunt. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi.", "Admin Test", new DateTime(2023, 11, 19, 14, 22, 46, 465, DateTimeKind.Local).AddTicks(8052), null, null, new Guid("dc03addb-368f-467d-b9ee-44b3ff55690c"), null, null, "Visual Studio Deneme Makalesi 1", new Guid("dbb6f4e2-16e7-4f92-908f-bbee39c524f9"), 15, false }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("20338605-fbe0-4a16-aae4-2115ba236534"),
                column: "ConcurrencyStamp",
                value: "43d874f0-61be-4643-bced-53d42c121929");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("78fc7306-f8de-40c7-94a6-549927879e5e"),
                column: "ConcurrencyStamp",
                value: "96c44785-7a48-49be-8e8b-65ff2d42e32b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f015a37a-bc1f-4155-a900-49f3c46b58cc"),
                column: "ConcurrencyStamp",
                value: "e6577517-44e3-4a0a-aa53-3da19458a400");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("70d1acae-20a4-41bf-a054-a7b9b8b4ea5f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a01957ad-54ef-4c8c-be90-9d908ebc07de", "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAELxSEl8DmxUBnNoJE3+CCJBOU/sx0C//2UQI+pLWqR/bi5KDWRfwDJtNRQyNuC3/nw==", "d246573f-2802-4cf3-82b1-ef801623a9be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dbb6f4e2-16e7-4f92-908f-bbee39c524f9"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02e1bcbf-6a5e-4252-b8ec-c08a67a79a67", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEBRur/yH20xQJo8lnKA0gQuVcD0v4cT+GuN35J3MFjeXWtCrGgQpn5kypWM9IfdjJA==", "bb402290-75a4-436a-85c3-396b5668a247" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fe393e9-0a0e-413e-96b7-cde88666be44"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 22, 46, 465, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("696b9001-aad9-43c1-8286-6cf3495b31f5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 22, 46, 465, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3f2e9acb-6ae5-47d0-9d08-a24120068307"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 22, 46, 466, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("dc03addb-368f-467d-b9ee-44b3ff55690c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 22, 46, 466, DateTimeKind.Local).AddTicks(703));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1d62a31b-4f79-4b0b-92c7-3619d801f89d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7cf4afc0-90b0-4826-b359-0f9a01fbf300"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("7573377c-8007-4bf9-8464-013abf5cb2cd"), new Guid("696b9001-aad9-43c1-8286-6cf3495b31f5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nulla aliquet enim tortor at auctor urna nunc id cursus. Mi eget mauris pharetra et. Morbi enim nunc faucibus a pellentesque sit amet porttitor eget. Neque laoreet suspendisse interdum consectetur. Ac placerat vestibulum lectus mauris. In hac habitasse platea dictumst vestibulum rhoncus est pellentesque. At in tellus integer feugiat. Orci phasellus egestas tellus rutrum. Quam pellentesque nec nam aliquam sem. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Ac tortor dignissim convallis aenean et tortor at. Quis viverra nibh cras pulvinar mattis. Integer vitae justo eget magna fermentum iaculis eu non. Sollicitudin nibh sit amet commodo nulla. Quis auctor elit sed vulputate mi sit amet. Ipsum suspendisse ultrices gravida dictum fusce. Dictum at tempor commodo ullamcorper a lacus. Tempor id eu nisl nunc mi ipsum.\r\n\r\nMassa eget egestas purus viverra accumsan in nisl nisi scelerisque. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque. Euismod lacinia at quis risus sed. Lacus vestibulum sed arcu non. Vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras. Netus et malesuada fames ac turpis egestas maecenas pharetra. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices. Elementum nisi quis eleifend quam adipiscing vitae proin. Pulvinar elementum integer enim neque volutpat ac tincidunt. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi.", "Admin Test", new DateTime(2023, 11, 19, 1, 40, 11, 394, DateTimeKind.Local).AddTicks(6456), null, null, new Guid("3f2e9acb-6ae5-47d0-9d08-a24120068307"), null, null, "Asp .net Core Deneme Makalesi", new Guid("70d1acae-20a4-41bf-a054-a7b9b8b4ea5f"), 15, false },
                    { new Guid("bfd9a437-bd35-456b-8e94-7b1b00a16491"), new Guid("1fe393e9-0a0e-413e-96b7-cde88666be44"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nulla aliquet enim tortor at auctor urna nunc id cursus. Mi eget mauris pharetra et. Morbi enim nunc faucibus a pellentesque sit amet porttitor eget. Neque laoreet suspendisse interdum consectetur. Ac placerat vestibulum lectus mauris. In hac habitasse platea dictumst vestibulum rhoncus est pellentesque. At in tellus integer feugiat. Orci phasellus egestas tellus rutrum. Quam pellentesque nec nam aliquam sem. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Ac tortor dignissim convallis aenean et tortor at. Quis viverra nibh cras pulvinar mattis. Integer vitae justo eget magna fermentum iaculis eu non. Sollicitudin nibh sit amet commodo nulla. Quis auctor elit sed vulputate mi sit amet. Ipsum suspendisse ultrices gravida dictum fusce. Dictum at tempor commodo ullamcorper a lacus. Tempor id eu nisl nunc mi ipsum.\r\n\r\nMassa eget egestas purus viverra accumsan in nisl nisi scelerisque. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque. Euismod lacinia at quis risus sed. Lacus vestibulum sed arcu non. Vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras. Netus et malesuada fames ac turpis egestas maecenas pharetra. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices. Elementum nisi quis eleifend quam adipiscing vitae proin. Pulvinar elementum integer enim neque volutpat ac tincidunt. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi.", "Admin Test", new DateTime(2023, 11, 19, 1, 40, 11, 394, DateTimeKind.Local).AddTicks(6464), null, null, new Guid("dc03addb-368f-467d-b9ee-44b3ff55690c"), null, null, "Visual Studio Deneme Makalesi 1", new Guid("dbb6f4e2-16e7-4f92-908f-bbee39c524f9"), 15, false }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("20338605-fbe0-4a16-aae4-2115ba236534"),
                column: "ConcurrencyStamp",
                value: "af19043e-68ab-4dcc-bdfb-c12b687add74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("78fc7306-f8de-40c7-94a6-549927879e5e"),
                column: "ConcurrencyStamp",
                value: "f1dd5c17-b550-4c9f-b6cc-999c081addb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f015a37a-bc1f-4155-a900-49f3c46b58cc"),
                column: "ConcurrencyStamp",
                value: "704a4cd5-98f9-4935-9050-361d6b44c073");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("70d1acae-20a4-41bf-a054-a7b9b8b4ea5f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db2175c7-38f5-4349-8ce2-5f70918be384", "SUPERADMİN@GMAİL.COM", "SUPERADMİN@GMAİL.COM", "AQAAAAIAAYagAAAAEOkEaLhHZOFSCVhYtsairKruW5HiJjEIgUzuwkK42itvyyGFCEhcVvL+y0jHUSonYQ==", "e8f30644-3f39-47ee-90d8-de4943006122" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dbb6f4e2-16e7-4f92-908f-bbee39c524f9"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23def96f-56ff-4375-92b0-940772db5155", "ADMİN@GMAİL.COM", "ADMİN@GMAİL.COM", "AQAAAAIAAYagAAAAELfAbLQ0fRuqZS7W2//F2xexYA/7dfhiEM/2uObtgbSzgAS+mJedIfyquZ2zJAyQsQ==", "dc7b24e2-3903-41f6-aa16-73c83ca620fa" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fe393e9-0a0e-413e-96b7-cde88666be44"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 1, 40, 11, 394, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("696b9001-aad9-43c1-8286-6cf3495b31f5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 1, 40, 11, 394, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3f2e9acb-6ae5-47d0-9d08-a24120068307"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 1, 40, 11, 394, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("dc03addb-368f-467d-b9ee-44b3ff55690c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 1, 40, 11, 394, DateTimeKind.Local).AddTicks(9930));
        }
    }
}
