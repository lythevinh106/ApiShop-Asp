using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class addDateTimeAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "ProductOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "Name", "Time" },
                values: new object[] { "category name  48", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9517) });

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
                columns: new[] { "Name", "Time" },
                values: new object[] { "ProductName 30", new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "Name", "Price", "Time" },
                values: new object[] { "ProductName 6", 2567m, new DateTime(2024, 2, 17, 18, 59, 59, 106, DateTimeKind.Local).AddTicks(9243) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "ProductOrders");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "Dia chi 49", "8f0f4b1c-34e5-4e1f-88e5-35951a4f0e90", "user42@gmail.com", "19", "4b495378-da7d-49b2-a9bb-9b891e2f79d6", "nguyen14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "Dia chi 46", "9849b1b4-79aa-44a3-bf6a-9e4dffd75989", "user37@gmail.com", "24", "16a69000-2900-4e1e-9bf0-5e27810d1415", "nguyen10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "Dia chi 31", "d25b25ad-f552-4550-9c1b-b716b0551bb2", "user17@gmail.com", "37", "57fb86d3-efaa-4474-af00-c13e478f9eea", "nguyen44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "Dia chi 9", "d3a4cd1e-125d-4c04-a4e2-d240c520656c", "user22@gmail.com", "47", "980e7af4-c68c-4ce3-8ee5-a91f956c73e4", "nguyen43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "Dia chi 16", "a8cbefe4-cd82-442e-8143-2617f5d6cd38", "user49@gmail.com", "38", "45f1741d-ab19-4368-824e-ed96b637b9a5", "nguyen3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "Dia chi 30", "2a3cb63e-34c4-41a8-af69-7d0edaf72a15", "user25@gmail.com", "16", "fd4a1c0d-b34a-487e-9921-98abd96f1b56", "nguyen28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "Dia chi 40", "4c37f16e-ebaf-40c2-9db6-3c54c04a60e6", "user43@gmail.com", "30", "55d4d275-2782-4f06-90ab-57d39b5b3508", "nguyen16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "Dia chi 5", "76232e95-753e-4d7a-ad3d-582d5047f16d", "user9@gmail.com", "3", "c5faaaf6-c479-4dc4-a876-e9bdf72c5571", "nguyen26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "Address", "ConcurrencyStamp", "Email", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "Dia chi 42", "b6eaf532-4c37-48f0-9840-aebba7a47f91", "user6@gmail.com", "23", "dd024905-9b47-4462-b894-36e07322a7d4", "nguyen23" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                column: "Name",
                value: "category name  16");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                column: "Name",
                value: "category name  30");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                column: "Name",
                value: "category name  45");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                column: "Name",
                value: "category name  41");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                column: "Name",
                value: "category name  23");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                column: "Name",
                value: "category name  29");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                column: "Name",
                value: "category name  2");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                column: "Name",
                value: "category name  45");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                column: "Name",
                value: "category name  10");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                column: "Time",
                value: new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                column: "Time",
                value: new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                column: "Time",
                value: new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                column: "Time",
                value: new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                column: "Time",
                value: new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                column: "Time",
                value: new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                column: "Time",
                value: new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                column: "Time",
                value: new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                column: "Time",
                value: new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "79640b64-94d3-4cb2-89c8-a5fefe3c2051" },
                column: "Quantity",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "79640b64-94d3-4cb2-89c8-a5fefe3c2052" },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "79640b64-94d3-4cb2-89c8-a5fefe3c2053" },
                column: "Quantity",
                value: 34);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "79640b64-94d3-4cb2-89c8-a5fefe3c2054" },
                column: "Quantity",
                value: 45);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "79640b64-94d3-4cb2-89c8-a5fefe3c2055" },
                column: "Quantity",
                value: 47);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "79640b64-94d3-4cb2-89c8-a5fefe3c2056" },
                column: "Quantity",
                value: 36);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "79640b64-94d3-4cb2-89c8-a5fefe3c2057" },
                column: "Quantity",
                value: 37);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "79640b64-94d3-4cb2-89c8-a5fefe3c2058" },
                column: "Quantity",
                value: 39);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "79640b64-94d3-4cb2-89c8-a5fefe3c2059" },
                column: "Quantity",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 42", 2569m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 47", 2543m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 12", 2551m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 7", 2579m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 43", 2538m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 19", 2572m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 49", 2581m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                column: "Name",
                value: "ProductName 38");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 40", 2580m });
        }
    }
}
