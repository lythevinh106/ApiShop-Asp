using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class AddDescriptionProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "6ce9dd0e-de66-44b6-8ba3-00b7c9e07107", "user13@gmail.com", "37", "0580c64f-039d-4d3b-bab5-d77b1f33f8fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "b8e8bf51-a2b7-4f0e-aefb-7b14d3732b47", "user25@gmail.com", "2", "e739bacb-e89e-47e9-9cd9-a4090612944f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "85ccd1e5-0365-41db-83b2-7973610f8c11", "user34@gmail.com", "44", "1e65c994-739b-4e09-8065-ef95bcaaae74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "9c7ee594-f6a5-44fb-8ed4-16d2c2957c27", "user41@gmail.com", "26", "2b6e31f1-82ba-44c0-8f53-f4e441d9acb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "8e254b2e-0853-42d2-831f-2bc979ea6591", "user9@gmail.com", "23", "2c2bc2f7-0297-410c-bc6a-c8421d79824e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "c9ded8a4-1261-4461-a39e-54967c2dd795", "user2@gmail.com", "36", "456bcdec-5bcb-43b1-93df-04bdec0a48fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "ce6853b7-a690-4111-82f2-0ea323e9afab", "user33@gmail.com", "48", "fefc0344-45f2-4dd5-8891-8b0b8a079924" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "769a96a5-5b7b-4041-97c4-3cbf25f522c4", "user35@gmail.com", "36", "71169b04-d6fe-4b8e-bee4-b2f56e2bbe53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "4fb9c52f-f356-43f2-bc70-d356ef9bf8e4", "user37@gmail.com", "18", "463cfe01-5c9f-4c92-bead-666bc52a9db7" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                column: "Name",
                value: "category name  38");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                column: "Name",
                value: "category name  49");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                column: "Name",
                value: "category name  47");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                column: "Name",
                value: "category name  15");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                column: "Name",
                value: "category name  47");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                column: "Name",
                value: "category name  27");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                column: "Name",
                value: "category name  38");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                column: "Name",
                value: "category name  8");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                column: "Name",
                value: "category name  11");

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "79640b64-94d3-4cb2-89c8-a5fefe3c2051" },
                column: "Quantity",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "79640b64-94d3-4cb2-89c8-a5fefe3c2052" },
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "79640b64-94d3-4cb2-89c8-a5fefe3c2053" },
                column: "Quantity",
                value: 38);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "79640b64-94d3-4cb2-89c8-a5fefe3c2054" },
                column: "Quantity",
                value: 38);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "79640b64-94d3-4cb2-89c8-a5fefe3c2055" },
                column: "Quantity",
                value: 38);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "79640b64-94d3-4cb2-89c8-a5fefe3c2056" },
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "79640b64-94d3-4cb2-89c8-a5fefe3c2057" },
                column: "Quantity",
                value: 44);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "79640b64-94d3-4cb2-89c8-a5fefe3c2058" },
                column: "Quantity",
                value: 19);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "79640b64-94d3-4cb2-89c8-a5fefe3c2059" },
                column: "Quantity",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Mô tả điện thoại", "ProductName 30", 2563m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Mô tả điện thoại", "ProductName 17", 2548m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Mô tả điện thoại", "ProductName 46", 2559m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Mô tả điện thoại", "ProductName 29", 2538m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Mô tả điện thoại", "ProductName 44", 2559m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Mô tả điện thoại", "ProductName 18", 2573m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Mô tả điện thoại", "ProductName 11", 2547m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Mô tả điện thoại", "ProductName 2", 2557m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Mô tả điện thoại", "ProductName 4", 2569m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "a494de60-3fbc-4a29-920a-1cafc134488c", "user43@gmail.com", "12", "3a7fd777-d3bc-4c76-b3b2-fad5a4376bfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "d76065c2-de93-45c4-bdae-0df9b9360e1a", "user12@gmail.com", "26", "2bb27057-9c7c-4c5d-a354-35716739f8d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "e1c853d5-fed4-4026-8bf0-b0518b5a6e1b", "user17@gmail.com", "49", "45cb0027-c272-44d4-b440-9720f1737309" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "ab397e33-2ed0-42b3-aee0-2ac3d3dd9b5f", "user49@gmail.com", "15", "36f79761-3853-4639-97d5-f6f093c06b5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "2874b2e5-bce3-4dc5-a643-2306fbec3a13", "user10@gmail.com", "30", "4558898c-3c4a-4133-be08-5b8e387d4cd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "740f9c3b-8fbe-4de7-a4df-11a3cd3437b6", "user41@gmail.com", "26", "5f6af64e-95b2-4e78-b42f-6938319e8f30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "7f260573-f742-4042-a2b1-7ef54de3cfa7", "user5@gmail.com", "36", "40c6db99-1572-4727-a829-5f81e1fed6ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "112df2e7-db27-4866-82fc-9676df30fc62", "user14@gmail.com", "32", "484a2813-ccd6-466e-ac97-0746298685dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "SecurityStamp" },
                values: new object[] { "cbce2753-80de-44a6-801a-9e59e8c6e84c", "user28@gmail.com", "25", "2f4cd872-2ca4-4da4-8edf-e6ddaacfcac1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                column: "Name",
                value: "category name  28");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                column: "Name",
                value: "category name  3");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                column: "Name",
                value: "category name  5");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                column: "Name",
                value: "category name  36");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                column: "Name",
                value: "category name  46");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                column: "Name",
                value: "category name  47");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                column: "Name",
                value: "category name  30");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                column: "Name",
                value: "category name  36");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                column: "Name",
                value: "category name  32");

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "79640b64-94d3-4cb2-89c8-a5fefe3c2051" },
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "79640b64-94d3-4cb2-89c8-a5fefe3c2052" },
                column: "Quantity",
                value: 26);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "79640b64-94d3-4cb2-89c8-a5fefe3c2053" },
                column: "Quantity",
                value: 44);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "79640b64-94d3-4cb2-89c8-a5fefe3c2054" },
                column: "Quantity",
                value: 48);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "79640b64-94d3-4cb2-89c8-a5fefe3c2055" },
                column: "Quantity",
                value: 40);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "79640b64-94d3-4cb2-89c8-a5fefe3c2056" },
                column: "Quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "79640b64-94d3-4cb2-89c8-a5fefe3c2057" },
                column: "Quantity",
                value: 39);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "79640b64-94d3-4cb2-89c8-a5fefe3c2058" },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "79640b64-94d3-4cb2-89c8-a5fefe3c2059" },
                column: "Quantity",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 36", 2558m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 2", 2566m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 34", 2555m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 32", 2581m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 6", 2555m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 2", 2556m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 4", 2548m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 41", 2572m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79640b64-94d3-4cb2-89c8-a5fefe3c2059",
                columns: new[] { "Name", "Price" },
                values: new object[] { "ProductName 18", 2555m });
        }
    }
}
