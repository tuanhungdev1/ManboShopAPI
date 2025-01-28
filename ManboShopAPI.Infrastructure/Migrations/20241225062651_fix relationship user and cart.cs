using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class fixrelationshipuserandcart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.AlterColumn<string>(
                name: "SessionId",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.AlterColumn<int>(
                name: "SessionId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "199 Kendrick Mill, Port Winonatown, Sweden", "411392e4-17eb-4b99-aa7c-17e47ce072c2", new DateTime(2024, 9, 12, 18, 25, 7, 763, DateTimeKind.Utc).AddTicks(1563), "Adah_Ledner79@gmail.com", "Adah", "Ledner", "ADAH_LEDNER79@GMAIL.COM", "ADAH21", "AQAAAAIAAYagAAAAELlt4nUskW1lVE9b7xkK9tAKsAiKVlVUAZPH0gvokJUn5xuOzB9ay5okx18g0jzchA==", "718-301-3520", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/464.jpg", "Adah21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "48651 Clinton Grove, North Armani, Liberia", "7bb72331-4aac-4f4f-ab50-471a4adea1e2", new DateTime(2024, 11, 21, 18, 25, 7, 764, DateTimeKind.Utc).AddTicks(6961), "Gay86@yahoo.com", "Gay", "Wisozk", "GAY86@YAHOO.COM", "GAY_WISOZK0", "AQAAAAIAAYagAAAAEKKB0T/+Em1revyqg9R4uzMIOzeVw2lGgtOOcOKE9PI95mHh9RrvT8DD4cQ9j9RADg==", "932-865-8232", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/56.jpg", "Gay_Wisozk0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3636 Adolphus Flat, Miloside, Bosnia and Herzegovina", "c472c1f5-05b2-4304-8e93-9ebf6198ea8a", new DateTime(2024, 2, 3, 18, 25, 7, 764, DateTimeKind.Utc).AddTicks(7391), "Camila.Krajcik@gmail.com", "Camila", "Krajcik", "CAMILA.KRAJCIK@GMAIL.COM", "CAMILA1", "AQAAAAIAAYagAAAAEN0csZKM7s5TTpnay0x/O7h6FCkdDe27ue1aX9WPUqsOaFwy3fIvfBJBGTeghScttQ==", "127-560-9260", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1101.jpg", "Camila1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5896 Yadira Vista, Kilbackfort, Samoa", "dd5485fd-16b6-4fd1-825b-b4f0288fac05", new DateTime(2024, 10, 16, 18, 25, 7, 764, DateTimeKind.Utc).AddTicks(9190), "Georgette.Sporer@gmail.com", "Georgette", "Sporer", "GEORGETTE.SPORER@GMAIL.COM", "GEORGETTE_SPORER27", "AQAAAAIAAYagAAAAEDoRTIzCW4PiJMhahnYjw9ruTcURI7YkbQV5ewoMnKLite5nS7I7mWA294waQCkRUQ==", "933-997-5658", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/475.jpg", "Georgette_Sporer27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5809 Kris Meadows, North Dorianfurt, Isle of Man", "0c5b1dbf-d9e3-452c-95ee-0c0d5908d533", new DateTime(2024, 9, 27, 18, 25, 7, 764, DateTimeKind.Utc).AddTicks(9631), "Haskell46@hotmail.com", "Haskell", "Halvorson", "HASKELL46@HOTMAIL.COM", "HASKELL72", "AQAAAAIAAYagAAAAEGhjlM0DuULa1g+Ty8grdHtU8H6TsK1Ek20rh6EBBiavq3FElswbjy3Li5zEFgP+jA==", "272-388-4176", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/617.jpg", "Haskell72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3950 Crist Landing, Othastad, Falkland Islands (Malvinas)", "cf213824-2a11-4e11-942e-3f9897a9ac05", new DateTime(2024, 4, 12, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(13), "Justice_Padberg46@yahoo.com", "Justice", "Padberg", "JUSTICE_PADBERG46@YAHOO.COM", "JUSTICE_PADBERG1", "AQAAAAIAAYagAAAAEHQhjN/gHAPxygXEnj/PuJ2xpzPkJBI4apq5+ndQFY7po1QomIxfH8mrhJi0WN8FVQ==", "560-156-5335", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/453.jpg", "Justice_Padberg1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "763 Hunter Turnpike, Hickleton, Heard Island and McDonald Islands", "a0183207-3db4-42d5-8b18-dec14e00c6db", new DateTime(2024, 5, 12, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(428), "Lexie.Konopelski@gmail.com", "Lexie", "Konopelski", "LEXIE.KONOPELSKI@GMAIL.COM", "LEXIE27", "AQAAAAIAAYagAAAAEOKlafF8HsVO9tMBoZbRovRGfNS0zJiBqEx+ubbvMcqN9zRgNSV6SANvBigA9tF3Wg==", "991-668-6722", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/302.jpg", "Lexie27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "00865 Randi Parkway, Strackeburgh, Ecuador", "32dc467f-54b0-4f00-8ba4-10c71a93cc3a", new DateTime(2024, 11, 5, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(859), "Roy.Lindgren2@gmail.com", "Roy", "Lindgren", "ROY.LINDGREN2@GMAIL.COM", "ROY59", "AQAAAAIAAYagAAAAEJztjgHPItTvyCCFdbYosjmInDXJ0R99gTrrW+b5wGZdhegS/skjiswXke7MMn8jTw==", "254-821-9852", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/396.jpg", "Roy59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "265 Kunde Rest, Gloriafort, Malaysia", "dcc57c75-e4b6-4343-9f85-fc89a0ed6197", new DateTime(2024, 4, 5, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(1147), "Alvah86@yahoo.com", "Alvah", "Monahan", "ALVAH86@YAHOO.COM", "ALVAH27", "AQAAAAIAAYagAAAAEGuCnztfCJ3lXUfQ6FTQ9VBPOdhUmHxPOIF2jivzvBTw+f5fyRiAm9t8i4xIlT4keg==", "073-815-8863", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/598.jpg", "Alvah27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "492 Murphy Isle, Millerhaven, Belarus", "666442f3-231c-448a-9444-7494e3b0095f", new DateTime(2024, 4, 6, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(1507), "Reggie.Kerluke20@yahoo.com", "Reggie", "Kerluke", "REGGIE.KERLUKE20@YAHOO.COM", "REGGIE_KERLUKE", "AQAAAAIAAYagAAAAEMLvDygc96R5zPeoM9ijOOCzUcso8frEzze5rBmcdEqGG5mSg0spYUc17oZhuWW5gw==", "640-783-3798", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/307.jpg", "Reggie_Kerluke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "74644 Parisian Plain, Lake Justinamouth, Italy", "fb74d568-e44b-400c-aca0-86eba1cb5823", new DateTime(2024, 12, 7, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(1813), "Lexus61@yahoo.com", "Lexus", "Maggio", "LEXUS61@YAHOO.COM", "LEXUS_MAGGIO64", "AQAAAAIAAYagAAAAEPnWh90bqya2fwqO6i+5yfBP9e6LzPu2Shw0gcPSalCkKzbI8Qgz/BmxCF9aKatjvA==", "378-587-1608", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/710.jpg", "Lexus_Maggio64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8894 Rippin Avenue, New Blaiseburgh, Madagascar", "2e4ddfc0-4b62-4e57-93f8-7711e037ab60", new DateTime(2024, 3, 2, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(2152), "Rodger.Schiller@gmail.com", "Rodger", "Schiller", "RODGER.SCHILLER@GMAIL.COM", "RODGER97", "AQAAAAIAAYagAAAAEKnbdnC4/P44/2+97w2Fvn3D3fNTP8ZFLNOAJG7EFvW+ZmJAr3GYz3DETIx7hyQ8bg==", "059-027-5927", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/554.jpg", "Rodger97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "38401 Everardo Rest, Murazikburgh, Iran", "2db67b66-269f-40a7-a738-6b499c9bd7a8", new DateTime(2024, 3, 8, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(2506), "Justice.Williamson@yahoo.com", "Justice", "Williamson", "JUSTICE.WILLIAMSON@YAHOO.COM", "JUSTICE_WILLIAMSON11", "AQAAAAIAAYagAAAAEHEGWTOfUarOTIToG+lNBfLdFia8B5iZsbIKHN+8WkJVIYtyPhqqYDu8CKbOoUsORA==", "842-013-0263", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/876.jpg", "Justice_Williamson11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9418 Johathan Inlet, Lake Maegan, Ecuador", "4605a3e7-fe23-4d0d-93bf-5763e4ebab4f", new DateTime(2024, 8, 29, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(2818), "Anabelle.Kuhic69@hotmail.com", "Anabelle", "Kuhic", "ANABELLE.KUHIC69@HOTMAIL.COM", "ANABELLE_KUHIC", "AQAAAAIAAYagAAAAEOUBqWqvJCTyeDnisUH7syRhABePwf43A/rOmGAmxSNMFTi5TBWP4xd3YYQtAMEjcQ==", "483-920-6040", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/844.jpg", "Anabelle_Kuhic" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "78957 Smitham View, New Tad, Indonesia", "7e39f296-993b-404e-91a2-b0b46519bc05", new DateTime(2024, 7, 2, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(3116), "Lonie.Gibson72@gmail.com", "Lonie", "Gibson", "LONIE.GIBSON72@GMAIL.COM", "LONIE.GIBSON", "AQAAAAIAAYagAAAAED+X66K7zoMU+YVG7vLQsMxdWkGzb8WYxmOhKM38oMXuW4jx3v53A/aF6wkgW2+7hg==", "252-436-3768", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/822.jpg", "Lonie.Gibson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8836 Walsh Point, Darrellhaven, Kenya", "b67a1284-e18f-4dc3-9f70-5b08aee43d31", new DateTime(2024, 9, 21, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(3441), "Kelsie_Wisoky@gmail.com", "Kelsie", "Wisoky", "KELSIE_WISOKY@GMAIL.COM", "KELSIE2", "AQAAAAIAAYagAAAAEGdlreq7JCtD3B4XMs4fv+oTR67V+ceYba9vE56DsdjicrUSLW6lDF3e0y3itosgsg==", "443-274-2528", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/309.jpg", "Kelsie2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "831 Merlin Circles, Arnoldobury, Bahamas", "2663e63a-be95-4278-bfb3-2ca2ceb17836", new DateTime(2024, 8, 28, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(3711), "Titus_King24@yahoo.com", "Titus", "King", "TITUS_KING24@YAHOO.COM", "TITUS_KING70", "AQAAAAIAAYagAAAAEHrH9Lm9E3+qM0LWdTGHsSM4xqdJ/guFBnGKMqdSVZe6roUgMGEFWfGlFXrX/hPURA==", "365-038-1786", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/991.jpg", "Titus_King70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "85023 Rosella Harbors, Port Leola, Togo", "cc14cbc5-1b99-476e-b1b4-afdcc3cef2a8", new DateTime(2024, 7, 13, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(4050), "Rahsaan.Stiedemann3@hotmail.com", "Rahsaan", "Stiedemann", "RAHSAAN.STIEDEMANN3@HOTMAIL.COM", "RAHSAAN_STIEDEMANN59", "AQAAAAIAAYagAAAAECsXXzlN25UrszBHp0dPEvSmTGA6l9/OLOyDpdEH1Q9vVJauoVToXJo5YOJm6ySXPw==", "499-709-4325", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1236.jpg", "Rahsaan_Stiedemann59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "434 Roscoe Square, West Nayelimouth, Nepal", "dc5ed538-ad9a-469a-9f1c-d5afee98cf58", new DateTime(2024, 9, 4, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(4328), "Maud_Leuschke@hotmail.com", "Maud", "Leuschke", "MAUD_LEUSCHKE@HOTMAIL.COM", "MAUD97", "AQAAAAIAAYagAAAAEFkxmvEYdRvdG/R3UxMYocAsuGgPO2gMv6UfHNxzTRTmcL+80W4uolZqHrZigrtjGQ==", "294-695-5296", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/378.jpg", "Maud97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0456 Lilly Valley, Lake Liachester, Pakistan", "71330a17-3e85-4419-bd5c-56df84e14955", new DateTime(2024, 1, 11, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(4643), "Judge.Halvorson@yahoo.com", "Judge", "Halvorson", "JUDGE.HALVORSON@YAHOO.COM", "JUDGE_HALVORSON73", "AQAAAAIAAYagAAAAEFZS6LM2YgdZ0hIvuqKJfa4xsHIq7383SLAc7C9yEO1azjebCUDpBYpNdHK3gWFTrw==", "171-655-9050", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/945.jpg", "Judge_Halvorson73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "267 Denis Place, Willstad, French Guiana", "1abf0f3e-a4d6-4e7e-a236-3297c9f818ad", new DateTime(2024, 9, 24, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(4912), "Brad_Erdman@yahoo.com", "Brad", "Erdman", "BRAD_ERDMAN@YAHOO.COM", "BRAD70", "AQAAAAIAAYagAAAAEJ1gtdThxqJPD5Q7gQEIh/djrIxCIugGOsCD8pBXAN6fnx4B9JZE6yNLcpTJAaUQTw==", "446-093-1333", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/837.jpg", "Brad70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "30252 Gabrielle Flats, Lindfurt, Marshall Islands", "5c124651-bdf8-4337-9f0d-efd0e87d4569", new DateTime(2024, 6, 12, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(5242), "Joaquin.Schroeder@yahoo.com", "Joaquin", "Schroeder", "JOAQUIN.SCHROEDER@YAHOO.COM", "JOAQUIN_SCHROEDER46", "AQAAAAIAAYagAAAAEAkzpTQHcm32Q4dWABoTFubPh8xghU6DaDFtIGEPCwBSCTllm8M+lbs+2nJTfp+XBA==", "303-334-1237", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/153.jpg", "Joaquin_Schroeder46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "11372 Toby Causeway, Noraburgh, Bosnia and Herzegovina", "22c4f582-d327-46ca-a345-329f1b51a079", new DateTime(2024, 12, 1, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(5513), "Roxane4@gmail.com", "Roxane", "Feil", "ROXANE4@GMAIL.COM", "ROXANE.FEIL43", "AQAAAAIAAYagAAAAENTSVpLLBzZVpO31ip7LqjY8UxUTAORGuboRy0huFdRe0D66dcqUACrpQrp2siqHEw==", "594-472-9056", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/945.jpg", "Roxane.Feil43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "658 Jody Landing, Dimitriland, Heard Island and McDonald Islands", "717dbb76-ee96-44dc-bf5d-8b86d7d13b13", new DateTime(2024, 6, 26, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(5825), "Arlo.Cartwright41@hotmail.com", "Arlo", "Cartwright", "ARLO.CARTWRIGHT41@HOTMAIL.COM", "ARLO57", "AQAAAAIAAYagAAAAEFjIV7mB2ZNT+yp2EQxNShvZy3y/IIqarM6r3INVCwLFas1XxgvpzFG4EEKjE+mPQw==", "373-703-8618", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/444.jpg", "Arlo57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "01313 Calista Pines, East Chauncey, Ethiopia", "c5a4c353-607e-401f-9d83-af45d2083704", new DateTime(2024, 11, 29, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(6134), "Jaylan.Abbott@yahoo.com", "Jaylan", "Abbott", "JAYLAN.ABBOTT@YAHOO.COM", "JAYLAN.ABBOTT57", "AQAAAAIAAYagAAAAEMASXFy4pucMFQCG06L+knvdNKaEHJp5aUFK0t0SZiqzm9k/Q1OoYYQFOnDVqE7YuQ==", "887-385-5954", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1114.jpg", "Jaylan.Abbott57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "63954 Rosella Springs, Bretview, Cyprus", "9f73c6e2-0d52-4798-b173-a68d92d9ea77", new DateTime(2024, 1, 2, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(6465), "Baylee_Hermann12@gmail.com", "Baylee", "Hermann", "BAYLEE_HERMANN12@GMAIL.COM", "BAYLEE.HERMANN93", "AQAAAAIAAYagAAAAELZLwdiLVqt2KrYXnSVcd+02dvQivrt4L3sbLxhRkdROVvVDG8xlvoWxGRIlk7r7ng==", "159-655-1150", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/343.jpg", "Baylee.Hermann93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "63809 Jamil Burg, Lake Antonetteside, Suriname", "49f691e4-d3f9-4b26-b495-7a20001147d3", new DateTime(2024, 11, 19, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(6798), "Josianne_Dickens@gmail.com", "Josianne", "Dickens", "JOSIANNE_DICKENS@GMAIL.COM", "JOSIANNE_DICKENS", "AQAAAAIAAYagAAAAEJvJJhl97aRTnBOsEfLFlir2hlQnmsfr99sXVMgx/oHThTflKNQGdY2GkZ902J5Bjg==", "813-184-6820", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/295.jpg", "Josianne_Dickens" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5404 Greenholt Trafficway, Trompberg, Mali", "49899714-8220-4b01-9e49-6f3dd3c9ecbe", new DateTime(2024, 4, 24, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(7064), "Collin_Jast@gmail.com", "Collin", "Jast", "COLLIN_JAST@GMAIL.COM", "COLLIN1", "AQAAAAIAAYagAAAAEMZ7tzuyKy2iI1wA37Po95MOGM/kwobC7MIWpFfq20/c85XhNVQ1p46OKGJrZJUnXQ==", "384-379-6882", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/609.jpg", "Collin1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "299 Eunice Lane, Swiftton, Czech Republic", "5fa2ec59-fa8e-489f-ae0c-cd4cc999eedc", new DateTime(2024, 6, 8, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(7387), "Juwan_Mitchell@gmail.com", "Juwan", "Mitchell", "JUWAN_MITCHELL@GMAIL.COM", "JUWAN79", "AQAAAAIAAYagAAAAEMrgtTYxeKiWOJ7r/TQX44wHBdiIdr4pGnXSHzOCeDm2WbJJPJyjUN+LJJOP2M68XA==", "492-061-5971", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/522.jpg", "Juwan79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "58719 Lesch Bypass, Mitchellfurt, Bermuda", "5b07861d-33e5-4ef4-a75b-cd65b57ec542", new DateTime(2024, 2, 18, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(7703), "Aditya.Heidenreich97@yahoo.com", "Aditya", "Heidenreich", "ADITYA.HEIDENREICH97@YAHOO.COM", "ADITYA_HEIDENREICH", "AQAAAAIAAYagAAAAEPLkpK3VjPxCNq46iJvEdrg2nqN3Wavsr870qiSSwgxYZLL3Ldz7o+M7/V0PSp/GQg==", "657-919-9666", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1042.jpg", "Aditya_Heidenreich" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1693 Schiller Forest, Arnulfofort, Pitcairn Islands", "a7608f1b-ca9d-4077-995f-5984f5b89ee2", new DateTime(2024, 2, 23, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(7986), "Brad.Goodwin95@gmail.com", "Brad", "Goodwin", "BRAD.GOODWIN95@GMAIL.COM", "BRAD_GOODWIN", "AQAAAAIAAYagAAAAEDnsQ4/zlkVj3CxEMEzZ+oYzzo6ymEUGtRnEdGHsAQ1A4hWFdQiQVQ69RTLspkuBhA==", "692-404-3279", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/14.jpg", "Brad_Goodwin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2236 Robert Drive, West Fredton, Guinea", "f73a9e59-c7c3-400e-bb83-5164e92f10d4", new DateTime(2024, 12, 5, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(8289), "Presley.Erdman@yahoo.com", "Presley", "Erdman", "PRESLEY.ERDMAN@YAHOO.COM", "PRESLEY.ERDMAN94", "AQAAAAIAAYagAAAAEEGDqBsq7j02Vep6AnylrZL77OzvTCITp+lE4CA+yk/XFM4bYVxHTbXnOY1rcmZGFA==", "575-774-2862", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1164.jpg", "Presley.Erdman94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9889 Jesse Point, Travonhaven, Maldives", "4067a336-8b6d-40f2-ae53-abdd27c81b95", new DateTime(2024, 9, 14, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(8602), "Haylie_Beer14@gmail.com", "Haylie", "Beer", "HAYLIE_BEER14@GMAIL.COM", "HAYLIE.BEER", "AQAAAAIAAYagAAAAEFwvlccuyjkMQtxO2VtZIUQnsdvoLau8VAcRxHm1MA4w09bkvg1G7WtPgXmZawiSXQ==", "664-533-7353", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/585.jpg", "Haylie.Beer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "406 Ebert Drive, South Jamar, Switzerland", "a65bfe61-cc55-4087-bf2b-40bf27b06b21", new DateTime(2024, 11, 10, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(8873), "Laurence80@hotmail.com", "Laurence", "Jacobi", "LAURENCE80@HOTMAIL.COM", "LAURENCE.JACOBI", "AQAAAAIAAYagAAAAEL/RTY3bH+uSloMtC6EOj6Z0A+DpVUHGOux1TG4dLxc0/Yxcgb2pkKY2UewTQPCDAg==", "948-853-3980", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/648.jpg", "Laurence.Jacobi" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "747 Angela Causeway, North Eloisetown, Syrian Arab Republic", "010fea9e-e489-4f25-b42e-5f35cd180246", new DateTime(2024, 10, 25, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(9210), "Harvey_Gusikowski52@gmail.com", "Harvey", "Gusikowski", "HARVEY_GUSIKOWSKI52@GMAIL.COM", "HARVEY99", "AQAAAAIAAYagAAAAEKSMQb2v4zoalbMsV5eTK+hjj6KF3AydVizKMIDeCyWSIpDgvfoGkMB3jH1Nt21rZA==", "958-314-9947", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/961.jpg", "Harvey99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "750 Borer Point, East Nickolas, Netherlands", "937ea052-5add-4570-ae85-79425b4d3032", new DateTime(2024, 7, 3, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(9484), "Stewart.Ritchie@gmail.com", "Stewart", "Ritchie", "STEWART.RITCHIE@GMAIL.COM", "STEWART.RITCHIE", "AQAAAAIAAYagAAAAEDRpJJRxJTiGQdqNS3ZgrFZYpXy6glH49oer49S9Pslx5CskpxAQDplKtXWf0mW3uw==", "322-398-1607", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/122.jpg", "Stewart.Ritchie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9323 Flatley Points, Scottieville, Western Sahara", "af5cf090-6217-4c65-8f8e-d7012e6e6801", new DateTime(2024, 6, 12, 18, 25, 7, 765, DateTimeKind.Utc).AddTicks(9794), "Anissa_Ullrich8@hotmail.com", "Anissa", "Ullrich", "ANISSA_ULLRICH8@HOTMAIL.COM", "ANISSA_ULLRICH", "AQAAAAIAAYagAAAAECXuoCqNBqSZwDeeFuV0XDjdAQ/ROBv7fDCn7GlDTrlPBkRNBLKTpYazDfnz2AlSlA==", "195-163-2997", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/71.jpg", "Anissa_Ullrich" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0656 Roberts Crossroad, Wehnerfurt, Lao People's Democratic Republic", "049f610b-2cf7-428e-8ef3-5d2af1f75641", new DateTime(2024, 7, 30, 18, 25, 7, 766, DateTimeKind.Utc).AddTicks(80), "Micaela_Frami42@gmail.com", "Micaela", "Frami", "MICAELA_FRAMI42@GMAIL.COM", "MICAELA40", "AQAAAAIAAYagAAAAEKULBHZ3x0+1OPXhi7gJvujMdRfuzuX+SppY/s0vBeP4/EO+A8PkIdCbe/L5dPCifQ==", "896-243-9019", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/623.jpg", "Micaela40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "485 Flatley Centers, Terryside, Eritrea", "194e13b7-f02f-4fb7-ba46-a65e53a18148", new DateTime(2024, 2, 27, 18, 25, 7, 766, DateTimeKind.Utc).AddTicks(397), "Timmothy22@yahoo.com", "Timmothy", "Bernier", "TIMMOTHY22@YAHOO.COM", "TIMMOTHY15", "AQAAAAIAAYagAAAAECezKh6liwc2zpbHzpqjxZphsOn5+8bOOaI/WaWY5o8GsNLMzmzCV6cAFm3lA5TEgg==", "924-039-8619", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/494.jpg", "Timmothy15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "457 Cruickshank Gardens, West Georgiana, Poland", "03d2cc17-8afd-4b5c-9fde-77fcd3be4fd2", new DateTime(2024, 12, 9, 18, 25, 7, 766, DateTimeKind.Utc).AddTicks(673), "Camryn49@hotmail.com", "Camryn", "Rosenbaum", "CAMRYN49@HOTMAIL.COM", "CAMRYN_ROSENBAUM", "AQAAAAIAAYagAAAAEAbODXNuZilYbFbTdjiYAs+jUHqH62bWeah+Gpz8oHCr1xUx/m2mDkvkX2hvNLgTog==", "869-695-8119", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/463.jpg", "Camryn_Rosenbaum" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 10, 219, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 18, 25, 7, 413, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
