using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class addvariantforproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductVariantValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OldPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariantValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariantValues_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Variants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VariantValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VariantId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VariantValues_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "74378 Mayert Mission, East Alvaberg, Mauritania", "58f33fa7-a7d8-4541-abc4-43077fb894bf", new DateTime(2024, 11, 17, 11, 1, 3, 835, DateTimeKind.Utc).AddTicks(7711), "America.Hoeger39@gmail.com", "America", "Hoeger", "AMERICA.HOEGER39@GMAIL.COM", "AMERICA_HOEGER", "AQAAAAIAAYagAAAAEGyX/uueOhzpn1HIp9fD3ohZGjzXMXyoj/UYk8XFWWFEA/bp+U/G1enQc6VUqdDBog==", "159-106-6129", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/412.jpg", "America_Hoeger" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "179 Batz Junctions, Monroeborough, Suriname", "22eb3d65-19dd-4ecf-a5d2-f724c08b0531", new DateTime(2024, 8, 28, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(2731), "Van.Goyette@yahoo.com", "Van", "Goyette", "VAN.GOYETTE@YAHOO.COM", "VAN67", "AQAAAAIAAYagAAAAEPnvCf640Cz7UHB9fdGzbtfyB7q6GsPK8LNOmXTa2wiDhhqC8YQvSf90n23mqClJdA==", "453-986-2588", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/291.jpg", "Van67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "891 Josianne Meadow, North Lon, Cocos (Keeling) Islands", "03ad9578-df1c-441e-9635-8ca8c77d13c0", new DateTime(2024, 4, 15, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(3082), "Watson_Sawayn91@yahoo.com", "Watson", "Sawayn", "WATSON_SAWAYN91@YAHOO.COM", "WATSON.SAWAYN76", "AQAAAAIAAYagAAAAEJys4pl5NMC2BQB0EodJDOpN+tA6gTyX055nq+0UTulU4FOR08VdZmcSDKCzo1DpuQ==", "017-039-2095", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1025.jpg", "Watson.Sawayn76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5248 Jess Curve, Torphyview, Barbados", "b5bbaa0b-b66c-4652-96dc-03b1755e025e", new DateTime(2024, 12, 29, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(3414), "Greg_Breitenberg@hotmail.com", "Greg", "Breitenberg", "GREG_BREITENBERG@HOTMAIL.COM", "GREG97", "AQAAAAIAAYagAAAAEMad3g2MrZmvhQWSA4pg/eWor2jalsRVhgwm8MWactMzpS3fyzJRwZQiMqzhLvgSpQ==", "420-103-1460", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/789.jpg", "Greg97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "552 Richard Fields, South Elzahaven, India", "689d77b5-83e1-4fba-8173-933f46034cfa", new DateTime(2024, 12, 11, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(3697), "Euna.Hilll22@hotmail.com", "Euna", "Hilll", "EUNA.HILLL22@HOTMAIL.COM", "EUNA72", "AQAAAAIAAYagAAAAEJsDg0Wg8gogvG+pY/nfkNloWo9AEUHp3FLkTDVv50B6DQF1gS4CLRGnDbwgfaPayQ==", "419-886-2337", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/868.jpg", "Euna72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4815 Kuphal Crest, Patsyport, French Southern Territories", "0325efd9-6424-4acc-a600-3582b45f836b", new DateTime(2024, 11, 16, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(5052), "Jonatan_Langosh32@yahoo.com", "Jonatan", "Langosh", "JONATAN_LANGOSH32@YAHOO.COM", "JONATAN69", "AQAAAAIAAYagAAAAEDzeWnFLRPXq4Q8aTAnGLMiZyLA7Z7fzooc2vmXL8gzNFMlNBqqq0CsjmIEMR3bDsw==", "091-393-9381", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/460.jpg", "Jonatan69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "34465 MacGyver Shore, North Virgie, Greece", "5bf109cf-d9ff-4954-aa28-1837add8b86b", new DateTime(2024, 10, 5, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(5430), "Alivia15@yahoo.com", "Alivia", "Kozey", "ALIVIA15@YAHOO.COM", "ALIVIA86", "AQAAAAIAAYagAAAAED1MwbJ3elDe/pVRiZAVkXxaJ12z8AU+fK/3xXI7K6fPNzzXEVFG3zB7peEw0A/Wwg==", "038-833-3428", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/335.jpg", "Alivia86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "388 Alphonso Valley, Goyettebury, Chile", "f76c173e-1222-4df4-a9b9-f967aa4e1e8f", new DateTime(2024, 3, 19, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(5749), "Ophelia.Cummings@gmail.com", "Ophelia", "Cummings", "OPHELIA.CUMMINGS@GMAIL.COM", "OPHELIA_CUMMINGS36", "AQAAAAIAAYagAAAAECCDb8vCqZTWEj8rIDoYk/SNQUtoVU83b8H8hVbRSJFNNrflnwv/AuSNC4bCsL/aIg==", "186-778-3564", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/527.jpg", "Ophelia_Cummings36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "298 Pamela View, New Jewelfurt, United Arab Emirates", "ba7110e1-add8-4c32-afaf-7576fb1da911", new DateTime(2024, 11, 5, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(6006), "Okey_Spencer36@yahoo.com", "Okey", "Spencer", "OKEY_SPENCER36@YAHOO.COM", "OKEY25", "AQAAAAIAAYagAAAAEFgukEZY2kPwQzTjXQJ7Kh3n6z1UiKRTw5ND7LTzGLr4NbiPon0EVekHAEtJHuLhoQ==", "920-422-6403", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/571.jpg", "Okey25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4319 O'Reilly Manors, West Dangelo, Argentina", "4b71a0aa-8571-4f96-8676-c566cde22176", new DateTime(2024, 7, 18, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(6284), "Hubert_Gerhold91@yahoo.com", "Hubert", "Gerhold", "HUBERT_GERHOLD91@YAHOO.COM", "HUBERT.GERHOLD29", "AQAAAAIAAYagAAAAEBtbAehefkHmCHtmt5jo2fBOJC/0lj1ZKmcrSGC4VOyG8w5GuSzcyYPxn857JhIaIA==", "560-710-7441", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/586.jpg", "Hubert.Gerhold29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1057 Abernathy Court, Juniusmouth, Panama", "327c6250-8624-4218-8256-bb28ca098396", new DateTime(2024, 10, 14, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(6519), "Tony.Fahey@yahoo.com", "Tony", "Fahey", "TONY.FAHEY@YAHOO.COM", "TONY_FAHEY", "AQAAAAIAAYagAAAAEDm6ou8eX2s+Z/G/LvA1HBidlnM0HqwnK2i7u5YYzeJAQ00pyaxAosaqjWl4kDReQQ==", "031-296-4568", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1127.jpg", "Tony_Fahey" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "08567 Enid Stravenue, South Lorenton, Russian Federation", "b124d6c8-7de5-442c-bc58-bcd4c30bc570", new DateTime(2024, 4, 17, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(6799), "Ian12@yahoo.com", "Ian", "Nolan", "IAN12@YAHOO.COM", "IAN_NOLAN48", "AQAAAAIAAYagAAAAEMfoiCPnsbnrSvwzJ6wyrbUqMWuYhKZb2FdQO9dfRDru28GN5QOAyXs6CHDCYNfz8A==", "470-609-6289", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/737.jpg", "Ian_Nolan48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "058 Harrison Brooks, West Rylee, French Polynesia", "aff2e763-f9c1-4840-9738-c569b5dc33ff", new DateTime(2024, 6, 16, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(7050), "Jakob14@gmail.com", "Jakob", "Murray", "JAKOB14@GMAIL.COM", "JAKOB65", "AQAAAAIAAYagAAAAELj3lT9IB3tHUKpOXg9GSc0yg0N2UGWONzvVL50cg79hn0JKdjyvEOKzSvplLGzVxg==", "031-888-3799", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1096.jpg", "Jakob65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "39925 Michaela Inlet, Busterport, Tokelau", "fa1a2055-1aec-4281-bc1b-5ea80245f00a", new DateTime(2024, 2, 19, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(7342), "Della.Flatley@hotmail.com", "Della", "Flatley", "DELLA.FLATLEY@HOTMAIL.COM", "DELLA_FLATLEY54", "AQAAAAIAAYagAAAAEL71e4emWIlFwp0iUfcxQX7Tie9SNN0GS6nNN1JANfUih2LycXOCeL8oaT2a8h4ufQ==", "160-808-5647", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/387.jpg", "Della_Flatley54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6216 Mann Radial, East Treport, Peru", "256fdc31-fe10-41ce-ba0f-9b760fe753f2", new DateTime(2024, 7, 17, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(7617), "Heloise6@gmail.com", "Heloise", "Heidenreich", "HELOISE6@GMAIL.COM", "HELOISE_HEIDENREICH10", "AQAAAAIAAYagAAAAELXIL0vuWF9woan/fSvT2WZo8gqM2n4nZ1IJoiXz5ZeRYV2Ri8ZOaI1NBWQ3TvHZCA==", "547-910-9305", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1248.jpg", "Heloise_Heidenreich10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "23439 Rippin Turnpike, Murphyport, Suriname", "4798be86-2fc6-484c-9770-8b6dfd414beb", new DateTime(2024, 10, 7, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(7858), "Johanna_Jerde@yahoo.com", "Johanna", "Jerde", "JOHANNA_JERDE@YAHOO.COM", "JOHANNA5", "AQAAAAIAAYagAAAAEJrkbOH3b3fDudiKHg+aJuNvD3v1HZNuxKHoiI4BA/y1jY1lDLtW4QlB1j24D7maBw==", "164-233-5894", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1046.jpg", "Johanna5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "084 Salvador Walks, West Lethashire, Palau", "dae67923-466c-4091-8bb3-8d7f57d19f3c", new DateTime(2024, 3, 5, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(8108), "Noemy32@yahoo.com", "Noemy", "Borer", "NOEMY32@YAHOO.COM", "NOEMY_BORER36", "AQAAAAIAAYagAAAAEAPkbizQq6AVJ3ESDRa310nUMIMGwS7dOPOey0aoQr01VTCYg0w6HDMsS6ppb/mMXw==", "174-136-3489", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/67.jpg", "Noemy_Borer36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "876 Upton Heights, Schneidertown, San Marino", "80bc0676-4039-4a51-a808-11b22a4aa2d3", new DateTime(2024, 10, 21, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(8380), "Torrance_Boyle@yahoo.com", "Torrance", "Boyle", "TORRANCE_BOYLE@YAHOO.COM", "TORRANCE.BOYLE15", "AQAAAAIAAYagAAAAEDZBcv3NWsTwtojwuXPcoEuoacYTtoXhI4vNVOQgkzf0bgi4eU/tnfpZDqMr2xOe7w==", "624-709-7376", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/311.jpg", "Torrance.Boyle15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "89293 Dameon Oval, East Murlton, Northern Mariana Islands", "b23b0f2a-4881-4595-bc85-8157acc8cb37", new DateTime(2024, 5, 26, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(8688), "Lon80@yahoo.com", "Lon", "Cummerata", "LON80@YAHOO.COM", "LON.CUMMERATA67", "AQAAAAIAAYagAAAAEFN26nPjgpRSu2n2qV4CDh6Mnvoe7CWZ86DB5irEI9OusDTji9R7+zkXcidK2AuK5A==", "459-726-0107", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/436.jpg", "Lon.Cummerata67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "413 Braun Flat, Schowalterfurt, Mauritania", "7d4064a4-fd0c-446b-b873-09a25a5247e3", new DateTime(2024, 7, 3, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(8913), "Edwardo.Kozey@hotmail.com", "Edwardo", "Kozey", "EDWARDO.KOZEY@HOTMAIL.COM", "EDWARDO87", "AQAAAAIAAYagAAAAEJzC1w8dzhOofgDwyZHnUQDOfW+jBI9UjJ7xSKYGh+PzejCF77k5+wiqA4DE6DLaww==", "323-911-8132", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1226.jpg", "Edwardo87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "95505 Marks Route, Lake Fleta, Cayman Islands", "b227dd2a-bd28-4b25-bf81-a9645da71db7", new DateTime(2024, 9, 30, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(9168), "Abigail_Koss@gmail.com", "Abigail", "Koss", "ABIGAIL_KOSS@GMAIL.COM", "ABIGAIL_KOSS93", "AQAAAAIAAYagAAAAELEHSRt5WvQ50ZVhb0bqM5Iw6q54NHGSo1AH9RpJ5UZStUaz9GDzLVVtpogR+3Eh7Q==", "363-593-9316", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/607.jpg", "Abigail_Koss93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "169 Hayes Lake, Turnerton, Japan", "8ac3aa37-db07-44ed-b2ea-2def3c45e4a6", new DateTime(2024, 3, 9, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(9450), "Madyson.Wyman19@gmail.com", "Madyson", "Wyman", "MADYSON.WYMAN19@GMAIL.COM", "MADYSON_WYMAN70", "AQAAAAIAAYagAAAAEKUjcqhqTNzR+yvKwNH2aCML0KzBWARGbZPoxBKk2llDPNNYfLPRmkGUbONLP7j30A==", "780-117-3534", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/176.jpg", "Madyson_Wyman70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3249 Witting Circle, Corneliusburgh, Vanuatu", "55b1760e-a2f7-447f-b8cc-bb6e1d5552ac", new DateTime(2024, 11, 25, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(9704), "Braeden51@hotmail.com", "Braeden", "Hilll", "BRAEDEN51@HOTMAIL.COM", "BRAEDEN34", "AQAAAAIAAYagAAAAELQNOmgdJLzwUidg44lCg1JIu6FezElSjMc0ZXcbNmjp9K/iZ1RFhQyfRWU1H+s8Yw==", "639-826-2947", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/315.jpg", "Braeden34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8851 Stephon Fork, Port Juliafort, Honduras", "77450636-6659-4d62-af4a-6e38fe2ae193", new DateTime(2024, 9, 22, 11, 1, 3, 837, DateTimeKind.Utc).AddTicks(9985), "Johnson97@yahoo.com", "Johnson", "Brekke", "JOHNSON97@YAHOO.COM", "JOHNSON.BREKKE54", "AQAAAAIAAYagAAAAEAVD+azjeM3zID0wt1KGYeyQhEu1Q4cKTx/TIfZVU4PR/OkuEIkEaml0G62t4R9m0w==", "558-766-6005", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/247.jpg", "Johnson.Brekke54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "892 Harvey Pines, East Ritastad, Republic of Korea", "bcece5cf-1351-4835-83a9-a31bdb8d4bb2", new DateTime(2024, 5, 25, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(279), "Rosario.Morissette20@yahoo.com", "Rosario", "Morissette", "ROSARIO.MORISSETTE20@YAHOO.COM", "ROSARIO.MORISSETTE42", "AQAAAAIAAYagAAAAEDCuAtusCS/t6KlQJwakxJSKNKcwwQwMk4JxPya+BnQbzfgdELWWQcchoIHqFsjp2A==", "301-516-0692", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/694.jpg", "Rosario.Morissette42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "66652 Torphy Ridge, New Cullen, Germany", "6100813f-5cc1-41ba-90a9-bcc4898b430f", new DateTime(2024, 10, 8, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(534), "Hosea.Kunze29@gmail.com", "Hosea", "Kunze", "HOSEA.KUNZE29@GMAIL.COM", "HOSEA_KUNZE88", "AQAAAAIAAYagAAAAEKyDBddZI+74KjE1yHNAWvYvclMGqfPwSgl3TpuVkonxW7weY+xsdYKUo4+d5wn2xg==", "266-101-6562", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1036.jpg", "Hosea_Kunze88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6986 Georgiana Plains, Verniceville, Angola", "261edace-8481-49c0-a7ac-7b8e6636ba82", new DateTime(2024, 12, 14, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(798), "Keira41@hotmail.com", "Keira", "Hane", "KEIRA41@HOTMAIL.COM", "KEIRA_HANE76", "AQAAAAIAAYagAAAAEArgrXXXPxYxKj6Enb1T2Ai+ZAJ4ddtbHqvjr5O89kvrPftyx519GP0Ltj1WUUH3vQ==", "936-316-8631", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/853.jpg", "Keira_Hane76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "31893 Arlie Haven, Masonshire, British Indian Ocean Territory (Chagos Archipelago)", "9455e84f-6c48-4ebd-bb5f-4d4466734b54", new DateTime(2024, 8, 11, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(1064), "Scotty_Bartoletti@gmail.com", "Scotty", "Bartoletti", "SCOTTY_BARTOLETTI@GMAIL.COM", "SCOTTY_BARTOLETTI58", "AQAAAAIAAYagAAAAEKDP6e+gzoghvSfGEgLTntEERFlVmbqz+cjQM8p/dOEYqUjHVyJ5VPLSav6jpZjxNg==", "395-578-7221", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/893.jpg", "Scotty_Bartoletti58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2399 Antonette Loaf, Gunnermouth, Malta", "2bed5da4-3ab4-4070-a522-68ceaaf30fff", new DateTime(2024, 5, 9, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(1327), "Cicero_Trantow@gmail.com", "Cicero", "Trantow", "CICERO_TRANTOW@GMAIL.COM", "CICERO.TRANTOW", "AQAAAAIAAYagAAAAENcXFg1BFQngVcpD01n7An74b3mrhfCYltdp+Kg+LNOE6boLtIbk/O7kQ6l8DnxxLg==", "998-497-3517", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/182.jpg", "Cicero.Trantow" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "829 Aniyah Stream, South Henryburgh, Angola", "e85472a7-b909-4e0d-8ac6-f6508728a976", new DateTime(2024, 11, 2, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(1582), "Wilburn_Erdman@gmail.com", "Wilburn", "Erdman", "WILBURN_ERDMAN@GMAIL.COM", "WILBURN96", "AQAAAAIAAYagAAAAEGQaMj8mNkjeUIaB/f3VaapVRwuuenmFVU39+N7tvDH0sS3xQ+f7NMVhJYr5/AnxCw==", "260-789-4277", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/368.jpg", "Wilburn96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "15410 Little Groves, New Theresabury, Syrian Arab Republic", "6e359777-9c41-4cd2-8d48-5d7b2b180bdb", new DateTime(2024, 9, 9, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(1856), "Herman87@gmail.com", "Herman", "Ritchie", "HERMAN87@GMAIL.COM", "HERMAN.RITCHIE61", "AQAAAAIAAYagAAAAENiOU8c9V37J2MWzn/hKxxys4nrxLD513s167UYbAd/Az9CcfU21RFkQoQR32thuoQ==", "795-027-0287", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1133.jpg", "Herman.Ritchie61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "990 Earnest Divide, Williamsonland, Dominica", "4cc3ab55-8331-47e9-af48-a90dbf28bc82", new DateTime(2024, 8, 31, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(2088), "Rhea.Moen51@hotmail.com", "Rhea", "Moen", "RHEA.MOEN51@HOTMAIL.COM", "RHEA.MOEN13", "AQAAAAIAAYagAAAAEP03U51lVu1hQGKzMhxzLtE0N6WogNRlyAFoPGbQUMusd7jKlE+lZaNCpnNEtOeIwA==", "008-975-2505", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1205.jpg", "Rhea.Moen13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "088 Kuphal Orchard, Lake Vadaberg, Cyprus", "0dea20f0-3614-456c-8c50-367ac46ca73a", new DateTime(2024, 11, 11, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(2363), "Melba64@hotmail.com", "Melba", "Homenick", "MELBA64@HOTMAIL.COM", "MELBA35", "AQAAAAIAAYagAAAAEJoSwZlkjnxfAayDl9ErTJJJ7DJtqrTW02sECqLVEFxc/n5QvMVcfEcHqO7BjySM3A==", "895-631-9940", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/360.jpg", "Melba35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "02968 Maria Lane, Keaganstad, Mauritania", "5b15c52b-f2bc-4844-a2ca-c160aa33a6b7", new DateTime(2024, 2, 15, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(2585), "Rosina_Crona20@hotmail.com", "Rosina", "Crona", "ROSINA_CRONA20@HOTMAIL.COM", "ROSINA_CRONA22", "AQAAAAIAAYagAAAAEEmlne46QZwXHCVVjy08BuUifKqJsd8CmxfV6mj56jd23F2KKG5C/YlQbh9Emnrr9A==", "795-743-0766", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/920.jpg", "Rosina_Crona22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "135 Schaden Crescent, South Eleanore, Belgium", "7d3a06f4-30fd-48aa-ad57-f1a74979acdf", new DateTime(2024, 6, 22, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(2833), "Trudie7@gmail.com", "Trudie", "Pagac", "TRUDIE7@GMAIL.COM", "TRUDIE.PAGAC", "AQAAAAIAAYagAAAAEEKb7DaFroDkDUef+10T1cv8QLxITHWYwI++q9p3QE9G+xQYDqBYvaHw75fY7KXShQ==", "594-401-5051", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/253.jpg", "Trudie.Pagac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "727 Schultz Walks, North Cristinaport, Falkland Islands (Malvinas)", "7d9571ac-6a44-4c13-90df-91fef66e91ba", new DateTime(2024, 4, 9, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(3064), "Carolanne_Mante@gmail.com", "Carolanne", "Mante", "CAROLANNE_MANTE@GMAIL.COM", "CAROLANNE5", "AQAAAAIAAYagAAAAECLpT/k//RIPqZhhMMF4E/VShRtwtYCzbIPM4Eu4OdxX34l1mm1cu+IuqhF2Lh6/3A==", "713-969-9287", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/885.jpg", "Carolanne5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "81964 Mraz Row, West Friedrichmouth, Belize", "c82a8186-5ce0-4fe4-963d-f827e53a2020", new DateTime(2024, 4, 8, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(3358), "Herminio_Kulas@hotmail.com", "Herminio", "Kulas", "HERMINIO_KULAS@HOTMAIL.COM", "HERMINIO10", "AQAAAAIAAYagAAAAEDHveM0AMYWBe3wjUGQDq29/LnVfO++DjpHZ5AvmtNv7Jl3FIARFnGwYg0MBrIvvIQ==", "465-710-6462", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/566.jpg", "Herminio10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9620 Homenick Fall, West Schuyler, United States Minor Outlying Islands", "665491ae-597e-4cb3-95ac-01247870743f", new DateTime(2024, 10, 10, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(3576), "Tyson.Larson@yahoo.com", "Tyson", "Larson", "TYSON.LARSON@YAHOO.COM", "TYSON_LARSON", "AQAAAAIAAYagAAAAEFQ4c0UhnLskJ3kvrdElDucf9xA/gMPG5JKNsCUQBn6vKDccvPxTnSdHLacsDTKczw==", "157-621-7011", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/284.jpg", "Tyson_Larson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9538 Bergstrom Estate, Donaldshire, American Samoa", "ba12ace5-e914-4296-a8a0-640ee4c5fcab", new DateTime(2024, 12, 17, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(3834), "Thalia_Casper11@yahoo.com", "Thalia", "Casper", "THALIA_CASPER11@YAHOO.COM", "THALIA86", "AQAAAAIAAYagAAAAECIrKegJaLVvzKOQRQS2VuA+BfQ2b+Q+g4MzRYVCz2E5BKLiF4U+iXuwRwsy/xb4Lw==", "982-895-8509", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1223.jpg", "Thalia86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6836 Jovani Walks, Efrenfort, Uzbekistan", "42f2d0dc-a680-47e8-9359-17a21718151d", new DateTime(2024, 8, 6, 11, 1, 3, 838, DateTimeKind.Utc).AddTicks(4085), "Scottie.Johnston41@gmail.com", "Scottie", "Johnston", "SCOTTIE.JOHNSTON41@GMAIL.COM", "SCOTTIE.JOHNSTON", "AQAAAAIAAYagAAAAEIzZ3I4Skwl475OBNg5LlfwEedKcX3iBkq+SconwSzK2cITm/oj8ElbcycjFVnzeJA==", "812-215-3122", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/782.jpg", "Scottie.Johnston" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 5, 667, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantValues_ProductId",
                table: "ProductVariantValues",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_VariantValues_VariantId",
                table: "VariantValues",
                column: "VariantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariantValues");

            migrationBuilder.DropTable(
                name: "VariantValues");

            migrationBuilder.DropTable(
                name: "Variants");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "08281 Durgan Island, West Catherineton, Bulgaria", "4bac2a0b-cc9a-4e0a-aa76-b89aa5dc8df1", new DateTime(2024, 10, 31, 3, 17, 11, 988, DateTimeKind.Utc).AddTicks(5524), "Abigail_Gerlach13@hotmail.com", "Abigail", "Gerlach", "ABIGAIL_GERLACH13@HOTMAIL.COM", "ABIGAIL.GERLACH", "AQAAAAIAAYagAAAAEJjGjBO4UapTKk9r71U+eOv/4lMYqDwTlye3pZUd0dLzFbVFSb6hupMHINt6kTULJA==", "267-592-2346", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/738.jpg", "Abigail.Gerlach" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6729 Oswald Villages, East Terrill, Niger", "66cc5aae-5aec-456c-9631-f6a34b9d3b89", new DateTime(2024, 4, 24, 3, 17, 11, 989, DateTimeKind.Utc).AddTicks(9754), "Reggie6@yahoo.com", "Reggie", "Block", "REGGIE6@YAHOO.COM", "REGGIE.BLOCK49", "AQAAAAIAAYagAAAAECUxszt1MRui12jo0474lKbyLco9w0PtIbST3ucqXOFIP68o+BEDuk/HSENJeBjpWA==", "507-883-2443", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/717.jpg", "Reggie.Block49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "161 Quinten Court, New Hesterfurt, Kazakhstan", "62d24228-cd98-4c09-99d9-295db850b985", new DateTime(2024, 9, 10, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(139), "Tyrell_Keeling@hotmail.com", "Tyrell", "Keeling", "TYRELL_KEELING@HOTMAIL.COM", "TYRELL16", "AQAAAAIAAYagAAAAEF1hTvXITRO0rtsMvlsTARMn+B+58jxmymoSsxBWYqnDlfP82gMxsAKpZU7xzmAimA==", "868-254-2239", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/487.jpg", "Tyrell16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "284 Hintz Mission, Lake Jefferey, Palestinian Territory", "82849778-3df5-4d99-991b-aec65b74428c", new DateTime(2024, 7, 16, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(380), "Shyann.Pfeffer77@hotmail.com", "Shyann", "Pfeffer", "SHYANN.PFEFFER77@HOTMAIL.COM", "SHYANN_PFEFFER", "AQAAAAIAAYagAAAAEMLCjg/Pq8vYi/RQjBJS+O6T/Ux9BC3S0OoXNQgxatKYwo1bvNNnM0dw9AqLX3b4YQ==", "959-827-4190", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/942.jpg", "Shyann_Pfeffer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "026 Eunice Flat, Danialton, Poland", "2162e5f4-1439-4cf5-83c0-54cedc0cee34", new DateTime(2024, 7, 23, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(608), "Vada98@hotmail.com", "Vada", "Johnson", "VADA98@HOTMAIL.COM", "VADA95", "AQAAAAIAAYagAAAAEBqZV1X8Co7STtLFypDAdR6fu+E3Ras241VhQZJBMRzOYFBwpMuiZQl7nGwB1q9aYg==", "266-514-4137", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1179.jpg", "Vada95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "323 Winston Row, Estaport, Samoa", "9000e48e-ad8b-406a-9e01-abbb9479adad", new DateTime(2024, 8, 1, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(975), "Magdalena81@hotmail.com", "Magdalena", "Roberts", "MAGDALENA81@HOTMAIL.COM", "MAGDALENA.ROBERTS26", "AQAAAAIAAYagAAAAEC9cPnBl0B5K1bpNZhyzabxRz39slJHqFrAKuLqS+msxs+Pt29eKnhSlIKqYZlZ0Gg==", "059-068-6590", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/563.jpg", "Magdalena.Roberts26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8946 Feil Ramp, Lake Toneyshire, Mali", "66ae86d7-faaf-43ff-8495-7acb4423b1f8", new DateTime(2024, 9, 27, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(1274), "Porter_Gusikowski83@hotmail.com", "Porter", "Gusikowski", "PORTER_GUSIKOWSKI83@HOTMAIL.COM", "PORTER.GUSIKOWSKI89", "AQAAAAIAAYagAAAAEJvSFvKy520YLSDykRj/vjVw3oHqfCLokc+WJT6ZhsXlJw26lXck+6rTGFebLYCnbw==", "946-803-5500", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/47.jpg", "Porter.Gusikowski89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "886 Glover Squares, West Lenora, Bermuda", "37d6f0a7-2483-4185-999c-aa8f9414ee5e", new DateTime(2024, 9, 30, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(1505), "Nicholas.Friesen1@gmail.com", "Nicholas", "Friesen", "NICHOLAS.FRIESEN1@GMAIL.COM", "NICHOLAS.FRIESEN50", "AQAAAAIAAYagAAAAEI1zKobT4nSCNKg4XkvBOmYiJSyJV+UXxi9v+gNOI/BJ9qipu6jipCVc0VHkFlsyAQ==", "197-386-8937", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1189.jpg", "Nicholas.Friesen50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "61406 Diana Prairie, Boehmstad, Gibraltar", "c257e733-6d38-4c29-a39a-2061b96a940f", new DateTime(2024, 9, 14, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(1786), "Kitty22@yahoo.com", "Kitty", "Oberbrunner", "KITTY22@YAHOO.COM", "KITTY58", "AQAAAAIAAYagAAAAEDZh+oroVfA6nM5LEgw1Z3wkPFIhslJB691n14+F5Y7bYPAFRlvMTLDBZICmSypb4g==", "454-138-3940", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/647.jpg", "Kitty58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4975 Beatty Glens, Jayneborough, Cambodia", "6b6b2f8a-25fe-4499-82af-15d0e41bce4f", new DateTime(2024, 6, 8, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(2005), "Trenton64@hotmail.com", "Trenton", "Kutch", "TRENTON64@HOTMAIL.COM", "TRENTON3", "AQAAAAIAAYagAAAAEDi8g8fn4jTzP0t/TNCk8qCmz+udUMBbAP5lz25l/pVYYIZS6yj+DCAmBK9d/fD7FA==", "203-801-5430", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/977.jpg", "Trenton3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "91308 Crooks Rest, Port Ayanaside, Lithuania", "97093595-dab8-44d5-8de1-3c9d87131660", new DateTime(2024, 4, 5, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(2249), "Brisa.Sanford84@hotmail.com", "Brisa", "Sanford", "BRISA.SANFORD84@HOTMAIL.COM", "BRISA_SANFORD", "AQAAAAIAAYagAAAAEHLrYDYl+vzHIsfBKfyl32Ly5xD9j3KfcSVDv9SLdZ5biGMzOqMgP0nNejj6GHn36w==", "122-808-2575", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/143.jpg", "Brisa_Sanford" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1463 Baumbach Pines, Tyrelburgh, Brazil", "22b37c5d-5d98-490a-87a8-cc8185f26f60", new DateTime(2024, 12, 8, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(2466), "Arjun_Douglas@yahoo.com", "Arjun", "Douglas", "ARJUN_DOUGLAS@YAHOO.COM", "ARJUN_DOUGLAS14", "AQAAAAIAAYagAAAAEGogfVJsRuCi7ZTM9lf+ilSKqB9bfrdj3owQSmOcptM4XrKbNNy/gaKhvKnlpvUJeg==", "062-183-3432", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/543.jpg", "Arjun_Douglas14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5592 Timmy Pine, Brendenburgh, Senegal", "a31f1f92-9ea9-4164-ae93-cffd279dc0df", new DateTime(2024, 11, 26, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(2720), "Jeanne77@yahoo.com", "Jeanne", "Connelly", "JEANNE77@YAHOO.COM", "JEANNE.CONNELLY77", "AQAAAAIAAYagAAAAEBO6w5WLRXKFtzxufcIW4iUtbAca1BMmwkM2g320SlpibMjqs7KNvZ3m7u+DTVYsGQ==", "502-372-6674", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/87.jpg", "Jeanne.Connelly77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "04173 Kelli Spring, Stromantown, Guyana", "ea8b98f6-dcea-47e8-bb66-222c1c8050c3", new DateTime(2024, 9, 2, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(2939), "Garnett.Kunze@yahoo.com", "Garnett", "Kunze", "GARNETT.KUNZE@YAHOO.COM", "GARNETT.KUNZE90", "AQAAAAIAAYagAAAAELENG85ISwawpoSlP1Fe2R6RsfobwxmndiEMBxS3QBJztDY+dtEpnTNWsLAIsloKGg==", "685-495-8824", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/284.jpg", "Garnett.Kunze90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8074 Albina Brooks, Bertrandton, United Arab Emirates", "4675f64e-43ea-4270-afc4-0088e38f2541", new DateTime(2024, 1, 16, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(3182), "Kristofer_Metz63@hotmail.com", "Kristofer", "Metz", "KRISTOFER_METZ63@HOTMAIL.COM", "KRISTOFER.METZ", "AQAAAAIAAYagAAAAEM3mUUHyPOAXPdHNAHtMiNthIPbzmRauAd7dlM6HV92Ab4LN/Oy0krbHhQnjr63C8A==", "918-458-1067", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/915.jpg", "Kristofer.Metz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8432 Beahan Walks, New Lucyland, Kuwait", "6307da6a-6cfe-411c-abd5-c3b931ed0b3f", new DateTime(2024, 12, 17, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(3412), "Margaret33@hotmail.com", "Margaret", "Zulauf", "MARGARET33@HOTMAIL.COM", "MARGARET_ZULAUF47", "AQAAAAIAAYagAAAAEADET595vf+fZC3Rywn3qlQDcdiVUk3nxWQhDNWxzq8GnhyFYUNjUkczw3dofdf80g==", "697-323-6676", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/784.jpg", "Margaret_Zulauf47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "70168 Waylon Course, Reichertside, Burundi", "4f3feaf2-1828-43c7-80ff-fdf970dc1882", new DateTime(2024, 6, 10, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(3636), "Aida63@yahoo.com", "Aida", "Wisoky", "AIDA63@YAHOO.COM", "AIDA16", "AQAAAAIAAYagAAAAEERk7K83i8uFoaPT0ljMJUI4DEbfsnuzZLx4JLDQ6wIfC5PG+VpikuiJpHihHhln+g==", "651-745-3442", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/455.jpg", "Aida16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "17072 Rylee Inlet, Juanitafort, Bhutan", "588e535b-9e6c-4d32-99b7-adc99abefb97", new DateTime(2024, 5, 25, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(3850), "Alf77@yahoo.com", "Alf", "Friesen", "ALF77@YAHOO.COM", "ALF_FRIESEN17", "AQAAAAIAAYagAAAAEOC0NbMIyfZ1ILEqwkYuSGk7XOy0f4a5qNVFqq1gXNMQdaF/qnBm/Fx9qqWuNIjdKg==", "114-698-9008", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/905.jpg", "Alf_Friesen17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "686 Houston Hill, Lake Randall, South Georgia and the South Sandwich Islands", "4a8ff03d-1460-4e9c-ae7a-65e54bfac5b8", new DateTime(2024, 1, 16, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(4089), "Emery_Graham@gmail.com", "Emery", "Graham", "EMERY_GRAHAM@GMAIL.COM", "EMERY_GRAHAM12", "AQAAAAIAAYagAAAAENBSQGuSu0ZQhLa6YMeMfjJcZ6HjZ3JDrernf/a1xMjv1SI+PIsMepgg9nkUSUSdaQ==", "747-994-1272", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/983.jpg", "Emery_Graham12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "83225 Daniella Plains, Colestad, Togo", "78af8ed7-8ebc-495e-ae55-6350a62316f6", new DateTime(2024, 3, 18, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(4308), "Charles_Weimann83@hotmail.com", "Charles", "Weimann", "CHARLES_WEIMANN83@HOTMAIL.COM", "CHARLES.WEIMANN", "AQAAAAIAAYagAAAAELzTC6/47PBYBkTwlmourLPNST1D16pRGWhyR3w2UuUBgUyJCaqy9cmi+8GAu4AnsQ==", "854-325-0356", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/816.jpg", "Charles.Weimann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9462 Rosenbaum Lakes, Treverhaven, Argentina", "51109907-721f-4dd5-a013-e0aedf53fb11", new DateTime(2024, 12, 27, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(4548), "Gayle28@hotmail.com", "Gayle", "Maggio", "GAYLE28@HOTMAIL.COM", "GAYLE62", "AQAAAAIAAYagAAAAEJ4eUAnZxrxW2HiBJ+mSONc+eVQ3LHF+5h0DxYuZjnn4htCRJCYlWQ11/RWFbua8BQ==", "580-641-1673", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1054.jpg", "Gayle62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5198 Kunde Parks, Lake Raphael, Portugal", "2bce2df7-5d5e-470b-99a0-1f5c0e4e7440", new DateTime(2024, 7, 3, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(4781), "Margaret.Bogisich@hotmail.com", "Margaret", "Bogisich", "MARGARET.BOGISICH@HOTMAIL.COM", "MARGARET.BOGISICH", "AQAAAAIAAYagAAAAEBOU2maNua1Fo8zqJFL9XdUfitfBzI0RPTufJIixkN1QviYTDuJvJBmcyqBvCTYHKA==", "647-006-2011", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/165.jpg", "Margaret.Bogisich" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3368 Austyn Village, North Hymanland, Ghana", "7b5fe783-33db-4e35-b11e-9c187b5cfa32", new DateTime(2024, 6, 10, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(5029), "Anna_Hettinger@hotmail.com", "Anna", "Hettinger", "ANNA_HETTINGER@HOTMAIL.COM", "ANNA3", "AQAAAAIAAYagAAAAEM3DEJHVgEFecd3+X+07PRXXCDoPjGWn3QROfKYkD2fn/+9GQ8J3LOu2oarAjjSeBA==", "637-993-7232", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1022.jpg", "Anna3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "552 Della Estate, Port Rosaliaville, Botswana", "2d7dd6c8-b37f-4ec9-815e-5d4eddd8a7e4", new DateTime(2024, 6, 6, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(5239), "Rebecca_Jones@gmail.com", "Rebecca", "Jones", "REBECCA_JONES@GMAIL.COM", "REBECCA36", "AQAAAAIAAYagAAAAEHqiByK3RPxa1e4Y5RsI7b2o9CPQTE9UkAkpXWQGWPx+kFP3m8O25vgX3jBJkHOC8w==", "846-506-9279", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/658.jpg", "Rebecca36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2638 Doyle Track, Franeckiport, Democratic People's Republic of Korea", "25f0c4d0-ebd0-458a-8b28-3b5da5824ae7", new DateTime(2025, 1, 1, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(5469), "Chandler_Paucek89@hotmail.com", "Chandler", "Paucek", "CHANDLER_PAUCEK89@HOTMAIL.COM", "CHANDLER93", "AQAAAAIAAYagAAAAEKEN7tO7tdt1qAH/qeAg3FMz4cdtWpmVB+6aLI+xwCj6KdI/Zo8ly8T47sEn6ESt2w==", "983-932-7212", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/134.jpg", "Chandler93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1013 Doyle Rue, Port Caraside, Belize", "3fbc1120-5c59-4d3d-8fb0-89ca982ed628", new DateTime(2024, 5, 31, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(5763), "Delaney57@hotmail.com", "Delaney", "Emmerich", "DELANEY57@HOTMAIL.COM", "DELANEY_EMMERICH", "AQAAAAIAAYagAAAAEJWqaBaagfkvo+/vGiM0Vgm2R/NlnS6wRBOIx/zfUkBREvxEEEPhXaJ40H9OZBF3qQ==", "083-816-3659", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/134.jpg", "Delaney_Emmerich" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "712 Bednar Ridges, Cyrilside, Iraq", "7c8b4b3b-7f7d-44c6-b25d-fa8ee67010d3", new DateTime(2024, 8, 19, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(5978), "Destiney_Heller46@yahoo.com", "Destiney", "Heller", "DESTINEY_HELLER46@YAHOO.COM", "DESTINEY.HELLER", "AQAAAAIAAYagAAAAEBeN20ijBEqdjZh6wEEMFojcGFbbItlImWhby48fgK7OyJlHvJ7c5K03gf2GMrZMVA==", "586-415-2331", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1236.jpg", "Destiney.Heller" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "81583 Willy Ways, Briellefurt, Belize", "cd936abf-cb2b-440d-bf95-c4b0ae9b4b5f", new DateTime(2024, 9, 11, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(6216), "Sydnee48@hotmail.com", "Sydnee", "Wilderman", "SYDNEE48@HOTMAIL.COM", "SYDNEE_WILDERMAN", "AQAAAAIAAYagAAAAEF547fseIahRlDV08uU1HsFWijH7kC0A3PrdKGOHCp3aaXhZf+Vlgpl0iyDUh5smXw==", "957-674-9004", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1104.jpg", "Sydnee_Wilderman" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "42106 Laisha Unions, Skilesburgh, Liberia", "c4777414-225b-4254-b160-ffb252b7fd00", new DateTime(2024, 2, 18, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(6414), "Kailey36@gmail.com", "Kailey", "Jacobi", "KAILEY36@GMAIL.COM", "KAILEY64", "AQAAAAIAAYagAAAAEFEhpTt3KJ7oc6TJF1JlmUjd+MkGPLuuCMqGLxBbVtuaIbzxlGQ2XrjgBJ4XIyaJPw==", "773-648-1203", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1196.jpg", "Kailey64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "70486 Fritsch Meadows, North Nicklaus, Seychelles", "760fad5d-d44f-46dd-b933-d03175b55e81", new DateTime(2024, 3, 4, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(6646), "Jairo.Konopelski@gmail.com", "Jairo", "Konopelski", "JAIRO.KONOPELSKI@GMAIL.COM", "JAIRO13", "AQAAAAIAAYagAAAAEE9vAPc2zWgqkfbn53aqRBbnOrIOFqmY9guv2nkBBxpJT/WpzQWu4yfkANEygrExGA==", "030-295-2359", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/179.jpg", "Jairo13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3352 Foster Point, Lake Frank, Ecuador", "6c0e2cb2-bc9e-4ae2-ba3a-5c9e01fe5ce5", new DateTime(2024, 3, 1, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(6856), "Jeanne_Feil64@gmail.com", "Jeanne", "Feil", "JEANNE_FEIL64@GMAIL.COM", "JEANNE.FEIL", "AQAAAAIAAYagAAAAEMDSccPiFTdyl8oDp6DLQg3y6Aywbwkxz6UY5BS77Cqs641FOwZAu/NFW7iuQAUsiA==", "480-426-0322", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1134.jpg", "Jeanne.Feil" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "336 Fred Trail, South Trishaberg, Bahamas", "57c47f9a-852b-4270-ad51-eef1763f6e56", new DateTime(2024, 3, 10, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(7108), "Alene43@gmail.com", "Alene", "Osinski", "ALENE43@GMAIL.COM", "ALENE7", "AQAAAAIAAYagAAAAECR+oTL9V0lUS/tEX+H+AG+LbmV+QfnN/BaZ6bM/citvMogIcL71RtbB0i/8cVOAmw==", "366-761-8657", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/566.jpg", "Alene7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "24188 McGlynn Center, Bodetown, French Guiana", "6335fc71-451c-4d64-b494-e1f92dac82dc", new DateTime(2024, 2, 13, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(7309), "Amely.Kreiger@hotmail.com", "Amely", "Kreiger", "AMELY.KREIGER@HOTMAIL.COM", "AMELY.KREIGER93", "AQAAAAIAAYagAAAAEOuJ9BTLMIoT0STLT1R48FXWn4eRdKDrhQniUQFv9pJklenOIO7hYeZvj0s99A7fyw==", "344-482-2072", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/850.jpg", "Amely.Kreiger93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "95086 Sipes Valleys, Americostad, Fiji", "cbc13b0d-dce1-41a6-b52c-91d475c91ef9", new DateTime(2024, 12, 28, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(7543), "Gloria76@hotmail.com", "Gloria", "Hackett", "GLORIA76@HOTMAIL.COM", "GLORIA.HACKETT", "AQAAAAIAAYagAAAAEAl2StWHViHBTq1Yi7z/eEmf8ZQBum1UMOc89Ly4dwvAIZW9OrJM7N3GuUkOzatn9w==", "563-473-6355", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/190.jpg", "Gloria.Hackett" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1037 Donnell Fall, North Maiyastad, Chad", "4b80be15-889c-4d0e-b65c-b899609264d6", new DateTime(2024, 5, 2, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(7742), "Warren_Grady@hotmail.com", "Warren", "Grady", "WARREN_GRADY@HOTMAIL.COM", "WARREN_GRADY77", "AQAAAAIAAYagAAAAENvhkWgu3LwtznPE6MgH1DYNBzSAA2No6PNaWbNKyIUTFJg9l5hRRA1tmbtq16ftcA==", "982-532-9219", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/590.jpg", "Warren_Grady77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8341 Josefina Garden, Lake Cierra, Zimbabwe", "924d9f61-7458-4776-b4a5-da675ce12917", new DateTime(2024, 7, 14, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(7981), "Roosevelt.Bernhard90@hotmail.com", "Roosevelt", "Bernhard", "ROOSEVELT.BERNHARD90@HOTMAIL.COM", "ROOSEVELT.BERNHARD", "AQAAAAIAAYagAAAAEI4gx3/HssDJO+9md2oQKRFYp1VgJiZMlc+zgxqorYEnVk45PJnVDCDy8K/J72j06w==", "132-442-3711", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/187.jpg", "Roosevelt.Bernhard" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6938 Gerlach Brook, Haleybury, Lesotho", "04c2da5c-a47b-4747-939a-bf9c9c12df23", new DateTime(2024, 6, 7, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(8198), "Archibald43@gmail.com", "Archibald", "Lesch", "ARCHIBALD43@GMAIL.COM", "ARCHIBALD33", "AQAAAAIAAYagAAAAEBH85aKRcqUNoMguoHbQq9MwDWmGwJ2mtfcxQbqB52G8FhteF5l27VYp+pWZPnbpRA==", "147-718-6521", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/350.jpg", "Archibald33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "06407 Nova Dale, Jenningsmouth, Honduras", "bab62c00-3eeb-4fa8-ade1-71ca20ea0658", new DateTime(2024, 10, 31, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(8453), "Timmothy_Wiegand37@yahoo.com", "Timmothy", "Wiegand", "TIMMOTHY_WIEGAND37@YAHOO.COM", "TIMMOTHY30", "AQAAAAIAAYagAAAAEOpu1gRVBVcNYPnWJXeU8F4l4rSEH4BUdL5pzeNK1NLWScG5Nl6EH78q+EM1hugLRg==", "976-464-6260", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/482.jpg", "Timmothy30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "52601 Irving Mall, North Maximoton, Finland", "600ab8c2-d4b4-40bf-aa02-58810f981e8d", new DateTime(2024, 4, 8, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(8661), "Dejah26@hotmail.com", "Dejah", "McDermott", "DEJAH26@HOTMAIL.COM", "DEJAH.MCDERMOTT", "AQAAAAIAAYagAAAAEBMDYUgq1io9StEbZE8O7IYHibRWznRKKVBvV3FTqhrmrLq7dLCcg58p/kmIBRTj5g==", "537-187-8319", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1011.jpg", "Dejah.McDermott" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "84065 Missouri Turnpike, Margaritaburgh, Sao Tome and Principe", "3d163945-24d6-4c75-b03d-175daf79027e", new DateTime(2024, 5, 8, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(8890), "Tiffany4@yahoo.com", "Tiffany", "Conroy", "TIFFANY4@YAHOO.COM", "TIFFANY69", "AQAAAAIAAYagAAAAEKcn0LBxUdrlKexT3Ri++e094Cizf1RikzrDVo31kllGEN03TwFx0ipL2U2l6bmVng==", "680-775-5651", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/214.jpg", "Tiffany69" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8343));
        }
    }
}
