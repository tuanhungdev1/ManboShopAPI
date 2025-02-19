using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManboShopAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatecoupontable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "CouponConditions");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CurrentUsages",
                table: "Coupons");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Coupons",
                newName: "UsageCount");

            migrationBuilder.RenameColumn(
                name: "MaxUsages",
                table: "Coupons",
                newName: "DiscountType");

            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "Coupons",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "VariantValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "VariantValues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "VariantValueImages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "VariantValueImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Variants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Variants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductVariantValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductVariantValues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductImages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductAttributeValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductAttributeValues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "OrderDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "OrderDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "OrderAddresses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "OrderAddresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "NewsDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "NewsDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "News",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "News",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Feedbacks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "FeedbackLikes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FeedbackLikes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Favorites",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Favorites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Coupons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Coupons",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountValue",
                table: "Coupons",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Coupons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Coupons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Coupons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MaxUsage",
                table: "Coupons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaximumDiscountAmount",
                table: "Coupons",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MinimumAmount",
                table: "Coupons",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Carts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Carts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "CartItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CartItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Brands",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Brands",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Banners",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Banners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "BannerDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BannerDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Attributes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Attributes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Addresses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Addresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Coupons_CouponId",
                table: "Orders",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Coupons_CouponId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "VariantValues");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "VariantValues");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "VariantValueImages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "VariantValueImages");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductVariantValues");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductVariantValues");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductAttributeValues");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductAttributeValues");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "OrderAddresses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "OrderAddresses");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "NewsDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "NewsDetails");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "News");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "News");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "FeedbackLikes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FeedbackLikes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Favorites");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Favorites");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "DiscountValue",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "MaxUsage",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "MaximumDiscountAmount",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "MinimumAmount",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "BannerDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BannerDetails");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "UsageCount",
                table: "Coupons",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Coupons",
                newName: "ExpirationDate");

            migrationBuilder.RenameColumn(
                name: "DiscountType",
                table: "Coupons",
                newName: "MaxUsages");

            migrationBuilder.AddColumn<int>(
                name: "CouponId",
                table: "OrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentUsages",
                table: "Coupons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CouponConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponId = table.Column<int>(type: "int", nullable: false),
                    Attribute = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountAmount = table.Column<int>(type: "int", nullable: false),
                    Operator = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[,]
                {
                    { 1, 0, "63388 Edwina Prairie, Lake Aleen, Myanmar", "b61ff116-11c8-44b3-a8be-2d37f6f38435", new DateTime(2024, 8, 24, 23, 24, 8, 117, DateTimeKind.Utc).AddTicks(2167), "Lois.Raynor@hotmail.com", true, "Lois", "Raynor", false, null, "LOIS.RAYNOR@HOTMAIL.COM", "LOIS68", "AQAAAAIAAYagAAAAEHTjRyIK/e51AVaLEehUgikooYOFRCIC14kx3OaCkxvTsJipmvhSmApbelchXyQWbw==", "199-187-4029", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/344.jpg", null, null, null, false, null, "Lois68", null, null },
                    { 2, 0, "32039 Connelly Lodge, West Bettyehaven, Wallis and Futuna", "4fc86652-9ade-4ca4-8362-e57a3d95a614", new DateTime(2024, 4, 25, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(3885), "Monserrat.Bins27@gmail.com", true, "Monserrat", "Bins", false, null, "MONSERRAT.BINS27@GMAIL.COM", "MONSERRAT.BINS9", "AQAAAAIAAYagAAAAEJ6lBh+pzPq51qNB38PvGWT5QkQt68sUBSRWw7bz93RgvWKaGXJlNjLQrdUiCO6/uw==", "621-588-7415", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1038.jpg", null, null, null, false, null, "Monserrat.Bins9", null, null },
                    { 3, 0, "9886 Jamal Common, Boehmchester, Uruguay", "23179e8b-e807-427c-afaa-0a7f26ae61b2", new DateTime(2024, 7, 13, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(5273), "Cortney.Bergstrom15@yahoo.com", true, "Cortney", "Bergstrom", false, null, "CORTNEY.BERGSTROM15@YAHOO.COM", "CORTNEY_BERGSTROM26", "AQAAAAIAAYagAAAAEKL6VLuUSwBH9zQ8YG2NZbyJ+lGe0rP8lTw5FDP1ywz4mzNTI5bhOsjjBE3Rr1sTYg==", "467-196-6702", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/447.jpg", null, null, null, false, null, "Cortney_Bergstrom26", null, null },
                    { 4, 0, "8374 Ondricka Junctions, North Owenmouth, Lesotho", "04e1d9ba-793c-447f-8dd2-bc4b28223f15", new DateTime(2024, 11, 8, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(5535), "Marshall.Rath@hotmail.com", true, "Marshall", "Rath", false, null, "MARSHALL.RATH@HOTMAIL.COM", "MARSHALL_RATH", "AQAAAAIAAYagAAAAEMEhgytQbzLQAyiRQamSsG4dtR53kNfAb5j69senBtozmnV6ZrZtw2XDTNXmLOXSpQ==", "985-319-7221", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/589.jpg", null, null, null, false, null, "Marshall_Rath", null, null },
                    { 5, 0, "901 Gaston Path, Lockmanfurt, Solomon Islands", "f25bf3a8-96bd-4e9c-978a-917c6967605e", new DateTime(2024, 4, 30, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(5801), "Jay2@hotmail.com", true, "Jay", "Pfeffer", false, null, "JAY2@HOTMAIL.COM", "JAY.PFEFFER", "AQAAAAIAAYagAAAAEHHQExk3LEyig2r56qfR9LEG3xls6kz7HSMZpS4TrnybNaL0k0pGryMWwJ5MWk1bDw==", "205-389-3169", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/931.jpg", null, null, null, false, null, "Jay.Pfeffer", null, null },
                    { 6, 0, "062 Alexzander Knoll, Rhiannonbury, Saudi Arabia", "43862110-ec86-4bca-af21-3bc6657d388a", new DateTime(2024, 8, 24, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(6023), "Mckenna.Kuhic58@yahoo.com", true, "Mckenna", "Kuhic", false, null, "MCKENNA.KUHIC58@YAHOO.COM", "MCKENNA_KUHIC", "AQAAAAIAAYagAAAAEBMXhjMnxp+hyqlyHPat6jgE6dPYLa39G+1TBFNTkPgSWyg8TlW4qNRLvF2baMXHUw==", "469-798-4568", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/128.jpg", null, null, null, false, null, "Mckenna_Kuhic", null, null },
                    { 7, 0, "4268 Daniel Bypass, South Eileenport, Saudi Arabia", "8ff6b49b-107e-46f7-b7c7-83a5571f52ff", new DateTime(2024, 12, 26, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(6843), "Elna97@gmail.com", true, "Elna", "Herman", false, null, "ELNA97@GMAIL.COM", "ELNA_HERMAN", "AQAAAAIAAYagAAAAEN0cW73P75mJt3XgyXeQuZBgtiSy/zspSfwA/VQrT2IgsC+7No9B1iZkgd6SLD1n5A==", "217-170-8618", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/543.jpg", null, null, null, false, null, "Elna_Herman", null, null },
                    { 8, 0, "477 Elwyn Tunnel, Erdmanview, Wallis and Futuna", "d6ce30e3-52c9-44f6-a073-282a1267043f", new DateTime(2025, 1, 9, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(9750), "Magnus.Wiza@hotmail.com", true, "Magnus", "Wiza", false, null, "MAGNUS.WIZA@HOTMAIL.COM", "MAGNUS.WIZA", "AQAAAAIAAYagAAAAEHSfb6KJRHunvC9PZt2B/1bxLlI3iIvfuBWqY9aFhLa1pp4z5enqCO9RUnhv3mK8ug==", "236-253-7246", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1050.jpg", null, null, null, false, null, "Magnus.Wiza", null, null },
                    { 9, 0, "74639 Hansen Tunnel, Olsonmouth, Indonesia", "85ab85d4-5e22-4954-bb89-06f94233f088", new DateTime(2024, 11, 18, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(369), "Jonatan89@yahoo.com", true, "Jonatan", "Flatley", false, null, "JONATAN89@YAHOO.COM", "JONATAN61", "AQAAAAIAAYagAAAAEK7iHNfOOM0/qh6x5pJDYY0TysY11GSMV6hCWcbuO6yxed9XImp9v5hLEjCn5JetrA==", "339-955-2900", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/265.jpg", null, null, null, false, null, "Jonatan61", null, null },
                    { 10, 0, "062 Little Mount, Lueilwitzmouth, Fiji", "248f7f93-c8b2-43fe-b1c2-612fe1f0a2cd", new DateTime(2024, 9, 27, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(675), "Mohammad.McGlynn78@hotmail.com", true, "Mohammad", "McGlynn", false, null, "MOHAMMAD.MCGLYNN78@HOTMAIL.COM", "MOHAMMAD60", "AQAAAAIAAYagAAAAENMsWRjQX+vWTKExnphqx5D/8s2p7jh4sT/7pRl29bH5/Vy6Feylif1sVmu1+9em4w==", "357-688-9704", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1072.jpg", null, null, null, false, null, "Mohammad60", null, null },
                    { 11, 0, "6747 Sylvan Mill, Grahammouth, Algeria", "f7212f76-3246-4b8e-a70f-bb343495970a", new DateTime(2024, 12, 5, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(1025), "Lillie.Hyatt@yahoo.com", true, "Lillie", "Hyatt", false, null, "LILLIE.HYATT@YAHOO.COM", "LILLIE12", "AQAAAAIAAYagAAAAEPpFXN0Lpn+dzJTE1RoVlWDoPMr6e6R+TWjuOknsDCkrNiBBFuNlNeq97Lf1bKqnNQ==", "934-386-8248", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1228.jpg", null, null, null, false, null, "Lillie12", null, null },
                    { 12, 0, "88079 Lempi Route, Anjalishire, Madagascar", "e73cb373-b7f0-4bf8-9e1f-71a5fd8d4ca3", new DateTime(2024, 11, 16, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(1432), "David_Thiel@hotmail.com", true, "David", "Thiel", false, null, "DAVID_THIEL@HOTMAIL.COM", "DAVID_THIEL", "AQAAAAIAAYagAAAAEB10rA+ryXBPYfNVrVBTPw2EHoY/y3JgTJzaArTw0CZ/aioupUu1CNzNV9+u4Ysa9Q==", "097-672-5355", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1135.jpg", null, null, null, false, null, "David_Thiel", null, null },
                    { 13, 0, "49423 Kris Throughway, Larkinshire, Thailand", "3fa7e41b-4e50-4529-9f65-999302254d3a", new DateTime(2024, 5, 10, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(8752), "Jace5@hotmail.com", true, "Jace", "O'Kon", false, null, "JACE5@HOTMAIL.COM", "JACE.OKON", "AQAAAAIAAYagAAAAEP4k2uBzFs2QapoGN9hcekX/Q9D06kiZOEn0H4dnbFZGXetz10N4DmnNErZFdNMM5A==", "296-104-9454", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1063.jpg", null, null, null, false, null, "Jace.OKon", null, null },
                    { 14, 0, "7550 Luettgen Isle, South Ismaelbury, Democratic People's Republic of Korea", "223cdd70-fa38-4835-986b-780ef5f19a06", new DateTime(2024, 3, 27, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(9251), "Marcus_McCullough9@gmail.com", true, "Marcus", "McCullough", false, null, "MARCUS_MCCULLOUGH9@GMAIL.COM", "MARCUS_MCCULLOUGH", "AQAAAAIAAYagAAAAENVndRly6q9Rn7pqi1DWk62KvwK5vx4+9cuZZjwCFaVlSnJxxT618oWrRuyT0ACEmQ==", "647-080-1331", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1234.jpg", null, null, null, false, null, "Marcus_McCullough", null, null },
                    { 15, 0, "383 Israel Wall, New Floydland, Uruguay", "64687071-cbfe-49db-ac5a-85d61d0f14ea", new DateTime(2024, 7, 21, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(9703), "Emely_Cartwright87@gmail.com", true, "Emely", "Cartwright", false, null, "EMELY_CARTWRIGHT87@GMAIL.COM", "EMELY0", "AQAAAAIAAYagAAAAEEkS6i8OlZafXAC994J4LMTU4fZp0ayofIL539tpaxY7I/J16kdEVi7CyWddraDB0w==", "163-521-0137", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1216.jpg", null, null, null, false, null, "Emely0", null, null },
                    { 16, 0, "3117 Wintheiser Pine, Brakusview, Madagascar", "4ef1280e-ba4a-45ad-9844-2a35bc3e9dc6", new DateTime(2024, 2, 28, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(66), "Kenny47@gmail.com", true, "Kenny", "Weber", false, null, "KENNY47@GMAIL.COM", "KENNY73", "AQAAAAIAAYagAAAAEKbWsIGloGS+tDdI54kFfPApbRPI26oY7KITft5qusCAjTWktAtMPur4gxuFzj3EQg==", "950-775-0092", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/343.jpg", null, null, null, false, null, "Kenny73", null, null },
                    { 17, 0, "829 Christiansen Roads, South Morris, Slovakia (Slovak Republic)", "e7806253-602f-41a1-80be-792028693d74", new DateTime(2024, 7, 15, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(521), "Chelsie.Ankunding@yahoo.com", true, "Chelsie", "Ankunding", false, null, "CHELSIE.ANKUNDING@YAHOO.COM", "CHELSIE_ANKUNDING43", "AQAAAAIAAYagAAAAEDTkbl4gmvp3vQ77rdmjygjcAqs9nMcZojry172IMFr58qayCLbfiyYkcUxBxucugg==", "073-465-9158", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/109.jpg", null, null, null, false, null, "Chelsie_Ankunding43", null, null },
                    { 18, 0, "5435 Weber Fork, South Kaitlin, Pakistan", "67d6ef53-9a4d-42fb-a510-2a6123450430", new DateTime(2024, 8, 8, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(945), "Lamont97@yahoo.com", true, "Lamont", "Rosenbaum", false, null, "LAMONT97@YAHOO.COM", "LAMONT5", "AQAAAAIAAYagAAAAEIM9XXgAbOoPsA7GuI4CWUgJQQuiFd3OO7vW9OQUMoztBPAsAWxpwtQLCtcQoHk2ag==", "709-978-4774", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/349.jpg", null, null, null, false, null, "Lamont5", null, null },
                    { 19, 0, "1323 Gutkowski Summit, New Zettaton, Mozambique", "e876d279-b6d5-4c8a-a560-de26a06af955", new DateTime(2025, 1, 2, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(1420), "Carole20@hotmail.com", true, "Carole", "Schiller", false, null, "CAROLE20@HOTMAIL.COM", "CAROLE_SCHILLER85", "AQAAAAIAAYagAAAAEHuVZSuLXggDOs/oCzTvbuTJ3UB25M8mW2OU6vlXj1pj4HbMydDrJvfxu7W87KhLHA==", "210-311-3758", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/864.jpg", null, null, null, false, null, "Carole_Schiller85", null, null },
                    { 20, 0, "923 Kellie Highway, North Timothystad, Taiwan", "89a34a71-8b58-4621-91f6-1fc4a5e9b750", new DateTime(2024, 3, 17, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(1848), "Willy.Doyle@hotmail.com", true, "Willy", "Doyle", false, null, "WILLY.DOYLE@HOTMAIL.COM", "WILLY_DOYLE18", "AQAAAAIAAYagAAAAEDl3+FIaOLm5I2Yqcvi2GvhsMSa19gOMFUf5be6zoZ34oJTUym+cTrVzTp8qrpDSlQ==", "752-931-3926", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/822.jpg", null, null, null, false, null, "Willy_Doyle18", null, null },
                    { 21, 0, "350 Kutch Courts, Isabellebury, Guinea-Bissau", "98d17aa0-6b14-4a50-ab18-c75b6c44aafe", new DateTime(2024, 9, 28, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(2227), "Aiden.Wintheiser@gmail.com", true, "Aiden", "Wintheiser", false, null, "AIDEN.WINTHEISER@GMAIL.COM", "AIDEN_WINTHEISER20", "AQAAAAIAAYagAAAAEKvHojxRsbuGnrefA08Svgyf8zdD3w9jLEI3urUWU9JkWYfj8hppFXZToDV5a22LyQ==", "351-030-0840", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/603.jpg", null, null, null, false, null, "Aiden_Wintheiser20", null, null },
                    { 22, 0, "43285 Kiehn Tunnel, DuBuquechester, Sudan", "46f8224b-a4bd-4149-a88a-259d952b036c", new DateTime(2025, 1, 16, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(2662), "Beverly_Morissette77@yahoo.com", true, "Beverly", "Morissette", false, null, "BEVERLY_MORISSETTE77@YAHOO.COM", "BEVERLY.MORISSETTE", "AQAAAAIAAYagAAAAENzN5vB3ce2tEuWr3FwbUb9IF0pWrBzfoKcg8bQRcchY+umAHacgSnuG7StBCZRstw==", "001-206-4016", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1133.jpg", null, null, null, false, null, "Beverly.Morissette", null, null },
                    { 23, 0, "563 Cummerata Junction, Noemiehaven, Mexico", "98d0aa1f-26f0-4986-9ee1-5091284910e0", new DateTime(2024, 2, 9, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(3092), "Margarette77@gmail.com", true, "Margarette", "Greenholt", false, null, "MARGARETTE77@GMAIL.COM", "MARGARETTE96", "AQAAAAIAAYagAAAAEDgUrgvTULWFmabpKd51jk7V7q5e0v2nUUAW1vh1FmuZ937NgAvMLTi+D6BkMQ2YkA==", "042-147-5231", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/140.jpg", null, null, null, false, null, "Margarette96", null, null },
                    { 24, 0, "20431 Leannon Crossing, Port Augustafurt, Argentina", "8808fa1b-597d-459f-89cd-7d89d38af7a4", new DateTime(2024, 10, 29, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(3468), "Randy59@hotmail.com", true, "Randy", "Kuphal", false, null, "RANDY59@HOTMAIL.COM", "RANDY.KUPHAL48", "AQAAAAIAAYagAAAAEOXTUhm5N3PSWK0bmjb4bktbgVpYaqCRX2prziRy7DGqNgt5uKY0w8S+TYBtlPUstQ==", "577-838-1926", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/930.jpg", null, null, null, false, null, "Randy.Kuphal48", null, null },
                    { 25, 0, "45586 O'Keefe Manors, South Lisaland, Virgin Islands, British", "28ce02dd-ae19-425e-9a0a-426921750b0a", new DateTime(2024, 11, 14, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(3781), "Amaya.Runte@gmail.com", true, "Amaya", "Runte", false, null, "AMAYA.RUNTE@GMAIL.COM", "AMAYA.RUNTE", "AQAAAAIAAYagAAAAEPKSLQT6MqPx5nU/pvYndFLk6Od2uRRsO2Euj59q4cJGfSUXNoSEy98IqrmGaB4NzQ==", "221-771-1917", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/261.jpg", null, null, null, false, null, "Amaya.Runte", null, null },
                    { 26, 0, "094 Fay Shoal, Durwardberg, Pitcairn Islands", "4c408af1-2176-4dec-9593-71dd8de465d1", new DateTime(2024, 11, 17, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(4123), "Dennis61@yahoo.com", true, "Dennis", "Greenfelder", false, null, "DENNIS61@YAHOO.COM", "DENNIS_GREENFELDER27", "AQAAAAIAAYagAAAAEP47buGBxzrlRxqwEofvWbeJRAWsGJNnE8Sz6NU4iXDw6EJabEdqXLWCnCpI+fyXDw==", "862-781-2098", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/738.jpg", null, null, null, false, null, "Dennis_Greenfelder27", null, null },
                    { 27, 0, "0265 Daniel Isle, West Damonshire, Kiribati", "94d48ed3-f269-46b8-8915-384cef6be6cc", new DateTime(2024, 7, 10, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(4453), "Benton.Turner@yahoo.com", true, "Benton", "Turner", false, null, "BENTON.TURNER@YAHOO.COM", "BENTON.TURNER", "AQAAAAIAAYagAAAAEOcFtg/9Lj4zsL9M3EFdyDf1lbTx3pulGNMChrJrYCilAiBHiF3zgzmx7uaJNgHjTQ==", "027-453-4152", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/185.jpg", null, null, null, false, null, "Benton.Turner", null, null },
                    { 28, 0, "431 Wiza Freeway, North Rosellatown, Senegal", "aecb2f74-0de3-4c8e-b8cc-e41e7ee5ea1a", new DateTime(2024, 9, 20, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(5450), "Haskell_Lockman@gmail.com", true, "Haskell", "Lockman", false, null, "HASKELL_LOCKMAN@GMAIL.COM", "HASKELL89", "AQAAAAIAAYagAAAAEEdgOKwg6a2HbWKxox1qAsxXpN4pGaIIkMBy/TE7xEvq3KP+y6DB2vVx72Nl6gh9wA==", "881-925-9800", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/758.jpg", null, null, null, false, null, "Haskell89", null, null },
                    { 29, 0, "2578 Orn Meadows, Zoeymouth, Cape Verde", "d5043252-cc69-4a7b-a3a9-e01bb25a0a23", new DateTime(2024, 2, 29, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(5922), "Lennie_Klocko1@yahoo.com", true, "Lennie", "Klocko", false, null, "LENNIE_KLOCKO1@YAHOO.COM", "LENNIE53", "AQAAAAIAAYagAAAAEIHT4TnQg9oDllrOPmSP2gM3ljPYXVzES2e3mBLJZ1eHWoRtbcaGmLKy2eFzLXjE+Q==", "821-457-9624", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/901.jpg", null, null, null, false, null, "Lennie53", null, null },
                    { 30, 0, "534 Stark Haven, North Brycentown, Indonesia", "2deb1c7e-c7cc-4530-91ab-462d17c72120", new DateTime(2024, 6, 24, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(6234), "Nyasia.Kreiger17@hotmail.com", true, "Nyasia", "Kreiger", false, null, "NYASIA.KREIGER17@HOTMAIL.COM", "NYASIA.KREIGER", "AQAAAAIAAYagAAAAEDYpPDxGudWj5ZNChgg3TfUj+m1Pa4IeBwx53dKMXAwR72msWnvjX9afHXbwbJsSmQ==", "489-476-7332", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/47.jpg", null, null, null, false, null, "Nyasia.Kreiger", null, null },
                    { 31, 0, "771 Stoltenberg Road, Labadieberg, Lao People's Democratic Republic", "96f1d325-9fb1-4a4b-a704-80f2f1d8dc0a", new DateTime(2024, 3, 3, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(6563), "Jermey_Parisian@yahoo.com", true, "Jermey", "Parisian", false, null, "JERMEY_PARISIAN@YAHOO.COM", "JERMEY18", "AQAAAAIAAYagAAAAEFZ818OdrZFzRvHFL6wNB2LeI54GWZzPZQPOgfKaBtblbEBymXeCL4eJ6YI++euOZw==", "113-067-7732", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/856.jpg", null, null, null, false, null, "Jermey18", null, null },
                    { 32, 0, "7433 Dach Terrace, Port Marquisland, Greenland", "3cbbc18c-f507-482c-be54-cced2c2b2e73", new DateTime(2025, 1, 10, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(6845), "Alize_Stanton61@yahoo.com", true, "Alize", "Stanton", false, null, "ALIZE_STANTON61@YAHOO.COM", "ALIZE.STANTON52", "AQAAAAIAAYagAAAAEO7dILzFlVTVHMEvx1vvYWnu5ideJt0D73uVu/v4a3lqiK0uWZGtfLea//t8g7YNGg==", "769-178-0082", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/272.jpg", null, null, null, false, null, "Alize.Stanton52", null, null },
                    { 33, 0, "5858 Bradtke Common, Websterhaven, Iraq", "2887b07e-a035-447e-930a-88f7a50c4a09", new DateTime(2024, 9, 26, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(7129), "Justine.Rice96@hotmail.com", true, "Justine", "Rice", false, null, "JUSTINE.RICE96@HOTMAIL.COM", "JUSTINE.RICE50", "AQAAAAIAAYagAAAAEIRj/u57tNjCluHv2BRaSwEra/GLLP4B6NwEAM9ShmWBiOCIIjpZ6rlC9SQbXMzxYQ==", "808-605-6483", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/926.jpg", null, null, null, false, null, "Justine.Rice50", null, null },
                    { 34, 0, "427 Maddison Forks, Whiteborough, Wallis and Futuna", "9e93f030-362a-4636-a074-0daaf2d28b7d", new DateTime(2024, 3, 9, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(7403), "Kian.Torp19@gmail.com", true, "Kian", "Torp", false, null, "KIAN.TORP19@GMAIL.COM", "KIAN_TORP", "AQAAAAIAAYagAAAAEEjVr5Uegg/U8O8bOAIl42uFin+hIAFMTY1L/3Kj+fu7Pt3eiuFwoZLscqyYayi3bg==", "797-387-7742", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/905.jpg", null, null, null, false, null, "Kian_Torp", null, null },
                    { 35, 0, "7944 Lamont Plaza, South Nettieside, Mozambique", "1b478225-fd12-4f7c-adfa-4daec5c35233", new DateTime(2025, 1, 13, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(7719), "Una53@gmail.com", true, "Una", "Skiles", false, null, "UNA53@GMAIL.COM", "UNA.SKILES", "AQAAAAIAAYagAAAAECMosUbVVTuWw+hGtLdIixBzHUOMRlO1Mf2apJd8aKnNFMGu5jSf0bT/qpC2g+lQqQ==", "799-148-3861", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/739.jpg", null, null, null, false, null, "Una.Skiles", null, null },
                    { 36, 0, "4434 Fahey Mission, Padbergfurt, Norway", "81177012-6709-4c71-86c8-a4b5a2cf42c3", new DateTime(2024, 9, 4, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(8008), "Melvina38@yahoo.com", true, "Melvina", "Jaskolski", false, null, "MELVINA38@YAHOO.COM", "MELVINA.JASKOLSKI75", "AQAAAAIAAYagAAAAEMbX08JwEkeLwLsuD89/ErnyJ4X5Bi4YbNdJ8v/OWsZgWjOX2YVly5wCy6T1HRVPcw==", "491-550-8077", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/190.jpg", null, null, null, false, null, "Melvina.Jaskolski75", null, null },
                    { 37, 0, "188 Arlene Light, South Rainabury, Myanmar", "77af0fd8-fe11-4e04-b3cf-93e0b8f605ff", new DateTime(2025, 1, 15, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(8320), "Noemie26@hotmail.com", true, "Noemie", "Kerluke", false, null, "NOEMIE26@HOTMAIL.COM", "NOEMIE67", "AQAAAAIAAYagAAAAEOdoiRujV2G5JfUlONGoNSZCHsWWItaEHdPh7PsItMzWQdfSS/R16InjIees+Q0UjQ==", "302-388-9913", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/395.jpg", null, null, null, false, null, "Noemie67", null, null },
                    { 38, 0, "7405 Lillian Cape, Eulaliamouth, Norfolk Island", "82f377ca-4a80-4f9f-bd65-5d951ca3ebd6", new DateTime(2024, 5, 6, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(8613), "Toney_Bogisich65@yahoo.com", true, "Toney", "Bogisich", false, null, "TONEY_BOGISICH65@YAHOO.COM", "TONEY.BOGISICH22", "AQAAAAIAAYagAAAAEOvb/sfWu/Md7C6MkfWv07aTEv7HxtYNlIehlnN2VNjRn1tCfh5Is68frBsrxwGJ/g==", "395-950-5456", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/396.jpg", null, null, null, false, null, "Toney.Bogisich22", null, null },
                    { 39, 0, "42894 Pfeffer Courts, Alexzanderhaven, Switzerland", "0f152d6b-29c6-4b29-9ff1-50cdd8a5a17b", new DateTime(2024, 8, 25, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(8869), "Neil.Boyer8@yahoo.com", true, "Neil", "Boyer", false, null, "NEIL.BOYER8@YAHOO.COM", "NEIL79", "AQAAAAIAAYagAAAAEDEkVckK0Nm4qIEYmjkDC8RgrzReHB1naYlOWiq0ToluiCtU5bIUy7+4JHfeJAp+iw==", "974-419-7413", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1087.jpg", null, null, null, false, null, "Neil79", null, null },
                    { 40, 0, "544 Bogisich Stream, Ricehaven, Morocco", "21691769-258f-492a-b28f-6046effcc47e", new DateTime(2024, 5, 24, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(9458), "Sherman40@yahoo.com", true, "Sherman", "Botsford", false, null, "SHERMAN40@YAHOO.COM", "SHERMAN_BOTSFORD80", "AQAAAAIAAYagAAAAEHl1KN2y1V7AbVCdlQDNQOKpKxr0M6RCUR0jVBCQiK0Mq9vHVx+Pjyo/vpEGat/Q2A==", "509-905-6515", true, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/278.jpg", null, null, null, false, null, "Sherman_Botsford80", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CouponId",
                table: "OrderDetails",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponConditions_CouponId",
                table: "CouponConditions",
                column: "CouponId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Coupons_CouponId",
                table: "OrderDetails",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Coupons_CouponId",
                table: "Orders",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id");
        }
    }
}
