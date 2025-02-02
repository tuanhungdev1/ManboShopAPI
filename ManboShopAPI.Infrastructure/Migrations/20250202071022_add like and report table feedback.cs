using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addlikeandreporttablefeedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Feedbacks",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "FeedbackLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedbackLikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedbackLikes_Feedbacks_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "Feedbacks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FeedbackReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedbackReports_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedbackReports_Feedbacks_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "Feedbacks",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "077 Oberbrunner Park, West Rorybury, Aruba", "54b10b2d-086d-43b8-b892-37f613b26177", new DateTime(2024, 9, 29, 7, 10, 19, 798, DateTimeKind.Utc).AddTicks(3101), "Oceane_Cummings86@yahoo.com", "Oceane", "Cummings", "OCEANE_CUMMINGS86@YAHOO.COM", "OCEANE44", "AQAAAAIAAYagAAAAECb/cUoAOD7V+TjfXgTg8pLXRPPMLBX9EAnJVvY0Dsj0aQ/1KPqmBtfNSLtIopUtrA==", "425-667-0698", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/666.jpg", "Oceane44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "38458 Rashawn Crescent, South Jazmyneberg, Albania", "2127be1f-1c95-4500-a7ef-ccb3b4c61c9c", new DateTime(2024, 4, 3, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(7377), "Keith.Gleichner@gmail.com", "Keith", "Gleichner", "KEITH.GLEICHNER@GMAIL.COM", "KEITH.GLEICHNER", "AQAAAAIAAYagAAAAEOrY5jD/+AoZBhTqTx4GyWmj0w3dxkMlqYipByPSe62ZirhteWfuSzhDYTaMcQPonA==", "633-861-9113", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/257.jpg", "Keith.Gleichner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "01853 Adams Ridges, Gradytown, Uzbekistan", "2acd26d4-3298-4831-b70d-b23d11c4d831", new DateTime(2025, 1, 8, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(7752), "Bertram30@yahoo.com", "Bertram", "Tillman", "BERTRAM30@YAHOO.COM", "BERTRAM46", "AQAAAAIAAYagAAAAEDexS9ZsCPJFweNzbY7h2qZQtw/VLqRm7I2XXgpLrmGv/gPOEaiNw/KGt6/GtDD6LQ==", "136-933-1261", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/859.jpg", "Bertram46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "686 Brody Radial, VonRuedenborough, Swaziland", "d0081d86-b9cc-4399-aa00-b72bdd811fb7", new DateTime(2024, 7, 17, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(8026), "Garett47@yahoo.com", "Garett", "Powlowski", "GARETT47@YAHOO.COM", "GARETT_POWLOWSKI77", "AQAAAAIAAYagAAAAEJEe3aP45QcJZ0DidS2ufgpqonUxsppaav/2t8uRQyztZ9YXMb+JTMp8QhOxVShPMg==", "494-933-6243", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/944.jpg", "Garett_Powlowski77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "575 Rubie Land, Pagachaven, French Guiana", "e79e878c-589e-4dfc-9bbb-a4db07e79960", new DateTime(2024, 11, 28, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(8235), "Brennon39@gmail.com", "Brennon", "Kerluke", "BRENNON39@GMAIL.COM", "BRENNON45", "AQAAAAIAAYagAAAAEGfoj0oMZdqX9ofAx9sci9TStEKAAzXYu7GwwrRYJl2WBQEDocTSE7aTkxn4ZtrEMw==", "507-438-4071", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/608.jpg", "Brennon45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "18378 Leannon Ridge, Chrisshire, Luxembourg", "0ce6ef9a-0842-4958-aaf6-079ce6be8544", new DateTime(2024, 4, 18, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(8468), "Roosevelt71@hotmail.com", "Roosevelt", "Kassulke", "ROOSEVELT71@HOTMAIL.COM", "ROOSEVELT35", "AQAAAAIAAYagAAAAEGC+E5Dnkn25VChTXwpUmebV2ydjHpQ2pEM8722i9TulNd4mC34w8+lDvOxEr1dHrA==", "195-265-5105", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/534.jpg", "Roosevelt35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "003 Mustafa Forges, Sadieberg, United Arab Emirates", "b7c4c342-aed7-4b05-b70f-1857404c8ca0", new DateTime(2024, 4, 24, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(8678), "Lionel.Predovic@yahoo.com", "Lionel", "Predovic", "LIONEL.PREDOVIC@YAHOO.COM", "LIONEL_PREDOVIC", "AQAAAAIAAYagAAAAELVoFdqfj297V48C2QE+wJfpcC4Y9DHMXEGkHUd+jFzZdwXu/65/XkAN8bRFDXx2xA==", "222-074-5688", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1220.jpg", "Lionel_Predovic" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8054 Zachery Expressway, New Darrin, Lebanon", "3b506795-06c7-418b-b297-4309caf0b9c7", new DateTime(2024, 12, 10, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(8934), "Oda.Considine@gmail.com", "Oda", "Considine", "ODA.CONSIDINE@GMAIL.COM", "ODA.CONSIDINE98", "AQAAAAIAAYagAAAAEIXjznZHwGSNYFIIqTzxPxArsH7cQefZmT7YYqaCSnXuNq24Z6QGl/jChT1T1SfQoQ==", "747-762-0939", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/132.jpg", "Oda.Considine98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7236 Jovani Forge, Carleeberg, Sudan", "50186085-74fa-4cc2-8174-22cf2621f13d", new DateTime(2024, 3, 17, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(9125), "Mose.Macejkovic@yahoo.com", "Mose", "Macejkovic", "MOSE.MACEJKOVIC@YAHOO.COM", "MOSE_MACEJKOVIC", "AQAAAAIAAYagAAAAECT+eascTZYy8F8AyldITGdsFXerOyA/VOnavTX047br6kkbA+6zmgUXCdsGolPA2w==", "753-645-4433", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/144.jpg", "Mose_Macejkovic" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "01463 Anderson Highway, Rutherfordville, Chad", "1899e0f4-799d-4546-8d68-e2a8cfb5ec05", new DateTime(2024, 6, 22, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(9393), "Winfield21@hotmail.com", "Winfield", "Jacobi", "WINFIELD21@HOTMAIL.COM", "WINFIELD.JACOBI37", "AQAAAAIAAYagAAAAEGy919EVHTu4Pv3E+UuWQjwoLvM/BCPBk8lQ85t3tss51goCzy2TRWCnsL4pJp8u8w==", "688-290-3233", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/26.jpg", "Winfield.Jacobi37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0930 Elmira Drive, Garfieldborough, Turks and Caicos Islands", "f6e4cc6e-5a27-4e80-989c-36918ef4454e", new DateTime(2024, 10, 28, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(9633), "Trent.Lesch@yahoo.com", "Trent", "Lesch", "TRENT.LESCH@YAHOO.COM", "TRENT48", "AQAAAAIAAYagAAAAEH33a8JdQ6TP9NcKVzVq9g/IhyQz9yPGdBs2hPiMcAkFBemQN5t9TY5B09tQkDN14Q==", "104-659-2531", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1209.jpg", "Trent48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "990 Gutmann Crescent, Generalbury, Uganda", "a1a6c79b-ac10-43a3-9037-20ac5f1f0ef6", new DateTime(2024, 10, 19, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(9841), "Liliane72@hotmail.com", "Liliane", "Nikolaus", "LILIANE72@HOTMAIL.COM", "LILIANE.NIKOLAUS75", "AQAAAAIAAYagAAAAEEsVaBHr6yMkYLFYq1wSRlH5BHzQc34f88bYdI0HcH7qhjh5wDoAnv6st6Li/qju0w==", "821-842-4956", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/983.jpg", "Liliane.Nikolaus75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1280 Harber Overpass, Randallberg, Iraq", "5b96515e-6aa0-4e2c-bd36-647f038590dd", new DateTime(2024, 11, 30, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(33), "Nichole.Runte6@gmail.com", "Nichole", "Runte", "NICHOLE.RUNTE6@GMAIL.COM", "NICHOLE_RUNTE", "AQAAAAIAAYagAAAAEA4P1IxwwzMBHvPne2MVPWT5YxgCH/6gk4wV5lcoBprYeifS48bWKh9sjaSYHuk5aQ==", "370-073-3342", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/414.jpg", "Nichole_Runte" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "51011 Dalton Square, North Kenneth, Svalbard & Jan Mayen Islands", "738914cc-97fd-477b-8c7d-cd9fc5afdda1", new DateTime(2024, 6, 13, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(249), "Boris55@gmail.com", "Boris", "Emmerich", "BORIS55@GMAIL.COM", "BORIS.EMMERICH85", "AQAAAAIAAYagAAAAEDGKdenD9D8GPOOJMiRMSf4ISGpo9aLdk8mZuOUX8Rn6RebYeom91475w67MMfMrsw==", "403-177-6450", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/570.jpg", "Boris.Emmerich85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "599 Garett Place, West Meredithberg, Antigua and Barbuda", "2de6e217-cce9-48ee-8e63-23b4bb2851ed", new DateTime(2024, 6, 9, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(431), "Ellie_Wisozk@yahoo.com", "Ellie", "Wisozk", "ELLIE_WISOZK@YAHOO.COM", "ELLIE76", "AQAAAAIAAYagAAAAEJ/1u+t9+jCS4BPEcPYXbqT3iT8oW/G3haMD3hGZmeZiD3oPiS9i4hWvqrMnJBvykg==", "579-686-9218", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/738.jpg", "Ellie76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "72906 Hilll Manors, Maryseville, Papua New Guinea", "e7fbd63f-4d88-4f19-9b74-4854fe21110d", new DateTime(2024, 6, 18, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(680), "Kailey_Stiedemann@gmail.com", "Kailey", "Stiedemann", "KAILEY_STIEDEMANN@GMAIL.COM", "KAILEY_STIEDEMANN", "AQAAAAIAAYagAAAAEBIawalxI9Uz6N0SBaNi8hHfVOEAsmnsehDjRvWUgW+6l/msoNw3L2GDcWRgau+MBg==", "900-174-6926", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/33.jpg", "Kailey_Stiedemann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "51628 Abernathy Place, South Mya, Cambodia", "801fd928-1a59-44b8-8db1-b1ba34506a74", new DateTime(2025, 1, 22, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(897), "Abigale71@gmail.com", "Abigale", "Littel", "ABIGALE71@GMAIL.COM", "ABIGALE.LITTEL85", "AQAAAAIAAYagAAAAEOZVq++oaFxmPm0Ea/Ur32EMNUt+3Uel5irQSfoFAAVWZFJreQs8Rya/f2yA0exfIA==", "083-851-1081", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/835.jpg", "Abigale.Littel85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1927 Halvorson Tunnel, Titusport, Lithuania", "c35cdef9-7d9a-4912-939d-7ea49098b845", new DateTime(2024, 8, 30, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(1093), "Armando.Kertzmann96@gmail.com", "Armando", "Kertzmann", "ARMANDO.KERTZMANN96@GMAIL.COM", "ARMANDO_KERTZMANN", "AQAAAAIAAYagAAAAEK30+yVh//iz+DWFsr/tkOFxJi+SZV6rbCL8QEvVscy4TfWhCDPIBS76wzzrF2NaQQ==", "927-223-6627", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/896.jpg", "Armando_Kertzmann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "155 Will Extension, East Rolandoville, Guinea-Bissau", "1be9000b-acc8-48ac-bf59-bd9b52bffd56", new DateTime(2024, 7, 31, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(1317), "Corrine.Cummings@yahoo.com", "Corrine", "Cummings", "CORRINE.CUMMINGS@YAHOO.COM", "CORRINE39", "AQAAAAIAAYagAAAAEBM1bHr9vaEb1hzgQAqSXs7mzjbIOYNu9A3VbmvP0WOD+H1quAcDJdybwIqLnJoFrg==", "291-277-0830", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/297.jpg", "Corrine39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "952 Lemke Square, Gastonville, Netherlands", "f22ade51-b92f-4e11-8d42-b89aeff38474", new DateTime(2024, 3, 7, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(1493), "Elmore_Flatley61@yahoo.com", "Elmore", "Flatley", "ELMORE_FLATLEY61@YAHOO.COM", "ELMORE.FLATLEY67", "AQAAAAIAAYagAAAAEI7Bf7BJedbqcByLAtWICOM4+XfH8UPMqzP/7xy6GBrLatD3mUwHB8OgAGtt0ziNvw==", "815-832-2911", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/492.jpg", "Elmore.Flatley67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "48744 Baumbach Vista, Cruzport, Christmas Island", "158c1b91-455f-4570-995d-e9dadf016767", new DateTime(2024, 3, 3, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(1724), "Thaddeus_Blick53@gmail.com", "Thaddeus", "Blick", "THADDEUS_BLICK53@GMAIL.COM", "THADDEUS21", "AQAAAAIAAYagAAAAELpRZZYbnh9RV7dwL7QW7w4CcitBYOwa3qbTDSAp0Kpi/P6sHQRXlDp+C/T2TSEfzw==", "007-660-0114", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/596.jpg", "Thaddeus21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "649 Fiona Green, Darronfort, Guadeloupe", "bc667860-e08e-492a-bed8-ba56b1d269cb", new DateTime(2024, 12, 8, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(1913), "Clair77@yahoo.com", "Clair", "Schamberger", "CLAIR77@YAHOO.COM", "CLAIR.SCHAMBERGER29", "AQAAAAIAAYagAAAAEIpb/Jbb/rsSpJ3lIOzsBk8JrTFiPg/+nuezZVlIaJ0DFKOq4P0VhGfr060FkjARew==", "670-659-6848", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1173.jpg", "Clair.Schamberger29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1999 Hagenes Causeway, Harveyfort, Guinea-Bissau", "aed1b8a7-4ad0-478b-a309-554e23256b3f", new DateTime(2024, 7, 30, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(2117), "Rosetta18@gmail.com", "Rosetta", "Mosciski", "ROSETTA18@GMAIL.COM", "ROSETTA.MOSCISKI", "AQAAAAIAAYagAAAAEC6L4TnRKijBtlxn8gM3Mp9OCkPiCSEtY8L/IXGoPOp/kkFOLVK9jmVO/aPUGlRhHQ==", "765-208-8248", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/641.jpg", "Rosetta.Mosciski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "94715 O'Reilly Center, South Morris, Estonia", "23b57ad7-f26f-44aa-9de7-4df82361dff9", new DateTime(2024, 9, 8, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(2286), "Samir49@gmail.com", "Samir", "Ledner", "SAMIR49@GMAIL.COM", "SAMIR.LEDNER", "AQAAAAIAAYagAAAAEBINDCSPT2zgNYnLXsu0PdUBLGv9v81k3r+PgxOhjHn9+u+2UW+nsPlTcWuynOtINQ==", "175-922-1747", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/744.jpg", "Samir.Ledner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "242 Koepp Stream, Port Talonfort, Gabon", "1d45c6e2-d953-4834-9510-2b40779eec8e", new DateTime(2024, 4, 1, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(2489), "Gabriella.Berge47@gmail.com", "Gabriella", "Berge", "GABRIELLA.BERGE47@GMAIL.COM", "GABRIELLA.BERGE", "AQAAAAIAAYagAAAAEJFX9gQqBYA0EejcvHaWg2yHB44y/cD3Blv1fJdKm/UnZ67QAibZD2NT1P+rhYeU8g==", "696-309-9043", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1133.jpg", "Gabriella.Berge" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "82534 Enid Knolls, Schuppeland, Brunei Darussalam", "6a536e39-e49e-4a2b-a70e-0127740418e2", new DateTime(2024, 2, 17, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(2794), "Jackson_Tromp4@gmail.com", "Jackson", "Tromp", "JACKSON_TROMP4@GMAIL.COM", "JACKSON.TROMP53", "AQAAAAIAAYagAAAAELrmDI5LpZ87PPx9hGlLx55yHbNWe9/mNz81Ox4R8YKAHknH62UuFfguMCtQogldRQ==", "778-217-4354", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/158.jpg", "Jackson.Tromp53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9071 Una Flat, New Vaughn, Bermuda", "2a53231f-ce2c-45b4-99cc-2c2e77630f28", new DateTime(2024, 8, 29, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(2992), "Hilbert74@gmail.com", "Hilbert", "Reynolds", "HILBERT74@GMAIL.COM", "HILBERT.REYNOLDS41", "AQAAAAIAAYagAAAAEHhknLkY+s+Xw7Zi/d/trTXK5Rft71YtGF+fTCR8N44V+xu2Aqt3OfC0zSq6ZpzmXw==", "633-832-5256", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/448.jpg", "Hilbert.Reynolds41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "02015 Will Ford, Terrellbury, Taiwan", "aa76a422-a472-471a-a0b7-b2b0a961c4d8", new DateTime(2024, 8, 2, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(3163), "Arden_Ferry@gmail.com", "Arden", "Ferry", "ARDEN_FERRY@GMAIL.COM", "ARDEN_FERRY4", "AQAAAAIAAYagAAAAEBGazUtwKNlRy6Zwp40kj9TQk27zQiln7c8LFInzRN7VWRuj6Ar+h5I7Dh8KQwdY5w==", "856-640-2069", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/227.jpg", "Arden_Ferry4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "94301 Humberto Locks, North Jessikastad, Philippines", "1f16c4e0-a979-42fa-8964-5859a5618030", new DateTime(2024, 2, 26, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(3381), "Eloise_Carter@gmail.com", "Eloise", "Carter", "ELOISE_CARTER@GMAIL.COM", "ELOISE15", "AQAAAAIAAYagAAAAEB2FzWqVZ0O1Uljzx+nP6GGNoT46idifudqyG15OoJMCbNwtrPZOYYCykc5zxu1nsw==", "266-162-9135", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/402.jpg", "Eloise15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "246 Haley Summit, Wymanhaven, Saudi Arabia", "e9a63d89-a867-4d77-8f77-f2873703e284", new DateTime(2024, 12, 11, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(3585), "Mario.Aufderhar@hotmail.com", "Mario", "Aufderhar", "MARIO.AUFDERHAR@HOTMAIL.COM", "MARIO_AUFDERHAR16", "AQAAAAIAAYagAAAAECcJINqsZhxEA8q1Ut8mpnxjWNTz53KoaUsY6yq3/Rh/djeBKtRUDKBdrL9bqX7GtA==", "294-471-2972", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/441.jpg", "Mario_Aufderhar16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "500 Hertha Center, Eldredmouth, United Arab Emirates", "76422c61-4147-4d7a-b46c-f7c9cb56c9a7", new DateTime(2024, 4, 29, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(3793), "Mabelle96@hotmail.com", "Mabelle", "Heidenreich", "MABELLE96@HOTMAIL.COM", "MABELLE_HEIDENREICH82", "AQAAAAIAAYagAAAAEE91v6h2NmJi3sF2nJDliIGaKX9sxZ+jk8LTr/f/4wWMfcFuusW0Apui7JtFkngmVw==", "466-057-3669", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/934.jpg", "Mabelle_Heidenreich82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "453 Craig Run, East Timothyfort, Qatar", "ea8830ec-8e57-4d72-be07-0bba6aeec83d", new DateTime(2024, 8, 23, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4016), "Tamia_Stracke87@gmail.com", "Tamia", "Stracke", "TAMIA_STRACKE87@GMAIL.COM", "TAMIA_STRACKE", "AQAAAAIAAYagAAAAEB7DXv86Nkt9wEj54F3+Ne3HMJVtwL9+qQKYkVTNxU4oNc8KnzuEGE2VjNuyBF+JXA==", "632-522-9615", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/940.jpg", "Tamia_Stracke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "11673 Hyatt Freeway, Port Evalynborough, Portugal", "c04f369b-90fa-47cd-84f5-d737ee80de4c", new DateTime(2024, 9, 20, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4197), "Sydnee.Jerde84@hotmail.com", "Sydnee", "Jerde", "SYDNEE.JERDE84@HOTMAIL.COM", "SYDNEE_JERDE", "AQAAAAIAAYagAAAAEOjuRDoBQanp5wAUALAmVTAyFjuDRXcUOcCj+Tvo9XLRrZA21KCy1MFUS8N/Hfn3UA==", "120-497-1259", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1042.jpg", "Sydnee_Jerde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8509 Jo Courts, Adityamouth, Mexico", "cd79909d-3ba9-4247-9395-c1828cfb4f1c", new DateTime(2025, 1, 3, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4406), "Odie_Lindgren67@yahoo.com", "Odie", "Lindgren", "ODIE_LINDGREN67@YAHOO.COM", "ODIE.LINDGREN85", "AQAAAAIAAYagAAAAEKDs/ea3QvlVI3pXJXRDZS9fJcBZUhskpxf6nzFJbRSoCT2MSzFOcZhRAvp0Km/J4Q==", "882-405-7652", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/818.jpg", "Odie.Lindgren85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9372 Mike Greens, Vellamouth, Canada", "a4c80844-f65d-4dcb-969b-22fd9a4d996a", new DateTime(2024, 4, 11, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4576), "Summer.Maggio@hotmail.com", "Summer", "Maggio", "SUMMER.MAGGIO@HOTMAIL.COM", "SUMMER_MAGGIO96", "AQAAAAIAAYagAAAAEPZFOR5Fm3M5qD4CoQgMOPL7QZYLbhU3MHJYjNhVyub80eEhXHKr67I4GfOlbylGHw==", "705-215-7796", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/618.jpg", "Summer_Maggio96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3072 Josie Points, Greggville, Belarus", "695985d8-42e4-496c-8b23-0968a9f54786", new DateTime(2024, 4, 3, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4775), "Quincy.Kovacek@yahoo.com", "Quincy", "Kovacek", "QUINCY.KOVACEK@YAHOO.COM", "QUINCY.KOVACEK29", "AQAAAAIAAYagAAAAEEpIjdiE7C0WAZOvegnnF0dikxom1xAodKI4K7Is98Joluql7YqXqv+m9Tj0Z8P80A==", "106-670-9748", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/663.jpg", "Quincy.Kovacek29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "300 Hayes Points, Calistaborough, Germany", "4ba15f08-714b-4363-8049-16c1595a59a5", new DateTime(2024, 9, 15, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4970), "Filiberto_Crist52@hotmail.com", "Filiberto", "Crist", "FILIBERTO_CRIST52@HOTMAIL.COM", "FILIBERTO.CRIST", "AQAAAAIAAYagAAAAEKMFp9TEoDezMqej+N8sz/WwxCkk3ZZEaxxsPUZ7N+bDL/TF4ntY192oioi4Rh/wbA==", "829-625-7316", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/317.jpg", "Filiberto.Crist" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3477 Creola Drives, Bruenmouth, Argentina", "9d67faee-76f3-4e3f-bed2-9a5ea62ae19b", new DateTime(2024, 7, 1, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(5223), "Bethel_Armstrong@hotmail.com", "Bethel", "Armstrong", "BETHEL_ARMSTRONG@HOTMAIL.COM", "BETHEL_ARMSTRONG98", "AQAAAAIAAYagAAAAEF/3C3OQ3/B+PwX8V2K6ytkDpZwR09o9ORyyWFT1KJtz+cyOmCA+PO/vt9Ja5400MQ==", "496-314-6005", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1204.jpg", "Bethel_Armstrong98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "944 Hagenes Port, Port Elenora, Cambodia", "96876b6c-284e-47e6-a42d-4a09faa57f7e", new DateTime(2024, 7, 4, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(5395), "Mellie.Fadel@gmail.com", "Mellie", "Fadel", "MELLIE.FADEL@GMAIL.COM", "MELLIE_FADEL91", "AQAAAAIAAYagAAAAENe60TH6PNA41VtvbkYM38vWYOtWtauwBrLW7/hpfK7fUxQPfuRGJtzV1535+VsStg==", "924-170-3356", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/325.jpg", "Mellie_Fadel91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "681 Auer Hollow, Lake Rupertmouth, Kazakhstan", "d136c130-f129-4c1d-a066-60d0be6e0940", new DateTime(2024, 9, 25, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(5594), "Ben_West85@yahoo.com", "Ben", "West", "BEN_WEST85@YAHOO.COM", "BEN.WEST12", "AQAAAAIAAYagAAAAEE2MoLnSDAzxXnKhAX9ULbHKxeF1XydOAJBamyZQWJJ6UaySN0Fn3zESEobRgVAVSg==", "617-541-6810", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/830.jpg", "Ben.West12" });

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackLikes_FeedbackId",
                table: "FeedbackLikes",
                column: "FeedbackId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedbackLikes");

            migrationBuilder.DropTable(
                name: "FeedbackReports");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Feedbacks");

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
    }
}
