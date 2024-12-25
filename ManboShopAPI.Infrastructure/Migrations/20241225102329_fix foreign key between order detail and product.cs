using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixforeignkeybetweenorderdetailandproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_OrderId",
                table: "OrderDetails");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "915 Norval Roads, Justynstad, Sierra Leone", "e55113b0-5d42-4e6f-b969-db47a162eb5d", new DateTime(2024, 11, 12, 10, 23, 26, 569, DateTimeKind.Utc).AddTicks(7954), "Jamar40@gmail.com", "Jamar", "Schimmel", "JAMAR40@GMAIL.COM", "JAMAR_SCHIMMEL", "AQAAAAIAAYagAAAAEBm7zoc3p2B45DvHjg5cAZ1h8CBQSzf31zxkoyey33gL+xH6/hM26tbAuBrb5kRP4Q==", "940-119-7338", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/152.jpg", "Jamar_Schimmel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7516 Maye Roads, New Katrinaton, Italy", "eaba8c37-aec1-41b8-9852-c048825aed39", new DateTime(2024, 6, 4, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(351), "Christelle_Walsh90@hotmail.com", "Christelle", "Walsh", "CHRISTELLE_WALSH90@HOTMAIL.COM", "CHRISTELLE58", "AQAAAAIAAYagAAAAEEUw6KCscw8QQrfcVTk7SWtwr4YfsHkGipjY4RCupCSVvDZQI/qSePT9RCmh78oA8w==", "756-107-3262", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/704.jpg", "Christelle58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1352 Granville Meadows, New Lesly, Solomon Islands", "285da001-348a-4a40-a811-e2a6ca4e84c4", new DateTime(2024, 12, 12, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(798), "Shakira_Ondricka@gmail.com", "Shakira", "Ondricka", "SHAKIRA_ONDRICKA@GMAIL.COM", "SHAKIRA.ONDRICKA87", "AQAAAAIAAYagAAAAEJEo5k+sLVwNHcdvxvivI81zcJpH2HMAl12orGBxjGfRZtuUhUkFjkPx8+KnUBw/Lg==", "167-611-5190", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/327.jpg", "Shakira.Ondricka87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7265 Bogan Burg, West Krystinafort, Croatia", "80cda68c-d16b-4360-8460-035cfe48d24b", new DateTime(2024, 12, 10, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(1050), "Trinity13@gmail.com", "Trinity", "Fadel", "TRINITY13@GMAIL.COM", "TRINITY7", "AQAAAAIAAYagAAAAEI8+bkmDMudDd4F9mj6R0gDBa2W0s88ubCOHAvD8Sofp5rI7VQ7Pdfh7LTXk/T2J1A==", "569-959-0834", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1225.jpg", "Trinity7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "830 Rutherford Track, West Dominic, Netherlands Antilles", "fde0730a-e5f8-4494-84ca-c0f0b15ee68a", new DateTime(2024, 3, 27, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(1322), "Lucile.Goodwin@yahoo.com", "Lucile", "Goodwin", "LUCILE.GOODWIN@YAHOO.COM", "LUCILE_GOODWIN60", "AQAAAAIAAYagAAAAEGrvkAQZtr8BkfEOERObjABCQIMsHjW51Q0ZN5ZG970N3LyC/xGrt8VMn/r8ExabHg==", "127-341-0469", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/183.jpg", "Lucile_Goodwin60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3925 Hegmann Drives, Moenmouth, Central African Republic", "b203e8dc-487c-4c26-823b-cd0ebf2066d0", new DateTime(2024, 8, 23, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(1556), "Elisha.Romaguera@yahoo.com", "Elisha", "Romaguera", "ELISHA.ROMAGUERA@YAHOO.COM", "ELISHA_ROMAGUERA67", "AQAAAAIAAYagAAAAEN1UpCtlXDJmqiEMD0pBXjxp5MvLIiZD5V2WEy7GBMZxO067vg/JoG7AunQKF6+Uyw==", "733-696-4155", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/70.jpg", "Elisha_Romaguera67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5537 Kshlerin Vista, South Avery, Venezuela", "d2c321ef-abca-4181-994d-d2fd98442d45", new DateTime(2024, 4, 22, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(1813), "Lula_Gorczany74@hotmail.com", "Lula", "Gorczany", "LULA_GORCZANY74@HOTMAIL.COM", "LULA49", "AQAAAAIAAYagAAAAEPS1yGMQDCs4ffYa/2HWxN7HCQbgwtusl+ShyLDBWI2p3FdfipCCGVJZYD5+Q1S6Kg==", "806-494-7965", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/796.jpg", "Lula49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "075 Will Port, Ebbastad, Monaco", "8962f4d8-d1a5-4508-8551-5a45857a2c56", new DateTime(2024, 12, 24, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(2022), "Ciara_Farrell81@hotmail.com", "Ciara", "Farrell", "CIARA_FARRELL81@HOTMAIL.COM", "CIARA.FARRELL", "AQAAAAIAAYagAAAAEEKp/C5k23kLwyG0AxSEwttwlOilsflFx//tuYCglqcnuJTDkdjRxnx4My4aKQ7WMg==", "810-525-2260", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1118.jpg", "Ciara.Farrell" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3914 Lesley Groves, Hudsonville, Malawi", "d27f76bc-6a23-46ad-8aa7-620b37860cf1", new DateTime(2024, 8, 30, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(2288), "Juanita.Abshire@yahoo.com", "Juanita", "Abshire", "JUANITA.ABSHIRE@YAHOO.COM", "JUANITA_ABSHIRE64", "AQAAAAIAAYagAAAAEKGGh3KdVmlQ+LNtvrneEWxlCiis1ECYhx9r9UaoqouDDltGDYqrWp2h6L21NXhsFw==", "818-457-7857", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/452.jpg", "Juanita_Abshire64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8698 Kunde Orchard, Fatimamouth, Heard Island and McDonald Islands", "7535abb7-f4e3-4f79-8d3f-b603459f16b4", new DateTime(2024, 10, 24, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(2487), "Reyes.Raynor@hotmail.com", "Reyes", "Raynor", "REYES.RAYNOR@HOTMAIL.COM", "REYES.RAYNOR", "AQAAAAIAAYagAAAAEJ1INrOuB87JWQrOy/7I4dlVX3DTx/Q0VLSACsepveskyi+slatD6ywnGT+oMpkSkg==", "997-903-4124", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/556.jpg", "Reyes.Raynor" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1638 Renner Coves, Maggioland, San Marino", "e1385698-2e7e-48b9-97cf-a02cb7140011", new DateTime(2024, 7, 1, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(2734), "Kendall.Schuppe@hotmail.com", "Kendall", "Schuppe", "KENDALL.SCHUPPE@HOTMAIL.COM", "KENDALL_SCHUPPE88", "AQAAAAIAAYagAAAAEAf7MLbhzPl+AxnBbo1TBd+YW07F+GTKvzI7k8grtkm2wFcXY0Jk5Kc5/Uc/h7ETQA==", "045-667-3044", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/804.jpg", "Kendall_Schuppe88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2809 Sherwood Radial, Treutelbury, Algeria", "1584b6bf-7508-4a22-a963-7a558e9eb316", new DateTime(2024, 2, 17, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(2950), "Remington67@hotmail.com", "Remington", "Baumbach", "REMINGTON67@HOTMAIL.COM", "REMINGTON.BAUMBACH61", "AQAAAAIAAYagAAAAEK5DebgtMqQxMisAQq65Js9D14zyss7pxbYuFWiuTpE5CKm+M/ExwrFmDHmjAJ6JCA==", "400-427-4065", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/709.jpg", "Remington.Baumbach61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1274 Conn Radial, South Kaia, Denmark", "8e509491-fd8a-494c-8b42-fa301acca984", new DateTime(2024, 11, 25, 10, 23, 26, 575, DateTimeKind.Utc).AddTicks(9221), "Sasha32@yahoo.com", "Sasha", "O'Hara", "SASHA32@YAHOO.COM", "SASHA.OHARA", "AQAAAAIAAYagAAAAEDOP3g/jou4WWp8abO61cAwu9KlyZLDTw+DRDtl75dezBRFXVFBVJTgvOmBMbKdBdw==", "508-064-4963", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/418.jpg", "Sasha.OHara" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6955 Wava Trail, Lake Jessycaburgh, Antarctica (the territory South of 60 deg S)", "81f97553-5efa-4751-a141-efc69ebd3814", new DateTime(2024, 1, 17, 10, 23, 26, 575, DateTimeKind.Utc).AddTicks(9928), "Orville_Turner@hotmail.com", "Orville", "Turner", "ORVILLE_TURNER@HOTMAIL.COM", "ORVILLE_TURNER", "AQAAAAIAAYagAAAAECDzFtVaqPoEj0MkmQ/yrucWsrbezT7JghdxtLgJcuKwFz9/rEw2IkSCZAUGOoK7Gg==", "866-356-1435", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/923.jpg", "Orville_Turner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4447 Valentine Fall, Kerlukemouth, Chile", "4f202fc2-c152-4af7-ba23-75d69ae46226", new DateTime(2024, 3, 7, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(371), "Wava17@yahoo.com", "Wava", "Feest", "WAVA17@YAHOO.COM", "WAVA.FEEST", "AQAAAAIAAYagAAAAEJvCZiokMWiZHZl4loFB4wuzlbyerrEalYEg/F/+OHoIYwYJ6bxvH2jOlHNpPHsdgA==", "122-970-6246", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/108.jpg", "Wava.Feest" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6516 Conor Turnpike, Boscoton, Zimbabwe", "488d95ec-16ef-4d73-ac37-df8431d7bce6", new DateTime(2024, 2, 18, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(711), "Dannie_Nienow@yahoo.com", "Dannie", "Nienow", "DANNIE_NIENOW@YAHOO.COM", "DANNIE_NIENOW71", "AQAAAAIAAYagAAAAED7TUcb+xqRDg22lB75wb+mckMyVtt3foUkVvie8waGmhIvPTBUoyKu5Gkd41JWa2A==", "184-473-8782", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1138.jpg", "Dannie_Nienow71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "58726 Klocko Squares, New Virginiaton, Botswana", "722ec7c8-4cf1-42ab-8cd8-7e041b14a18e", new DateTime(2024, 4, 22, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(1189), "Hilma_Schmidt@hotmail.com", "Hilma", "Schmidt", "HILMA_SCHMIDT@HOTMAIL.COM", "HILMA_SCHMIDT", "AQAAAAIAAYagAAAAEEGsedk/WKbE1B4hR83a2dlgwYmA4/ml+QJB2cMlMkrzSzl0Ka3yJEvMdRmEMQWU2Q==", "788-902-3848", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/256.jpg", "Hilma_Schmidt" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "29330 Morgan Bypass, Paucekmouth, Antigua and Barbuda", "31aae358-2140-4175-8613-c3ede6b25d0f", new DateTime(2024, 6, 28, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(1592), "Bridgette14@yahoo.com", "Bridgette", "Hahn", "BRIDGETTE14@YAHOO.COM", "BRIDGETTE.HAHN39", "AQAAAAIAAYagAAAAEPUiN8o5oKm7LOQjJOK2LZGEdwWU7CQ4GRMgPGRsUWxb37DxI+VDYgLarW3kYSE4Zg==", "520-496-8194", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/398.jpg", "Bridgette.Hahn39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1177 Tony Forges, Bruceside, Luxembourg", "a14cbf9f-ab80-41c8-b092-3e4bb061a6a8", new DateTime(2024, 5, 4, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(2020), "Clemens81@gmail.com", "Clemens", "Medhurst", "CLEMENS81@GMAIL.COM", "CLEMENS.MEDHURST", "AQAAAAIAAYagAAAAEOaQY/Pg2B2LTbB6joT6qxp/AEOt6d32hjVmDL78a1xowm97y76DAkLcnT8MA85oLw==", "517-672-5566", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/210.jpg", "Clemens.Medhurst" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6793 Kirlin Junctions, Abshireview, Greenland", "377b1133-3f17-46c6-aaeb-21d33cc5dc62", new DateTime(2024, 1, 6, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(2401), "Mayra_Renner69@hotmail.com", "Mayra", "Renner", "MAYRA_RENNER69@HOTMAIL.COM", "MAYRA_RENNER54", "AQAAAAIAAYagAAAAEIX0IGfHO+P8vacGKBOQHnp8MPM+mwDDfuuGcE0+Asbb0ht5QhqQfTKBkQFAmLy7bQ==", "430-817-3935", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/834.jpg", "Mayra_Renner54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2181 Emie Key, West Donatobury, Cape Verde", "2add071a-eabf-4127-aa23-d14bcacc243b", new DateTime(2024, 7, 2, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(2742), "Everette2@yahoo.com", "Everette", "Hansen", "EVERETTE2@YAHOO.COM", "EVERETTE_HANSEN", "AQAAAAIAAYagAAAAEOjV8keGmEy9cgA8YGmb274T3yd/T3A9/kvVpAcWLF/TK+vuvTengKeo78Vojk6CCw==", "020-054-8583", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/613.jpg", "Everette_Hansen" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0409 Nova Curve, New Madysonchester, Cambodia", "77a5ee7f-6153-45e8-8e81-e961e8465ba5", new DateTime(2024, 6, 5, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(3152), "Noe.Toy@gmail.com", "Noe", "Toy", "NOE.TOY@GMAIL.COM", "NOE_TOY83", "AQAAAAIAAYagAAAAEEyuolzADRmiavbxFkGe7/xiU+bov22H70QCBL7Aq664Pn/rH/xHvPjeLg5FhcM5WQ==", "825-036-8160", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/695.jpg", "Noe_Toy83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "44765 Schaefer Ridges, West Marianne, Wallis and Futuna", "853f3c57-c94e-42f7-a5e6-023b3d03a6d9", new DateTime(2024, 7, 12, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(3516), "Joshua_Frami@hotmail.com", "Joshua", "Frami", "JOSHUA_FRAMI@HOTMAIL.COM", "JOSHUA41", "AQAAAAIAAYagAAAAEDlqHn/7XNDHCpLrkPYX71YldYIhtdRF7UL0ozOmogzx7ns7kR72A7H0WptJanzpLA==", "736-755-1856", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/881.jpg", "Joshua41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "565 Veum Trafficway, West Johnpaulborough, Suriname", "9be5880e-9aa7-48b8-8f88-52cfb646e912", new DateTime(2024, 6, 12, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(3998), "Karson_Considine81@yahoo.com", "Karson", "Considine", "KARSON_CONSIDINE81@YAHOO.COM", "KARSON_CONSIDINE", "AQAAAAIAAYagAAAAEJETRpdIzRyiNj7nSYliW1Qcu0URQ9ao0Ly/VEXLEGTlIZchZFebtANJRNQLVfS48A==", "473-838-7757", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/599.jpg", "Karson_Considine" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0825 Alta Mountains, North Orlandoport, Sierra Leone", "b44bff68-8497-4e81-a9ce-dca99000a243", new DateTime(2024, 8, 13, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(4349), "Jovany_Wiza54@yahoo.com", "Jovany", "Wiza", "JOVANY_WIZA54@YAHOO.COM", "JOVANY_WIZA", "AQAAAAIAAYagAAAAEOk8kIJsfIVgrXIhBmO1Sjh+ii/wi9W2ovRw0OUKNq/EDJ2xxlT1E1IaoE3ZBuzBng==", "477-732-4267", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/25.jpg", "Jovany_Wiza" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8321 Princess Prairie, Kutchmouth, Morocco", "6f5d099b-ba70-4866-8e45-3f8ae9941a56", new DateTime(2024, 11, 9, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(4804), "Monserrat_Cronin@hotmail.com", "Monserrat", "Cronin", "MONSERRAT_CRONIN@HOTMAIL.COM", "MONSERRAT.CRONIN", "AQAAAAIAAYagAAAAEG75B02IqlBuMVXoDIaJpJ0yG1f75mwQZu9LnB9R5D8XVGulzs2FRQif8965wxr5Rw==", "913-833-8927", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/596.jpg", "Monserrat.Cronin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0679 Hirthe Wells, Mariambury, Solomon Islands", "e699644c-943c-4961-9615-436e2f4fe06c", new DateTime(2024, 5, 17, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(5132), "Twila.Gerhold83@gmail.com", "Twila", "Gerhold", "TWILA.GERHOLD83@GMAIL.COM", "TWILA_GERHOLD69", "AQAAAAIAAYagAAAAEPv4poE4C0+M7bZLd4RposEWXqmspA3ACz/dn1jRtBqQ0VJcUED4bfFmI0difRNGvg==", "828-445-5332", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/738.jpg", "Twila_Gerhold69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "378 Lemke Corners, Port Carolemouth, Russian Federation", "c8dc9ae6-4db1-4edb-aed8-feba2cf9fa09", new DateTime(2024, 2, 15, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(5507), "Jesse51@hotmail.com", "Jesse", "Torp", "JESSE51@HOTMAIL.COM", "JESSE_TORP25", "AQAAAAIAAYagAAAAEKBeqk1h8WbAXyZa3d6h7zYJipvFsYAVJMvLA3EPVYu0HIaDILLE4sJ1vHsln+go4A==", "639-500-5739", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/74.jpg", "Jesse_Torp25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7283 Bartoletti Neck, Prohaskaview, Papua New Guinea", "84bc906a-5140-4bf9-a100-27f6c2c5b13a", new DateTime(2024, 5, 23, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(5951), "Walton.Carroll54@yahoo.com", "Walton", "Carroll", "WALTON.CARROLL54@YAHOO.COM", "WALTON0", "AQAAAAIAAYagAAAAEIIm/x5R8YgOLVPDMzQDCu5wGgZKCJh5s+tWepDAtVzln6eelGi9ZseZYPeoAtxA7g==", "668-556-3148", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/65.jpg", "Walton0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "46524 Robin Rapid, Larsonhaven, Turkmenistan", "982c9e43-318f-4fc5-8c81-31a0a20f9efa", new DateTime(2024, 12, 19, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(6421), "Pedro.Rempel@gmail.com", "Pedro", "Rempel", "PEDRO.REMPEL@GMAIL.COM", "PEDRO.REMPEL", "AQAAAAIAAYagAAAAELg7tGW1p8MiuP8qZ41FJdTLo64dedrxgYXrSZIcHZCIcU8HkKRrIDcMdQBkP1kU+g==", "187-955-1905", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/440.jpg", "Pedro.Rempel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "93454 Antonia Lock, Cheyenneland, Tajikistan", "4a4b71cf-8b8a-4aec-98ac-981cc34550b2", new DateTime(2023, 12, 31, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(6781), "Christian_Rosenbaum24@hotmail.com", "Christian", "Rosenbaum", "CHRISTIAN_ROSENBAUM24@HOTMAIL.COM", "CHRISTIAN.ROSENBAUM", "AQAAAAIAAYagAAAAEL0+7FimC6ItTxFy7uvltr6e8PiY5q5f96/70iRIDoyMq4fXqjZqQP1GWUdM9y3qiQ==", "429-925-0484", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/882.jpg", "Christian.Rosenbaum" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "257 Bianka Shoal, New Sarai, Rwanda", "ad2b26d7-cf13-4343-8674-cfa019e68b81", new DateTime(2024, 1, 27, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(7182), "Alexandro13@gmail.com", "Alexandro", "Thiel", "ALEXANDRO13@GMAIL.COM", "ALEXANDRO47", "AQAAAAIAAYagAAAAEK0fWe8p03RQS3B4CghMIARo7cQbrHOUnDU1uh1FHa13JeOtFYFnajnwIIUHYc0ljg==", "148-139-4768", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/10.jpg", "Alexandro47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4950 Jay Courts, West Hermann, Haiti", "998dceeb-e706-4f41-b204-139b14f7c0e8", new DateTime(2024, 4, 12, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(8405), "Jayde_Weimann10@yahoo.com", "Jayde", "Weimann", "JAYDE_WEIMANN10@YAHOO.COM", "JAYDE.WEIMANN", "AQAAAAIAAYagAAAAEFT9IFpQeW7w2ZSapgmT4O5YiB2iczHcUf7NYcb7iKIPZ3DlaUxzdGikNGc3tnVt0Q==", "698-232-7956", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/104.jpg", "Jayde.Weimann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "839 Kaylie Drives, West Damionville, Vietnam", "483662f6-957f-4c75-abc9-ac0cab319b28", new DateTime(2024, 5, 27, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(975), "Camren.Breitenberg88@gmail.com", "Camren", "Breitenberg", "CAMREN.BREITENBERG88@GMAIL.COM", "CAMREN.BREITENBERG65", "AQAAAAIAAYagAAAAEFuGAGK5nbY3Vrc52co1UQVmHa3zzRLyr2TfbGFDP/9kYENPHv+yPM0nyNfo4irlfA==", "355-276-3566", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1131.jpg", "Camren.Breitenberg65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "56319 Borer Station, Faheyhaven, Reunion", "d3320232-1348-412c-9822-d5178ada9052", new DateTime(2024, 3, 31, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(3562), "Karson.Mitchell@yahoo.com", "Karson", "Mitchell", "KARSON.MITCHELL@YAHOO.COM", "KARSON_MITCHELL34", "AQAAAAIAAYagAAAAEPXt1ZteLI9NLeQ9snSIluJzdJMF8dh+fAOoO3jE9mleTIduOi7z32S2Uofo9YZODA==", "083-903-6938", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/140.jpg", "Karson_Mitchell34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "70537 Amparo Shores, Bartonbury, Guadeloupe", "59efc1c4-e2bc-41aa-86c3-6c893d4793a0", new DateTime(2024, 8, 30, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(4578), "Kenya24@gmail.com", "Kenya", "Fritsch", "KENYA24@GMAIL.COM", "KENYA_FRITSCH", "AQAAAAIAAYagAAAAEGS08Fgb3nxaUvlo4YQdLCfA739d7WrB4h105EPdWUI0vg1CSuxBCmIlz+RedXAC+g==", "033-438-0902", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/909.jpg", "Kenya_Fritsch" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "10268 Alva Ridge, Creolachester, Saint Kitts and Nevis", "3ea4eb69-ca8c-46aa-8d69-87b8fc94d76b", new DateTime(2024, 6, 8, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(4816), "Dayne.Kautzer21@yahoo.com", "Dayne", "Kautzer", "DAYNE.KAUTZER21@YAHOO.COM", "DAYNE9", "AQAAAAIAAYagAAAAEFVKe/S+P5C7nEivwvwGqsBIxi6mPuqbPZ6saExQSIuAPOyaCOq49tYprt3bgQKz1Q==", "702-593-5064", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1047.jpg", "Dayne9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "750 Lueilwitz Cliff, Kayleeside, Seychelles", "dcb8b053-7aa3-4ff2-89c0-e3eca1bb2bda", new DateTime(2024, 12, 21, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(5064), "Gage50@hotmail.com", "Gage", "Rutherford", "GAGE50@HOTMAIL.COM", "GAGE_RUTHERFORD", "AQAAAAIAAYagAAAAEP9NA/DWYqdyvl8nhBC4GqupNO6bKme/Om2SPiHriEF+7XVj0urTHKU8ZDCnooTuUQ==", "884-618-3697", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/315.jpg", "Gage_Rutherford" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "095 Olson Neck, Ryanland, Tajikistan", "fc9a8f29-ea77-44cc-90f5-e3cf2c81ed64", new DateTime(2024, 12, 1, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(5277), "Lilly_Lowe85@gmail.com", "Lilly", "Lowe", "LILLY_LOWE85@GMAIL.COM", "LILLY59", "AQAAAAIAAYagAAAAEJHpJ7965Q/l/KrQEVeHTaubZJOmTd6F2xXsUMEDfJu5XQFkA6L5Boq/tRjFL9ECjg==", "937-663-3131", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1217.jpg", "Lilly59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "586 Kennedi Estates, Bethelland, Tajikistan", "8ce7a922-9bd8-4895-9b5c-e335d9163165", new DateTime(2024, 7, 21, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(5493), "Melany_Kling@yahoo.com", "Melany", "Kling", "MELANY_KLING@YAHOO.COM", "MELANY18", "AQAAAAIAAYagAAAAEMQteJ7qjzlQaK2OKIhePurRjlK2BFdGXL6ZtvogB2jfpgAoIwdTWppd+gFkHij5ww==", "065-873-0719", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/594.jpg", "Melany18" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "280 Melba Wells, Salmaberg, British Indian Ocean Territory (Chagos Archipelago)", "fe551945-2459-41d9-8cbb-4f50d8af5789", new DateTime(2024, 4, 21, 6, 26, 48, 105, DateTimeKind.Utc).AddTicks(8713), "Eunice.Gerlach@yahoo.com", "Eunice", "Gerlach", "EUNICE.GERLACH@YAHOO.COM", "EUNICE_GERLACH42", "AQAAAAIAAYagAAAAEA/Tc+qWYVS97P+uJLhy/M+PRNavoLy9NWVyCV8CTLnD9ySfDp4XQ5G3BcMmchZeAQ==", "517-265-5701", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1010.jpg", "Eunice_Gerlach42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "12173 Phoebe Via, Schadenbury, Tokelau", "b944a4e2-1e6e-4215-ae62-31f770198ba9", new DateTime(2024, 8, 9, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(3251), "Shyanne79@gmail.com", "Shyanne", "Johns", "SHYANNE79@GMAIL.COM", "SHYANNE.JOHNS", "AQAAAAIAAYagAAAAEK61uR0xsQ2/54LZ1R/QdIBHimt9brTQfEvHktNCf6iLFcTAIPA2d7u/iOx5Cod8Gw==", "919-276-4631", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/247.jpg", "Shyanne.Johns" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8629 Anais Row, Robintown, Ethiopia", "8165ceb5-edbe-450a-acc8-14ef82b59ef0", new DateTime(2024, 5, 14, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(3581), "Davon_Harvey84@gmail.com", "Davon", "Harvey", "DAVON_HARVEY84@GMAIL.COM", "DAVON_HARVEY", "AQAAAAIAAYagAAAAEOqnDgBgb4QhY0LmfXFYU/xwIch/L5ybgZDYpWfqtGY8Dqb6XfptLDIhs6rWmu5xww==", "874-676-4440", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/2.jpg", "Davon_Harvey" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "10381 Towne Crest, New Joannyville, Guinea-Bissau", "862f26d6-b658-4e62-b5e2-fb8fa8d84367", new DateTime(2024, 5, 4, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(3910), "Coby61@gmail.com", "Coby", "Torp", "COBY61@GMAIL.COM", "COBY.TORP", "AQAAAAIAAYagAAAAEBEXHNZoOuqTeuv2b2QH/6MpOWATJdMPxt6VO/+4eYRLG+kdRyjz/C6+lTdyzdhfMg==", "341-927-1203", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/168.jpg", "Coby.Torp" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "28907 Deven Run, North Miketown, Moldova", "c5b9d148-6326-4b80-8180-fb00c1478bfd", new DateTime(2024, 9, 23, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(5331), "Stan_Pfannerstill@hotmail.com", "Stan", "Pfannerstill", "STAN_PFANNERSTILL@HOTMAIL.COM", "STAN_PFANNERSTILL", "AQAAAAIAAYagAAAAEAfF1dSExp2wryV/izQxTYG0XTZ5g5NtMqU8xj7C5dlxxvrq+1+iuXW9xkcyInrX4g==", "967-657-0262", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/504.jpg", "Stan_Pfannerstill" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "592 Mafalda Ville, North Jeramyshire, Cayman Islands", "1822573e-75f6-4ad1-a5f0-34053cd25a9f", new DateTime(2024, 2, 4, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(5694), "Odell43@gmail.com", "Odell", "Okuneva", "ODELL43@GMAIL.COM", "ODELL_OKUNEVA2", "AQAAAAIAAYagAAAAEIyNaDjgentCGqJgLRM72Qao7aQYdw9wOWfZdHO/dm1z2/UaRtfUwE1DXNoE0tuQfA==", "807-419-7022", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/258.jpg", "Odell_Okuneva2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6247 Auer Key, West Mckenzie, United States Minor Outlying Islands", "8f683aea-51fe-479c-88ad-2940bbb48800", new DateTime(2024, 2, 19, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(5926), "Rod_Volkman@yahoo.com", "Rod", "Volkman", "ROD_VOLKMAN@YAHOO.COM", "ROD_VOLKMAN", "AQAAAAIAAYagAAAAEIhZTl/EoYbdvnxpvQOZdI12b7jAT5yLRzbEK0vmOHAYlgd3knUsvAevfLWVbW4wPg==", "384-918-6464", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/741.jpg", "Rod_Volkman" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0357 Walsh Harbors, Domenicoshire, Belize", "3e78e779-55a9-494d-a9b9-403e5ea5d469", new DateTime(2024, 9, 1, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(6207), "May_Spinka97@yahoo.com", "May", "Spinka", "MAY_SPINKA97@YAHOO.COM", "MAY9", "AQAAAAIAAYagAAAAEEiO0u9EKHZcveUXaxqxJuCgOor95rRVG6opHVX4RpFC0/vA6N6TwSN15sMAGYlwrQ==", "660-874-2987", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1074.jpg", "May9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "628 Luettgen Inlet, North Ashley, Serbia", "e0966cd3-3a90-44ba-aa0e-f4d79b7177cd", new DateTime(2024, 10, 15, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(6439), "Yadira_Walker@gmail.com", "Yadira", "Walker", "YADIRA_WALKER@GMAIL.COM", "YADIRA48", "AQAAAAIAAYagAAAAEHRe0Y46E4XYK4qETrb/g1IJfK2mQzS+DQodGOIr/iQU6AGoysuZw1b7RvvqVH8BFw==", "550-958-5705", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/659.jpg", "Yadira48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "04117 Treva Cliffs, Rodriguezburgh, Chad", "e89d3fe4-735d-4880-becd-99124d6546de", new DateTime(2024, 12, 9, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(6694), "Elyssa_Spinka@gmail.com", "Elyssa", "Spinka", "ELYSSA_SPINKA@GMAIL.COM", "ELYSSA.SPINKA", "AQAAAAIAAYagAAAAEAOdvOFwswJ7KFZ9Kvtqof95GH4AQPlbmuxKCfw+9W7QUZy0uMTNaW50a83yXSSirA==", "615-941-3809", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/539.jpg", "Elyssa.Spinka" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8462 Schroeder Radial, Wittingshire, Chile", "8ce4b1e8-c9d5-47c0-8ea4-c8bb950a7b8c", new DateTime(2024, 11, 22, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(6930), "Elwyn.Ritchie81@gmail.com", "Elwyn", "Ritchie", "ELWYN.RITCHIE81@GMAIL.COM", "ELWYN.RITCHIE70", "AQAAAAIAAYagAAAAECVUedIqrt9La9phCGlyVgJ1mCI9eIjnzl5m0kJbFNVXCkMCuW/9R8QuZ38nOgd5EQ==", "869-439-5541", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/882.jpg", "Elwyn.Ritchie70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "07555 Parker Skyway, New Clementview, Tuvalu", "2d36721f-ad47-41f5-81c3-4b245a15a567", new DateTime(2023, 12, 30, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(7192), "Parker73@gmail.com", "Parker", "Metz", "PARKER73@GMAIL.COM", "PARKER.METZ", "AQAAAAIAAYagAAAAELAaNpR/jjczH08ny5aanABOoou70L+gYVF6qZc4It3xJyAyM+77X530cDNDcOZ2Vw==", "264-101-3459", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/721.jpg", "Parker.Metz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "45408 Krajcik Park, New Modestamouth, Slovenia", "00e00907-8410-43d6-946d-c517b6ec0ed2", new DateTime(2024, 2, 5, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(7434), "Lavinia81@yahoo.com", "Lavinia", "Armstrong", "LAVINIA81@YAHOO.COM", "LAVINIA52", "AQAAAAIAAYagAAAAECmPrGhQ6E3uf189xX00WzkIdB1cDlHp1coCBCBVEx3sZtVFdwSCSGtZO1TRxWqTJw==", "410-494-4660", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/688.jpg", "Lavinia52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "97915 Lysanne Extension, Geovanyview, Kyrgyz Republic", "ba64e86e-ae30-4a71-a4f7-9e518d336159", new DateTime(2024, 11, 1, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(7696), "Jordyn_Blick81@gmail.com", "Jordyn", "Blick", "JORDYN_BLICK81@GMAIL.COM", "JORDYN.BLICK5", "AQAAAAIAAYagAAAAEOMT9u6cwpEsoTitZzup1I2dq3Juzc11TG0SJejgF+whk3Fb5zUTkyuMNW8a0TtC7Q==", "515-539-2955", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/183.jpg", "Jordyn.Blick5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "665 Toy Estate, Schusterborough, Democratic People's Republic of Korea", "ffe4dbe3-4a3a-4dd6-8c34-1eca89be9117", new DateTime(2024, 5, 23, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(7891), "Mallie77@hotmail.com", "Mallie", "Monahan", "MALLIE77@HOTMAIL.COM", "MALLIE.MONAHAN92", "AQAAAAIAAYagAAAAEMzKUGg2805uS8HoT9ooX0xoMU3D/kscweIg8QXExlPGeMnkhQFbA5uWTS/Od9rQtg==", "585-664-8185", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/438.jpg", "Mallie.Monahan92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "49811 Breitenberg Ville, Lake Ceasar, Guadeloupe", "157167a3-16a2-4f35-acac-ac665cdf77a9", new DateTime(2024, 9, 21, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(8169), "Wallace61@gmail.com", "Wallace", "Adams", "WALLACE61@GMAIL.COM", "WALLACE_ADAMS82", "AQAAAAIAAYagAAAAECIosBSlW2h4ek60KfmGjm9/0zen6v6fin9rpka4Rk/kL3E30TT6on6s3VPZP4ydmA==", "234-195-3882", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/421.jpg", "Wallace_Adams82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "632 Emilie Parkway, Lake Charlieport, India", "d618614a-f5af-49c8-b44e-2c85a8f4cc28", new DateTime(2024, 12, 1, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(8420), "Lesly2@gmail.com", "Lesly", "Ferry", "LESLY2@GMAIL.COM", "LESLY10", "AQAAAAIAAYagAAAAEHkwf6GdY+6jj191VKJ6nGNd+zZxzXnRU30zdpsPmos//1LNx1N0wu86f9SNdX+CxQ==", "600-261-2518", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/987.jpg", "Lesly10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "055 Lang Trail, New Maddison, Cambodia", "090cfb2c-30ad-41dc-9497-834515dc64e6", new DateTime(2024, 9, 10, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(8677), "Donald18@hotmail.com", "Donald", "Mayer", "DONALD18@HOTMAIL.COM", "DONALD_MAYER25", "AQAAAAIAAYagAAAAEMTaa8QSyI6flVzMbdBgGmMBDQNQae6/0ECGSriYTBVkb8ypv4161fz4m0nAaTEzFw==", "915-020-4793", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/308.jpg", "Donald_Mayer25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4086 Murphy Corner, Kamrenview, Guinea", "f6116036-af05-49f0-a9e9-7576a65798ca", new DateTime(2024, 3, 6, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(8894), "Kira42@gmail.com", "Kira", "Crona", "KIRA42@GMAIL.COM", "KIRA.CRONA13", "AQAAAAIAAYagAAAAEGdNMHUA42gD+9SCmHn0oSJkkBlEfdgHxu/XcqFTDM8uyQN+geetZCdqQHmtxPjjgA==", "166-998-1883", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/683.jpg", "Kira.Crona13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6484 Hodkiewicz Parks, New Vernahaven, Netherlands", "73be3264-6635-4e7c-9951-590b635f9629", new DateTime(2024, 6, 1, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(9135), "Addie.Schneider55@gmail.com", "Addie", "Schneider", "ADDIE.SCHNEIDER55@GMAIL.COM", "ADDIE.SCHNEIDER", "AQAAAAIAAYagAAAAEH4qVyEwuCi7OMkea78nAGxjWkzLG3ajIhXBULXhUHaz+OUfmEpevdjR/qteRB2CoA==", "769-494-5169", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/187.jpg", "Addie.Schneider" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3712 Kunde Mountain, Rutherfordburgh, Serbia", "6ed825ba-98a1-4214-9d1b-80e59387c712", new DateTime(2024, 1, 2, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(9378), "Amber.Hills30@yahoo.com", "Amber", "Hills", "AMBER.HILLS30@YAHOO.COM", "AMBER_HILLS70", "AQAAAAIAAYagAAAAEDT4DMnCnzNVXBcMVA9GkKKb0F5b6tG6S3aTp+dhnZDqmKarE435zyWJbXN3E3TFGg==", "891-874-7243", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/254.jpg", "Amber_Hills70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6594 Eryn Throughway, Runteborough, Ireland", "8727aaf0-7c7f-4e14-a205-3f5e5415207a", new DateTime(2024, 11, 16, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(9588), "Sabryna1@yahoo.com", "Sabryna", "Mayert", "SABRYNA1@YAHOO.COM", "SABRYNA.MAYERT", "AQAAAAIAAYagAAAAEI5Z+EvIE92pUqMM+MX5GWXtoIyr4lw0dUaxQbToVK8L7Hrg/CtDvR8r0kkfR7knbA==", "145-568-5594", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/847.jpg", "Sabryna.Mayert" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "48239 Fidel Route, South Sierra, Albania", "2581291a-70f9-4bef-99ec-5b74364e8731", new DateTime(2024, 8, 26, 6, 26, 48, 107, DateTimeKind.Utc).AddTicks(9839), "Keon64@gmail.com", "Keon", "Beatty", "KEON64@GMAIL.COM", "KEON_BEATTY54", "AQAAAAIAAYagAAAAEFYBuTwuUZ3GdloQuS4xlVWL7IxOLLa7HFWY6mzzVMjdwxDlO0ED2esPJvbNf2iYtA==", "087-968-4398", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/62.jpg", "Keon_Beatty54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7202 Prohaska Branch, Abernathyberg, Cuba", "2ea14285-808d-4e01-adb5-6660ef2caad0", new DateTime(2024, 8, 3, 6, 26, 48, 108, DateTimeKind.Utc).AddTicks(34), "Deven.Labadie@hotmail.com", "Deven", "Labadie", "DEVEN.LABADIE@HOTMAIL.COM", "DEVEN33", "AQAAAAIAAYagAAAAEEUG0xpdNZitZkztJ+YSYtEOUDHtqgpTbNTIwI+5hldJsmX5UbVF7d5abt+oZfGJ8w==", "146-267-4660", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/191.jpg", "Deven33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "96645 Casper Forges, East Lailafort, China", "33e614b3-a04d-4cef-876d-e5e228328e5a", new DateTime(2024, 8, 1, 6, 26, 48, 108, DateTimeKind.Utc).AddTicks(337), "Tiffany_Ruecker40@hotmail.com", "Tiffany", "Ruecker", "TIFFANY_RUECKER40@HOTMAIL.COM", "TIFFANY_RUECKER73", "AQAAAAIAAYagAAAAELUdRcnSi2QWKBUt0wAQYC4GunJOMPSWJ84QOT4dYRGKrJhLZxkzmFotfxpkYZ5+aQ==", "586-667-2187", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/806.jpg", "Tiffany_Ruecker73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "526 Jarrod Lights, Piperburgh, Myanmar", "5ef60792-0ef1-4c70-a8cb-a3c849a98a83", new DateTime(2024, 1, 23, 6, 26, 48, 108, DateTimeKind.Utc).AddTicks(630), "Josianne.Williamson@yahoo.com", "Josianne", "Williamson", "JOSIANNE.WILLIAMSON@YAHOO.COM", "JOSIANNE75", "AQAAAAIAAYagAAAAENoOs+UX6NTcM4qevd4Or6YAqhUxOECTy9njz0s5ERA0/oXXCE/D4mTfcBgrSSZREg==", "123-861-3566", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1202.jpg", "Josianne75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "46266 Huel Cape, North Marquise, Tajikistan", "c0bfa4d3-98c2-4571-824a-c76689c7c5eb", new DateTime(2024, 9, 9, 6, 26, 48, 108, DateTimeKind.Utc).AddTicks(875), "Schuyler38@yahoo.com", "Schuyler", "Howell", "SCHUYLER38@YAHOO.COM", "SCHUYLER_HOWELL92", "AQAAAAIAAYagAAAAECAkFEb2m8iMUUhcpXv0hDa1ZGUagXNcxzMreKOw2qOaOgT3XR+Ih0fiIcYXKQfF5w==", "248-572-9117", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/821.jpg", "Schuyler_Howell92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "499 O'Conner Park, North Neomaview, Paraguay", "972eb63d-71bf-429f-8587-a9fa3719d35e", new DateTime(2024, 2, 17, 6, 26, 48, 108, DateTimeKind.Utc).AddTicks(1145), "Noble_Denesik@gmail.com", "Noble", "Denesik", "NOBLE_DENESIK@GMAIL.COM", "NOBLE.DENESIK48", "AQAAAAIAAYagAAAAEAYekmzhP3aoH9PGPHNHM7+j6+WAbWw3ali51TuLR5jrTK8AFaV9mTqoXcL+QDx2Vg==", "981-083-9374", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/64.jpg", "Noble.Denesik48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "09541 Julianne Roads, Hintzmouth, Saint Kitts and Nevis", "ce0701a2-477d-4d45-a298-7567a348750d", new DateTime(2024, 2, 16, 6, 26, 48, 108, DateTimeKind.Utc).AddTicks(1360), "Brock_Connelly17@hotmail.com", "Brock", "Connelly", "BROCK_CONNELLY17@HOTMAIL.COM", "BROCK_CONNELLY8", "AQAAAAIAAYagAAAAEHFO1jVcJIA4BnwNXbEzv9YzvNewl7JngbSX+hlv8JHKOdpBE7jGF+z1weEjT8/P4A==", "055-619-4780", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/197.jpg", "Brock_Connelly8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "09585 Olin Ridge, West Rowlandmouth, Australia", "0ed69948-f730-49c5-b712-bb6df7af2911", new DateTime(2024, 6, 8, 6, 26, 48, 108, DateTimeKind.Utc).AddTicks(1608), "Wilson.Sipes72@hotmail.com", "Wilson", "Sipes", "WILSON.SIPES72@HOTMAIL.COM", "WILSON24", "AQAAAAIAAYagAAAAEDklD8JBCWTtJPjWTIj2gdlhrkw9ttMCN6HHoaseVKYsUwh88IBoEeJEYFRwFcyEnw==", "673-154-7778", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/619.jpg", "Wilson24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "43378 Beer Roads, Farrellville, Jersey", "1c961236-e2e3-41ec-a381-07c03f4e4752", new DateTime(2024, 3, 15, 6, 26, 48, 108, DateTimeKind.Utc).AddTicks(1810), "Ward15@gmail.com", "Ward", "Graham", "WARD15@GMAIL.COM", "WARD64", "AQAAAAIAAYagAAAAEDvAtAl3QVp2t0Cd1Qy4FGT3IvHuMDqegvTaGZwKGFFKZex177j6J3NUQRWXSM2A4w==", "675-858-5764", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1233.jpg", "Ward64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "75846 Ramona Garden, North Gracie, Ecuador", "78ac0443-f075-4f1b-a4bb-d598b7ca16e7", new DateTime(2024, 11, 30, 6, 26, 48, 108, DateTimeKind.Utc).AddTicks(2056), "Bianka_Kozey76@gmail.com", "Bianka", "Kozey", "BIANKA_KOZEY76@GMAIL.COM", "BIANKA_KOZEY", "AQAAAAIAAYagAAAAECgyEHBaZqw/db6ZeyySlyFAXD58JgWUbRy/7xLK4CEA+QO5Od8iZwn7C88UBvGevQ==", "788-684-7155", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/199.jpg", "Bianka_Kozey" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "01975 Osinski Alley, Kertzmannburgh, Mayotte", "6b9d0d3a-a9f1-4390-9332-a82ce371ed50", new DateTime(2024, 1, 5, 6, 26, 48, 108, DateTimeKind.Utc).AddTicks(2283), "Johathan.Smith@hotmail.com", "Johathan", "Smith", "JOHATHAN.SMITH@HOTMAIL.COM", "JOHATHAN51", "AQAAAAIAAYagAAAAELfSSAJ/p+rQI+vHjnIsxNAg44WrcK8kM4pzKw+/4LmeilO4tPjTwQckHxUeFQwhJw==", "541-107-4025", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/897.jpg", "Johathan51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "28698 Josiah Union, Adrianastad, Qatar", "e172c7d3-e40e-4ea3-a368-d6583cd5bd4b", new DateTime(2024, 8, 26, 6, 26, 48, 108, DateTimeKind.Utc).AddTicks(2486), "Barton_Kohler@yahoo.com", "Barton", "Kohler", "BARTON_KOHLER@YAHOO.COM", "BARTON87", "AQAAAAIAAYagAAAAEBU0fzMam5MkPIK0P4MMhoHiLpa7hvxkiAfsFL0pLIh0sQuF2dmVdRy7p94qbfx+Jw==", "233-772-0791", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/425.jpg", "Barton87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "62416 Kerluke Cape, Lake Isom, Macao", "cc9e31e1-0cf3-4fce-ab36-86f13ecfbaa3", new DateTime(2024, 10, 19, 6, 26, 48, 110, DateTimeKind.Utc).AddTicks(1719), "Madie.OKon61@hotmail.com", "Madie", "O'Kon", "MADIE.OKON61@HOTMAIL.COM", "MADIE.OKON", "AQAAAAIAAYagAAAAELqXp+ozShPTTW8Gl9c2v2duaTjqy36NKDgYVccbkY/dXJOGfPcNJkbsKPxTtn4LIA==", "236-791-1471", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1180.jpg", "Madie.OKon" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1367 Harris Drive, South Camylleside, Lesotho", "bbe6397c-cdde-4953-a47c-6a1d88f8a34a", new DateTime(2024, 6, 11, 6, 26, 48, 110, DateTimeKind.Utc).AddTicks(2068), "Adriel_Deckow65@yahoo.com", "Adriel", "Deckow", "ADRIEL_DECKOW65@YAHOO.COM", "ADRIEL31", "AQAAAAIAAYagAAAAEExAKhdAHhle9qR7W0B+4zsrQM2uF3nOqgIrJJYFjvjrbe/VpzlssRBaUAdleUaptA==", "962-428-5730", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1126.jpg", "Adriel31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "570 Arturo Streets, Port Jarvisborough, Guernsey", "8ef5ca8f-b969-494d-a588-862d9e56250f", new DateTime(2024, 3, 16, 6, 26, 48, 110, DateTimeKind.Utc).AddTicks(2330), "Bo77@hotmail.com", "Bo", "Hoeger", "BO77@HOTMAIL.COM", "BO.HOEGER84", "AQAAAAIAAYagAAAAELVGioNeE5A3iG86874I83f136ppw0v9aPanD6KHE/NGCIoQo/9ZSE8GD0daCFXbAQ==", "029-741-7106", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/612.jpg", "Bo.Hoeger84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "075 Rollin Cove, Mortimerhaven, Kazakhstan", "49b4583d-302a-4a10-81f4-07e4378072ee", new DateTime(2024, 9, 4, 6, 26, 48, 110, DateTimeKind.Utc).AddTicks(2628), "Kristoffer.Harber75@gmail.com", "Kristoffer", "Harber", "KRISTOFFER.HARBER75@GMAIL.COM", "KRISTOFFER.HARBER", "AQAAAAIAAYagAAAAEBJZ8J1O8EWqzdxMYv7MN/u5UPSuYF9kDrOOl+3402rNl9D6mHRU0/24bUXk+/oz9Q==", "916-021-2434", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/593.jpg", "Kristoffer.Harber" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7520 Zane View, Boscostad, Togo", "c76983c5-8cdd-49a9-8572-0a09fb7229d1", new DateTime(2024, 5, 17, 6, 26, 48, 110, DateTimeKind.Utc).AddTicks(2850), "Luisa_Hudson@gmail.com", "Luisa", "Hudson", "LUISA_HUDSON@GMAIL.COM", "LUISA21", "AQAAAAIAAYagAAAAENk0ZUBu3zQjHImC+4dBclGHDT8KotFXK0GC0OgcYZOUXoOUClRIpKKZ5yR3IgdqHA==", "849-556-7254", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/980.jpg", "Luisa21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6107 Reginald Pass, South Demarcusside, Liberia", "6fab7d06-6285-4297-81ea-63f0e90b6be7", new DateTime(2024, 5, 3, 6, 26, 48, 110, DateTimeKind.Utc).AddTicks(3105), "Einar_Boyer73@hotmail.com", "Einar", "Boyer", "EINAR_BOYER73@HOTMAIL.COM", "EINAR92", "AQAAAAIAAYagAAAAEP+rKGVmu1ssKD+OuBxPNHqae4bIgYWFnYz2g5bKpfj6qbhicErEXB3rrttukwFq4g==", "253-275-3500", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/893.jpg", "Einar92" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 50, 584, DateTimeKind.Utc).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 6, 26, 48, 39, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
