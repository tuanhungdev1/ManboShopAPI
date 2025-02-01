using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class Fixproductconstrain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "OrderDetails",
                newName: "ProductVariantValueId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductVariantValueId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "CartItems",
                newName: "ProductVariantValueId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                newName: "IX_CartItems_ProductVariantValueId");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_ProductVariantValues_ProductVariantValueId",
                table: "CartItems",
                column: "ProductVariantValueId",
                principalTable: "ProductVariantValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_ProductVariantValues_ProductVariantValueId",
                table: "OrderDetails",
                column: "ProductVariantValueId",
                principalTable: "ProductVariantValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_ProductVariantValues_ProductVariantValueId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Coupons_CouponId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ProductVariantValues_ProductVariantValueId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Coupons_CouponId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ProductVariantValueId",
                table: "OrderDetails",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductVariantValueId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductVariantValueId",
                table: "CartItems",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_ProductVariantValueId",
                table: "CartItems",
                newName: "IX_CartItems_ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Orders",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Coupons_CouponId",
                table: "OrderDetails",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Coupons_CouponId",
                table: "Orders",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
