using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class initmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaxUsages = table.Column<int>(type: "int", nullable: false),
                    CurrentUsages = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FlatOrHouse = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BuildingOrCompanyOrApartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AreaOrColonyOrStreetOrSectorOrVillage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PinCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OldPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BuyTurn = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CouponConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponId = table.Column<int>(type: "int", nullable: false),
                    Attribute = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Operator = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DiscountAmount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouponConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CouponConditions_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CouponId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Orders_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "BannerDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BannerId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BannerDetails_Banners_BannerId",
                        column: x => x.BannerId,
                        principalTable: "Banners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BannerDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Star = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsDetails_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CouponId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "5364 Alanis Glen, West Lura, Czech Republic", "b6633ebe-cfd3-44f3-afa2-df7658b30f95", new DateTime(2024, 2, 5, 6, 15, 7, 571, DateTimeKind.Utc).AddTicks(6637), "Damian21@gmail.com", true, "Damian", "O'Hara", false, null, "DAMIAN21@GMAIL.COM", "DAMIAN_OHARA", "AQAAAAIAAYagAAAAEIGnI+i2xNkte/mFo1u65Wh9KvSxm3lIGJZxSQCQhh0ToxeegbKTazhUyDgh7g9lrQ==", "154-020-9240", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/338.jpg", null, null, null, false, null, "Damian_OHara" },
                    { 2, 0, "22897 Yundt Forest, New Marisol, Uzbekistan", "69e77f05-8eee-4266-9fea-7a664afd2d35", new DateTime(2024, 10, 27, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(8210), "Yoshiko_Nitzsche@gmail.com", true, "Yoshiko", "Nitzsche", false, null, "YOSHIKO_NITZSCHE@GMAIL.COM", "YOSHIKO.NITZSCHE81", "AQAAAAIAAYagAAAAEFY/nVzfKFhveqxiu7vnhMM0ekh8IKmNc6gSH63RBuukdgb/Apky/ptt/JppuHzMQw==", "187-409-4924", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1003.jpg", null, null, null, false, null, "Yoshiko.Nitzsche81" },
                    { 3, 0, "514 Moore Turnpike, North Shanon, Hungary", "c2350f5e-d7d1-4248-a2e4-ac07792c6e94", new DateTime(2024, 10, 21, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(8551), "Shanna_Hills@hotmail.com", true, "Shanna", "Hills", false, null, "SHANNA_HILLS@HOTMAIL.COM", "SHANNA4", "AQAAAAIAAYagAAAAEHKpC5gU3Jus/6yWAvGTzJ/pSrgXKUgT5w20R3uYi+Si3UNy9C1aUcq+H8qT0hL7aQ==", "330-188-8053", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/549.jpg", null, null, null, false, null, "Shanna4" },
                    { 4, 0, "1966 Koss Club, Greenfelderton, Cuba", "a7fee4cc-8c8f-4e7b-9dde-650344a84522", new DateTime(2024, 10, 1, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(8801), "Edwin57@yahoo.com", true, "Edwin", "Mitchell", false, null, "EDWIN57@YAHOO.COM", "EDWIN_MITCHELL2", "AQAAAAIAAYagAAAAEELqYHz1w67tnDVy4pjODgqYObhBjkOYlj9XwJxEGWWR3eNt+J2+aSd/vQAfDBKmbw==", "783-828-6740", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/266.jpg", null, null, null, false, null, "Edwin_Mitchell2" },
                    { 5, 0, "768 Bednar Locks, Lake Lisetteland, Faroe Islands", "57ecf5a3-161d-41a7-ba3c-83edc8010092", new DateTime(2024, 1, 17, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(9022), "Mertie.Walter@gmail.com", true, "Mertie", "Walter", false, null, "MERTIE.WALTER@GMAIL.COM", "MERTIE.WALTER64", "AQAAAAIAAYagAAAAEOaaqaEIaEjzpA0fc/JxSIUpJ2vr0yqwVCYucskiYZYZS8ZrX5TgKQTuk76ZwchYlg==", "371-862-4901", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/342.jpg", null, null, null, false, null, "Mertie.Walter64" },
                    { 6, 0, "0710 Beverly Coves, Josefaview, Iraq", "e2e97ec6-1563-45e5-8171-e5014c1bff6a", new DateTime(2024, 6, 8, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(9314), "Gino15@hotmail.com", true, "Gino", "Parisian", false, null, "GINO15@HOTMAIL.COM", "GINO26", "AQAAAAIAAYagAAAAEOuOFlqcuzpR0XQ7MT9kaKEwHBDy+P7tUc9wYrjZv0H4kcg2lnWh6wdYwQkJKJ/wPg==", "992-374-3549", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/225.jpg", null, null, null, false, null, "Gino26" },
                    { 7, 0, "88092 Reagan Row, East Camylleberg, Bermuda", "cd90dfe5-6480-42aa-9ffb-f2d820208fe7", new DateTime(2024, 8, 11, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(9518), "Rahul45@hotmail.com", true, "Rahul", "Kiehn", false, null, "RAHUL45@HOTMAIL.COM", "RAHUL40", "AQAAAAIAAYagAAAAENJGBnfaZ7g54zCfVYQAyX3pWyqQWJhlcQumTL7XC8vtU/Dx30kYengMlrdRzFXx/g==", "140-516-9405", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/824.jpg", null, null, null, false, null, "Rahul40" },
                    { 8, 0, "378 Gaston Knolls, Oberbrunnerbury, Cyprus", "b77b2613-2fb6-4660-b8d0-71825f3f39c2", new DateTime(2024, 3, 1, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(9736), "Soledad74@gmail.com", true, "Soledad", "Stanton", false, null, "SOLEDAD74@GMAIL.COM", "SOLEDAD.STANTON", "AQAAAAIAAYagAAAAEHQbR/HeZkTzmh4SGhLDBIdJ2I3yDGAUwPe6iVboUHh18L7ezQfzq9y96qLCcYFVnw==", "663-986-5224", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/464.jpg", null, null, null, false, null, "Soledad.Stanton" },
                    { 9, 0, "0775 Nicole Mall, Lonzoport, Kazakhstan", "0a1f6f95-69fb-4ea8-8a9b-abfccb12a434", new DateTime(2024, 6, 26, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(9921), "Antonia_Wunsch@hotmail.com", true, "Antonia", "Wunsch", false, null, "ANTONIA_WUNSCH@HOTMAIL.COM", "ANTONIA.WUNSCH", "AQAAAAIAAYagAAAAEIKaBNrBZZ7rsQo9rogdcDRzX0P91UlniOtXeu9KZSTfoA/AQ3SOf1qGLuh0K7FubQ==", "605-357-5455", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/284.jpg", null, null, null, false, null, "Antonia.Wunsch" },
                    { 10, 0, "145 Zulauf Lodge, West Regan, Cambodia", "c2a80072-ee41-4e66-875a-18f70f0d3483", new DateTime(2024, 8, 17, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(158), "Rupert.Wilderman@yahoo.com", true, "Rupert", "Wilderman", false, null, "RUPERT.WILDERMAN@YAHOO.COM", "RUPERT23", "AQAAAAIAAYagAAAAEG5A1LKzlI0ID4sJEcx7gqDmT+unMon5mfnbtZrdIJb0tK8MWgcw1C1iFPuW+6jMtw==", "895-867-1149", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/303.jpg", null, null, null, false, null, "Rupert23" },
                    { 11, 0, "30759 Ernser Port, Port Estell, Saint Kitts and Nevis", "076c922b-c8a2-475a-a6b3-a356d89c3ad6", new DateTime(2024, 7, 19, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(363), "Arne_Dickinson84@hotmail.com", true, "Arne", "Dickinson", false, null, "ARNE_DICKINSON84@HOTMAIL.COM", "ARNE_DICKINSON42", "AQAAAAIAAYagAAAAEIpQlw+3sO3FCWMakGJqHHUBb/hHN+LFfVPVd0JNcnSdN6nzP0xnCFG/AA5A6YtOFQ==", "092-813-6698", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/13.jpg", null, null, null, false, null, "Arne_Dickinson42" },
                    { 12, 0, "9860 Madaline Causeway, Coralieberg, Saint Barthelemy", "4d5803df-81bc-44a0-9e7b-d9815e0035fa", new DateTime(2024, 7, 28, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(640), "Aylin_Jakubowski@hotmail.com", true, "Aylin", "Jakubowski", false, null, "AYLIN_JAKUBOWSKI@HOTMAIL.COM", "AYLIN84", "AQAAAAIAAYagAAAAEJfMGhM7bYb29cY0vBjdqUl0vM+dZi2hRbYwjZkqOFWP/R7keBJy6zJtsYI3ks26vg==", "064-606-4778", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1013.jpg", null, null, null, false, null, "Aylin84" },
                    { 13, 0, "331 Sister Rapid, West Durwardshire, Italy", "afa1e77a-5a6a-47e3-bb0d-72ca28fa2e23", new DateTime(2024, 10, 11, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(844), "Hilario.Kirlin78@yahoo.com", true, "Hilario", "Kirlin", false, null, "HILARIO.KIRLIN78@YAHOO.COM", "HILARIO.KIRLIN72", "AQAAAAIAAYagAAAAEJU0/1Lxxs7+3mUrVx0KfL4A5MIs5bGIz+z0xJPijxTTagL2lOHlHMe8Urxk64qGxQ==", "306-006-2034", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1185.jpg", null, null, null, false, null, "Hilario.Kirlin72" },
                    { 14, 0, "445 Murazik Radial, Binsview, Switzerland", "7cd35d2f-50a9-4f2a-857e-a90fdb50cd67", new DateTime(2024, 2, 14, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(1125), "Rosanna99@hotmail.com", true, "Rosanna", "Schamberger", false, null, "ROSANNA99@HOTMAIL.COM", "ROSANNA_SCHAMBERGER", "AQAAAAIAAYagAAAAECAz6ngm+SWYc8Q9Wf5vD3qh+qSH2EZd09P/yo8SlUsO+yxnjqSQweTn5NF1Vly6bQ==", "425-084-9698", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1243.jpg", null, null, null, false, null, "Rosanna_Schamberger" },
                    { 15, 0, "523 Morar Way, South Elouisestad, Antarctica (the territory South of 60 deg S)", "1526396e-e509-42aa-b7d1-bc3965db7abd", new DateTime(2024, 1, 26, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(1335), "Filiberto21@hotmail.com", true, "Filiberto", "Stark", false, null, "FILIBERTO21@HOTMAIL.COM", "FILIBERTO_STARK", "AQAAAAIAAYagAAAAEOTDyHoHAAgxMvXNAyhuafGwYv6fF9Ri/+E8NZL1UlQaTdlTQYh6jONsVx8qfBC54A==", "094-922-5989", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/78.jpg", null, null, null, false, null, "Filiberto_Stark" },
                    { 16, 0, "20110 Anderson Trace, Strosinshire, Ukraine", "28e9b758-accf-4d54-a9f3-d91218c28ea8", new DateTime(2024, 3, 25, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(1565), "Adella.Hickle@hotmail.com", true, "Adella", "Hickle", false, null, "ADELLA.HICKLE@HOTMAIL.COM", "ADELLA.HICKLE", "AQAAAAIAAYagAAAAEDE/BWivI6zmYisrm4wmBJLAdz5QaD+Aiz3zt2q9C5IZbse3xBsXddznpsR4nw/6SA==", "306-347-7090", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/825.jpg", null, null, null, false, null, "Adella.Hickle" },
                    { 17, 0, "709 Bradley Islands, Kennyberg, Guam", "9a85aa65-10cd-42b8-95e1-4dd2d0350442", new DateTime(2024, 6, 12, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(1786), "Estefania_Konopelski@yahoo.com", true, "Estefania", "Konopelski", false, null, "ESTEFANIA_KONOPELSKI@YAHOO.COM", "ESTEFANIA.KONOPELSKI14", "AQAAAAIAAYagAAAAEI/I+6oHJwvLUWgb0q49PHp+g99GV46YaiypHSGD0ba+fAV7MFY2aOUUpBdfmhpZYA==", "959-811-2279", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/67.jpg", null, null, null, false, null, "Estefania.Konopelski14" },
                    { 18, 0, "318 Cortney Squares, Princeview, Angola", "201129ec-10f6-48c4-a1c1-d04d37edc480", new DateTime(2024, 4, 19, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(1985), "Green.Gerlach@yahoo.com", true, "Green", "Gerlach", false, null, "GREEN.GERLACH@YAHOO.COM", "GREEN.GERLACH", "AQAAAAIAAYagAAAAECzgTjVkrNn1L3BRDUwXOJwiAp5VbD/9mJ1Q+A9N9Ezz6BIHB4/os4IjRe8c+RY++Q==", "790-340-3384", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1085.jpg", null, null, null, false, null, "Green.Gerlach" },
                    { 19, 0, "3450 O'Conner Plaza, Port Garretmouth, Barbados", "b6e5ef02-209a-42be-a61e-5170ce78ec97", new DateTime(2024, 3, 1, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(2211), "Gail_Muller32@hotmail.com", true, "Gail", "Muller", false, null, "GAIL_MULLER32@HOTMAIL.COM", "GAIL_MULLER94", "AQAAAAIAAYagAAAAELTP7Labydu6v9h+xbxt8g/iqCw34ErTCk4NoJB41sX1bzjBGNKgE1aEX/ndkaYo1g==", "512-648-6640", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/652.jpg", null, null, null, false, null, "Gail_Muller94" },
                    { 20, 0, "9328 Cruickshank Island, Lake Drewberg, Thailand", "9e161447-8511-4133-a52a-4ac7aa26727c", new DateTime(2024, 5, 7, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(2397), "Marlen71@yahoo.com", true, "Marlen", "Klein", false, null, "MARLEN71@YAHOO.COM", "MARLEN_KLEIN", "AQAAAAIAAYagAAAAEKU7V8uIoZrrwC2k2hwPVhDNTed1/IgokBxMMUbixCylNp7k4NYpIrnmh1SzFGt0Vg==", "532-572-0217", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/221.jpg", null, null, null, false, null, "Marlen_Klein" },
                    { 21, 0, "714 Schowalter Skyway, New Gregoriahaven, Norfolk Island", "02b1cd7f-829a-482c-bfd9-5ebc9be3b8b7", new DateTime(2023, 12, 19, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(2623), "Mazie.Cassin84@yahoo.com", true, "Mazie", "Cassin", false, null, "MAZIE.CASSIN84@YAHOO.COM", "MAZIE1", "AQAAAAIAAYagAAAAEBAdhflbI2+OzL4zuHZNduP7RoHHWUfVvlyrZuHi0ZAFVkEHlyyyD1xE2tQ5TdjvNA==", "966-550-9045", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/380.jpg", null, null, null, false, null, "Mazie1" },
                    { 22, 0, "704 Fadel Cove, East Brodyland, Togo", "7dbbab67-3dcc-44b1-9c28-df1fc9e8473f", new DateTime(2024, 3, 2, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(2855), "Kraig.Schroeder@yahoo.com", true, "Kraig", "Schroeder", false, null, "KRAIG.SCHROEDER@YAHOO.COM", "KRAIG_SCHROEDER8", "AQAAAAIAAYagAAAAEKhV3y+Pa9lhkcLheMI/LiYDS9MBXAmh8zEswdjH1cm9ls68mnNkb3WpK5inb8VRrQ==", "711-789-7564", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/674.jpg", null, null, null, false, null, "Kraig_Schroeder8" },
                    { 23, 0, "84906 Wisoky Mills, Steuberview, Puerto Rico", "2a57848c-175b-4757-a970-eb18af9c2cc1", new DateTime(2024, 9, 23, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(3092), "Genevieve.Corkery90@gmail.com", true, "Genevieve", "Corkery", false, null, "GENEVIEVE.CORKERY90@GMAIL.COM", "GENEVIEVE76", "AQAAAAIAAYagAAAAEIK+p/oUu+Tp8G/ghP9pBWfaR2nKzfNBBYOsvS9QV8bfZiPp6Jv+ztLKl80i94TxgQ==", "490-851-6924", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/701.jpg", null, null, null, false, null, "Genevieve76" },
                    { 24, 0, "948 Lucio Radial, Nicolasside, Cote d'Ivoire", "f5c12c2f-8e05-4169-a2d6-8bac266db36c", new DateTime(2024, 4, 2, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(3274), "Dario_Bogan56@yahoo.com", true, "Dario", "Bogan", false, null, "DARIO_BOGAN56@YAHOO.COM", "DARIO.BOGAN21", "AQAAAAIAAYagAAAAEG+2hWzh1vIDirrWtaMnvWbC2Eb/dWJIdIOUCkhz3O/lElthb4ZuFZczTfYHtT1yoQ==", "116-607-5188", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/863.jpg", null, null, null, false, null, "Dario.Bogan21" },
                    { 25, 0, "1037 Keebler Ways, Ilatown, Suriname", "ec94f4db-6d9b-4047-b584-ba4a901acb6a", new DateTime(2024, 1, 30, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(3491), "Tyreek80@gmail.com", true, "Tyreek", "Goyette", false, null, "TYREEK80@GMAIL.COM", "TYREEK.GOYETTE", "AQAAAAIAAYagAAAAELS42/xO2Rl5XtRs2mnDadSDmpYBtHBOOpskTEfUIYpSACNIkho2CgUR0bX3VOHsGQ==", "640-520-9047", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/663.jpg", null, null, null, false, null, "Tyreek.Goyette" },
                    { 26, 0, "9488 Witting Locks, Albinaport, Croatia", "c92170aa-f5d6-4b3b-b3dd-feebf7558cfc", new DateTime(2024, 11, 11, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(3715), "Israel16@yahoo.com", true, "Israel", "Heidenreich", false, null, "ISRAEL16@YAHOO.COM", "ISRAEL15", "AQAAAAIAAYagAAAAEEY41Q6T4mKieHzqv6sZSN4PBMia1D837a2i16REGluVDtzVhSCTkyRndJKt7yJWbg==", "074-538-4630", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/660.jpg", null, null, null, false, null, "Israel15" },
                    { 27, 0, "5764 Connelly Hill, Lake Franz, Cook Islands", "00585d23-2aee-4d3e-828d-12e5eb2aed67", new DateTime(2024, 4, 3, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(3979), "Orval61@yahoo.com", true, "Orval", "Veum", false, null, "ORVAL61@YAHOO.COM", "ORVAL.VEUM", "AQAAAAIAAYagAAAAEAtvBp1GBbHmGVxS2WBiECXt4lbPwQtRoajn4rxa0dCZMldagplURfFY0bdNyaXTJA==", "005-956-2685", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/252.jpg", null, null, null, false, null, "Orval.Veum" },
                    { 28, 0, "381 Klocko Forge, Lake Georgianatown, Ireland", "56dd58eb-5dae-4298-aeb7-41619a81ff85", new DateTime(2024, 5, 15, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(4174), "Victor48@yahoo.com", true, "Victor", "Kautzer", false, null, "VICTOR48@YAHOO.COM", "VICTOR0", "AQAAAAIAAYagAAAAEBWkobUSAZkYnv5y5WbaDd7wUVsHLh4dz1D5PylielUZ6XZTLeQuKBowOh05ly3COg==", "799-061-0916", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/58.jpg", null, null, null, false, null, "Victor0" },
                    { 29, 0, "29092 McGlynn Square, New Carmel, Saint Lucia", "52f9c988-9277-4dde-a32c-9e7ce9056aa0", new DateTime(2024, 3, 3, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(4445), "Hettie_Grant@hotmail.com", true, "Hettie", "Grant", false, null, "HETTIE_GRANT@HOTMAIL.COM", "HETTIE.GRANT", "AQAAAAIAAYagAAAAEKvjtpkHlkI11zm61b6jWfl2KfOqFaILIgny0Pvs1UI85weI6ILU7YxVNHhah6y8PQ==", "906-569-1874", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1071.jpg", null, null, null, false, null, "Hettie.Grant" },
                    { 30, 0, "676 Reina Expressway, Natashachester, Yemen", "996bb792-f2dd-4e02-819b-90905ddac0e0", new DateTime(2024, 4, 28, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(4649), "Vern_Haley60@gmail.com", true, "Vern", "Haley", false, null, "VERN_HALEY60@GMAIL.COM", "VERN_HALEY", "AQAAAAIAAYagAAAAEDm6GPqlDnXoJXiv/6rMS4ABNuRBwss4vP3XDKbFlWtNVMrDxVoxguFBa/eWmSbVgg==", "173-872-3396", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/312.jpg", null, null, null, false, null, "Vern_Haley" },
                    { 31, 0, "227 Goodwin Parkways, Lake Orlochester, Uzbekistan", "af0846d7-c4f3-493b-9b80-d1a6ab99d9ca", new DateTime(2024, 2, 29, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(4863), "Gideon26@hotmail.com", true, "Gideon", "Smith", false, null, "GIDEON26@HOTMAIL.COM", "GIDEON90", "AQAAAAIAAYagAAAAEKVPhsrrj4Xd25hz98UlUgqKX5Soowr9tIVQEpmHtQTGW1d75HNu4Zg2FTsEa38oNg==", "365-316-2658", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1095.jpg", null, null, null, false, null, "Gideon90" },
                    { 32, 0, "15768 Geovanni Cliff, Lake Alva, Tanzania", "4aaddc43-9a58-45bc-b4c4-390054ca5e60", new DateTime(2024, 6, 14, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(5034), "Lupe_Renner86@gmail.com", true, "Lupe", "Renner", false, null, "LUPE_RENNER86@GMAIL.COM", "LUPE41", "AQAAAAIAAYagAAAAEKlQG6LytLVPXJqF9C2fp5oYaBWB4/Hqd4EIYHzgcBx3LhJfWbA/7WTwB4slPV3xpQ==", "107-184-9368", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/645.jpg", null, null, null, false, null, "Lupe41" },
                    { 33, 0, "3515 Reichel Walks, West Haylie, Samoa", "07d913ca-f374-479c-9693-e906470ae8f3", new DateTime(2024, 2, 8, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(5295), "Zechariah31@hotmail.com", true, "Zechariah", "Breitenberg", false, null, "ZECHARIAH31@HOTMAIL.COM", "ZECHARIAH60", "AQAAAAIAAYagAAAAEGAnpZIzUJtdO2upk3ZeiT98jSK9AVaHVYVehcr+ZneCQ3G3hvvcNSAMyiecREO8iQ==", "171-733-7515", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1102.jpg", null, null, null, false, null, "Zechariah60" },
                    { 34, 0, "98742 Bergnaum Fork, Langworthshire, Christmas Island", "08409b5c-2f2d-4e39-9952-8da6e81a0a41", new DateTime(2024, 7, 10, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(5474), "Clara_Jacobs@yahoo.com", true, "Clara", "Jacobs", false, null, "CLARA_JACOBS@YAHOO.COM", "CLARA62", "AQAAAAIAAYagAAAAEFH8oNJVSsienCXmLOtv4GW5/p6jIPiq82rZv0QPs0cDFSZAwm0xyA8TnpV+r3dSRA==", "987-083-2156", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/535.jpg", null, null, null, false, null, "Clara62" },
                    { 35, 0, "139 Greenholt Mountain, Port Laceyhaven, Ghana", "e703ec1e-eb6f-46ea-82b0-44104c7e0df4", new DateTime(2024, 4, 12, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(5689), "Kirsten.Raynor56@hotmail.com", true, "Kirsten", "Raynor", false, null, "KIRSTEN.RAYNOR56@HOTMAIL.COM", "KIRSTEN_RAYNOR", "AQAAAAIAAYagAAAAEADdTds3Hzv9Wc0ojOx4vxcnO0XqPIY5xwPw0zRihotom4WiFEQuTerl/VhMbj5Mrg==", "082-848-3343", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1167.jpg", null, null, null, false, null, "Kirsten_Raynor" },
                    { 36, 0, "5762 Aylin Ranch, Conorton, Tonga", "da0c6782-63ec-4ad5-9a92-c5fbc5af3239", new DateTime(2024, 3, 28, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(5865), "Palma_Dickens@hotmail.com", true, "Palma", "Dickens", false, null, "PALMA_DICKENS@HOTMAIL.COM", "PALMA_DICKENS", "AQAAAAIAAYagAAAAEAYaosBLsnN9fT2B4adQk6iMK5LD244h313lKCD76XNyLqs9O0DDMZE3vrstWm3wzQ==", "810-876-1064", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/764.jpg", null, null, null, false, null, "Palma_Dickens" },
                    { 37, 0, "8888 Herman Parkway, Runolfsdottirtown, Libyan Arab Jamahiriya", "92ed5a40-7741-4cfc-b9ac-455b4b03856a", new DateTime(2024, 2, 15, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(6062), "William25@hotmail.com", true, "William", "Will", false, null, "WILLIAM25@HOTMAIL.COM", "WILLIAM_WILL3", "AQAAAAIAAYagAAAAELsWaK8qAo5oBFbU/qwLVqu+Jmljuze1n781FnfhjBItG/LIfcl27MWsij+qa4NdOQ==", "464-340-0276", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/30.jpg", null, null, null, false, null, "William_Will3" },
                    { 38, 0, "191 Eliseo Rest, Dayanamouth, Saint Barthelemy", "52f94adb-a821-4301-922b-1fc833ae37c8", new DateTime(2024, 1, 1, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(6253), "Ansel_Keebler@yahoo.com", true, "Ansel", "Keebler", false, null, "ANSEL_KEEBLER@YAHOO.COM", "ANSEL.KEEBLER", "AQAAAAIAAYagAAAAEBOr2aFWH1Ldo47WGWrV61DnFn0VsNyfiylLt1d+8glY6Gh35Hfy6nd4xZ89mQLfNw==", "479-190-0446", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/994.jpg", null, null, null, false, null, "Ansel.Keebler" },
                    { 39, 0, "0621 Anjali Fort, Lake Nedfort, Micronesia", "a6abb3a6-22ca-4e47-8392-4acee2638c2a", new DateTime(2024, 3, 8, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(6494), "May_Johnston4@yahoo.com", true, "May", "Johnston", false, null, "MAY_JOHNSTON4@YAHOO.COM", "MAY.JOHNSTON", "AQAAAAIAAYagAAAAEEbZXzyApjbqzk3fF/al3tGGrXiZXhC2+bzttXMJZcstXm8Zi5zVsVqQYE9bI4sWhg==", "136-330-3236", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/768.jpg", null, null, null, false, null, "May.Johnston" },
                    { 40, 0, "235 Barbara Vista, Shaniaborough, Isle of Man", "16fd147d-e53d-4f17-8444-66bb486ffbf6", new DateTime(2024, 10, 13, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(6673), "Jed_Quitzon@hotmail.com", true, "Jed", "Quitzon", false, null, "JED_QUITZON@HOTMAIL.COM", "JED_QUITZON2", "AQAAAAIAAYagAAAAEOlKK+c0IVJkPr1CdytofPWaZbX63uJHvKproKEECsyGC2BPwYlyYaa4yIgjgtmP3g==", "419-166-6825", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/152.jpg", null, null, null, false, null, "Jed_Quitzon2" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(1668), "https://example.com/images/nike.jpg", "Nike", null },
                    { 2, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2043), "https://example.com/images/adidas.jpg", "Adidas", null },
                    { 3, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2044), "https://example.com/images/gucci.jpg", "Gucci", null },
                    { 4, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2060), "https://example.com/images/louis-vuitton.jpg", "Louis Vuitton", null },
                    { 5, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2061), "https://example.com/images/zara.jpg", "Zara", null },
                    { 6, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2069), "https://example.com/images/h&m.jpg", "H&M", null },
                    { 7, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2070), "https://example.com/images/chanel.jpg", "Chanel", null },
                    { 8, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2071), "https://example.com/images/prada.jpg", "Prada", null },
                    { 9, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2072), "https://example.com/images/versace.jpg", "Versace", null },
                    { 10, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2074), "https://example.com/images/burberry.jpg", "Burberry", null },
                    { 11, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2075), "https://example.com/images/dior.jpg", "Dior", null },
                    { 12, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2076), "https://example.com/images/calvin-klein.jpg", "Calvin Klein", null },
                    { 13, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2077), "https://example.com/images/tommy-hilfiger.jpg", "Tommy Hilfiger", null },
                    { 14, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2078), "https://example.com/images/levis.jpg", "Levi's", null },
                    { 15, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2078), "https://example.com/images/uniqlo.jpg", "Uniqlo", null },
                    { 16, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2079), "https://example.com/images/lacoste.jpg", "Lacoste", null },
                    { 17, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2080), "https://example.com/images/the-north-face.jpg", "The North Face", null },
                    { 18, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2082), "https://example.com/images/ralph-lauren.jpg", "Ralph Lauren", null },
                    { 19, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2083), "https://example.com/images/puma.jpg", "Puma", null },
                    { 20, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2084), "https://example.com/images/hugo-boss.jpg", "Hugo Boss", null },
                    { 21, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2085), "https://example.com/images/armani.jpg", "Armani", null },
                    { 22, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2086), "https://example.com/images/balenciaga.jpg", "Balenciaga", null },
                    { 23, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2087), "https://example.com/images/fendi.jpg", "Fendi", null },
                    { 24, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2100), "https://example.com/images/givenchy.jpg", "Givenchy", null },
                    { 25, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2101), "https://example.com/images/hermes.jpg", "Hermès", null },
                    { 26, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2102), "https://example.com/images/salvatore-ferragamo.jpg", "Salvatore Ferragamo", null },
                    { 27, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2103), "https://example.com/images/valentino.jpg", "Valentino", null },
                    { 28, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2109), "https://example.com/images/dolce-gabbana.jpg", "Dolce & Gabbana", null },
                    { 29, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2110), "https://example.com/images/gap.jpg", "Gap", null },
                    { 30, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2118), "https://example.com/images/forever21.jpg", "Forever 21", null },
                    { 31, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2119), "https://example.com/images/new-balance.jpg", "New Balance", null },
                    { 32, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2120), "https://example.com/images/vans.jpg", "Vans", null },
                    { 33, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2121), "https://example.com/images/converse.jpg", "Converse", null },
                    { 34, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2122), "https://example.com/images/under-armour.jpg", "Under Armour", null },
                    { 35, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2123), "https://example.com/images/reebok.jpg", "Reebok", null },
                    { 36, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2124), "https://example.com/images/coach.jpg", "Coach", null },
                    { 37, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2125), "https://example.com/images/kate-spade.jpg", "Kate Spade", null },
                    { 38, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2126), "https://example.com/images/michael-kors.jpg", "Michael Kors", null },
                    { 39, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2127), "https://example.com/images/bally.jpg", "Bally", null },
                    { 40, new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2128), "https://example.com/images/guess.jpg", "Guess", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9059), "https://example.com/images/men-clothing.jpg", "Men's Clothing", null },
                    { 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9405), "https://example.com/images/women-clothing.jpg", "Women's Clothing", null },
                    { 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9407), "https://example.com/images/children-clothing.jpg", "Children's Clothing", null },
                    { 4, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9408), "https://example.com/images/shoes.jpg", "Shoes", null },
                    { 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9409), "https://example.com/images/bags.jpg", "Bags", null },
                    { 6, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9453), "https://example.com/images/accessories.jpg", "Accessories", null },
                    { 7, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9454), "https://example.com/images/watches.jpg", "Watches", null },
                    { 8, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9455), "https://example.com/images/sportswear.jpg", "Sportswear", null },
                    { 9, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9456), "https://example.com/images/swimwear.jpg", "Swimwear", null },
                    { 10, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9461), "https://example.com/images/formal-wear.jpg", "Formal Wear", null },
                    { 11, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9462), "https://example.com/images/casual-wear.jpg", "Casual Wear", null },
                    { 12, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9462), "https://example.com/images/t-shirts.jpg", "T-Shirts", null },
                    { 13, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9463), "https://example.com/images/jeans.jpg", "Jeans", null },
                    { 14, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9464), "https://example.com/images/jackets-coats.jpg", "Jackets & Coats", null },
                    { 15, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9465), "https://example.com/images/hats-caps.jpg", "Hats & Caps", null },
                    { 16, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9466), "https://example.com/images/scarves.jpg", "Scarves", null },
                    { 17, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9467), "https://example.com/images/sunglasses.jpg", "Sunglasses", null },
                    { 18, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9469), "https://example.com/images/belts.jpg", "Belts", null },
                    { 19, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9470), "https://example.com/images/undergarments.jpg", "Undergarments", null },
                    { 20, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9470), "https://example.com/images/sports-shoes.jpg", "Sports Shoes", null },
                    { 21, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9471), "https://example.com/images/boots.jpg", "Boots", null },
                    { 22, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9472), "https://example.com/images/high-heels.jpg", "High Heels", null },
                    { 23, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9475), "https://example.com/images/sneakers.jpg", "Sneakers", null },
                    { 24, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9476), "https://example.com/images/suits.jpg", "Suits", null },
                    { 25, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9477), "https://example.com/images/dresses.jpg", "Dresses", null },
                    { 26, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9478), "https://example.com/images/blouses.jpg", "Blouses", null },
                    { 27, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9479), "https://example.com/images/skirts.jpg", "Skirts", null },
                    { 28, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9480), "https://example.com/images/shorts.jpg", "Shorts", null },
                    { 29, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9481), "https://example.com/images/pajamas.jpg", "Pajamas", null },
                    { 30, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9482), "https://example.com/images/outerwear.jpg", "Outerwear", null },
                    { 31, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9482), "https://example.com/images/activewear.jpg", "Activewear", null },
                    { 32, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9483), "https://example.com/images/raincoats.jpg", "Raincoats", null },
                    { 33, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9484), "https://example.com/images/cardigans.jpg", "Cardigans", null },
                    { 34, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9485), "https://example.com/images/sweaters.jpg", "Sweaters", null },
                    { 35, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9486), "https://example.com/images/leggings.jpg", "Leggings", null },
                    { 36, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9487), "https://example.com/images/tracksuits.jpg", "Tracksuits", null },
                    { 37, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9488), "https://example.com/images/gloves.jpg", "Gloves", null },
                    { 38, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9489), "https://example.com/images/socks.jpg", "Socks", null },
                    { 39, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9490), "https://example.com/images/loungewear.jpg", "Loungewear", null },
                    { 40, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9491), "https://example.com/images/winter-wear.jpg", "Winter Wear", null }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 3, 128, 4, new DateTime(2024, 12, 18, 6, 15, 7, 540, DateTimeKind.Utc).AddTicks(5862), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Uniqlo Áo Polo Thoải Mái", 4317540.1677663763837148279184m, 3472532.087834561900000m, 383, "Kích thước: XS, S, L. Màu sắc: Hồng, Đen", null },
                    { 2, 9, 63, 2, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9491), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Chanel Blazer Sang Trọng", 4249101.3941340976831914811617m, 3253746.988758479900000m, 317, "Kích thước: XXL, M, L. Màu sắc: Đỏ, Xanh Navy", null },
                    { 3, 8, 122, 3, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9758), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Váy Liền Trẻ Trung", 1542972.8012491716865181121245m, 1235455.032252657650000m, 172, "Kích thước: XXL, M, XS. Màu sắc: Hồng, Đen", null },
                    { 4, 2, 166, 1, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9804), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Chanel Đầm Dạ Hội Thời Thượng", 6268605.1326935572281826221395m, 4266169.712323220300000m, 366, "Kích thước: XS, M, XXL. Màu sắc: Trắng, Xám", null },
                    { 5, 8, 174, 5, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9884), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Zara Áo Sơ Mi Sang Trọng", 1901457.8470746726750222208254m, 1449368.826112093100000m, 492, "Kích thước: XL, XS, XXL. Màu sắc: Đen, Đỏ", null },
                    { 6, 2, 107, 1, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9918), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Khoác Sang Trọng", 4099751.8960911480454810607437m, 3372508.906288231550000m, 384, "Kích thước: S, XL, L. Màu sắc: Xanh Navy, Đen", null },
                    { 7, 1, 175, 3, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9952), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Zara Áo Len Trẻ Trung", 4010737.3215647084024703344013m, 2870464.897388885450000m, 432, "Kích thước: XL, M, L. Màu sắc: Xanh Navy, Xám", null },
                    { 8, 10, 199, 5, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9997), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Polo Cổ Điển", 2992696.7649861321887641882635m, 2156402.528218709600000m, 446, "Kích thước: XL, L, XXL. Màu sắc: Trắng, Đỏ", null },
                    { 9, 2, 27, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(63), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Len Trẻ Trung", 1092101.2306532788650299176707m, 803702.299636655600000m, 268, "Kích thước: L, XS, XL. Màu sắc: Xám, Trắng", null },
                    { 10, 4, 44, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(96), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "H&M Váy Liền Năng Động", 4943751.4424434200129421515757m, 3685982.617037586200000m, 440, "Kích thước: XS, S, L. Màu sắc: Hồng, Đen", null },
                    { 11, 6, 172, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(127), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Uniqlo Quần Jean Trẻ Trung", 1068659.9139299684853544767365m, 761472.817347206750000m, 307, "Kích thước: M, XL, XS. Màu sắc: Đỏ, Hồng", null },
                    { 12, 5, 1, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(159), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Gucci Áo Len Thoải Mái", 3255904.7772465319872063862027m, 2301459.272405256650000m, 79, "Kích thước: XL, S, M. Màu sắc: Xám, Đen", null },
                    { 13, 10, 166, 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(214), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Nike Quần Short Thời Thượng", 997277.4361703295185702165949m, 768994.28662181450000m, 385, "Kích thước: XS, L, M. Màu sắc: Xám, Đen", null },
                    { 14, 6, 68, 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(245), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Đầm Dạ Hội Trẻ Trung", 372747.41027568518212171390925m, 316992.4519645778450000m, 429, "Kích thước: S, XL, XXL. Màu sắc: Đỏ, Xanh Navy", null },
                    { 15, 4, 59, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(275), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp thể thao", "Gucci Quần Jogger Hiện Đại", 7074228.3290921235583361128774m, 4877517.25075403300000m, 56, "Kích thước: L, M, XXL. Màu sắc: Đen, Xám", null },
                    { 16, 10, 36, 4, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(330), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Adidas Blazer Trẻ Trung", 784532.68372604097330970454073m, 586730.972947517150000m, 165, "Kích thước: S, XS, L. Màu sắc: Đỏ, Hồng", null },
                    { 17, 3, 189, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(363), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Louis Vuitton Quần Jean Cổ Điển", 1198904.0924325564956349760679m, 1084946.242769626550000m, 449, "Kích thước: L, M, XS. Màu sắc: Trắng, Đen", null },
                    { 18, 10, 66, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(392), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Áo Khoác Cổ Điển", 6304326.3959406708964663122849m, 4266290.145198302600000m, 329, "Kích thước: M, XXL, L. Màu sắc: Trắng, Đỏ", null },
                    { 19, 9, 25, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(423), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "Chanel Quần Jogger Cổ Điển", 4598506.2255113322019640095810m, 3330611.519677071800000m, 370, "Kích thước: XL, XS, L. Màu sắc: Đỏ, Xám", null },
                    { 20, 4, 152, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(480), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Áo Khoác Trẻ Trung", 978464.3605380117292226398625m, 883845.047708187350000m, 42, "Kích thước: S, XXL, M. Màu sắc: Xám, Đỏ", null },
                    { 21, 10, 162, 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(510), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "H&M Quần Jean Thời Thượng", 1069327.4298663932400751630284m, 795166.643102134550000m, 246, "Kích thước: XL, M, XXL. Màu sắc: Xám, Trắng", null },
                    { 22, 8, 33, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(541), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp thể thao", "H&M Áo Thun Cổ Điển", 917615.7204802892507552228166m, 720129.311055243050000m, 446, "Kích thước: L, M, XL. Màu sắc: Xanh Navy, Xám", null },
                    { 23, 4, 0, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(572), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Áo Thun Thời Thượng", 301086.67025311246868883627760m, 254970.5112473631800000m, 373, "Kích thước: L, M, S. Màu sắc: Hồng, Đỏ", null },
                    { 24, 8, 80, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(619), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Gucci Váy Liền Năng Động", 2956600.4271001891905546899541m, 2040984.682768751450000m, 191, "Kích thước: L, XS, M. Màu sắc: Đỏ, Hồng", null },
                    { 25, 8, 129, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(652), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Adidas Áo Thun Thoải Mái", 4928961.6545509136668521144708m, 3316849.179361780100000m, 406, "Kích thước: XXL, XS, S. Màu sắc: Hồng, Đỏ", null },
                    { 26, 8, 55, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(684), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Thun Sang Trọng", 4600142.7111277739118364815854m, 3724410.820225333100000m, 198, "Kích thước: S, XL, XXL. Màu sắc: Đen, Đỏ", null },
                    { 27, 4, 152, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(763), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "H&M Blazer Sang Trọng", 1878532.1653974841833733699272m, 1442721.632135711900000m, 315, "Kích thước: XL, XXL, L. Màu sắc: Xanh Navy, Đỏ", null },
                    { 28, 1, 18, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(796), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp dạo phố", "Zara Đầm Dạ Hội Cổ Điển", 2431177.1567275791331879541160m, 1918475.927493043550000m, 162, "Kích thước: S, M, L. Màu sắc: Trắng, Xanh Navy", null },
                    { 29, 7, 130, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(827), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "Louis Vuitton Quần Short Sang Trọng", 1617023.3271486585529413629040m, 1273249.753574466200000m, 183, "Kích thước: L, XL, XS. Màu sắc: Hồng, Xanh Navy", null },
                    { 30, 4, 59, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(857), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Chanel Áo Khoác Hiện Đại", 3301565.7043471868468300742194m, 2861971.198974434750000m, 358, "Kích thước: L, XS, XL. Màu sắc: Xám, Hồng", null },
                    { 31, 9, 45, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(922), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Áo Polo Trẻ Trung", 6672472.8397202778963557720698m, 4452801.841732236800000m, 218, "Kích thước: S, XL, M. Màu sắc: Xanh Navy, Xám", null },
                    { 32, 9, 99, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(953), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Gucci Áo Thun Hiện Đại", 905303.6765483437787032252735m, 634626.120112405250000m, 275, "Kích thước: XL, S, M. Màu sắc: Xanh Navy, Đỏ", null },
                    { 33, 8, 137, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(982), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "H&M Váy Liền Hiện Đại", 4556736.8710029830180338747728m, 3825063.444498872900000m, 289, "Kích thước: XL, XS, XXL. Màu sắc: Hồng, Xám", null },
                    { 34, 3, 76, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1014), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Polo Hiện Đại", 744039.87058539231835067919603m, 628854.566486909900000m, 350, "Kích thước: L, XL, XXL. Màu sắc: Hồng, Đỏ", null },
                    { 35, 8, 150, 4, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1072), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "Zara Quần Jean Hiện Đại", 4578648.6397906352465644063503m, 3342462.339061484600000m, 455, "Kích thước: L, S, M. Màu sắc: Đen, Hồng", null },
                    { 36, 7, 95, 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1101), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Khoác Sang Trọng", 5158791.5866741921187183724295m, 3748376.301881741150000m, 326, "Kích thước: L, S, M. Màu sắc: Xanh Navy, Hồng", null },
                    { 37, 10, 93, 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1131), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "H&M Blazer Cổ Điển", 5038033.4572280875410234757769m, 3547653.012859077050000m, 225, "Kích thước: XL, L, XS. Màu sắc: Đen, Trắng", null },
                    { 38, 7, 150, 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1163), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp dạo phố", "Gucci Áo Thun Hiện Đại", 362544.46264997751232987696294m, 312872.773399382300000m, 123, "Kích thước: XXL, M, XL. Màu sắc: Đen, Đỏ", null },
                    { 39, 7, 40, 4, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1217), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Đầm Dạ Hội Năng Động", 1196512.4429549296307098470621m, 1038506.211189429350000m, 323, "Kích thước: L, S, M. Màu sắc: Đỏ, Xám", null },
                    { 40, 7, 153, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1247), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Chanel Đầm Dạ Hội Năng Động", 5336527.3183058546613547607936m, 4828502.911545121550000m, 12, "Kích thước: S, XXL, M. Màu sắc: Đen, Đỏ", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

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
                name: "IX_BannerDetails_BannerId",
                table: "BannerDetails",
                column: "BannerId");

            migrationBuilder.CreateIndex(
                name: "IX_BannerDetails_ProductId",
                table: "BannerDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponConditions_CouponId",
                table: "CouponConditions",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_ProductId",
                table: "Favorites",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ProductId",
                table: "Feedbacks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsDetails_NewsId",
                table: "NewsDetails",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsDetails_ProductId",
                table: "NewsDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CouponId",
                table: "OrderDetails",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CouponId",
                table: "Orders",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

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
                name: "BannerDetails");

            migrationBuilder.DropTable(
                name: "CouponConditions");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "NewsDetails");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
