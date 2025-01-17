using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManboShopAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatecategoriestable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "VariantValues");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Variants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentCategoryId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4767 Smitham Gateway, Murazikmouth, Guernsey", "cbb70c4f-6e96-4598-bef7-0e672b000b2c", new DateTime(2024, 4, 21, 20, 46, 56, 777, DateTimeKind.Utc).AddTicks(4043), "Karlie_Watsica46@gmail.com", "Karlie", "Watsica", "KARLIE_WATSICA46@GMAIL.COM", "KARLIE_WATSICA", "AQAAAAIAAYagAAAAEGTZ4PDXk7CqTTJoOzdoQQQ4+UjiIqNMGR5AQeYbeJmj84Ht/ZsisXaONeA/L297SA==", "933-271-5858", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1009.jpg", "Karlie_Watsica" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8008 Joannie Causeway, Murrayshire, Somalia", "486ea800-1e06-48b7-9c1a-773779cfc96b", new DateTime(2024, 7, 6, 20, 46, 56, 778, DateTimeKind.Utc).AddTicks(8483), "Derrick_Ullrich37@gmail.com", "Derrick", "Ullrich", "DERRICK_ULLRICH37@GMAIL.COM", "DERRICK_ULLRICH", "AQAAAAIAAYagAAAAEBdyqPCth1ThPznWMorgyRjmMRYMBCn3oekvOv7Cl1EU8pVrNslb3reFLUEZzXBgxQ==", "195-273-2173", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/672.jpg", "Derrick_Ullrich" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "90868 Reichert Keys, Port Brauliotown, Finland", "02c87541-3705-4621-baca-6490e9e8030e", new DateTime(2024, 3, 29, 20, 46, 56, 778, DateTimeKind.Utc).AddTicks(9058), "Urban.Hudson@yahoo.com", "Urban", "Hudson", "URBAN.HUDSON@YAHOO.COM", "URBAN81", "AQAAAAIAAYagAAAAECe4zk5SxjzqDC6YIeNImGW9a7VAlBeWrE96l9STXM/cfMmM6XmCoeTplgLHRhikeg==", "470-209-6954", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/870.jpg", "Urban81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "89556 Enos Fields, North Vincenzachester, Grenada", "ac0548fe-9a8c-46a8-989c-938b91ca5851", new DateTime(2024, 4, 4, 20, 46, 56, 778, DateTimeKind.Utc).AddTicks(9314), "Levi_Rolfson13@gmail.com", "Levi", "Rolfson", "LEVI_ROLFSON13@GMAIL.COM", "LEVI.ROLFSON", "AQAAAAIAAYagAAAAECwRW5kNw985beAwcK8hF2oGVGmMzXVwpo4/wmXF4iVWU2ZxXd4G5p3JAM5ECKY8Mw==", "401-743-4981", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/782.jpg", "Levi.Rolfson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "094 Fanny Keys, Albertville, Samoa", "e387f8fe-ad79-49d4-abf5-a5e2cbda5eef", new DateTime(2024, 3, 3, 20, 46, 56, 778, DateTimeKind.Utc).AddTicks(9505), "Mallory_Kuhn42@yahoo.com", "Mallory", "Kuhn", "MALLORY_KUHN42@YAHOO.COM", "MALLORY9", "AQAAAAIAAYagAAAAEO7PlcTvxTxr5M78d2B+YRVeiED1ZD5gVhtMJs7X4ddN3A1c8KJNrk/hFhdJM5RlGw==", "143-297-6361", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/884.jpg", "Mallory9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "79038 Veum Extensions, Lake Eulah, Guam", "2058d21c-5b82-4a69-8e95-fd4121b59309", new DateTime(2024, 11, 11, 20, 46, 56, 778, DateTimeKind.Utc).AddTicks(9736), "Marcelina.Wintheiser48@yahoo.com", "Marcelina", "Wintheiser", "MARCELINA.WINTHEISER48@YAHOO.COM", "MARCELINA79", "AQAAAAIAAYagAAAAED6VnJ9iptMDYBV+SbpFsJ/Oyu6KLRCbfoSoypmTiV6ZFWK1ldBf/ysrKNR6Y6BM8A==", "049-138-8846", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/731.jpg", "Marcelina79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "65527 Aliza Lights, Macejkovicville, Chile", "75c56e73-1fcc-46d1-8229-1cdb9a711106", new DateTime(2024, 6, 1, 20, 46, 56, 778, DateTimeKind.Utc).AddTicks(9944), "Duane_Tremblay64@yahoo.com", "Duane", "Tremblay", "DUANE_TREMBLAY64@YAHOO.COM", "DUANE_TREMBLAY30", "AQAAAAIAAYagAAAAEJZekVDZ+8JnBFPm+uU8kHfjKHFmbRMqDNN32kca/X0UQQg6AwfqZpv2+kx+pZre+A==", "731-190-1386", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/336.jpg", "Duane_Tremblay30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "899 Kemmer Landing, Lake Breanne, Wallis and Futuna", "3af5ee4b-d5a8-4422-812d-f4c7a62fbff4", new DateTime(2024, 12, 22, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(164), "Rosemary_White@gmail.com", "Rosemary", "White", "ROSEMARY_WHITE@GMAIL.COM", "ROSEMARY25", "AQAAAAIAAYagAAAAECPnF8AZouaxA3E+eDyMzWRlFRiHuxFbm4owiM8gZME+18xJDs+wpNWnO2BD/XonoA==", "419-469-3016", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/963.jpg", "Rosemary25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "134 Braeden Manor, Lake Beverlyshire, Honduras", "2b9d7645-9dfa-41d4-856d-fc846cf2011f", new DateTime(2024, 3, 11, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(372), "Emmalee40@gmail.com", "Emmalee", "Hodkiewicz", "EMMALEE40@GMAIL.COM", "EMMALEE_HODKIEWICZ", "AQAAAAIAAYagAAAAEOPBsZMBF7ze7dJCUz6zAuuUnQeY7S2vDDrxXkldEGqegICde2B8/wbPp0tL8d/9iA==", "997-737-9718", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/219.jpg", "Emmalee_Hodkiewicz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "05293 Ellie Passage, Derektown, New Zealand", "568912ae-f5e0-48f5-a910-e3aa0ef7ede3", new DateTime(2024, 3, 22, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(586), "Stefan.Dickens23@yahoo.com", "Stefan", "Dickens", "STEFAN.DICKENS23@YAHOO.COM", "STEFAN.DICKENS", "AQAAAAIAAYagAAAAEBy50Gmriw8jCM522SEvjDFOMiElnldRwe3456DAZwa/NaIM0fqLpzYnKBa6tSzgjA==", "847-204-1218", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/633.jpg", "Stefan.Dickens" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "59207 Tromp Lane, New Jaydonstad, Macedonia", "823a3d48-b921-418a-8602-856e0f372f23", new DateTime(2024, 3, 4, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(773), "Ole.Heaney@gmail.com", "Ole", "Heaney", "OLE.HEANEY@GMAIL.COM", "OLE_HEANEY86", "AQAAAAIAAYagAAAAEA9pMxbAnJuOPrvSDWuSZMmZwExSh4mgXxKOR0E+PmAmIxfJXEqiChuev0RPspPDaQ==", "580-061-1390", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/398.jpg", "Ole_Heaney86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "311 Considine Lodge, Johnathanland, Nicaragua", "8a395060-ff77-4f97-9222-8262dd6726e4", new DateTime(2024, 4, 23, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(983), "Rosario_Rippin24@gmail.com", "Rosario", "Rippin", "ROSARIO_RIPPIN24@GMAIL.COM", "ROSARIO.RIPPIN", "AQAAAAIAAYagAAAAELuG0bPJ2tK8wDPQgL1pTIWY0NJJ3sq1UjMPrKCszK6g63BrNY4p+WTfDr5KUnJO1A==", "155-000-5739", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/771.jpg", "Rosario.Rippin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "506 Gottlieb Route, Maudieton, Rwanda", "0ae28bb7-7bd7-4caf-9e84-74964c5776b2", new DateTime(2024, 5, 13, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(1190), "Elsie75@gmail.com", "Elsie", "Johns", "ELSIE75@GMAIL.COM", "ELSIE.JOHNS", "AQAAAAIAAYagAAAAEOd81xfKNk8hF9uuo9xUBmaQEzX4n0CLJav32dHlS27rUv0bS0a0KH/zrwfGUL/Mdw==", "512-943-9498", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1144.jpg", "Elsie.Johns" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "54244 Sauer Branch, Jadafurt, Uzbekistan", "7ca9c423-d9ef-4254-9208-8a48d42ca285", new DateTime(2024, 2, 29, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(1404), "Leslie.Leannon@hotmail.com", "Leslie", "Leannon", "LESLIE.LEANNON@HOTMAIL.COM", "LESLIE_LEANNON", "AQAAAAIAAYagAAAAEIwAzCe7P8yjQcPQIoCHeW4j76QDWbE1EUOY9NcLjwra9osPOGZ58z+vnAZ26Lpn0A==", "591-401-1781", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1156.jpg", "Leslie_Leannon" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "530 Charity Overpass, Gretatown, Macedonia", "329b6e6e-a2ad-4be3-955d-1fdbcfef5e41", new DateTime(2024, 2, 2, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(1590), "Jerel79@yahoo.com", "Jerel", "Baumbach", "JEREL79@YAHOO.COM", "JEREL_BAUMBACH15", "AQAAAAIAAYagAAAAEAOsgRg/jQDswv/hJcX0OLt3Riy1j+2LUMb0d3CTo1Ym8C1rby0ykY7oJ0FN7YFc5A==", "551-270-3116", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/617.jpg", "Jerel_Baumbach15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2511 Breanne Ridges, Hoegerborough, United Kingdom", "16b946b4-70d0-44bf-b72a-afbae352fc6c", new DateTime(2025, 1, 10, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(1793), "Shakira.Brakus@hotmail.com", "Shakira", "Brakus", "SHAKIRA.BRAKUS@HOTMAIL.COM", "SHAKIRA78", "AQAAAAIAAYagAAAAECwKZk25Pq4303KUyt5QyKfWuZC7lTOR6tXLmsombu5bssmPXim32QA4mOrlRM1Cdg==", "627-237-3915", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/205.jpg", "Shakira78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "004 Ruthie Lock, East Roryberg, Cote d'Ivoire", "289ee855-839c-4455-b5d0-1ce4027677e4", new DateTime(2024, 9, 21, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(1967), "Katelin.Dicki21@hotmail.com", "Katelin", "Dicki", "KATELIN.DICKI21@HOTMAIL.COM", "KATELIN56", "AQAAAAIAAYagAAAAEFi1Pd0c8jBRlIP072U3OUze2fhHiNyyHyS1fP4QiYmuzeBZF6005FXmqZ+xjHNHXg==", "620-423-2424", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/853.jpg", "Katelin56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2812 Iliana Mission, East Rupertstad, Tonga", "957a8d6b-776e-4501-af3b-a859ba9dc6e6", new DateTime(2024, 4, 18, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(2188), "Shaina.Watsica@gmail.com", "Shaina", "Watsica", "SHAINA.WATSICA@GMAIL.COM", "SHAINA81", "AQAAAAIAAYagAAAAEHnX9ibUEguhEcoHQToi0gGKtD+1AUVlSoZE4mDdrSqPcQLAAXquSSzJL/saUMSdNw==", "909-863-5117", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1100.jpg", "Shaina81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "434 Baumbach Garden, West Danika, India", "9bf972ab-465f-44eb-b9a1-9b7fea9b2cbe", new DateTime(2024, 12, 29, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(2369), "Gabriella_Mohr88@hotmail.com", "Gabriella", "Mohr", "GABRIELLA_MOHR88@HOTMAIL.COM", "GABRIELLA50", "AQAAAAIAAYagAAAAEA1pV8oBwC6oa4m57mc9wLcKp8t7qt2WfSCVa3SOI0z07iacz2MiSLVm7DSPuuAGrw==", "322-672-6189", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1070.jpg", "Gabriella50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2356 Williamson Lodge, Carliechester, South Africa", "f730eaf4-d6e8-4e67-88a8-1c83576a399e", new DateTime(2024, 12, 28, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(2562), "Macy86@yahoo.com", "Macy", "Nader", "MACY86@YAHOO.COM", "MACY.NADER", "AQAAAAIAAYagAAAAEEzvgdHJOeGidAZFHJkrbzXg/jMsB3ZtRURdpDzoSAQHkWVYV0mwm9jGFKnoKSMVmw==", "431-179-7915", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/339.jpg", "Macy.Nader" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1651 Loy Hill, Lake Jessbury, Switzerland", "3e98f40a-40cd-46f1-bbbe-bdb15b143d4d", new DateTime(2024, 5, 15, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(2762), "Nora_Abshire62@yahoo.com", "Nora", "Abshire", "NORA_ABSHIRE62@YAHOO.COM", "NORA.ABSHIRE", "AQAAAAIAAYagAAAAEEvp/nu10d4kCzXL68ftD9GVfBuQ4zpKiiJGeVpKdu3mGUQSWmL7ms9e4Ste9/qr4A==", "047-776-8869", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/548.jpg", "Nora.Abshire" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9649 Beier Walk, Strackeport, Saint Pierre and Miquelon", "092ca5b9-1f9d-4df7-97b2-253bccb7c9aa", new DateTime(2024, 1, 25, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(2979), "Ubaldo_Farrell40@hotmail.com", "Ubaldo", "Farrell", "UBALDO_FARRELL40@HOTMAIL.COM", "UBALDO.FARRELL34", "AQAAAAIAAYagAAAAEMXV/NwC43LsJ4l2dLE8Y5drJF+dd4eOQ3FZKzywG7KxWPWSvpRa3nkosM4GpJ1lMA==", "196-079-0962", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/16.jpg", "Ubaldo.Farrell34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "33638 Therese Harbors, McKenziebury, Paraguay", "133599ea-9dda-4414-b05a-4d7b09891b14", new DateTime(2024, 3, 27, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(3154), "Bethel_Schaden@gmail.com", "Bethel", "Schaden", "BETHEL_SCHADEN@GMAIL.COM", "BETHEL95", "AQAAAAIAAYagAAAAEFCztgqx2pIy+76XDWpJdKVki1O7rc1xp7wiBex1pfzuhc/VzfDa0g7AlzHjmJ1ybQ==", "032-068-7919", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/96.jpg", "Bethel95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6648 Antonietta Crest, Danielmouth, Turks and Caicos Islands", "ef4df2b8-c892-44f1-bfbe-9f421328e615", new DateTime(2024, 6, 14, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(3356), "Soledad_Shields@yahoo.com", "Soledad", "Shields", "SOLEDAD_SHIELDS@YAHOO.COM", "SOLEDAD.SHIELDS", "AQAAAAIAAYagAAAAEAtt5Slx7w/zXcOnarhou1Bn56Z4s/gNcczgZrBZC/L14/+gQtflLlyp4diwnQVpIg==", "862-849-8764", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/542.jpg", "Soledad.Shields" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "24688 Hayes Vista, Lake Katarinaburgh, Montenegro", "fa662cbc-11be-4edf-9fc4-a4bcc3bb2f35", new DateTime(2024, 7, 2, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(3529), "Lloyd72@hotmail.com", "Lloyd", "Wolff", "LLOYD72@HOTMAIL.COM", "LLOYD.WOLFF", "AQAAAAIAAYagAAAAEMUcvBCM40UtT1ajVPCaJWTwolkj85DPW7tbKDPsffDicCqPUFWq+4yr9ruj5xshfg==", "498-656-8417", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/223.jpg", "Lloyd.Wolff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "80228 Magdalena Ranch, New Americoville, Martinique", "615493b9-4a2f-4dcc-a687-06d9947e0e16", new DateTime(2024, 4, 20, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(3753), "Donald.Gottlieb@gmail.com", "Donald", "Gottlieb", "DONALD.GOTTLIEB@GMAIL.COM", "DONALD_GOTTLIEB", "AQAAAAIAAYagAAAAEN4d4EJtlAGGiOafekFHvaPwdRuUQptmC0k7rALQtijmF8j+hwplldXtu4DaOkQVSA==", "593-934-1199", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1197.jpg", "Donald_Gottlieb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3862 Robert Prairie, South Jeffrychester, Pitcairn Islands", "9a101e4f-dac2-41a7-b291-24216b69118d", new DateTime(2024, 12, 22, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(3989), "Bernadine.Dietrich27@gmail.com", "Bernadine", "Dietrich", "BERNADINE.DIETRICH27@GMAIL.COM", "BERNADINE84", "AQAAAAIAAYagAAAAECtcJ19T9eu0GIX9Rm2zjjChU+NibFIo6tBaHKv9YBjxTc8BjV3YGF2AIljcm1yRaw==", "081-516-8086", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/501.jpg", "Bernadine84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9438 Klein Mill, Meggieland, Turkmenistan", "8eba0201-09fd-40b4-ba25-43572fdbac62", new DateTime(2024, 8, 14, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(4173), "Hanna_Rutherford60@gmail.com", "Hanna", "Rutherford", "HANNA_RUTHERFORD60@GMAIL.COM", "HANNA89", "AQAAAAIAAYagAAAAEF44Uc3bRWNRhbtWgVgJho7SJ2Stzm/rkb9xw0jprYrgZA1SR7QEq1+C1lsOuU1ABg==", "920-155-0572", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/118.jpg", "Hanna89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "214 Metz Forest, West Deloresstad, New Caledonia", "a2ffc6cd-ba71-4836-bcef-19036a792ef1", new DateTime(2024, 5, 20, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(4378), "Camron.Stroman@gmail.com", "Camron", "Stroman", "CAMRON.STROMAN@GMAIL.COM", "CAMRON.STROMAN", "AQAAAAIAAYagAAAAED/zdZK7wOitd/2nuyUMurc+AqldV5xKoYyjonQ85mwwuLyl+Ga9QfSvtjJ6Di7+9g==", "104-606-7450", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/24.jpg", "Camron.Stroman" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2211 Cole Plain, Eileenside, Chile", "516614d3-259f-4564-a1ad-91bec1f1451b", new DateTime(2024, 5, 9, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(4555), "Zackary.Schultz@hotmail.com", "Zackary", "Schultz", "ZACKARY.SCHULTZ@HOTMAIL.COM", "ZACKARY.SCHULTZ4", "AQAAAAIAAYagAAAAEJqjeL5gVGJu08blGaezIK1kVdk9u9k0iBTKOiJZ1iZIUsr8vTruyZ8aLTdVHbh5mg==", "273-787-2089", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1213.jpg", "Zackary.Schultz4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0449 Ullrich Prairie, Lake Fridamouth, Andorra", "ba6e7b32-3f3e-40eb-814a-ffcd0bf80154", new DateTime(2024, 2, 10, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(4748), "Lenora8@gmail.com", "Lenora", "Schumm", "LENORA8@GMAIL.COM", "LENORA.SCHUMM", "AQAAAAIAAYagAAAAEMvHBsFK4m8TdTCBvKIyMyn9k8JaYvMR+ww4xeHd5rw2bariPEZCim5fDJ+OqSR8DA==", "945-128-2668", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/595.jpg", "Lenora.Schumm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0261 Alden Courts, North Marcelo, Saint Barthelemy", "486c6a71-8b1e-4bbb-8de9-f7665fa8302d", new DateTime(2024, 8, 11, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(4928), "Olen26@yahoo.com", "Olen", "Jakubowski", "OLEN26@YAHOO.COM", "OLEN.JAKUBOWSKI", "AQAAAAIAAYagAAAAEMl8TJjekR4xIUdoQlidqQl/YUiLw43zrysVMG37XWzb3wEjeprHsawNW/CZWIx/gg==", "367-655-4264", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/905.jpg", "Olen.Jakubowski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "917 Kohler Coves, Lilianachester, Azerbaijan", "9fe5009c-0fca-4aab-816c-6f6d8ff3badc", new DateTime(2024, 2, 12, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(5206), "Delphine_Cruickshank53@hotmail.com", "Delphine", "Cruickshank", "DELPHINE_CRUICKSHANK53@HOTMAIL.COM", "DELPHINE.CRUICKSHANK", "AQAAAAIAAYagAAAAECROLxMADNghB+XgRVye5Bw65fPV6R+LFuT0+ih70Az2oWIsuTYiY+JMqaeBRwZbuQ==", "365-606-6091", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/143.jpg", "Delphine.Cruickshank" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "412 Bayer Plaza, West Stanford, Botswana", "4dec5a5f-1798-40f1-8c6f-b27c8764e743", new DateTime(2025, 1, 14, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(5362), "Saul62@gmail.com", "Saul", "Metz", "SAUL62@GMAIL.COM", "SAUL.METZ", "AQAAAAIAAYagAAAAEIaZLpkzxRPXxfgtioqAe2r4BV+CjQmHQn7yIBCkyUJzBXyQ5Xu/mDZqrf+ibqkv1w==", "312-914-3502", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/249.jpg", "Saul.Metz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "37771 Hills Walk, North Oswald, Timor-Leste", "71a70c36-a9eb-43b2-93c7-a4404895f5ad", new DateTime(2024, 7, 12, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(5553), "Celestino.Klocko@yahoo.com", "Celestino", "Klocko", "CELESTINO.KLOCKO@YAHOO.COM", "CELESTINO1", "AQAAAAIAAYagAAAAEJ0pz6RK00gBR/H2arlQLNiFirlRHZHuEK/W138aG6YQHfuhtXR/k1wc4LyRqqnyvQ==", "732-721-8948", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/994.jpg", "Celestino1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "96170 Smitham Station, Ratkeland, Paraguay", "00e78fcf-4a8d-49d3-88e7-fd04429db594", new DateTime(2024, 6, 17, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(5725), "Dasia.Bergnaum@gmail.com", "Dasia", "Bergnaum", "DASIA.BERGNAUM@GMAIL.COM", "DASIA_BERGNAUM", "AQAAAAIAAYagAAAAECJK5n1AHh/evSxctkW+9+6lN/SbaxsxbQ3DZmJK/vYwCqQT1R5UZKz4gGVT5H5yTA==", "930-180-9281", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1017.jpg", "Dasia_Bergnaum" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9214 Frami Turnpike, Port Bruceborough, Malaysia", "b10e543b-9787-4c6c-b416-8a84444af1e1", new DateTime(2024, 8, 20, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(5929), "Greyson19@gmail.com", "Greyson", "Will", "GREYSON19@GMAIL.COM", "GREYSON.WILL", "AQAAAAIAAYagAAAAEMARpwa4w5iqdj1+4dWkpHal37KaislxrHbDlApHngsocqfOKjf74pBOGDC9A65BSg==", "371-160-0399", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1196.jpg", "Greyson.Will" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8953 Durgan Mission, New Mortonborough, Taiwan", "34079b36-2ece-4af0-b0e9-f9ba335573a1", new DateTime(2024, 3, 21, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(6108), "Alta.Dach57@yahoo.com", "Alta", "Dach", "ALTA.DACH57@YAHOO.COM", "ALTA.DACH", "AQAAAAIAAYagAAAAENgNKkP0/xWlCLW59hMBpsmANSO/9g8QFWjS4ZibDMmcu1arMUCuw+uvconNpSzGIw==", "084-447-0976", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/953.jpg", "Alta.Dach" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "620 Gislason Mountain, Loybury, Guinea", "038a9137-3209-48a4-9eaf-65e35100090a", new DateTime(2024, 2, 14, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(6301), "Kobe28@yahoo.com", "Kobe", "Collins", "KOBE28@YAHOO.COM", "KOBE.COLLINS", "AQAAAAIAAYagAAAAEBK2tcreEuryqVPYywoZu6ekI8sK+XvrqsSSpKEB6LjHPsUQi2kfZgRGV/lqfaCdEw==", "697-043-2700", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/499.jpg", "Kobe.Collins" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "018 Eldred Locks, Jeffmouth, Guadeloupe", "66d2269e-6821-432a-872d-0c62317e9135", new DateTime(2024, 11, 3, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(6479), "Nickolas59@yahoo.com", "Nickolas", "Maggio", "NICKOLAS59@YAHOO.COM", "NICKOLAS_MAGGIO39", "AQAAAAIAAYagAAAAEOJVrAoMgHBI4f5oxJ2AE+UGOiud2HKueWHXfOs5FchWgoMpa6uMuYlRGM1lX8Cemw==", "194-106-3371", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/307.jpg", "Nickolas_Maggio39" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentCategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "ParentCategoryId",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "VariantValues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3012), "https://example.com/images/men-clothing.jpg", "Men's Clothing", null },
                    { 2, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3484), "https://example.com/images/women-clothing.jpg", "Women's Clothing", null },
                    { 3, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3485), "https://example.com/images/children-clothing.jpg", "Children's Clothing", null },
                    { 4, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3487), "https://example.com/images/shoes.jpg", "Shoes", null },
                    { 5, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3488), "https://example.com/images/bags.jpg", "Bags", null },
                    { 6, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3490), "https://example.com/images/accessories.jpg", "Accessories", null },
                    { 7, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3491), "https://example.com/images/watches.jpg", "Watches", null },
                    { 8, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3492), "https://example.com/images/sportswear.jpg", "Sportswear", null },
                    { 9, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3493), "https://example.com/images/swimwear.jpg", "Swimwear", null },
                    { 10, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3494), "https://example.com/images/formal-wear.jpg", "Formal Wear", null },
                    { 11, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3495), "https://example.com/images/casual-wear.jpg", "Casual Wear", null },
                    { 12, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3496), "https://example.com/images/t-shirts.jpg", "T-Shirts", null },
                    { 13, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3497), "https://example.com/images/jeans.jpg", "Jeans", null },
                    { 14, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3498), "https://example.com/images/jackets-coats.jpg", "Jackets & Coats", null },
                    { 15, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3499), "https://example.com/images/hats-caps.jpg", "Hats & Caps", null },
                    { 16, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3500), "https://example.com/images/scarves.jpg", "Scarves", null },
                    { 17, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3501), "https://example.com/images/sunglasses.jpg", "Sunglasses", null },
                    { 18, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3502), "https://example.com/images/belts.jpg", "Belts", null },
                    { 19, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3503), "https://example.com/images/undergarments.jpg", "Undergarments", null },
                    { 20, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3504), "https://example.com/images/sports-shoes.jpg", "Sports Shoes", null },
                    { 21, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3505), "https://example.com/images/boots.jpg", "Boots", null },
                    { 22, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3506), "https://example.com/images/high-heels.jpg", "High Heels", null },
                    { 23, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3507), "https://example.com/images/sneakers.jpg", "Sneakers", null },
                    { 24, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3508), "https://example.com/images/suits.jpg", "Suits", null },
                    { 25, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3508), "https://example.com/images/dresses.jpg", "Dresses", null },
                    { 26, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3509), "https://example.com/images/blouses.jpg", "Blouses", null },
                    { 27, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3510), "https://example.com/images/skirts.jpg", "Skirts", null },
                    { 28, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3511), "https://example.com/images/shorts.jpg", "Shorts", null },
                    { 29, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3512), "https://example.com/images/pajamas.jpg", "Pajamas", null },
                    { 30, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3513), "https://example.com/images/outerwear.jpg", "Outerwear", null },
                    { 31, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3514), "https://example.com/images/activewear.jpg", "Activewear", null },
                    { 32, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3515), "https://example.com/images/raincoats.jpg", "Raincoats", null },
                    { 33, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3516), "https://example.com/images/cardigans.jpg", "Cardigans", null },
                    { 34, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3517), "https://example.com/images/sweaters.jpg", "Sweaters", null },
                    { 35, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3518), "https://example.com/images/leggings.jpg", "Leggings", null },
                    { 36, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3519), "https://example.com/images/tracksuits.jpg", "Tracksuits", null },
                    { 37, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3520), "https://example.com/images/gloves.jpg", "Gloves", null },
                    { 38, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3521), "https://example.com/images/socks.jpg", "Socks", null },
                    { 39, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3522), "https://example.com/images/loungewear.jpg", "Loungewear", null },
                    { 40, new DateTime(2025, 1, 4, 11, 1, 3, 562, DateTimeKind.Utc).AddTicks(3523), "https://example.com/images/winter-wear.jpg", "Winter Wear", null }
                });
        }
    }
}
