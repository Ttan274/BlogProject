using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("504052c0-a5c6-4738-b668-3d7e088d6334"), "Talha Tan", new DateTime(2024, 1, 23, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8199), null, null, false, null, null, "Hayvan" },
                    { new Guid("800c5be4-0448-4e66-a96a-ccc8cc0d65e1"), "Talha Tan", new DateTime(2024, 1, 23, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8202), null, null, false, null, null, "Hayvan" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("6445f48b-373c-4fde-a5f3-1425faf7f5da"), "Talha Tan", new DateTime(2024, 1, 23, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9158), null, null, "images/KediFotosu", "png", false, null, null },
                    { new Guid("ee4c53f9-5201-4002-a639-9bbce2cee833"), "Talha Tan", new DateTime(2024, 1, 23, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9169), null, null, "images/HippoFotosu", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0735bd59-d05a-4954-8659-6405c0486901"), new Guid("504052c0-a5c6-4738-b668-3d7e088d6334"), "Kedilerin su içtiği kaptan su içebilirsiniz çünkü kediler çok temiz hayvanlardır", "Talha Tan", new DateTime(2024, 1, 23, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(7151), null, null, new Guid("6445f48b-373c-4fde-a5f3-1425faf7f5da"), false, null, null, "Kedi Özellikleri", 20 },
                    { new Guid("bfd4728a-6e81-4bfd-83c5-1b554db12f01"), new Guid("800c5be4-0448-4e66-a96a-ccc8cc0d65e1"), "Hipopotamların sütü pembe renktedir çünkü salgıladıkları kırmızı ve parlak turuncu renkteki asitlerin birleşimindes pembe renk oluşur", "Talha Tan", new DateTime(2024, 1, 23, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(7156), null, null, new Guid("ee4c53f9-5201-4002-a639-9bbce2cee833"), false, null, null, "Hipopotam Özellikleri", 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0735bd59-d05a-4954-8659-6405c0486901"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bfd4728a-6e81-4bfd-83c5-1b554db12f01"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("504052c0-a5c6-4738-b668-3d7e088d6334"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("800c5be4-0448-4e66-a96a-ccc8cc0d65e1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6445f48b-373c-4fde-a5f3-1425faf7f5da"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ee4c53f9-5201-4002-a639-9bbce2cee833"));
        }
    }
}
