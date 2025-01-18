using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatevariantproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Variants");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "VariantValues",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "VariantValues");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Variants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "256 Lockman Lakes, North Marilynefort, Monaco", "b8f79bc5-d3d4-4935-ab18-f7430fafe4cc", new DateTime(2024, 9, 2, 15, 47, 30, 860, DateTimeKind.Utc).AddTicks(3050), "Dameon.Hamill@gmail.com", "Dameon", "Hamill", "DAMEON.HAMILL@GMAIL.COM", "DAMEON_HAMILL26", "AQAAAAIAAYagAAAAEGOfxvKr1GewFt468A3gte7lbIRhDRnoOJL7dmM4nge5Qhxew7yXccOsxwHZh7YxwA==", "241-444-3122", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/962.jpg", "Dameon_Hamill26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3053 Predovic Stream, Dorothyhaven, Cyprus", "e666d7d1-cce3-4856-ae4f-9e99ed7f682c", new DateTime(2024, 7, 11, 15, 47, 30, 861, DateTimeKind.Utc).AddTicks(5912), "Amaya.Windler@yahoo.com", "Amaya", "Windler", "AMAYA.WINDLER@YAHOO.COM", "AMAYA8", "AQAAAAIAAYagAAAAEENfTxtGCe/St9oNlXQE4VINqVabbRgUnPMuklFokh27wd0mpScUvGngwyPifZ+WWQ==", "897-053-3019", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/871.jpg", "Amaya8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "11325 Kenneth Hollow, North Aliaburgh, Dominica", "36ce8c60-6884-4b02-8392-74cc89dec54e", new DateTime(2024, 3, 12, 15, 47, 30, 861, DateTimeKind.Utc).AddTicks(6282), "Lillian.Hyatt38@hotmail.com", "Lillian", "Hyatt", "LILLIAN.HYATT38@HOTMAIL.COM", "LILLIAN65", "AQAAAAIAAYagAAAAEFqUomeJkX0NBUItCQZe2wxtM5yNYvfUo0OgQbbjXwb2E1zcbUqO7luMuMRiScUf1w==", "941-668-3845", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/854.jpg", "Lillian65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6452 Kovacek Loop, Nikolauston, Montserrat", "7a25799c-c5ce-4b5c-9b70-295d51b5be7e", new DateTime(2024, 12, 31, 15, 47, 30, 861, DateTimeKind.Utc).AddTicks(6522), "Verda_Bahringer@gmail.com", "Verda", "Bahringer", "VERDA_BAHRINGER@GMAIL.COM", "VERDA.BAHRINGER", "AQAAAAIAAYagAAAAEJ9AvueLiN+PBEjojOMg1DX7WlXXJpUql56W8OhM66eQhbo8ZmhldBB/83kvHAH2lQ==", "684-005-1814", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/12.jpg", "Verda.Bahringer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5849 Edgar Junctions, North Eveline, Argentina", "05c6c875-bc7f-497e-b681-abe68896cc6d", new DateTime(2024, 7, 10, 15, 47, 30, 861, DateTimeKind.Utc).AddTicks(6783), "Barney.Moore90@hotmail.com", "Barney", "Moore", "BARNEY.MOORE90@HOTMAIL.COM", "BARNEY_MOORE46", "AQAAAAIAAYagAAAAEIVwP+yR4R7y2mV28rMjOdC8p9bv3wk03qgztRHjjh9tcII4DmzyeGnJqOw//t/kBA==", "353-136-7087", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1114.jpg", "Barney_Moore46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "639 Hillard Dale, Duncanview, Eritrea", "882ee1bb-8409-426b-b7bd-e5bc69aa1a65", new DateTime(2024, 8, 20, 15, 47, 30, 861, DateTimeKind.Utc).AddTicks(7041), "Fidel.Muller@yahoo.com", "Fidel", "Muller", "FIDEL.MULLER@YAHOO.COM", "FIDEL.MULLER", "AQAAAAIAAYagAAAAEN0C+91OMY8cBLrF2ikkquw8+PBf+lu0Fw4W4hLKpBGEnrwyWyo4UGlf684lAaobhQ==", "781-652-8243", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/211.jpg", "Fidel.Muller" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7005 Grant Road, Marcoborough, Norfolk Island", "58072bb7-7638-4bc9-aec5-ba9b6a6d2a26", new DateTime(2024, 8, 4, 15, 47, 30, 861, DateTimeKind.Utc).AddTicks(7313), "Lew_Heidenreich@gmail.com", "Lew", "Heidenreich", "LEW_HEIDENREICH@GMAIL.COM", "LEW.HEIDENREICH", "AQAAAAIAAYagAAAAEJSNXeFZF8uccETrDjF5/Ta+FNYUrqq9ScBum2Cs07IPoGYnc4QidRFN2jr1+1U7HA==", "126-891-5600", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1238.jpg", "Lew.Heidenreich" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4227 Amie Manors, New Hazle, Nauru", "cb83d263-cd2a-4f44-911b-2c353da9810f", new DateTime(2024, 8, 26, 15, 47, 30, 863, DateTimeKind.Utc).AddTicks(5865), "Hortense_OKon1@gmail.com", "Hortense", "O'Kon", "HORTENSE_OKON1@GMAIL.COM", "HORTENSE13", "AQAAAAIAAYagAAAAEByabxDC2Y+B9UEXL/pp5A6UNLQ9MwONhooBUTqv8n/CtCLPQrFfUSe1FmXobWjc9Q==", "906-761-7586", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/780.jpg", "Hortense13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "59564 Alicia Islands, Port Rollin, Norway", "78fc140c-565d-4d60-895a-6993b71b5222", new DateTime(2024, 10, 13, 15, 47, 30, 863, DateTimeKind.Utc).AddTicks(7409), "Mattie.Gusikowski@yahoo.com", "Mattie", "Gusikowski", "MATTIE.GUSIKOWSKI@YAHOO.COM", "MATTIE_GUSIKOWSKI", "AQAAAAIAAYagAAAAEDB1KW0hMXMgRyAv+Chy/5DM8hcKubbjsAgd/ldsk8oYMyx/vg4SPUM9o41xHV6Sbw==", "493-183-6512", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/267.jpg", "Mattie_Gusikowski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9043 Reina Coves, Mayertberg, Micronesia", "be699446-cc44-4191-b97f-1087a708873f", new DateTime(2024, 5, 15, 15, 47, 30, 863, DateTimeKind.Utc).AddTicks(7681), "Myra_Abbott10@yahoo.com", "Myra", "Abbott", "MYRA_ABBOTT10@YAHOO.COM", "MYRA51", "AQAAAAIAAYagAAAAEE4tk9GzJSWTF+lAjJFbPxdsP3NQBN1pc9IF0pkkrhC3iKzO9fMK66ejf5wRNk2Z/g==", "873-274-0967", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1167.jpg", "Myra51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "669 Hyatt Glen, Lake Robbshire, Trinidad and Tobago", "17835c07-3420-4451-9b05-adedffa76278", new DateTime(2024, 10, 24, 15, 47, 30, 863, DateTimeKind.Utc).AddTicks(7970), "Elroy10@gmail.com", "Elroy", "McKenzie", "ELROY10@GMAIL.COM", "ELROY_MCKENZIE", "AQAAAAIAAYagAAAAECaa2zDS3yiSm+M8eUCsqQcUf/gPs3Y/4CSLHABsP/Z4ZAGrtvBqu0HuW+UYEOWIKQ==", "225-348-3195", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1125.jpg", "Elroy_McKenzie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "34151 Smitham Locks, Donnellyshire, Finland", "daed5424-1787-4a2c-85fc-14b3b85cc67a", new DateTime(2024, 8, 28, 15, 47, 30, 863, DateTimeKind.Utc).AddTicks(8196), "Jena82@yahoo.com", "Jena", "Jacobi", "JENA82@YAHOO.COM", "JENA68", "AQAAAAIAAYagAAAAEHfy8IC5oQkK0nzcTHqOQAf4RC+kh20FWv2r/dsiUoelMNSbgHV6YA+zsp2cYQpjuQ==", "519-759-2799", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/791.jpg", "Jena68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9196 Amber Cliffs, Colemantown, Iran", "29e0f1df-a878-439a-ac30-df025e4a2e93", new DateTime(2024, 4, 1, 15, 47, 30, 863, DateTimeKind.Utc).AddTicks(8458), "Aiyana.Deckow@gmail.com", "Aiyana", "Deckow", "AIYANA.DECKOW@GMAIL.COM", "AIYANA.DECKOW", "AQAAAAIAAYagAAAAEKVxG3dClwqMvWNB+gzosOhDuF0dKB3u2kiVv/vyaZytaNYuWlmR0dS7gYNQ9RQOnA==", "898-076-0069", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/263.jpg", "Aiyana.Deckow" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "412 Elenor Curve, Jacobsland, Gibraltar", "57d429e6-de7c-498c-b658-9b7762c0a801", new DateTime(2024, 10, 3, 15, 47, 30, 863, DateTimeKind.Utc).AddTicks(8660), "Kimberly85@yahoo.com", "Kimberly", "Ratke", "KIMBERLY85@YAHOO.COM", "KIMBERLY.RATKE", "AQAAAAIAAYagAAAAEABcSJQWL3TJtK8X9bfDy8CFlXeMDL42cnUYIfo36rGlfecFXTLhRv0BgB2oD8zTCw==", "497-552-3882", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1004.jpg", "Kimberly.Ratke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "96065 Lakin Crest, Hillaryland, Svalbard & Jan Mayen Islands", "1a90ebad-46d2-4b3c-8b20-863508f871c6", new DateTime(2024, 10, 25, 15, 47, 30, 863, DateTimeKind.Utc).AddTicks(8904), "Brisa_Halvorson@hotmail.com", "Brisa", "Halvorson", "BRISA_HALVORSON@HOTMAIL.COM", "BRISA.HALVORSON68", "AQAAAAIAAYagAAAAENY8vIEXSWVnLj9pxCN0+4x4of/4sJjOse+rEhXe80vliQcNNyJtWoGSccsrUB8DWQ==", "413-585-8041", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1095.jpg", "Brisa.Halvorson68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "93596 Miller Center, Watsonburgh, Nicaragua", "ef11bddb-691e-484f-b4ee-8bcf0bde25e1", new DateTime(2024, 4, 19, 15, 47, 30, 863, DateTimeKind.Utc).AddTicks(9676), "Adaline.Rath72@yahoo.com", "Adaline", "Rath", "ADALINE.RATH72@YAHOO.COM", "ADALINE56", "AQAAAAIAAYagAAAAEEVwtyYMc4KwoLcTQ/61ae1vL/G3GfolOeEy/HQs5Zv79GiyM8904BVe43d1XKjxIg==", "579-166-6218", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/499.jpg", "Adaline56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8303 Muller Fork, Brakusport, Pakistan", "872aec42-1c47-4e68-948b-05b47465c3aa", new DateTime(2024, 3, 3, 15, 47, 30, 863, DateTimeKind.Utc).AddTicks(9982), "Benedict_Balistreri8@yahoo.com", "Benedict", "Balistreri", "BENEDICT_BALISTRERI8@YAHOO.COM", "BENEDICT_BALISTRERI72", "AQAAAAIAAYagAAAAEHkp9OymxYOhhKGt1x0ZWUlG7RIjz8uV2F8DXBh8JbfmYR4RSh6EzNuxO0wQ54S1uA==", "375-414-7257", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/2.jpg", "Benedict_Balistreri72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "79010 Bettye Trail, New Maribelfurt, Bermuda", "697a7860-fbb3-42b2-ad7f-085f34373afc", new DateTime(2024, 10, 19, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(266), "Caterina_Ullrich37@gmail.com", "Caterina", "Ullrich", "CATERINA_ULLRICH37@GMAIL.COM", "CATERINA.ULLRICH27", "AQAAAAIAAYagAAAAEFNcHFHriUU6Zl4oe/3+ycp0LB4ggX2oIpmDaoG6lm+olt88AwY1RbYxTWtIXT7snA==", "362-126-1649", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/600.jpg", "Caterina.Ullrich27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5727 Donnell Mount, Grahamton, Libyan Arab Jamahiriya", "e19c7dfd-fa84-4638-88a2-b242391937d8", new DateTime(2024, 9, 14, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(469), "Kip6@gmail.com", "Kip", "McLaughlin", "KIP6@GMAIL.COM", "KIP13", "AQAAAAIAAYagAAAAEOyftkbpb+y/bvd9q7fwFCarN+LEvswmQGNNhIzDACORHELuLza1naO5ITHNOiKGTA==", "172-868-0081", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/791.jpg", "Kip13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "672 Strosin Trafficway, New Maurineport, South Georgia and the South Sandwich Islands", "908fd160-d5ad-43c5-bfc4-909b77e9e78b", new DateTime(2025, 1, 2, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(713), "Madyson.Funk@gmail.com", "Madyson", "Funk", "MADYSON.FUNK@GMAIL.COM", "MADYSON.FUNK", "AQAAAAIAAYagAAAAECPOhW7zzueZNAqsGIlIOUy8OluGcxrkvbcnWlK2vaUOd9tW+gHQcnxr0FqvMyDJjA==", "833-941-2188", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/796.jpg", "Madyson.Funk" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "75626 Koepp Cape, Port Rahsaanshire, Seychelles", "5a97298b-9496-4b32-b456-34c4e2007a04", new DateTime(2024, 2, 15, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(914), "Minerva.Smitham1@gmail.com", "Minerva", "Smitham", "MINERVA.SMITHAM1@GMAIL.COM", "MINERVA_SMITHAM8", "AQAAAAIAAYagAAAAECthDA8S2IoObuQGR3+tfjWjVH9/xyjkV7Cn+zWMaTnED/LCdcVBqV9UVpYbR1YhxA==", "464-630-4484", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/894.jpg", "Minerva_Smitham8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "312 Bins Common, Constantintown, Eritrea", "944ce807-9b91-4300-a995-26246f57808f", new DateTime(2024, 12, 29, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(1159), "Harold77@hotmail.com", "Harold", "White", "HAROLD77@HOTMAIL.COM", "HAROLD_WHITE", "AQAAAAIAAYagAAAAEAZmMvSGMq3QEwwvWQ/LKY0MDwCSSu5/OMKr0NvVI1OssbM48Rx9pyjzMn9n1JAGoA==", "084-440-1056", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1239.jpg", "Harold_White" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "50480 Bruen Path, Kunzeburgh, Christmas Island", "1481968e-3b22-49dd-bf97-0f0da1efcd13", new DateTime(2024, 2, 7, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(1359), "Elenora_Barrows92@hotmail.com", "Elenora", "Barrows", "ELENORA_BARROWS92@HOTMAIL.COM", "ELENORA.BARROWS", "AQAAAAIAAYagAAAAEGCIDNii8ydX80PqVMq4jdwEn1MMNZe+IjedY92J6Cz6NPT8uvCWA2+sOg9+akxMpw==", "638-310-2564", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/222.jpg", "Elenora.Barrows" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "356 Beer Mills, Ramonburgh, Palau", "f3c99e15-97f6-49dd-96a7-28958c8f5d87", new DateTime(2024, 11, 12, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(1588), "Josefa38@gmail.com", "Josefa", "Cassin", "JOSEFA38@GMAIL.COM", "JOSEFA72", "AQAAAAIAAYagAAAAED/zxqgt9W9vgwmzuIzrc/wbtPGY1uQjobgBy1ytwRkgrPhSguvCoUMbek944VqizA==", "957-016-4151", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1059.jpg", "Josefa72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7488 DuBuque Ford, South Antonetta, Brazil", "48cd3e6e-d6d9-41f6-9691-7df83cdef29e", new DateTime(2024, 12, 26, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(1784), "Kenny.Rolfson90@gmail.com", "Kenny", "Rolfson", "KENNY.ROLFSON90@GMAIL.COM", "KENNY_ROLFSON", "AQAAAAIAAYagAAAAEAL6lApf+9ZfkAFjl4tGc23HM3qTt6eISdBLPLtjn/AKqBFvnwr6Jkuh7X8mlYFy3w==", "130-931-2471", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/60.jpg", "Kenny_Rolfson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "194 Ullrich Vista, West Providenci, French Polynesia", "ff5da249-a3b1-47fa-ab41-6f8680aeb752", new DateTime(2024, 8, 18, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(2031), "Annabel30@gmail.com", "Annabel", "Mann", "ANNABEL30@GMAIL.COM", "ANNABEL.MANN45", "AQAAAAIAAYagAAAAEIarUHykQf+MKyv6oxlYJTUBGa8EbZdv+m5Oy0aIRVH7lZ6NDBTuoPZpzOc3tvMZHA==", "893-180-7434", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1145.jpg", "Annabel.Mann45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "309 Giles Wells, West Amyton, Armenia", "6b520254-a40e-4782-9562-3c518369b5b2", new DateTime(2024, 4, 25, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(2243), "Onie_Wilderman30@yahoo.com", "Onie", "Wilderman", "ONIE_WILDERMAN30@YAHOO.COM", "ONIE.WILDERMAN", "AQAAAAIAAYagAAAAEDXZo2GDTu5KpObl2dhce787Q03Q74BbX1Av82nyV68h+hHLAxrV15PMBnYWkSgpQw==", "255-565-4473", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1218.jpg", "Onie.Wilderman" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "68185 Mason Neck, East Mercedes, Mongolia", "c0c96190-5702-46e1-9b08-7e993b8285cd", new DateTime(2024, 4, 14, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(2534), "Ibrahim_Lesch@gmail.com", "Ibrahim", "Lesch", "IBRAHIM_LESCH@GMAIL.COM", "IBRAHIM_LESCH", "AQAAAAIAAYagAAAAEFV5FITihWD9iPIhXIFTaesANj9kcY5SnUIYDOSsclCpkaVNuKTsr+GoLrcoGVjAXQ==", "736-931-7463", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/276.jpg", "Ibrahim_Lesch" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "611 Itzel Gateway, Spencerstad, Sri Lanka", "13270dd2-497b-498c-a090-ffd224b03fdc", new DateTime(2024, 2, 23, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(2749), "Franz_Zulauf53@yahoo.com", "Franz", "Zulauf", "FRANZ_ZULAUF53@YAHOO.COM", "FRANZ_ZULAUF65", "AQAAAAIAAYagAAAAEAwsr9LaGxN0a17HQqNGGpivHJMHV+ZHh5QjbobmSPpUo8Mlromg03ZFSW3A+T/P0w==", "104-805-7535", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/882.jpg", "Franz_Zulauf65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "87007 Zboncak Mews, West Ursula, Aruba", "6a840fe6-32ff-4455-a516-ab3e9013577e", new DateTime(2024, 4, 11, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(3002), "Johanna.Oberbrunner56@hotmail.com", "Johanna", "Oberbrunner", "JOHANNA.OBERBRUNNER56@HOTMAIL.COM", "JOHANNA.OBERBRUNNER13", "AQAAAAIAAYagAAAAEJfPKc+Sq5T80cuK+KeotyG2xeSQCZ+50AeUZE9ra0wkTMJ4InY1GZba/gV66+7cOA==", "232-996-8296", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/429.jpg", "Johanna.Oberbrunner13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9107 Kulas Tunnel, Lake Effie, Singapore", "d37da339-cbd1-44af-8f2a-beb0cf0effbb", new DateTime(2024, 1, 21, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(3197), "Rafael.Lindgren@hotmail.com", "Rafael", "Lindgren", "RAFAEL.LINDGREN@HOTMAIL.COM", "RAFAEL_LINDGREN", "AQAAAAIAAYagAAAAEB0NXiBaug5y0hOVAaziD3EH5/QiA72WQHqWf5E3eNb7vqWapNG4t7+tNIPAbhX4ig==", "417-803-3184", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/0.jpg", "Rafael_Lindgren" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5857 Augusta Crest, Aufderharborough, United Kingdom", "8eda08ef-35e7-4eab-b4e3-1a462b44871a", new DateTime(2024, 11, 4, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(3434), "Dereck.Beatty21@hotmail.com", "Dereck", "Beatty", "DERECK.BEATTY21@HOTMAIL.COM", "DERECK98", "AQAAAAIAAYagAAAAEOobNw291pXj5sqponCLs7usSkFXBDJgXpbVUK7nPszkxwZauAEa/UmUDSTgdF41wA==", "446-761-8349", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/368.jpg", "Dereck98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "681 Senger Station, Mackville, Fiji", "f7342a50-783e-4ea5-9af5-37860954341e", new DateTime(2024, 12, 5, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(3609), "Kyleigh91@hotmail.com", "Kyleigh", "Zulauf", "KYLEIGH91@HOTMAIL.COM", "KYLEIGH.ZULAUF3", "AQAAAAIAAYagAAAAEEgIVgpN6y3KnWL8bzowypEmLvKrtteLAy3SAU41YRVZGlvnnuZFOD0RBpYYFDIAhw==", "315-344-9660", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/958.jpg", "Kyleigh.Zulauf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "88380 Susan Bridge, Romaineside, Niue", "cc6ed160-81a9-4bd3-b3b8-414562cf8c83", new DateTime(2024, 8, 7, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(3868), "Antone_Bashirian56@gmail.com", "Antone", "Bashirian", "ANTONE_BASHIRIAN56@GMAIL.COM", "ANTONE25", "AQAAAAIAAYagAAAAEE5f3r7snkToXKkN885/lH9HYkQykAB2wrn/y0bDu5k0sIqa5jLHfpk16c8HMASiFA==", "743-000-8371", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/310.jpg", "Antone25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "00000 Llewellyn Prairie, Lake Camden, Luxembourg", "b8f4b54a-dfe4-4674-b008-6329a71cefc1", new DateTime(2024, 8, 11, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(4074), "Dolly_Gutmann@yahoo.com", "Dolly", "Gutmann", "DOLLY_GUTMANN@YAHOO.COM", "DOLLY.GUTMANN", "AQAAAAIAAYagAAAAEOYz71otyUh6xTL0JwEOHQe/bTMj3Y9EreNH+OikDri4g7TJWxWpwNoIsb+n30Oo1A==", "775-478-9089", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/698.jpg", "Dolly.Gutmann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "508 Reilly Manor, Xzavierport, Swaziland", "a69136a8-d284-4012-9ec8-5e9afdf016c2", new DateTime(2024, 10, 12, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(4301), "Bruce.Pacocha@hotmail.com", "Bruce", "Pacocha", "BRUCE.PACOCHA@HOTMAIL.COM", "BRUCE.PACOCHA73", "AQAAAAIAAYagAAAAEMNjoNc468CE5IHY2W7VlmEhOKiU4gWu9WfkvByBsfWKNT8vya9nxkaSr0c49Zrmug==", "267-074-4708", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/337.jpg", "Bruce.Pacocha73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "141 Horacio Walk, Port Sienna, Norway", "ae523196-5914-4acc-9cf8-140af3bc2094", new DateTime(2024, 11, 13, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(4503), "Rachelle.Swaniawski4@gmail.com", "Rachelle", "Swaniawski", "RACHELLE.SWANIAWSKI4@GMAIL.COM", "RACHELLE.SWANIAWSKI", "AQAAAAIAAYagAAAAEKKxwglTf06dXJ53ennIvmb09gN1QaGbCKN3RA4BNg26p8HkBinAS+rAC8f7N+HMKA==", "618-424-6217", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/260.jpg", "Rachelle.Swaniawski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "25644 Pagac Trafficway, North Albertofurt, Saudi Arabia", "73d9d26e-4660-41bf-82e9-ca2759363246", new DateTime(2024, 3, 7, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(4711), "Alda_Kihn50@gmail.com", "Alda", "Kihn", "ALDA_KIHN50@GMAIL.COM", "ALDA.KIHN", "AQAAAAIAAYagAAAAELv76FDkwHRkn5kslVuHe6l52rJOp7CJkTDSIALV+TOA0lg7HgC2yYH0FKkyDWyl1w==", "336-116-5082", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/77.jpg", "Alda.Kihn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "490 Nikolaus Motorway, West Keanufort, Burkina Faso", "d6c2d423-6cf2-4efd-92b1-489211043fab", new DateTime(2024, 12, 7, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(4964), "Luigi.Collins@hotmail.com", "Luigi", "Collins", "LUIGI.COLLINS@HOTMAIL.COM", "LUIGI_COLLINS", "AQAAAAIAAYagAAAAEJl+bSCivQxuQygacG65/JZk9uYHYruFz3v1+QHxsKM6Hgns8hIhiipFG2xRARteBA==", "071-995-0372", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/695.jpg", "Luigi_Collins" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "089 Eda Inlet, Jenkinsburgh, Cocos (Keeling) Islands", "7940cad3-ffba-43f2-9d76-9f7a3971f517", new DateTime(2024, 6, 7, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(5163), "Deon_Abernathy87@gmail.com", "Deon", "Abernathy", "DEON_ABERNATHY87@GMAIL.COM", "DEON.ABERNATHY", "AQAAAAIAAYagAAAAEFHd7K1bpuNr6aYu26+O0efyY8c5oPVWXZKCN8m0ekbHs/I4/FYsab9KMYJb2LtB8Q==", "615-127-8372", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/934.jpg", "Deon.Abernathy" });
        }
    }
}
