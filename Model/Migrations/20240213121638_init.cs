using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_ProductOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", 0, "Dia chi 49", "8f0f4b1c-34e5-4e1f-88e5-35951a4f0e90", "user42@gmail.com", false, "nguyen", "19", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "4b495378-da7d-49b2-a9bb-9b891e2f79d6", false, "nguyen14" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", 0, "Dia chi 46", "9849b1b4-79aa-44a3-bf6a-9e4dffd75989", "user37@gmail.com", false, "nguyen", "24", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "16a69000-2900-4e1e-9bf0-5e27810d1415", false, "nguyen10" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", 0, "Dia chi 31", "d25b25ad-f552-4550-9c1b-b716b0551bb2", "user17@gmail.com", false, "nguyen", "37", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "57fb86d3-efaa-4474-af00-c13e478f9eea", false, "nguyen44" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", 0, "Dia chi 9", "d3a4cd1e-125d-4c04-a4e2-d240c520656c", "user22@gmail.com", false, "nguyen", "47", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "980e7af4-c68c-4ce3-8ee5-a91f956c73e4", false, "nguyen43" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", 0, "Dia chi 16", "a8cbefe4-cd82-442e-8143-2617f5d6cd38", "user49@gmail.com", false, "nguyen", "38", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "45f1741d-ab19-4368-824e-ed96b637b9a5", false, "nguyen3" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", 0, "Dia chi 30", "2a3cb63e-34c4-41a8-af69-7d0edaf72a15", "user25@gmail.com", false, "nguyen", "16", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "fd4a1c0d-b34a-487e-9921-98abd96f1b56", false, "nguyen28" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", 0, "Dia chi 40", "4c37f16e-ebaf-40c2-9db6-3c54c04a60e6", "user43@gmail.com", false, "nguyen", "30", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "55d4d275-2782-4f06-90ab-57d39b5b3508", false, "nguyen16" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", 0, "Dia chi 5", "76232e95-753e-4d7a-ad3d-582d5047f16d", "user9@gmail.com", false, "nguyen", "3", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "c5faaaf6-c479-4dc4-a876-e9bdf72c5571", false, "nguyen26" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", 0, "Dia chi 42", "b6eaf532-4c37-48f0-9840-aebba7a47f91", "user6@gmail.com", false, "nguyen", "23", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "dd024905-9b47-4462-b894-36e07322a7d4", false, "nguyen23" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "category name  16" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "category name  30" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "category name  45" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "category name  41" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "category name  23" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "category name  29" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "category name  2" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "category name  45" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "category name  10" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Status", "Time", "UserId" },
                values: new object[,]
                {
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", 0, new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9395), "79640b64-94d3-4cb2-89c8-a5fefe3c2051" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", 0, new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9397), "79640b64-94d3-4cb2-89c8-a5fefe3c2052" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", 0, new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9399), "79640b64-94d3-4cb2-89c8-a5fefe3c2053" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", 0, new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9399), "79640b64-94d3-4cb2-89c8-a5fefe3c2054" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", 0, new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9400), "79640b64-94d3-4cb2-89c8-a5fefe3c2055" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", 0, new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9402), "79640b64-94d3-4cb2-89c8-a5fefe3c2056" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", 0, new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9403), "79640b64-94d3-4cb2-89c8-a5fefe3c2057" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", 0, new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9404), "79640b64-94d3-4cb2-89c8-a5fefe3c2058" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", 0, new DateTime(2024, 2, 13, 19, 16, 38, 716, DateTimeKind.Local).AddTicks(9405), "79640b64-94d3-4cb2-89c8-a5fefe3c2059" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "Mô tả điện thoại", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 42", 2569m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "Mô tả điện thoại", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 47", 2543m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "Mô tả điện thoại", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 12", 2551m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "Mô tả điện thoại", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 7", 2579m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "Mô tả điện thoại", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 43", 2538m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "Mô tả điện thoại", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 19", 2572m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "Mô tả điện thoại", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 49", 2581m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "Mô tả điện thoại", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 38", 2581m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "Mô tả điện thoại", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 40", 2580m }
                });

            migrationBuilder.InsertData(
                table: "ProductOrders",
                columns: new[] { "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "79640b64-94d3-4cb2-89c8-a5fefe3c2051", 12 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "79640b64-94d3-4cb2-89c8-a5fefe3c2052", 1 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "79640b64-94d3-4cb2-89c8-a5fefe3c2053", 34 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "79640b64-94d3-4cb2-89c8-a5fefe3c2054", 45 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "79640b64-94d3-4cb2-89c8-a5fefe3c2055", 47 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "79640b64-94d3-4cb2-89c8-a5fefe3c2056", 36 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "79640b64-94d3-4cb2-89c8-a5fefe3c2057", 37 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "79640b64-94d3-4cb2-89c8-a5fefe3c2058", 39 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "79640b64-94d3-4cb2-89c8-a5fefe3c2059", 37 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_OrderId",
                table: "ProductOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

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
                name: "ProductOrders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
