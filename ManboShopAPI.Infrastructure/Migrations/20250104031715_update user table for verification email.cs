using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class updateusertableforverificationemail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VerificationCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VerificationCodeExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "08281 Durgan Island, West Catherineton, Bulgaria", "4bac2a0b-cc9a-4e0a-aa76-b89aa5dc8df1", new DateTime(2024, 10, 31, 3, 17, 11, 988, DateTimeKind.Utc).AddTicks(5524), "Abigail_Gerlach13@hotmail.com", "Abigail", "Gerlach", "ABIGAIL_GERLACH13@HOTMAIL.COM", "ABIGAIL.GERLACH", "AQAAAAIAAYagAAAAEJjGjBO4UapTKk9r71U+eOv/4lMYqDwTlye3pZUd0dLzFbVFSb6hupMHINt6kTULJA==", "267-592-2346", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/738.jpg", "Abigail.Gerlach", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "6729 Oswald Villages, East Terrill, Niger", "66cc5aae-5aec-456c-9631-f6a34b9d3b89", new DateTime(2024, 4, 24, 3, 17, 11, 989, DateTimeKind.Utc).AddTicks(9754), "Reggie6@yahoo.com", "Reggie", "Block", "REGGIE6@YAHOO.COM", "REGGIE.BLOCK49", "AQAAAAIAAYagAAAAECUxszt1MRui12jo0474lKbyLco9w0PtIbST3ucqXOFIP68o+BEDuk/HSENJeBjpWA==", "507-883-2443", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/717.jpg", "Reggie.Block49", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "161 Quinten Court, New Hesterfurt, Kazakhstan", "62d24228-cd98-4c09-99d9-295db850b985", new DateTime(2024, 9, 10, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(139), "Tyrell_Keeling@hotmail.com", "Tyrell", "Keeling", "TYRELL_KEELING@HOTMAIL.COM", "TYRELL16", "AQAAAAIAAYagAAAAEF1hTvXITRO0rtsMvlsTARMn+B+58jxmymoSsxBWYqnDlfP82gMxsAKpZU7xzmAimA==", "868-254-2239", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/487.jpg", "Tyrell16", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "284 Hintz Mission, Lake Jefferey, Palestinian Territory", "82849778-3df5-4d99-991b-aec65b74428c", new DateTime(2024, 7, 16, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(380), "Shyann.Pfeffer77@hotmail.com", "Shyann", "Pfeffer", "SHYANN.PFEFFER77@HOTMAIL.COM", "SHYANN_PFEFFER", "AQAAAAIAAYagAAAAEMLCjg/Pq8vYi/RQjBJS+O6T/Ux9BC3S0OoXNQgxatKYwo1bvNNnM0dw9AqLX3b4YQ==", "959-827-4190", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/942.jpg", "Shyann_Pfeffer", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "026 Eunice Flat, Danialton, Poland", "2162e5f4-1439-4cf5-83c0-54cedc0cee34", new DateTime(2024, 7, 23, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(608), "Vada98@hotmail.com", "Vada", "Johnson", "VADA98@HOTMAIL.COM", "VADA95", "AQAAAAIAAYagAAAAEBqZV1X8Co7STtLFypDAdR6fu+E3Ras241VhQZJBMRzOYFBwpMuiZQl7nGwB1q9aYg==", "266-514-4137", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1179.jpg", "Vada95", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "323 Winston Row, Estaport, Samoa", "9000e48e-ad8b-406a-9e01-abbb9479adad", new DateTime(2024, 8, 1, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(975), "Magdalena81@hotmail.com", "Magdalena", "Roberts", "MAGDALENA81@HOTMAIL.COM", "MAGDALENA.ROBERTS26", "AQAAAAIAAYagAAAAEC9cPnBl0B5K1bpNZhyzabxRz39slJHqFrAKuLqS+msxs+Pt29eKnhSlIKqYZlZ0Gg==", "059-068-6590", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/563.jpg", "Magdalena.Roberts26", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "8946 Feil Ramp, Lake Toneyshire, Mali", "66ae86d7-faaf-43ff-8495-7acb4423b1f8", new DateTime(2024, 9, 27, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(1274), "Porter_Gusikowski83@hotmail.com", "Porter", "Gusikowski", "PORTER_GUSIKOWSKI83@HOTMAIL.COM", "PORTER.GUSIKOWSKI89", "AQAAAAIAAYagAAAAEJvSFvKy520YLSDykRj/vjVw3oHqfCLokc+WJT6ZhsXlJw26lXck+6rTGFebLYCnbw==", "946-803-5500", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/47.jpg", "Porter.Gusikowski89", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "886 Glover Squares, West Lenora, Bermuda", "37d6f0a7-2483-4185-999c-aa8f9414ee5e", new DateTime(2024, 9, 30, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(1505), "Nicholas.Friesen1@gmail.com", "Nicholas", "Friesen", "NICHOLAS.FRIESEN1@GMAIL.COM", "NICHOLAS.FRIESEN50", "AQAAAAIAAYagAAAAEI1zKobT4nSCNKg4XkvBOmYiJSyJV+UXxi9v+gNOI/BJ9qipu6jipCVc0VHkFlsyAQ==", "197-386-8937", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1189.jpg", "Nicholas.Friesen50", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "61406 Diana Prairie, Boehmstad, Gibraltar", "c257e733-6d38-4c29-a39a-2061b96a940f", new DateTime(2024, 9, 14, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(1786), "Kitty22@yahoo.com", "Kitty", "Oberbrunner", "KITTY22@YAHOO.COM", "KITTY58", "AQAAAAIAAYagAAAAEDZh+oroVfA6nM5LEgw1Z3wkPFIhslJB691n14+F5Y7bYPAFRlvMTLDBZICmSypb4g==", "454-138-3940", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/647.jpg", "Kitty58", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "4975 Beatty Glens, Jayneborough, Cambodia", "6b6b2f8a-25fe-4499-82af-15d0e41bce4f", new DateTime(2024, 6, 8, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(2005), "Trenton64@hotmail.com", "Trenton", "Kutch", "TRENTON64@HOTMAIL.COM", "TRENTON3", "AQAAAAIAAYagAAAAEDi8g8fn4jTzP0t/TNCk8qCmz+udUMBbAP5lz25l/pVYYIZS6yj+DCAmBK9d/fD7FA==", "203-801-5430", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/977.jpg", "Trenton3", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "91308 Crooks Rest, Port Ayanaside, Lithuania", "97093595-dab8-44d5-8de1-3c9d87131660", new DateTime(2024, 4, 5, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(2249), "Brisa.Sanford84@hotmail.com", "Brisa", "Sanford", "BRISA.SANFORD84@HOTMAIL.COM", "BRISA_SANFORD", "AQAAAAIAAYagAAAAEHLrYDYl+vzHIsfBKfyl32Ly5xD9j3KfcSVDv9SLdZ5biGMzOqMgP0nNejj6GHn36w==", "122-808-2575", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/143.jpg", "Brisa_Sanford", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "1463 Baumbach Pines, Tyrelburgh, Brazil", "22b37c5d-5d98-490a-87a8-cc8185f26f60", new DateTime(2024, 12, 8, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(2466), "Arjun_Douglas@yahoo.com", "Arjun", "Douglas", "ARJUN_DOUGLAS@YAHOO.COM", "ARJUN_DOUGLAS14", "AQAAAAIAAYagAAAAEGogfVJsRuCi7ZTM9lf+ilSKqB9bfrdj3owQSmOcptM4XrKbNNy/gaKhvKnlpvUJeg==", "062-183-3432", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/543.jpg", "Arjun_Douglas14", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "5592 Timmy Pine, Brendenburgh, Senegal", "a31f1f92-9ea9-4164-ae93-cffd279dc0df", new DateTime(2024, 11, 26, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(2720), "Jeanne77@yahoo.com", "Jeanne", "Connelly", "JEANNE77@YAHOO.COM", "JEANNE.CONNELLY77", "AQAAAAIAAYagAAAAEBO6w5WLRXKFtzxufcIW4iUtbAca1BMmwkM2g320SlpibMjqs7KNvZ3m7u+DTVYsGQ==", "502-372-6674", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/87.jpg", "Jeanne.Connelly77", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "04173 Kelli Spring, Stromantown, Guyana", "ea8b98f6-dcea-47e8-bb66-222c1c8050c3", new DateTime(2024, 9, 2, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(2939), "Garnett.Kunze@yahoo.com", "Garnett", "Kunze", "GARNETT.KUNZE@YAHOO.COM", "GARNETT.KUNZE90", "AQAAAAIAAYagAAAAELENG85ISwawpoSlP1Fe2R6RsfobwxmndiEMBxS3QBJztDY+dtEpnTNWsLAIsloKGg==", "685-495-8824", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/284.jpg", "Garnett.Kunze90", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "8074 Albina Brooks, Bertrandton, United Arab Emirates", "4675f64e-43ea-4270-afc4-0088e38f2541", new DateTime(2024, 1, 16, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(3182), "Kristofer_Metz63@hotmail.com", "Kristofer", "Metz", "KRISTOFER_METZ63@HOTMAIL.COM", "KRISTOFER.METZ", "AQAAAAIAAYagAAAAEM3mUUHyPOAXPdHNAHtMiNthIPbzmRauAd7dlM6HV92Ab4LN/Oy0krbHhQnjr63C8A==", "918-458-1067", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/915.jpg", "Kristofer.Metz", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "8432 Beahan Walks, New Lucyland, Kuwait", "6307da6a-6cfe-411c-abd5-c3b931ed0b3f", new DateTime(2024, 12, 17, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(3412), "Margaret33@hotmail.com", "Margaret", "Zulauf", "MARGARET33@HOTMAIL.COM", "MARGARET_ZULAUF47", "AQAAAAIAAYagAAAAEADET595vf+fZC3Rywn3qlQDcdiVUk3nxWQhDNWxzq8GnhyFYUNjUkczw3dofdf80g==", "697-323-6676", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/784.jpg", "Margaret_Zulauf47", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "70168 Waylon Course, Reichertside, Burundi", "4f3feaf2-1828-43c7-80ff-fdf970dc1882", new DateTime(2024, 6, 10, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(3636), "Aida63@yahoo.com", "Aida", "Wisoky", "AIDA63@YAHOO.COM", "AIDA16", "AQAAAAIAAYagAAAAEERk7K83i8uFoaPT0ljMJUI4DEbfsnuzZLx4JLDQ6wIfC5PG+VpikuiJpHihHhln+g==", "651-745-3442", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/455.jpg", "Aida16", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "17072 Rylee Inlet, Juanitafort, Bhutan", "588e535b-9e6c-4d32-99b7-adc99abefb97", new DateTime(2024, 5, 25, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(3850), "Alf77@yahoo.com", "Alf", "Friesen", "ALF77@YAHOO.COM", "ALF_FRIESEN17", "AQAAAAIAAYagAAAAEOC0NbMIyfZ1ILEqwkYuSGk7XOy0f4a5qNVFqq1gXNMQdaF/qnBm/Fx9qqWuNIjdKg==", "114-698-9008", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/905.jpg", "Alf_Friesen17", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "686 Houston Hill, Lake Randall, South Georgia and the South Sandwich Islands", "4a8ff03d-1460-4e9c-ae7a-65e54bfac5b8", new DateTime(2024, 1, 16, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(4089), "Emery_Graham@gmail.com", "Emery", "Graham", "EMERY_GRAHAM@GMAIL.COM", "EMERY_GRAHAM12", "AQAAAAIAAYagAAAAENBSQGuSu0ZQhLa6YMeMfjJcZ6HjZ3JDrernf/a1xMjv1SI+PIsMepgg9nkUSUSdaQ==", "747-994-1272", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/983.jpg", "Emery_Graham12", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "83225 Daniella Plains, Colestad, Togo", "78af8ed7-8ebc-495e-ae55-6350a62316f6", new DateTime(2024, 3, 18, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(4308), "Charles_Weimann83@hotmail.com", "Charles", "Weimann", "CHARLES_WEIMANN83@HOTMAIL.COM", "CHARLES.WEIMANN", "AQAAAAIAAYagAAAAELzTC6/47PBYBkTwlmourLPNST1D16pRGWhyR3w2UuUBgUyJCaqy9cmi+8GAu4AnsQ==", "854-325-0356", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/816.jpg", "Charles.Weimann", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "9462 Rosenbaum Lakes, Treverhaven, Argentina", "51109907-721f-4dd5-a013-e0aedf53fb11", new DateTime(2024, 12, 27, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(4548), "Gayle28@hotmail.com", "Gayle", "Maggio", "GAYLE28@HOTMAIL.COM", "GAYLE62", "AQAAAAIAAYagAAAAEJ4eUAnZxrxW2HiBJ+mSONc+eVQ3LHF+5h0DxYuZjnn4htCRJCYlWQ11/RWFbua8BQ==", "580-641-1673", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1054.jpg", "Gayle62", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "5198 Kunde Parks, Lake Raphael, Portugal", "2bce2df7-5d5e-470b-99a0-1f5c0e4e7440", new DateTime(2024, 7, 3, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(4781), "Margaret.Bogisich@hotmail.com", "Margaret", "Bogisich", "MARGARET.BOGISICH@HOTMAIL.COM", "MARGARET.BOGISICH", "AQAAAAIAAYagAAAAEBOU2maNua1Fo8zqJFL9XdUfitfBzI0RPTufJIixkN1QviYTDuJvJBmcyqBvCTYHKA==", "647-006-2011", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/165.jpg", "Margaret.Bogisich", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "3368 Austyn Village, North Hymanland, Ghana", "7b5fe783-33db-4e35-b11e-9c187b5cfa32", new DateTime(2024, 6, 10, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(5029), "Anna_Hettinger@hotmail.com", "Anna", "Hettinger", "ANNA_HETTINGER@HOTMAIL.COM", "ANNA3", "AQAAAAIAAYagAAAAEM3DEJHVgEFecd3+X+07PRXXCDoPjGWn3QROfKYkD2fn/+9GQ8J3LOu2oarAjjSeBA==", "637-993-7232", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1022.jpg", "Anna3", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "552 Della Estate, Port Rosaliaville, Botswana", "2d7dd6c8-b37f-4ec9-815e-5d4eddd8a7e4", new DateTime(2024, 6, 6, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(5239), "Rebecca_Jones@gmail.com", "Rebecca", "Jones", "REBECCA_JONES@GMAIL.COM", "REBECCA36", "AQAAAAIAAYagAAAAEHqiByK3RPxa1e4Y5RsI7b2o9CPQTE9UkAkpXWQGWPx+kFP3m8O25vgX3jBJkHOC8w==", "846-506-9279", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/658.jpg", "Rebecca36", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "2638 Doyle Track, Franeckiport, Democratic People's Republic of Korea", "25f0c4d0-ebd0-458a-8b28-3b5da5824ae7", new DateTime(2025, 1, 1, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(5469), "Chandler_Paucek89@hotmail.com", "Chandler", "Paucek", "CHANDLER_PAUCEK89@HOTMAIL.COM", "CHANDLER93", "AQAAAAIAAYagAAAAEKEN7tO7tdt1qAH/qeAg3FMz4cdtWpmVB+6aLI+xwCj6KdI/Zo8ly8T47sEn6ESt2w==", "983-932-7212", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/134.jpg", "Chandler93", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "1013 Doyle Rue, Port Caraside, Belize", "3fbc1120-5c59-4d3d-8fb0-89ca982ed628", new DateTime(2024, 5, 31, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(5763), "Delaney57@hotmail.com", "Delaney", "Emmerich", "DELANEY57@HOTMAIL.COM", "DELANEY_EMMERICH", "AQAAAAIAAYagAAAAEJWqaBaagfkvo+/vGiM0Vgm2R/NlnS6wRBOIx/zfUkBREvxEEEPhXaJ40H9OZBF3qQ==", "083-816-3659", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/134.jpg", "Delaney_Emmerich", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "712 Bednar Ridges, Cyrilside, Iraq", "7c8b4b3b-7f7d-44c6-b25d-fa8ee67010d3", new DateTime(2024, 8, 19, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(5978), "Destiney_Heller46@yahoo.com", "Destiney", "Heller", "DESTINEY_HELLER46@YAHOO.COM", "DESTINEY.HELLER", "AQAAAAIAAYagAAAAEBeN20ijBEqdjZh6wEEMFojcGFbbItlImWhby48fgK7OyJlHvJ7c5K03gf2GMrZMVA==", "586-415-2331", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1236.jpg", "Destiney.Heller", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "81583 Willy Ways, Briellefurt, Belize", "cd936abf-cb2b-440d-bf95-c4b0ae9b4b5f", new DateTime(2024, 9, 11, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(6216), "Sydnee48@hotmail.com", "Sydnee", "Wilderman", "SYDNEE48@HOTMAIL.COM", "SYDNEE_WILDERMAN", "AQAAAAIAAYagAAAAEF547fseIahRlDV08uU1HsFWijH7kC0A3PrdKGOHCp3aaXhZf+Vlgpl0iyDUh5smXw==", "957-674-9004", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1104.jpg", "Sydnee_Wilderman", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "42106 Laisha Unions, Skilesburgh, Liberia", "c4777414-225b-4254-b160-ffb252b7fd00", new DateTime(2024, 2, 18, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(6414), "Kailey36@gmail.com", "Kailey", "Jacobi", "KAILEY36@GMAIL.COM", "KAILEY64", "AQAAAAIAAYagAAAAEFEhpTt3KJ7oc6TJF1JlmUjd+MkGPLuuCMqGLxBbVtuaIbzxlGQ2XrjgBJ4XIyaJPw==", "773-648-1203", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1196.jpg", "Kailey64", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "70486 Fritsch Meadows, North Nicklaus, Seychelles", "760fad5d-d44f-46dd-b933-d03175b55e81", new DateTime(2024, 3, 4, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(6646), "Jairo.Konopelski@gmail.com", "Jairo", "Konopelski", "JAIRO.KONOPELSKI@GMAIL.COM", "JAIRO13", "AQAAAAIAAYagAAAAEE9vAPc2zWgqkfbn53aqRBbnOrIOFqmY9guv2nkBBxpJT/WpzQWu4yfkANEygrExGA==", "030-295-2359", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/179.jpg", "Jairo13", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "3352 Foster Point, Lake Frank, Ecuador", "6c0e2cb2-bc9e-4ae2-ba3a-5c9e01fe5ce5", new DateTime(2024, 3, 1, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(6856), "Jeanne_Feil64@gmail.com", "Jeanne", "Feil", "JEANNE_FEIL64@GMAIL.COM", "JEANNE.FEIL", "AQAAAAIAAYagAAAAEMDSccPiFTdyl8oDp6DLQg3y6Aywbwkxz6UY5BS77Cqs641FOwZAu/NFW7iuQAUsiA==", "480-426-0322", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1134.jpg", "Jeanne.Feil", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "336 Fred Trail, South Trishaberg, Bahamas", "57c47f9a-852b-4270-ad51-eef1763f6e56", new DateTime(2024, 3, 10, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(7108), "Alene43@gmail.com", "Alene", "Osinski", "ALENE43@GMAIL.COM", "ALENE7", "AQAAAAIAAYagAAAAECR+oTL9V0lUS/tEX+H+AG+LbmV+QfnN/BaZ6bM/citvMogIcL71RtbB0i/8cVOAmw==", "366-761-8657", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/566.jpg", "Alene7", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "24188 McGlynn Center, Bodetown, French Guiana", "6335fc71-451c-4d64-b494-e1f92dac82dc", new DateTime(2024, 2, 13, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(7309), "Amely.Kreiger@hotmail.com", "Amely", "Kreiger", "AMELY.KREIGER@HOTMAIL.COM", "AMELY.KREIGER93", "AQAAAAIAAYagAAAAEOuJ9BTLMIoT0STLT1R48FXWn4eRdKDrhQniUQFv9pJklenOIO7hYeZvj0s99A7fyw==", "344-482-2072", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/850.jpg", "Amely.Kreiger93", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "95086 Sipes Valleys, Americostad, Fiji", "cbc13b0d-dce1-41a6-b52c-91d475c91ef9", new DateTime(2024, 12, 28, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(7543), "Gloria76@hotmail.com", "Gloria", "Hackett", "GLORIA76@HOTMAIL.COM", "GLORIA.HACKETT", "AQAAAAIAAYagAAAAEAl2StWHViHBTq1Yi7z/eEmf8ZQBum1UMOc89Ly4dwvAIZW9OrJM7N3GuUkOzatn9w==", "563-473-6355", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/190.jpg", "Gloria.Hackett", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "1037 Donnell Fall, North Maiyastad, Chad", "4b80be15-889c-4d0e-b65c-b899609264d6", new DateTime(2024, 5, 2, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(7742), "Warren_Grady@hotmail.com", "Warren", "Grady", "WARREN_GRADY@HOTMAIL.COM", "WARREN_GRADY77", "AQAAAAIAAYagAAAAENvhkWgu3LwtznPE6MgH1DYNBzSAA2No6PNaWbNKyIUTFJg9l5hRRA1tmbtq16ftcA==", "982-532-9219", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/590.jpg", "Warren_Grady77", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "8341 Josefina Garden, Lake Cierra, Zimbabwe", "924d9f61-7458-4776-b4a5-da675ce12917", new DateTime(2024, 7, 14, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(7981), "Roosevelt.Bernhard90@hotmail.com", "Roosevelt", "Bernhard", "ROOSEVELT.BERNHARD90@HOTMAIL.COM", "ROOSEVELT.BERNHARD", "AQAAAAIAAYagAAAAEI4gx3/HssDJO+9md2oQKRFYp1VgJiZMlc+zgxqorYEnVk45PJnVDCDy8K/J72j06w==", "132-442-3711", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/187.jpg", "Roosevelt.Bernhard", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "6938 Gerlach Brook, Haleybury, Lesotho", "04c2da5c-a47b-4747-939a-bf9c9c12df23", new DateTime(2024, 6, 7, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(8198), "Archibald43@gmail.com", "Archibald", "Lesch", "ARCHIBALD43@GMAIL.COM", "ARCHIBALD33", "AQAAAAIAAYagAAAAEBH85aKRcqUNoMguoHbQq9MwDWmGwJ2mtfcxQbqB52G8FhteF5l27VYp+pWZPnbpRA==", "147-718-6521", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/350.jpg", "Archibald33", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "06407 Nova Dale, Jenningsmouth, Honduras", "bab62c00-3eeb-4fa8-ade1-71ca20ea0658", new DateTime(2024, 10, 31, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(8453), "Timmothy_Wiegand37@yahoo.com", "Timmothy", "Wiegand", "TIMMOTHY_WIEGAND37@YAHOO.COM", "TIMMOTHY30", "AQAAAAIAAYagAAAAEOpu1gRVBVcNYPnWJXeU8F4l4rSEH4BUdL5pzeNK1NLWScG5Nl6EH78q+EM1hugLRg==", "976-464-6260", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/482.jpg", "Timmothy30", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "52601 Irving Mall, North Maximoton, Finland", "600ab8c2-d4b4-40bf-aa02-58810f981e8d", new DateTime(2024, 4, 8, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(8661), "Dejah26@hotmail.com", "Dejah", "McDermott", "DEJAH26@HOTMAIL.COM", "DEJAH.MCDERMOTT", "AQAAAAIAAYagAAAAEBMDYUgq1io9StEbZE8O7IYHibRWznRKKVBvV3FTqhrmrLq7dLCcg58p/kmIBRTj5g==", "537-187-8319", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1011.jpg", "Dejah.McDermott", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName", "VerificationCode", "VerificationCodeExpiryTime" },
                values: new object[] { "84065 Missouri Turnpike, Margaritaburgh, Sao Tome and Principe", "3d163945-24d6-4c75-b03d-175daf79027e", new DateTime(2024, 5, 8, 3, 17, 11, 990, DateTimeKind.Utc).AddTicks(8890), "Tiffany4@yahoo.com", "Tiffany", "Conroy", "TIFFANY4@YAHOO.COM", "TIFFANY69", "AQAAAAIAAYagAAAAEKcn0LBxUdrlKexT3Ri++e094Cizf1RikzrDVo31kllGEN03TwFx0ipL2U2l6bmVng==", "680-775-5651", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/214.jpg", "Tiffany69", null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 14, 242, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 4, 3, 17, 11, 675, DateTimeKind.Utc).AddTicks(8343));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VerificationCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VerificationCodeExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "51576 Aurore Union, Elenorville, Jordan", "8948b81c-aba5-4d4d-b2f1-9dca07c4e5bd", new DateTime(2024, 2, 3, 3, 33, 58, 614, DateTimeKind.Utc).AddTicks(7329), "Jerrold_Muller96@gmail.com", "Jerrold", "Muller", "JERROLD_MULLER96@GMAIL.COM", "JERROLD.MULLER", "AQAAAAIAAYagAAAAECHRE5fR1wOgvrMi3roAZ7L/gQ2lc2G5Rcq9rs2E4inXxL5qfnghk6qB6rpT1Lu3EA==", "591-863-8062", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/599.jpg", "Jerrold.Muller" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "621 Kuhic Port, Lake Earl, Taiwan", "fdcfbfa8-07b9-42cd-abd7-5a88898ea6eb", new DateTime(2024, 7, 12, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(2157), "Presley_Buckridge@yahoo.com", "Presley", "Buckridge", "PRESLEY_BUCKRIDGE@YAHOO.COM", "PRESLEY_BUCKRIDGE", "AQAAAAIAAYagAAAAEIKyqG7IIdgtHsD2M3ln1kV+pRws3EnHmAxcDlIlD++sv1dNLrb1H/EzVxPuPUhuwg==", "207-534-4581", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/641.jpg", "Presley_Buckridge" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "800 Ladarius Skyway, Port Jerald, Cameroon", "378503ae-c798-42eb-9c40-01bf2012b92f", new DateTime(2024, 1, 5, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(2651), "Betty0@hotmail.com", "Betty", "Kerluke", "BETTY0@HOTMAIL.COM", "BETTY.KERLUKE3", "AQAAAAIAAYagAAAAEGYWVRsJV2yhcRlURR1njC3HSDUmgUilMHivuexfWG6GYqOGQvEVDHOfYkbw5bJ64g==", "685-234-2400", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/995.jpg", "Betty.Kerluke3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "725 Rutherford Center, South Bella, Palau", "a64f6b13-df18-4af9-bfc6-325f34d4f6bd", new DateTime(2024, 2, 24, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(3070), "Martine41@hotmail.com", "Martine", "Heaney", "MARTINE41@HOTMAIL.COM", "MARTINE87", "AQAAAAIAAYagAAAAEN7sWzS40LqEXeRd5Vo5405UzDj67TX2dXHpFyRdJCbalT+RoyuzckIiAft49TDwrw==", "486-965-6641", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/152.jpg", "Martine87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "50135 Cruickshank Vista, Doylestad, Svalbard & Jan Mayen Islands", "7253e990-5220-40ac-8184-c7f59b6a4ed9", new DateTime(2024, 11, 14, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(3383), "Oleta.Wolf@hotmail.com", "Oleta", "Wolf", "OLETA.WOLF@HOTMAIL.COM", "OLETA34", "AQAAAAIAAYagAAAAEJ+mQkpYsW3hMYYPwd3mhj9Iv47JfUcjs4x/XI4VM8yNt1L//tC1G6GNMSCBNPWtmw==", "759-641-7574", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1209.jpg", "Oleta34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "622 Louisa Burg, Lake Curt, Cape Verde", "bf6eafae-bd34-4cde-a0ed-2fd8759119f5", new DateTime(2024, 2, 25, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(3713), "Sherman9@gmail.com", "Sherman", "Windler", "SHERMAN9@GMAIL.COM", "SHERMAN.WINDLER", "AQAAAAIAAYagAAAAELsFrX0GN9h1gsycQAur11lLmtWk6u3n85VGS/l4S9VVeuT8Uo6vZ3z1xPIyN1naTA==", "542-942-6654", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/861.jpg", "Sherman.Windler" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "330 Daniel Junctions, Hermistonhaven, Saint Barthelemy", "2a84fa18-eeef-4dcf-a854-b4f0ef59250f", new DateTime(2024, 6, 26, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(4038), "Virgie_Parisian60@yahoo.com", "Virgie", "Parisian", "VIRGIE_PARISIAN60@YAHOO.COM", "VIRGIE_PARISIAN8", "AQAAAAIAAYagAAAAEGXpjoFgKBBi8yOI4XyGqMB+hB1PnGsAD77Gkes6zO1o2rm/UDO7UbBShm7j1z2vjQ==", "640-390-4519", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/947.jpg", "Virgie_Parisian8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "505 White Terrace, Bridgetton, United States of America", "051e8795-8517-4a67-86fd-dc1d0f10b157", new DateTime(2024, 2, 15, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(4374), "Alan57@gmail.com", "Alan", "Walter", "ALAN57@GMAIL.COM", "ALAN_WALTER85", "AQAAAAIAAYagAAAAEIv0yC70VQ5wsHA/t2IGl81WJYMjaVfMS/n4Du7j/8M9AyuVTG6R4ndyvAshFbFFXg==", "201-351-4923", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1114.jpg", "Alan_Walter85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7642 Green Villages, Weimannshire, Guadeloupe", "423509b4-18bb-457a-a608-b810a3507d83", new DateTime(2024, 12, 28, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(4689), "Patricia_Leuschke73@hotmail.com", "Patricia", "Leuschke", "PATRICIA_LEUSCHKE73@HOTMAIL.COM", "PATRICIA.LEUSCHKE16", "AQAAAAIAAYagAAAAEINwwvNAf4SatCMgLwsiQwArciU+XGF0DQmSfChQhzJU0HWtIRgLh4p9NV6srbJGyw==", "276-053-3815", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/983.jpg", "Patricia.Leuschke16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5126 Roberts Pike, Jacobiview, Netherlands", "02a73c6a-417e-41ae-aaee-3441548b5eee", new DateTime(2024, 8, 9, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(4989), "Keon95@yahoo.com", "Keon", "Boehm", "KEON95@YAHOO.COM", "KEON_BOEHM64", "AQAAAAIAAYagAAAAEBVZxXnWWJWIHjj41ZAXZc9vqSzvBL+vwQofVZqVbS2yaGjt6AXybBcdTf/xXB95Eg==", "248-220-5365", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/307.jpg", "Keon_Boehm64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "44503 Eldon Prairie, Hellerton, Russian Federation", "7b0626dc-666a-42fb-8f77-86d0238a07d8", new DateTime(2024, 9, 18, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(5267), "Audrey13@hotmail.com", "Audrey", "Stokes", "AUDREY13@HOTMAIL.COM", "AUDREY.STOKES", "AQAAAAIAAYagAAAAEM1lnd9neZq1AUHJJCdt3Op5JVWXnCuFkgFbleMldPsaXZj6ByK3mMB661LdvRf0PQ==", "913-129-7413", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/330.jpg", "Audrey.Stokes" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "88843 Raynor Pass, Robbmouth, Mongolia", "b03f4905-fe36-4fb7-9816-a2fd3e313a14", new DateTime(2024, 11, 13, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(5566), "Lisette.Cassin54@gmail.com", "Lisette", "Cassin", "LISETTE.CASSIN54@GMAIL.COM", "LISETTE6", "AQAAAAIAAYagAAAAENxD3Me/mxXwxcQMlp2dhR++Bvbye4EaO+Zw5dA8w+cKQ0yDw/jyfGAE4dVdHOPIYg==", "821-068-3209", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/130.jpg", "Lisette6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "40541 Harber Fords, Karleytown, United States of America", "6692549a-c631-406a-8c7f-850a21853b6c", new DateTime(2024, 8, 8, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(5840), "Gloria12@yahoo.com", "Gloria", "Hoppe", "GLORIA12@YAHOO.COM", "GLORIA_HOPPE39", "AQAAAAIAAYagAAAAEBBxWZqbDhV7rDLstYzSQXXJoI1JoamBYKLC0utz+x1cMLADpennSVbXFHDCtZDmxg==", "947-317-2322", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1220.jpg", "Gloria_Hoppe39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "299 Shany Gateway, Port Lisaview, Netherlands", "fcebf0d0-2441-4a3f-9c9b-d1e89fc69bac", new DateTime(2024, 2, 7, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(6194), "Billie54@gmail.com", "Billie", "Pfannerstill", "BILLIE54@GMAIL.COM", "BILLIE.PFANNERSTILL", "AQAAAAIAAYagAAAAEAnt7zf7Baqj7Me7eIX9MsUffYnzQt7shmEvztIXC62S1PWAmI60W6DKZgOSttEcGw==", "408-256-5624", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/392.jpg", "Billie.Pfannerstill" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "560 Kendrick Greens, Johnathanburgh, Mali", "42f22551-c3e8-49aa-8911-0ac3e091c796", new DateTime(2024, 5, 21, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(6462), "Zakary.Mills23@yahoo.com", "Zakary", "Mills", "ZAKARY.MILLS23@YAHOO.COM", "ZAKARY_MILLS", "AQAAAAIAAYagAAAAEGX8HqCmGpoWjtj0pIS5N4VLWuh+DFAbUNZHR+iUaYW8R8XeCuMxRke5hMveba0V7A==", "646-312-2087", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/527.jpg", "Zakary_Mills" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2035 Ward Camp, Augustusside, Samoa", "4e68e4f6-8f2b-42bf-b58f-42e30a4e7a29", new DateTime(2024, 1, 13, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(6753), "Lelia79@yahoo.com", "Lelia", "Cormier", "LELIA79@YAHOO.COM", "LELIA89", "AQAAAAIAAYagAAAAEAdTdF/iOVEps/zBcMbWQmKuNvvGwCSOgSoTP1O7ZgBuls76GdoPUw0k84pveRTwjA==", "151-912-9299", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/749.jpg", "Lelia89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7520 Hubert Corners, Madelineside, Romania", "66584805-bbc6-4871-8731-32e3ba932551", new DateTime(2024, 11, 14, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(7001), "Stone.Wiza96@hotmail.com", "Stone", "Wiza", "STONE.WIZA96@HOTMAIL.COM", "STONE16", "AQAAAAIAAYagAAAAEA+qs5uOMAccwU4htyPNWkxfUFQO/Oh7EFC31+RdVz4pMV+d8B3IbakaEQWIdimvxQ==", "911-237-8608", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/773.jpg", "Stone16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2080 Laney Harbors, Ludiestad, Yemen", "92258fcf-dc61-4752-bec6-32786500d4ab", new DateTime(2024, 10, 22, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(7282), "Camren94@hotmail.com", "Camren", "Hickle", "CAMREN94@HOTMAIL.COM", "CAMREN25", "AQAAAAIAAYagAAAAEKWhzsz0GjKg8khN+nKUMsbfPj7OzH/n6kmzsGTbaEkkMJ3hZGER6SiAhUeVYNrMfQ==", "246-841-1937", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/846.jpg", "Camren25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "36965 Clyde Trail, East Budborough, Chad", "e7d7f1ff-95a6-4828-b649-4fd100be37fe", new DateTime(2024, 5, 17, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(7566), "Jett.Stiedemann@gmail.com", "Jett", "Stiedemann", "JETT.STIEDEMANN@GMAIL.COM", "JETT63", "AQAAAAIAAYagAAAAEO0PspX2jFQCEWZZztqaEonlENjrYkyEsaTVKYxkNTs7fGLoBYoQ44LKW/ym1t4SzA==", "935-233-7086", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1146.jpg", "Jett63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5095 Corkery Square, Georgeport, Albania", "a50b08ef-e49a-42fe-9555-22b3589228b0", new DateTime(2024, 12, 23, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(7873), "Ulises.Gibson95@gmail.com", "Ulises", "Gibson", "ULISES.GIBSON95@GMAIL.COM", "ULISES16", "AQAAAAIAAYagAAAAEOKiD8G92CmJfRazQw9s+Cx31fORY+FIOaCuSS0HK+kO8fB9kWw2lSkzozCwqRdRfA==", "799-845-3293", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1141.jpg", "Ulises16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "05704 Nick Forest, Norrisview, Ethiopia", "7f908332-ff9a-40b7-adcd-097af697147b", new DateTime(2024, 5, 25, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(8142), "Lucius58@yahoo.com", "Lucius", "Schoen", "LUCIUS58@YAHOO.COM", "LUCIUS6", "AQAAAAIAAYagAAAAEP/PKFMXRI+mDOhHGfD1vH2wx2vUQ1LQyorf6CX9RrzGek6gutbUHZrbX+xjq/eJAw==", "970-011-2186", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/734.jpg", "Lucius6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "618 Felipe Lock, New Hermantown, Estonia", "b236087c-2369-4459-9592-3187fe890454", new DateTime(2024, 2, 12, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(8432), "Josue_Morar17@yahoo.com", "Josue", "Morar", "JOSUE_MORAR17@YAHOO.COM", "JOSUE48", "AQAAAAIAAYagAAAAEBk5bN5uPiGyH0VmKXaCZJOe8v+FBQ7Ce/6ZK0mm8UXefyVY4Bb1pJ3ufrXw99byFQ==", "671-762-4590", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/374.jpg", "Josue48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "24818 Jo Glens, Lake Lloydfort, Papua New Guinea", "6c0f3c42-1bf7-41d8-b38c-e9ff385310a2", new DateTime(2024, 8, 31, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(8688), "Brad.Conroy@hotmail.com", "Brad", "Conroy", "BRAD.CONROY@HOTMAIL.COM", "BRAD.CONROY50", "AQAAAAIAAYagAAAAEMfzEqn7FmHSrFLmZuDR/P4gG8cnMj0zWSdUpWvNLYZpR+NEN+2VA6J6yU7kF2NDNg==", "639-496-0090", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/813.jpg", "Brad.Conroy50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "791 Lehner Park, Diannachester, Guernsey", "ad593e28-e21c-48f9-bdd7-bc061eb9c690", new DateTime(2024, 9, 23, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(8973), "Darrel71@yahoo.com", "Darrel", "Senger", "DARREL71@YAHOO.COM", "DARREL.SENGER92", "AQAAAAIAAYagAAAAEKCqCdJVInQJO9hKXqCEs5eUuyzsFX4l1clLtKoljsaICaqyCdz2xccJvmxVL2gzAQ==", "710-228-8251", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1038.jpg", "Darrel.Senger92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "72279 Turner Groves, North Elza, Lithuania", "0aeb531c-b048-4e28-833e-cff878ee985c", new DateTime(2024, 2, 12, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(9253), "Guido39@yahoo.com", "Guido", "Towne", "GUIDO39@YAHOO.COM", "GUIDO.TOWNE23", "AQAAAAIAAYagAAAAEDZSQjQd1IRSC9/MQlRSurdBerIVOM8LXEQxPPiSe6Q1hLisBe+EOccWtUEAki0K/A==", "852-754-3620", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1169.jpg", "Guido.Towne23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "454 Hudson Trafficway, South Clairport, El Salvador", "1298409a-fc60-410d-a80a-09edaf93c309", new DateTime(2024, 7, 7, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(9594), "Elmore_Streich@yahoo.com", "Elmore", "Streich", "ELMORE_STREICH@YAHOO.COM", "ELMORE3", "AQAAAAIAAYagAAAAEEnrxJ8wfwwWSMJ6l72sbpcEutyorRDsgjFtlVuKGmqehFga17d0kOQ0ncZFcfm//Q==", "933-003-3843", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/154.jpg", "Elmore3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "68874 Noelia Lights, West Emilio, Jordan", "68b79f9a-978c-41c8-a9c7-e421fa9335bc", new DateTime(2024, 9, 14, 3, 33, 58, 616, DateTimeKind.Utc).AddTicks(9880), "Cydney_Breitenberg52@yahoo.com", "Cydney", "Breitenberg", "CYDNEY_BREITENBERG52@YAHOO.COM", "CYDNEY.BREITENBERG", "AQAAAAIAAYagAAAAEP72sIVaZaSbM4TJjMYmUEf64+lIsm1F89C0f6pWQhOQIiz9wOm6t1kscbap60QFYA==", "494-794-2296", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/326.jpg", "Cydney.Breitenberg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "676 Ray Turnpike, South Chayafort, British Indian Ocean Territory (Chagos Archipelago)", "53b7305c-c7c3-44ff-a564-0b0378560413", new DateTime(2024, 4, 13, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(205), "Aileen_Rippin@gmail.com", "Aileen", "Rippin", "AILEEN_RIPPIN@GMAIL.COM", "AILEEN_RIPPIN", "AQAAAAIAAYagAAAAEPa5Bdg/zhWgvrG4ZfSdQtEeayXogpy1jq3vzi9fNVzVFbve0CNT6G9+PckN7rvM9A==", "267-106-6925", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/717.jpg", "Aileen_Rippin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7497 Crist Dale, South Ethelborough, Portugal", "dccee221-a779-4e83-a279-7799ae581097", new DateTime(2024, 11, 1, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(486), "Alexie.Gulgowski@hotmail.com", "Alexie", "Gulgowski", "ALEXIE.GULGOWSKI@HOTMAIL.COM", "ALEXIE.GULGOWSKI18", "AQAAAAIAAYagAAAAECcB+TxqQ+feYV/U1EDEci09K6k3bb2xCebRNVmFBkh+Rbp7RrOu6Q70LPHIXMn+zw==", "284-860-1180", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1011.jpg", "Alexie.Gulgowski18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "158 Douglas Lodge, Dibbertbury, Monaco", "05510e1b-df61-4500-8e09-f00862a854f6", new DateTime(2024, 8, 11, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(776), "Greyson.Tremblay@yahoo.com", "Greyson", "Tremblay", "GREYSON.TREMBLAY@YAHOO.COM", "GREYSON_TREMBLAY65", "AQAAAAIAAYagAAAAELS+wB9ssD6jYGYsqfPczZT0SAfoLZfvCUDI6uwmbX4WUCZfhiv8/Kks5Afxus5XyA==", "051-811-6049", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/481.jpg", "Greyson_Tremblay65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "114 Hilll Junction, New Edmund, Egypt", "f9f9a5b0-ab8f-4338-9979-92b85d5117f2", new DateTime(2024, 7, 22, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(1057), "Kirk70@gmail.com", "Kirk", "Donnelly", "KIRK70@GMAIL.COM", "KIRK49", "AQAAAAIAAYagAAAAENovjj1FNqvMuHBbNVZiJi4jiOcL2+JMD7rA1VtUU2e2OyxsKqITuMTZFTyIJYMN/g==", "859-222-4257", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/879.jpg", "Kirk49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6122 Sasha Rapid, West Alexandrebury, Denmark", "70857432-f4e3-49c9-909a-3f14b4aa170f", new DateTime(2024, 3, 10, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(1389), "Brendon.Smitham@yahoo.com", "Brendon", "Smitham", "BRENDON.SMITHAM@YAHOO.COM", "BRENDON.SMITHAM5", "AQAAAAIAAYagAAAAEBe6u55bqNmKOOHi9SkzWWAsk+k55dYv9dbMs8MuGggOg30eD+PTqNSphoKRBzCFAA==", "766-926-3231", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/142.jpg", "Brendon.Smitham5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9879 Durgan Cape, Adeliashire, Angola", "908fb149-db9b-4e6e-b235-39aff0b09a62", new DateTime(2024, 9, 7, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(1636), "Shemar_Maggio@hotmail.com", "Shemar", "Maggio", "SHEMAR_MAGGIO@HOTMAIL.COM", "SHEMAR_MAGGIO", "AQAAAAIAAYagAAAAEGrqWZXhQDg/q+QlwnTF7JJpqU/NRhMdixoayhCF1uVjxvfdYDFixvBxNaqt+GxYTQ==", "233-421-4179", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/931.jpg", "Shemar_Maggio" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1885 Dooley Extension, Jazmynside, Iran", "3acbbc27-97dc-4f18-9d18-2381518a2dee", new DateTime(2024, 3, 21, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(1926), "Ilene_Hickle@hotmail.com", "Ilene", "Hickle", "ILENE_HICKLE@HOTMAIL.COM", "ILENE_HICKLE52", "AQAAAAIAAYagAAAAEBfNeCSYwd5mZ9CJ56gAlr1hgbb2jbkWBBn0h7TlrBV/uCLkUmrt20Iy3Z+Goh3m1Q==", "045-155-1093", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/442.jpg", "Ilene_Hickle52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "802 Imogene Locks, Alexanetown, Saint Barthelemy", "57f1687f-f3d1-46f8-bd0b-56b44ce1629f", new DateTime(2024, 10, 18, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(2179), "Hilario.Emard19@gmail.com", "Hilario", "Emard", "HILARIO.EMARD19@GMAIL.COM", "HILARIO.EMARD", "AQAAAAIAAYagAAAAEHPc/WolZQf4bDeRDWHhX7PxPkgarZELEO3ehpsyUqdu8FPH4ra1eh6YvYMDPZjgjw==", "408-558-0152", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/10.jpg", "Hilario.Emard" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "427 Beier Shoals, Kiehnshire, Slovakia (Slovak Republic)", "873ad3aa-0503-4343-8c29-3042b1e001bb", new DateTime(2024, 8, 27, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(2472), "Gideon.Roob59@yahoo.com", "Gideon", "Roob", "GIDEON.ROOB59@YAHOO.COM", "GIDEON.ROOB98", "AQAAAAIAAYagAAAAEHvRG32VnZnoHMHjsUM+HjYGEJJkZm9YFfYG36bYYKYsZD1LZz+ZsLVFVff69J7osw==", "910-535-1235", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/102.jpg", "Gideon.Roob98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7958 Verona Ferry, West Emmett, Barbados", "b832dd04-9b26-495b-8d34-c56f71d73d2f", new DateTime(2024, 3, 26, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(2750), "Estevan95@yahoo.com", "Estevan", "Gaylord", "ESTEVAN95@YAHOO.COM", "ESTEVAN_GAYLORD59", "AQAAAAIAAYagAAAAENT4Uq1BRvQffkFprONuxq+c9hkQojUQkwHGEhmH3B7lYk4s6LCwB0BVY2nuM7XmOA==", "344-961-5680", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/880.jpg", "Estevan_Gaylord59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2477 Towne Hills, Torphyborough, Sweden", "0578668e-1f12-40af-9c70-3f2e43a8e778", new DateTime(2024, 8, 15, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(3035), "Erling4@hotmail.com", "Erling", "Nader", "ERLING4@HOTMAIL.COM", "ERLING.NADER", "AQAAAAIAAYagAAAAEL47vNTWXo7eykHYLz+d25VvAntypn23jHC5KMo0ily9HVHYIeTXGV9lt4GBXEz7JA==", "531-729-6053", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/191.jpg", "Erling.Nader" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5926 Antonina Summit, Emmettside, Kyrgyz Republic", "b1356774-b7e3-4d3a-a8f0-0501538a66d0", new DateTime(2024, 8, 24, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(3300), "Stephan49@hotmail.com", "Stephan", "Tillman", "STEPHAN49@HOTMAIL.COM", "STEPHAN.TILLMAN47", "AQAAAAIAAYagAAAAEER7FS1tl1fA5OXdyfjQ9+0Tlbupgbnky6RawQqwispPEkD+D1/WxynrKG5z6mQphQ==", "855-636-0610", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1219.jpg", "Stephan.Tillman47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "99884 Rath Fort, South Nigelborough, Saint Barthelemy", "6222f3bc-9690-46ec-bed4-886eadc972a8", new DateTime(2024, 1, 29, 3, 33, 58, 617, DateTimeKind.Utc).AddTicks(3609), "Katlynn_Wyman@gmail.com", "Katlynn", "Wyman", "KATLYNN_WYMAN@GMAIL.COM", "KATLYNN_WYMAN42", "AQAAAAIAAYagAAAAEFKR/KGNFGrUsibGTKfjqpYopTe9uLgKdGpAY7877GJkf6U/kkf9y6sCR66oOd2SXg==", "469-024-4439", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1204.jpg", "Katlynn_Wyman42" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 34, 0, 831, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 3, 33, 58, 282, DateTimeKind.Utc).AddTicks(3895));
        }
    }
}
