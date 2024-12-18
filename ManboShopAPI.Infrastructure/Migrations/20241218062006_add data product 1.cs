using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManboShopAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adddataproduct1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "745 Bernard Mills, Port Modestaside, Tunisia", "f08e8d2a-b3ec-4114-b42e-950ee584c4ba", new DateTime(2024, 6, 29, 6, 20, 3, 674, DateTimeKind.Utc).AddTicks(160), "Branson98@hotmail.com", "Branson", "Walsh", "BRANSON98@HOTMAIL.COM", "BRANSON_WALSH19", "AQAAAAIAAYagAAAAEBArX7vBHnZbS+CORxQWfDOGur8czbmpdt5zVs22FADa3XE8W+JFBQFRDF6kFV9D/Q==", "156-460-6825", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1016.jpg", "Branson_Walsh19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4269 Harold Isle, Langmouth, Svalbard & Jan Mayen Islands", "5fb63b79-621f-4939-b2b2-052c4beef708", new DateTime(2024, 10, 1, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(1878), "Kirsten.Dicki9@yahoo.com", "Kirsten", "Dicki", "KIRSTEN.DICKI9@YAHOO.COM", "KIRSTEN13", "AQAAAAIAAYagAAAAEBMQLgSzwG5lOOm2OZCoCRXOvWnUkFjZ3ApCK1qW43ScNpdUzFXvHc06A62UR3S5nQ==", "023-946-7592", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/107.jpg", "Kirsten13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "882 Medhurst Corners, Swaniawskiport, Micronesia", "a0ff7ca1-1bc2-4491-acd1-257cbd25c156", new DateTime(2024, 11, 7, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(2165), "Laurel51@hotmail.com", "Laurel", "Fay", "LAUREL51@HOTMAIL.COM", "LAUREL.FAY58", "AQAAAAIAAYagAAAAEAY/hCW7GedNfmHWQ05kue8UmHP+c0x3SvIxudwfI6uiBMcXfWQR+nBp6VMJqD/UOw==", "722-942-7727", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/182.jpg", "Laurel.Fay58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "505 Kaleigh Radial, Port Lessieton, Saudi Arabia", "c7a2003a-c9c1-4a77-8b39-bcd455078160", new DateTime(2024, 7, 14, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(2396), "Myriam.Rau@gmail.com", "Myriam", "Rau", "MYRIAM.RAU@GMAIL.COM", "MYRIAM66", "AQAAAAIAAYagAAAAECINYbyRxq3yRneZpgRVA7qutST4VcAPGoERyeEctSN2oZgJ4n/PrvntDlpYGBIkSQ==", "877-967-2828", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/164.jpg", "Myriam66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "41667 Flavie Isle, Baileeberg, Tunisia", "c8a813df-ca3a-4185-9da2-6f237047c257", new DateTime(2024, 6, 18, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(2590), "Megane61@yahoo.com", "Megane", "Ernser", "MEGANE61@YAHOO.COM", "MEGANE.ERNSER39", "AQAAAAIAAYagAAAAECtnYjiuCAZcV9FXPuvXenLuJOYCtPtFSshvZI7C9l0ywz1T62PomWemu1ugWBXqUQ==", "394-733-8144", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1200.jpg", "Megane.Ernser39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8765 Medhurst Glens, Port Ewaldstad, Bulgaria", "0eecbb02-31da-4ac8-84bf-11b3210e6fb8", new DateTime(2024, 4, 22, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(2837), "Gloria_Hyatt@yahoo.com", "Gloria", "Hyatt", "GLORIA_HYATT@YAHOO.COM", "GLORIA.HYATT", "AQAAAAIAAYagAAAAEFjZ12Y9uRXXVdbT6AQeoTBd1rqDcnz/2Ov0FHpZUDfCGB9rMur9QAHponeBG0sYqQ==", "199-907-4370", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/405.jpg", "Gloria.Hyatt" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "291 Harvey Knolls, Littelburgh, Taiwan", "3900e6e5-0a25-490f-8be0-d693a87187f0", new DateTime(2024, 10, 20, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(4128), "Gussie23@hotmail.com", "Gussie", "Bergnaum", "GUSSIE23@HOTMAIL.COM", "GUSSIE_BERGNAUM92", "AQAAAAIAAYagAAAAEHSP9DGzK4H0SkVqNrA2Rsy0NhW4f9CBz/6AE7b9m3XjkhM3+zOsCo1fD/9svWvy3A==", "515-588-7919", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1221.jpg", "Gussie_Bergnaum92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "03232 Corwin Shoal, Tremayneville, Liechtenstein", "76c8eace-6855-41a8-ab58-e7f31d100f75", new DateTime(2024, 10, 9, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(4400), "Antoinette90@yahoo.com", "Antoinette", "McKenzie", "ANTOINETTE90@YAHOO.COM", "ANTOINETTE.MCKENZIE", "AQAAAAIAAYagAAAAEIRpAYDGHRob4T3zcizbDU/6s+1eT2qVRPYP9izOLjEJCGTyYh26QHTJDsk2Qa4UpA==", "852-714-3807", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/908.jpg", "Antoinette.McKenzie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "07497 Lilliana Garden, East Reaganstad, Norfolk Island", "21438169-e857-4e90-806c-1dc4fdf36e9b", new DateTime(2024, 2, 10, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(4649), "Delphia86@hotmail.com", "Delphia", "Breitenberg", "DELPHIA86@HOTMAIL.COM", "DELPHIA44", "AQAAAAIAAYagAAAAEJnlJHDquolT8eaLKVZKoVRXsAuKlDO1rHTEaLUW/msJv61UfVsZbq08wPjAmCsE9Q==", "247-496-5855", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1109.jpg", "Delphia44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9167 Heber Crossing, East Dedric, Grenada", "905c4488-a1a4-4430-a366-f9f0826c099a", new DateTime(2024, 5, 20, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(4833), "Berniece.Walter0@gmail.com", "Berniece", "Walter", "BERNIECE.WALTER0@GMAIL.COM", "BERNIECE40", "AQAAAAIAAYagAAAAEIX8bUq2maRwwmxsc3PcnPcnkIaiBMcjTutIs8GYsbMpHQRiFDBbj8JDinf6eZuvfA==", "832-311-0472", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1050.jpg", "Berniece40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "283 Lurline Drive, Leuschkeberg, Poland", "def0538b-dcb5-412a-935b-bf35954c7502", new DateTime(2024, 10, 8, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(5100), "Shanelle65@yahoo.com", "Shanelle", "Mante", "SHANELLE65@YAHOO.COM", "SHANELLE.MANTE42", "AQAAAAIAAYagAAAAEEbEBmuIUFH3CNF4CVQS6HooAFwiWkXh5EmEfkOS/7ijKCFX2UWUA2WQuJ1ej9L3JA==", "717-553-3544", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/287.jpg", "Shanelle.Mante42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "975 Hauck Island, Mosciskiview, Guernsey", "c85a05a0-3936-4a9a-bcda-ddb30d9666b9", new DateTime(2024, 11, 16, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(5343), "Ava61@yahoo.com", "Ava", "Herzog", "AVA61@YAHOO.COM", "AVA_HERZOG24", "AQAAAAIAAYagAAAAENbaKTcqp6IOnTADVaur9xPhlGX3xrJyxf/rFusq6YcZFImB+4CLhEGXFoteXR7nNg==", "655-727-2139", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/914.jpg", "Ava_Herzog24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8419 Haley View, O'Keefeside, Oman", "08d7b943-f752-4746-85e4-f9620d3c4c31", new DateTime(2024, 8, 19, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(5556), "Jasper_Reinger@yahoo.com", "Jasper", "Reinger", "JASPER_REINGER@YAHOO.COM", "JASPER.REINGER26", "AQAAAAIAAYagAAAAEDBAgVvlcz+6GBv/56bycsnge738+j5VWSAR0zTGDZrrOfObaZ2Oa2FMuhXLl2Tb3Q==", "487-261-0449", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/199.jpg", "Jasper.Reinger26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "428 Mackenzie Points, Aylinfurt, Lesotho", "cc3b2e0f-779d-4f62-89da-5583a88072bb", new DateTime(2024, 10, 13, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(5783), "Reid60@hotmail.com", "Reid", "O'Conner", "REID60@HOTMAIL.COM", "REID64", "AQAAAAIAAYagAAAAEB7SD9v3PpMS2KRt1VGsXatkIveuXtqb7yBi/zNHaHXRlVIvhEmHmziKge4jPoOewA==", "746-430-1742", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/858.jpg", "Reid64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7440 Volkman Springs, West Anderson, Canada", "45509207-8a90-4f6c-8d00-250837bf5fbf", new DateTime(2024, 3, 13, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(5964), "Elbert.Mueller74@yahoo.com", "Elbert", "Mueller", "ELBERT.MUELLER74@YAHOO.COM", "ELBERT36", "AQAAAAIAAYagAAAAEHy437+nRHH3HUwlqh1vbhr65s0RRlJhUMWFOFJ5ApTPr7LBYBmdUDFTHZv1O//sPw==", "487-117-7312", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/679.jpg", "Elbert36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "46239 Bailee Pike, Hickleberg, Macedonia", "ff4d6e84-271b-40c8-8a70-de58d98b16c4", new DateTime(2024, 3, 8, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(6165), "Gudrun32@hotmail.com", "Gudrun", "Kovacek", "GUDRUN32@HOTMAIL.COM", "GUDRUN_KOVACEK", "AQAAAAIAAYagAAAAEGH8VS3TAlVgGucsmebbvY1mtfkRklRwL+g08jQbLfBifHDlqK6lOO+xGlPuA48c3w==", "889-245-8982", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1204.jpg", "Gudrun_Kovacek" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2207 Kellie Gateway, Todchester, Dominica", "aa9ef4c8-bd89-4b95-8b8b-44a720aa00c9", new DateTime(2024, 9, 7, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(6345), "Jalyn52@hotmail.com", "Jalyn", "Nikolaus", "JALYN52@HOTMAIL.COM", "JALYN56", "AQAAAAIAAYagAAAAEN16ReaZZPKKK8FkaHcmXOyMLIn/pHl72B0zMLsibKy9kPzRqw7YEqgj69SgcLNMVg==", "680-885-0797", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/876.jpg", "Jalyn56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6106 Will Tunnel, Dietrichville, Equatorial Guinea", "fca66930-df3e-459c-b306-f2299f2c0226", new DateTime(2024, 8, 29, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(6561), "Providenci65@gmail.com", "Providenci", "Doyle", "PROVIDENCI65@GMAIL.COM", "PROVIDENCI_DOYLE49", "AQAAAAIAAYagAAAAEJrNue6KAkflrQfSnccOq7BerGAXRKENo6o/psbRJn+1QNk/CZUMsPraQaLq2I5WmQ==", "440-194-6015", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/166.jpg", "Providenci_Doyle49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8313 Kimberly Estate, Reichelhaven, Togo", "6a8120b1-0971-4d08-bee4-815f988349f4", new DateTime(2024, 6, 18, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(6734), "Ciara.Heathcote54@gmail.com", "Ciara", "Heathcote", "CIARA.HEATHCOTE54@GMAIL.COM", "CIARA46", "AQAAAAIAAYagAAAAEICjCPWt0WeKesgwbDQmWNoWjtVM62iKD09IFPWqZi9qxo4mjzXFWRXyC351ABQ+8w==", "210-102-1733", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/683.jpg", "Ciara46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "156 Fatima Estate, Leonoramouth, Guatemala", "e368a6d9-dec9-4db6-8ea0-c87f1c5114b9", new DateTime(2023, 12, 26, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(6925), "Emery_Spinka@yahoo.com", "Emery", "Spinka", "EMERY_SPINKA@YAHOO.COM", "EMERY_SPINKA", "AQAAAAIAAYagAAAAEPt/J/8Iz3PryiMqswMgCsk1N7NAd3C8I2wcgHVVeHUcR2DHJRdzATM85EjqkQTZRQ==", "910-577-5632", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/172.jpg", "Emery_Spinka" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7132 Janet Crescent, Trystanmouth, Bangladesh", "c41a6d96-81fb-4e7e-a197-6733c772d181", new DateTime(2023, 12, 28, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(7087), "Bonita53@hotmail.com", "Bonita", "Stokes", "BONITA53@HOTMAIL.COM", "BONITA.STOKES", "AQAAAAIAAYagAAAAEKSt8Y/A1OGkDIUM7Qz4Kx+JjD7oF1hFxHDr/+KHqtgC7BSYvcCtxk+UrpCfTii//A==", "929-514-5288", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/14.jpg", "Bonita.Stokes" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8163 Rosa Glen, Walshmouth, Saint Barthelemy", "370ac733-851f-4130-8b63-cceb3c5dbb97", new DateTime(2024, 1, 20, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(7303), "Darrell_McDermott@hotmail.com", "Darrell", "McDermott", "DARRELL_MCDERMOTT@HOTMAIL.COM", "DARRELL47", "AQAAAAIAAYagAAAAEKXD0ORj55lFkunH4WKQYmmwFcTBMTsdkRyYso4Z5RWMcpJxRvD9SzmyypwVe5iwHA==", "435-109-3363", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/531.jpg", "Darrell47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "735 Geovanny Street, Dayanachester, Algeria", "7483a7fd-7202-4d1c-9f18-19ef8ba0ebe5", new DateTime(2024, 8, 20, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(7470), "Laverne.Kihn13@hotmail.com", "Laverne", "Kihn", "LAVERNE.KIHN13@HOTMAIL.COM", "LAVERNE_KIHN86", "AQAAAAIAAYagAAAAEE3j1msHUXkvZ5ELV9y3vwhbCxGtWSz8OD2YRLyDXvW6UktfM7WEkbdsvOHaRk6UMA==", "301-724-5202", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/295.jpg", "Laverne_Kihn86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "881 Rosalind Track, Port Juliofurt, Australia", "36006cce-7b10-470d-a03d-52d4ecd0e471", new DateTime(2024, 11, 24, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(7661), "Jed.Kuhic@yahoo.com", "Jed", "Kuhic", "JED.KUHIC@YAHOO.COM", "JED31", "AQAAAAIAAYagAAAAEBr0KIs9MqUWIfH+PAPhE49Vy+Ay3wqJ+LwWKGNmOPsmLQ2OnIqrjVYOF2ac0EHXPA==", "417-956-6729", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1035.jpg", "Jed31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "44370 Emmerich Locks, New Haleymouth, Barbados", "1bcfafb1-c1bb-4224-aa51-0f1ccd4541a2", new DateTime(2024, 6, 1, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(7835), "Louisa_Rogahn89@yahoo.com", "Louisa", "Rogahn", "LOUISA_ROGAHN89@YAHOO.COM", "LOUISA87", "AQAAAAIAAYagAAAAEBguNrXjl4Dwln4yPfppdHL5sfhS0+FUOehcDkniJt71N3y4HefRY4dlEYdiwgso7Q==", "457-737-8847", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/582.jpg", "Louisa87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8645 Bradtke Underpass, West Eudora, Micronesia", "1cc2edab-92c2-4bf0-ac7d-340e86b85bb1", new DateTime(2024, 2, 6, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(8107), "Greta77@gmail.com", "Greta", "Johnston", "GRETA77@GMAIL.COM", "GRETA65", "AQAAAAIAAYagAAAAEGC6X3oQGDLXDk/6UKAyUDyqYknpsxSbRRVjI1DkWZior9KGK/mtZNRKmWnTKFj09A==", "853-727-6667", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/103.jpg", "Greta65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "410 Gutkowski Harbor, Generalburgh, Tuvalu", "b23ae18b-be0a-4260-a59a-333a64915a08", new DateTime(2024, 9, 1, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(8286), "Henri.Rice@gmail.com", "Henri", "Rice", "HENRI.RICE@GMAIL.COM", "HENRI0", "AQAAAAIAAYagAAAAEBJOkgWjUfXx5psplEmbvdYD0/UPDa3oEbEqon/qKgqS71XP8vxCggtGiRIgRUX4og==", "900-224-3702", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/311.jpg", "Henri0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "98369 Adam Turnpike, New Urbanchester, Tanzania", "4930464b-d5a3-463b-a266-eb7f43d899f5", new DateTime(2024, 4, 16, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(8531), "Moriah.Schamberger24@gmail.com", "Moriah", "Schamberger", "MORIAH.SCHAMBERGER24@GMAIL.COM", "MORIAH42", "AQAAAAIAAYagAAAAED3sSMnPZ7uCAC16xpJy1p40RSCD/JFsCh9TayYasmLwFT0dnx9n+bADoARQkL6Kmw==", "982-258-8659", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/160.jpg", "Moriah42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "00664 Krystel Mountain, Giovannishire, Rwanda", "dd51b8ec-30f9-429f-a9b9-c5bf8b326e1a", new DateTime(2024, 12, 12, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(8768), "Skylar2@yahoo.com", "Skylar", "Gottlieb", "SKYLAR2@YAHOO.COM", "SKYLAR.GOTTLIEB", "AQAAAAIAAYagAAAAEJ/JHEDpHCt2wDWkKimBs7eq4KnpR7DeL7ZAx9apUMeU7AV0IudZ0XGOeX/aks4enw==", "399-599-7289", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/388.jpg", "Skylar.Gottlieb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1320 Malika Mountain, New Sim, Kuwait", "46935894-dd6c-40d9-9fe9-80d99fc25105", new DateTime(2024, 11, 2, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(8988), "Bianka.Wintheiser74@gmail.com", "Bianka", "Wintheiser", "BIANKA.WINTHEISER74@GMAIL.COM", "BIANKA.WINTHEISER", "AQAAAAIAAYagAAAAENKm5onDpv/N9Zi5afMj88SjEr07AyDomEdvUAnxZF/Ix47/Yo9F95dAo/a1faVI6g==", "044-710-1785", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/505.jpg", "Bianka.Wintheiser" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "390 Willie Drives, South Abnerhaven, Serbia", "ddf7cdcd-1de9-483f-90d6-daaab5a82cfb", new DateTime(2024, 12, 3, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(9254), "Clair_Erdman44@yahoo.com", "Clair", "Erdman", "CLAIR_ERDMAN44@YAHOO.COM", "CLAIR30", "AQAAAAIAAYagAAAAEI59mXviCcVNB3lg3WTVAZ6Tkm1JZJpyJTcB5wHRI6U4n0+aiiWXuPH1l1K+yxQDvg==", "151-028-0427", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/477.jpg", "Clair30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "772 Cummerata Union, New Imatown, Sudan", "81fc9517-82ce-40ad-82db-f738f374e43c", new DateTime(2024, 1, 2, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(9459), "Martin_Muller@hotmail.com", "Martin", "Muller", "MARTIN_MULLER@HOTMAIL.COM", "MARTIN.MULLER75", "AQAAAAIAAYagAAAAEFHvcU9oEDtIF9PYH/5XlpFG6mIfHaaGtsNjlXXx0xqqgmF346rAwvd/v1T8mD9vpw==", "138-787-0129", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/967.jpg", "Martin.Muller75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "133 Braun Groves, Port Jeniferview, New Caledonia", "47cea0b0-fa11-4439-9f2b-1afd535fe1ca", new DateTime(2024, 9, 13, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(9779), "Rachel_King81@hotmail.com", "Rachel", "King", "RACHEL_KING81@HOTMAIL.COM", "RACHEL.KING53", "AQAAAAIAAYagAAAAEN/iktSho0tWzOFpjMXQ1cyA59cLWr9aqKQ8wCD+b0K9npNHts3056XXXhG1xPgrYw==", "197-529-5569", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/950.jpg", "Rachel.King53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "94206 Mueller Manors, North Emmanuellebury, Micronesia", "cf4909e6-f28b-41b2-95bc-6f57774d6076", new DateTime(2024, 11, 15, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(9996), "Margarete.Kunze2@yahoo.com", "Margarete", "Kunze", "MARGARETE.KUNZE2@YAHOO.COM", "MARGARETE_KUNZE65", "AQAAAAIAAYagAAAAECECLbsBA8+m9CGiQ+W9djSjYxy4CQkJb3h31afmWQWMWPbbTp0myxK1m/Jy5nYPUA==", "884-193-0365", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/87.jpg", "Margarete_Kunze65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "623 Robel Wall, Naderbury, Aruba", "0471d0fe-178c-4d57-977a-1ee501c41abc", new DateTime(2024, 9, 27, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(210), "Lon_Rowe@yahoo.com", "Lon", "Rowe", "LON_ROWE@YAHOO.COM", "LON29", "AQAAAAIAAYagAAAAENB7olJ9ZLCsRRL9e/f/badp/QtW8VNxUna7oWjR3nE8IdbFNhyofnno9/ImY5mbGQ==", "462-380-8359", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/195.jpg", "Lon29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "219 Sharon Fall, New Ashton, Lithuania", "967ac62f-ac45-487a-b82e-646d846a1542", new DateTime(2024, 4, 8, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(373), "Rae_Hilll28@hotmail.com", "Rae", "Hilll", "RAE_HILLL28@HOTMAIL.COM", "RAE41", "AQAAAAIAAYagAAAAEA/7IQ5rFopMQxaZIj6bgT5cpHwp4a6KYhJSZckHuzxLjWYdHWEZihMX37p36HkTBQ==", "769-104-8531", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1247.jpg", "Rae41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "013 Johns Canyon, Verdieberg, Hungary", "9efed32d-2e8d-4567-bbd3-72843d4b3abf", new DateTime(2024, 1, 21, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(569), "Ashleigh52@gmail.com", "Ashleigh", "Wunsch", "ASHLEIGH52@GMAIL.COM", "ASHLEIGH.WUNSCH79", "AQAAAAIAAYagAAAAENZLOil0+OP0mGCyB3bhNq6WM4G78KtwcpERHz0uqrnmQ4vmhmLugQKdJra1JLCj5Q==", "601-358-3963", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/692.jpg", "Ashleigh.Wunsch79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "790 Wisozk Harbors, Batzland, Malaysia", "6372049c-e34e-4699-9a2c-e8056754f415", new DateTime(2024, 8, 13, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(732), "Sibyl_Price@gmail.com", "Sibyl", "Price", "SIBYL_PRICE@GMAIL.COM", "SIBYL.PRICE6", "AQAAAAIAAYagAAAAEHthkYs+cxbexv8gWho0jExv4E/D8sBjUpqwNQ7qBLba8PBJ0Wwkd2hx7nSrhFCS6g==", "326-285-0557", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1028.jpg", "Sibyl.Price6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "40968 Gutkowski Crest, Doylestad, Macedonia", "fbf7f149-5101-4457-bbef-2ea1d8f0b195", new DateTime(2024, 3, 23, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(893), "Gerard93@hotmail.com", "Gerard", "Spinka", "GERARD93@HOTMAIL.COM", "GERARD7", "AQAAAAIAAYagAAAAEKSJk2XKDzUH4fPymQr0B6Y/3LnowhULaC1UwWOtGj8jvMZU3O3uL+3msjeAOzaRzA==", "687-090-8040", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/874.jpg", "Gerard7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "638 Ashleigh Extensions, West Edmondburgh, Tuvalu", "2f686cd2-693c-44d8-80d8-47d5bec9bc95", new DateTime(2024, 4, 1, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(1083), "Amber_Wuckert@gmail.com", "Amber", "Wuckert", "AMBER_WUCKERT@GMAIL.COM", "AMBER.WUCKERT3", "AQAAAAIAAYagAAAAELsoOIlfc8iI0bVMV4IIjNmWPW/y6Wgq/SaB+mnuc7ekR8ygVewUSuigEyqZKz9PLA==", "326-838-3685", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/996.jpg", "Amber.Wuckert3" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 88, 3, new DateTime(2024, 12, 18, 6, 20, 3, 644, DateTimeKind.Utc).AddTicks(6015), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp dạo phố", "Chanel Áo Len Cổ Điển", 2757911.6597977134020084075990m, 2439687.481218123350000m, 110, "Kích thước: M, L, XXL. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 40, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(45), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Adidas Đầm Dạ Hội Trẻ Trung", 303926.48028816805991469321746m, 252688.7843753966600000m, 324, "Kích thước: S, XL, XS. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 132, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(213), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Louis Vuitton Áo Thun Sang Trọng", 6974661.0500281025990669083666m, 4826068.14839207900000m, 311, "Kích thước: M, L, XXL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 154, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(253), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Quần Tây Năng Động", 2503264.8096885861234949417672m, 1701221.111562743600000m, 289, "Kích thước: XXL, XL, M. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 55, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(313), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "H&M Quần Short Sang Trọng", 899431.9145513259622600839557m, 629135.461551683300000m, 38, "Kích thước: L, M, XXL. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 52, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(346), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Nike Quần Tây Sang Trọng", 6154215.6471008754936578864126m, 4300517.212080581750000m, 350, "Kích thước: XL, S, M. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 85, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(379), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp thể thao", "Adidas Đầm Dạ Hội Cổ Điển", 4035458.0243999272369379456168m, 2812037.583476340950000m, 227, "Kích thước: XL, XXL, M. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BrandId", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(409), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "H&M Áo Sơ Mi Hiện Đại", 2354629.6533797403011200341974m, 1708178.680546133900000m, 460, "Kích thước: XL, L, S. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 147, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(483), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Louis Vuitton Đầm Dạ Hội Cổ Điển", 5144420.4624919057005907159810m, 3738010.90412618600000m, 465, "Kích thước: L, XS, S. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 121, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(516), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp dạo phố", "Nike Váy Liền Năng Động", 1869539.4235842354148095859987m, 1275307.081417344200000m, 256, "Kích thước: S, XXL, XS. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 184, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(546), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Adidas Đầm Dạ Hội Thoải Mái", 5573599.3091296281955639408730m, 4769287.10921153750000m, 78, "Kích thước: XL, S, M. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 75, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(577), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Gucci Blazer Thời Thượng", 2757770.0211902554565065641546m, 2205324.924354125150000m, 36, "Kích thước: XXL, S, XS. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 191, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(636), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Tây Trẻ Trung", 5626175.9427893990750369403464m, 3950522.933354915450000m, 346, "Kích thước: M, S, L. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 7, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(666), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Chanel Áo Khoác Năng Động", 6565243.3363599197172941491194m, 4881568.577027541800000m, 92, "Kích thước: S, XL, XXL. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 113, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(697), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Khoác Thời Thượng", 3264903.1736207790467991841248m, 2595353.909500376150000m, 374, "Kích thước: S, M, L. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 108, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(751), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Thun Cổ Điển", 5950464.0527942864618166740464m, 4618323.566653990550000m, 200, "Kích thước: XS, L, S. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 68, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(780), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Polo Thời Thượng", 619043.90889470163726604972406m, 458390.9665143468050000m, 318, "Kích thước: S, XXL, L. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 96, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(807), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp thể thao", "Uniqlo Quần Tây Trẻ Trung", 605485.87138144781348127617693m, 530157.9430345393850000m, 288, "Kích thước: XL, M, L. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 157, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(836), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Nike Đầm Dạ Hội Hiện Đại", 4971117.0034383616860055096429m, 3343333.587874172150000m, 316, "Kích thước: S, XL, XXL. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 165, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(888), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "H&M Quần Jogger Năng Động", 2257428.9857896414580682878619m, 1681835.37190307150000m, 208, "Kích thước: XS, S, XL. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 81, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(918), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Quần Short Năng Động", 4453946.1659219400502000220282m, 2973806.94404519600000m, 74, "Kích thước: XXL, S, XL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 78, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(948), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Quần Tây Thời Thượng", 4976348.8891319975611393653919m, 3591977.011307111300000m, 63, "Kích thước: L, S, XL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 195, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(976), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Chanel Quần Tây Cổ Điển", 4630124.9550871639156462899512m, 3126410.648005560800000m, 132, "Kích thước: L, XXL, XS. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 193, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1028), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Áo Thun Trẻ Trung", 5604011.8444516004676897555619m, 3989708.130357878450000m, 242, "Kích thước: L, S, XXL. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 125, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1057), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp thể thao", "Adidas Quần Jogger Trẻ Trung", 6335751.7343909634047971171409m, 4838028.682921256300000m, 382, "Kích thước: XXL, M, XL. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 76, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1085), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Nike Quần Jean Năng Động", 4115381.5240720033139185829404m, 2837188.082327549450000m, 326, "Kích thước: M, XXL, S. Màu sắc: Đen, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 122, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1135), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Adidas Áo Polo Thời Thượng", 4422876.2818169361122279332186m, 3577759.0834248950000m, 340, "Kích thước: XL, M, L. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 153, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1166), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp thể thao", "Chanel Áo Sơ Mi Thời Thượng", 3864180.8411210609885686908149m, 2690463.096334357250000m, 75, "Kích thước: S, XS, M. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 82, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1194), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Chanel Áo Thun Năng Động", 3629388.7163155256201817926479m, 3049717.297680049100000m, 246, "Kích thước: XL, M, XXL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 5, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1220), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Uniqlo Quần Jogger Hiện Đại", 6656686.6044769860359669193615m, 4452018.087800626700000m, 186, "Kích thước: XXL, L, XL. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 59, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1271), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Louis Vuitton Đầm Dạ Hội Năng Động", 2652906.4151394488579424045185m, 2260142.020104215450000m, 223, "Kích thước: XXL, XS, S. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 91, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1300), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Blazer Trẻ Trung", 3133768.5187917698182121366679m, 2824825.308100404350000m, 437, "Kích thước: XL, XXL, XS. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 166, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1328), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Louis Vuitton Quần Short Hiện Đại", 3757533.8905814923965502354484m, 3026704.963438248350000m, 253, "Kích thước: S, M, XS. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 153, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1358), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Zara Quần Short Trẻ Trung", 1765694.0150702707528157743175m, 1224231.338392930400000m, 78, "Kích thước: XXL, S, XS. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 43, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1402), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Nike Áo Khoác Năng Động", 2272445.9216333485293146570688m, 1607654.782793535800000m, 118, "Kích thước: XS, M, XXL. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 25, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1431), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp thể thao", "Zara Áo Khoác Trẻ Trung", 5441484.3591964368101740329355m, 4495632.975044076200000m, 11, "Kích thước: XL, L, XS. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 67, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1460), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Đầm Dạ Hội Thời Thượng", 1145650.6380785156590899564521m, 828144.065132619350000m, 118, "Kích thước: XL, L, XXL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 101, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1517), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Quần Jogger Trẻ Trung", 2196601.4103211829884339840578m, 1685444.452740096350000m, 189, "Kích thước: XXL, L, XS. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 93, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1547), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Zara Quần Jean Năng Động", 899307.3838476888934149852754m, 633252.309320827850000m, 368, "Kích thước: M, XS, L. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 112, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1577), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "Chanel Áo Polo Trẻ Trung", 186012.62705255858913713341217m, 126473.5506689894300000m, 39, "Kích thước: XS, S, XXL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 13, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1606), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "H&M Áo Khoác Thời Thượng", 7123180.8905097201703129693215m, 4988715.008141289650000m, 255, "Kích thước: XXL, XL, S. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 147, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1664), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Nike Áo Khoác Năng Động", 6393546.4642991457053162956685m, 4792445.240571009950000m, 471, "Kích thước: S, XL, XXL. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 19, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1694), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Váy Liền Thời Thượng", 1561803.0751327553259370043048m, 1234682.796272221400000m, 396, "Kích thước: S, XXL, L. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 22, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1722), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Polo Cổ Điển", 2984642.0117755017865612845923m, 2468127.308005220900000m, 58, "Kích thước: XS, L, XXL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 20, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1750), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Áo Khoác Thoải Mái", 346102.61972253612147892962425m, 292207.1104501480850000m, 310, "Kích thước: XL, XXL, L. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 101, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1803), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Nike Váy Liền Năng Động", 921330.1773067938411812634218m, 749370.962839341650000m, 340, "Kích thước: L, M, S. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 27, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1831), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Adidas Quần Short Hiện Đại", 6943351.5731985510941362101032m, 4669644.63896488850000m, 468, "Kích thước: M, S, XXL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 109, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1859), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp dạo phố", "Chanel Váy Liền Sang Trọng", 1246041.3718756773921085774258m, 1087491.279329775050000m, 492, "Kích thước: XS, M, L. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 79, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1887), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp văn phòng", "H&M Áo Thun Sang Trọng", 1988789.5405566635963315061954m, 1677404.553316430900000m, 11, "Kích thước: XXL, S, M. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 7, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1943), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Nike Áo Sơ Mi Năng Động", 3381996.9353690988469566721312m, 2552167.046430233600000m, 130, "Kích thước: XXL, XL, XS. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 54, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1972), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Chanel Blazer Trẻ Trung", 4202136.2368072006226018238390m, 3476494.463277335450000m, 66, "Kích thước: XL, S, XXL. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 28, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2052), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp văn phòng", "Adidas Váy Liền Trẻ Trung", 2926171.1221681955310359806666m, 2187679.167089143700000m, 131, "Kích thước: S, M, XXL. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 92, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2105), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp dạo phố", "Nike Áo Khoác Cổ Điển", 671594.85907792264699243357081m, 561170.772275424800000m, 462, "Kích thước: S, L, XXL. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 140, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2135), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp văn phòng", "Gucci Áo Khoác Hiện Đại", 5564630.3475342192777011154279m, 4065713.402427295250000m, 186, "Kích thước: S, XXL, M. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 129, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2163), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Nike Quần Short Thoải Mái", 4821798.1038147513174180187242m, 3606344.140176687200000m, 337, "Kích thước: XS, XL, S. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 156, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2191), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "H&M Váy Liền Thoải Mái", 5610330.2192021877436105856874m, 4340322.233236549400000m, 26, "Kích thước: XS, XXL, M. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 154, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2242), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Louis Vuitton Áo Polo Năng Động", 5979971.0247516784018115473353m, 4075394.166319677800000m, 210, "Kích thước: XS, XL, XXL. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 126, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2270), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Chanel Đầm Dạ Hội Thoải Mái", 651250.64568458005968047259436m, 469264.1960767191800000m, 121, "Kích thước: M, S, XL. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 46, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2298), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Quần Jogger Thời Thượng", 3730795.7274507645379554910216m, 3186608.525537422100000m, 113, "Kích thước: M, XS, XXL. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 112, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2326), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Nike Áo Thun Thoải Mái", 3550960.4931102051882136632438m, 2670319.129671329900000m, 131, "Kích thước: M, S, XS. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 71, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2382), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp thể thao", "Zara Quần Jean Hiện Đại", 1509638.8976274897240993022293m, 1257721.329990332300000m, 60, "Kích thước: S, M, XS. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 147, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2410), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "H&M Quần Short Sang Trọng", 5907331.9652419549822060969352m, 4412977.657373776100000m, 115, "Kích thước: L, XS, S. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 57, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2438), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "H&M Váy Liền Trẻ Trung", 752362.47421975521800453598049m, 607732.813240364300000m, 127, "Kích thước: L, XL, S. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 9, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2481), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Zara Áo Sơ Mi Thời Thượng", 1281194.9890073405766429739641m, 1146500.610230572250000m, 345, "Kích thước: M, XL, XS. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 65, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2510), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Đầm Dạ Hội Thoải Mái", 5751514.3605751169559657346759m, 4984848.453209778950000m, 410, "Kích thước: XXL, S, XS. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 107, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2537), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Adidas Áo Khoác Thời Thượng", 2750751.0788324117417794257133m, 2317906.204475306450000m, 110, "Kích thước: S, XL, M. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 143, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2564), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Adidas Đầm Dạ Hội Sang Trọng", 183480.19746152377160146723667m, 126594.042719998100000m, 185, "Kích thước: S, M, XS. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 87, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2622), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Uniqlo Quần Jogger Trẻ Trung", 2197284.4835231291978151025803m, 1480142.094006569900000m, 276, "Kích thước: L, M, S. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 37, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2650), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Louis Vuitton Quần Jogger Thoải Mái", 3395463.6960029403101437399051m, 2361895.461269809250000m, 163, "Kích thước: S, L, M. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 150, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2678), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Nike Áo Sơ Mi Hiện Đại", 5453964.4691579894854198394974m, 4539400.538007263450000m, 307, "Kích thước: XXL, L, M. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 155, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2705), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Blazer Cổ Điển", 5491679.5251307100138417283576m, 4807013.530137435050000m, 440, "Kích thước: XS, XL, XXL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 9, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2763), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Adidas Váy Liền Thoải Mái", 1796702.5840936833088096010688m, 1277352.051601963100000m, 123, "Kích thước: L, XL, XXL. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 88, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2791), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Áo Thun Sang Trọng", 1148290.9892400416938724943061m, 779399.901037702400000m, 451, "Kích thước: M, XL, XXL. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 26, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2818), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Louis Vuitton Quần Jogger Năng Động", 5812926.5859792301953740634892m, 4115814.066923437400000m, 236, "Kích thước: L, XXL, M. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 198, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2868), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Nike Đầm Dạ Hội Năng Động", 6130635.3414360408908694168380m, 4236594.658793531600000m, 113, "Kích thước: S, L, XS. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 64, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2897), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp thể thao", "Zara Đầm Dạ Hội Thoải Mái", 7146407.6648674334749372233382m, 4864052.957429378300000m, 127, "Kích thước: XS, XXL, XL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 157, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2926), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Đầm Dạ Hội Cổ Điển", 3332610.8689099156498968803998m, 2378323.886586734300000m, 380, "Kích thước: S, M, XXL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 54, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2954), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Chanel Quần Jean Thời Thượng", 5440057.2197061371267297054986m, 4276013.656204595750000m, 398, "Kích thước: XL, S, L. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 175, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3006), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Zara Áo Khoác Sang Trọng", 5223911.3391946167988693235910m, 4193440.086470105300000m, 23, "Kích thước: XL, XS, L. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 135, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3035), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "H&M Áo Sơ Mi Cổ Điển", 2086827.5201612944308178336560m, 1802458.22861783300000m, 212, "Kích thước: L, S, XXL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 112, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3063), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Gucci Quần Tây Sang Trọng", 2963430.0586561040604179440459m, 2182506.455245733600000m, 89, "Kích thước: L, XXL, M. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 181, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3091), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "H&M Áo Khoác Trẻ Trung", 6370913.8327244739492321125136m, 4254322.553730112550000m, 221, "Kích thước: M, XXL, S. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 99, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3144), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Louis Vuitton Blazer Năng Động", 5708665.7795782825498720740087m, 4159027.057163710550000m, 123, "Kích thước: XXL, S, XS. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 42, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3173), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Short Năng Động", 860070.8936734745346364307647m, 750900.48558376550000m, 469, "Kích thước: M, XS, XL. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 113, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3201), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Gucci Quần Tây Năng Động", 648237.00837926097545794162894m, 481015.1043475267100000m, 141, "Kích thước: L, M, S. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 183, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3229), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Quần Short Thoải Mái", 764279.26961116370742432124958m, 566141.364925379600000m, 283, "Kích thước: L, XL, XS. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 156, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3278), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Zara Váy Liền Sang Trọng", 1167637.9111095501763434268698m, 1005252.176841106100000m, 216, "Kích thước: S, L, XL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 186, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3307), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Gucci Quần Jogger Thời Thượng", 1782664.6491557824654888918853m, 1388518.430547966800000m, 203, "Kích thước: XL, XXL, XS. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 6, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3335), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Nike Áo Thun Sang Trọng", 3140132.6398724178122971889416m, 2372425.616289673400000m, 283, "Kích thước: M, L, XS. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 154, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3389), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Gucci Blazer Hiện Đại", 438480.38466178803917512929720m, 383833.5091889745200000m, 101, "Kích thước: M, L, XXL. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 173, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3417), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Adidas Quần Tây Trẻ Trung", 4916100.9864019089371904133413m, 4399472.929299510650000m, 185, "Kích thước: XL, M, L. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 105, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3447), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Zara Áo Thun Thời Thượng", 3607730.2142197036427383849828m, 3058877.843047996700000m, 226, "Kích thước: XS, M, XL. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 62, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3476), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Chanel Đầm Dạ Hội Cổ Điển", 2632569.1175258092312789819619m, 2222416.53885576650000m, 304, "Kích thước: XL, XS, M. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 78, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3522), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp dạo phố", "Nike Áo Khoác Sang Trọng", 3816252.7571281365653906106079m, 2747518.321870966550000m, 300, "Kích thước: XXL, XL, XS. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 89, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3550), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp dạo phố", "H&M Đầm Dạ Hội Cổ Điển", 4963237.2398038436584218691141m, 4431251.264579028950000m, 410, "Kích thước: S, XL, XXL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 91, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3579), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Áo Thun Hiện Đại", 5351548.3500396245487873780481m, 3778965.617674144100000m, 161, "Kích thước: XXL, S, XS. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 191, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3608), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp văn phòng", "Adidas Áo Polo Sang Trọng", 1755829.5507440446882981776229m, 1594669.296513625700000m, 85, "Kích thước: XXL, M, L. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 55, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3666), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Sơ Mi Thoải Mái", 2559901.5509147675105632085909m, 2209109.876138895350000m, 416, "Kích thước: S, XXL, XL. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 119, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3695), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Adidas Quần Jogger Hiện Đại", 3434586.0704023135135744363626m, 2604443.507322198800000m, 476, "Kích thước: XS, XL, S. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 39, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3723), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Chanel Áo Sơ Mi Trẻ Trung", 1400630.8467564928723686223630m, 1133989.318828263650000m, 248, "Kích thước: XS, M, S. Màu sắc: Hồng, Đen" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification", "UpdatedAt" },
                values: new object[,]
                {
                    { 101, 7, 78, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3779), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Chanel Quần Short Năng Động", 3172499.6125116980490978493047m, 2658296.19112883150000m, 418, "Kích thước: S, XXL, XS. Màu sắc: Đen, Đỏ", null },
                    { 102, 5, 35, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3808), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Uniqlo Đầm Dạ Hội Cổ Điển", 972846.3809201830113238381043m, 710064.302706554900000m, 359, "Kích thước: XS, S, L. Màu sắc: Xám, Đen", null },
                    { 103, 10, 192, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3837), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Đầm Dạ Hội Thoải Mái", 2226386.7993096081719071327186m, 2003480.505648131900000m, 498, "Kích thước: L, M, S. Màu sắc: Trắng, Đen", null },
                    { 104, 8, 29, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3866), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Khoác Hiện Đại", 3699418.1144343219631784076733m, 2683247.156984884550000m, 55, "Kích thước: L, M, XS. Màu sắc: Xanh Navy, Trắng", null },
                    { 105, 10, 64, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3918), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Zara Blazer Thoải Mái", 6449343.5636034674051957366495m, 4882228.20441140450000m, 285, "Kích thước: XS, L, XL. Màu sắc: Xanh Navy, Trắng", null },
                    { 106, 3, 72, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3947), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Thun Hiện Đại", 5355178.7967038194592863929531m, 3808673.773531298600000m, 439, "Kích thước: XXL, L, XS. Màu sắc: Hồng, Xanh Navy", null },
                    { 107, 9, 103, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3974), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Quần Tây Thời Thượng", 797863.8618858095811849665512m, 555402.892940721050000m, 153, "Kích thước: L, XL, XXL. Màu sắc: Xám, Trắng", null },
                    { 108, 10, 176, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4001), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Zara Đầm Dạ Hội Trẻ Trung", 5001003.8738672493232553260535m, 3645029.159267646650000m, 212, "Kích thước: M, S, L. Màu sắc: Đỏ, Trắng", null },
                    { 109, 5, 170, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4051), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Nike Váy Liền Thoải Mái", 72571.310221556242469863113017m, 53050.592331143629250000m, 125, "Kích thước: L, XXL, S. Màu sắc: Trắng, Xanh Navy", null },
                    { 110, 3, 103, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4079), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "H&M Áo Khoác Năng Động", 6863729.2431706348402681894993m, 4941292.994625943400000m, 478, "Kích thước: XS, XXL, S. Màu sắc: Xanh Navy, Hồng", null },
                    { 111, 7, 3, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4107), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "H&M Áo Sơ Mi Thời Thượng", 3307396.3970103127249067177049m, 2369367.375308777750000m, 393, "Kích thước: XS, L, M. Màu sắc: Xám, Xanh Navy", null },
                    { 112, 7, 50, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4158), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Gucci Áo Thun Trẻ Trung", 5527975.1633222089356007233753m, 4458827.89264042400000m, 57, "Kích thước: XL, XS, XXL. Màu sắc: Đen, Đỏ", null },
                    { 113, 6, 124, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4187), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Nike Áo Len Cổ Điển", 3594500.9767528117436720129137m, 2409354.127570767800000m, 208, "Kích thước: XS, L, S. Màu sắc: Đen, Đỏ", null },
                    { 114, 1, 148, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4214), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Chanel Áo Polo Hiện Đại", 1627670.3844955492347997503214m, 1120410.73215457700000m, 108, "Kích thước: S, L, XXL. Màu sắc: Xám, Đỏ", null },
                    { 115, 10, 108, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4242), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "H&M Áo Thun Năng Động", 5169549.5790326197734717975506m, 3794388.215597585600000m, 457, "Kích thước: L, XL, S. Màu sắc: Trắng, Xanh Navy", null },
                    { 116, 9, 110, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4292), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Chanel Quần Tây Sang Trọng", 4646322.5257986967490471561030m, 3542725.11849809900000m, 335, "Kích thước: XXL, XL, M. Màu sắc: Trắng, Xám", null },
                    { 117, 7, 111, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4319), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Sơ Mi Thoải Mái", 4209451.3517370406976316124943m, 3573884.375695201100000m, 378, "Kích thước: L, XXL, XS. Màu sắc: Trắng, Xanh Navy", null },
                    { 118, 10, 179, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4347), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Louis Vuitton Váy Liền Thời Thượng", 3610073.0842668451812632040259m, 3078917.617374690800000m, 351, "Kích thước: S, XS, M. Màu sắc: Đỏ, Đen", null },
                    { 119, 1, 175, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4375), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Adidas Blazer Sang Trọng", 255942.16284688942525676395412m, 210243.7828511905550000m, 131, "Kích thước: XXL, L, XL. Màu sắc: Xanh Navy, Hồng", null },
                    { 120, 7, 173, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4426), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Gucci Đầm Dạ Hội Trẻ Trung", 2095106.6258818978866010932104m, 1525129.201809546800000m, 362, "Kích thước: XS, XL, M. Màu sắc: Trắng, Đen", null },
                    { 121, 4, 165, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4454), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Len Cổ Điển", 4131664.6496911978141580580059m, 3561570.43888006400000m, 208, "Kích thước: XS, S, XL. Màu sắc: Trắng, Xám", null },
                    { 122, 5, 98, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4482), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Chanel Quần Jean Hiện Đại", 6053659.0359690865104652556271m, 4312273.516293432200000m, 298, "Kích thước: XS, L, S. Màu sắc: Trắng, Đỏ", null },
                    { 123, 9, 58, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4509), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Gucci Áo Sơ Mi Sang Trọng", 3893414.3566267239290774341329m, 2829979.549427550800000m, 106, "Kích thước: XXL, S, XS. Màu sắc: Hồng, Đỏ", null },
                    { 124, 4, 65, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4553), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Áo Polo Sang Trọng", 161953.88847846271522123779972m, 140649.6106866980300000m, 264, "Kích thước: XXL, M, S. Màu sắc: Đỏ, Xám", null },
                    { 125, 3, 2, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4581), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Nike Đầm Dạ Hội Sang Trọng", 988899.2170768381147829367496m, 753491.405791436900000m, 226, "Kích thước: XL, L, XXL. Màu sắc: Đen, Đỏ", null },
                    { 126, 8, 87, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4609), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Zara Áo Polo Thời Thượng", 4222473.2172993163771876626910m, 3306709.261968740600000m, 486, "Kích thước: S, XXL, L. Màu sắc: Đỏ, Đen", null },
                    { 127, 8, 166, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4665), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp thể thao", "Zara Đầm Dạ Hội Thoải Mái", 844002.1931195293605978224645m, 563542.606813888850000m, 238, "Kích thước: L, M, XXL. Màu sắc: Đen, Xám", null },
                    { 128, 9, 143, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4694), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Nike Đầm Dạ Hội Hiện Đại", 5055271.1674357762044495251761m, 4214751.491632923950000m, 145, "Kích thước: XXL, XL, M. Màu sắc: Xám, Xanh Navy", null },
                    { 129, 1, 90, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4724), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Blazer Thoải Mái", 4726480.0358167252182752750415m, 3154130.765109334400000m, 122, "Kích thước: S, XS, L. Màu sắc: Đỏ, Trắng", null },
                    { 130, 10, 35, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4752), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Áo Sơ Mi Thoải Mái", 1777767.1605581130018861253447m, 1333833.340850347100000m, 463, "Kích thước: M, L, XL. Màu sắc: Xanh Navy, Hồng", null },
                    { 131, 6, 44, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4819), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Gucci Quần Jogger Thời Thượng", 2230652.0420418930781646470151m, 1631949.624218009750000m, 194, "Kích thước: S, XL, XXL. Màu sắc: Đỏ, Hồng", null },
                    { 132, 4, 128, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4846), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Adidas Quần Jogger Sang Trọng", 5904534.3266716896740199661656m, 4120127.338460542700000m, 273, "Kích thước: S, XS, XL. Màu sắc: Trắng, Xanh Navy", null },
                    { 133, 7, 185, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4873), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp thể thao", "H&M Quần Jogger Thoải Mái", 5471876.2250002195859962640359m, 4127495.374019081300000m, 469, "Kích thước: XL, XXL, L. Màu sắc: Xanh Navy, Trắng", null },
                    { 134, 8, 198, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4902), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Uniqlo Quần Short Trẻ Trung", 3788438.2226036753237117799039m, 2613982.839265532300000m, 34, "Kích thước: XXL, S, L. Màu sắc: Xám, Hồng", null },
                    { 135, 1, 69, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4955), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "H&M Đầm Dạ Hội Cổ Điển", 3159335.8072563532797807748991m, 2210667.578726033300000m, 237, "Kích thước: M, XXL, S. Màu sắc: Hồng, Đen", null },
                    { 136, 4, 169, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4985), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Blazer Thoải Mái", 836150.7429097773163110769021m, 655746.443905573850000m, 126, "Kích thước: S, L, XL. Màu sắc: Hồng, Xanh Navy", null },
                    { 137, 4, 194, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5013), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Louis Vuitton Váy Liền Thoải Mái", 3998672.6336918190257594217497m, 3055731.957415125950000m, 473, "Kích thước: XS, S, M. Màu sắc: Hồng, Xám", null },
                    { 138, 4, 106, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5063), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Chanel Quần Jean Hiện Đại", 4631588.5891396046310575765274m, 3457129.851486021650000m, 111, "Kích thước: L, M, XS. Màu sắc: Đen, Đỏ", null },
                    { 139, 10, 181, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5092), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Adidas Quần Tây Hiện Đại", 1369589.4175994318029817326187m, 1237383.222508709600000m, 23, "Kích thước: M, XXL, XS. Màu sắc: Đen, Trắng", null },
                    { 140, 5, 186, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5120), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Len Sang Trọng", 670195.71307574490939267865857m, 509228.6543265571700000m, 382, "Kích thước: XS, L, S. Màu sắc: Xám, Đỏ", null },
                    { 141, 9, 61, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5149), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Chanel Quần Jogger Thời Thượng", 809649.9067194977179002329527m, 610039.115521105550000m, 66, "Kích thước: L, S, XS. Màu sắc: Xám, Đỏ", null },
                    { 142, 1, 48, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5200), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Zara Quần Jogger Thời Thượng", 7006680.4361335151067343361469m, 4861348.898518540400000m, 239, "Kích thước: XXL, S, XL. Màu sắc: Xanh Navy, Hồng", null },
                    { 143, 1, 195, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5228), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Váy Liền Cổ Điển", 4216273.0007935874150207167328m, 3667930.830839246900000m, 274, "Kích thước: XXL, XS, M. Màu sắc: Trắng, Đen", null },
                    { 144, 3, 113, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5255), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Louis Vuitton Quần Jogger Hiện Đại", 3830973.9519848872153233779235m, 3218420.054563718900000m, 244, "Kích thước: XXL, XL, M. Màu sắc: Xám, Xanh Navy", null },
                    { 145, 4, 71, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5283), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Nike Blazer Sang Trọng", 644857.76260145180012298714460m, 519009.5434018027550000m, 73, "Kích thước: XL, XXL, M. Màu sắc: Xám, Hồng", null },
                    { 146, 4, 147, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5334), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Chanel Blazer Thoải Mái", 1358891.6560239263257949263228m, 1130285.405845248350000m, 392, "Kích thước: XL, S, XXL. Màu sắc: Xám, Xanh Navy", null },
                    { 147, 3, 137, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5359), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "H&M Blazer Thoải Mái", 1439603.1523593701435459770708m, 1138157.827631877200000m, 25, "Kích thước: L, M, XXL. Màu sắc: Đỏ, Hồng", null },
                    { 148, 3, 122, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5387), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Louis Vuitton Quần Jogger Thời Thượng", 3267859.6422309878865905600490m, 2618863.948615197200000m, 26, "Kích thước: S, XL, L. Màu sắc: Xám, Xanh Navy", null },
                    { 149, 1, 110, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5438), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Chanel Áo Len Sang Trọng", 3184729.5390629351213688983238m, 2774693.266531852550000m, 324, "Kích thước: S, XS, XXL. Màu sắc: Hồng, Xanh Navy", null },
                    { 150, 1, 100, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5466), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Adidas Quần Tây Trẻ Trung", 223268.68099411189576463155896m, 149716.2225002776250000m, 114, "Kích thước: L, M, S. Màu sắc: Đen, Xanh Navy", null },
                    { 151, 7, 92, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5494), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Louis Vuitton Áo Thun Cổ Điển", 6856183.8861916722315389267295m, 4720235.2831686200000m, 359, "Kích thước: XL, S, L. Màu sắc: Hồng, Xanh Navy", null },
                    { 152, 4, 14, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5524), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Adidas Áo Khoác Sang Trọng", 2376890.2163308865985979367946m, 1589279.046264048650000m, 210, "Kích thước: M, XXL, XS. Màu sắc: Trắng, Xám", null },
                    { 153, 2, 44, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5568), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Adidas Áo Khoác Sang Trọng", 3169897.4438834434956056671578m, 2179688.855613182600000m, 427, "Kích thước: XL, XS, S. Màu sắc: Xanh Navy, Trắng", null },
                    { 154, 2, 72, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5596), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Uniqlo Áo Polo Thoải Mái", 1340221.6061397974968065694703m, 962817.653316672950000m, 419, "Kích thước: L, S, XS. Màu sắc: Xanh Navy, Đỏ", null },
                    { 155, 1, 62, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5624), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp dạo phố", "H&M Quần Tây Sang Trọng", 5219661.8789799238479504996543m, 4544494.617841358900000m, 265, "Kích thước: S, XS, XL. Màu sắc: Hồng, Đỏ", null },
                    { 156, 9, 120, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5653), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Quần Short Sang Trọng", 1044101.3863687243732326842382m, 944614.069377130850000m, 259, "Kích thước: M, XS, XL. Màu sắc: Đỏ, Xám", null },
                    { 157, 5, 66, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5713), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Gucci Váy Liền Thoải Mái", 5724983.9386108898762415127678m, 4697609.237421042200000m, 120, "Kích thước: M, S, XL. Màu sắc: Đỏ, Đen", null },
                    { 158, 1, 42, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5741), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp dạo phố", "H&M Đầm Dạ Hội Năng Động", 1287111.4292578532730422538081m, 986701.694306813600000m, 380, "Kích thước: L, XS, S. Màu sắc: Đen, Hồng", null },
                    { 159, 2, 87, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5769), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp thể thao", "H&M Quần Jogger Sang Trọng", 4493179.4967692978295263180418m, 3011652.547835372600000m, 237, "Kích thước: XL, S, XS. Màu sắc: Đỏ, Xanh Navy", null },
                    { 160, 9, 87, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5828), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Blazer Năng Động", 3535888.4758314065382610743954m, 3140587.639558284800000m, 93, "Kích thước: L, M, XXL. Màu sắc: Đỏ, Đen", null },
                    { 161, 9, 116, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5857), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Louis Vuitton Quần Short Thời Thượng", 1679789.5147387626898884307937m, 1510553.650038484100000m, 432, "Kích thước: XS, S, M. Màu sắc: Trắng, Hồng", null },
                    { 162, 2, 23, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5885), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Uniqlo Áo Len Trẻ Trung", 458517.44387185352991374700506m, 340996.0047632389400000m, 351, "Kích thước: L, S, XXL. Màu sắc: Đen, Hồng", null },
                    { 163, 6, 176, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5913), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "H&M Áo Sơ Mi Năng Động", 1589956.3236291133544575409956m, 1222366.551004234850000m, 460, "Kích thước: XS, XL, XXL. Màu sắc: Xanh Navy, Đỏ", null },
                    { 164, 1, 194, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5964), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Chanel Blazer Thoải Mái", 754689.66185174937488076751810m, 552926.791953202100000m, 207, "Kích thước: M, L, S. Màu sắc: Đỏ, Hồng", null },
                    { 165, 2, 20, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5994), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "H&M Váy Liền Sang Trọng", 4595349.5652296421055643382807m, 4148680.193947511150000m, 178, "Kích thước: S, XS, M. Màu sắc: Đen, Đỏ", null },
                    { 166, 3, 172, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6023), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Polo Trẻ Trung", 2950114.8934588542185965538724m, 2379493.018031407250000m, 160, "Kích thước: M, XL, L. Màu sắc: Xanh Navy, Đỏ", null },
                    { 167, 5, 126, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6051), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Adidas Quần Tây Sang Trọng", 3950804.8885138787683836415928m, 2722072.855814794850000m, 176, "Kích thước: S, M, XXL. Màu sắc: Đỏ, Xanh Navy", null },
                    { 168, 8, 26, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6101), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Gucci Blazer Trẻ Trung", 914671.8343354245129776644948m, 614410.448484952850000m, 191, "Kích thước: L, XS, S. Màu sắc: Xanh Navy, Hồng", null },
                    { 169, 3, 48, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6128), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Gucci Áo Khoác Năng Động", 1767442.2668901362532969862729m, 1229806.758877374650000m, 267, "Kích thước: XL, M, L. Màu sắc: Trắng, Xám", null },
                    { 170, 7, 61, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6155), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp văn phòng", "Chanel Quần Jogger Trẻ Trung", 2187705.1122483531224150558597m, 1905523.720051837550000m, 409, "Kích thước: M, XS, XXL. Màu sắc: Đen, Xanh Navy", null },
                    { 171, 10, 87, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6182), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Đầm Dạ Hội Sang Trọng", 4909120.9390325874140652547765m, 3746792.340111333650000m, 209, "Kích thước: XL, M, XXL. Màu sắc: Xám, Đen", null },
                    { 172, 10, 65, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6235), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp thể thao", "H&M Quần Jogger Thoải Mái", 3439363.8714990150601217323719m, 2389173.413404630550000m, 351, "Kích thước: L, XS, XL. Màu sắc: Đỏ, Hồng", null },
                    { 173, 1, 18, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6264), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Uniqlo Áo Thun Thoải Mái", 487837.31748045867144242176325m, 418550.1627296781050000m, 262, "Kích thước: L, XXL, XL. Màu sắc: Đỏ, Xanh Navy", null },
                    { 174, 8, 50, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6291), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp thể thao", "Chanel Áo Thun Thoải Mái", 5776151.4917655563282966195932m, 4531343.574055879850000m, 409, "Kích thước: XL, S, XS. Màu sắc: Xanh Navy, Đen", null },
                    { 175, 10, 185, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6339), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Áo Len Năng Động", 4565964.6151188179052350760454m, 3757172.460164155400000m, 292, "Kích thước: L, XS, M. Màu sắc: Trắng, Xanh Navy", null },
                    { 176, 4, 44, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6366), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "Gucci Quần Jean Năng Động", 3873501.8576441199456820017300m, 3041466.511069671800000m, 483, "Kích thước: M, S, XS. Màu sắc: Xám, Đen", null },
                    { 177, 3, 109, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6395), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Nike Áo Polo Thời Thượng", 5430243.8153772659338027056871m, 3872921.503474921100000m, 41, "Kích thước: L, S, XS. Màu sắc: Xám, Xanh Navy", null },
                    { 178, 1, 162, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6423), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Đầm Dạ Hội Thời Thượng", 4082874.9735456561769395209046m, 3008239.321248701600000m, 285, "Kích thước: XXL, M, L. Màu sắc: Trắng, Đỏ", null },
                    { 179, 4, 180, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6503), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Len Năng Động", 4980156.1592486694016204531823m, 4208655.60759278300000m, 127, "Kích thước: XXL, XL, S. Màu sắc: Trắng, Xám", null },
                    { 180, 5, 78, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6532), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Nike Áo Khoác Sang Trọng", 6089570.9921383557826795103320m, 4189929.678241466450000m, 160, "Kích thước: XS, XXL, L. Màu sắc: Đen, Trắng", null },
                    { 181, 5, 155, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6561), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "Zara Áo Khoác Cổ Điển", 3180780.9014640401164846357118m, 2530463.813442680450000m, 277, "Kích thước: M, XL, S. Màu sắc: Đỏ, Đen", null },
                    { 182, 7, 110, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6588), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Thun Thời Thượng", 4541479.3578003853814710574297m, 3793139.286586581200000m, 271, "Kích thước: M, XS, L. Màu sắc: Xám, Hồng", null },
                    { 183, 4, 57, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6642), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Gucci Áo Sơ Mi Trẻ Trung", 3276361.1134667819814504083832m, 2444697.447643217750000m, 199, "Kích thước: S, XL, M. Màu sắc: Hồng, Đỏ", null },
                    { 184, 4, 120, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6669), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Quần Short Năng Động", 5790123.9152646159122819839424m, 3885416.1600868850000m, 285, "Kích thước: S, XL, XS. Màu sắc: Trắng, Đen", null },
                    { 185, 2, 66, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6697), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Chanel Áo Thun Trẻ Trung", 6221039.7145867057984710535212m, 4722152.983751254100000m, 98, "Kích thước: XXL, L, M. Màu sắc: Hồng, Đỏ", null },
                    { 186, 3, 26, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6750), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "H&M Áo Len Thời Thượng", 3039426.8703837624670558519728m, 2331789.48615675200000m, 382, "Kích thước: S, XL, M. Màu sắc: Trắng, Đen", null },
                    { 187, 6, 52, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6779), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "H&M Quần Short Hiện Đại", 4692756.6864019323623014697242m, 3365328.70298146550000m, 125, "Kích thước: XL, XXL, L. Màu sắc: Xanh Navy, Trắng", null },
                    { 188, 6, 113, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6807), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Gucci Quần Short Cổ Điển", 1807970.1984211338110794864303m, 1211591.608316570750000m, 226, "Kích thước: S, XS, M. Màu sắc: Xanh Navy, Đỏ", null },
                    { 189, 10, 88, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6835), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Uniqlo Quần Jogger Cổ Điển", 5331076.9838202001824131320238m, 3564307.920708790700000m, 260, "Kích thước: XL, L, M. Màu sắc: Đen, Xanh Navy", null },
                    { 190, 7, 104, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6885), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Zara Áo Polo Hiện Đại", 2581673.4183825295847968693744m, 2103351.676556590850000m, 24, "Kích thước: L, S, M. Màu sắc: Trắng, Xám", null },
                    { 191, 8, 26, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6913), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Uniqlo Quần Jogger Năng Động", 1093888.1125638469516272804471m, 906261.079609972850000m, 86, "Kích thước: L, S, XS. Màu sắc: Đỏ, Xanh Navy", null },
                    { 192, 8, 42, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6940), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Chanel Quần Jogger Năng Động", 6217087.1708433305277499836466m, 4904458.019507287400000m, 393, "Kích thước: L, XXL, S. Màu sắc: Xanh Navy, Đỏ", null },
                    { 193, 4, 63, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6968), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Nike Blazer Trẻ Trung", 5495994.1819706704694597651287m, 4278556.790655122750000m, 360, "Kích thước: L, S, XL. Màu sắc: Hồng, Đen", null },
                    { 194, 4, 189, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7021), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Louis Vuitton Áo Len Thời Thượng", 4239134.4299067639041943470190m, 3020705.150026370900000m, 141, "Kích thước: L, M, XXL. Màu sắc: Trắng, Hồng", null },
                    { 195, 8, 148, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7048), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Adidas Quần Jean Trẻ Trung", 2449970.6064999089382327011168m, 2155377.589457608400000m, 406, "Kích thước: S, M, XXL. Màu sắc: Xám, Hồng", null },
                    { 196, 1, 59, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7075), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Nike Áo Polo Hiện Đại", 4446856.7660200368582189331194m, 3624607.140151986950000m, 71, "Kích thước: S, XL, L. Màu sắc: Đỏ, Đen", null },
                    { 197, 10, 190, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7102), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Thun Sang Trọng", 3071381.1926098650647162526491m, 2170079.200285752200000m, 60, "Kích thước: XS, M, XL. Màu sắc: Xanh Navy, Xám", null },
                    { 198, 1, 105, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7144), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp thể thao", "Adidas Áo Polo Trẻ Trung", 7043161.2251754733099654997585m, 4997875.970511508100000m, 453, "Kích thước: S, XL, XS. Màu sắc: Xanh Navy, Đen", null },
                    { 199, 1, 156, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7171), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Gucci Quần Jogger Thời Thượng", 5200330.5966708094727369046765m, 4003248.670625323850000m, 37, "Kích thước: XL, S, XXL. Màu sắc: Đỏ, Xanh Navy", null },
                    { 200, 7, 177, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7198), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Chanel Blazer Trẻ Trung", 105765.56470719666104799259474m, 93421.94532541170800000m, 89, "Kích thước: XL, L, M. Màu sắc: Hồng, Xanh Navy", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3998 Cummings Parkways, Cassinstad, Singapore", "d321a8af-ecbd-4200-986d-79f2a3ab5bbb", new DateTime(2024, 6, 22, 6, 18, 59, 147, DateTimeKind.Utc).AddTicks(4185), "Miles.Schmeler26@yahoo.com", "Miles", "Schmeler", "MILES.SCHMELER26@YAHOO.COM", "MILES.SCHMELER", "AQAAAAIAAYagAAAAEPXYAIQyXtZG92u/P3xl8xoUoTt0RQ7eFk2Rg1SidQG1WLjzrmpRXjYsPCUK3Ag6sw==", "761-878-9654", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/580.jpg", "Miles.Schmeler" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "47930 Morissette Forks, Trantowhaven, Andorra", "8873e9de-3716-4c5c-99c1-43775cfd0308", new DateTime(2024, 5, 2, 6, 18, 59, 148, DateTimeKind.Utc).AddTicks(5079), "Mckenzie0@gmail.com", "Mckenzie", "Senger", "MCKENZIE0@GMAIL.COM", "MCKENZIE40", "AQAAAAIAAYagAAAAELBQAzXacGn/qDpykixkCT53ALTOcEl7sBCu+RW5xGGNK01b29kjoBi0xWC4SDPzGw==", "747-855-9028", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/497.jpg", "Mckenzie40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "830 Carleton Row, North Nina, Australia", "932ac614-cda9-4927-aefb-cae77cd16228", new DateTime(2024, 2, 23, 6, 18, 59, 148, DateTimeKind.Utc).AddTicks(5590), "Ernesto_Sanford@hotmail.com", "Ernesto", "Sanford", "ERNESTO_SANFORD@HOTMAIL.COM", "ERNESTO.SANFORD", "AQAAAAIAAYagAAAAEBrRRymdMVO+G3zHhxAblxttRdjVYQDS6BFgnFhSdBG5Kv0HbQxAM8Pm10i+oKWCxQ==", "941-093-9695", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1181.jpg", "Ernesto.Sanford" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "49722 Paul Plaza, Emmerichbury, New Zealand", "9172ba19-6040-4158-a5d6-c9a7b6dfc68f", new DateTime(2024, 6, 2, 6, 18, 59, 148, DateTimeKind.Utc).AddTicks(5827), "Shanny_Wisoky31@hotmail.com", "Shanny", "Wisoky", "SHANNY_WISOKY31@HOTMAIL.COM", "SHANNY.WISOKY5", "AQAAAAIAAYagAAAAEDQ9KK8nhW+j7rWQ9C1YhpSRMzwfE6LC85/1g8QXv2Iof+8uu5kuEO/Ou88nN+vuKw==", "060-309-8220", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/371.jpg", "Shanny.Wisoky5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8436 Pouros Well, Port Domenickside, Australia", "8fa115b2-895e-4e66-a7ae-b1417c22d3db", new DateTime(2024, 8, 11, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(1372), "Brandyn_OConner@gmail.com", "Brandyn", "O'Conner", "BRANDYN_OCONNER@GMAIL.COM", "BRANDYN.OCONNER", "AQAAAAIAAYagAAAAEOOJfkcgQ8WhzSAK4DVQ9nGCi4c3KgMXyFS/b9GvTkZPTVOc0Q8fV6qhPwnfAwnJpA==", "443-016-3549", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/771.jpg", "Brandyn.OConner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9241 Allen Roads, South Ernestinaberg, France", "2ec814a2-908e-4028-b415-fa42dce672d5", new DateTime(2024, 9, 14, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(1659), "Claire_Bergstrom@hotmail.com", "Claire", "Bergstrom", "CLAIRE_BERGSTROM@HOTMAIL.COM", "CLAIRE_BERGSTROM", "AQAAAAIAAYagAAAAEO/9/D/mLEBl5KK0hL6fUb/XQt3c0GwpxK8+rUKi0fuEoi2S6syyS3qEe4V4601iGg==", "350-538-5968", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/485.jpg", "Claire_Bergstrom" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "92763 Heller Plain, Ladariusberg, Sweden", "a94e4dd6-42d8-4ff4-8a60-a85ae404b2a7", new DateTime(2024, 6, 23, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(1906), "Colin.Cormier@yahoo.com", "Colin", "Cormier", "COLIN.CORMIER@YAHOO.COM", "COLIN66", "AQAAAAIAAYagAAAAEB2fF8NqQiBEooq3fZAUvlfZv+ZyllVqBE4JZmHQJcbxac6zjJjbQ+N97qAhAn9pMA==", "553-361-2423", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1019.jpg", "Colin66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "52634 Bernadine Brook, Towneshire, Jordan", "53558af4-e10c-4e63-8c76-680744b225f3", new DateTime(2024, 11, 5, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(3156), "Vivienne_Hirthe93@hotmail.com", "Vivienne", "Hirthe", "VIVIENNE_HIRTHE93@HOTMAIL.COM", "VIVIENNE_HIRTHE", "AQAAAAIAAYagAAAAEOrRqWj7w8VvjLfNlWvdoOgt2dNY0RlbmracA4HoUPHfcvmUloWlrD7knK5LEjLTtw==", "472-104-9726", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/340.jpg", "Vivienne_Hirthe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6585 Darrel Terrace, Lake Mauricefurt, Bosnia and Herzegovina", "b8a655e0-a1c4-48c9-b472-50f91b5d585d", new DateTime(2024, 8, 5, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(3482), "Winston23@yahoo.com", "Winston", "Powlowski", "WINSTON23@YAHOO.COM", "WINSTON.POWLOWSKI", "AQAAAAIAAYagAAAAEKg5lSkEKqEZocdXNwkiV3NVcQQ40bdvWv3biyYgrEnp+gq5BDOMPVGM1vx/QCUjMg==", "402-589-1727", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/533.jpg", "Winston.Powlowski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0524 Dean Brook, Lake Mohammedshire, Thailand", "27ac242d-fc65-426e-99cf-e22d51e05b42", new DateTime(2024, 4, 17, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(3683), "Roel_Weber20@gmail.com", "Roel", "Weber", "ROEL_WEBER20@GMAIL.COM", "ROEL.WEBER", "AQAAAAIAAYagAAAAELHlwVVlbphIoRfyOz9NhvlbPKknTkGKFdemFJzgfqHqrnism3W1sJNz9befkjQrIQ==", "205-895-1210", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/418.jpg", "Roel.Weber" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "23262 Auer Estates, Lake Emiltown, Russian Federation", "0da9b554-cc0d-4ec6-99d9-6893f1ad71d7", new DateTime(2024, 10, 7, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(3914), "Asia.Larkin@hotmail.com", "Asia", "Larkin", "ASIA.LARKIN@HOTMAIL.COM", "ASIA78", "AQAAAAIAAYagAAAAECCF6/BnlZaxZOTSpcEshVD8sD+IhefjOTQRgTT4ig78sryAB4Q2JQdi0noq6sFsuQ==", "873-123-9700", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/554.jpg", "Asia78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0612 Lucienne Plain, Port Antoniastad, Iceland", "2982a9a8-a461-4e92-a86d-af8532ae1714", new DateTime(2024, 10, 6, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(4104), "Eloise_Borer93@gmail.com", "Eloise", "Borer", "ELOISE_BORER93@GMAIL.COM", "ELOISE.BORER", "AQAAAAIAAYagAAAAEHTsAxCKfyvMdq3UlX8wGI0WTrdauJUGrXEHbdXBaGDyFBSNF32J44ZPxTcG8N/qHA==", "549-044-0157", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/286.jpg", "Eloise.Borer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "69785 Alaina Rapids, Lake Rickeybury, Botswana", "fc97cab1-50a2-45f6-b32c-7a7fd90d1024", new DateTime(2024, 11, 21, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(4340), "Kody.Walter22@gmail.com", "Kody", "Walter", "KODY.WALTER22@GMAIL.COM", "KODY.WALTER52", "AQAAAAIAAYagAAAAEHNS52ZSapmJo1g90ZAcRsskB+lyBNVnp+pwEUqxlDgHznwcSFGgjglB/kbH03nsPg==", "951-549-7955", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/757.jpg", "Kody.Walter52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "34134 Deckow Drives, West Calebberg, Holy See (Vatican City State)", "b3f43a2a-d159-4b01-98d2-f641129f5a62", new DateTime(2024, 3, 1, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(4521), "Alvah_Mills@yahoo.com", "Alvah", "Mills", "ALVAH_MILLS@YAHOO.COM", "ALVAH.MILLS22", "AQAAAAIAAYagAAAAEP6nu+Q57jMxc1OEE1f09GdFS1BS/QBrntVGdRK560py7BRHEvTjpVZIKn7F0oZMRw==", "996-676-3314", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/766.jpg", "Alvah.Mills22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "234 Gerhard Motorway, North Reymundoview, Saudi Arabia", "9637d8e2-b0bb-4249-935d-8bc9a2ac5114", new DateTime(2024, 8, 6, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(4725), "Barbara_Ward52@gmail.com", "Barbara", "Ward", "BARBARA_WARD52@GMAIL.COM", "BARBARA.WARD53", "AQAAAAIAAYagAAAAEHy6X4sL4AM3CZQkOtqYkS6WRc5KT0uMNBi02Vd7h8ose4NuGB2LQubwnhlWgTy89w==", "683-861-9627", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/49.jpg", "Barbara.Ward53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "405 Fahey Mountain, Lake Damien, Tanzania", "1dfd3e45-e3fc-4e78-a34e-52c9d4539007", new DateTime(2024, 11, 29, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(4887), "Deon_Fay4@yahoo.com", "Deon", "Fay", "DEON_FAY4@YAHOO.COM", "DEON28", "AQAAAAIAAYagAAAAENHiy9pzwIYcC2Xy4+uYpwn6X/U8JB0sRzmul5o+XIcgpHb1a56z9b/Mv2w8+D+IdA==", "670-090-9136", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/578.jpg", "Deon28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "17720 Paris Causeway, Clarabelleberg, Guernsey", "f09ebaee-68bc-4cb1-b974-37740d15ef15", new DateTime(2024, 9, 4, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(5120), "Katharina_Gutmann@yahoo.com", "Katharina", "Gutmann", "KATHARINA_GUTMANN@YAHOO.COM", "KATHARINA.GUTMANN32", "AQAAAAIAAYagAAAAEIw20gnsuSY6OuitG3+l6wg0V52h4FC7ruSCUtjD7Po03YKPTOOMLclM+43y281cDA==", "505-153-7765", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/948.jpg", "Katharina.Gutmann32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1991 Sean Wells, Kertzmanntown, Moldova", "abe06661-6167-43c1-91da-6f19f2cba0e9", new DateTime(2024, 4, 23, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(5296), "Lance_Purdy45@hotmail.com", "Lance", "Purdy", "LANCE_PURDY45@HOTMAIL.COM", "LANCE.PURDY89", "AQAAAAIAAYagAAAAEBUXDxg3YasvKmQmEbESzGjgWQk6rw58Gf0JKmhC4p+y944RndwUifOSuqZrNblg1g==", "239-666-1496", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/641.jpg", "Lance.Purdy89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5636 Marquardt Route, Ferryburgh, Kenya", "1a8f0a6c-4659-47ad-860e-3d31472f75de", new DateTime(2024, 10, 28, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(5494), "Hannah.Hauck38@gmail.com", "Hannah", "Hauck", "HANNAH.HAUCK38@GMAIL.COM", "HANNAH15", "AQAAAAIAAYagAAAAELlwOMM0H3FybcJUfeGxg4fPx03nfAf99J3s3OFVqPeDN238P8Orl7DwMpII8ZG/5w==", "156-743-5443", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/778.jpg", "Hannah15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6874 Purdy Corners, Aaronmouth, Bahamas", "3a5f4727-8307-4abe-ad51-441ecbc6e059", new DateTime(2024, 11, 9, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(5667), "Stuart58@yahoo.com", "Stuart", "Stroman", "STUART58@YAHOO.COM", "STUART48", "AQAAAAIAAYagAAAAEFssbKaC2Q4bNx/jw3mRt7Kq8gLIoEyJxorbgQp+BBw8otgdjKsK3+MKr1ZCpkrIFg==", "418-327-5031", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/472.jpg", "Stuart48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "29415 Legros Street, Boyleland, New Caledonia", "d41eb555-3d58-4c53-a698-653f2fbd3f52", new DateTime(2024, 8, 30, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(5875), "Delia.Rodriguez30@gmail.com", "Delia", "Rodriguez", "DELIA.RODRIGUEZ30@GMAIL.COM", "DELIA.RODRIGUEZ66", "AQAAAAIAAYagAAAAEAVkK3ZrLD6NSFhq7m5++9yuYRII1+duuGpfASxfxqQBrh817vLe/AbBCr2vR5RJ5A==", "307-910-9628", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/865.jpg", "Delia.Rodriguez66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "873 Eliezer Common, Oleland, Croatia", "ef21a2cc-7586-437c-9358-e97bc4a09015", new DateTime(2024, 11, 19, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(6059), "Mohammed_Lesch@hotmail.com", "Mohammed", "Lesch", "MOHAMMED_LESCH@HOTMAIL.COM", "MOHAMMED.LESCH19", "AQAAAAIAAYagAAAAENgtg0NZRYEOlGBbMZ1OAc/eHZuitLh7RQWQRdR/wKlMI0gZJGeSwflZ9rZ5A3spXA==", "009-563-2914", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/778.jpg", "Mohammed.Lesch19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1520 Heidi Extensions, Gillianburgh, Virgin Islands, British", "ff733cf5-bb3d-4a06-8ba5-942f54213020", new DateTime(2024, 3, 26, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(6283), "Theron42@yahoo.com", "Theron", "Steuber", "THERON42@YAHOO.COM", "THERON50", "AQAAAAIAAYagAAAAEOYyQVLxUYUjUHAxjCn/3SF1GIjRQp1V1JwEms2X9Rj/SCZzgEqQ5A95zP++6y3zrQ==", "052-409-7641", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/954.jpg", "Theron50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6362 Bernita Curve, Macitown, Cocos (Keeling) Islands", "5c962957-5b03-4100-b93b-fefc23126145", new DateTime(2023, 12, 31, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(6452), "Chaz.Weber@gmail.com", "Chaz", "Weber", "CHAZ.WEBER@GMAIL.COM", "CHAZ23", "AQAAAAIAAYagAAAAEBdJHB6IY7EcJLvNtiFzxqv8UIgicu9Yfz2c0py1jEH5Rjhm3Yk5E7UkGyKfCrdRMg==", "763-424-8418", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/933.jpg", "Chaz23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "89723 Prosacco Dam, South Merlinbury, Samoa", "d359eb2e-7783-4497-883c-c709cf28bd39", new DateTime(2024, 3, 17, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(6657), "Sterling.Sporer@hotmail.com", "Sterling", "Sporer", "STERLING.SPORER@HOTMAIL.COM", "STERLING.SPORER", "AQAAAAIAAYagAAAAEJarYZ6bePks7lYy/1R9WHL78d15qHEatNhmIGwLdhUGqIUES4wypPUW3ZWUpJkedw==", "016-003-8229", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/140.jpg", "Sterling.Sporer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "155 Robel Flat, Steuberland, United Arab Emirates", "a01ab9dc-fdb8-4ddc-844a-d989c9592e5e", new DateTime(2024, 7, 14, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(6865), "Ora24@yahoo.com", "Ora", "Doyle", "ORA24@YAHOO.COM", "ORA38", "AQAAAAIAAYagAAAAEG9oYttEMuja+0ZJlMfBR5UPOSI3xOIkBETyruUkA6iNIq6FCZJcQyzzNhaKR/1b8w==", "019-807-5312", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/667.jpg", "Ora38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "54184 Arianna Pine, North Emileberg, Saint Kitts and Nevis", "3b8a3054-058f-4b77-8601-35bbd6eec0c9", new DateTime(2024, 6, 26, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(7099), "Agustina_Olson70@yahoo.com", "Agustina", "Olson", "AGUSTINA_OLSON70@YAHOO.COM", "AGUSTINA61", "AQAAAAIAAYagAAAAEI709fCayHRlX9X1Bh95K17gxmCFdlYReBFxxjvYWs0ZinpCJBAVXsVYt+8EU+hbeA==", "505-286-7045", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/438.jpg", "Agustina61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3820 Armstrong Expressway, Carlieport, Bangladesh", "5ce5c1a4-0db5-437b-9720-3153942c5cf7", new DateTime(2024, 8, 28, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(7272), "William_Beer@hotmail.com", "William", "Beer", "WILLIAM_BEER@HOTMAIL.COM", "WILLIAM_BEER", "AQAAAAIAAYagAAAAEC0uWk3e7bD2IJsCF8y5I+ikIq+k2gWNNcPr7Osu3GWBIRLd+wwjZV6k8k3pHWQynA==", "962-357-9812", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/924.jpg", "William_Beer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "574 Sanford Pass, Lake Finn, Falkland Islands (Malvinas)", "fcdd9797-bf5a-4c5a-a12d-8f287e109e1d", new DateTime(2024, 3, 8, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(7472), "Sherman_Kris74@hotmail.com", "Sherman", "Kris", "SHERMAN_KRIS74@HOTMAIL.COM", "SHERMAN.KRIS66", "AQAAAAIAAYagAAAAEOpUMMt9LxAWT57lcAB9FZ4Ccq0dYLGjQPI89o5H7wrh74JYQClA5kKkei5unVnu/A==", "267-378-7795", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1061.jpg", "Sherman.Kris66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "54888 Rosella Terrace, East Katelynfort, Myanmar", "7db288f9-949b-4dfa-9d9c-9cea9673be1d", new DateTime(2024, 8, 13, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(7664), "Rachel57@gmail.com", "Rachel", "Konopelski", "RACHEL57@GMAIL.COM", "RACHEL.KONOPELSKI75", "AQAAAAIAAYagAAAAEIIiclH/gL9Mh/Ps023/DYSMHVeYhNO7bVvk0noKJ9UVh1rMW+wbT4KGzRUNc+s2Vw==", "489-065-0722", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1174.jpg", "Rachel.Konopelski75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "37078 Dandre Crest, New Keithchester, Saint Pierre and Miquelon", "b55004be-110e-4774-8aba-beeff2c84ff6", new DateTime(2024, 5, 15, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(7863), "Tremayne33@gmail.com", "Tremayne", "Rolfson", "TREMAYNE33@GMAIL.COM", "TREMAYNE.ROLFSON2", "AQAAAAIAAYagAAAAECz4otxCz+uQKwn8Ro8waReu85q7xVd8FdBmqLd/pELmURTIKXepiIe4c+MQzotl/g==", "398-490-1621", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/566.jpg", "Tremayne.Rolfson2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "332 Randi River, Chelsiebury, Togo", "3e7cb79b-7a4a-4c7a-a88b-c47d8e38a8f7", new DateTime(2024, 5, 12, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(8075), "Jeanne84@hotmail.com", "Jeanne", "Jacobs", "JEANNE84@HOTMAIL.COM", "JEANNE.JACOBS", "AQAAAAIAAYagAAAAEHsy48VXaKLlAGe4oxcGWfRdwLnhbqJRp6y1pCMzbO/Tja9P7wPXWZ7Hd5YwbhDNfw==", "476-464-5988", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/497.jpg", "Jeanne.Jacobs" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "979 Kendrick Stream, Padbergfort, Benin", "2aa7f376-fed1-4833-b656-0477147ee028", new DateTime(2024, 10, 31, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(8249), "Joseph78@hotmail.com", "Joseph", "Muller", "JOSEPH78@HOTMAIL.COM", "JOSEPH24", "AQAAAAIAAYagAAAAEDpxs/t4vTzKr3Ms8+F8VzQOtAWIwREM3etTYH5I1D4IFy6Rdq5vUNNjpOli1PzbkA==", "002-922-0081", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1171.jpg", "Joseph24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "41548 Pagac Skyway, Lindgrenborough, Cuba", "87f42e8b-ec2a-41f3-b74d-b6c2b5b39ac6", new DateTime(2024, 5, 18, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(8446), "Eliezer_Medhurst@hotmail.com", "Eliezer", "Medhurst", "ELIEZER_MEDHURST@HOTMAIL.COM", "ELIEZER.MEDHURST", "AQAAAAIAAYagAAAAELwjJ/NVEaL1IvMbWvVu95vDVV73Nv6EKFBcY5uArMs50GAy9S4KYFE930Sw1i67Mg==", "076-328-0382", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/146.jpg", "Eliezer.Medhurst" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "04356 Alf Hills, Lake Ladariusshire, United States Minor Outlying Islands", "1704e3c4-9112-47e7-94d2-5e3a207a049f", new DateTime(2024, 11, 28, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(8628), "Tabitha_Daniel@hotmail.com", "Tabitha", "Daniel", "TABITHA_DANIEL@HOTMAIL.COM", "TABITHA.DANIEL30", "AQAAAAIAAYagAAAAEB4IWUeDcFfrE9bXfY0oJJ8sqYMWA8ASfVgMn2MzX5xE+trPiNTDdgEblMc9gpdnkw==", "968-450-7190", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/823.jpg", "Tabitha.Daniel30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2047 Vita Parkway, North Cleve, Samoa", "a98da4a9-7a41-406c-9dbc-060cba2172fa", new DateTime(2024, 2, 4, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(8813), "Hyman72@yahoo.com", "Hyman", "Lindgren", "HYMAN72@YAHOO.COM", "HYMAN_LINDGREN65", "AQAAAAIAAYagAAAAEFDiPFsUU61OtXF2yQ02axi0r+i2TVeBsU4CiCEt9QvJZylrAFgmnsiNqZie0miPWA==", "447-205-5668", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/99.jpg", "Hyman_Lindgren65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "921 Nannie Ridge, Harrisfort, Cocos (Keeling) Islands", "e65c5b62-b8ac-4004-b2cf-681498b77c29", new DateTime(2024, 1, 5, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(8993), "Joyce.Schuster78@yahoo.com", "Joyce", "Schuster", "JOYCE.SCHUSTER78@YAHOO.COM", "JOYCE6", "AQAAAAIAAYagAAAAEHOJmTUVs5wbsO/2S6wX/1bVkjxwZ/eL/POORaiGTcmR7lY6gK27TOYGjng7iyBZqA==", "140-266-4884", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/319.jpg", "Joyce6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5088 Onie Row, New Kellyberg, Republic of Korea", "005087e5-28e5-48dc-b9d6-4e9ea6363dac", new DateTime(2024, 9, 20, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(9213), "Jaron.Lesch88@gmail.com", "Jaron", "Lesch", "JARON.LESCH88@GMAIL.COM", "JARON_LESCH24", "AQAAAAIAAYagAAAAEAtTzRfT5zy+ogTbfjhRHhRgoOPeDFX3cPVXs/pa9a9c9EsMMMDj95k3MDZt3M0iqw==", "132-456-1630", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/992.jpg", "Jaron_Lesch24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "329 Gislason Plains, Stantonfort, Saint Kitts and Nevis", "e48f8298-6eab-4274-b11a-91e423f1259b", new DateTime(2024, 4, 29, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(9385), "Enoch_Goldner@hotmail.com", "Enoch", "Goldner", "ENOCH_GOLDNER@HOTMAIL.COM", "ENOCH28", "AQAAAAIAAYagAAAAEH4w9ytqlS1ymIC21SQZxdI+Mszm3Saq8/AT5UD1zu0gHqVVAXGCX/V8EmcnypvqIQ==", "273-786-8268", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/854.jpg", "Enoch28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "87052 Johns Fields, Peterbury, Oman", "c90e43d6-8874-49bb-9503-7acd79029940", new DateTime(2024, 1, 19, 6, 18, 59, 149, DateTimeKind.Utc).AddTicks(9558), "Chloe19@hotmail.com", "Chloe", "Halvorson", "CHLOE19@HOTMAIL.COM", "CHLOE.HALVORSON3", "AQAAAAIAAYagAAAAEHVw65WSOFDlJQlSyQICEo48ookLpb6C9txFohfLmegOtLGXlbcQzr1uveZ70hREZQ==", "470-282-9333", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1083.jpg", "Chloe.Halvorson3" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 19, 0, 955, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 18, 59, 124, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 152, 4, new DateTime(2024, 12, 18, 6, 18, 59, 117, DateTimeKind.Utc).AddTicks(7223), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Adidas Áo Polo Thoải Mái", 4518659.6031697677686715288908m, 3504853.013195195150000m, 476, "Kích thước: XS, S, L. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 172, 1, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9130), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "H&M Áo Sơ Mi Năng Động", 3888830.1084312667516427054725m, 3130308.665563731800000m, 471, "Kích thước: M, S, XL. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 27, 3, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9300), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp văn phòng", "Zara Áo Polo Thời Thượng", 2830620.9841512039581346224285m, 2379243.4566699650000m, 353, "Kích thước: S, M, XS. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 56, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9340), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp văn phòng", "Zara Blazer Thời Thượng", 4090807.2925835821305275458633m, 3149128.041772561700000m, 73, "Kích thước: XXL, S, XS. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 86, 4, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9375), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Zara Áo Thun Năng Động", 4530249.5052426890781793329290m, 3466119.950819995100000m, 72, "Kích thước: M, XXL, S. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 187, 3, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9440), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Chanel Áo Sơ Mi Cổ Điển", 1239610.0072943243051424805645m, 934650.981847603850000m, 228, "Kích thước: L, M, S. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 96, 2, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9471), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Zara Quần Tây Thoải Mái", 4802311.9753847430832720526601m, 3604110.074402978750000m, 99, "Kích thước: M, L, XL. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BrandId", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 2, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9502), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Áo Sơ Mi Sang Trọng", 5322800.7185549177046945741059m, 4417470.422451950000m, 201, "Kích thước: M, XL, XXL. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 161, 4, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9557), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Gucci Áo Polo Hiện Đại", 3025059.0084991692839034828282m, 2157319.486630113800000m, 351, "Kích thước: XS, L, S. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 87, 1, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9589), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Louis Vuitton Quần Jogger Hiện Đại", 1231012.6909186546668233252658m, 1104875.961790407350000m, 47, "Kích thước: M, XS, S. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 167, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9620), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Nike Áo Len Năng Động", 3454088.6195230883714178303010m, 2680246.394631462200000m, 19, "Kích thước: XXL, M, XL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 41, 2, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9650), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Adidas Áo Len Năng Động", 3023545.5973903458819354365509m, 2253419.223316762550000m, 482, "Kích thước: L, XS, S. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 192, 4, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9701), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Adidas Váy Liền Thoải Mái", 6873533.1887385621220417182271m, 4898639.89884109550000m, 170, "Kích thước: XS, S, XXL. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 143, 3, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9730), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Chanel Quần Jean Trẻ Trung", 6898149.2744153721418762801204m, 4999011.669993335450000m, 146, "Kích thước: XXL, M, L. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 89, 1, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9760), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Louis Vuitton Váy Liền Sang Trọng", 1601155.2716157415145661724642m, 1223757.476982102650000m, 258, "Kích thước: XS, M, XL. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 73, 4, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9790), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Zara Áo Thun Trẻ Trung", 2574687.8538150919063164740350m, 2332489.817074512650000m, 167, "Kích thước: XXL, S, XS. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 123, 5, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9844), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Uniqlo Váy Liền Thời Thượng", 2770692.4877723095957077815724m, 1926467.649816326600000m, 19, "Kích thước: L, XS, S. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 12, 5, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9875), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Adidas Áo Khoác Năng Động", 5523078.5258584814362890052733m, 4497788.628107389400000m, 51, "Kích thước: L, S, XXL. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 38, 1, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9905), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Zara Áo Len Hiện Đại", 2716775.7509249419550711797644m, 2113863.958476097250000m, 238, "Kích thước: XXL, XL, M. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 83, 2, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9960), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Adidas Đầm Dạ Hội Trẻ Trung", 6237912.7319126780999657039609m, 4428457.225736638550000m, 309, "Kích thước: XL, M, XS. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 35, 2, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9989), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp dạo phố", "Nike Áo Thun Cổ Điển", 4348690.1990004452303434822283m, 3338987.710363955600000m, 24, "Kích thước: S, XL, XS. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 63, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(17), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Jogger Năng Động", 4066206.7026008522967131437150m, 2984498.171484939950000m, 390, "Kích thước: XL, L, S. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 16, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(45), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Gucci Váy Liền Cổ Điển", 3568285.9083988627569148199424m, 2858290.04111597150000m, 438, "Kích thước: XS, XL, S. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 47, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(91), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Chanel Áo Polo Thời Thượng", 5351904.0767678962057181961664m, 4501812.565094100800000m, 332, "Kích thước: M, XL, L. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 3, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(121), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Adidas Áo Thun Trẻ Trung", 3401259.9599301073474339148197m, 2347415.629734706250000m, 293, "Kích thước: M, S, XL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 146, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(150), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp thể thao", "Gucci Áo Polo Sang Trọng", 6041075.2342182022159132284795m, 4221699.025299149300000m, 477, "Kích thước: XXL, L, XS. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 151, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(179), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Chanel Quần Short Thời Thượng", 3244927.1422592874556608519569m, 2943832.181747450900000m, 402, "Kích thước: XXL, XL, L. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 196, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(252), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Quần Short Năng Động", 3416476.5982736547233672360093m, 3105300.097144521050000m, 440, "Kích thước: XS, L, XL. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 13, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(282), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "H&M Áo Thun Hiện Đại", 5645716.0579624997247054399774m, 4382200.525786553750000m, 147, "Kích thước: S, XXL, XS. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 188, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(311), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "H&M Quần Short Cổ Điển", 3320341.9610156629243525514967m, 2280710.011489960550000m, 181, "Kích thước: S, XXL, XS. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 79, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(372), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Thun Năng Động", 2761005.7166375045014315458076m, 2067881.716249737800000m, 374, "Kích thước: S, XXL, L. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 51, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(403), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Jogger Thời Thượng", 5001658.3646264757177979497924m, 4272892.069422646400000m, 470, "Kích thước: S, M, XXL. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 128, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(432), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp thể thao", "Gucci Váy Liền Hiện Đại", 3094473.7508306800978619199020m, 2248383.262649060300000m, 198, "Kích thước: S, XXL, M. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 66, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(461), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Gucci Áo Sơ Mi Thoải Mái", 6593427.3613247305258172634199m, 4838323.162389720800000m, 235, "Kích thước: XL, XXL, XS. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 20, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(513), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Gucci Quần Short Cổ Điển", 479188.63135302244147951044705m, 337858.3642562855150000m, 235, "Kích thước: M, XL, XS. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 66, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(542), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Adidas Quần Short Trẻ Trung", 4587588.8115693994502858138386m, 3445715.877486345050000m, 208, "Kích thước: XS, M, L. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 184, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(572), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Quần Tây Cổ Điển", 5831074.8753401248757156974645m, 4475685.105099391100000m, 155, "Kích thước: L, XS, M. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 144, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(601), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Nike Áo Thun Thời Thượng", 1880760.7976634794231791164604m, 1455114.712277972300000m, 198, "Kích thước: XS, XXL, L. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 60, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(654), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Adidas Quần Jean Hiện Đại", 5733552.1154371912512341731563m, 4138285.34719304150000m, 151, "Kích thước: XS, XL, M. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 47, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(683), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp thể thao", "Nike Áo Len Thoải Mái", 2811901.8308174613140978526553m, 2187528.988518844250000m, 220, "Kích thước: M, XXL, L. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 132, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(712), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Sơ Mi Thời Thượng", 3704623.1714412360962196569835m, 3096616.983910436750000m, 233, "Kích thước: S, XL, XS. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 25, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(772), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Uniqlo Váy Liền Thoải Mái", 5311513.3372223585285070832710m, 4774162.720856780300000m, 66, "Kích thước: S, XS, XXL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 151, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(804), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Zara Quần Jean Hiện Đại", 3824734.5362640776000675190474m, 3015785.093957321900000m, 28, "Kích thước: S, XL, L. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 31, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(836), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "H&M Quần Short Trẻ Trung", 1077387.0379273424771202689783m, 839666.647263480800000m, 79, "Kích thước: XS, XXL, XL. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 169, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(865), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Gucci Blazer Thời Thượng", 1536902.1324118470614669463923m, 1378547.014200503900000m, 370, "Kích thước: XL, S, XS. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 64, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(918), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Uniqlo Đầm Dạ Hội Năng Động", 3148012.2321441220556057572616m, 2481545.549781080150000m, 233, "Kích thước: XS, XXL, XL. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 21, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(948), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Sơ Mi Hiện Đại", 2588675.7757006647349764147446m, 1925088.036156113900000m, 305, "Kích thước: L, M, XL. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 142, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(978), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Thun Cổ Điển", 4642878.8392645063781058147605m, 3521773.211724860900000m, 413, "Kích thước: XS, L, XL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 40, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1007), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Tây Cổ Điển", 1448896.5166414356808985422260m, 1183675.021063668050000m, 313, "Kích thước: M, L, S. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 155, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1062), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Quần Jogger Trẻ Trung", 3671957.3516779766743074623233m, 3255333.272355572600000m, 483, "Kích thước: XXL, S, L. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 146, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1091), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Zara Quần Jean Thời Thượng", 4759915.4513204863685960665212m, 3292051.332302924900000m, 488, "Kích thước: L, S, XS. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 79, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1171), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Uniqlo Quần Tây Thời Thượng", 2600901.6094155629084901701942m, 2025406.442620816700000m, 248, "Kích thước: S, L, XS. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 8, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1199), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "H&M Áo Sơ Mi Trẻ Trung", 3198291.7117276149030584644355m, 2629919.736451206050000m, 393, "Kích thước: S, XXL, M. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 55, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1245), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Thun Hiện Đại", 3934552.5860997062321466157975m, 3080362.98848845100000m, 330, "Kích thước: XXL, L, XS. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 50, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1276), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Zara Áo Khoác Trẻ Trung", 5553249.8555653112541840140910m, 4161773.655258986750000m, 217, "Kích thước: XL, S, M. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 199, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1305), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "H&M Quần Jean Năng Động", 173246.14636318761732611018566m, 147068.9313021606200000m, 298, "Kích thước: XS, S, XL. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 68, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1391), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "H&M Áo Len Cổ Điển", 3587928.7428717356548322205503m, 2708217.337063526150000m, 218, "Kích thước: M, L, XXL. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 10, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1422), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Gucci Quần Jean Thời Thượng", 217702.91789260275751665192835m, 189377.1443602704650000m, 264, "Kích thước: XL, XS, S. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 198, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1451), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Chanel Quần Tây Thoải Mái", 2402268.4771637240060981866781m, 1775075.152045907750000m, 268, "Kích thước: L, XXL, S. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 197, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1479), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Uniqlo Đầm Dạ Hội Cổ Điển", 2971249.4310336003567427896970m, 2494205.30270092550000m, 311, "Kích thước: XS, S, XL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 53, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1539), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Quần Jean Năng Động", 4019844.4766499036199937274612m, 2849383.236160925150000m, 422, "Kích thước: M, XXL, XS. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 68, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1568), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Gucci Áo Khoác Thời Thượng", 1632393.5171736435020289069812m, 1297998.325797792800000m, 423, "Kích thước: XS, M, XL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 150, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1597), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Adidas Quần Short Thời Thượng", 2613111.2758828505823729066211m, 2332681.760659576100000m, 19, "Kích thước: S, XS, XXL. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 141, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1627), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Len Cổ Điển", 4391232.6437120129752716805639m, 3252451.994970760400000m, 42, "Kích thước: S, L, XL. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 169, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1681), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Adidas Áo Khoác Sang Trọng", 5106403.6637934843960462441473m, 3903492.425615635550000m, 114, "Kích thước: M, XS, XXL. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 133, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1711), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Adidas Đầm Dạ Hội Thời Thượng", 247760.59366344006579102353015m, 172282.4284389035900000m, 164, "Kích thước: L, XL, XXL. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 137, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1739), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Chanel Váy Liền Trẻ Trung", 5350557.4662984913807139027055m, 4483128.23583218600000m, 119, "Kích thước: L, XS, S. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 200, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1788), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Nike Áo Khoác Thoải Mái", 4956118.6032803160666810110511m, 4363821.541504884200000m, 17, "Kích thước: XL, XS, XXL. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 75, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1820), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp thể thao", "Zara Áo Polo Hiện Đại", 1348439.1549621707967711163925m, 1126662.8613035900000m, 433, "Kích thước: XL, XXL, XS. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 158, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1848), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "H&M Quần Tây Trẻ Trung", 4513385.4387392284010109613636m, 3274359.329158518650000m, 384, "Kích thước: L, XL, XS. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 128, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1877), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Adidas Váy Liền Thoải Mái", 5532306.7331466490402839502961m, 4520799.005405636750000m, 243, "Kích thước: XL, S, L. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 94, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1946), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Nike Áo Len Thời Thượng", 4506426.6499392910842413709150m, 3221212.12725846650000m, 48, "Kích thước: S, XL, L. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 148, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1974), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Gucci Quần Jogger Thoải Mái", 3466758.7449241053956435747513m, 2971570.50339217250000m, 199, "Kích thước: XL, XXL, M. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 99, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2002), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "H&M Quần Short Thời Thượng", 2616247.5213720099336483274765m, 2222247.440739264350000m, 464, "Kích thước: XL, S, L. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 143, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2030), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Zara Váy Liền Thời Thượng", 744811.80540022378024760266936m, 548007.351855104300000m, 128, "Kích thước: XL, XS, S. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 174, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2084), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "H&M Áo Sơ Mi Cổ Điển", 1793058.7309136291558929799063m, 1331399.273951147450000m, 452, "Kích thước: XL, L, S. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 148, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2111), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Nike Váy Liền Trẻ Trung", 5560728.7996360893911073312608m, 4323556.192602384050000m, 62, "Kích thước: M, XL, S. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 144, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2139), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Nike Áo Len Sang Trọng", 3199112.2808103106858678906750m, 2634273.604377741650000m, 251, "Kích thước: M, XS, S. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 119, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2189), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Zara Áo Len Thời Thượng", 3274404.3416525308374016700396m, 2475271.076312796800000m, 200, "Kích thước: S, M, L. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 189, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2218), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Sơ Mi Thời Thượng", 1136460.5126458010058635299772m, 854341.534816333250000m, 225, "Kích thước: XXL, XL, S. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 13, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2248), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Nike Quần Jogger Thời Thượng", 6508908.9314873154309964810387m, 4367418.647179233200000m, 305, "Kích thước: XL, S, XS. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 16, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2276), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp dạo phố", "Louis Vuitton Áo Len Cổ Điển", 3223087.3474514588214679438988m, 2468902.735520570750000m, 334, "Kích thước: L, XL, M. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 129, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2320), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "H&M Quần Jean Trẻ Trung", 6585912.5306576255303480886159m, 4884632.685717454400000m, 337, "Kích thước: XXL, XL, XS. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 192, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2349), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Đầm Dạ Hội Thoải Mái", 397935.75600127247589046311973m, 299363.198713445300000m, 259, "Kích thước: XS, S, XL. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 50, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2378), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "H&M Váy Liền Thoải Mái", 2380086.1610820003807785305138m, 1682456.979099164900000m, 290, "Kích thước: XXL, XS, S. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 113, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2407), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Váy Liền Thoải Mái", 514584.58232977783135409972443m, 344911.6758176827700000m, 318, "Kích thước: M, XS, L. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 52, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2469), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Adidas Áo Sơ Mi Sang Trọng", 1418246.6050759583578779005682m, 1003201.877020622900000m, 490, "Kích thước: S, XXL, L. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 161, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2497), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "Zara Áo Thun Hiện Đại", 4246444.1780949009835198223772m, 3077702.862308276900000m, 466, "Kích thước: XXL, M, S. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 106, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2528), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "Nike Áo Thun Cổ Điển", 1176923.3033969270565118819541m, 914561.604836263400000m, 339, "Kích thước: L, XXL, S. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 180, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2555), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Gucci Quần Tây Cổ Điển", 3034451.2059806465690311138518m, 2507770.91215470650000m, 270, "Kích thước: XXL, S, XS. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 120, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2616), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Chanel Quần Tây Hiện Đại", 2929173.5818644111852539209801m, 2615375.914559046050000m, 433, "Kích thước: M, S, XL. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 55, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2645), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Sơ Mi Sang Trọng", 3821743.2949301632659270101612m, 3166230.169395013550000m, 433, "Kích thước: XL, S, L. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 16, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2674), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Zara Quần Jean Cổ Điển", 469732.45065358448496394601267m, 321948.6674264917700000m, 46, "Kích thước: XL, M, S. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 139, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2738), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Đầm Dạ Hội Cổ Điển", 4935408.2459099103244608434724m, 4448841.464216086250000m, 251, "Kích thước: XL, XXL, XS. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 60, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2769), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "H&M Quần Short Thoải Mái", 1585697.2146472674091679687285m, 1207869.515645849600000m, 465, "Kích thước: M, L, XXL. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 172, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2799), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Gucci Đầm Dạ Hội Hiện Đại", 579027.59638569603217848694171m, 404619.6300112979150000m, 195, "Kích thước: XS, M, XXL. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2827), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Chanel Quần Jean Hiện Đại", 4307049.9263870509418823225505m, 3063885.014538478850000m, 143, "Kích thước: XL, XXL, S. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 110, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2882), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Chanel Blazer Thời Thượng", 2365458.7725158041768120320492m, 1920154.007363645300000m, 421, "Kích thước: M, XXL, XL. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 128, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2912), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Quần Tây Năng Động", 3865388.2842552170077260497478m, 3021384.428027148650000m, 384, "Kích thước: L, XXL, M. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 175, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2941), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp thể thao", "Chanel Áo Khoác Thoải Mái", 2102819.9211532238074312885449m, 1526987.986685251700000m, 14, "Kích thước: S, M, XS. Màu sắc: Trắng, Đỏ" });
        }
    }
}
