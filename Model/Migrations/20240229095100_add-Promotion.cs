using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class addPromotion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PromotionId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 47", "cf6204dd-f835-4315-b9f2-c760fc701de5", "user17@gmail.com", "18", "82043152-55fe-4be0-9e00-abe79dadb147", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(6547), "nguyen9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 45", "cf139e2f-00ad-43a4-8e72-5516def89e74", "user31@gmail.com", "24", "6d25266f-14ce-44c7-ada8-53c5f3b310da", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(6658), "nguyen9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 46", "cc213f2d-376b-45d2-af7f-48b2579a189e", "user28@gmail.com", "35", "ca4a84a4-9730-4a9d-9730-d2406e0052a8", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(6674), "nguyen3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 21", "454ed1da-2b3d-48da-aa2c-a257b97fdaa2", "user10@gmail.com", "41", "5dcb9cde-d0c0-4eae-a84e-b50c60d91991", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(6725), "nguyen46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 10", "c3201652-ba27-4860-93f8-15d4d2f60e16", "user7@gmail.com", "25", "4416c46e-9591-4b2a-9fa3-2576e11175c7", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(6741), "nguyen35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 21", "2f4e43f4-4ce4-4751-918a-bc7b46b09e85", "user26@gmail.com", "32", "438cb8b1-b494-462b-9ec2-fb396bd56e71", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(6755), "nguyen33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 11", "6125b373-1ecf-4f8f-a191-1e662094c216", "user25@gmail.com", "32", "692a9fe1-f031-4272-a4bd-e2a29dda8fbd", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(6769), "nguyen38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 32", "d3d13d85-fabb-4160-814f-5b6d5805a57d", "user32@gmail.com", "25", "9117f1e3-210c-4ab2-9164-b1adc5c79f82", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(6782), "nguyen8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 27", "884836f5-0b91-4372-93fb-f5540bbba1e2", "user18@gmail.com", "15", "283df77f-d925-4f54-bfa7-d6bcc8e45e30", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(6794), "nguyen25" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  21", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  27", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  35", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  45", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  37", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  24", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                column: "Time",
                value: new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  13", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  8", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                column: "Time",
                value: new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                column: "Time",
                value: new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                column: "Time",
                value: new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                column: "Time",
                value: new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                column: "Time",
                value: new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                column: "Time",
                value: new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                column: "Time",
                value: new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                column: "Time",
                value: new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                column: "Time",
                value: new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "79640b64-94d3-4cb2-89c8-a5fefe3c2051" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 17, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "79640b64-94d3-4cb2-89c8-a5fefe3c2052" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 32, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "79640b64-94d3-4cb2-89c8-a5fefe3c2053" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 6, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "79640b64-94d3-4cb2-89c8-a5fefe3c2054" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 30, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "79640b64-94d3-4cb2-89c8-a5fefe3c2055" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 7, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "79640b64-94d3-4cb2-89c8-a5fefe3c2056" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 38, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "79640b64-94d3-4cb2-89c8-a5fefe3c2057" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 28, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "79640b64-94d3-4cb2-89c8-a5fefe3c2058" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 23, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "79640b64-94d3-4cb2-89c8-a5fefe3c2059" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 16, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 23", 2580m, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 10", 2554m, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 6", 2568m, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 44", 2556m, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 45", 2539m, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 42", 2539m, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 28", 2578m, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 23", 2573m, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 12", 2580m, new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "Description", "Name", "Time", "TimeEnd", "TimeStart", "Value" },
                values: new object[,]
                {
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "Mô tả điện thoại", "PromotionName 7", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7025), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7024), 30 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "Mô tả điện thoại", "PromotionName 29", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7032), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7031), 44 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "Mô tả điện thoại", "PromotionName 4", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7038), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7038), 26 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "Mô tả điện thoại", "PromotionName 35", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7040), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7042), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7041), 14 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "Mô tả điện thoại", "PromotionName 23", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7045), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7048), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7047), 28 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "Mô tả điện thoại", "PromotionName 11", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7050), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7053), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7052), 4 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "Mô tả điện thoại", "PromotionName 13", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7056), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7058), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7057), 39 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "Mô tả điện thoại", "PromotionName 24", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7061), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7061), 23 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "Mô tả điện thoại", "PromotionName 48", new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7065), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7067), new DateTime(2024, 2, 29, 16, 50, 59, 895, DateTimeKind.Local).AddTicks(7066), 26 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_PromotionId",
                table: "Products",
                column: "PromotionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Promotions_PromotionId",
                table: "Products",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Promotions_PromotionId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropIndex(
                name: "IX_Products_PromotionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PromotionId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 21", "6d8ab6e4-67cb-4c2b-9f28-15c7a60bc9b5", "user40@gmail.com", "26", "3bef880e-5bde-4e10-82af-68207e9dee79", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(8500), "nguyen8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 10", "cead261f-a889-44bf-8d91-7dc6b4112e1a", "user27@gmail.com", "40", "b680a803-fdb0-4781-9169-8dcd7d32c8af", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(8602), "nguyen43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 7", "b8ab4a8b-952b-4d86-8267-293f91ef6341", "user18@gmail.com", "21", "c01b08e6-486d-419e-9371-132b7ed720d2", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(8618), "nguyen2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 38", "b50a5723-cf79-4d02-856d-0a057555f520", "user44@gmail.com", "20", "9ec47c0c-1afb-4e39-b613-ccdafad6b6e0", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(8631), "nguyen47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 14", "24df6539-336a-4655-b048-61a5d0d14da2", "user4@gmail.com", "39", "b8c2138d-7d63-4686-8305-6e435506d131", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(8643), "nguyen45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 36", "5b8bbd3c-73a4-4b42-a5d9-f5aa1c613666", "user23@gmail.com", "18", "b151d980-1881-487d-9852-d099452c7e25", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(8690), "nguyen34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 2", "f34c0ce9-5569-4135-bc7a-a02b97f9a312", "user49@gmail.com", "33", "73384b3c-1ef0-410b-b05b-f9ba14d82b0e", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(8715), "nguyen11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 21", "55642932-873d-4c77-a46e-ac4d569f85dc", "user33@gmail.com", "47", "de176592-c6c2-4c9f-9caa-fe6606cb0784", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(8727), "nguyen39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "Time", "UserName" },
                values: new object[] { "Dia chi 7", "5d55def5-e3f7-4679-bda9-68bffffac6ee", "user48@gmail.com", "42", "5cd9b1f2-63f6-4325-89ba-057712f94cb5", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(8740), "nguyen30" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  25", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  9", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  41", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  29", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  10", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  46", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                column: "Time",
                value: new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  18", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  5", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                column: "Time",
                value: new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                column: "Time",
                value: new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                column: "Time",
                value: new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                column: "Time",
                value: new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                column: "Time",
                value: new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                column: "Time",
                value: new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                column: "Time",
                value: new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                column: "Time",
                value: new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                column: "Time",
                value: new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "79640b64-94d3-4cb2-89c8-a5fefe3c2051" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 38, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "79640b64-94d3-4cb2-89c8-a5fefe3c2052" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 31, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "79640b64-94d3-4cb2-89c8-a5fefe3c2053" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 19, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "79640b64-94d3-4cb2-89c8-a5fefe3c2054" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 41, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "79640b64-94d3-4cb2-89c8-a5fefe3c2055" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 41, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "79640b64-94d3-4cb2-89c8-a5fefe3c2056" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 15, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "79640b64-94d3-4cb2-89c8-a5fefe3c2057" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 20, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "79640b64-94d3-4cb2-89c8-a5fefe3c2058" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 28, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "79640b64-94d3-4cb2-89c8-a5fefe3c2059" },
                columns: new[] { "Quantity", "Time" },
                values: new object[] { 40, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 3", 2559m, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 14", 2567m, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 17", 2571m, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 47", 2567m, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 16", 2566m, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 30", 2549m, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 42", 2551m, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 30", 2581m, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 6", 2567m, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9243) });
        }
    }
}
