using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class updateproducttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SlugName",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6685 Kiehn Track, Gennaroside, Switzerland", "96989079-2580-4793-9c26-536ef1dd7731", new DateTime(2024, 5, 27, 6, 1, 0, 30, DateTimeKind.Utc).AddTicks(1900), "Rodrigo_Bergstrom11@gmail.com", "Rodrigo", "Bergstrom", "RODRIGO_BERGSTROM11@GMAIL.COM", "RODRIGO36", "AQAAAAIAAYagAAAAEDFmmNk7vOvoB+6w7kD+G892i8VThfMs7IvfAZ2WzS9sar3hYMQQRcHWJIDd4NdIUw==", "404-985-0063", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1195.jpg", "Rodrigo36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "22924 Parker Track, West Alenefurt, Gambia", "f43ac615-1e01-4cc7-88b8-aaa384cd18c0", new DateTime(2024, 3, 6, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(841), "Quinten.McKenzie14@hotmail.com", "Quinten", "McKenzie", "QUINTEN.MCKENZIE14@HOTMAIL.COM", "QUINTEN.MCKENZIE22", "AQAAAAIAAYagAAAAEMoXz1tb+bG/RxFIwfrPnu2tQYEDnSZlB4l3BMKSy48zHRuzjkXsHM4sn3HzFDG6Dw==", "723-428-9810", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/551.jpg", "Quinten.McKenzie22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8060 Selmer Shoal, Lake Destin, Tokelau", "5823d6ab-5cef-4c59-baec-0f13d6ef6469", new DateTime(2024, 8, 3, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(1538), "Trent_Pfannerstill39@hotmail.com", "Trent", "Pfannerstill", "TRENT_PFANNERSTILL39@HOTMAIL.COM", "TRENT_PFANNERSTILL", "AQAAAAIAAYagAAAAEKMlMrmKnEK1sN0PTf8e/aiEKp0zDsJsa/la4eutKkHpBNlJyH7ONU33GMi+U17M4Q==", "432-001-9323", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1245.jpg", "Trent_Pfannerstill" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "954 Mueller Corner, Port Beulah, Somalia", "50a08e5e-58b2-4c85-87ea-0c9bb96f182a", new DateTime(2025, 1, 7, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(1970), "Patricia35@hotmail.com", "Patricia", "Watsica", "PATRICIA35@HOTMAIL.COM", "PATRICIA_WATSICA", "AQAAAAIAAYagAAAAECi96GiKyedOZpGSZ3UmPpsQXVRfXS3rJq0DIyaJCCCdrkt5azUSPD31uMYMGgwKBQ==", "918-789-8432", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/963.jpg", "Patricia_Watsica" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "673 Jared Views, Isabellaville, Egypt", "20fd8321-3074-4443-9415-c436796e130a", new DateTime(2024, 9, 11, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(2385), "Rachelle91@gmail.com", "Rachelle", "Brekke", "RACHELLE91@GMAIL.COM", "RACHELLE.BREKKE", "AQAAAAIAAYagAAAAEAIYFmvgeCUJ/HmYCHXB8OHVkr6bgGD/Y6zBOEirN/BQayEyRv+aOIxJMqTWGnbSQg==", "008-194-9229", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/865.jpg", "Rachelle.Brekke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "66356 Deckow Lock, Olsonchester, Martinique", "6a601123-575d-4952-ae44-c711343c324d", new DateTime(2024, 9, 4, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(2776), "Herbert69@yahoo.com", "Herbert", "Schinner", "HERBERT69@YAHOO.COM", "HERBERT_SCHINNER85", "AQAAAAIAAYagAAAAEDqAI4IrPAxmxk3LzQATB0/TDGt8keoodScY85XZdzijcR9pWENLbaDozZagiD+UsQ==", "742-283-0856", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/397.jpg", "Herbert_Schinner85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "816 Wisozk Lakes, New Enos, Martinique", "2e12396b-aa0d-4eb9-a60e-41ec17b3839a", new DateTime(2024, 3, 30, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(3164), "Isidro60@hotmail.com", "Isidro", "Koss", "ISIDRO60@HOTMAIL.COM", "ISIDRO.KOSS", "AQAAAAIAAYagAAAAELmpcX7AnNP4PsGnS+2Y2Iz2S9LW9NFIstzWZJTlo1NoXkESqVnQi+niv0pbAR5ZCg==", "974-980-7925", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1033.jpg", "Isidro.Koss" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9402 MacGyver Valley, East Martine, French Guiana", "ba12706c-66f0-43d4-8102-12e81d3b1d42", new DateTime(2024, 2, 26, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(3488), "Ines_Legros@yahoo.com", "Ines", "Legros", "INES_LEGROS@YAHOO.COM", "INES.LEGROS18", "AQAAAAIAAYagAAAAEF3t0ku0naNgxR/Vv1j+T190BG+Ht2eLN2HzX3wNGeL8bKoyyHBy68D9DMKEnRhmOA==", "250-020-5360", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/724.jpg", "Ines.Legros18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7631 Schneider Burgs, New Frankiemouth, Nepal", "a2f50250-37d6-4f19-adb7-4733cf179bee", new DateTime(2024, 6, 13, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(3893), "Samara.Waelchi95@yahoo.com", "Samara", "Waelchi", "SAMARA.WAELCHI95@YAHOO.COM", "SAMARA79", "AQAAAAIAAYagAAAAEHetUP8qjxtdxCbxQvf+8lLX274y/kRFFEcIv7TLBLDnjFLyYEhCVxF9VntQbbIXLQ==", "747-871-3902", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/348.jpg", "Samara79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "239 Yazmin Creek, Aurelieside, Reunion", "3f8e3c13-49ab-4720-964d-a356cb9344a9", new DateTime(2024, 5, 10, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(4312), "Rocky_MacGyver49@yahoo.com", "Rocky", "MacGyver", "ROCKY_MACGYVER49@YAHOO.COM", "ROCKY57", "AQAAAAIAAYagAAAAEJDa8psKu+juNJTQveSllvJlSd//MTUhFNSAJgjm7Sal68lSmGyaLOV5oeK82Va2VA==", "550-177-0300", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/521.jpg", "Rocky57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "969 Leonora Drive, East Thalia, Bouvet Island (Bouvetoya)", "e660bf6b-144d-4536-b0e3-2505ec9e728f", new DateTime(2024, 9, 3, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(4700), "Douglas70@gmail.com", "Douglas", "Miller", "DOUGLAS70@GMAIL.COM", "DOUGLAS.MILLER28", "AQAAAAIAAYagAAAAEC6GoMfxUfkfmfuRQyxdgRpVoIn5ylATiOXr48d3nV4xFZuBiBoRkhBkUGTw842RCA==", "961-370-7564", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/612.jpg", "Douglas.Miller28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "12962 Tatyana Path, Gorczanyport, Iraq", "efc02d55-f57d-47bb-a7e0-e0ec2b1d234f", new DateTime(2024, 5, 20, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(5033), "Dorian.Swift38@gmail.com", "Dorian", "Swift", "DORIAN.SWIFT38@GMAIL.COM", "DORIAN44", "AQAAAAIAAYagAAAAEFbUy1BK9xT14+awMq9uK8fmX5df8QPsG3UNuK7PZneQg3V6kbgD9vBXUOCnGgEauw==", "285-346-5266", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/353.jpg", "Dorian44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "191 Rosalind Roads, Marcoshaven, Niue", "8120891f-c760-48f6-815c-d8ee67d80cbd", new DateTime(2024, 7, 3, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(5397), "Daryl.Murray75@yahoo.com", "Daryl", "Murray", "DARYL.MURRAY75@YAHOO.COM", "DARYL_MURRAY92", "AQAAAAIAAYagAAAAEDQGERFdgDA4JiwZg5ZyuetMKPMZnL7Ep7XkpWEU3A4PcLiSknDik04GcuUyJNAzHQ==", "254-624-4957", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/751.jpg", "Daryl_Murray92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "57484 Tre Coves, South Archibaldtown, Sweden", "80a29243-e0b5-4344-9fe1-06b8ede6b06e", new DateTime(2024, 2, 14, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(5732), "Blanca_Rau54@gmail.com", "Blanca", "Rau", "BLANCA_RAU54@GMAIL.COM", "BLANCA50", "AQAAAAIAAYagAAAAECY2FTtHPpcggvJZpyUooByJGIom5wpTT+UPSKQCXYL3tPPy6V1gDuewcxC6Ce3nMw==", "527-463-2941", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/354.jpg", "Blanca50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4578 Gaylord Corner, Kington, Wallis and Futuna", "f08addb4-ee86-4995-920b-5fce9db75725", new DateTime(2024, 6, 3, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(6201), "Michale8@gmail.com", "Michale", "Ziemann", "MICHALE8@GMAIL.COM", "MICHALE.ZIEMANN31", "AQAAAAIAAYagAAAAEMF+flXo4vsagzulhLi2For4CxTHDUpM4G7neSL0ipafduckAN9pP4KlUVmIRcD6uA==", "607-015-6329", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/94.jpg", "Michale.Ziemann31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "20692 Glennie Garden, Kayceechester, Spain", "bd83067e-acfb-4b46-9c94-eff774e33f6d", new DateTime(2024, 12, 18, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(6551), "Rosalia_Kunde49@yahoo.com", "Rosalia", "Kunde", "ROSALIA_KUNDE49@YAHOO.COM", "ROSALIA.KUNDE", "AQAAAAIAAYagAAAAEB0zdwJVX/WRRBUtE/WcndiIK4F9tgVIHNH5AaopGGXWFRPxIMGT0vOW7pYdFEqz+w==", "443-934-7288", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/941.jpg", "Rosalia.Kunde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7813 Alysa Expressway, North Jimmyburgh, Malta", "0e4b18b8-99c4-467c-9828-d6d97cfd3551", new DateTime(2024, 11, 1, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(6964), "Stephany.Wiegand@yahoo.com", "Stephany", "Wiegand", "STEPHANY.WIEGAND@YAHOO.COM", "STEPHANY.WIEGAND", "AQAAAAIAAYagAAAAEDsBYZHUOb5QFfz8a5Z9elyvPOcfJsFZ7BbsrRSmyunRpVTWb0Bn8KBWQ3JlE6asRQ==", "502-371-4070", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1018.jpg", "Stephany.Wiegand" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2548 King Rapids, Huelsville, Mozambique", "eb75d5d2-9917-49b5-a969-cd392810c074", new DateTime(2024, 4, 9, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(7284), "Toni55@hotmail.com", "Toni", "Stiedemann", "TONI55@HOTMAIL.COM", "TONI.STIEDEMANN", "AQAAAAIAAYagAAAAEJ5gyfQMMnkr8U1EIvfzm1GT5QjQgZXTgnTwJa+b0rHBJxOFOOEgKWw93QQeFbrLMA==", "411-456-4440", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/420.jpg", "Toni.Stiedemann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "142 Howell Crescent, North Jamal, Hong Kong", "3c0973da-e4d4-483c-b9e8-63f01636dbac", new DateTime(2024, 9, 23, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(7615), "Colton_Kulas@yahoo.com", "Colton", "Kulas", "COLTON_KULAS@YAHOO.COM", "COLTON96", "AQAAAAIAAYagAAAAEHuaSWVHxinChELXxVDFMyo+s9FImnP/wxQmU3hZIPxb/OxL/6OusUEjOquvA1CHag==", "449-982-3995", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1083.jpg", "Colton96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "134 Stracke Drive, Klockoton, France", "b304b037-7542-4953-9688-c7287b877afd", new DateTime(2024, 6, 19, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(7940), "Constance96@gmail.com", "Constance", "Purdy", "CONSTANCE96@GMAIL.COM", "CONSTANCE94", "AQAAAAIAAYagAAAAED/QIh/AnYYhUqq1kEsX/BqO5jvqkWGXeGH+f6b3V1WrRPFAO5aeCOZx5ZexeEG6Fg==", "760-386-1437", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/290.jpg", "Constance94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8000 Georgiana Loop, McDermottville, Czech Republic", "c34ed141-fa9a-45a4-8f14-227c34575c6a", new DateTime(2024, 11, 15, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(8305), "Loyce.Rogahn70@gmail.com", "Loyce", "Rogahn", "LOYCE.ROGAHN70@GMAIL.COM", "LOYCE.ROGAHN74", "AQAAAAIAAYagAAAAEEU5VUlzVUxbne46Qnqn8aBdQN6w837AjXMBTRSt01p3e5VaB0CeNirQeUYpONlPrg==", "339-161-6379", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1242.jpg", "Loyce.Rogahn74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1619 Koss Skyway, New Lelandchester, Canada", "97e4950b-573c-4f95-80f0-f8ef0e336f49", new DateTime(2024, 11, 14, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(8697), "Alexandre88@yahoo.com", "Alexandre", "Collier", "ALEXANDRE88@YAHOO.COM", "ALEXANDRE_COLLIER", "AQAAAAIAAYagAAAAEBOHuO8aaRQHbpToE3DuQf/ZeuDW8iEacLmR0k6iJULrgaqwHwTmiRrW5A+9rryf1A==", "545-359-6700", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/872.jpg", "Alexandre_Collier" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7055 Cole Island, North Ernaville, Peru", "74b59a95-42ce-4ee5-a614-88357788ee4c", new DateTime(2024, 8, 25, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(9028), "Sally51@yahoo.com", "Sally", "Bradtke", "SALLY51@YAHOO.COM", "SALLY59", "AQAAAAIAAYagAAAAEFZZxlNw34akZMGoN0kcMvGLGofIDs4FNbW0+juba6XnFkxgmFF7fQCHOWZa5zkMRg==", "254-175-4752", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1104.jpg", "Sally59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "88690 Jackeline Streets, East Deliaberg, Paraguay", "e88c68ec-5d80-4817-9d2e-f99617f148de", new DateTime(2024, 2, 24, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(9403), "Cleveland22@gmail.com", "Cleveland", "Powlowski", "CLEVELAND22@GMAIL.COM", "CLEVELAND.POWLOWSKI79", "AQAAAAIAAYagAAAAEHUlT9qWYRU/qzUrUXIKYDkEbfAFjyOgN1OGnOsP0Dms0QsbrRsCrLHG5KyZnAW0cg==", "110-609-8157", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/980.jpg", "Cleveland.Powlowski79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "29973 Krystel Ridges, Port Ella, Mongolia", "96a87260-fa01-493f-988e-56bfa9b317e1", new DateTime(2025, 1, 6, 6, 1, 0, 32, DateTimeKind.Utc).AddTicks(9744), "Antonia_Weimann@gmail.com", "Antonia", "Weimann", "ANTONIA_WEIMANN@GMAIL.COM", "ANTONIA94", "AQAAAAIAAYagAAAAEOvzvHjQ8GXp6RvimcjZc3XZguwsn4slROurOoNh2UwYSyWEJJi/HClXxi2IrLA//Q==", "074-197-5220", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/289.jpg", "Antonia94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2713 Pfannerstill Landing, New Cornell, Colombia", "f7a27a6e-100b-4a64-ab16-4ef1ecc4c0ba", new DateTime(2024, 8, 14, 6, 1, 0, 33, DateTimeKind.Utc).AddTicks(158), "Nakia70@hotmail.com", "Nakia", "Kihn", "NAKIA70@HOTMAIL.COM", "NAKIA83", "AQAAAAIAAYagAAAAEI8ikOJFaoHjRFfp642ZQprtSVUJEvJH1U82lTfzk2Bvh93SSUrsT2skDacXumXKgQ==", "921-796-6278", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/771.jpg", "Nakia83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "833 Langosh Corner, South Cora, Myanmar", "d964cc6e-6acd-4115-92a1-b06e1bf0e74f", new DateTime(2024, 5, 21, 6, 1, 0, 33, DateTimeKind.Utc).AddTicks(470), "Fay_Jast@yahoo.com", "Fay", "Jast", "FAY_JAST@YAHOO.COM", "FAY.JAST75", "AQAAAAIAAYagAAAAEDnYUp27BHe2X5pl+k2ZwPIfnxMrkQKpkB2cj2nl5yblo9UIxNTroaxErgPWSrD2+g==", "737-675-7001", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/849.jpg", "Fay.Jast75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2585 Watsica Mount, New Joesphstad, British Indian Ocean Territory (Chagos Archipelago)", "93fcff3a-d11b-4de5-a7c6-a8891edd5ba9", new DateTime(2024, 2, 12, 6, 1, 0, 33, DateTimeKind.Utc).AddTicks(839), "Jodie65@gmail.com", "Jodie", "Stehr", "JODIE65@GMAIL.COM", "JODIE62", "AQAAAAIAAYagAAAAEIwdfB6CiACtlusDHBYYn2lhON/aCw7CEWPceXgc82clccaVA5tJ52PUc8JhftTwhg==", "630-928-9611", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1211.jpg", "Jodie62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "860 Caden Court, Hendersonland, Israel", "0d5ebe02-c9f7-40d7-b01f-eb7fda72e500", new DateTime(2024, 5, 31, 6, 1, 0, 33, DateTimeKind.Utc).AddTicks(1199), "Kristopher_Abbott66@gmail.com", "Kristopher", "Abbott", "KRISTOPHER_ABBOTT66@GMAIL.COM", "KRISTOPHER.ABBOTT", "AQAAAAIAAYagAAAAEP9fpBXXH2mPp3uGNoz05VFJhRRN3s9LAbgjehdLhxPMFYLGR7qS0+LzrqdYAOJvXg==", "584-765-0050", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/642.jpg", "Kristopher.Abbott" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4792 Murphy Grove, Alexandroberg, Jordan", "33505a64-7195-4269-ad0b-51f118640c7b", new DateTime(2024, 4, 11, 6, 1, 0, 33, DateTimeKind.Utc).AddTicks(1563), "Lue33@gmail.com", "Lue", "Grimes", "LUE33@GMAIL.COM", "LUE_GRIMES91", "AQAAAAIAAYagAAAAEBfd0ify197RFKGMhmc02naot0es3f3OhY/ZvIuYRVcML4HZtWUxrvnO3s/8A6rY4g==", "216-219-8648", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1027.jpg", "Lue_Grimes91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9784 Tillman Summit, Quigleymouth, Haiti", "46aacfd8-3663-48fb-b1b2-fdf02b043287", new DateTime(2024, 10, 19, 6, 1, 0, 33, DateTimeKind.Utc).AddTicks(1935), "Madison.McLaughlin@yahoo.com", "Madison", "McLaughlin", "MADISON.MCLAUGHLIN@YAHOO.COM", "MADISON.MCLAUGHLIN", "AQAAAAIAAYagAAAAEHz4Eqsgy/GhovnWGauS/EmXF9wH9qa0llKlLRr6EHNI8gKgwYUpa6CsiBInTD3x/Q==", "907-596-1602", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/709.jpg", "Madison.McLaughlin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "00571 Arnaldo Forks, Talonview, Austria", "eea1ff80-8970-439f-8c34-797782659858", new DateTime(2024, 11, 24, 6, 1, 0, 34, DateTimeKind.Utc).AddTicks(5399), "Tre12@hotmail.com", "Tre", "O'Reilly", "TRE12@HOTMAIL.COM", "TRE_OREILLY74", "AQAAAAIAAYagAAAAEEsdjX/e93ZLhUhDvR+H1pBYFbR0rg17BmsB8+gyhjq+uBcrAVcuqmyFu7SIeiM+0A==", "152-090-6738", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/560.jpg", "Tre_OReilly74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "664 Fae Inlet, North Esmeralda, Netherlands", "13e53d91-3657-454b-991f-3f53546461ec", new DateTime(2024, 2, 19, 6, 1, 0, 34, DateTimeKind.Utc).AddTicks(5846), "Rubie_Walker86@yahoo.com", "Rubie", "Walker", "RUBIE_WALKER86@YAHOO.COM", "RUBIE_WALKER", "AQAAAAIAAYagAAAAEJ15864gwmNboDLg96oCLl98LEAF3AXbKOu1BF1duzWwF94NX5sWiobEoA95+swT2g==", "848-508-9264", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1024.jpg", "Rubie_Walker" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "257 Senger Ways, East Akeemfurt, Niue", "002c449b-e2f2-49e0-a59a-0aa946576d44", new DateTime(2024, 6, 4, 6, 1, 0, 34, DateTimeKind.Utc).AddTicks(6288), "Lorenz_Larson@gmail.com", "Lorenz", "Larson", "LORENZ_LARSON@GMAIL.COM", "LORENZ.LARSON", "AQAAAAIAAYagAAAAEAnJTSraW8xdB6iCtHi5Y23wnqpNtBWrQITHrrS921Uswwfo6pIsm2yOw7Enz9HDGw==", "493-098-9102", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/168.jpg", "Lorenz.Larson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "623 Zetta Roads, Strosinhaven, Democratic People's Republic of Korea", "6c826841-1605-4a02-8789-f742cc5a25c4", new DateTime(2024, 2, 9, 6, 1, 0, 34, DateTimeKind.Utc).AddTicks(6704), "Jaqueline_Ruecker@hotmail.com", "Jaqueline", "Ruecker", "JAQUELINE_RUECKER@HOTMAIL.COM", "JAQUELINE_RUECKER", "AQAAAAIAAYagAAAAENCKIBxail+wfevihWXs9IvIMtxNVewfE8r5svthtZlipzyFjqEfj5WG/oTjIa4IRw==", "645-647-5711", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1175.jpg", "Jaqueline_Ruecker" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "29894 Leuschke Haven, East Lorenzo, Belgium", "50fd2c58-e0d8-40b4-a634-b5d4c01783eb", new DateTime(2024, 12, 13, 6, 1, 0, 34, DateTimeKind.Utc).AddTicks(7203), "Roxanne22@gmail.com", "Roxanne", "Spencer", "ROXANNE22@GMAIL.COM", "ROXANNE_SPENCER47", "AQAAAAIAAYagAAAAECUUwz7GQ9w6zvmJUDnACSG8r9JlthZKdu6rJbS4kkuzuijYZ8EXEYgKQ+3r7ta4lA==", "930-578-0897", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/647.jpg", "Roxanne_Spencer47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "37708 Frami Meadow, Amiyaton, Tonga", "0a6876a4-b047-42c7-967b-b195b77c67cf", new DateTime(2024, 9, 15, 6, 1, 0, 34, DateTimeKind.Utc).AddTicks(7552), "Colin_Carroll@gmail.com", "Colin", "Carroll", "COLIN_CARROLL@GMAIL.COM", "COLIN.CARROLL86", "AQAAAAIAAYagAAAAEJRqoZlC4jqcecUEDFqBNPULUDtNJtJAwP+wmycqdodT61yfPrtTW8cYl+DxE2snmA==", "596-458-0672", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/735.jpg", "Colin.Carroll86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9278 Raynor Spur, North Braulio, Costa Rica", "e20f5d8b-43e4-47b8-b3e4-b48503844592", new DateTime(2024, 8, 7, 6, 1, 0, 34, DateTimeKind.Utc).AddTicks(7942), "Alexanne.McKenzie4@gmail.com", "Alexanne", "McKenzie", "ALEXANNE.MCKENZIE4@GMAIL.COM", "ALEXANNE.MCKENZIE", "AQAAAAIAAYagAAAAEOVp2wtJW1vWF0BX0+v1exCLjB2BQtrQu8JexcjLT2fKylh9hqLr6T/GJ6A417no+Q==", "548-357-2172", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1191.jpg", "Alexanne.McKenzie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "859 Wuckert Forges, Daltonton, Malaysia", "fcfeeff3-fc8f-4737-ac9b-90b02681bc78", new DateTime(2024, 4, 8, 6, 1, 0, 34, DateTimeKind.Utc).AddTicks(8318), "Rosalee.VonRueden7@hotmail.com", "Rosalee", "VonRueden", "ROSALEE.VONRUEDEN7@HOTMAIL.COM", "ROSALEE53", "AQAAAAIAAYagAAAAECysQz50hcgMekjJbFBTh/ow84QNG4JI8Hh9ne+jerg67fbQ3c8ycXOfMOB/oiqUIA==", "634-648-5532", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/946.jpg", "Rosalee53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4003 Elena Streets, Ullrichborough, Slovakia (Slovak Republic)", "48be71b5-2ecf-4be2-af9c-b29123864928", new DateTime(2024, 11, 18, 6, 1, 0, 34, DateTimeKind.Utc).AddTicks(8700), "Pascale_Kozey@gmail.com", "Pascale", "Kozey", "PASCALE_KOZEY@GMAIL.COM", "PASCALE_KOZEY61", "AQAAAAIAAYagAAAAEOFKN3w5dkYdvlAm5JCoLxN1HRud/A/kKHEROngGITi4ZOocAWFeTebWg5VHmxWwSQ==", "283-629-6691", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/303.jpg", "Pascale_Kozey61" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlugName",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5301 Fred Parkways, West Dereckshire, Turkey", "16fc99de-e622-43ea-af01-db7e82f42ad9", new DateTime(2024, 12, 21, 12, 3, 36, 328, DateTimeKind.Utc).AddTicks(6112), "May.Johns@gmail.com", "May", "Johns", "MAY.JOHNS@GMAIL.COM", "MAY53", "AQAAAAIAAYagAAAAEN0JYe3xzGRKzfWLvlYiasYkM9x2M87CJq7+ccAuB7zuJb4G/jgQrQxyEx2hXiGjfg==", "391-105-8805", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1112.jpg", "May53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "326 Runolfsdottir Course, Isaistad, Greece", "77766ba2-96f4-4bb3-b841-927d6a5b5207", new DateTime(2024, 10, 18, 12, 3, 36, 329, DateTimeKind.Utc).AddTicks(7724), "Lavonne.Wunsch@gmail.com", "Lavonne", "Wunsch", "LAVONNE.WUNSCH@GMAIL.COM", "LAVONNE.WUNSCH53", "AQAAAAIAAYagAAAAEB9C9jv1s6EttxZYWiDqILEw9Zvb6wTgxMbDmtYaKjGKD8LOeMYwBD2XUHJWFUc3Dw==", "299-100-6377", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/992.jpg", "Lavonne.Wunsch53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "472 Pat Mount, Beahanmouth, Antigua and Barbuda", "8dade60e-1a1e-4126-bd89-3e29f866c943", new DateTime(2024, 6, 30, 12, 3, 36, 329, DateTimeKind.Utc).AddTicks(8054), "Kenneth94@hotmail.com", "Kenneth", "Mitchell", "KENNETH94@HOTMAIL.COM", "KENNETH30", "AQAAAAIAAYagAAAAELuAdp40KdW1ADnpF9vFr3xkna6LZ4BeAaMEApmIrbB1Y2jpHs/WA0/k0Ot1bKwfOg==", "783-247-9714", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/652.jpg", "Kenneth30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8073 Kub Branch, Immanuelchester, Jersey", "a52e46bd-1080-4ff1-8d3d-3d80f96d9321", new DateTime(2024, 4, 2, 12, 3, 36, 329, DateTimeKind.Utc).AddTicks(9376), "Sherman.Gerhold78@yahoo.com", "Sherman", "Gerhold", "SHERMAN.GERHOLD78@YAHOO.COM", "SHERMAN.GERHOLD11", "AQAAAAIAAYagAAAAECrjBIV+zTkZlwTXixaaHKmwlhdWidZ4DJ9lSGlHHdwiHEXEo8fl6V0KDKmAmg5M2w==", "665-896-9651", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/144.jpg", "Sherman.Gerhold11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "841 Braun Square, Stokesfurt, Cuba", "98963c5e-e633-4ab8-860f-1cab21537720", new DateTime(2024, 6, 26, 12, 3, 36, 329, DateTimeKind.Utc).AddTicks(9676), "Dominic41@yahoo.com", "Dominic", "Daugherty", "DOMINIC41@YAHOO.COM", "DOMINIC_DAUGHERTY25", "AQAAAAIAAYagAAAAEC1W6Vba5pt4gByiG7k7SKdyjFK12w4oLEW0wf1SgbvJMhN2DbyYDukHZgOSUdH/jA==", "894-155-8500", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1077.jpg", "Dominic_Daugherty25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7097 Jasmin Bypass, Port Tatyana, Heard Island and McDonald Islands", "96471df2-67df-4cc4-b659-e6c5f2326d47", new DateTime(2024, 6, 8, 12, 3, 36, 329, DateTimeKind.Utc).AddTicks(9892), "Paul_Kassulke@gmail.com", "Paul", "Kassulke", "PAUL_KASSULKE@GMAIL.COM", "PAUL.KASSULKE", "AQAAAAIAAYagAAAAEGwTQvtmU5LwHZvpfJo9aK8SJGtLQS7fxlpPdf8cR9LPhs0EG+Du7B0+JgE/+xWzTg==", "158-440-1755", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1121.jpg", "Paul.Kassulke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "97446 Weimann Lodge, Kylafurt, Zambia", "c6278d99-49ca-4be3-8cb7-95ffb767e9b9", new DateTime(2024, 5, 17, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(112), "Laurel80@yahoo.com", "Laurel", "Fisher", "LAUREL80@YAHOO.COM", "LAUREL_FISHER33", "AQAAAAIAAYagAAAAEARY1sDh9wxC7V/Nx9bjWweW4OucdxYaU4yJeukvqL9FCu5zq4PCHrtSxdMej0HUMw==", "046-400-7874", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/672.jpg", "Laurel_Fisher33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "70136 Jerald Row, Antwonbury, Morocco", "37f23843-b966-4bec-bc40-d68377e56051", new DateTime(2024, 6, 28, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(348), "Jaclyn_Torp@gmail.com", "Jaclyn", "Torp", "JACLYN_TORP@GMAIL.COM", "JACLYN.TORP", "AQAAAAIAAYagAAAAEDyHqKf7rmseFGFcwXyfaWO4hP44wUlFT+bjnkoD4UYVCvyiHmr1B2trrfjNMGeJqw==", "549-618-6052", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1146.jpg", "Jaclyn.Torp" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "180 Paucek Hill, Bartonmouth, Turkey", "60940cf5-566a-4813-838b-5a72532671d4", new DateTime(2024, 4, 12, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(576), "Jamal_Cruickshank27@hotmail.com", "Jamal", "Cruickshank", "JAMAL_CRUICKSHANK27@HOTMAIL.COM", "JAMAL72", "AQAAAAIAAYagAAAAEC0IwS3dN//frcHJckoYprTByz457cgd4oiY+pwz214gCJNKaoosp0FLCtTcTZZmBQ==", "835-753-1725", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/526.jpg", "Jamal72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0034 Marley Walk, Corashire, Puerto Rico", "fe9ba86c-20ad-4813-8776-071b2b726ef5", new DateTime(2024, 9, 26, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(822), "Karli_Koch68@gmail.com", "Karli", "Koch", "KARLI_KOCH68@GMAIL.COM", "KARLI58", "AQAAAAIAAYagAAAAEISUTwCZPcK+IDJPI0m7XZ1QLk79Mha2bOhkbUNL9VZW5E7kAbHZfK0PcCsxn92Nuw==", "875-051-6591", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/454.jpg", "Karli58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "22115 Brionna Court, Faheyborough, Bahamas", "25815ca3-d844-4ece-b661-3354db6e2a7a", new DateTime(2024, 1, 22, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(1025), "Sophie_Spinka@gmail.com", "Sophie", "Spinka", "SOPHIE_SPINKA@GMAIL.COM", "SOPHIE76", "AQAAAAIAAYagAAAAEFtYbqTFBNpyb/vkWuu+kOt2YVdIeXQa3q10uJHnyWb8WMdFGZQQ82NbDrct6MAutw==", "134-464-6342", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/884.jpg", "Sophie76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "174 Bradtke Burgs, North Godfrey, French Southern Territories", "cbe6b196-4a7a-40c6-9f11-76effda07123", new DateTime(2024, 6, 18, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(1265), "Kelton46@yahoo.com", "Kelton", "Hills", "KELTON46@YAHOO.COM", "KELTON11", "AQAAAAIAAYagAAAAELbrv28rSxVbSKGWZUKAia3YwcM6v9vhRp1OeU5n5E6tMVl7z9/X7QvQ8N00RhWgqQ==", "358-850-9156", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1166.jpg", "Kelton11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0326 Morar Drives, Weimannchester, Tokelau", "d04db97e-03a4-46e5-b569-60ab6dfbf828", new DateTime(2024, 10, 14, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(1448), "Pearline.Volkman98@hotmail.com", "Pearline", "Volkman", "PEARLINE.VOLKMAN98@HOTMAIL.COM", "PEARLINE95", "AQAAAAIAAYagAAAAEBapE2XS0OuwlLMBGLB6owDJrETOA/Z5PXHzQH9UD0EvPCiV4GAMrormD5i4kExYIg==", "810-348-3009", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/991.jpg", "Pearline95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "692 Berniece Plaza, Sageberg, Bhutan", "7a878c3d-12a1-4f10-9604-6f77aeadabb1", new DateTime(2024, 7, 27, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(1711), "Mia29@yahoo.com", "Mia", "Conroy", "MIA29@YAHOO.COM", "MIA87", "AQAAAAIAAYagAAAAENmHqzPV7f/NDOyIeCcARMMYerudQVcW3DdAaM3tj2R+g9B3hdIuuJbBHISaKjO7kQ==", "362-542-5391", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1171.jpg", "Mia87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "169 Ransom Drives, Rogahnmouth, Taiwan", "5c9725db-47a9-4a2d-88ee-efb734f883c9", new DateTime(2024, 10, 19, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(2466), "Ollie54@hotmail.com", "Ollie", "Gottlieb", "OLLIE54@HOTMAIL.COM", "OLLIE_GOTTLIEB", "AQAAAAIAAYagAAAAEL8P5pvzAV2bE/JAZGi2X4YUFYcNEvigQDSh5SgKzitHcSX3T1tDStDdk/sH9HwtpA==", "361-490-3961", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/714.jpg", "Ollie_Gottlieb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "70810 Parker Valley, Lake Loyce, Venezuela", "69061b5d-5880-4d80-b33d-2524873d8178", new DateTime(2024, 4, 24, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(3343), "Dereck80@gmail.com", "Dereck", "Nader", "DERECK80@GMAIL.COM", "DERECK85", "AQAAAAIAAYagAAAAED4y/BKRv1v54uKSH1BN5y//ppqEHDbCGXHd6rrVTCwQliTeCokDTWm3X8zX41B5+A==", "097-861-7819", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/808.jpg", "Dereck85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3980 Adams Throughway, Port Lelahmouth, Uganda", "4a6537ce-4741-429d-bc1d-8bab1a69ad34", new DateTime(2024, 11, 28, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(3596), "Jay_Wolf66@yahoo.com", "Jay", "Wolf", "JAY_WOLF66@YAHOO.COM", "JAY_WOLF", "AQAAAAIAAYagAAAAEC4ol4I6wZ9giigIIUXa+DP2ncfLNSan5bVihvGtR0cifPDoKmvjtspDy84UPUNdzA==", "393-439-3642", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/381.jpg", "Jay_Wolf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0263 Fadel Plains, Auerchester, Bangladesh", "8d9652ea-c43d-4bb4-8154-8f4b59195307", new DateTime(2024, 9, 23, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(3832), "Katheryn60@yahoo.com", "Katheryn", "Homenick", "KATHERYN60@YAHOO.COM", "KATHERYN.HOMENICK29", "AQAAAAIAAYagAAAAEB1Ijafzm1zKvCWLe/zquusXI1WW3VEKCAGDm7puSOAzfP4X8eVv/h2WJgjXS3qK5A==", "748-640-3170", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1100.jpg", "Katheryn.Homenick29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "410 Murazik Circle, Lake Marquiseside, Norway", "ee14ec57-b04a-4cc5-b3a8-c471d14c66d7", new DateTime(2024, 11, 8, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(4049), "Berry_Robel@gmail.com", "Berry", "Robel", "BERRY_ROBEL@GMAIL.COM", "BERRY1", "AQAAAAIAAYagAAAAEK+XJPdjPPFJRQ+mfr10Kgv1b5HTSno/pxMEBmjJ9txWGdP0QlDAMbnhQCk8xFR9rg==", "964-931-0511", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/690.jpg", "Berry1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "24123 Leland Glen, Briannefort, Dominican Republic", "97bb375d-93a2-4507-a46c-94e9edad2b01", new DateTime(2024, 3, 26, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(4322), "Erik.Schuppe53@yahoo.com", "Erik", "Schuppe", "ERIK.SCHUPPE53@YAHOO.COM", "ERIK_SCHUPPE", "AQAAAAIAAYagAAAAEGThVnzZOC5YGpyVnCAHPtGuPP7hibh2059nAmS3zFelXjtJeiuQxyzL4hFCnspDfA==", "979-980-7456", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/209.jpg", "Erik_Schuppe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6681 McCullough Groves, South Gayleview, Netherlands", "6337d7a6-a9f7-4454-944b-f28bd4b1225c", new DateTime(2025, 1, 8, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(4529), "Wilmer_McKenzie@gmail.com", "Wilmer", "McKenzie", "WILMER_MCKENZIE@GMAIL.COM", "WILMER24", "AQAAAAIAAYagAAAAEK7wp6Sb2/XKxX5eVOkUmQleheOkqhHKrq4KiyVU5vp8ppK0uqijV+bl80iiG0P3rg==", "752-313-2245", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/832.jpg", "Wilmer24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5738 Hortense Fields, Port Doloresfurt, Albania", "c385d60d-40b1-4b0f-8e24-9fc5275257d4", new DateTime(2024, 2, 24, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(4973), "Ophelia.Johnson67@hotmail.com", "Ophelia", "Johnson", "OPHELIA.JOHNSON67@HOTMAIL.COM", "OPHELIA9", "AQAAAAIAAYagAAAAED/yIqZMzawQ6MKnyleKoERcLNAVThkXhGFjPKC8If/gOVRLpRFGMKBXkeAXcNEfwg==", "835-684-2617", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1246.jpg", "Ophelia9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "63397 Beverly Ford, South Dexterfort, Guinea", "8424a8cd-7eb5-4cb5-9a91-98f185edd1d4", new DateTime(2024, 11, 21, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(5274), "Cullen31@gmail.com", "Cullen", "Kreiger", "CULLEN31@GMAIL.COM", "CULLEN.KREIGER", "AQAAAAIAAYagAAAAEKPrn/8DIAngzaZprLf5vnAtsdaDOprb5Sc2s6C4pDGGCsXFXFftMX/J0JsUXOq7bQ==", "899-467-4198", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1109.jpg", "Cullen.Kreiger" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "57691 Reichert Via, Malcolmside, United States of America", "80b081a6-7f05-4e84-9e8a-118115ddd2bc", new DateTime(2024, 8, 10, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(5495), "Ruthie.Collier@yahoo.com", "Ruthie", "Collier", "RUTHIE.COLLIER@YAHOO.COM", "RUTHIE41", "AQAAAAIAAYagAAAAEJpbN5FjhKInERCRO//7z/1/rHGt6tUSMfvyQGTjDqxvHCSpLenPZRVUwRMad4Sbog==", "596-780-8560", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1009.jpg", "Ruthie41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "91869 Heloise Plaza, Adanton, Slovakia (Slovak Republic)", "1fe7c6f1-4d40-4575-bd55-a48dd425a9b4", new DateTime(2024, 10, 11, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(5726), "Blaise36@gmail.com", "Blaise", "Russel", "BLAISE36@GMAIL.COM", "BLAISE.RUSSEL2", "AQAAAAIAAYagAAAAEIEyoVs6DkJBwrCQjmsqsqw5xhA3ttGR5VJeXS5+L++K6vl/eXAOAi7CtqFVdKSDJQ==", "283-081-9155", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1005.jpg", "Blaise.Russel2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "768 Leannon Lakes, Lake Alberthaside, San Marino", "8fb4d653-b6d9-4166-9b59-28492d410db4", new DateTime(2024, 10, 31, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(5970), "Tressie_MacGyver8@hotmail.com", "Tressie", "MacGyver", "TRESSIE_MACGYVER8@HOTMAIL.COM", "TRESSIE_MACGYVER86", "AQAAAAIAAYagAAAAEIxxMycfeQ+b6PHVr5s1ec2arpVHbgIwF66rzBO4nVLTnIr88rhQ92S5APbUI06Iuw==", "663-367-9153", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/303.jpg", "Tressie_MacGyver86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "39412 Mante Mountains, Franciscashire, Seychelles", "2e5b6e26-92c7-44ab-875f-5f3910926d56", new DateTime(2024, 12, 1, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(7184), "Alexandro46@hotmail.com", "Alexandro", "Kshlerin", "ALEXANDRO46@HOTMAIL.COM", "ALEXANDRO63", "AQAAAAIAAYagAAAAEOC2DBeDlTiJFKOPIaAwWTgZkIy3P83jnMGtqfMsKo96/AigSHPjpi8DCTwj5jhOCw==", "831-133-6141", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/310.jpg", "Alexandro63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6266 Kali Camp, West Carlieshire, Papua New Guinea", "fd676e33-c627-4de0-8b1a-aa478904ec55", new DateTime(2024, 7, 26, 12, 3, 36, 330, DateTimeKind.Utc).AddTicks(7841), "Hassie87@gmail.com", "Hassie", "Crist", "HASSIE87@GMAIL.COM", "HASSIE_CRIST", "AQAAAAIAAYagAAAAEGI8Ne6jDrs8OdWG1Yj6eevjBkJIToyagT1w+kJz5buTm2JvJEGDMnCUYqpoLcO7dA==", "078-180-5681", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/138.jpg", "Hassie_Crist" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "05790 Barrows Cape, Ankundingmouth, Thailand", "5a90d1f2-724f-4bd7-9b4f-a3dbaee42362", new DateTime(2024, 11, 25, 12, 3, 36, 331, DateTimeKind.Utc).AddTicks(229), "Oral.Crona@hotmail.com", "Oral", "Crona", "ORAL.CRONA@HOTMAIL.COM", "ORAL_CRONA", "AQAAAAIAAYagAAAAEFWRS5oZHMEfgNVhIETvmTzEuSGwO7dy25s7qCfQCgJx9c9l59NreHSmmltEC6fQBg==", "494-447-3153", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/380.jpg", "Oral_Crona" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "039 Rice River, Lockmanport, Aruba", "508f3507-924d-461d-a46f-51ea8ebcb621", new DateTime(2024, 3, 22, 12, 3, 36, 331, DateTimeKind.Utc).AddTicks(1249), "Marcelino.Schaden@gmail.com", "Marcelino", "Schaden", "MARCELINO.SCHADEN@GMAIL.COM", "MARCELINO80", "AQAAAAIAAYagAAAAEC5lqu1pSPWbxaUHKU0ofrept3ZaD7ICdKrWGZCb7UO/1KPK+A8Yv/vWOEq/nl4RJw==", "683-598-3733", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/745.jpg", "Marcelino80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3051 Kessler Square, McCulloughview, Czech Republic", "e9b8e9cd-25c6-4fbb-922c-d2b37a24d5f8", new DateTime(2024, 4, 20, 12, 3, 36, 331, DateTimeKind.Utc).AddTicks(3135), "Justyn36@hotmail.com", "Justyn", "Robel", "JUSTYN36@HOTMAIL.COM", "JUSTYN34", "AQAAAAIAAYagAAAAEJSdlzgTQGWOQ5JQU6GlCTuOHtdWKV+ANnRccP9ANmFHeguCDJRW9sZzM0W3G2NgnQ==", "278-554-7238", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/309.jpg", "Justyn34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6433 Santos Bypass, North Marleymouth, Lithuania", "77c30dbb-0924-4172-895b-24bd64f782e1", new DateTime(2024, 4, 17, 12, 3, 36, 331, DateTimeKind.Utc).AddTicks(4349), "Louie.Collier50@yahoo.com", "Louie", "Collier", "LOUIE.COLLIER50@YAHOO.COM", "LOUIE_COLLIER44", "AQAAAAIAAYagAAAAEDW2KWbh2HvNoZNrY4kv4FxjjfRdmycUze06a0n1/eGyZN9SHsc7TNobvgEtnTJp6g==", "639-412-8092", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/325.jpg", "Louie_Collier44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9406 Kelly Shoal, West Corbinland, Norway", "1f44283d-38b2-44cc-9a12-2bbe5f76668b", new DateTime(2024, 7, 1, 12, 3, 36, 331, DateTimeKind.Utc).AddTicks(5868), "Jalen_Dooley@hotmail.com", "Jalen", "Dooley", "JALEN_DOOLEY@HOTMAIL.COM", "JALEN79", "AQAAAAIAAYagAAAAEHDbBFxiT7Ku1Z3mnpFRsa45EloIQ7Xtc3+6kErDga//a661ghzIi7dNvOut/8t36w==", "647-684-3659", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/193.jpg", "Jalen79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "23174 Claudie Village, Fredaside, Barbados", "82b80cd5-78bd-43a5-ad6d-8ffa6aa36e09", new DateTime(2024, 1, 31, 12, 3, 36, 331, DateTimeKind.Utc).AddTicks(6942), "Lea_Kuphal@gmail.com", "Lea", "Kuphal", "LEA_KUPHAL@GMAIL.COM", "LEA2", "AQAAAAIAAYagAAAAEAMv5GTOFSpenEIU9RdajQ2flSo+hlqsZvexJKehG1vj3Af5/d5U/sSa1wl5VROZcA==", "660-735-2671", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/782.jpg", "Lea2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2189 Pablo Manors, South Emmanuelberg, Christmas Island", "bd526f23-3dfe-417d-88d7-0a1c922f3a0a", new DateTime(2024, 7, 10, 12, 3, 36, 331, DateTimeKind.Utc).AddTicks(9220), "Sheridan_Jacobi@yahoo.com", "Sheridan", "Jacobi", "SHERIDAN_JACOBI@YAHOO.COM", "SHERIDAN_JACOBI", "AQAAAAIAAYagAAAAEN96iYEozEY3mGgzZoBpUUgFiDkJ8RdEXBQpE3VBYKdJaG0lTFMGojqOFa/PnUfcaw==", "316-796-3148", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/859.jpg", "Sheridan_Jacobi" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "060 Klein Rue, Port Barrettside, Angola", "814bee33-1939-4c10-ac80-158e85b57dac", new DateTime(2024, 2, 14, 12, 3, 36, 331, DateTimeKind.Utc).AddTicks(9469), "Consuelo.Blick@hotmail.com", "Consuelo", "Blick", "CONSUELO.BLICK@HOTMAIL.COM", "CONSUELO.BLICK89", "AQAAAAIAAYagAAAAEGkWhVKln3trCyTWIR/6zaQZRMQNFLaas/E2ZuuHF8Wq8n5d87EbnoEYcIzCs2g3rQ==", "263-017-5544", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/734.jpg", "Consuelo.Blick89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "600 Jerald Landing, New Ferminland, British Indian Ocean Territory (Chagos Archipelago)", "46f86c2c-d68b-4d40-b18c-c6deaa1fc978", new DateTime(2024, 3, 18, 12, 3, 36, 331, DateTimeKind.Utc).AddTicks(9715), "Brenda.Witting@hotmail.com", "Brenda", "Witting", "BRENDA.WITTING@HOTMAIL.COM", "BRENDA.WITTING", "AQAAAAIAAYagAAAAEPPNP5XLNfj0F0mcB1wQQFjhc6sqwPbpcoeVhUTw9bx1Xv/WLSJ6wdBGjv69bMFRyQ==", "277-926-4983", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/485.jpg", "Brenda.Witting" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "40451 Hills Heights, Ardithview, New Zealand", "f7e90657-349f-461e-9e11-bb2a16c8ca44", new DateTime(2024, 2, 14, 12, 3, 36, 331, DateTimeKind.Utc).AddTicks(9907), "Zetta49@gmail.com", "Zetta", "Hills", "ZETTA49@GMAIL.COM", "ZETTA.HILLS", "AQAAAAIAAYagAAAAEPL+3DT8Mmao06lIjT6+rRZfDZ0x4ogoOlBNw6XpvlsnY5SHfXDghZv8uaEr59cW8Q==", "703-040-9272", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/775.jpg", "Zetta.Hills" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "15190 Ora Plains, Deontaeburgh, Turks and Caicos Islands", "9795ed0a-25ad-49b1-8e8d-0212c6a600e7", new DateTime(2024, 3, 14, 12, 3, 36, 332, DateTimeKind.Utc).AddTicks(144), "Carrie25@hotmail.com", "Carrie", "Kiehn", "CARRIE25@HOTMAIL.COM", "CARRIE5", "AQAAAAIAAYagAAAAEL5DHU+5XOMym9usNkozRndaGZjKL0HXtEskgpJKAS0DIt9/2e30jii83RAyh1TSUQ==", "538-985-1225", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/111.jpg", "Carrie5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "04583 Veda Loaf, Korystad, Saint Helena", "8679c9c0-be87-4904-bde5-2ad56e1e31e2", new DateTime(2024, 2, 1, 12, 3, 36, 332, DateTimeKind.Utc).AddTicks(348), "Ines.Keeling@hotmail.com", "Ines", "Keeling", "INES.KEELING@HOTMAIL.COM", "INES61", "AQAAAAIAAYagAAAAEBrjc2cnfDbIONWPHqwHhn/K0J1nZo6vy1f2ax/l9VNv15T0SeqpbG5wiQGeZ4aUlQ==", "048-741-9810", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/912.jpg", "Ines61" });
        }
    }
}
