using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class createTableOrderAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CancelledAt",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ConfirmedAt",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveredAt",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PaymentMethod",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PaymentStatus",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProcessedAt",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ShippedAt",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShippingAddressId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingFee",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "OrderAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    City = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    State = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderAddresses_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_OrderAddresses_OrderId",
                table: "OrderAddresses",
                column: "OrderId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderAddresses");

            migrationBuilder.DropColumn(
                name: "CancelledAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ConfirmedAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveredAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProcessedAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippedAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingAddressId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingFee",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9674 Savannah Creek, North Mariehaven, Georgia", "8123372d-8af0-47ab-97a0-e7a18952f5b4", new DateTime(2024, 6, 20, 23, 32, 47, 845, DateTimeKind.Utc).AddTicks(9717), "Delfina.McCullough4@hotmail.com", "Delfina", "McCullough", "DELFINA.MCCULLOUGH4@HOTMAIL.COM", "DELFINA.MCCULLOUGH", "AQAAAAIAAYagAAAAEIYZpHq8a/vSMy9nhyQg9Bh1/DXBCsEH2Nhmb5W8xiWPVam6kHHu8bn0j9wKk7wVOw==", "052-298-4170", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1138.jpg", "Delfina.McCullough" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5092 Johns Extension, Port Mireillestad, Estonia", "a57d057f-7406-4353-be6c-d5d425e66cbf", new DateTime(2024, 11, 1, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(3036), "Ashleigh.White@hotmail.com", "Ashleigh", "White", "ASHLEIGH.WHITE@HOTMAIL.COM", "ASHLEIGH_WHITE", "AQAAAAIAAYagAAAAEO1YhQJOYKWkPVBA/ISKUQKwQgjGw1fLb8wAwLJ9Qr/jjzrc6RwoDulN+psOsYfBZQ==", "811-835-4498", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/125.jpg", "Ashleigh_White" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2006 Veum Prairie, Isabellashire, Montenegro", "0b01f792-64f9-40d4-a280-b43f8c01b861", new DateTime(2024, 5, 22, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(3387), "Guy.Stehr88@hotmail.com", "Guy", "Stehr", "GUY.STEHR88@HOTMAIL.COM", "GUY.STEHR0", "AQAAAAIAAYagAAAAEFWKp7K2mTlAWa2e6ebNftGlnIavYgMCognSKoY23vchPh6PbXIwmpaLYjoX4dOR8A==", "289-568-1035", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/136.jpg", "Guy.Stehr0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6047 Heidenreich Viaduct, East Breanne, Burundi", "b0387a9b-03b6-488e-a2d1-ee4383b6339b", new DateTime(2024, 10, 9, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(3630), "Foster78@hotmail.com", "Foster", "Marquardt", "FOSTER78@HOTMAIL.COM", "FOSTER44", "AQAAAAIAAYagAAAAEPo+oDV+TM0xPcLI85OXvk3FzxKWapCaPYl/qwZJ6yRLs48+jwaTtIgT4wT/w7PKsA==", "254-242-0600", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/16.jpg", "Foster44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "397 Sawayn Highway, Lake Halle, Saint Pierre and Miquelon", "9f4db71f-2edd-4437-aeef-067b21157b4a", new DateTime(2024, 11, 6, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(3953), "Adelbert17@hotmail.com", "Adelbert", "Lueilwitz", "ADELBERT17@HOTMAIL.COM", "ADELBERT.LUEILWITZ", "AQAAAAIAAYagAAAAELCOL5EsIYoyWtZxNM6BFV4J+nS9avYHPYBvOfYzYpmXQo/R7Ilfysww/i0aEs4OaQ==", "460-968-5330", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1071.jpg", "Adelbert.Lueilwitz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "631 Kautzer Corner, Botsfordville, Bahamas", "af355c3c-d7a9-4b28-a77d-ed3e21fd9cce", new DateTime(2024, 12, 20, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(4207), "Elyse24@gmail.com", "Elyse", "Nitzsche", "ELYSE24@GMAIL.COM", "ELYSE.NITZSCHE30", "AQAAAAIAAYagAAAAEABTWOKF+OV4n5XffsSS7pHiMtPFrPwFcRkCoLexE7DFHJ7yA9p4cOJV1HPGBwPoaw==", "008-502-0775", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/476.jpg", "Elyse.Nitzsche30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "288 Donnelly Trafficway, North Juliusport, Togo", "1a2ef54c-de22-42d7-8332-74fba604fc54", new DateTime(2025, 1, 27, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(4477), "Eugenia.Wisoky@hotmail.com", "Eugenia", "Wisoky", "EUGENIA.WISOKY@HOTMAIL.COM", "EUGENIA11", "AQAAAAIAAYagAAAAEFKO7XeuvexQdUcj3mMOz+oWjUtj3xMf9ZFycMMzLuYVcXU37VQJUduvM+z3gRwbkw==", "549-215-8754", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1111.jpg", "Eugenia11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "33195 Carroll Mews, East Boborough, French Guiana", "58cecc50-bf25-4c2b-8edd-7d352e6f602f", new DateTime(2024, 11, 12, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(4737), "Chadrick15@yahoo.com", "Chadrick", "Gerlach", "CHADRICK15@YAHOO.COM", "CHADRICK.GERLACH", "AQAAAAIAAYagAAAAEFlEpediQLREhWipRfZvtg/Vhsy09yGV6T423oPiKL1sa5FwWKEa6r7Qp6CNiKmitw==", "455-079-1239", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1036.jpg", "Chadrick.Gerlach" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "136 Nolan Port, Cheyenneberg, Namibia", "519ef944-6006-4ba6-abbb-36bcf2f03e0f", new DateTime(2024, 3, 3, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(4938), "Adrianna11@gmail.com", "Adrianna", "Fahey", "ADRIANNA11@GMAIL.COM", "ADRIANNA.FAHEY84", "AQAAAAIAAYagAAAAEPfSt0LSk0HjkwBL0zHykQb1x90m0DPJjiKTkU5HrlyQD1taxRX5oY8OCrUDIySARA==", "203-843-2418", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/294.jpg", "Adrianna.Fahey84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "54320 Jordy Oval, New Linneaview, El Salvador", "a483ff1c-174c-4048-ae45-c32042a6ddb2", new DateTime(2024, 8, 30, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(5202), "Pierre.Yost@gmail.com", "Pierre", "Yost", "PIERRE.YOST@GMAIL.COM", "PIERRE_YOST59", "AQAAAAIAAYagAAAAEFv833AYJS4m8UY4CMJwHkjIaEduxubdw/h5OyDb6QyfTtueVfwEsw1OX28cKP+P7Q==", "715-174-8039", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/819.jpg", "Pierre_Yost59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "18658 Mariela Station, Lake Caitlyn, Tonga", "44faf38e-fee9-4d0e-b08d-1ed89869e83d", new DateTime(2024, 7, 2, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(5410), "Malinda29@yahoo.com", "Malinda", "Schaden", "MALINDA29@YAHOO.COM", "MALINDA.SCHADEN", "AQAAAAIAAYagAAAAELVO7caoF6GasctwveQxckmgJrspVXNGDGqTHMcn8YMD8khJgTjsNoI4IlnkdxlRPg==", "205-310-3575", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/985.jpg", "Malinda.Schaden" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8870 Jaida Centers, East Estevanhaven, Zimbabwe", "2cc84c0b-e43b-4679-beff-c2337b17b268", new DateTime(2024, 7, 20, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(5647), "Sigmund.Emard25@hotmail.com", "Sigmund", "Emard", "SIGMUND.EMARD25@HOTMAIL.COM", "SIGMUND63", "AQAAAAIAAYagAAAAEF+73Y4Rj5VEZ+0KcYlnI54cXtpWlx3RsfqwwPZsAm+0Q2aTDQDmqG+rXfw6kNFNwQ==", "647-798-0157", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1057.jpg", "Sigmund63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8405 Grover Dale, North Terrenceport, Malaysia", "c1fb6242-e5ac-4561-8111-be5be1f70ab9", new DateTime(2024, 4, 4, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(5867), "Harley86@yahoo.com", "Harley", "Collier", "HARLEY86@YAHOO.COM", "HARLEY_COLLIER", "AQAAAAIAAYagAAAAEO9ehHXR6CPx0sZ5OLnOPO3YOPhAa4OV9VJGIn/X1FIVjiwpJ8whbEln0KI/AAM+oQ==", "878-290-7570", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/634.jpg", "Harley_Collier" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "63604 Karl Branch, Ziemefort, New Zealand", "3a5c6c81-2524-4f9a-91e1-d01a3957af0c", new DateTime(2024, 6, 6, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(6097), "Alisa_Powlowski@gmail.com", "Alisa", "Powlowski", "ALISA_POWLOWSKI@GMAIL.COM", "ALISA.POWLOWSKI72", "AQAAAAIAAYagAAAAEMhLLbceJ37ECpNtCSmsvwf4g7T4J9MRQ3lZSMb5KCY63sEhOVzaoBAzJj2EFNoGwg==", "751-064-2655", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/982.jpg", "Alisa.Powlowski72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2931 Weber Flat, New Otha, Tokelau", "d770ae5c-db10-475d-96fb-47d4ed20be6b", new DateTime(2024, 7, 11, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(6319), "Emmett_Bartoletti70@yahoo.com", "Emmett", "Bartoletti", "EMMETT_BARTOLETTI70@YAHOO.COM", "EMMETT.BARTOLETTI91", "AQAAAAIAAYagAAAAELyplYQvN1IU5d1KBgFmhMYiaZemk5IuHXCDEcQ8IuzTCJh2U70U9a6e5ug7VcZ3cg==", "861-996-2495", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/362.jpg", "Emmett.Bartoletti91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8946 Charlie Wall, Port Justynton, Iran", "aa372bf2-1d14-4e3e-9cc4-75c8f5e0a984", new DateTime(2025, 2, 2, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(6586), "Braeden60@hotmail.com", "Braeden", "Lynch", "BRAEDEN60@HOTMAIL.COM", "BRAEDEN.LYNCH51", "AQAAAAIAAYagAAAAEKy7HztzqUNR/DVYsgeAGCvw2ZSENVnHr5PK3B1s5Xz2dgu/98hd2/KzOvL5+PL2sA==", "513-271-4971", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/977.jpg", "Braeden.Lynch51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0133 Altenwerth Rest, North Antonette, Moldova", "808c8d8f-74b4-4571-969a-6cbecfba769c", new DateTime(2024, 8, 16, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(6788), "Marcelle66@hotmail.com", "Marcelle", "Wiza", "MARCELLE66@HOTMAIL.COM", "MARCELLE53", "AQAAAAIAAYagAAAAENNK+JwmJrU8S9JjhREDuM7zGVK6n0cPbWT0NnWxMTX5jn0rlSZEG6AKxTzuk4QYHQ==", "616-278-4206", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/746.jpg", "Marcelle53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "64534 Hodkiewicz Track, North Alexandroborough, Iceland", "f895c597-3e2e-47a4-8943-f6cc10e0569d", new DateTime(2024, 8, 13, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(7016), "Foster85@hotmail.com", "Foster", "West", "FOSTER85@HOTMAIL.COM", "FOSTER_WEST", "AQAAAAIAAYagAAAAEG6e3y3r1KrwHG6Vrmat9G6vbbDF6/Bw9G4MvL3Xnpfg12zg9623MKjRymAremtfVQ==", "665-643-6722", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/501.jpg", "Foster_West" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "832 Melisa Locks, South Joany, Jordan", "5aa42781-f5eb-47a4-9c19-9a96ef72eac9", new DateTime(2024, 9, 17, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(7226), "Hector41@gmail.com", "Hector", "O'Connell", "HECTOR41@GMAIL.COM", "HECTOR0", "AQAAAAIAAYagAAAAELRCiUNIs/bhSe+oQNovE6LW/ZfWTtKjfrtKU3cdJA6egkS1ivP7feE3gFVO4hgP0A==", "555-561-6391", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/33.jpg", "Hector0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6467 Roberto Plains, South Karlie, Mexico", "b73eeb88-5c0c-416e-a9d4-45d008e54dcd", new DateTime(2024, 7, 20, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(3149), "Presley97@hotmail.com", "Presley", "O'Hara", "PRESLEY97@HOTMAIL.COM", "PRESLEY.OHARA", "AQAAAAIAAYagAAAAEOBgt/RBcnxY/D1pcWDPany3tYmeigbl2BgoRBFUYfEW7rESeVYnbXWYMzLSdGoJBg==", "938-911-4032", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/616.jpg", "Presley.OHara" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "66121 Hayes Loaf, Lilianachester, Ukraine", "531e9d6c-8256-461b-9020-c9a91cf60203", new DateTime(2024, 6, 4, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(3489), "Cassandre.Quitzon@hotmail.com", "Cassandre", "Quitzon", "CASSANDRE.QUITZON@HOTMAIL.COM", "CASSANDRE.QUITZON52", "AQAAAAIAAYagAAAAEEK1dJSeCdPFH4mvFwzgximVDPYSQhNA/7zEfjpZEIp0/BMKreyvBp1RXvycIaozsA==", "791-713-4215", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/877.jpg", "Cassandre.Quitzon52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "15327 Tracy Forges, Pourosberg, Paraguay", "387766c0-d49d-49ec-b863-04d6aba797e7", new DateTime(2024, 12, 13, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(3745), "Reina_Cummings87@yahoo.com", "Reina", "Cummings", "REINA_CUMMINGS87@YAHOO.COM", "REINA7", "AQAAAAIAAYagAAAAEOUxYYHDhiW2qL2afggfC7X1hNmHgYpC5H2rRaGaqwptOT2lHGAtrj5gjxBJaySuhQ==", "239-500-1244", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/567.jpg", "Reina7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0049 Howell Valleys, Rodriguezborough, Lithuania", "412f7203-8690-48e2-a6d2-81d0ced903d2", new DateTime(2024, 9, 12, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(4002), "Wendy.Erdman@yahoo.com", "Wendy", "Erdman", "WENDY.ERDMAN@YAHOO.COM", "WENDY.ERDMAN8", "AQAAAAIAAYagAAAAEN+c/L2kmi9PL3Pxd+/B7JeBfDlJCNn/igUQTZF9KsAjp885lCDR2/zP5wr1dUrYlA==", "479-209-4754", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/825.jpg", "Wendy.Erdman8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "656 Hartmann Knoll, Brendenview, Slovakia (Slovak Republic)", "9a1dbb4e-99bd-422c-bbcd-24f46888b72a", new DateTime(2024, 11, 14, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(4214), "Parker76@yahoo.com", "Parker", "Dibbert", "PARKER76@YAHOO.COM", "PARKER67", "AQAAAAIAAYagAAAAEKDosb+av6v42l2nv0XS37mk7F/QfPiE6oahKP0jAgsxiI8OPeMiGi3mJrD85rQ6TQ==", "513-204-7742", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/216.jpg", "Parker67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "42533 Madilyn Prairie, Pierceberg, Liechtenstein", "d11db386-ff98-4b05-aaa8-a924c45f4331", new DateTime(2024, 6, 2, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(4443), "Lucius_Koss@gmail.com", "Lucius", "Koss", "LUCIUS_KOSS@GMAIL.COM", "LUCIUS_KOSS13", "AQAAAAIAAYagAAAAEPoKiVOVutrNdjbOhbldzZToZ4uHY4CKoSezBPW7gvutK/nF2D058E1Ng+bbJ17OgQ==", "965-451-5096", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/549.jpg", "Lucius_Koss13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "31309 Blanda Village, West Clarabelle, Angola", "ebc3607d-d2cc-4406-acd0-43bee620884a", new DateTime(2024, 7, 25, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(4696), "Cordelia56@gmail.com", "Cordelia", "Emard", "CORDELIA56@GMAIL.COM", "CORDELIA82", "AQAAAAIAAYagAAAAEMlUkHMY5HVnRQZZY6ExRe+QJvzshzwO/d1D5zjqP6z44MZGUHwVDhgKQivA3iX7Fw==", "524-127-2704", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/770.jpg", "Cordelia82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "53961 Norma Unions, Kunzemouth, Cambodia", "2db6008c-b984-4b2a-a5bf-c79236294ad1", new DateTime(2025, 1, 13, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(4941), "Wilma_Gaylord51@hotmail.com", "Wilma", "Gaylord", "WILMA_GAYLORD51@HOTMAIL.COM", "WILMA22", "AQAAAAIAAYagAAAAEEIn57cxje6Bfz/mq7mwJbIDozbDs2h+rc8o1kRF7GyylAtY/8uuv1Rk9twG48vSow==", "196-958-7518", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/566.jpg", "Wilma22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "36696 Alessia Lock, Nannieside, Slovakia (Slovak Republic)", "8a905185-a306-4a91-90d7-4e02ddac9c4e", new DateTime(2024, 5, 29, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(5182), "Margarette_Cummerata57@gmail.com", "Margarette", "Cummerata", "MARGARETTE_CUMMERATA57@GMAIL.COM", "MARGARETTE.CUMMERATA", "AQAAAAIAAYagAAAAEBeaC8Ng40Hj31j3M8ROVQvKz/M/CEJpJcumgRp0/Qu0X0h7hlxzc1V6ooBb88R6RA==", "047-753-6261", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/60.jpg", "Margarette.Cummerata" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "873 Francisca Inlet, New Jeanne, Cocos (Keeling) Islands", "456658a2-dbac-466a-b320-bbed253a99c5", new DateTime(2024, 10, 17, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(5420), "Jannie47@gmail.com", "Jannie", "Bogan", "JANNIE47@GMAIL.COM", "JANNIE.BOGAN", "AQAAAAIAAYagAAAAEOuUIaWwKwuMDV5pWPy+L7oRVDx6/XkIeVi2J5MDzS8yGmMm4Wxl4XrN2Q+lSt132Q==", "452-171-3976", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/618.jpg", "Jannie.Bogan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "69890 Jailyn Skyway, New Quinnside, French Polynesia", "7197dfda-c049-4551-9f30-bae931b874fe", new DateTime(2024, 9, 8, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(5632), "Larry_Torphy@yahoo.com", "Larry", "Torphy", "LARRY_TORPHY@YAHOO.COM", "LARRY11", "AQAAAAIAAYagAAAAEFSBW0tuDrVYBH/n+QEV9Qm9ItjDp7aN6urPVGTVnHFehsI/UMJcSh0eTc3kpSjmBA==", "638-863-0734", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/222.jpg", "Larry11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8337 Troy Forge, West Chaz, Falkland Islands (Malvinas)", "8572ac91-434c-4bb7-90ea-b929adda0651", new DateTime(2024, 3, 1, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(5861), "Toni_Barton@yahoo.com", "Toni", "Barton", "TONI_BARTON@YAHOO.COM", "TONI.BARTON", "AQAAAAIAAYagAAAAEJ6yqT0l7Rn4EMyqKLDwfsKVWJ7LYML0xFsGSraYbil0PZ7FZm884v0jDeC+SYUjhA==", "792-916-9722", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/601.jpg", "Toni.Barton" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6011 Klocko Square, Port Edgar, Guinea-Bissau", "64474711-57a6-4281-a24a-8ab9c91cf04b", new DateTime(2024, 10, 17, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(6078), "Marilyne_Kunde41@yahoo.com", "Marilyne", "Kunde", "MARILYNE_KUNDE41@YAHOO.COM", "MARILYNE.KUNDE", "AQAAAAIAAYagAAAAEO/jVqEsHVztp7JJxgeQ6WByfgZcApiE9HK67empiE2HIccLIUkqabn+6M6L+EOCLg==", "888-402-2157", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1189.jpg", "Marilyne.Kunde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "01208 Brittany Point, Lynchview, Saint Kitts and Nevis", "69836ab5-cb34-4681-8b39-63a80aefa97d", new DateTime(2024, 3, 24, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(6328), "Marjory_McLaughlin24@yahoo.com", "Marjory", "McLaughlin", "MARJORY_MCLAUGHLIN24@YAHOO.COM", "MARJORY_MCLAUGHLIN58", "AQAAAAIAAYagAAAAEJJ7pfsurZjmEs2aRpCHckygaMgng3pypZi4SFBg+FIZ8arjPZTKJXCb30IzuBO4vg==", "396-502-4549", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/979.jpg", "Marjory_McLaughlin58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "61895 Hahn Coves, South Estamouth, Austria", "8c3c397d-d04a-4e8f-ab54-2802d2258d23", new DateTime(2024, 9, 19, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(6586), "Kristian_Stiedemann90@hotmail.com", "Kristian", "Stiedemann", "KRISTIAN_STIEDEMANN90@HOTMAIL.COM", "KRISTIAN62", "AQAAAAIAAYagAAAAEOcssQRESng9OkndC5NttskP8lXXEoFOo4jWXGyWosq6jBDwzfiolW+TjvoNY9GCzg==", "424-163-1473", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/644.jpg", "Kristian62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "439 Purdy Throughway, Lake Stonemouth, Indonesia", "fcd886c1-043c-432e-9798-e86310b1d8bc", new DateTime(2024, 10, 31, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(6812), "Lauretta_Price42@gmail.com", "Lauretta", "Price", "LAURETTA_PRICE42@GMAIL.COM", "LAURETTA75", "AQAAAAIAAYagAAAAEMMs7zvSqJOkaYcfs4CBVaqxSLKCMgNDscoimvN3M5Ts8YjpYzci/mgju/S/gt5Lnw==", "753-892-5754", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1051.jpg", "Lauretta75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "30982 Joel Oval, Dickiport, Andorra", "23f38c6d-cee3-43bf-9905-3ec5cd58576e", new DateTime(2024, 10, 20, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(7032), "Oma71@hotmail.com", "Oma", "Howe", "OMA71@HOTMAIL.COM", "OMA87", "AQAAAAIAAYagAAAAEEi2m86WRhhtmKRvyiDpBePKbkqTICqUn9DqpIrn5AeyBHlGlQym8B7+ARhwYj+rWA==", "395-062-0232", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1035.jpg", "Oma87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "11003 Altenwerth Hills, Johnsontown, Niger", "5827f641-ac33-4bde-ab62-f136787ee828", new DateTime(2024, 7, 20, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(7248), "Angie_Rau6@gmail.com", "Angie", "Rau", "ANGIE_RAU6@GMAIL.COM", "ANGIE_RAU9", "AQAAAAIAAYagAAAAEI70FeE8j5VdnxAbu2ERnrfore42GbuBuvx4eo6lKPm4V1ngdnuM02LmDosm9IpWPg==", "307-735-7208", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/870.jpg", "Angie_Rau9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7398 Jakob Flat, Schmelerburgh, Aruba", "456c6e46-77f9-4f54-bffc-635c544d1068", new DateTime(2024, 12, 23, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(7524), "Noah54@hotmail.com", "Noah", "Lubowitz", "NOAH54@HOTMAIL.COM", "NOAH.LUBOWITZ0", "AQAAAAIAAYagAAAAEHSjB/r0Rfn1Gv27JRzO2sV3YqGAEVEWhYAayl5hZZA65uDcMtyfA6m+nmTuOQulXQ==", "034-821-1405", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1194.jpg", "Noah.Lubowitz0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "913 Toy Trace, Kutchville, French Polynesia", "25dfd645-2359-4e3e-be94-271a4fd02bc6", new DateTime(2024, 3, 30, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(7736), "Sadye_Mante44@gmail.com", "Sadye", "Mante", "SADYE_MANTE44@GMAIL.COM", "SADYE10", "AQAAAAIAAYagAAAAEB8qWgNwxA7rEpHMurnbqLLSjpioxLON0BYSehgtQiI5y6uFIog5ctlPnXZ+6bI6yg==", "179-675-2921", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/110.jpg", "Sadye10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "64490 Luella Street, Monahanstad, Honduras", "05c7494d-5a30-4dfd-8e5b-cdf470d34b88", new DateTime(2024, 8, 21, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(7961), "Theresa.Ernser41@gmail.com", "Theresa", "Ernser", "THERESA.ERNSER41@GMAIL.COM", "THERESA_ERNSER44", "AQAAAAIAAYagAAAAELYwmKDBVHtTsWUPHVXwacU3dVvlG8BdjPm90s9Q5Vnus6dEMEA5ZXXTo4R2rTIUpQ==", "671-673-2394", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/248.jpg", "Theresa_Ernser44" });
        }
    }
}
