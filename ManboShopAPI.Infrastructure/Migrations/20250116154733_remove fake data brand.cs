using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class removefakedatabrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40);

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
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "490 Nikolaus Motorway, West Keanufort, Burkina Faso", "d6c2d423-6cf2-4efd-92b1-489211043fab", new DateTime(2024, 12, 7, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(4964), "Luigi.Collins@hotmail.com", "Luigi", "LUIGI.COLLINS@HOTMAIL.COM", "LUIGI_COLLINS", "AQAAAAIAAYagAAAAEJl+bSCivQxuQygacG65/JZk9uYHYruFz3v1+QHxsKM6Hgns8hIhiipFG2xRARteBA==", "071-995-0372", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/695.jpg", "Luigi_Collins" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "089 Eda Inlet, Jenkinsburgh, Cocos (Keeling) Islands", "7940cad3-ffba-43f2-9d76-9f7a3971f517", new DateTime(2024, 6, 7, 15, 47, 30, 864, DateTimeKind.Utc).AddTicks(5163), "Deon_Abernathy87@gmail.com", "Deon", "Abernathy", "DEON_ABERNATHY87@GMAIL.COM", "DEON.ABERNATHY", "AQAAAAIAAYagAAAAEFHd7K1bpuNr6aYu26+O0efyY8c5oPVWXZKCN8m0ekbHs/I4/FYsab9KMYJb2LtB8Q==", "615-127-8372", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/934.jpg", "Deon.Abernathy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "620 Gislason Mountain, Loybury, Guinea", "038a9137-3209-48a4-9eaf-65e35100090a", new DateTime(2024, 2, 14, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(6301), "Kobe28@yahoo.com", "Kobe", "KOBE28@YAHOO.COM", "KOBE.COLLINS", "AQAAAAIAAYagAAAAEBK2tcreEuryqVPYywoZu6ekI8sK+XvrqsSSpKEB6LjHPsUQi2kfZgRGV/lqfaCdEw==", "697-043-2700", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/499.jpg", "Kobe.Collins" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "018 Eldred Locks, Jeffmouth, Guadeloupe", "66d2269e-6821-432a-872d-0c62317e9135", new DateTime(2024, 11, 3, 20, 46, 56, 779, DateTimeKind.Utc).AddTicks(6479), "Nickolas59@yahoo.com", "Nickolas", "Maggio", "NICKOLAS59@YAHOO.COM", "NICKOLAS_MAGGIO39", "AQAAAAIAAYagAAAAEOJVrAoMgHBI4f5oxJ2AE+UGOiud2HKueWHXfOs5FchWgoMpa6uMuYlRGM1lX8Cemw==", "194-106-3371", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/307.jpg", "Nickolas_Maggio39" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(3574), "https://example.com/images/nike.jpg", "Nike", null },
                    { 2, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4065), "https://example.com/images/adidas.jpg", "Adidas", null },
                    { 3, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4068), "https://example.com/images/gucci.jpg", "Gucci", null },
                    { 4, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4071), "https://example.com/images/louis-vuitton.jpg", "Louis Vuitton", null },
                    { 5, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4072), "https://example.com/images/zara.jpg", "Zara", null },
                    { 6, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4076), "https://example.com/images/h&m.jpg", "H&M", null },
                    { 7, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4078), "https://example.com/images/chanel.jpg", "Chanel", null },
                    { 8, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4078), "https://example.com/images/prada.jpg", "Prada", null },
                    { 9, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4079), "https://example.com/images/versace.jpg", "Versace", null },
                    { 10, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4081), "https://example.com/images/burberry.jpg", "Burberry", null },
                    { 11, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4082), "https://example.com/images/dior.jpg", "Dior", null },
                    { 12, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4083), "https://example.com/images/calvin-klein.jpg", "Calvin Klein", null },
                    { 13, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4084), "https://example.com/images/tommy-hilfiger.jpg", "Tommy Hilfiger", null },
                    { 14, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4084), "https://example.com/images/levis.jpg", "Levi's", null },
                    { 15, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4085), "https://example.com/images/uniqlo.jpg", "Uniqlo", null },
                    { 16, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4086), "https://example.com/images/lacoste.jpg", "Lacoste", null },
                    { 17, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4087), "https://example.com/images/the-north-face.jpg", "The North Face", null },
                    { 18, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4089), "https://example.com/images/ralph-lauren.jpg", "Ralph Lauren", null },
                    { 19, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4090), "https://example.com/images/puma.jpg", "Puma", null },
                    { 20, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4091), "https://example.com/images/hugo-boss.jpg", "Hugo Boss", null },
                    { 21, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4092), "https://example.com/images/armani.jpg", "Armani", null },
                    { 22, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4092), "https://example.com/images/balenciaga.jpg", "Balenciaga", null },
                    { 23, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4093), "https://example.com/images/fendi.jpg", "Fendi", null },
                    { 24, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4098), "https://example.com/images/givenchy.jpg", "Givenchy", null },
                    { 25, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4099), "https://example.com/images/hermes.jpg", "Hermès", null },
                    { 26, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4100), "https://example.com/images/salvatore-ferragamo.jpg", "Salvatore Ferragamo", null },
                    { 27, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4101), "https://example.com/images/valentino.jpg", "Valentino", null },
                    { 28, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4104), "https://example.com/images/dolce-gabbana.jpg", "Dolce & Gabbana", null },
                    { 29, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4105), "https://example.com/images/gap.jpg", "Gap", null },
                    { 30, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4108), "https://example.com/images/forever21.jpg", "Forever 21", null },
                    { 31, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4109), "https://example.com/images/new-balance.jpg", "New Balance", null },
                    { 32, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4109), "https://example.com/images/vans.jpg", "Vans", null },
                    { 33, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4110), "https://example.com/images/converse.jpg", "Converse", null },
                    { 34, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4112), "https://example.com/images/under-armour.jpg", "Under Armour", null },
                    { 35, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4113), "https://example.com/images/reebok.jpg", "Reebok", null },
                    { 36, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4114), "https://example.com/images/coach.jpg", "Coach", null },
                    { 37, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4115), "https://example.com/images/kate-spade.jpg", "Kate Spade", null },
                    { 38, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4115), "https://example.com/images/michael-kors.jpg", "Michael Kors", null },
                    { 39, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4116), "https://example.com/images/bally.jpg", "Bally", null },
                    { 40, new DateTime(2025, 1, 14, 20, 46, 58, 580, DateTimeKind.Utc).AddTicks(4117), "https://example.com/images/guess.jpg", "Guess", null }
                });
        }
    }
}
