using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogData.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("1fe393e9-0a0e-413e-96b7-cde88666be44"), "Admin Test", new DateTime(2023, 11, 14, 13, 33, 10, 571, DateTimeKind.Local).AddTicks(9722), null, null, null, null, "Visual Studio", false },
                    { new Guid("696b9001-aad9-43c1-8286-6cf3495b31f5"), "Admin Test", new DateTime(2023, 11, 14, 13, 33, 10, 571, DateTimeKind.Local).AddTicks(9716), null, null, null, null, "Asp .Net Core", false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "ModifiedBy", "ModifiedDate", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("3f2e9acb-6ae5-47d0-9d08-a24120068307"), "Admin Test", new DateTime(2023, 11, 14, 13, 33, 10, 572, DateTimeKind.Local).AddTicks(1400), null, null, "Image/testImage", "jpg", null, null, false },
                    { new Guid("dc03addb-368f-467d-b9ee-44b3ff55690c"), "Admin Test", new DateTime(2023, 11, 14, 13, 33, 10, 572, DateTimeKind.Local).AddTicks(1405), null, null, "Image/studioTestImage", "png", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("65b3ed5f-c695-4892-89b0-f9387c4946ef"), new Guid("696b9001-aad9-43c1-8286-6cf3495b31f5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nulla aliquet enim tortor at auctor urna nunc id cursus. Mi eget mauris pharetra et. Morbi enim nunc faucibus a pellentesque sit amet porttitor eget. Neque laoreet suspendisse interdum consectetur. Ac placerat vestibulum lectus mauris. In hac habitasse platea dictumst vestibulum rhoncus est pellentesque. At in tellus integer feugiat. Orci phasellus egestas tellus rutrum. Quam pellentesque nec nam aliquam sem. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Ac tortor dignissim convallis aenean et tortor at. Quis viverra nibh cras pulvinar mattis. Integer vitae justo eget magna fermentum iaculis eu non. Sollicitudin nibh sit amet commodo nulla. Quis auctor elit sed vulputate mi sit amet. Ipsum suspendisse ultrices gravida dictum fusce. Dictum at tempor commodo ullamcorper a lacus. Tempor id eu nisl nunc mi ipsum.\r\n\r\nMassa eget egestas purus viverra accumsan in nisl nisi scelerisque. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque. Euismod lacinia at quis risus sed. Lacus vestibulum sed arcu non. Vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras. Netus et malesuada fames ac turpis egestas maecenas pharetra. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices. Elementum nisi quis eleifend quam adipiscing vitae proin. Pulvinar elementum integer enim neque volutpat ac tincidunt. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi.", "Admin Test", new DateTime(2023, 11, 14, 13, 33, 10, 571, DateTimeKind.Local).AddTicks(4279), null, null, new Guid("3f2e9acb-6ae5-47d0-9d08-a24120068307"), null, null, "Asp .net Core Deneme Makalesi", 15, false },
                    { new Guid("c9a2d716-d657-4e98-a847-87bb8059866c"), new Guid("1fe393e9-0a0e-413e-96b7-cde88666be44"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nulla aliquet enim tortor at auctor urna nunc id cursus. Mi eget mauris pharetra et. Morbi enim nunc faucibus a pellentesque sit amet porttitor eget. Neque laoreet suspendisse interdum consectetur. Ac placerat vestibulum lectus mauris. In hac habitasse platea dictumst vestibulum rhoncus est pellentesque. At in tellus integer feugiat. Orci phasellus egestas tellus rutrum. Quam pellentesque nec nam aliquam sem. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Ac tortor dignissim convallis aenean et tortor at. Quis viverra nibh cras pulvinar mattis. Integer vitae justo eget magna fermentum iaculis eu non. Sollicitudin nibh sit amet commodo nulla. Quis auctor elit sed vulputate mi sit amet. Ipsum suspendisse ultrices gravida dictum fusce. Dictum at tempor commodo ullamcorper a lacus. Tempor id eu nisl nunc mi ipsum.\r\n\r\nMassa eget egestas purus viverra accumsan in nisl nisi scelerisque. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque. Euismod lacinia at quis risus sed. Lacus vestibulum sed arcu non. Vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras. Netus et malesuada fames ac turpis egestas maecenas pharetra. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices. Elementum nisi quis eleifend quam adipiscing vitae proin. Pulvinar elementum integer enim neque volutpat ac tincidunt. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi.", "Admin Test", new DateTime(2023, 11, 14, 13, 33, 10, 571, DateTimeKind.Local).AddTicks(4286), null, null, new Guid("dc03addb-368f-467d-b9ee-44b3ff55690c"), null, null, "Visual Studio Deneme Makalesi 1", 15, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("65b3ed5f-c695-4892-89b0-f9387c4946ef"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c9a2d716-d657-4e98-a847-87bb8059866c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fe393e9-0a0e-413e-96b7-cde88666be44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("696b9001-aad9-43c1-8286-6cf3495b31f5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3f2e9acb-6ae5-47d0-9d08-a24120068307"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("dc03addb-368f-467d-b9ee-44b3ff55690c"));
        }
    }
}
