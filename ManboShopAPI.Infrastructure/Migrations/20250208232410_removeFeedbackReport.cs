using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class removeFeedbackReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackLikes_AspNetUsers_UserId",
                table: "FeedbackLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackLikes_Feedbacks_FeedbackId",
                table: "FeedbackLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Products_ProductId",
                table: "Feedbacks");

            migrationBuilder.DropTable(
                name: "FeedbackReports");

            migrationBuilder.DropIndex(
                name: "IX_FeedbackLikes_UserId",
                table: "FeedbackLikes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "63388 Edwina Prairie, Lake Aleen, Myanmar", "b61ff116-11c8-44b3-a8be-2d37f6f38435", new DateTime(2024, 8, 24, 23, 24, 8, 117, DateTimeKind.Utc).AddTicks(2167), "Lois.Raynor@hotmail.com", "Lois", "Raynor", "LOIS.RAYNOR@HOTMAIL.COM", "LOIS68", "AQAAAAIAAYagAAAAEHTjRyIK/e51AVaLEehUgikooYOFRCIC14kx3OaCkxvTsJipmvhSmApbelchXyQWbw==", "199-187-4029", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/344.jpg", "Lois68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "32039 Connelly Lodge, West Bettyehaven, Wallis and Futuna", "4fc86652-9ade-4ca4-8362-e57a3d95a614", new DateTime(2024, 4, 25, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(3885), "Monserrat.Bins27@gmail.com", "Monserrat", "Bins", "MONSERRAT.BINS27@GMAIL.COM", "MONSERRAT.BINS9", "AQAAAAIAAYagAAAAEJ6lBh+pzPq51qNB38PvGWT5QkQt68sUBSRWw7bz93RgvWKaGXJlNjLQrdUiCO6/uw==", "621-588-7415", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1038.jpg", "Monserrat.Bins9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9886 Jamal Common, Boehmchester, Uruguay", "23179e8b-e807-427c-afaa-0a7f26ae61b2", new DateTime(2024, 7, 13, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(5273), "Cortney.Bergstrom15@yahoo.com", "Cortney", "Bergstrom", "CORTNEY.BERGSTROM15@YAHOO.COM", "CORTNEY_BERGSTROM26", "AQAAAAIAAYagAAAAEKL6VLuUSwBH9zQ8YG2NZbyJ+lGe0rP8lTw5FDP1ywz4mzNTI5bhOsjjBE3Rr1sTYg==", "467-196-6702", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/447.jpg", "Cortney_Bergstrom26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8374 Ondricka Junctions, North Owenmouth, Lesotho", "04e1d9ba-793c-447f-8dd2-bc4b28223f15", new DateTime(2024, 11, 8, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(5535), "Marshall.Rath@hotmail.com", "Marshall", "Rath", "MARSHALL.RATH@HOTMAIL.COM", "MARSHALL_RATH", "AQAAAAIAAYagAAAAEMEhgytQbzLQAyiRQamSsG4dtR53kNfAb5j69senBtozmnV6ZrZtw2XDTNXmLOXSpQ==", "985-319-7221", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/589.jpg", "Marshall_Rath" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "901 Gaston Path, Lockmanfurt, Solomon Islands", "f25bf3a8-96bd-4e9c-978a-917c6967605e", new DateTime(2024, 4, 30, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(5801), "Jay2@hotmail.com", "Jay", "Pfeffer", "JAY2@HOTMAIL.COM", "JAY.PFEFFER", "AQAAAAIAAYagAAAAEHHQExk3LEyig2r56qfR9LEG3xls6kz7HSMZpS4TrnybNaL0k0pGryMWwJ5MWk1bDw==", "205-389-3169", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/931.jpg", "Jay.Pfeffer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "062 Alexzander Knoll, Rhiannonbury, Saudi Arabia", "43862110-ec86-4bca-af21-3bc6657d388a", new DateTime(2024, 8, 24, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(6023), "Mckenna.Kuhic58@yahoo.com", "Mckenna", "Kuhic", "MCKENNA.KUHIC58@YAHOO.COM", "MCKENNA_KUHIC", "AQAAAAIAAYagAAAAEBMXhjMnxp+hyqlyHPat6jgE6dPYLa39G+1TBFNTkPgSWyg8TlW4qNRLvF2baMXHUw==", "469-798-4568", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/128.jpg", "Mckenna_Kuhic" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4268 Daniel Bypass, South Eileenport, Saudi Arabia", "8ff6b49b-107e-46f7-b7c7-83a5571f52ff", new DateTime(2024, 12, 26, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(6843), "Elna97@gmail.com", "Elna", "Herman", "ELNA97@GMAIL.COM", "ELNA_HERMAN", "AQAAAAIAAYagAAAAEN0cW73P75mJt3XgyXeQuZBgtiSy/zspSfwA/VQrT2IgsC+7No9B1iZkgd6SLD1n5A==", "217-170-8618", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/543.jpg", "Elna_Herman" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "477 Elwyn Tunnel, Erdmanview, Wallis and Futuna", "d6ce30e3-52c9-44f6-a073-282a1267043f", new DateTime(2025, 1, 9, 23, 24, 8, 118, DateTimeKind.Utc).AddTicks(9750), "Magnus.Wiza@hotmail.com", "Magnus", "Wiza", "MAGNUS.WIZA@HOTMAIL.COM", "MAGNUS.WIZA", "AQAAAAIAAYagAAAAEHSfb6KJRHunvC9PZt2B/1bxLlI3iIvfuBWqY9aFhLa1pp4z5enqCO9RUnhv3mK8ug==", "236-253-7246", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1050.jpg", "Magnus.Wiza" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "74639 Hansen Tunnel, Olsonmouth, Indonesia", "85ab85d4-5e22-4954-bb89-06f94233f088", new DateTime(2024, 11, 18, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(369), "Jonatan89@yahoo.com", "Jonatan", "Flatley", "JONATAN89@YAHOO.COM", "JONATAN61", "AQAAAAIAAYagAAAAEK7iHNfOOM0/qh6x5pJDYY0TysY11GSMV6hCWcbuO6yxed9XImp9v5hLEjCn5JetrA==", "339-955-2900", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/265.jpg", "Jonatan61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "062 Little Mount, Lueilwitzmouth, Fiji", "248f7f93-c8b2-43fe-b1c2-612fe1f0a2cd", new DateTime(2024, 9, 27, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(675), "Mohammad.McGlynn78@hotmail.com", "Mohammad", "McGlynn", "MOHAMMAD.MCGLYNN78@HOTMAIL.COM", "MOHAMMAD60", "AQAAAAIAAYagAAAAENMsWRjQX+vWTKExnphqx5D/8s2p7jh4sT/7pRl29bH5/Vy6Feylif1sVmu1+9em4w==", "357-688-9704", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1072.jpg", "Mohammad60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6747 Sylvan Mill, Grahammouth, Algeria", "f7212f76-3246-4b8e-a70f-bb343495970a", new DateTime(2024, 12, 5, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(1025), "Lillie.Hyatt@yahoo.com", "Lillie", "Hyatt", "LILLIE.HYATT@YAHOO.COM", "LILLIE12", "AQAAAAIAAYagAAAAEPpFXN0Lpn+dzJTE1RoVlWDoPMr6e6R+TWjuOknsDCkrNiBBFuNlNeq97Lf1bKqnNQ==", "934-386-8248", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1228.jpg", "Lillie12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "88079 Lempi Route, Anjalishire, Madagascar", "e73cb373-b7f0-4bf8-9e1f-71a5fd8d4ca3", new DateTime(2024, 11, 16, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(1432), "David_Thiel@hotmail.com", "David", "Thiel", "DAVID_THIEL@HOTMAIL.COM", "DAVID_THIEL", "AQAAAAIAAYagAAAAEB10rA+ryXBPYfNVrVBTPw2EHoY/y3JgTJzaArTw0CZ/aioupUu1CNzNV9+u4Ysa9Q==", "097-672-5355", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1135.jpg", "David_Thiel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "49423 Kris Throughway, Larkinshire, Thailand", "3fa7e41b-4e50-4529-9f65-999302254d3a", new DateTime(2024, 5, 10, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(8752), "Jace5@hotmail.com", "Jace", "O'Kon", "JACE5@HOTMAIL.COM", "JACE.OKON", "AQAAAAIAAYagAAAAEP4k2uBzFs2QapoGN9hcekX/Q9D06kiZOEn0H4dnbFZGXetz10N4DmnNErZFdNMM5A==", "296-104-9454", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1063.jpg", "Jace.OKon" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7550 Luettgen Isle, South Ismaelbury, Democratic People's Republic of Korea", "223cdd70-fa38-4835-986b-780ef5f19a06", new DateTime(2024, 3, 27, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(9251), "Marcus_McCullough9@gmail.com", "Marcus", "McCullough", "MARCUS_MCCULLOUGH9@GMAIL.COM", "MARCUS_MCCULLOUGH", "AQAAAAIAAYagAAAAENVndRly6q9Rn7pqi1DWk62KvwK5vx4+9cuZZjwCFaVlSnJxxT618oWrRuyT0ACEmQ==", "647-080-1331", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1234.jpg", "Marcus_McCullough" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "383 Israel Wall, New Floydland, Uruguay", "64687071-cbfe-49db-ac5a-85d61d0f14ea", new DateTime(2024, 7, 21, 23, 24, 8, 119, DateTimeKind.Utc).AddTicks(9703), "Emely_Cartwright87@gmail.com", "Emely", "Cartwright", "EMELY_CARTWRIGHT87@GMAIL.COM", "EMELY0", "AQAAAAIAAYagAAAAEEkS6i8OlZafXAC994J4LMTU4fZp0ayofIL539tpaxY7I/J16kdEVi7CyWddraDB0w==", "163-521-0137", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1216.jpg", "Emely0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3117 Wintheiser Pine, Brakusview, Madagascar", "4ef1280e-ba4a-45ad-9844-2a35bc3e9dc6", new DateTime(2024, 2, 28, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(66), "Kenny47@gmail.com", "Kenny", "Weber", "KENNY47@GMAIL.COM", "KENNY73", "AQAAAAIAAYagAAAAEKbWsIGloGS+tDdI54kFfPApbRPI26oY7KITft5qusCAjTWktAtMPur4gxuFzj3EQg==", "950-775-0092", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/343.jpg", "Kenny73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "829 Christiansen Roads, South Morris, Slovakia (Slovak Republic)", "e7806253-602f-41a1-80be-792028693d74", new DateTime(2024, 7, 15, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(521), "Chelsie.Ankunding@yahoo.com", "Chelsie", "Ankunding", "CHELSIE.ANKUNDING@YAHOO.COM", "CHELSIE_ANKUNDING43", "AQAAAAIAAYagAAAAEDTkbl4gmvp3vQ77rdmjygjcAqs9nMcZojry172IMFr58qayCLbfiyYkcUxBxucugg==", "073-465-9158", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/109.jpg", "Chelsie_Ankunding43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5435 Weber Fork, South Kaitlin, Pakistan", "67d6ef53-9a4d-42fb-a510-2a6123450430", new DateTime(2024, 8, 8, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(945), "Lamont97@yahoo.com", "Lamont", "Rosenbaum", "LAMONT97@YAHOO.COM", "LAMONT5", "AQAAAAIAAYagAAAAEIM9XXgAbOoPsA7GuI4CWUgJQQuiFd3OO7vW9OQUMoztBPAsAWxpwtQLCtcQoHk2ag==", "709-978-4774", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/349.jpg", "Lamont5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1323 Gutkowski Summit, New Zettaton, Mozambique", "e876d279-b6d5-4c8a-a560-de26a06af955", new DateTime(2025, 1, 2, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(1420), "Carole20@hotmail.com", "Carole", "Schiller", "CAROLE20@HOTMAIL.COM", "CAROLE_SCHILLER85", "AQAAAAIAAYagAAAAEHuVZSuLXggDOs/oCzTvbuTJ3UB25M8mW2OU6vlXj1pj4HbMydDrJvfxu7W87KhLHA==", "210-311-3758", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/864.jpg", "Carole_Schiller85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "923 Kellie Highway, North Timothystad, Taiwan", "89a34a71-8b58-4621-91f6-1fc4a5e9b750", new DateTime(2024, 3, 17, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(1848), "Willy.Doyle@hotmail.com", "Willy", "Doyle", "WILLY.DOYLE@HOTMAIL.COM", "WILLY_DOYLE18", "AQAAAAIAAYagAAAAEDl3+FIaOLm5I2Yqcvi2GvhsMSa19gOMFUf5be6zoZ34oJTUym+cTrVzTp8qrpDSlQ==", "752-931-3926", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/822.jpg", "Willy_Doyle18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "350 Kutch Courts, Isabellebury, Guinea-Bissau", "98d17aa0-6b14-4a50-ab18-c75b6c44aafe", new DateTime(2024, 9, 28, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(2227), "Aiden.Wintheiser@gmail.com", "Aiden", "Wintheiser", "AIDEN.WINTHEISER@GMAIL.COM", "AIDEN_WINTHEISER20", "AQAAAAIAAYagAAAAEKvHojxRsbuGnrefA08Svgyf8zdD3w9jLEI3urUWU9JkWYfj8hppFXZToDV5a22LyQ==", "351-030-0840", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/603.jpg", "Aiden_Wintheiser20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "43285 Kiehn Tunnel, DuBuquechester, Sudan", "46f8224b-a4bd-4149-a88a-259d952b036c", new DateTime(2025, 1, 16, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(2662), "Beverly_Morissette77@yahoo.com", "Beverly", "Morissette", "BEVERLY_MORISSETTE77@YAHOO.COM", "BEVERLY.MORISSETTE", "AQAAAAIAAYagAAAAENzN5vB3ce2tEuWr3FwbUb9IF0pWrBzfoKcg8bQRcchY+umAHacgSnuG7StBCZRstw==", "001-206-4016", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1133.jpg", "Beverly.Morissette" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "563 Cummerata Junction, Noemiehaven, Mexico", "98d0aa1f-26f0-4986-9ee1-5091284910e0", new DateTime(2024, 2, 9, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(3092), "Margarette77@gmail.com", "Margarette", "Greenholt", "MARGARETTE77@GMAIL.COM", "MARGARETTE96", "AQAAAAIAAYagAAAAEDgUrgvTULWFmabpKd51jk7V7q5e0v2nUUAW1vh1FmuZ937NgAvMLTi+D6BkMQ2YkA==", "042-147-5231", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/140.jpg", "Margarette96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "20431 Leannon Crossing, Port Augustafurt, Argentina", "8808fa1b-597d-459f-89cd-7d89d38af7a4", new DateTime(2024, 10, 29, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(3468), "Randy59@hotmail.com", "Randy", "Kuphal", "RANDY59@HOTMAIL.COM", "RANDY.KUPHAL48", "AQAAAAIAAYagAAAAEOXTUhm5N3PSWK0bmjb4bktbgVpYaqCRX2prziRy7DGqNgt5uKY0w8S+TYBtlPUstQ==", "577-838-1926", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/930.jpg", "Randy.Kuphal48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "45586 O'Keefe Manors, South Lisaland, Virgin Islands, British", "28ce02dd-ae19-425e-9a0a-426921750b0a", new DateTime(2024, 11, 14, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(3781), "Amaya.Runte@gmail.com", "Amaya", "Runte", "AMAYA.RUNTE@GMAIL.COM", "AMAYA.RUNTE", "AQAAAAIAAYagAAAAEPKSLQT6MqPx5nU/pvYndFLk6Od2uRRsO2Euj59q4cJGfSUXNoSEy98IqrmGaB4NzQ==", "221-771-1917", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/261.jpg", "Amaya.Runte" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "094 Fay Shoal, Durwardberg, Pitcairn Islands", "4c408af1-2176-4dec-9593-71dd8de465d1", new DateTime(2024, 11, 17, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(4123), "Dennis61@yahoo.com", "Dennis", "Greenfelder", "DENNIS61@YAHOO.COM", "DENNIS_GREENFELDER27", "AQAAAAIAAYagAAAAEP47buGBxzrlRxqwEofvWbeJRAWsGJNnE8Sz6NU4iXDw6EJabEdqXLWCnCpI+fyXDw==", "862-781-2098", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/738.jpg", "Dennis_Greenfelder27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0265 Daniel Isle, West Damonshire, Kiribati", "94d48ed3-f269-46b8-8915-384cef6be6cc", new DateTime(2024, 7, 10, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(4453), "Benton.Turner@yahoo.com", "Benton", "Turner", "BENTON.TURNER@YAHOO.COM", "BENTON.TURNER", "AQAAAAIAAYagAAAAEOcFtg/9Lj4zsL9M3EFdyDf1lbTx3pulGNMChrJrYCilAiBHiF3zgzmx7uaJNgHjTQ==", "027-453-4152", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/185.jpg", "Benton.Turner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "431 Wiza Freeway, North Rosellatown, Senegal", "aecb2f74-0de3-4c8e-b8cc-e41e7ee5ea1a", new DateTime(2024, 9, 20, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(5450), "Haskell_Lockman@gmail.com", "Haskell", "Lockman", "HASKELL_LOCKMAN@GMAIL.COM", "HASKELL89", "AQAAAAIAAYagAAAAEEdgOKwg6a2HbWKxox1qAsxXpN4pGaIIkMBy/TE7xEvq3KP+y6DB2vVx72Nl6gh9wA==", "881-925-9800", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/758.jpg", "Haskell89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2578 Orn Meadows, Zoeymouth, Cape Verde", "d5043252-cc69-4a7b-a3a9-e01bb25a0a23", new DateTime(2024, 2, 29, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(5922), "Lennie_Klocko1@yahoo.com", "Lennie", "Klocko", "LENNIE_KLOCKO1@YAHOO.COM", "LENNIE53", "AQAAAAIAAYagAAAAEIHT4TnQg9oDllrOPmSP2gM3ljPYXVzES2e3mBLJZ1eHWoRtbcaGmLKy2eFzLXjE+Q==", "821-457-9624", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/901.jpg", "Lennie53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "534 Stark Haven, North Brycentown, Indonesia", "2deb1c7e-c7cc-4530-91ab-462d17c72120", new DateTime(2024, 6, 24, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(6234), "Nyasia.Kreiger17@hotmail.com", "Nyasia", "Kreiger", "NYASIA.KREIGER17@HOTMAIL.COM", "NYASIA.KREIGER", "AQAAAAIAAYagAAAAEDYpPDxGudWj5ZNChgg3TfUj+m1Pa4IeBwx53dKMXAwR72msWnvjX9afHXbwbJsSmQ==", "489-476-7332", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/47.jpg", "Nyasia.Kreiger" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "771 Stoltenberg Road, Labadieberg, Lao People's Democratic Republic", "96f1d325-9fb1-4a4b-a704-80f2f1d8dc0a", new DateTime(2024, 3, 3, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(6563), "Jermey_Parisian@yahoo.com", "Jermey", "Parisian", "JERMEY_PARISIAN@YAHOO.COM", "JERMEY18", "AQAAAAIAAYagAAAAEFZ818OdrZFzRvHFL6wNB2LeI54GWZzPZQPOgfKaBtblbEBymXeCL4eJ6YI++euOZw==", "113-067-7732", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/856.jpg", "Jermey18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7433 Dach Terrace, Port Marquisland, Greenland", "3cbbc18c-f507-482c-be54-cced2c2b2e73", new DateTime(2025, 1, 10, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(6845), "Alize_Stanton61@yahoo.com", "Alize", "Stanton", "ALIZE_STANTON61@YAHOO.COM", "ALIZE.STANTON52", "AQAAAAIAAYagAAAAEO7dILzFlVTVHMEvx1vvYWnu5ideJt0D73uVu/v4a3lqiK0uWZGtfLea//t8g7YNGg==", "769-178-0082", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/272.jpg", "Alize.Stanton52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5858 Bradtke Common, Websterhaven, Iraq", "2887b07e-a035-447e-930a-88f7a50c4a09", new DateTime(2024, 9, 26, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(7129), "Justine.Rice96@hotmail.com", "Justine", "Rice", "JUSTINE.RICE96@HOTMAIL.COM", "JUSTINE.RICE50", "AQAAAAIAAYagAAAAEIRj/u57tNjCluHv2BRaSwEra/GLLP4B6NwEAM9ShmWBiOCIIjpZ6rlC9SQbXMzxYQ==", "808-605-6483", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/926.jpg", "Justine.Rice50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "427 Maddison Forks, Whiteborough, Wallis and Futuna", "9e93f030-362a-4636-a074-0daaf2d28b7d", new DateTime(2024, 3, 9, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(7403), "Kian.Torp19@gmail.com", "Kian", "Torp", "KIAN.TORP19@GMAIL.COM", "KIAN_TORP", "AQAAAAIAAYagAAAAEEjVr5Uegg/U8O8bOAIl42uFin+hIAFMTY1L/3Kj+fu7Pt3eiuFwoZLscqyYayi3bg==", "797-387-7742", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/905.jpg", "Kian_Torp" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7944 Lamont Plaza, South Nettieside, Mozambique", "1b478225-fd12-4f7c-adfa-4daec5c35233", new DateTime(2025, 1, 13, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(7719), "Una53@gmail.com", "Una", "Skiles", "UNA53@GMAIL.COM", "UNA.SKILES", "AQAAAAIAAYagAAAAECMosUbVVTuWw+hGtLdIixBzHUOMRlO1Mf2apJd8aKnNFMGu5jSf0bT/qpC2g+lQqQ==", "799-148-3861", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/739.jpg", "Una.Skiles" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4434 Fahey Mission, Padbergfurt, Norway", "81177012-6709-4c71-86c8-a4b5a2cf42c3", new DateTime(2024, 9, 4, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(8008), "Melvina38@yahoo.com", "Melvina", "Jaskolski", "MELVINA38@YAHOO.COM", "MELVINA.JASKOLSKI75", "AQAAAAIAAYagAAAAEMbX08JwEkeLwLsuD89/ErnyJ4X5Bi4YbNdJ8v/OWsZgWjOX2YVly5wCy6T1HRVPcw==", "491-550-8077", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/190.jpg", "Melvina.Jaskolski75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "188 Arlene Light, South Rainabury, Myanmar", "77af0fd8-fe11-4e04-b3cf-93e0b8f605ff", new DateTime(2025, 1, 15, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(8320), "Noemie26@hotmail.com", "Noemie", "Kerluke", "NOEMIE26@HOTMAIL.COM", "NOEMIE67", "AQAAAAIAAYagAAAAEOdoiRujV2G5JfUlONGoNSZCHsWWItaEHdPh7PsItMzWQdfSS/R16InjIees+Q0UjQ==", "302-388-9913", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/395.jpg", "Noemie67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7405 Lillian Cape, Eulaliamouth, Norfolk Island", "82f377ca-4a80-4f9f-bd65-5d951ca3ebd6", new DateTime(2024, 5, 6, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(8613), "Toney_Bogisich65@yahoo.com", "Toney", "Bogisich", "TONEY_BOGISICH65@YAHOO.COM", "TONEY.BOGISICH22", "AQAAAAIAAYagAAAAEOvb/sfWu/Md7C6MkfWv07aTEv7HxtYNlIehlnN2VNjRn1tCfh5Is68frBsrxwGJ/g==", "395-950-5456", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/396.jpg", "Toney.Bogisich22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "42894 Pfeffer Courts, Alexzanderhaven, Switzerland", "0f152d6b-29c6-4b29-9ff1-50cdd8a5a17b", new DateTime(2024, 8, 25, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(8869), "Neil.Boyer8@yahoo.com", "Neil", "Boyer", "NEIL.BOYER8@YAHOO.COM", "NEIL79", "AQAAAAIAAYagAAAAEDEkVckK0Nm4qIEYmjkDC8RgrzReHB1naYlOWiq0ToluiCtU5bIUy7+4JHfeJAp+iw==", "974-419-7413", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1087.jpg", "Neil79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "544 Bogisich Stream, Ricehaven, Morocco", "21691769-258f-492a-b28f-6046effcc47e", new DateTime(2024, 5, 24, 23, 24, 8, 120, DateTimeKind.Utc).AddTicks(9458), "Sherman40@yahoo.com", "Sherman", "Botsford", "SHERMAN40@YAHOO.COM", "SHERMAN_BOTSFORD80", "AQAAAAIAAYagAAAAEHl1KN2y1V7AbVCdlQDNQOKpKxr0M6RCUR0jVBCQiK0Mq9vHVx+Pjyo/vpEGat/Q2A==", "509-905-6515", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/278.jpg", "Sherman_Botsford80" });

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackLikes_UserId_FeedbackId",
                table: "FeedbackLikes",
                columns: new[] { "UserId", "FeedbackId" },
                unique: true,
                filter: "[FeedbackId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackLikes_AspNetUsers_UserId",
                table: "FeedbackLikes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackLikes_Feedbacks_FeedbackId",
                table: "FeedbackLikes",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Products_ProductId",
                table: "Feedbacks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackLikes_AspNetUsers_UserId",
                table: "FeedbackLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackLikes_Feedbacks_FeedbackId",
                table: "FeedbackLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Products_ProductId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_FeedbackLikes_UserId_FeedbackId",
                table: "FeedbackLikes");

            migrationBuilder.CreateTable(
                name: "FeedbackReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedbackReports_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FeedbackReports_Feedbacks_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "Feedbacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "345 O'Hara Coves, New Madisyn, Portugal", "e1986744-2d64-4034-88b9-2a423e41a1a2", new DateTime(2024, 7, 24, 22, 21, 3, 64, DateTimeKind.Utc).AddTicks(1825), "Theodore.Schroeder37@yahoo.com", "Theodore", "Schroeder", "THEODORE.SCHROEDER37@YAHOO.COM", "THEODORE.SCHROEDER", "AQAAAAIAAYagAAAAEOhszMr8xOk2X6S2KQ+RHEJAAEOI1b/Zh+nI0HPG22ge96g+Ls3ymSGlQvNOXA8Tcw==", "605-340-5861", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/769.jpg", "Theodore.Schroeder" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "765 Koepp Mountains, Grantstad, Venezuela", "6e819021-ab7e-4315-9b95-cb80ea23d965", new DateTime(2024, 11, 20, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(3712), "Sandra.Walker95@gmail.com", "Sandra", "Walker", "SANDRA.WALKER95@GMAIL.COM", "SANDRA50", "AQAAAAIAAYagAAAAEA7FGme7ANgPsDZXI6hbOEB+Jp0sQhrsupMc9ajSezyAynpGpaVzqBiTWV/kKgjFNQ==", "792-002-9827", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/649.jpg", "Sandra50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "455 Schimmel Road, West Elvera, Ireland", "70a4ea81-c1e1-4273-b24a-761585d7420d", new DateTime(2024, 3, 17, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(4000), "Veronica_Fay6@gmail.com", "Veronica", "Fay", "VERONICA_FAY6@GMAIL.COM", "VERONICA2", "AQAAAAIAAYagAAAAEIM17QC4IhfvmjZnTXUqtym+7JoNy+uHNcCwXZjDkIzYWghx8C6lZaDQkRpLAO7Zgw==", "584-525-1501", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/550.jpg", "Veronica2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9860 Trinity Ford, Lindgrenfurt, Somalia", "033d32c2-abc6-4348-a827-5264869e5df5", new DateTime(2024, 8, 14, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(4266), "Bernadine.Bernhard@yahoo.com", "Bernadine", "Bernhard", "BERNADINE.BERNHARD@YAHOO.COM", "BERNADINE.BERNHARD", "AQAAAAIAAYagAAAAEDOS3XHLSBv+1UKZ/O8fc2yERWfIYO/89ShuaZLA3Prq2KBsGElATJkyazO8PYMlUQ==", "487-456-8804", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/219.jpg", "Bernadine.Bernhard" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5475 Torrance Brook, Port Ginoberg, Cook Islands", "d0e63d65-af71-4df5-851c-2a15040dd5e5", new DateTime(2024, 3, 30, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(4480), "Domingo36@yahoo.com", "Domingo", "Ernser", "DOMINGO36@YAHOO.COM", "DOMINGO28", "AQAAAAIAAYagAAAAEMI34NSkiwYCpdE9M57EwmDN5cRlEabdpwFJ7rT4nEZeYsDKIBobz9HK4hb88CRZUQ==", "116-136-6837", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/920.jpg", "Domingo28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1874 Bechtelar Road, Geovannyborough, Ukraine", "76dbc93a-a3d4-48fe-9486-80ae41f12158", new DateTime(2024, 12, 22, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(4723), "Jayden.Collier62@yahoo.com", "Jayden", "Collier", "JAYDEN.COLLIER62@YAHOO.COM", "JAYDEN_COLLIER33", "AQAAAAIAAYagAAAAEGQKV7JxgpWQ39383Ufe6D983+TYoRaed+0LMsqigcAfneT4NAFTuyMKYw3s0bxssQ==", "721-010-8282", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/424.jpg", "Jayden_Collier33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "215 Kulas Canyon, Lessieport, Rwanda", "59adbcac-ac79-42f2-8851-9f7ce3c6a637", new DateTime(2024, 3, 15, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(4930), "Dena.Bergnaum36@gmail.com", "Dena", "Bergnaum", "DENA.BERGNAUM36@GMAIL.COM", "DENA.BERGNAUM8", "AQAAAAIAAYagAAAAEC20y0ViZX5aRvAD/DgzTmISfjfrHw6+l72JTITRc7dlbhuPAwmT5ILixX6MfOjOLw==", "539-863-9648", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/993.jpg", "Dena.Bergnaum8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "835 Carol Circle, South Alanna, Samoa", "4e84d49d-bd8f-4749-8349-086ecda02e80", new DateTime(2024, 4, 27, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(5163), "Nikki_Spencer@hotmail.com", "Nikki", "Spencer", "NIKKI_SPENCER@HOTMAIL.COM", "NIKKI_SPENCER77", "AQAAAAIAAYagAAAAEFpFAhLEIgWa5I7R2Z/+nC+ZWVh1ecpc/HjlHagR/I+VfOLU7VH/6+ioQuBVUjXcfQ==", "801-712-8989", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/893.jpg", "Nikki_Spencer77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7005 Cheyenne Locks, Zoilaville, Solomon Islands", "7b93ec44-6373-460e-a419-e24526321c4f", new DateTime(2024, 12, 4, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(5387), "Marshall3@gmail.com", "Marshall", "Gaylord", "MARSHALL3@GMAIL.COM", "MARSHALL.GAYLORD30", "AQAAAAIAAYagAAAAEK4v/SFbbkjlS1U71hDWVGJ85xNz3VjLUKvI0F0o8H1GNmt4RawYAEkEzJn86WdrIQ==", "529-475-1170", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1030.jpg", "Marshall.Gaylord30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "58751 Sherman Plain, Westmouth, Malaysia", "2519a727-70f7-4329-9c88-2e27a152ba49", new DateTime(2024, 12, 8, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(5644), "Leola.Rogahn19@gmail.com", "Leola", "Rogahn", "LEOLA.ROGAHN19@GMAIL.COM", "LEOLA60", "AQAAAAIAAYagAAAAEDT85dv5gSzIyD0JNxwii0iULG9Vn/+giWWyyS2BmCF5uJbhE5BnFSBIameWTkr5Dw==", "895-870-3208", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/928.jpg", "Leola60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2862 Green Course, Darwinmouth, Democratic People's Republic of Korea", "4651d8c7-a477-41f9-a664-e8fc3585c271", new DateTime(2024, 7, 2, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(5830), "Gwendolyn_Spinka1@gmail.com", "Gwendolyn", "Spinka", "GWENDOLYN_SPINKA1@GMAIL.COM", "GWENDOLYN.SPINKA65", "AQAAAAIAAYagAAAAEPKUZvpU0YvC7v7eXF1XQq7ebM8iihhfhOqPwZN5oXmnErnOmiFiz4WXjJ8m1z4zVQ==", "600-483-5928", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/965.jpg", "Gwendolyn.Spinka65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2320 Lura Alley, Laronmouth, Bahrain", "4aa8e551-3b8e-4a83-b4d7-3b78cae5e615", new DateTime(2024, 4, 11, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(6057), "Lucy.Torp@gmail.com", "Lucy", "Torp", "LUCY.TORP@GMAIL.COM", "LUCY.TORP47", "AQAAAAIAAYagAAAAECPRP2HpaGSeVywuom+TvS/QOINNdbqR3Hra8jK0UOFdqnuq2ZbV/wSnLp1KTnbp9Q==", "933-261-7703", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1034.jpg", "Lucy.Torp47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "452 Lowe Hollow, East Bobby, Cayman Islands", "0e65898b-9cfb-4219-8eda-f9855ed76fcb", new DateTime(2024, 6, 24, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(6250), "Breanne_Renner71@yahoo.com", "Breanne", "Renner", "BREANNE_RENNER71@YAHOO.COM", "BREANNE53", "AQAAAAIAAYagAAAAEBLW1tPUCdBIB3hsYV0+v607qo5WFgvgEHQJbgaqGynFxAximqxhS7COu29iGd2vuw==", "488-244-3125", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1018.jpg", "Breanne53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9695 Marquardt Valleys, Lake Myriam, Yemen", "fa58854c-5186-4a14-a45b-22d72d0d877e", new DateTime(2024, 4, 21, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(6477), "Sammie_Ullrich12@hotmail.com", "Sammie", "Ullrich", "SAMMIE_ULLRICH12@HOTMAIL.COM", "SAMMIE.ULLRICH90", "AQAAAAIAAYagAAAAEGpk4gHORRkWixMmy0iY40gVd2e1qJ3df92klPNLdVSu034+c9F/KJubZ2xwQgWM7Q==", "846-646-1125", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1095.jpg", "Sammie.Ullrich90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3728 Jesse Forest, New Dangelo, Cameroon", "eb20852c-55ac-43e8-b58d-0121e53af942", new DateTime(2025, 1, 29, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(6662), "Randi91@gmail.com", "Randi", "Herzog", "RANDI91@GMAIL.COM", "RANDI37", "AQAAAAIAAYagAAAAENQB11iCEkpM2yFsn3NWP30vG2uvrxAfFGBqcMxfxt3l4kv0SDboCmTZYUE6WkSYRQ==", "358-277-1456", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/290.jpg", "Randi37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7800 Wisoky Island, South Alexandro, Portugal", "04f5570b-278d-4d8e-8f5b-2fca9e7a32c4", new DateTime(2024, 12, 3, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(6857), "Estel_Fadel24@yahoo.com", "Estel", "Fadel", "ESTEL_FADEL24@YAHOO.COM", "ESTEL27", "AQAAAAIAAYagAAAAEJM1lyzJ2kkdqb0Ed7ZtUP5ZFdidgYi3KeEtBus7xfvjMIP8+TOy3obW8A1o8vFzaA==", "059-276-7366", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1151.jpg", "Estel27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "45851 Bailey Grove, Nedraberg, Norfolk Island", "98df0be2-be32-4c29-bf69-e331f30e9858", new DateTime(2024, 8, 24, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(7053), "Zetta.Schamberger@yahoo.com", "Zetta", "Schamberger", "ZETTA.SCHAMBERGER@YAHOO.COM", "ZETTA88", "AQAAAAIAAYagAAAAEMmvoYdJlTm3KP/KvRy6es65EkcIH2xopbh4+TUc/N3S6O7EW8mWs/BhN4rOmIK03w==", "708-967-6983", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/854.jpg", "Zetta88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "37547 Cora Glens, West Israelmouth, United Kingdom", "24949c01-94c4-488c-afc1-4f75d34c99bf", new DateTime(2024, 11, 18, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(7293), "Webster12@yahoo.com", "Webster", "Kozey", "WEBSTER12@YAHOO.COM", "WEBSTER_KOZEY85", "AQAAAAIAAYagAAAAENWg45Jis/oZflvk6Wlkuigz5oD0whXgIK8s1NG9yI1xOQGru/0xGIXFMngolhUAsQ==", "852-726-0166", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1028.jpg", "Webster_Kozey85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "29462 Goodwin Squares, Lake Tiafurt, China", "1eacd4e6-a6cb-4e7e-ad31-d6722dc889c6", new DateTime(2024, 5, 18, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(7476), "Dianna_Littel@gmail.com", "Dianna", "Littel", "DIANNA_LITTEL@GMAIL.COM", "DIANNA60", "AQAAAAIAAYagAAAAENLGqaI74zJq9+LAG7txbyU3Qffneo+JLss0fYlvx/MUc1N8TCnKSYrFUHynEZwaIg==", "133-217-0030", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/249.jpg", "Dianna60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "358 Halvorson Mount, East Seamusburgh, Somalia", "060b4909-bf20-40b6-a7f0-bca1cccfae27", new DateTime(2024, 5, 19, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(7704), "Dariana.Runolfsson@gmail.com", "Dariana", "Runolfsson", "DARIANA.RUNOLFSSON@GMAIL.COM", "DARIANA_RUNOLFSSON", "AQAAAAIAAYagAAAAEJ41kaWSuFWU5BwECqR+cQCVtXfPZFq3twCRE4ZdjrTRVN0WN2apF/RDrZDocAlgNw==", "324-912-8285", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/744.jpg", "Dariana_Runolfsson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "81498 Berge Corner, Henriport, Jamaica", "670f8ca8-fe8d-4007-8c29-4eb6b8bbca57", new DateTime(2024, 11, 19, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(7901), "Stephany23@hotmail.com", "Stephany", "Abbott", "STEPHANY23@HOTMAIL.COM", "STEPHANY.ABBOTT", "AQAAAAIAAYagAAAAEF8s9ubvGrHz1gUiONoVTDhxoyMmhxCV8OEuYCfpH31QSbtyAVS9otaO5K3iDDW+Kg==", "430-210-1808", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/621.jpg", "Stephany.Abbott" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "107 Wilkinson Glens, Lake Blaiseberg, Taiwan", "863e042d-df39-4e61-92a7-a04468402bab", new DateTime(2024, 10, 31, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(8084), "Myah14@yahoo.com", "Myah", "Walsh", "MYAH14@YAHOO.COM", "MYAH34", "AQAAAAIAAYagAAAAEPexFZcWMDxv5clylD9380Lp5jDM2cCsLO92pV5aYS4o+ANwiiwQXOP0aStl1d9zqg==", "011-308-5522", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/961.jpg", "Myah34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "524 Treutel Courts, Kenyattaberg, Spain", "56c52cc3-8ca1-4a49-b6f2-0cc9df583ea0", new DateTime(2024, 12, 7, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(8303), "Chase_Kemmer@hotmail.com", "Chase", "Kemmer", "CHASE_KEMMER@HOTMAIL.COM", "CHASE67", "AQAAAAIAAYagAAAAELOWPuc+kpGOnaB/cWA/s/cKfC1ik1jOOgRlsoVECooaCld9yiXDc4eb57raeVjqXg==", "926-351-7612", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/161.jpg", "Chase67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "23504 Adriel Shoal, Marlenemouth, Virgin Islands, U.S.", "45779433-7d85-4bbf-a894-2d8dc074e8cc", new DateTime(2024, 12, 13, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(8478), "Jaylan.Heaney@yahoo.com", "Jaylan", "Heaney", "JAYLAN.HEANEY@YAHOO.COM", "JAYLAN_HEANEY79", "AQAAAAIAAYagAAAAEEwGDBBbPR14XuweOI6+TvrMFxHmr2QVsLqSiS05HdkPpdn+gttmVl6e3hkl2Zu1eA==", "607-920-1203", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/89.jpg", "Jaylan_Heaney79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "364 Fay Place, East Pierre, Venezuela", "f022d26b-9e73-4d5d-b9dd-9df434aa471e", new DateTime(2024, 12, 29, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(8696), "Loyal4@hotmail.com", "Loyal", "Sanford", "LOYAL4@HOTMAIL.COM", "LOYAL.SANFORD", "AQAAAAIAAYagAAAAEANnRnDFeTNf4GQOmFDR7JI+3OhhDurHGU+DcY44t1mh9A/APo+WiKewLXZONpenIw==", "156-976-0103", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/413.jpg", "Loyal.Sanford" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "709 Vada Crescent, Wehnermouth, India", "652ce822-2765-4355-bee4-d0a32e8c9d51", new DateTime(2024, 3, 26, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(8899), "Solon59@yahoo.com", "Solon", "Anderson", "SOLON59@YAHOO.COM", "SOLON_ANDERSON", "AQAAAAIAAYagAAAAED8pXxWNvzvbgX8ffmuCluOrQZZwgm9MQE/iZt9xJUrC8ZSQSI5hPnh55qwU2dTHzw==", "239-415-1550", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/964.jpg", "Solon_Anderson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "678 Bradtke Ports, New Jaiden, United States of America", "7d80aec2-9c68-43a4-96f2-148fa0720e46", new DateTime(2024, 4, 19, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(9154), "Myrtice_Gutkowski85@hotmail.com", "Myrtice", "Gutkowski", "MYRTICE_GUTKOWSKI85@HOTMAIL.COM", "MYRTICE.GUTKOWSKI", "AQAAAAIAAYagAAAAELNG8tphqrJi8aBYlZWNqmPHY9U0JdIlYbql61FRLGcvTOvRdipnE9P+Pq9lRVjG5A==", "088-150-9004", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/551.jpg", "Myrtice.Gutkowski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "430 Rhianna Tunnel, Vidalland, Saint Vincent and the Grenadines", "fb2b4ca0-a9ea-46e3-a180-adb0b44cf2e4", new DateTime(2024, 10, 28, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(9319), "Ora_Botsford@hotmail.com", "Ora", "Botsford", "ORA_BOTSFORD@HOTMAIL.COM", "ORA.BOTSFORD", "AQAAAAIAAYagAAAAEA3VKZ2VtDAFtvJX1hCjy/iiM1kc9qvK3JYeA8ax1Ym/KdKejLn7/Ij+Xftj6o8ifw==", "781-328-6885", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/417.jpg", "Ora.Botsford" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0780 Ellen Summit, North Stanfurt, Cuba", "80081857-2b53-4adf-868a-06091f9522ae", new DateTime(2024, 10, 18, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(9554), "Lloyd_Beatty46@hotmail.com", "Lloyd", "Beatty", "LLOYD_BEATTY46@HOTMAIL.COM", "LLOYD38", "AQAAAAIAAYagAAAAEOGoC3CikY2cNxMZ+9QOZfFAqXzMAs5s2J35r+JD6htAMSyWwRle+jHJgHYnyzTdFA==", "550-260-5537", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/50.jpg", "Lloyd38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1685 Eden Stream, East Alycefurt, Guatemala", "2265e960-c34f-4474-abcd-a42d7a9dc0ce", new DateTime(2024, 3, 2, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(9738), "Vallie90@hotmail.com", "Vallie", "Cassin", "VALLIE90@HOTMAIL.COM", "VALLIE77", "AQAAAAIAAYagAAAAEDpzOaWKg7kLXcbB9NTRm3TC1+06uwZga6XCu7YjCNhguwYh8ZiD0yucfTbTHWMLEQ==", "773-589-2062", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/290.jpg", "Vallie77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "65762 Chesley Corners, Karinebury, Falkland Islands (Malvinas)", "39f08143-f8c9-4baf-b3d0-b5a45eeaff6e", new DateTime(2024, 6, 23, 22, 21, 3, 65, DateTimeKind.Utc).AddTicks(9979), "Cordelia.Dickinson@gmail.com", "Cordelia", "Dickinson", "CORDELIA.DICKINSON@GMAIL.COM", "CORDELIA_DICKINSON67", "AQAAAAIAAYagAAAAEBrTkconC2A1jXLP5ekLbZKzCdXgnCrNfDw00FOAHvJyfzR8HoqUeXBwSWIikFViDg==", "065-732-5680", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/617.jpg", "Cordelia_Dickinson67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4636 Judge Brooks, Mallieville, Hong Kong", "ad05aa3b-9947-4c98-b94b-b74e5196f66c", new DateTime(2025, 1, 11, 22, 21, 3, 66, DateTimeKind.Utc).AddTicks(143), "Gus14@gmail.com", "Gus", "Mann", "GUS14@GMAIL.COM", "GUS91", "AQAAAAIAAYagAAAAEEvcuJ/B9dwFBClJ5Qg0Mdr1bDKGueaOpjdo9s30a9AQ/Sg+A7Z4VMrzqS8evNCvYQ==", "528-574-9822", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/207.jpg", "Gus91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "09999 Rosalyn Circle, South Rebekahfurt, Brazil", "5c952c1d-8666-48ea-a1b6-041710276dad", new DateTime(2024, 5, 14, 22, 21, 3, 66, DateTimeKind.Utc).AddTicks(350), "Ryan_Homenick46@gmail.com", "Ryan", "Homenick", "RYAN_HOMENICK46@GMAIL.COM", "RYAN.HOMENICK64", "AQAAAAIAAYagAAAAEPl8EsmDABZ9FzOeGtGpPrYiVCGIOisPob6R6RNqyjgcQo6UpHUDq5qrsAceBHdA0A==", "980-935-6601", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/584.jpg", "Ryan.Homenick64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "96814 Hyatt Path, Reynatown, Lao People's Democratic Republic", "55fa9437-2ca7-4fcd-9bbe-e843e7eff44e", new DateTime(2024, 12, 27, 22, 21, 3, 66, DateTimeKind.Utc).AddTicks(533), "Dalton17@hotmail.com", "Dalton", "Herman", "DALTON17@HOTMAIL.COM", "DALTON_HERMAN", "AQAAAAIAAYagAAAAELEjKGQPvEX9OqWUVHdUGg5ud8ofaRdp3eIf4dAudG0MhzeM5d+WFcPyf+L1oQqxxA==", "193-423-1791", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/34.jpg", "Dalton_Herman" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "25846 Legros Squares, New Deontaeberg, Pitcairn Islands", "2ff67f6f-781c-472e-844f-652cb4f25129", new DateTime(2024, 8, 31, 22, 21, 3, 66, DateTimeKind.Utc).AddTicks(762), "Otto_Jenkins@yahoo.com", "Otto", "Jenkins", "OTTO_JENKINS@YAHOO.COM", "OTTO_JENKINS61", "AQAAAAIAAYagAAAAEM3Nfcs+Gi7xuPPXWn0toFQV457Or60THA39TytaTZMTaafDFm+KRu0C7YiIOOcAAw==", "938-240-0141", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/533.jpg", "Otto_Jenkins61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8688 Jazmyne Key, Daisyland, Mauritania", "5e58c4e6-0d99-4ede-bc42-5e0acff46a3b", new DateTime(2025, 1, 15, 22, 21, 3, 66, DateTimeKind.Utc).AddTicks(941), "Rae.Osinski@hotmail.com", "Rae", "Osinski", "RAE.OSINSKI@HOTMAIL.COM", "RAE79", "AQAAAAIAAYagAAAAENk3wbVTxbvMWsdKN/8GqUX2mOQPhUs7oyvwgHX4edTTtMXeXF0J7XApBtdu7asKHQ==", "563-430-4945", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/437.jpg", "Rae79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "29167 Patsy Gardens, Rodriguezville, Egypt", "b75e6154-9564-430e-be98-c874d3811211", new DateTime(2024, 9, 29, 22, 21, 3, 66, DateTimeKind.Utc).AddTicks(1161), "Freddy_Russel60@yahoo.com", "Freddy", "Russel", "FREDDY_RUSSEL60@YAHOO.COM", "FREDDY_RUSSEL81", "AQAAAAIAAYagAAAAEONafctfZm9+n7njDM9qnFElBfppkknlw0NmVjq18erQimJkSqhj3kjEYsJJWScHZg==", "238-930-5751", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/219.jpg", "Freddy_Russel81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5195 Ritchie Square, South Nilsville, Netherlands", "001c1fb1-c404-494c-bbac-907b0cb4ae05", new DateTime(2024, 12, 23, 22, 21, 3, 66, DateTimeKind.Utc).AddTicks(1331), "Kip_Zieme59@yahoo.com", "Kip", "Zieme", "KIP_ZIEME59@YAHOO.COM", "KIP71", "AQAAAAIAAYagAAAAEOHN4gGygBDZfds+zDc5xuEW8gQfRqUowP788bzDr6slaxK0UtdSkb9hmVA2+ZWMCQ==", "421-232-3826", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1038.jpg", "Kip71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "65391 Ratke Wells, West Rosannaview, Mongolia", "b2e4199b-1b3d-4b26-9e5e-aa55f31c61c8", new DateTime(2024, 2, 17, 22, 21, 3, 66, DateTimeKind.Utc).AddTicks(1530), "Stewart69@yahoo.com", "Stewart", "Crist", "STEWART69@YAHOO.COM", "STEWART53", "AQAAAAIAAYagAAAAEIlrnz1G8pZ3KoGb0NWfssPx/n1bdfdHT9AQOrRgu6caYr9VzfHxf1xWFC42OBsG7A==", "528-547-0313", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/160.jpg", "Stewart53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "748 Stacey Ville, Lake Adam, Svalbard & Jan Mayen Islands", "142a00b6-a1fc-4cbf-8773-e4fc0fd68ed0", new DateTime(2024, 3, 18, 22, 21, 3, 66, DateTimeKind.Utc).AddTicks(1714), "Enos.Hilpert@gmail.com", "Enos", "Hilpert", "ENOS.HILPERT@GMAIL.COM", "ENOS34", "AQAAAAIAAYagAAAAECHhuxq8CfbOieOcry/C1MSGgSHg0J/zRCPyXOOVAZJpwXarYwATJ4CyNxuwAC3OaA==", "479-118-5291", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/520.jpg", "Enos34" });

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackLikes_UserId",
                table: "FeedbackLikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackReports_FeedbackId",
                table: "FeedbackReports",
                column: "FeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackReports_UserId",
                table: "FeedbackReports",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackLikes_AspNetUsers_UserId",
                table: "FeedbackLikes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackLikes_Feedbacks_FeedbackId",
                table: "FeedbackLikes",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Products_ProductId",
                table: "Feedbacks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
