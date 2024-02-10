using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class Init : Migration
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", 0, "a494de60-3fbc-4a29-920a-1cafc134488c", "user43@gmail.com", false, "nguyen", "12", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "3a7fd777-d3bc-4c76-b3b2-fad5a4376bfd", false, null },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", 0, "d76065c2-de93-45c4-bdae-0df9b9360e1a", "user12@gmail.com", false, "nguyen", "26", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "2bb27057-9c7c-4c5d-a354-35716739f8d2", false, null },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", 0, "e1c853d5-fed4-4026-8bf0-b0518b5a6e1b", "user17@gmail.com", false, "nguyen", "49", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "45cb0027-c272-44d4-b440-9720f1737309", false, null },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", 0, "ab397e33-2ed0-42b3-aee0-2ac3d3dd9b5f", "user49@gmail.com", false, "nguyen", "15", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "36f79761-3853-4639-97d5-f6f093c06b5b", false, null },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", 0, "2874b2e5-bce3-4dc5-a643-2306fbec3a13", "user10@gmail.com", false, "nguyen", "30", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "4558898c-3c4a-4133-be08-5b8e387d4cd4", false, null },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", 0, "740f9c3b-8fbe-4de7-a4df-11a3cd3437b6", "user41@gmail.com", false, "nguyen", "26", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "5f6af64e-95b2-4e78-b42f-6938319e8f30", false, null },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", 0, "7f260573-f742-4042-a2b1-7ef54de3cfa7", "user5@gmail.com", false, "nguyen", "36", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "40c6db99-1572-4727-a829-5f81e1fed6ba", false, null },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", 0, "112df2e7-db27-4866-82fc-9676df30fc62", "user14@gmail.com", false, "nguyen", "32", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "484a2813-ccd6-466e-ac97-0746298685dd", false, null },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", 0, "cbce2753-80de-44a6-801a-9e59e8c6e84c", "user28@gmail.com", false, "nguyen", "25", false, null, null, null, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", null, false, "2f4cd872-2ca4-4da4-8edf-e6ddaacfcac1", false, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "category name  28" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "category name  3" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "category name  5" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "category name  36" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "category name  46" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "category name  47" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "category name  30" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "category name  36" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "category name  32" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Status", "UserId" },
                values: new object[,]
                {
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", 0, "79640b64-94d3-4cb2-89c8-a5fefe3c2051" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", 0, "79640b64-94d3-4cb2-89c8-a5fefe3c2052" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", 0, "79640b64-94d3-4cb2-89c8-a5fefe3c2053" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", 0, "79640b64-94d3-4cb2-89c8-a5fefe3c2054" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", 0, "79640b64-94d3-4cb2-89c8-a5fefe3c2055" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", 0, "79640b64-94d3-4cb2-89c8-a5fefe3c2056" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", 0, "79640b64-94d3-4cb2-89c8-a5fefe3c2057" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", 0, "79640b64-94d3-4cb2-89c8-a5fefe3c2058" },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", 0, "79640b64-94d3-4cb2-89c8-a5fefe3c2059" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 36", 2558m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 2", 2566m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 34", 2555m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 32", 2581m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 6", 2555m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 2", 2556m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 4", 2548m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 41", 2572m },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8", "ProductName 18", 2555m }
                });

            migrationBuilder.InsertData(
                table: "ProductOrders",
                columns: new[] { "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2051", "79640b64-94d3-4cb2-89c8-a5fefe3c2051", 10 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2052", "79640b64-94d3-4cb2-89c8-a5fefe3c2052", 26 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2053", "79640b64-94d3-4cb2-89c8-a5fefe3c2053", 44 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2054", "79640b64-94d3-4cb2-89c8-a5fefe3c2054", 48 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2055", "79640b64-94d3-4cb2-89c8-a5fefe3c2055", 40 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2056", "79640b64-94d3-4cb2-89c8-a5fefe3c2056", 3 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2057", "79640b64-94d3-4cb2-89c8-a5fefe3c2057", 39 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2058", "79640b64-94d3-4cb2-89c8-a5fefe3c2058", 1 },
                    { "79640b64-94d3-4cb2-89c8-a5fefe3c2059", "79640b64-94d3-4cb2-89c8-a5fefe3c2059", 24 }
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
