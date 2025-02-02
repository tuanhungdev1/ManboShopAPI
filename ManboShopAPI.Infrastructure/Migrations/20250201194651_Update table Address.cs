using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class UpdatetableAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaOrColonyOrStreetOrSectorOrVillage",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "BuildingOrCompanyOrApartment",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "PinCode",
                table: "Addresses",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "FlatOrHouse",
                table: "Addresses",
                newName: "Country");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine",
                table: "Addresses",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0605 Reed Turnpike, North Jazmynefurt, Guadeloupe", "4847e74f-e4fc-45d3-a1d1-d287db85bd1c", new DateTime(2024, 3, 31, 19, 46, 49, 4, DateTimeKind.Utc).AddTicks(3261), "Nikolas.Lowe@hotmail.com", "Nikolas", "Lowe", "NIKOLAS.LOWE@HOTMAIL.COM", "NIKOLAS_LOWE77", "AQAAAAIAAYagAAAAEAQIcjQpgQHDsz1erd0bUoQTj+GScc4AhwGP07Ebd6tmY5qH6Lc8W0/wwyILIfy5/w==", "244-484-6156", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/602.jpg", "Nikolas_Lowe77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6752 Steve Expressway, East Michelle, Somalia", "219c651f-78b9-4f13-aee2-329fae42f279", new DateTime(2024, 9, 9, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(5746), "Ayla.Nikolaus@yahoo.com", "Ayla", "Nikolaus", "AYLA.NIKOLAUS@YAHOO.COM", "AYLA.NIKOLAUS", "AQAAAAIAAYagAAAAELLc3N4CxDyGOeK4vlDdomU9hwMLViJb1JJLQ5wUC/hPIivdPN4SEhMeB5mYPP6P9g==", "764-474-9176", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/679.jpg", "Ayla.Nikolaus" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9710 Lillian Run, West Haley, Kuwait", "4d410dfc-e927-4625-8e9d-e8ec2398ce15", new DateTime(2024, 11, 26, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(6181), "Amani56@gmail.com", "Amani", "Kilback", "AMANI56@GMAIL.COM", "AMANI.KILBACK", "AQAAAAIAAYagAAAAEAy6GiTEGXZBGLKGffq6OZslnyuG0U3cOa9KcT53v5VbJybw1VQdPg36u2BrnEcS0Q==", "973-961-0710", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1208.jpg", "Amani.Kilback" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "67398 Arne Radial, New Joel, Bermuda", "fafd3e95-6cec-4a8c-aa14-b4499524758f", new DateTime(2024, 10, 5, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(7535), "Marge_Konopelski@gmail.com", "Marge", "Konopelski", "MARGE_KONOPELSKI@GMAIL.COM", "MARGE.KONOPELSKI46", "AQAAAAIAAYagAAAAEFYwFjEOrsuayEzyNyVvfvgDagD43CnEqkxtPd0AM3Lo6qxkc2/9G2vm3LjRiPJA2Q==", "693-518-8570", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/913.jpg", "Marge.Konopelski46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "078 Mollie Glens, Mantebury, Montserrat", "ba3a9ddd-d9bd-4795-8f00-2d903650d4e5", new DateTime(2024, 5, 9, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(7812), "Alf88@gmail.com", "Alf", "Rohan", "ALF88@GMAIL.COM", "ALF_ROHAN50", "AQAAAAIAAYagAAAAELaM8IlHQ5hxItIt3LUvHEnrnBPOWw9XdmlMEwo1wlLfxWLnqxrJ0HChHwqavXzVLg==", "971-501-5454", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/177.jpg", "Alf_Rohan50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5529 Melvina Key, North Josephchester, Sudan", "91364031-7bed-4d84-be59-30321d24f1d2", new DateTime(2024, 7, 2, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(8107), "August26@gmail.com", "August", "Cummings", "AUGUST26@GMAIL.COM", "AUGUST.CUMMINGS59", "AQAAAAIAAYagAAAAEC9hasqWAgkeUuYe/w3RA8IxW8HJVu9t/HgOwTTqhyCmHCPVhZYZ2/rbvo+j5xlKTA==", "482-567-2634", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1093.jpg", "August.Cummings59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "13224 Dietrich Drive, Spencerchester, Singapore", "79109045-1ba8-4410-a5c3-5198c2de5eb8", new DateTime(2024, 6, 22, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(8336), "Nick46@gmail.com", "Nick", "Walsh", "NICK46@GMAIL.COM", "NICK_WALSH76", "AQAAAAIAAYagAAAAEO8vWaPPuadZ+hYH308qbV1LCIFBnzxYs6+QH0b5WmmAT7/xmDDL/UQDG9KMjVrcfw==", "912-350-2282", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/126.jpg", "Nick_Walsh76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8439 O'Hara Points, South Vicente, Japan", "cbcf6c51-71bf-4653-86da-df445a89b7ab", new DateTime(2024, 3, 16, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(8576), "Reece60@gmail.com", "Reece", "Hodkiewicz", "REECE60@GMAIL.COM", "REECE_HODKIEWICZ28", "AQAAAAIAAYagAAAAEKrCu/jHo3iLtpqoyZCATdN+wjOa/BKqvlqmCBzJSwzpSXxNTz83aI9lqgeN7HhZfg==", "222-789-1602", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/723.jpg", "Reece_Hodkiewicz28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "902 Lilly Square, West Tyreek, Syrian Arab Republic", "271d69a0-76b5-4210-8df0-04e6205fa4d2", new DateTime(2024, 5, 12, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(8771), "Jed_Pacocha@hotmail.com", "Jed", "Pacocha", "JED_PACOCHA@HOTMAIL.COM", "JED.PACOCHA", "AQAAAAIAAYagAAAAELJT0gLn0HG7Nj5wsjvSDj096WveWiqe/OygxNVkTSQdinxwiOtkKSVDQlGLFfpqug==", "579-646-4934", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/549.jpg", "Jed.Pacocha" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "73413 Zulauf Extensions, Stoltenbergburgh, Romania", "b4f461e4-22dc-496b-8e24-c0a8d95e41b1", new DateTime(2024, 9, 14, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(8998), "Laurie_Wuckert@gmail.com", "Laurie", "Wuckert", "LAURIE_WUCKERT@GMAIL.COM", "LAURIE.WUCKERT81", "AQAAAAIAAYagAAAAEMmt4Qrrn9qnqs3sBOThkFijRVErz/ZxklkxaF9MyqdcO1IBZYA0SjWgRlzHD3R7Dw==", "704-195-1503", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/823.jpg", "Laurie.Wuckert81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "78199 Hahn Turnpike, West Krista, Guernsey", "f8646e96-705b-4377-944a-ec3485357ccb", new DateTime(2024, 5, 21, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(9189), "Asia.Jacobi73@yahoo.com", "Asia", "Jacobi", "ASIA.JACOBI73@YAHOO.COM", "ASIA.JACOBI", "AQAAAAIAAYagAAAAEDNRW0qL3BqpF6JPB1Z7nRvbCukTCfhmPSbigWDfVV9ljzIZKFCUKoKgD6uF5f0ucQ==", "791-682-3754", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/880.jpg", "Asia.Jacobi" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "25922 Kreiger Tunnel, Dimitritown, Liechtenstein", "7bf809ab-a55e-48e7-9ef4-60b1ab5665e8", new DateTime(2024, 5, 29, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(9440), "Pete_Pfannerstill32@yahoo.com", "Pete", "Pfannerstill", "PETE_PFANNERSTILL32@YAHOO.COM", "PETE.PFANNERSTILL", "AQAAAAIAAYagAAAAEIZhKioekDBP1iU8xE0rzmS112Jfd1D5W2nCvhzMkpdTI4W9xKMThNPSu4VA397NvQ==", "187-555-6428", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1245.jpg", "Pete.Pfannerstill" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "693 Troy Shores, Lefflerview, Cayman Islands", "ac58b51f-f7cf-4689-be2e-cc4e449ea002", new DateTime(2024, 9, 19, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(9642), "Jaiden15@yahoo.com", "Jaiden", "Windler", "JAIDEN15@YAHOO.COM", "JAIDEN_WINDLER", "AQAAAAIAAYagAAAAEN+R29x0i09aMtHztIVDpxHkC96hNlM79SFaZvM2bjsEy1rCPahjqFotg32lpfZNDw==", "552-697-0749", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/709.jpg", "Jaiden_Windler" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "03099 Westley Coves, Augustineside, Ghana", "10d49f6b-eaa4-46bb-8bea-0ce61bb029a3", new DateTime(2024, 5, 26, 19, 46, 49, 5, DateTimeKind.Utc).AddTicks(9863), "Kristina_Bogan49@hotmail.com", "Kristina", "Bogan", "KRISTINA_BOGAN49@HOTMAIL.COM", "KRISTINA38", "AQAAAAIAAYagAAAAED9GBKtSf3OGdfCotMsptGiT+LFZ8b8n8b16tDjufq1IgruNYXfOqivl+Vn+5HiF5A==", "928-324-2692", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/864.jpg", "Kristina38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "119 Koepp Mountains, New Jenningshaven, Finland", "ee09c439-0444-458b-8e7d-c1d6bee75be7", new DateTime(2024, 11, 11, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(67), "Guido84@gmail.com", "Guido", "Effertz", "GUIDO84@GMAIL.COM", "GUIDO11", "AQAAAAIAAYagAAAAENKk7cSoJznvZ5f7cTiG0c739JCjulwrpz3iLdLps5ghu2Go71HLAM+4QkD//Il3yQ==", "394-205-1515", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1241.jpg", "Guido11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "511 Hirthe Lodge, South Isadore, Georgia", "b511d441-2f51-4d27-9ec9-7559c0beb5cb", new DateTime(2024, 4, 12, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(274), "Lily44@yahoo.com", "Lily", "Dickinson", "LILY44@YAHOO.COM", "LILY_DICKINSON32", "AQAAAAIAAYagAAAAEGmRGTjTydO267zevq6fJmAetN7Y87/FFc2MT/MAb4x6j5njRtFpNSUk6SOwORsGbA==", "559-995-5336", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/680.jpg", "Lily_Dickinson32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "77201 McGlynn Dam, Lake Ardith, Eritrea", "f1b1027c-78d8-4078-bb2f-21be96273499", new DateTime(2024, 6, 28, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(471), "Emily69@gmail.com", "Emily", "Brown", "EMILY69@GMAIL.COM", "EMILY_BROWN", "AQAAAAIAAYagAAAAELPGCcjk4rAbV2hE8sWNrPVVt+oPbAhkisN+UeRobljBKPdQwfY0/FW22Ezb9FhTkQ==", "606-853-1974", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1243.jpg", "Emily_Brown" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5434 Brady Gateway, Emilioton, Netherlands Antilles", "fa05736c-f085-4b37-b4ce-2f5b4005bc81", new DateTime(2024, 4, 3, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(707), "Candido93@yahoo.com", "Candido", "Leuschke", "CANDIDO93@YAHOO.COM", "CANDIDO.LEUSCHKE83", "AQAAAAIAAYagAAAAEL6ezJS8rVe4V1mAcpBYK1+rb9RmD3ySvzBMwAscFpqscEfCAmwV1uxQQwHjf8Phrw==", "716-549-4482", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/632.jpg", "Candido.Leuschke83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3447 Hyatt Junction, Boyleburgh, Finland", "fc0c8cbe-c44a-46c7-9fad-0cbd8b4b6137", new DateTime(2024, 2, 28, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(890), "Brielle_Durgan@gmail.com", "Brielle", "Durgan", "BRIELLE_DURGAN@GMAIL.COM", "BRIELLE96", "AQAAAAIAAYagAAAAECV/e69aITZcVdEvN5Bo1ZTXbEOKcMXAUaw+F4X041yuyQUU4kGBbDBaaLF4K+sBGQ==", "627-287-0880", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1044.jpg", "Brielle96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "792 Bernier Center, New Sageshire, El Salvador", "04a23839-fda1-4f67-8a75-95eab863e5bf", new DateTime(2024, 3, 30, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(1111), "Joshua_Hettinger@hotmail.com", "Joshua", "Hettinger", "JOSHUA_HETTINGER@HOTMAIL.COM", "JOSHUA39", "AQAAAAIAAYagAAAAEFTaPYp8nwjKHag/txPi344QlUtkWhiyU3j8vNCZL0x1a/FZaWqYuIxtSg8khK60ig==", "037-729-6764", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/612.jpg", "Joshua39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0746 Ayla Ports, New Jeanie, Malawi", "31eb0e8b-ef12-4e2d-95f8-63aa696e4987", new DateTime(2024, 5, 14, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(1300), "Destiney_Jerde@yahoo.com", "Destiney", "Jerde", "DESTINEY_JERDE@YAHOO.COM", "DESTINEY_JERDE", "AQAAAAIAAYagAAAAEJpJaPPex9/eXA1sZ6u4UIrlqi2sAXi3/31Lt6grttSyxuIBrsJ6uY1rxTfK/7wq2A==", "947-967-7698", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/809.jpg", "Destiney_Jerde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "859 Guiseppe Knoll, Alexzanderburgh, American Samoa", "1fc85db4-3062-4b0c-9190-c0e8b81b66cb", new DateTime(2024, 11, 14, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(1522), "Jaunita.Turner78@yahoo.com", "Jaunita", "Turner", "JAUNITA.TURNER78@YAHOO.COM", "JAUNITA_TURNER2", "AQAAAAIAAYagAAAAEPbWDdGd/kAwetqYtuwo3o63+q291tpz6rjSInGclnCF+JRdVdDSIO/QF6ThhVyxzw==", "814-001-1414", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/406.jpg", "Jaunita_Turner2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0494 Celestine Walk, Pacochamouth, Liechtenstein", "f3cec2b1-2659-4c12-a04c-b25e240dbe89", new DateTime(2024, 5, 13, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(1723), "Sandrine74@yahoo.com", "Sandrine", "Abshire", "SANDRINE74@YAHOO.COM", "SANDRINE.ABSHIRE", "AQAAAAIAAYagAAAAEOmAzaJlIUkMmMnE9rCj5tPWMnukTjDAKGotv/UGf2Jq72LHIQRDFUB5l7Pkt8i0bw==", "249-240-7331", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/462.jpg", "Sandrine.Abshire" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6610 Romaguera Forge, New Dorthahaven, Guernsey", "3ee93a11-d410-4c6e-94c1-fb76433bede3", new DateTime(2024, 11, 20, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(1948), "Kristina.Stokes14@gmail.com", "Kristina", "Stokes", "KRISTINA.STOKES14@GMAIL.COM", "KRISTINA.STOKES39", "AQAAAAIAAYagAAAAEOMZqT7SXfMq1USmtNMjYNLWKWEF8+lieTBZ3LINFPiM+rOtx5RXPF7kC6Nb6/2lKQ==", "054-489-0899", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/650.jpg", "Kristina.Stokes39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "03835 Block Mission, Francofort, Egypt", "8ddd1fba-5580-4a79-98ca-2bc8f0af6048", new DateTime(2024, 7, 17, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(2170), "Katarina_Tremblay2@gmail.com", "Katarina", "Tremblay", "KATARINA_TREMBLAY2@GMAIL.COM", "KATARINA.TREMBLAY", "AQAAAAIAAYagAAAAEKXgm30leAdETLMtMlimuN1jGnppqDFZ8NfuLxjbGmLilSKBZlXHUkG275ls7Ja1zw==", "291-845-6354", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1104.jpg", "Katarina.Tremblay" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7630 Hoppe Stravenue, Deckowchester, Guinea", "d86e5847-4248-492d-a72b-448363086eca", new DateTime(2024, 3, 31, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(2384), "Lilian55@yahoo.com", "Lilian", "Beatty", "LILIAN55@YAHOO.COM", "LILIAN87", "AQAAAAIAAYagAAAAEIVWOrD5T8jhoBBY044f+RtDhM30g9rTwYXTaWLjcuvFpzWz1Ji5ozplJ7Sq01wc+g==", "967-058-6786", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/13.jpg", "Lilian87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "65348 Emilia Pass, Brannonport, Switzerland", "ad243747-1cd9-4430-8208-b63f24006850", new DateTime(2024, 6, 9, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(2597), "Brice_Sanford@yahoo.com", "Brice", "Sanford", "BRICE_SANFORD@YAHOO.COM", "BRICE.SANFORD16", "AQAAAAIAAYagAAAAEI5R8pgwoG6FlFwlKGfkd1D4id99sSM9Ybd4CzBx8UfCMnE7xdebtZ9y/NLQ8JNhVQ==", "426-657-8198", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1104.jpg", "Brice.Sanford16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2168 Bertram Roads, New Retta, Western Sahara", "bfc333e9-58e1-4ba1-9f3c-1906daee68a8", new DateTime(2024, 5, 7, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(2802), "Barney18@yahoo.com", "Barney", "Boehm", "BARNEY18@YAHOO.COM", "BARNEY.BOEHM67", "AQAAAAIAAYagAAAAEBvaTgKA/5j17MgIXluirq2hIR0QLuD3mmlZW0bIhV/DynNGyMWmNB3SYOPBo0/3tw==", "603-087-3179", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/787.jpg", "Barney.Boehm67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0344 Quigley Harbor, Ortizshire, Saint Lucia", "51bdab0d-e06e-460f-9a1a-632fad6e6e2d", new DateTime(2024, 11, 9, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(3009), "Noelia71@hotmail.com", "Noelia", "Kunde", "NOELIA71@HOTMAIL.COM", "NOELIA49", "AQAAAAIAAYagAAAAEOaRUhBBkizz9IXa5nvEi6+p9bWQS2vc5X4kKCt8AYu5iZVOYEoYiYdGhGrJTzd55w==", "836-370-3323", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/530.jpg", "Noelia49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "061 Flavie Mountain, Trompville, Saint Pierre and Miquelon", "1347a86c-9e67-4ac9-9690-0bd5dbf8ca8d", new DateTime(2024, 4, 8, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(3216), "Patience_Runolfsdottir79@gmail.com", "Patience", "Runolfsdottir", "PATIENCE_RUNOLFSDOTTIR79@GMAIL.COM", "PATIENCE.RUNOLFSDOTTIR", "AQAAAAIAAYagAAAAEAAQ/HkAGB1NIrOhE6zaIILZr+ftzu3g3l+r8VrM5ImQFAmXw5bGmJtO9g8JlqX8BQ==", "449-646-7198", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/643.jpg", "Patience.Runolfsdottir" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "28518 Salvatore Tunnel, Hollyview, Kazakhstan", "c8770ab2-4e9d-434a-b4db-07208217d192", new DateTime(2024, 3, 12, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(3425), "Omer_Schmitt@hotmail.com", "Omer", "Schmitt", "OMER_SCHMITT@HOTMAIL.COM", "OMER.SCHMITT39", "AQAAAAIAAYagAAAAEGQsj/3JLmlMZAOEt7+WULWmetVKwOCzgGoym9uf3W1spSTha1DxjGfYL/f7uMXzZQ==", "629-155-1030", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/263.jpg", "Omer.Schmitt39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "082 Alfonzo Corners, Collierport, Slovakia (Slovak Republic)", "2e79c8c8-b43c-4940-a800-7f67d2a55a70", new DateTime(2024, 12, 30, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(3596), "Leon26@yahoo.com", "Leon", "Sanford", "LEON26@YAHOO.COM", "LEON_SANFORD31", "AQAAAAIAAYagAAAAEJYvbtyFLZ/8QSqEdTt8gQWrDvYhpJFUZfpwsqITH4sAGQthw+PQYMbMahTwbiw9lg==", "446-091-6600", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/755.jpg", "Leon_Sanford31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "843 Murphy Turnpike, Alessiaberg, Zambia", "a82f54d6-9265-41cd-982a-05eb8fcb1e00", new DateTime(2024, 12, 17, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(3819), "Idella.Bayer59@hotmail.com", "Idella", "Bayer", "IDELLA.BAYER59@HOTMAIL.COM", "IDELLA73", "AQAAAAIAAYagAAAAEIFSU7Cr/ff0FLysSN5AcTNbv90BWJZgwEMCD7ZawtwrnGCJoop40Swb+yEpmKF+xw==", "617-762-6416", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/284.jpg", "Idella73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "99131 Fiona Stravenue, West Carissaborough, Nauru", "a8d046a1-d40e-4dd6-bf94-cca08fec3eca", new DateTime(2024, 3, 12, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(4023), "Tessie_Wintheiser@hotmail.com", "Tessie", "Wintheiser", "TESSIE_WINTHEISER@HOTMAIL.COM", "TESSIE_WINTHEISER75", "AQAAAAIAAYagAAAAEKsGwdJTKNIC1geHOV2J+7QGqysok3PqyIZ2YAEGlblLy2rrK5rQ6wKJe+36GGGaXQ==", "805-523-5827", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/938.jpg", "Tessie_Wintheiser75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1196 Will Rapids, Lake Janick, Myanmar", "cb28839d-7b14-455f-b5a9-73302b7dd8cb", new DateTime(2024, 6, 27, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(4235), "Kattie_Homenick@gmail.com", "Kattie", "Homenick", "KATTIE_HOMENICK@GMAIL.COM", "KATTIE_HOMENICK", "AQAAAAIAAYagAAAAEI/3PabFJmsFP0BaUAtsqO18mLYUtVNjLWWaBUECzl7JWgMtmcBbVTy/a6FCkKj1Eg==", "724-482-8446", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/104.jpg", "Kattie_Homenick" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "732 Candido Parks, Port Shannon, Burundi", "972f2c55-3007-419f-8351-48af746d4cec", new DateTime(2024, 9, 30, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(4420), "Tina.Rodriguez@hotmail.com", "Tina", "Rodriguez", "TINA.RODRIGUEZ@HOTMAIL.COM", "TINA.RODRIGUEZ50", "AQAAAAIAAYagAAAAECY5gKpMyWA/BGMy3wVrUkVSK5sue83aFsVUFmH5bAW15P7vj4QXu1FiPWCEuzl1hw==", "824-003-8803", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1154.jpg", "Tina.Rodriguez50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6410 Rath Key, Brekkeside, Ireland", "13ef555d-1f84-4f09-9331-bd7ff87a12dc", new DateTime(2024, 8, 31, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(4624), "Shanelle98@gmail.com", "Shanelle", "Lubowitz", "SHANELLE98@GMAIL.COM", "SHANELLE75", "AQAAAAIAAYagAAAAEC/MKvTEbAiXeqdgbKtoAT4mImlpaaUcrSGsakp5ebZ2hGd3QBxfB2nTUohKUaWksA==", "256-886-7286", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/291.jpg", "Shanelle75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "502 Carmella Ford, New Ayanashire, New Caledonia", "125a9115-1232-4101-9333-6947fcf615d9", new DateTime(2025, 1, 29, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(4816), "Tyson_Bode6@gmail.com", "Tyson", "Bode", "TYSON_BODE6@GMAIL.COM", "TYSON_BODE80", "AQAAAAIAAYagAAAAEGNh9PxGZdJtNl/aTKjnad4rP49S9TrWqlcf1Z5AhfatnpOXyS792HgTFKX10pJsaA==", "827-980-9926", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/286.jpg", "Tyson_Bode80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "414 Georgianna Pines, Alanaberg, El Salvador", "37cbb5c6-16e3-4998-83b0-0fa374f3563f", new DateTime(2024, 5, 22, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(5026), "Peggie.Lind79@gmail.com", "Peggie", "Lind", "PEGGIE.LIND79@GMAIL.COM", "PEGGIE_LIND", "AQAAAAIAAYagAAAAEG4+82sOQ4OvWtYep9Tv6O/O11oSoaxbGGuwymI8BugpRBDRbl1ITm/QSL571MRNEA==", "500-181-7388", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/747.jpg", "Peggie_Lind" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "82502 Rebeka Expressway, Bartonland, Netherlands Antilles", "ff7ccb13-6935-4b93-9706-503a363ea7ab", new DateTime(2024, 3, 14, 19, 46, 49, 6, DateTimeKind.Utc).AddTicks(5204), "Odie28@yahoo.com", "Odie", "Littel", "ODIE28@YAHOO.COM", "ODIE18", "AQAAAAIAAYagAAAAEC69pI9yaZK2Un0zH0Fc93fZP6dwbVjAgzWEyw31gRO1oJgDoH5vBfcmozkgiNokCw==", "161-395-9659", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/508.jpg", "Odie18" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Addresses",
                newName: "PinCode");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Addresses",
                newName: "FlatOrHouse");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "AreaOrColonyOrStreetOrSectorOrVillage",
                table: "Addresses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BuildingOrCompanyOrApartment",
                table: "Addresses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "58780 Luettgen Village, Yazminmouth, Syrian Arab Republic", "4174aff9-db29-4820-81f7-68168fd7fe45", new DateTime(2025, 1, 15, 23, 41, 6, 630, DateTimeKind.Utc).AddTicks(7288), "Macey_Mayert@hotmail.com", "Macey", "Mayert", "MACEY_MAYERT@HOTMAIL.COM", "MACEY_MAYERT", "AQAAAAIAAYagAAAAENhw/3YUWFOCfFec61QWL/e2adWF706g45wr0THUkJ1fNUnwFtNQIgJkNOGSy/V9vQ==", "826-992-7638", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/562.jpg", "Macey_Mayert" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "160 Kling Lock, East Esta, Indonesia", "0a36978c-0154-44e2-91ff-cb5cca18ec3d", new DateTime(2024, 10, 2, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(1648), "Dasia_Wolff34@hotmail.com", "Dasia", "Wolff", "DASIA_WOLFF34@HOTMAIL.COM", "DASIA69", "AQAAAAIAAYagAAAAEMNi6p1RNU32qlU65JL/SU88wKA4NqJ+d8y99KtTQurLtBwHF848v3DE29HaaLr6nA==", "798-941-0101", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/115.jpg", "Dasia69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "17572 Jenkins Causeway, Karianneshire, Cook Islands", "49dabacc-e98c-48c7-91ee-a67fb20e66a6", new DateTime(2024, 3, 27, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(1989), "Emilio70@hotmail.com", "Emilio", "Skiles", "EMILIO70@HOTMAIL.COM", "EMILIO_SKILES", "AQAAAAIAAYagAAAAEKekyM1nZ7q0h7wgmplYErnXAK/c7V4pb6nJFilru0Y/eloIVmQNToIsNg7BnuUR/Q==", "386-601-8101", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/346.jpg", "Emilio_Skiles" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "150 Micah Fort, Arjunbury, Norway", "800c350a-3bdd-4be8-88f6-0e1272ac6662", new DateTime(2024, 2, 5, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(3436), "Wilhelmine86@gmail.com", "Wilhelmine", "Leuschke", "WILHELMINE86@GMAIL.COM", "WILHELMINE_LEUSCHKE73", "AQAAAAIAAYagAAAAEOQIKuAkyD4zWxHBJYEYd9agMZz+tGLgylEQH2BaeVbaq4zekUA8Yt+nOrIHi9jUSw==", "654-337-9415", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/211.jpg", "Wilhelmine_Leuschke73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "333 Gerhold Brook, West Reedberg, Senegal", "9a2782eb-6100-4da5-832e-85c9621c07aa", new DateTime(2024, 9, 18, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(3735), "Madeline32@gmail.com", "Madeline", "Torp", "MADELINE32@GMAIL.COM", "MADELINE67", "AQAAAAIAAYagAAAAEBDMn7Cl+E+JOyKainPiOl4vM0e7d1CUA7Ro5HqAKrMZIMcdCpMglsScCfEUPaHTEQ==", "364-651-5463", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/601.jpg", "Madeline67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "85807 Rutherford Highway, Lake Raquelfort, Nauru", "e3d3126d-3497-4f74-9c09-c6e936d751bf", new DateTime(2024, 9, 27, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(4017), "Cecelia.Pacocha@yahoo.com", "Cecelia", "Pacocha", "CECELIA.PACOCHA@YAHOO.COM", "CECELIA.PACOCHA90", "AQAAAAIAAYagAAAAEBPNnQUD9H9j0+Ctsu8NsQy1UtreXaFJAzBRtp17ncjZJFa2TjmCcfjHtTV2174PYQ==", "874-846-6876", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/942.jpg", "Cecelia.Pacocha90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "31437 Treutel Haven, Franciscoshire, Hong Kong", "f2f2f70a-69e9-41c4-a809-d54f34fb1127", new DateTime(2024, 5, 13, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(4322), "Pattie74@gmail.com", "Pattie", "Cassin", "PATTIE74@GMAIL.COM", "PATTIE24", "AQAAAAIAAYagAAAAEMVUv1CNwoCla5sw+cAWzAd9aF3DkslcXDBFgYqrsoYTTtzMEj0be8oCqRtvMuc2Ug==", "099-958-6176", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1152.jpg", "Pattie24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "810 Shanahan Green, Ferryville, Jersey", "73f072ff-23d3-4b69-8819-03c9d57f5743", new DateTime(2024, 9, 3, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(4543), "Helmer_Howe@hotmail.com", "Helmer", "Howe", "HELMER_HOWE@HOTMAIL.COM", "HELMER_HOWE", "AQAAAAIAAYagAAAAEKhiqBHwfJMGsdBy2cHZ0c0WBECXqgGHxNPqR+V+sGd27cOvfnOgR6CdUEAwKREeIA==", "577-401-9922", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1149.jpg", "Helmer_Howe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3250 Kreiger Terrace, Spencerfurt, Armenia", "be99e968-c5e0-49ef-ade4-6baa3c0efefb", new DateTime(2024, 7, 29, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(4795), "Oceane.Schinner@yahoo.com", "Oceane", "Schinner", "OCEANE.SCHINNER@YAHOO.COM", "OCEANE_SCHINNER", "AQAAAAIAAYagAAAAEPTt9265ajFg/4OWnaHkRfuFP7lNTzlnqd8corni8E+cQThj7Ead9Q2PlrOYgsfZoA==", "663-258-3019", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/93.jpg", "Oceane_Schinner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "121 Evan Mill, New Karsonberg, British Indian Ocean Territory (Chagos Archipelago)", "dc906e11-e49c-429a-ab1d-e80a4eca518a", new DateTime(2024, 5, 31, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(5009), "Sister.Orn50@yahoo.com", "Sister", "Orn", "SISTER.ORN50@YAHOO.COM", "SISTER_ORN58", "AQAAAAIAAYagAAAAEMUGYy43EfciMDRNQToPB1s9qrgdA3Wj+UJXlJpvOH56ELo4pDNW4FPQgY5ItksYNQ==", "893-542-5512", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/399.jpg", "Sister_Orn58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "55174 Alanna Port, South Ernesto, Suriname", "3b481daf-ec59-4deb-9a0f-c73baae61119", new DateTime(2024, 4, 13, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(5214), "Aubree.Crist15@yahoo.com", "Aubree", "Crist", "AUBREE.CRIST15@YAHOO.COM", "AUBREE84", "AQAAAAIAAYagAAAAEOIxerp2KJoctyM7eq2iyz6muJnwHJ/jIPrpOCJCRC8SRkeVxlPoRMPjMnT59/b3mQ==", "767-101-6287", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/574.jpg", "Aubree84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "677 Blick Trace, Cassinchester, Norway", "a3fba304-c3b5-431c-ba11-a40bbfb22edc", new DateTime(2024, 8, 6, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(5440), "Columbus47@gmail.com", "Columbus", "Jacobi", "COLUMBUS47@GMAIL.COM", "COLUMBUS55", "AQAAAAIAAYagAAAAEK7p+TNq88+J3Ox3A06TF4E8h/amSEba38M0OuAkG7CZPBqIzDXJDRU2yVia/LDf4w==", "732-758-8054", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/664.jpg", "Columbus55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0039 Dillan Walks, East Budside, Zimbabwe", "72697929-17ea-45ad-a04b-728fc775c948", new DateTime(2024, 3, 5, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(5702), "Shany52@gmail.com", "Shany", "Hettinger", "SHANY52@GMAIL.COM", "SHANY_HETTINGER72", "AQAAAAIAAYagAAAAEK5YODtZqEymFALbV/RjSalHkHZ9/I+JR4y+Zr1Gk5v2uLDfVvMpq7n9B+8l1N2JWQ==", "347-914-5997", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/548.jpg", "Shany_Hettinger72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "91780 Cole Valley, Port Delaney, Kuwait", "7df17bb7-4918-4c16-87a4-afabe7d0edfb", new DateTime(2024, 10, 9, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(5916), "Ezra_Gleason@hotmail.com", "Ezra", "Gleason", "EZRA_GLEASON@HOTMAIL.COM", "EZRA.GLEASON27", "AQAAAAIAAYagAAAAEM5fR1AqeG/usUs559ouaUF61CWCOPZl70K3eJyPtmTQpr9SeHlpSc81a0G4IOLbJw==", "901-373-4325", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/539.jpg", "Ezra.Gleason27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "452 Shea Freeway, North Aliciaview, Iraq", "5ba6f4f6-19b5-48ef-a760-59bd61eb5b75", new DateTime(2024, 12, 20, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(6185), "Chauncey_Runolfsdottir33@yahoo.com", "Chauncey", "Runolfsdottir", "CHAUNCEY_RUNOLFSDOTTIR33@YAHOO.COM", "CHAUNCEY_RUNOLFSDOTTIR", "AQAAAAIAAYagAAAAEL8yAxjgDvNlbDp2AUTiOY07pWVv9IEZlxZczaOHwE7k/RhSn1nbgXJLHNoY387Ylw==", "527-095-7041", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/454.jpg", "Chauncey_Runolfsdottir" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "70773 Jaiden Underpass, Kathrynechester, Libyan Arab Jamahiriya", "4fe39194-d431-4174-867c-80b3341b1d84", new DateTime(2024, 7, 22, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(6394), "Saige.Labadie68@gmail.com", "Saige", "Labadie", "SAIGE.LABADIE68@GMAIL.COM", "SAIGE_LABADIE", "AQAAAAIAAYagAAAAEJSoxNJuXLiRXDKtL6acuugEq9NQS02Fx7keuGyB/kYDzGHodn8u269I7i2DsZR5SQ==", "345-864-1193", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/575.jpg", "Saige_Labadie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "61039 Morar Square, Kohlerborough, Senegal", "2f2e5670-5bca-4fb4-ac04-046e8b1c7aa4", new DateTime(2024, 9, 8, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(6642), "Dereck85@yahoo.com", "Dereck", "Schroeder", "DERECK85@YAHOO.COM", "DERECK.SCHROEDER81", "AQAAAAIAAYagAAAAEP2AFO6hwLeLc8oS30TXX6GTQqZVEu4u1fny3XwCGl3FH8zLeciUAxealcj/OLHahQ==", "659-413-5823", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/83.jpg", "Dereck.Schroeder81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "671 Hilpert Trail, West Angie, Tanzania", "75de1c77-6472-4f98-b286-9990beac16d0", new DateTime(2024, 5, 30, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(6847), "Dale.Rippin@hotmail.com", "Dale", "Rippin", "DALE.RIPPIN@HOTMAIL.COM", "DALE_RIPPIN48", "AQAAAAIAAYagAAAAECx28/uvjgvDE9sE8zgIZzVHFNdFirafhRnclES+9EhInWHrQt8mlG1kLuA7LAb4OA==", "000-503-4993", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/122.jpg", "Dale_Rippin48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "10686 Oran Burg, Port Aliyah, Iraq", "656eeeec-9231-4b91-8d0c-4dff03be8c4c", new DateTime(2025, 1, 7, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(7072), "Breana.Heller8@gmail.com", "Breana", "Heller", "BREANA.HELLER8@GMAIL.COM", "BREANA15", "AQAAAAIAAYagAAAAENjOPCjEj0vrVuceYmrUYQWD6JqtLEw+sfdDl/xAmmTHaSfHKh04M/zvL3Vfsjo3hw==", "684-649-9781", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1067.jpg", "Breana15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1284 McKenzie Field, North Simeonstad, Moldova", "650a93c1-3b34-4293-8512-5e6f48242cfa", new DateTime(2024, 8, 30, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(7280), "Ramiro_Jacobi97@hotmail.com", "Ramiro", "Jacobi", "RAMIRO_JACOBI97@HOTMAIL.COM", "RAMIRO_JACOBI25", "AQAAAAIAAYagAAAAEC0KaMFPKJ4HGt7VRAFb1ztzgYv4F7hXhX8yQSOgoPNOq4LY43Vd6XywKXRNKMZzMQ==", "277-108-9292", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1246.jpg", "Ramiro_Jacobi25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "30696 Murazik Crossing, Meganemouth, United Arab Emirates", "23b286bf-ceef-472c-90bc-eba59e87871a", new DateTime(2024, 8, 13, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(7519), "Kaelyn_Brekke30@hotmail.com", "Kaelyn", "Brekke", "KAELYN_BREKKE30@HOTMAIL.COM", "KAELYN.BREKKE", "AQAAAAIAAYagAAAAEAEl5edQJffv5mLLTCfQZTPBUo0jXVf3HotVNrtJbEPWETMNiUyedHkf4pD97XEv3g==", "676-053-8705", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/894.jpg", "Kaelyn.Brekke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1795 Waters Port, Port Dulce, Seychelles", "4ab22616-7fcf-4d9c-9d1a-2d0f95da33cb", new DateTime(2024, 6, 26, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(7714), "Friedrich.Sipes@yahoo.com", "Friedrich", "Sipes", "FRIEDRICH.SIPES@YAHOO.COM", "FRIEDRICH18", "AQAAAAIAAYagAAAAEL3e4CIpj++mJWbXUXbTuT2d/ukJwOfhTdrXmxsdCIi3QKJ91v9/sj+nOCFMbdrfSA==", "149-623-4100", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/113.jpg", "Friedrich18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "045 Herzog Rue, East Kaylieland, Georgia", "e8092500-ad54-41fc-bb70-0fdf5085583c", new DateTime(2024, 2, 26, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(7990), "Nathanael_Robel39@yahoo.com", "Nathanael", "Robel", "NATHANAEL_ROBEL39@YAHOO.COM", "NATHANAEL_ROBEL91", "AQAAAAIAAYagAAAAEPjBtMw0aFJ6TVHVripp3aJbJ6iy8HWHymHQGx9tHNGMa2WqLo9F2KzTBQ5Uuy3FPA==", "739-815-9552", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/305.jpg", "Nathanael_Robel91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7080 Vincenzo Well, Lake Sydney, Cyprus", "1afab850-4353-4d3e-9afb-065162cae94d", new DateTime(2024, 6, 23, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(8180), "Elias.Kulas@yahoo.com", "Elias", "Kulas", "ELIAS.KULAS@YAHOO.COM", "ELIAS.KULAS", "AQAAAAIAAYagAAAAEEnn7JnF1DE5MS7vd9SmrE7cpBcirq1xAdowHNqXK+tFMIb4WoPG8F5ppi4Jcip4Kg==", "514-793-7333", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/818.jpg", "Elias.Kulas" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "480 Elaina Hollow, Deionton, Barbados", "1d2c6189-ba76-40ef-bf36-b4833477c4d2", new DateTime(2024, 5, 20, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(8421), "Taylor7@hotmail.com", "Taylor", "Mayer", "TAYLOR7@HOTMAIL.COM", "TAYLOR32", "AQAAAAIAAYagAAAAEF0tyAB4uJO3ArDrtmlHI+nL+TLEkYPRaPjE3v05y70HwqUfvO9Wx86vRJFtJpNZnw==", "185-587-8926", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/950.jpg", "Taylor32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2795 Emmerich Fork, Wilfredborough, Falkland Islands (Malvinas)", "15436e16-d73a-48b9-a59a-4e2ca010faf4", new DateTime(2024, 10, 30, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(8660), "Madyson.Torphy54@hotmail.com", "Madyson", "Torphy", "MADYSON.TORPHY54@HOTMAIL.COM", "MADYSON_TORPHY98", "AQAAAAIAAYagAAAAEHht1Qx/QiTktZzEb19x9n3fS5K3r1eCY6jLb8SugqT9g4bIoPA4Fdqb+oIOvVpZgA==", "240-392-6307", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/367.jpg", "Madyson_Torphy98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "528 Dejuan Shoals, Isacfurt, Bhutan", "f72576f4-86ba-4ce9-8c61-a8a4dfccfb5c", new DateTime(2024, 2, 20, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(8893), "Granville48@yahoo.com", "Granville", "Boyer", "GRANVILLE48@YAHOO.COM", "GRANVILLE.BOYER59", "AQAAAAIAAYagAAAAEBUXQFE8VJMpEWJpgPsXQ+WyS72eq8B5Zo7P6NPF+ltRwwIzKttakWQkmO+3BjY5gQ==", "855-879-6518", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/161.jpg", "Granville.Boyer59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0817 Bogan Fall, Lake Jennifershire, United States Minor Outlying Islands", "4023c08b-9a76-4cc0-aaec-a5386c847f02", new DateTime(2024, 9, 25, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(9107), "Vance_Beatty40@gmail.com", "Vance", "Beatty", "VANCE_BEATTY40@GMAIL.COM", "VANCE_BEATTY", "AQAAAAIAAYagAAAAEO8r9YUEja8pV9Aohc2/3e8Gr6TUcFK1/vRG2wp9OdXDWlXEnVofyKmdujlaAO9Qxw==", "643-774-5746", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/589.jpg", "Vance_Beatty" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1575 Stark Manors, Kunzeshire, Saint Barthelemy", "cb10f7ff-1bed-4eeb-acf8-b4d4421e7c6b", new DateTime(2024, 4, 3, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(9353), "Jerrell_Osinski61@hotmail.com", "Jerrell", "Osinski", "JERRELL_OSINSKI61@HOTMAIL.COM", "JERRELL.OSINSKI", "AQAAAAIAAYagAAAAEADwEa45q587C7Nk3l2i8L7nAxvb8Y6VUdF9i3WyqaUZcPlR7OmcodnPmB/tsU7L5A==", "452-471-8882", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/511.jpg", "Jerrell.Osinski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6765 Aurelie Villages, North Caylaville, Solomon Islands", "dc40f233-16a5-4ebb-9092-078ba317820a", new DateTime(2025, 1, 27, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(9548), "Jace_Thiel88@gmail.com", "Jace", "Thiel", "JACE_THIEL88@GMAIL.COM", "JACE33", "AQAAAAIAAYagAAAAEFN+P5BEsXOow99UtR1d6riHLMf4GX+s+lVmikrl5D+WZ+yCN49+EBnMB5vt9G1rtA==", "216-550-2017", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/626.jpg", "Jace33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "860 Hilpert Rue, East Adahview, Martinique", "76da7713-26dd-417b-a428-cd838cb7101c", new DateTime(2024, 9, 2, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(9780), "Kianna34@yahoo.com", "Kianna", "Legros", "KIANNA34@YAHOO.COM", "KIANNA45", "AQAAAAIAAYagAAAAEHyUE3nOFSfdGA5NW5WPTEcJCrIKMxwBKLkoHzJRcASjF7na5Wungih2GPBnIs6v1A==", "555-508-8858", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1101.jpg", "Kianna45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "410 Chaim Canyon, Port Claudineborough, El Salvador", "4e9b89c0-1619-4ff5-b7a1-55fecb479612", new DateTime(2024, 7, 18, 23, 41, 6, 632, DateTimeKind.Utc).AddTicks(9974), "Lorna_Towne15@yahoo.com", "Lorna", "Towne", "LORNA_TOWNE15@YAHOO.COM", "LORNA_TOWNE78", "AQAAAAIAAYagAAAAEOssRcu5FOnT5c0rBztZx0quFWMGZSbv/inOHlHej1FofQ8NOwjgDZi/p7wWWzJSYw==", "004-073-9229", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/282.jpg", "Lorna_Towne78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8270 Kuhn Prairie, Haagchester, Lithuania", "92a9c440-5c06-479d-b161-0c21d59cac74", new DateTime(2024, 11, 30, 23, 41, 6, 633, DateTimeKind.Utc).AddTicks(200), "Brenden63@yahoo.com", "Brenden", "Jones", "BRENDEN63@YAHOO.COM", "BRENDEN.JONES93", "AQAAAAIAAYagAAAAECgjRTf6x3LmdvmO/yHlBAfKuF+UOPLxVZxkIZ6SHuw3mYf1umFPzMV6K0XN80CjqQ==", "175-767-3958", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/658.jpg", "Brenden.Jones93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "67716 Amely Extensions, Eldredville, Argentina", "3425e712-1e22-4498-ab8d-2449a89af9d0", new DateTime(2024, 8, 6, 23, 41, 6, 633, DateTimeKind.Utc).AddTicks(469), "Humberto.Conroy@yahoo.com", "Humberto", "Conroy", "HUMBERTO.CONROY@YAHOO.COM", "HUMBERTO25", "AQAAAAIAAYagAAAAEMYU5h/QME72mw5Wb/D4qcFantiYFxIxHXtmCmRNmdmRWOnx1Q64MvekNsAEbXanOg==", "007-003-2111", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/778.jpg", "Humberto25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9411 Macy Drive, Port Katheryn, Russian Federation", "1088d438-fd40-4276-aa6b-b1dc2eee6b2c", new DateTime(2024, 4, 13, 23, 41, 6, 633, DateTimeKind.Utc).AddTicks(663), "Vaughn_Wehner@gmail.com", "Vaughn", "Wehner", "VAUGHN_WEHNER@GMAIL.COM", "VAUGHN32", "AQAAAAIAAYagAAAAEMnCRnj7WZCFa0Jf31CKys+HH+u157sRAYEBLcG4qSoUDrAr79fUxGPeS0bI/boNAQ==", "310-680-9277", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/143.jpg", "Vaughn32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4063 Morissette Keys, New Jeannetown, Belgium", "ded0bc9e-7877-4e94-804f-cdf5e0bdfa6b", new DateTime(2024, 4, 22, 23, 41, 6, 633, DateTimeKind.Utc).AddTicks(909), "Jeffrey_Konopelski@gmail.com", "Jeffrey", "Konopelski", "JEFFREY_KONOPELSKI@GMAIL.COM", "JEFFREY_KONOPELSKI", "AQAAAAIAAYagAAAAEAEDWcV22oC7e7knpRa35NwtW2UVcMht3w0f14Fqydbh8IdiEEnteI7G75XnLLZYXA==", "710-518-9666", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/47.jpg", "Jeffrey_Konopelski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9229 Kunze Shores, North Chanelleburgh, Cyprus", "42f5e366-c4a2-4d52-9023-bec5b0c63377", new DateTime(2024, 9, 17, 23, 41, 6, 633, DateTimeKind.Utc).AddTicks(1115), "Turner_Stracke@yahoo.com", "Turner", "Stracke", "TURNER_STRACKE@YAHOO.COM", "TURNER95", "AQAAAAIAAYagAAAAEAOzrlkhLg44p+89FrmzTHWt/WLW62OYau2UyFbPlaOEaVWayDDZs+8rqBvcG6ZDGA==", "508-724-5035", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/633.jpg", "Turner95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2445 Elizabeth Summit, Reichertside, Suriname", "bb4141b1-7001-4c7f-b71a-e9470fe57eb6", new DateTime(2024, 8, 27, 23, 41, 6, 633, DateTimeKind.Utc).AddTicks(1321), "Deshaun71@yahoo.com", "Deshaun", "Walker", "DESHAUN71@YAHOO.COM", "DESHAUN41", "AQAAAAIAAYagAAAAEMFlCsOe4TUvLOed+nTPdX9ih2T3ErchJJMtTzQ0JrEGr6sl3oQe7kDFrhIsbLDnWA==", "716-080-3258", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/345.jpg", "Deshaun41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "56998 Altenwerth Camp, South Marshall, Lebanon", "7005ff22-c920-45e7-884d-443d14561b9e", new DateTime(2024, 11, 20, 23, 41, 6, 633, DateTimeKind.Utc).AddTicks(1525), "Josefa53@hotmail.com", "Josefa", "Herzog", "JOSEFA53@HOTMAIL.COM", "JOSEFA.HERZOG72", "AQAAAAIAAYagAAAAEIAMzOEdbEwHLwyMDnl6htBTBwmpB46QCNafpQPpJYeg9UhcAlB9jxqtPjKdRXinOQ==", "890-676-5015", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1242.jpg", "Josefa.Herzog72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "777 Hettinger Street, South Murray, Libyan Arab Jamahiriya", "28449a6a-cc86-45eb-b187-3ae6ea145706", new DateTime(2024, 7, 4, 23, 41, 6, 633, DateTimeKind.Utc).AddTicks(1753), "Kaleb.MacGyver61@gmail.com", "Kaleb", "MacGyver", "KALEB.MACGYVER61@GMAIL.COM", "KALEB97", "AQAAAAIAAYagAAAAEKu8oUExmNS7Wc8ldSLetdnMr0rYU4Tamm6QQxUR07sNPSeK6sg46ON1++EVbTSU0w==", "107-118-8677", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/512.jpg", "Kaleb97" });
        }
    }
}
