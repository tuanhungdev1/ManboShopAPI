using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class adddataproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 152, new DateTime(2024, 12, 18, 6, 18, 59, 117, DateTimeKind.Utc).AddTicks(7223), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Adidas Áo Polo Thoải Mái", 4518659.6031697677686715288908m, 3504853.013195195150000m, 476, "Kích thước: XS, S, L. Màu sắc: Xám, Đỏ" });

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
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 27, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9300), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp văn phòng", "Zara Áo Polo Thời Thượng", 2830620.9841512039581346224285m, 2379243.4566699650000m, 353, "Kích thước: S, M, XS. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 56, 3, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9340), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp văn phòng", "Zara Blazer Thời Thượng", 4090807.2925835821305275458633m, 3149128.041772561700000m, 73, "Kích thước: XXL, S, XS. Màu sắc: Xám, Đen" });

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
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 162, 2, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9502), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Áo Sơ Mi Sang Trọng", 5322800.7185549177046945741059m, 4417470.422451950000m, 201, "Kích thước: M, XL, XXL. Màu sắc: Đỏ, Xám" });

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
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 89, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9760), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Louis Vuitton Váy Liền Sang Trọng", 1601155.2716157415145661724642m, 1223757.476982102650000m, 258, "Kích thước: XS, M, XL. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 73, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9790), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Zara Áo Thun Trẻ Trung", 2574687.8538150919063164740350m, 2332489.817074512650000m, 167, "Kích thước: XXL, S, XS. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 123, 5, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9844), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Uniqlo Váy Liền Thời Thượng", 2770692.4877723095957077815724m, 1926467.649816326600000m, 19, "Kích thước: L, XS, S. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 12, 5, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9875), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Adidas Áo Khoác Năng Động", 5523078.5258584814362890052733m, 4497788.628107389400000m, 51, "Kích thước: L, S, XXL. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 38, new DateTime(2024, 12, 18, 6, 18, 59, 122, DateTimeKind.Utc).AddTicks(9905), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Zara Áo Len Hiện Đại", 2716775.7509249419550711797644m, 2113863.958476097250000m, 238, "Kích thước: XXL, XL, M. Màu sắc: Đỏ, Hồng" });

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
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 66, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(461), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Gucci Áo Sơ Mi Thoải Mái", 6593427.3613247305258172634199m, 4838323.162389720800000m, 235, "Kích thước: XL, XXL, XS. Màu sắc: Đỏ, Xanh Navy" });

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
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 184, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(572), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Quần Tây Cổ Điển", 5831074.8753401248757156974645m, 4475685.105099391100000m, 155, "Kích thước: L, XS, M. Màu sắc: Đen, Trắng" });

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
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 60, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(654), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Adidas Quần Jean Hiện Đại", 5733552.1154371912512341731563m, 4138285.34719304150000m, 151, "Kích thước: XS, XL, M. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 47, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(683), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp thể thao", "Nike Áo Len Thoải Mái", 2811901.8308174613140978526553m, 2187528.988518844250000m, 220, "Kích thước: M, XXL, L. Màu sắc: Đen, Trắng" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification", "UpdatedAt" },
                values: new object[,]
                {
                    { 41, 5, 132, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(712), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Sơ Mi Thời Thượng", 3704623.1714412360962196569835m, 3096616.983910436750000m, 233, "Kích thước: S, XL, XS. Màu sắc: Xanh Navy, Đen", null },
                    { 42, 2, 25, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(772), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Uniqlo Váy Liền Thoải Mái", 5311513.3372223585285070832710m, 4774162.720856780300000m, 66, "Kích thước: S, XS, XXL. Màu sắc: Xanh Navy, Trắng", null },
                    { 43, 9, 151, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(804), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Zara Quần Jean Hiện Đại", 3824734.5362640776000675190474m, 3015785.093957321900000m, 28, "Kích thước: S, XL, L. Màu sắc: Đỏ, Xám", null },
                    { 44, 3, 31, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(836), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "H&M Quần Short Trẻ Trung", 1077387.0379273424771202689783m, 839666.647263480800000m, 79, "Kích thước: XS, XXL, XL. Màu sắc: Xám, Hồng", null },
                    { 45, 7, 169, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(865), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Gucci Blazer Thời Thượng", 1536902.1324118470614669463923m, 1378547.014200503900000m, 370, "Kích thước: XL, S, XS. Màu sắc: Trắng, Đỏ", null },
                    { 46, 10, 64, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(918), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Uniqlo Đầm Dạ Hội Năng Động", 3148012.2321441220556057572616m, 2481545.549781080150000m, 233, "Kích thước: XS, XXL, XL. Màu sắc: Trắng, Đen", null },
                    { 47, 3, 21, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(948), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Sơ Mi Hiện Đại", 2588675.7757006647349764147446m, 1925088.036156113900000m, 305, "Kích thước: L, M, XL. Màu sắc: Trắng, Xanh Navy", null },
                    { 48, 3, 142, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(978), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Thun Cổ Điển", 4642878.8392645063781058147605m, 3521773.211724860900000m, 413, "Kích thước: XS, L, XL. Màu sắc: Trắng, Xám", null },
                    { 49, 8, 40, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1007), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Tây Cổ Điển", 1448896.5166414356808985422260m, 1183675.021063668050000m, 313, "Kích thước: M, L, S. Màu sắc: Trắng, Xanh Navy", null },
                    { 50, 1, 155, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1062), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Quần Jogger Trẻ Trung", 3671957.3516779766743074623233m, 3255333.272355572600000m, 483, "Kích thước: XXL, S, L. Màu sắc: Trắng, Đỏ", null },
                    { 51, 6, 146, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1091), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Zara Quần Jean Thời Thượng", 4759915.4513204863685960665212m, 3292051.332302924900000m, 488, "Kích thước: L, S, XS. Màu sắc: Xanh Navy, Đen", null },
                    { 52, 5, 79, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1171), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Uniqlo Quần Tây Thời Thượng", 2600901.6094155629084901701942m, 2025406.442620816700000m, 248, "Kích thước: S, L, XS. Màu sắc: Xanh Navy, Xám", null },
                    { 53, 3, 8, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1199), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "H&M Áo Sơ Mi Trẻ Trung", 3198291.7117276149030584644355m, 2629919.736451206050000m, 393, "Kích thước: S, XXL, M. Màu sắc: Trắng, Hồng", null },
                    { 54, 2, 55, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1245), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Thun Hiện Đại", 3934552.5860997062321466157975m, 3080362.98848845100000m, 330, "Kích thước: XXL, L, XS. Màu sắc: Xám, Trắng", null },
                    { 55, 1, 50, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1276), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Zara Áo Khoác Trẻ Trung", 5553249.8555653112541840140910m, 4161773.655258986750000m, 217, "Kích thước: XL, S, M. Màu sắc: Hồng, Trắng", null },
                    { 56, 5, 199, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1305), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "H&M Quần Jean Năng Động", 173246.14636318761732611018566m, 147068.9313021606200000m, 298, "Kích thước: XS, S, XL. Màu sắc: Hồng, Đỏ", null },
                    { 57, 8, 68, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1391), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "H&M Áo Len Cổ Điển", 3587928.7428717356548322205503m, 2708217.337063526150000m, 218, "Kích thước: M, L, XXL. Màu sắc: Đen, Xanh Navy", null },
                    { 58, 6, 10, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1422), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Gucci Quần Jean Thời Thượng", 217702.91789260275751665192835m, 189377.1443602704650000m, 264, "Kích thước: XL, XS, S. Màu sắc: Trắng, Xám", null },
                    { 59, 8, 198, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1451), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Chanel Quần Tây Thoải Mái", 2402268.4771637240060981866781m, 1775075.152045907750000m, 268, "Kích thước: L, XXL, S. Màu sắc: Xanh Navy, Đỏ", null },
                    { 60, 4, 197, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1479), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Uniqlo Đầm Dạ Hội Cổ Điển", 2971249.4310336003567427896970m, 2494205.30270092550000m, 311, "Kích thước: XS, S, XL. Màu sắc: Đỏ, Trắng", null },
                    { 61, 2, 53, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1539), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Quần Jean Năng Động", 4019844.4766499036199937274612m, 2849383.236160925150000m, 422, "Kích thước: M, XXL, XS. Màu sắc: Đỏ, Trắng", null },
                    { 62, 6, 68, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1568), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Gucci Áo Khoác Thời Thượng", 1632393.5171736435020289069812m, 1297998.325797792800000m, 423, "Kích thước: XS, M, XL. Màu sắc: Xanh Navy, Trắng", null },
                    { 63, 6, 150, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1597), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Adidas Quần Short Thời Thượng", 2613111.2758828505823729066211m, 2332681.760659576100000m, 19, "Kích thước: S, XS, XXL. Màu sắc: Xám, Đỏ", null },
                    { 64, 3, 141, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1627), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Len Cổ Điển", 4391232.6437120129752716805639m, 3252451.994970760400000m, 42, "Kích thước: S, L, XL. Màu sắc: Đen, Xanh Navy", null },
                    { 65, 1, 169, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1681), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Adidas Áo Khoác Sang Trọng", 5106403.6637934843960462441473m, 3903492.425615635550000m, 114, "Kích thước: M, XS, XXL. Màu sắc: Xám, Đỏ", null },
                    { 66, 3, 133, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1711), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Adidas Đầm Dạ Hội Thời Thượng", 247760.59366344006579102353015m, 172282.4284389035900000m, 164, "Kích thước: L, XL, XXL. Màu sắc: Xám, Xanh Navy", null },
                    { 67, 2, 137, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1739), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Chanel Váy Liền Trẻ Trung", 5350557.4662984913807139027055m, 4483128.23583218600000m, 119, "Kích thước: L, XS, S. Màu sắc: Hồng, Xám", null },
                    { 68, 6, 200, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1788), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Nike Áo Khoác Thoải Mái", 4956118.6032803160666810110511m, 4363821.541504884200000m, 17, "Kích thước: XL, XS, XXL. Màu sắc: Xanh Navy, Đỏ", null },
                    { 69, 10, 75, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1820), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp thể thao", "Zara Áo Polo Hiện Đại", 1348439.1549621707967711163925m, 1126662.8613035900000m, 433, "Kích thước: XL, XXL, XS. Màu sắc: Đỏ, Hồng", null },
                    { 70, 9, 158, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1848), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "H&M Quần Tây Trẻ Trung", 4513385.4387392284010109613636m, 3274359.329158518650000m, 384, "Kích thước: L, XL, XS. Màu sắc: Hồng, Xanh Navy", null },
                    { 71, 8, 128, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1877), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Adidas Váy Liền Thoải Mái", 5532306.7331466490402839502961m, 4520799.005405636750000m, 243, "Kích thước: XL, S, L. Màu sắc: Xám, Xanh Navy", null },
                    { 72, 9, 94, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1946), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Nike Áo Len Thời Thượng", 4506426.6499392910842413709150m, 3221212.12725846650000m, 48, "Kích thước: S, XL, L. Màu sắc: Xám, Hồng", null },
                    { 73, 9, 148, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(1974), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Gucci Quần Jogger Thoải Mái", 3466758.7449241053956435747513m, 2971570.50339217250000m, 199, "Kích thước: XL, XXL, M. Màu sắc: Trắng, Xám", null },
                    { 74, 9, 99, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2002), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "H&M Quần Short Thời Thượng", 2616247.5213720099336483274765m, 2222247.440739264350000m, 464, "Kích thước: XL, S, L. Màu sắc: Hồng, Đen", null },
                    { 75, 2, 143, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2030), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Zara Váy Liền Thời Thượng", 744811.80540022378024760266936m, 548007.351855104300000m, 128, "Kích thước: XL, XS, S. Màu sắc: Xám, Xanh Navy", null },
                    { 76, 1, 174, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2084), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "H&M Áo Sơ Mi Cổ Điển", 1793058.7309136291558929799063m, 1331399.273951147450000m, 452, "Kích thước: XL, L, S. Màu sắc: Trắng, Xanh Navy", null },
                    { 77, 9, 148, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2111), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Nike Váy Liền Trẻ Trung", 5560728.7996360893911073312608m, 4323556.192602384050000m, 62, "Kích thước: M, XL, S. Màu sắc: Xám, Đen", null },
                    { 78, 3, 144, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2139), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Nike Áo Len Sang Trọng", 3199112.2808103106858678906750m, 2634273.604377741650000m, 251, "Kích thước: M, XS, S. Màu sắc: Đỏ, Hồng", null },
                    { 79, 5, 119, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2189), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Zara Áo Len Thời Thượng", 3274404.3416525308374016700396m, 2475271.076312796800000m, 200, "Kích thước: S, M, L. Màu sắc: Xanh Navy, Trắng", null },
                    { 80, 9, 189, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2218), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Sơ Mi Thời Thượng", 1136460.5126458010058635299772m, 854341.534816333250000m, 225, "Kích thước: XXL, XL, S. Màu sắc: Đen, Xám", null },
                    { 81, 1, 13, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2248), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Nike Quần Jogger Thời Thượng", 6508908.9314873154309964810387m, 4367418.647179233200000m, 305, "Kích thước: XL, S, XS. Màu sắc: Xanh Navy, Hồng", null },
                    { 82, 5, 16, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2276), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp dạo phố", "Louis Vuitton Áo Len Cổ Điển", 3223087.3474514588214679438988m, 2468902.735520570750000m, 334, "Kích thước: L, XL, M. Màu sắc: Xanh Navy, Đỏ", null },
                    { 83, 3, 129, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2320), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "H&M Quần Jean Trẻ Trung", 6585912.5306576255303480886159m, 4884632.685717454400000m, 337, "Kích thước: XXL, XL, XS. Màu sắc: Hồng, Xanh Navy", null },
                    { 84, 5, 192, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2349), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Đầm Dạ Hội Thoải Mái", 397935.75600127247589046311973m, 299363.198713445300000m, 259, "Kích thước: XS, S, XL. Màu sắc: Đỏ, Đen", null },
                    { 85, 7, 50, 4, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2378), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "H&M Váy Liền Thoải Mái", 2380086.1610820003807785305138m, 1682456.979099164900000m, 290, "Kích thước: XXL, XS, S. Màu sắc: Trắng, Hồng", null },
                    { 86, 3, 113, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2407), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Váy Liền Thoải Mái", 514584.58232977783135409972443m, 344911.6758176827700000m, 318, "Kích thước: M, XS, L. Màu sắc: Xám, Xanh Navy", null },
                    { 87, 4, 52, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2469), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Adidas Áo Sơ Mi Sang Trọng", 1418246.6050759583578779005682m, 1003201.877020622900000m, 490, "Kích thước: S, XXL, L. Màu sắc: Xám, Đỏ", null },
                    { 88, 1, 161, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2497), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "Zara Áo Thun Hiện Đại", 4246444.1780949009835198223772m, 3077702.862308276900000m, 466, "Kích thước: XXL, M, S. Màu sắc: Xanh Navy, Trắng", null },
                    { 89, 2, 106, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2528), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "Nike Áo Thun Cổ Điển", 1176923.3033969270565118819541m, 914561.604836263400000m, 339, "Kích thước: L, XXL, S. Màu sắc: Xám, Trắng", null },
                    { 90, 6, 180, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2555), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Gucci Quần Tây Cổ Điển", 3034451.2059806465690311138518m, 2507770.91215470650000m, 270, "Kích thước: XXL, S, XS. Màu sắc: Đỏ, Hồng", null },
                    { 91, 8, 120, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2616), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Chanel Quần Tây Hiện Đại", 2929173.5818644111852539209801m, 2615375.914559046050000m, 433, "Kích thước: M, S, XL. Màu sắc: Xanh Navy, Đỏ", null },
                    { 92, 8, 55, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2645), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Sơ Mi Sang Trọng", 3821743.2949301632659270101612m, 3166230.169395013550000m, 433, "Kích thước: XL, S, L. Màu sắc: Đỏ, Hồng", null },
                    { 93, 7, 16, 3, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2674), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Zara Quần Jean Cổ Điển", 469732.45065358448496394601267m, 321948.6674264917700000m, 46, "Kích thước: XL, M, S. Màu sắc: Hồng, Đỏ", null },
                    { 94, 2, 139, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2738), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Đầm Dạ Hội Cổ Điển", 4935408.2459099103244608434724m, 4448841.464216086250000m, 251, "Kích thước: XL, XXL, XS. Màu sắc: Xám, Xanh Navy", null },
                    { 95, 6, 60, 1, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2769), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "H&M Quần Short Thoải Mái", 1585697.2146472674091679687285m, 1207869.515645849600000m, 465, "Kích thước: M, L, XXL. Màu sắc: Xanh Navy, Đỏ", null },
                    { 96, 3, 172, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2799), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Gucci Đầm Dạ Hội Hiện Đại", 579027.59638569603217848694171m, 404619.6300112979150000m, 195, "Kích thước: XS, M, XXL. Màu sắc: Hồng, Đỏ", null },
                    { 97, 7, 10, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2827), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Chanel Quần Jean Hiện Đại", 4307049.9263870509418823225505m, 3063885.014538478850000m, 143, "Kích thước: XL, XXL, S. Màu sắc: Đỏ, Xanh Navy", null },
                    { 98, 5, 110, 5, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2882), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Chanel Blazer Thời Thượng", 2365458.7725158041768120320492m, 1920154.007363645300000m, 421, "Kích thước: M, XXL, XL. Màu sắc: Đen, Xanh Navy", null },
                    { 99, 5, 128, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2912), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Quần Tây Năng Động", 3865388.2842552170077260497478m, 3021384.428027148650000m, 384, "Kích thước: L, XXL, M. Màu sắc: Đỏ, Xanh Navy", null },
                    { 100, 2, 175, 2, new DateTime(2024, 12, 18, 6, 18, 59, 123, DateTimeKind.Utc).AddTicks(2941), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp thể thao", "Chanel Áo Khoác Thoải Mái", 2102819.9211532238074312885449m, 1526987.986685251700000m, 14, "Kích thước: S, M, XS. Màu sắc: Trắng, Đỏ", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5364 Alanis Glen, West Lura, Czech Republic", "b6633ebe-cfd3-44f3-afa2-df7658b30f95", new DateTime(2024, 2, 5, 6, 15, 7, 571, DateTimeKind.Utc).AddTicks(6637), "Damian21@gmail.com", "Damian", "O'Hara", "DAMIAN21@GMAIL.COM", "DAMIAN_OHARA", "AQAAAAIAAYagAAAAEIGnI+i2xNkte/mFo1u65Wh9KvSxm3lIGJZxSQCQhh0ToxeegbKTazhUyDgh7g9lrQ==", "154-020-9240", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/338.jpg", "Damian_OHara" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "22897 Yundt Forest, New Marisol, Uzbekistan", "69e77f05-8eee-4266-9fea-7a664afd2d35", new DateTime(2024, 10, 27, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(8210), "Yoshiko_Nitzsche@gmail.com", "Yoshiko", "Nitzsche", "YOSHIKO_NITZSCHE@GMAIL.COM", "YOSHIKO.NITZSCHE81", "AQAAAAIAAYagAAAAEFY/nVzfKFhveqxiu7vnhMM0ekh8IKmNc6gSH63RBuukdgb/Apky/ptt/JppuHzMQw==", "187-409-4924", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1003.jpg", "Yoshiko.Nitzsche81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "514 Moore Turnpike, North Shanon, Hungary", "c2350f5e-d7d1-4248-a2e4-ac07792c6e94", new DateTime(2024, 10, 21, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(8551), "Shanna_Hills@hotmail.com", "Shanna", "Hills", "SHANNA_HILLS@HOTMAIL.COM", "SHANNA4", "AQAAAAIAAYagAAAAEHKpC5gU3Jus/6yWAvGTzJ/pSrgXKUgT5w20R3uYi+Si3UNy9C1aUcq+H8qT0hL7aQ==", "330-188-8053", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/549.jpg", "Shanna4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1966 Koss Club, Greenfelderton, Cuba", "a7fee4cc-8c8f-4e7b-9dde-650344a84522", new DateTime(2024, 10, 1, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(8801), "Edwin57@yahoo.com", "Edwin", "Mitchell", "EDWIN57@YAHOO.COM", "EDWIN_MITCHELL2", "AQAAAAIAAYagAAAAEELqYHz1w67tnDVy4pjODgqYObhBjkOYlj9XwJxEGWWR3eNt+J2+aSd/vQAfDBKmbw==", "783-828-6740", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/266.jpg", "Edwin_Mitchell2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "768 Bednar Locks, Lake Lisetteland, Faroe Islands", "57ecf5a3-161d-41a7-ba3c-83edc8010092", new DateTime(2024, 1, 17, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(9022), "Mertie.Walter@gmail.com", "Mertie", "Walter", "MERTIE.WALTER@GMAIL.COM", "MERTIE.WALTER64", "AQAAAAIAAYagAAAAEOaaqaEIaEjzpA0fc/JxSIUpJ2vr0yqwVCYucskiYZYZS8ZrX5TgKQTuk76ZwchYlg==", "371-862-4901", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/342.jpg", "Mertie.Walter64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0710 Beverly Coves, Josefaview, Iraq", "e2e97ec6-1563-45e5-8171-e5014c1bff6a", new DateTime(2024, 6, 8, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(9314), "Gino15@hotmail.com", "Gino", "Parisian", "GINO15@HOTMAIL.COM", "GINO26", "AQAAAAIAAYagAAAAEOuOFlqcuzpR0XQ7MT9kaKEwHBDy+P7tUc9wYrjZv0H4kcg2lnWh6wdYwQkJKJ/wPg==", "992-374-3549", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/225.jpg", "Gino26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "88092 Reagan Row, East Camylleberg, Bermuda", "cd90dfe5-6480-42aa-9ffb-f2d820208fe7", new DateTime(2024, 8, 11, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(9518), "Rahul45@hotmail.com", "Rahul", "Kiehn", "RAHUL45@HOTMAIL.COM", "RAHUL40", "AQAAAAIAAYagAAAAENJGBnfaZ7g54zCfVYQAyX3pWyqQWJhlcQumTL7XC8vtU/Dx30kYengMlrdRzFXx/g==", "140-516-9405", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/824.jpg", "Rahul40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "378 Gaston Knolls, Oberbrunnerbury, Cyprus", "b77b2613-2fb6-4660-b8d0-71825f3f39c2", new DateTime(2024, 3, 1, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(9736), "Soledad74@gmail.com", "Soledad", "Stanton", "SOLEDAD74@GMAIL.COM", "SOLEDAD.STANTON", "AQAAAAIAAYagAAAAEHQbR/HeZkTzmh4SGhLDBIdJ2I3yDGAUwPe6iVboUHh18L7ezQfzq9y96qLCcYFVnw==", "663-986-5224", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/464.jpg", "Soledad.Stanton" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0775 Nicole Mall, Lonzoport, Kazakhstan", "0a1f6f95-69fb-4ea8-8a9b-abfccb12a434", new DateTime(2024, 6, 26, 6, 15, 7, 572, DateTimeKind.Utc).AddTicks(9921), "Antonia_Wunsch@hotmail.com", "Antonia", "Wunsch", "ANTONIA_WUNSCH@HOTMAIL.COM", "ANTONIA.WUNSCH", "AQAAAAIAAYagAAAAEIKaBNrBZZ7rsQo9rogdcDRzX0P91UlniOtXeu9KZSTfoA/AQ3SOf1qGLuh0K7FubQ==", "605-357-5455", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/284.jpg", "Antonia.Wunsch" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "145 Zulauf Lodge, West Regan, Cambodia", "c2a80072-ee41-4e66-875a-18f70f0d3483", new DateTime(2024, 8, 17, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(158), "Rupert.Wilderman@yahoo.com", "Rupert", "Wilderman", "RUPERT.WILDERMAN@YAHOO.COM", "RUPERT23", "AQAAAAIAAYagAAAAEG5A1LKzlI0ID4sJEcx7gqDmT+unMon5mfnbtZrdIJb0tK8MWgcw1C1iFPuW+6jMtw==", "895-867-1149", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/303.jpg", "Rupert23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "30759 Ernser Port, Port Estell, Saint Kitts and Nevis", "076c922b-c8a2-475a-a6b3-a356d89c3ad6", new DateTime(2024, 7, 19, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(363), "Arne_Dickinson84@hotmail.com", "Arne", "Dickinson", "ARNE_DICKINSON84@HOTMAIL.COM", "ARNE_DICKINSON42", "AQAAAAIAAYagAAAAEIpQlw+3sO3FCWMakGJqHHUBb/hHN+LFfVPVd0JNcnSdN6nzP0xnCFG/AA5A6YtOFQ==", "092-813-6698", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/13.jpg", "Arne_Dickinson42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9860 Madaline Causeway, Coralieberg, Saint Barthelemy", "4d5803df-81bc-44a0-9e7b-d9815e0035fa", new DateTime(2024, 7, 28, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(640), "Aylin_Jakubowski@hotmail.com", "Aylin", "Jakubowski", "AYLIN_JAKUBOWSKI@HOTMAIL.COM", "AYLIN84", "AQAAAAIAAYagAAAAEJfMGhM7bYb29cY0vBjdqUl0vM+dZi2hRbYwjZkqOFWP/R7keBJy6zJtsYI3ks26vg==", "064-606-4778", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1013.jpg", "Aylin84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "331 Sister Rapid, West Durwardshire, Italy", "afa1e77a-5a6a-47e3-bb0d-72ca28fa2e23", new DateTime(2024, 10, 11, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(844), "Hilario.Kirlin78@yahoo.com", "Hilario", "Kirlin", "HILARIO.KIRLIN78@YAHOO.COM", "HILARIO.KIRLIN72", "AQAAAAIAAYagAAAAEJU0/1Lxxs7+3mUrVx0KfL4A5MIs5bGIz+z0xJPijxTTagL2lOHlHMe8Urxk64qGxQ==", "306-006-2034", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1185.jpg", "Hilario.Kirlin72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "445 Murazik Radial, Binsview, Switzerland", "7cd35d2f-50a9-4f2a-857e-a90fdb50cd67", new DateTime(2024, 2, 14, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(1125), "Rosanna99@hotmail.com", "Rosanna", "Schamberger", "ROSANNA99@HOTMAIL.COM", "ROSANNA_SCHAMBERGER", "AQAAAAIAAYagAAAAECAz6ngm+SWYc8Q9Wf5vD3qh+qSH2EZd09P/yo8SlUsO+yxnjqSQweTn5NF1Vly6bQ==", "425-084-9698", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1243.jpg", "Rosanna_Schamberger" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "523 Morar Way, South Elouisestad, Antarctica (the territory South of 60 deg S)", "1526396e-e509-42aa-b7d1-bc3965db7abd", new DateTime(2024, 1, 26, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(1335), "Filiberto21@hotmail.com", "Filiberto", "Stark", "FILIBERTO21@HOTMAIL.COM", "FILIBERTO_STARK", "AQAAAAIAAYagAAAAEOTDyHoHAAgxMvXNAyhuafGwYv6fF9Ri/+E8NZL1UlQaTdlTQYh6jONsVx8qfBC54A==", "094-922-5989", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/78.jpg", "Filiberto_Stark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "20110 Anderson Trace, Strosinshire, Ukraine", "28e9b758-accf-4d54-a9f3-d91218c28ea8", new DateTime(2024, 3, 25, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(1565), "Adella.Hickle@hotmail.com", "Adella", "Hickle", "ADELLA.HICKLE@HOTMAIL.COM", "ADELLA.HICKLE", "AQAAAAIAAYagAAAAEDE/BWivI6zmYisrm4wmBJLAdz5QaD+Aiz3zt2q9C5IZbse3xBsXddznpsR4nw/6SA==", "306-347-7090", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/825.jpg", "Adella.Hickle" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "709 Bradley Islands, Kennyberg, Guam", "9a85aa65-10cd-42b8-95e1-4dd2d0350442", new DateTime(2024, 6, 12, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(1786), "Estefania_Konopelski@yahoo.com", "Estefania", "Konopelski", "ESTEFANIA_KONOPELSKI@YAHOO.COM", "ESTEFANIA.KONOPELSKI14", "AQAAAAIAAYagAAAAEI/I+6oHJwvLUWgb0q49PHp+g99GV46YaiypHSGD0ba+fAV7MFY2aOUUpBdfmhpZYA==", "959-811-2279", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/67.jpg", "Estefania.Konopelski14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "318 Cortney Squares, Princeview, Angola", "201129ec-10f6-48c4-a1c1-d04d37edc480", new DateTime(2024, 4, 19, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(1985), "Green.Gerlach@yahoo.com", "Green", "Gerlach", "GREEN.GERLACH@YAHOO.COM", "GREEN.GERLACH", "AQAAAAIAAYagAAAAECzgTjVkrNn1L3BRDUwXOJwiAp5VbD/9mJ1Q+A9N9Ezz6BIHB4/os4IjRe8c+RY++Q==", "790-340-3384", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1085.jpg", "Green.Gerlach" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3450 O'Conner Plaza, Port Garretmouth, Barbados", "b6e5ef02-209a-42be-a61e-5170ce78ec97", new DateTime(2024, 3, 1, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(2211), "Gail_Muller32@hotmail.com", "Gail", "Muller", "GAIL_MULLER32@HOTMAIL.COM", "GAIL_MULLER94", "AQAAAAIAAYagAAAAELTP7Labydu6v9h+xbxt8g/iqCw34ErTCk4NoJB41sX1bzjBGNKgE1aEX/ndkaYo1g==", "512-648-6640", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/652.jpg", "Gail_Muller94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9328 Cruickshank Island, Lake Drewberg, Thailand", "9e161447-8511-4133-a52a-4ac7aa26727c", new DateTime(2024, 5, 7, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(2397), "Marlen71@yahoo.com", "Marlen", "Klein", "MARLEN71@YAHOO.COM", "MARLEN_KLEIN", "AQAAAAIAAYagAAAAEKU7V8uIoZrrwC2k2hwPVhDNTed1/IgokBxMMUbixCylNp7k4NYpIrnmh1SzFGt0Vg==", "532-572-0217", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/221.jpg", "Marlen_Klein" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "714 Schowalter Skyway, New Gregoriahaven, Norfolk Island", "02b1cd7f-829a-482c-bfd9-5ebc9be3b8b7", new DateTime(2023, 12, 19, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(2623), "Mazie.Cassin84@yahoo.com", "Mazie", "Cassin", "MAZIE.CASSIN84@YAHOO.COM", "MAZIE1", "AQAAAAIAAYagAAAAEBAdhflbI2+OzL4zuHZNduP7RoHHWUfVvlyrZuHi0ZAFVkEHlyyyD1xE2tQ5TdjvNA==", "966-550-9045", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/380.jpg", "Mazie1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "704 Fadel Cove, East Brodyland, Togo", "7dbbab67-3dcc-44b1-9c28-df1fc9e8473f", new DateTime(2024, 3, 2, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(2855), "Kraig.Schroeder@yahoo.com", "Kraig", "Schroeder", "KRAIG.SCHROEDER@YAHOO.COM", "KRAIG_SCHROEDER8", "AQAAAAIAAYagAAAAEKhV3y+Pa9lhkcLheMI/LiYDS9MBXAmh8zEswdjH1cm9ls68mnNkb3WpK5inb8VRrQ==", "711-789-7564", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/674.jpg", "Kraig_Schroeder8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "84906 Wisoky Mills, Steuberview, Puerto Rico", "2a57848c-175b-4757-a970-eb18af9c2cc1", new DateTime(2024, 9, 23, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(3092), "Genevieve.Corkery90@gmail.com", "Genevieve", "Corkery", "GENEVIEVE.CORKERY90@GMAIL.COM", "GENEVIEVE76", "AQAAAAIAAYagAAAAEIK+p/oUu+Tp8G/ghP9pBWfaR2nKzfNBBYOsvS9QV8bfZiPp6Jv+ztLKl80i94TxgQ==", "490-851-6924", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/701.jpg", "Genevieve76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "948 Lucio Radial, Nicolasside, Cote d'Ivoire", "f5c12c2f-8e05-4169-a2d6-8bac266db36c", new DateTime(2024, 4, 2, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(3274), "Dario_Bogan56@yahoo.com", "Dario", "Bogan", "DARIO_BOGAN56@YAHOO.COM", "DARIO.BOGAN21", "AQAAAAIAAYagAAAAEG+2hWzh1vIDirrWtaMnvWbC2Eb/dWJIdIOUCkhz3O/lElthb4ZuFZczTfYHtT1yoQ==", "116-607-5188", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/863.jpg", "Dario.Bogan21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1037 Keebler Ways, Ilatown, Suriname", "ec94f4db-6d9b-4047-b584-ba4a901acb6a", new DateTime(2024, 1, 30, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(3491), "Tyreek80@gmail.com", "Tyreek", "Goyette", "TYREEK80@GMAIL.COM", "TYREEK.GOYETTE", "AQAAAAIAAYagAAAAELS42/xO2Rl5XtRs2mnDadSDmpYBtHBOOpskTEfUIYpSACNIkho2CgUR0bX3VOHsGQ==", "640-520-9047", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/663.jpg", "Tyreek.Goyette" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9488 Witting Locks, Albinaport, Croatia", "c92170aa-f5d6-4b3b-b3dd-feebf7558cfc", new DateTime(2024, 11, 11, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(3715), "Israel16@yahoo.com", "Israel", "Heidenreich", "ISRAEL16@YAHOO.COM", "ISRAEL15", "AQAAAAIAAYagAAAAEEY41Q6T4mKieHzqv6sZSN4PBMia1D837a2i16REGluVDtzVhSCTkyRndJKt7yJWbg==", "074-538-4630", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/660.jpg", "Israel15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5764 Connelly Hill, Lake Franz, Cook Islands", "00585d23-2aee-4d3e-828d-12e5eb2aed67", new DateTime(2024, 4, 3, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(3979), "Orval61@yahoo.com", "Orval", "Veum", "ORVAL61@YAHOO.COM", "ORVAL.VEUM", "AQAAAAIAAYagAAAAEAtvBp1GBbHmGVxS2WBiECXt4lbPwQtRoajn4rxa0dCZMldagplURfFY0bdNyaXTJA==", "005-956-2685", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/252.jpg", "Orval.Veum" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "381 Klocko Forge, Lake Georgianatown, Ireland", "56dd58eb-5dae-4298-aeb7-41619a81ff85", new DateTime(2024, 5, 15, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(4174), "Victor48@yahoo.com", "Victor", "Kautzer", "VICTOR48@YAHOO.COM", "VICTOR0", "AQAAAAIAAYagAAAAEBWkobUSAZkYnv5y5WbaDd7wUVsHLh4dz1D5PylielUZ6XZTLeQuKBowOh05ly3COg==", "799-061-0916", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/58.jpg", "Victor0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "29092 McGlynn Square, New Carmel, Saint Lucia", "52f9c988-9277-4dde-a32c-9e7ce9056aa0", new DateTime(2024, 3, 3, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(4445), "Hettie_Grant@hotmail.com", "Hettie", "Grant", "HETTIE_GRANT@HOTMAIL.COM", "HETTIE.GRANT", "AQAAAAIAAYagAAAAEKvjtpkHlkI11zm61b6jWfl2KfOqFaILIgny0Pvs1UI85weI6ILU7YxVNHhah6y8PQ==", "906-569-1874", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1071.jpg", "Hettie.Grant" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "676 Reina Expressway, Natashachester, Yemen", "996bb792-f2dd-4e02-819b-90905ddac0e0", new DateTime(2024, 4, 28, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(4649), "Vern_Haley60@gmail.com", "Vern", "Haley", "VERN_HALEY60@GMAIL.COM", "VERN_HALEY", "AQAAAAIAAYagAAAAEDm6GPqlDnXoJXiv/6rMS4ABNuRBwss4vP3XDKbFlWtNVMrDxVoxguFBa/eWmSbVgg==", "173-872-3396", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/312.jpg", "Vern_Haley" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "227 Goodwin Parkways, Lake Orlochester, Uzbekistan", "af0846d7-c4f3-493b-9b80-d1a6ab99d9ca", new DateTime(2024, 2, 29, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(4863), "Gideon26@hotmail.com", "Gideon", "Smith", "GIDEON26@HOTMAIL.COM", "GIDEON90", "AQAAAAIAAYagAAAAEKVPhsrrj4Xd25hz98UlUgqKX5Soowr9tIVQEpmHtQTGW1d75HNu4Zg2FTsEa38oNg==", "365-316-2658", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1095.jpg", "Gideon90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "15768 Geovanni Cliff, Lake Alva, Tanzania", "4aaddc43-9a58-45bc-b4c4-390054ca5e60", new DateTime(2024, 6, 14, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(5034), "Lupe_Renner86@gmail.com", "Lupe", "Renner", "LUPE_RENNER86@GMAIL.COM", "LUPE41", "AQAAAAIAAYagAAAAEKlQG6LytLVPXJqF9C2fp5oYaBWB4/Hqd4EIYHzgcBx3LhJfWbA/7WTwB4slPV3xpQ==", "107-184-9368", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/645.jpg", "Lupe41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3515 Reichel Walks, West Haylie, Samoa", "07d913ca-f374-479c-9693-e906470ae8f3", new DateTime(2024, 2, 8, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(5295), "Zechariah31@hotmail.com", "Zechariah", "Breitenberg", "ZECHARIAH31@HOTMAIL.COM", "ZECHARIAH60", "AQAAAAIAAYagAAAAEGAnpZIzUJtdO2upk3ZeiT98jSK9AVaHVYVehcr+ZneCQ3G3hvvcNSAMyiecREO8iQ==", "171-733-7515", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1102.jpg", "Zechariah60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "98742 Bergnaum Fork, Langworthshire, Christmas Island", "08409b5c-2f2d-4e39-9952-8da6e81a0a41", new DateTime(2024, 7, 10, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(5474), "Clara_Jacobs@yahoo.com", "Clara", "Jacobs", "CLARA_JACOBS@YAHOO.COM", "CLARA62", "AQAAAAIAAYagAAAAEFH8oNJVSsienCXmLOtv4GW5/p6jIPiq82rZv0QPs0cDFSZAwm0xyA8TnpV+r3dSRA==", "987-083-2156", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/535.jpg", "Clara62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "139 Greenholt Mountain, Port Laceyhaven, Ghana", "e703ec1e-eb6f-46ea-82b0-44104c7e0df4", new DateTime(2024, 4, 12, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(5689), "Kirsten.Raynor56@hotmail.com", "Kirsten", "Raynor", "KIRSTEN.RAYNOR56@HOTMAIL.COM", "KIRSTEN_RAYNOR", "AQAAAAIAAYagAAAAEADdTds3Hzv9Wc0ojOx4vxcnO0XqPIY5xwPw0zRihotom4WiFEQuTerl/VhMbj5Mrg==", "082-848-3343", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1167.jpg", "Kirsten_Raynor" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5762 Aylin Ranch, Conorton, Tonga", "da0c6782-63ec-4ad5-9a92-c5fbc5af3239", new DateTime(2024, 3, 28, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(5865), "Palma_Dickens@hotmail.com", "Palma", "Dickens", "PALMA_DICKENS@HOTMAIL.COM", "PALMA_DICKENS", "AQAAAAIAAYagAAAAEAYaosBLsnN9fT2B4adQk6iMK5LD244h313lKCD76XNyLqs9O0DDMZE3vrstWm3wzQ==", "810-876-1064", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/764.jpg", "Palma_Dickens" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8888 Herman Parkway, Runolfsdottirtown, Libyan Arab Jamahiriya", "92ed5a40-7741-4cfc-b9ac-455b4b03856a", new DateTime(2024, 2, 15, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(6062), "William25@hotmail.com", "William", "Will", "WILLIAM25@HOTMAIL.COM", "WILLIAM_WILL3", "AQAAAAIAAYagAAAAELsWaK8qAo5oBFbU/qwLVqu+Jmljuze1n781FnfhjBItG/LIfcl27MWsij+qa4NdOQ==", "464-340-0276", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/30.jpg", "William_Will3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "191 Eliseo Rest, Dayanamouth, Saint Barthelemy", "52f94adb-a821-4301-922b-1fc833ae37c8", new DateTime(2024, 1, 1, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(6253), "Ansel_Keebler@yahoo.com", "Ansel", "Keebler", "ANSEL_KEEBLER@YAHOO.COM", "ANSEL.KEEBLER", "AQAAAAIAAYagAAAAEBOr2aFWH1Ldo47WGWrV61DnFn0VsNyfiylLt1d+8glY6Gh35Hfy6nd4xZ89mQLfNw==", "479-190-0446", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/994.jpg", "Ansel.Keebler" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0621 Anjali Fort, Lake Nedfort, Micronesia", "a6abb3a6-22ca-4e47-8392-4acee2638c2a", new DateTime(2024, 3, 8, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(6494), "May_Johnston4@yahoo.com", "May", "Johnston", "MAY_JOHNSTON4@YAHOO.COM", "MAY.JOHNSTON", "AQAAAAIAAYagAAAAEEbZXzyApjbqzk3fF/al3tGGrXiZXhC2+bzttXMJZcstXm8Zi5zVsVqQYE9bI4sWhg==", "136-330-3236", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/768.jpg", "May.Johnston" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "235 Barbara Vista, Shaniaborough, Isle of Man", "16fd147d-e53d-4f17-8444-66bb486ffbf6", new DateTime(2024, 10, 13, 6, 15, 7, 573, DateTimeKind.Utc).AddTicks(6673), "Jed_Quitzon@hotmail.com", "Jed", "Quitzon", "JED_QUITZON@HOTMAIL.COM", "JED_QUITZON2", "AQAAAAIAAYagAAAAEOlKK+c0IVJkPr1CdytofPWaZbX63uJHvKproKEECsyGC2BPwYlyYaa4yIgjgtmP3g==", "419-166-6825", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/152.jpg", "Jed_Quitzon2" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 9, 428, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 128, new DateTime(2024, 12, 18, 6, 15, 7, 540, DateTimeKind.Utc).AddTicks(5862), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Uniqlo Áo Polo Thoải Mái", 4317540.1677663763837148279184m, 3472532.087834561900000m, 383, "Kích thước: XS, S, L. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 63, 2, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9491), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Chanel Blazer Sang Trọng", 4249101.3941340976831914811617m, 3253746.988758479900000m, 317, "Kích thước: XXL, M, L. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 122, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9758), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Váy Liền Trẻ Trung", 1542972.8012491716865181121245m, 1235455.032252657650000m, 172, "Kích thước: XXL, M, XS. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 166, 1, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9804), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Chanel Đầm Dạ Hội Thời Thượng", 6268605.1326935572281826221395m, 4266169.712323220300000m, 366, "Kích thước: XS, M, XXL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 174, 5, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9884), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Zara Áo Sơ Mi Sang Trọng", 1901457.8470746726750222208254m, 1449368.826112093100000m, 492, "Kích thước: XL, XS, XXL. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 107, 1, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9918), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Khoác Sang Trọng", 4099751.8960911480454810607437m, 3372508.906288231550000m, 384, "Kích thước: S, XL, L. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 175, 3, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9952), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Zara Áo Len Trẻ Trung", 4010737.3215647084024703344013m, 2870464.897388885450000m, 432, "Kích thước: XL, M, L. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 199, 5, new DateTime(2024, 12, 18, 6, 15, 7, 545, DateTimeKind.Utc).AddTicks(9997), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Polo Cổ Điển", 2992696.7649861321887641882635m, 2156402.528218709600000m, 446, "Kích thước: XL, L, XXL. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 27, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(63), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Len Trẻ Trung", 1092101.2306532788650299176707m, 803702.299636655600000m, 268, "Kích thước: L, XS, XL. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 44, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(96), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "H&M Váy Liền Năng Động", 4943751.4424434200129421515757m, 3685982.617037586200000m, 440, "Kích thước: XS, S, L. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 172, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(127), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Uniqlo Quần Jean Trẻ Trung", 1068659.9139299684853544767365m, 761472.817347206750000m, 307, "Kích thước: M, XL, XS. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 1, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(159), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Gucci Áo Len Thoải Mái", 3255904.7772465319872063862027m, 2301459.272405256650000m, 79, "Kích thước: XL, S, M. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 166, 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(214), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Nike Quần Short Thời Thượng", 997277.4361703295185702165949m, 768994.28662181450000m, 385, "Kích thước: XS, L, M. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 68, 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(245), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Đầm Dạ Hội Trẻ Trung", 372747.41027568518212171390925m, 316992.4519645778450000m, 429, "Kích thước: S, XL, XXL. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 59, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(275), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp thể thao", "Gucci Quần Jogger Hiện Đại", 7074228.3290921235583361128774m, 4877517.25075403300000m, 56, "Kích thước: L, M, XXL. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 36, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(330), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Adidas Blazer Trẻ Trung", 784532.68372604097330970454073m, 586730.972947517150000m, 165, "Kích thước: S, XS, L. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 189, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(363), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Louis Vuitton Quần Jean Cổ Điển", 1198904.0924325564956349760679m, 1084946.242769626550000m, 449, "Kích thước: L, M, XS. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 66, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(392), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Áo Khoác Cổ Điển", 6304326.3959406708964663122849m, 4266290.145198302600000m, 329, "Kích thước: M, XXL, L. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 25, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(423), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "Chanel Quần Jogger Cổ Điển", 4598506.2255113322019640095810m, 3330611.519677071800000m, 370, "Kích thước: XL, XS, L. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 152, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(480), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Áo Khoác Trẻ Trung", 978464.3605380117292226398625m, 883845.047708187350000m, 42, "Kích thước: S, XXL, M. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 162, 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(510), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "H&M Quần Jean Thời Thượng", 1069327.4298663932400751630284m, 795166.643102134550000m, 246, "Kích thước: XL, M, XXL. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 33, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(541), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp thể thao", "H&M Áo Thun Cổ Điển", 917615.7204802892507552228166m, 720129.311055243050000m, 446, "Kích thước: L, M, XL. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 0, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(572), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Áo Thun Thời Thượng", 301086.67025311246868883627760m, 254970.5112473631800000m, 373, "Kích thước: L, M, S. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 80, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(619), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Gucci Váy Liền Năng Động", 2956600.4271001891905546899541m, 2040984.682768751450000m, 191, "Kích thước: L, XS, M. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 129, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(652), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Adidas Áo Thun Thoải Mái", 4928961.6545509136668521144708m, 3316849.179361780100000m, 406, "Kích thước: XXL, XS, S. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 55, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(684), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Thun Sang Trọng", 4600142.7111277739118364815854m, 3724410.820225333100000m, 198, "Kích thước: S, XL, XXL. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 152, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(763), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "H&M Blazer Sang Trọng", 1878532.1653974841833733699272m, 1442721.632135711900000m, 315, "Kích thước: XL, XXL, L. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 18, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(796), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp dạo phố", "Zara Đầm Dạ Hội Cổ Điển", 2431177.1567275791331879541160m, 1918475.927493043550000m, 162, "Kích thước: S, M, L. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 130, 3, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(827), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "Louis Vuitton Quần Short Sang Trọng", 1617023.3271486585529413629040m, 1273249.753574466200000m, 183, "Kích thước: L, XL, XS. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 59, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(857), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Chanel Áo Khoác Hiện Đại", 3301565.7043471868468300742194m, 2861971.198974434750000m, 358, "Kích thước: L, XS, XL. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 45, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(922), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Áo Polo Trẻ Trung", 6672472.8397202778963557720698m, 4452801.841732236800000m, 218, "Kích thước: S, XL, M. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 99, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(953), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Gucci Áo Thun Hiện Đại", 905303.6765483437787032252735m, 634626.120112405250000m, 275, "Kích thước: XL, S, M. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 137, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(982), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "H&M Váy Liền Hiện Đại", 4556736.8710029830180338747728m, 3825063.444498872900000m, 289, "Kích thước: XL, XS, XXL. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 76, 1, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1014), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Polo Hiện Đại", 744039.87058539231835067919603m, 628854.566486909900000m, 350, "Kích thước: L, XL, XXL. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 150, 4, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1072), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "Zara Quần Jean Hiện Đại", 4578648.6397906352465644063503m, 3342462.339061484600000m, 455, "Kích thước: L, S, M. Màu sắc: Đen, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 95, 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1101), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Khoác Sang Trọng", 5158791.5866741921187183724295m, 3748376.301881741150000m, 326, "Kích thước: L, S, M. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 93, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1131), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "H&M Blazer Cổ Điển", 5038033.4572280875410234757769m, 3547653.012859077050000m, 225, "Kích thước: XL, L, XS. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 150, 5, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1163), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp dạo phố", "Gucci Áo Thun Hiện Đại", 362544.46264997751232987696294m, 312872.773399382300000m, 123, "Kích thước: XXL, M, XL. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 40, 4, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1217), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Đầm Dạ Hội Năng Động", 1196512.4429549296307098470621m, 1038506.211189429350000m, 323, "Kích thước: L, S, M. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 153, 2, new DateTime(2024, 12, 18, 6, 15, 7, 546, DateTimeKind.Utc).AddTicks(1247), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Chanel Đầm Dạ Hội Năng Động", 5336527.3183058546613547607936m, 4828502.911545121550000m, 12, "Kích thước: S, XXL, M. Màu sắc: Đen, Đỏ" });
        }
    }
}
