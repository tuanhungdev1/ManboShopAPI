using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class addeavmodelfroproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributeValues_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAttributeValues_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValues_AttributeId",
                table: "ProductAttributeValues",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValues_ProductId",
                table: "ProductAttributeValues",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAttributeValues");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "915 Norval Roads, Justynstad, Sierra Leone", "e55113b0-5d42-4e6f-b969-db47a162eb5d", new DateTime(2024, 11, 12, 10, 23, 26, 569, DateTimeKind.Utc).AddTicks(7954), "Jamar40@gmail.com", "Jamar", "Schimmel", "JAMAR40@GMAIL.COM", "JAMAR_SCHIMMEL", "AQAAAAIAAYagAAAAEBm7zoc3p2B45DvHjg5cAZ1h8CBQSzf31zxkoyey33gL+xH6/hM26tbAuBrb5kRP4Q==", "940-119-7338", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/152.jpg", "Jamar_Schimmel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7516 Maye Roads, New Katrinaton, Italy", "eaba8c37-aec1-41b8-9852-c048825aed39", new DateTime(2024, 6, 4, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(351), "Christelle_Walsh90@hotmail.com", "Christelle", "Walsh", "CHRISTELLE_WALSH90@HOTMAIL.COM", "CHRISTELLE58", "AQAAAAIAAYagAAAAEEUw6KCscw8QQrfcVTk7SWtwr4YfsHkGipjY4RCupCSVvDZQI/qSePT9RCmh78oA8w==", "756-107-3262", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/704.jpg", "Christelle58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1352 Granville Meadows, New Lesly, Solomon Islands", "285da001-348a-4a40-a811-e2a6ca4e84c4", new DateTime(2024, 12, 12, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(798), "Shakira_Ondricka@gmail.com", "Shakira", "Ondricka", "SHAKIRA_ONDRICKA@GMAIL.COM", "SHAKIRA.ONDRICKA87", "AQAAAAIAAYagAAAAEJEo5k+sLVwNHcdvxvivI81zcJpH2HMAl12orGBxjGfRZtuUhUkFjkPx8+KnUBw/Lg==", "167-611-5190", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/327.jpg", "Shakira.Ondricka87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7265 Bogan Burg, West Krystinafort, Croatia", "80cda68c-d16b-4360-8460-035cfe48d24b", new DateTime(2024, 12, 10, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(1050), "Trinity13@gmail.com", "Trinity", "Fadel", "TRINITY13@GMAIL.COM", "TRINITY7", "AQAAAAIAAYagAAAAEI8+bkmDMudDd4F9mj6R0gDBa2W0s88ubCOHAvD8Sofp5rI7VQ7Pdfh7LTXk/T2J1A==", "569-959-0834", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1225.jpg", "Trinity7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "830 Rutherford Track, West Dominic, Netherlands Antilles", "fde0730a-e5f8-4494-84ca-c0f0b15ee68a", new DateTime(2024, 3, 27, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(1322), "Lucile.Goodwin@yahoo.com", "Lucile", "Goodwin", "LUCILE.GOODWIN@YAHOO.COM", "LUCILE_GOODWIN60", "AQAAAAIAAYagAAAAEGrvkAQZtr8BkfEOERObjABCQIMsHjW51Q0ZN5ZG970N3LyC/xGrt8VMn/r8ExabHg==", "127-341-0469", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/183.jpg", "Lucile_Goodwin60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3925 Hegmann Drives, Moenmouth, Central African Republic", "b203e8dc-487c-4c26-823b-cd0ebf2066d0", new DateTime(2024, 8, 23, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(1556), "Elisha.Romaguera@yahoo.com", "Elisha", "Romaguera", "ELISHA.ROMAGUERA@YAHOO.COM", "ELISHA_ROMAGUERA67", "AQAAAAIAAYagAAAAEN1UpCtlXDJmqiEMD0pBXjxp5MvLIiZD5V2WEy7GBMZxO067vg/JoG7AunQKF6+Uyw==", "733-696-4155", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/70.jpg", "Elisha_Romaguera67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5537 Kshlerin Vista, South Avery, Venezuela", "d2c321ef-abca-4181-994d-d2fd98442d45", new DateTime(2024, 4, 22, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(1813), "Lula_Gorczany74@hotmail.com", "Lula", "Gorczany", "LULA_GORCZANY74@HOTMAIL.COM", "LULA49", "AQAAAAIAAYagAAAAEPS1yGMQDCs4ffYa/2HWxN7HCQbgwtusl+ShyLDBWI2p3FdfipCCGVJZYD5+Q1S6Kg==", "806-494-7965", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/796.jpg", "Lula49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "075 Will Port, Ebbastad, Monaco", "8962f4d8-d1a5-4508-8551-5a45857a2c56", new DateTime(2024, 12, 24, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(2022), "Ciara_Farrell81@hotmail.com", "Ciara", "Farrell", "CIARA_FARRELL81@HOTMAIL.COM", "CIARA.FARRELL", "AQAAAAIAAYagAAAAEEKp/C5k23kLwyG0AxSEwttwlOilsflFx//tuYCglqcnuJTDkdjRxnx4My4aKQ7WMg==", "810-525-2260", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1118.jpg", "Ciara.Farrell" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3914 Lesley Groves, Hudsonville, Malawi", "d27f76bc-6a23-46ad-8aa7-620b37860cf1", new DateTime(2024, 8, 30, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(2288), "Juanita.Abshire@yahoo.com", "Juanita", "Abshire", "JUANITA.ABSHIRE@YAHOO.COM", "JUANITA_ABSHIRE64", "AQAAAAIAAYagAAAAEKGGh3KdVmlQ+LNtvrneEWxlCiis1ECYhx9r9UaoqouDDltGDYqrWp2h6L21NXhsFw==", "818-457-7857", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/452.jpg", "Juanita_Abshire64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8698 Kunde Orchard, Fatimamouth, Heard Island and McDonald Islands", "7535abb7-f4e3-4f79-8d3f-b603459f16b4", new DateTime(2024, 10, 24, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(2487), "Reyes.Raynor@hotmail.com", "Reyes", "Raynor", "REYES.RAYNOR@HOTMAIL.COM", "REYES.RAYNOR", "AQAAAAIAAYagAAAAEJ1INrOuB87JWQrOy/7I4dlVX3DTx/Q0VLSACsepveskyi+slatD6ywnGT+oMpkSkg==", "997-903-4124", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/556.jpg", "Reyes.Raynor" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1638 Renner Coves, Maggioland, San Marino", "e1385698-2e7e-48b9-97cf-a02cb7140011", new DateTime(2024, 7, 1, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(2734), "Kendall.Schuppe@hotmail.com", "Kendall", "Schuppe", "KENDALL.SCHUPPE@HOTMAIL.COM", "KENDALL_SCHUPPE88", "AQAAAAIAAYagAAAAEAf7MLbhzPl+AxnBbo1TBd+YW07F+GTKvzI7k8grtkm2wFcXY0Jk5Kc5/Uc/h7ETQA==", "045-667-3044", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/804.jpg", "Kendall_Schuppe88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2809 Sherwood Radial, Treutelbury, Algeria", "1584b6bf-7508-4a22-a963-7a558e9eb316", new DateTime(2024, 2, 17, 10, 23, 26, 571, DateTimeKind.Utc).AddTicks(2950), "Remington67@hotmail.com", "Remington", "Baumbach", "REMINGTON67@HOTMAIL.COM", "REMINGTON.BAUMBACH61", "AQAAAAIAAYagAAAAEK5DebgtMqQxMisAQq65Js9D14zyss7pxbYuFWiuTpE5CKm+M/ExwrFmDHmjAJ6JCA==", "400-427-4065", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/709.jpg", "Remington.Baumbach61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1274 Conn Radial, South Kaia, Denmark", "8e509491-fd8a-494c-8b42-fa301acca984", new DateTime(2024, 11, 25, 10, 23, 26, 575, DateTimeKind.Utc).AddTicks(9221), "Sasha32@yahoo.com", "Sasha", "O'Hara", "SASHA32@YAHOO.COM", "SASHA.OHARA", "AQAAAAIAAYagAAAAEDOP3g/jou4WWp8abO61cAwu9KlyZLDTw+DRDtl75dezBRFXVFBVJTgvOmBMbKdBdw==", "508-064-4963", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/418.jpg", "Sasha.OHara" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6955 Wava Trail, Lake Jessycaburgh, Antarctica (the territory South of 60 deg S)", "81f97553-5efa-4751-a141-efc69ebd3814", new DateTime(2024, 1, 17, 10, 23, 26, 575, DateTimeKind.Utc).AddTicks(9928), "Orville_Turner@hotmail.com", "Orville", "Turner", "ORVILLE_TURNER@HOTMAIL.COM", "ORVILLE_TURNER", "AQAAAAIAAYagAAAAECDzFtVaqPoEj0MkmQ/yrucWsrbezT7JghdxtLgJcuKwFz9/rEw2IkSCZAUGOoK7Gg==", "866-356-1435", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/923.jpg", "Orville_Turner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4447 Valentine Fall, Kerlukemouth, Chile", "4f202fc2-c152-4af7-ba23-75d69ae46226", new DateTime(2024, 3, 7, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(371), "Wava17@yahoo.com", "Wava", "Feest", "WAVA17@YAHOO.COM", "WAVA.FEEST", "AQAAAAIAAYagAAAAEJvCZiokMWiZHZl4loFB4wuzlbyerrEalYEg/F/+OHoIYwYJ6bxvH2jOlHNpPHsdgA==", "122-970-6246", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/108.jpg", "Wava.Feest" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6516 Conor Turnpike, Boscoton, Zimbabwe", "488d95ec-16ef-4d73-ac37-df8431d7bce6", new DateTime(2024, 2, 18, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(711), "Dannie_Nienow@yahoo.com", "Dannie", "Nienow", "DANNIE_NIENOW@YAHOO.COM", "DANNIE_NIENOW71", "AQAAAAIAAYagAAAAED7TUcb+xqRDg22lB75wb+mckMyVtt3foUkVvie8waGmhIvPTBUoyKu5Gkd41JWa2A==", "184-473-8782", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1138.jpg", "Dannie_Nienow71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "58726 Klocko Squares, New Virginiaton, Botswana", "722ec7c8-4cf1-42ab-8cd8-7e041b14a18e", new DateTime(2024, 4, 22, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(1189), "Hilma_Schmidt@hotmail.com", "Hilma", "Schmidt", "HILMA_SCHMIDT@HOTMAIL.COM", "HILMA_SCHMIDT", "AQAAAAIAAYagAAAAEEGsedk/WKbE1B4hR83a2dlgwYmA4/ml+QJB2cMlMkrzSzl0Ka3yJEvMdRmEMQWU2Q==", "788-902-3848", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/256.jpg", "Hilma_Schmidt" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "29330 Morgan Bypass, Paucekmouth, Antigua and Barbuda", "31aae358-2140-4175-8613-c3ede6b25d0f", new DateTime(2024, 6, 28, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(1592), "Bridgette14@yahoo.com", "Bridgette", "Hahn", "BRIDGETTE14@YAHOO.COM", "BRIDGETTE.HAHN39", "AQAAAAIAAYagAAAAEPUiN8o5oKm7LOQjJOK2LZGEdwWU7CQ4GRMgPGRsUWxb37DxI+VDYgLarW3kYSE4Zg==", "520-496-8194", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/398.jpg", "Bridgette.Hahn39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1177 Tony Forges, Bruceside, Luxembourg", "a14cbf9f-ab80-41c8-b092-3e4bb061a6a8", new DateTime(2024, 5, 4, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(2020), "Clemens81@gmail.com", "Clemens", "Medhurst", "CLEMENS81@GMAIL.COM", "CLEMENS.MEDHURST", "AQAAAAIAAYagAAAAEOaQY/Pg2B2LTbB6joT6qxp/AEOt6d32hjVmDL78a1xowm97y76DAkLcnT8MA85oLw==", "517-672-5566", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/210.jpg", "Clemens.Medhurst" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6793 Kirlin Junctions, Abshireview, Greenland", "377b1133-3f17-46c6-aaeb-21d33cc5dc62", new DateTime(2024, 1, 6, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(2401), "Mayra_Renner69@hotmail.com", "Mayra", "Renner", "MAYRA_RENNER69@HOTMAIL.COM", "MAYRA_RENNER54", "AQAAAAIAAYagAAAAEIX0IGfHO+P8vacGKBOQHnp8MPM+mwDDfuuGcE0+Asbb0ht5QhqQfTKBkQFAmLy7bQ==", "430-817-3935", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/834.jpg", "Mayra_Renner54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2181 Emie Key, West Donatobury, Cape Verde", "2add071a-eabf-4127-aa23-d14bcacc243b", new DateTime(2024, 7, 2, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(2742), "Everette2@yahoo.com", "Everette", "Hansen", "EVERETTE2@YAHOO.COM", "EVERETTE_HANSEN", "AQAAAAIAAYagAAAAEOjV8keGmEy9cgA8YGmb274T3yd/T3A9/kvVpAcWLF/TK+vuvTengKeo78Vojk6CCw==", "020-054-8583", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/613.jpg", "Everette_Hansen" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0409 Nova Curve, New Madysonchester, Cambodia", "77a5ee7f-6153-45e8-8e81-e961e8465ba5", new DateTime(2024, 6, 5, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(3152), "Noe.Toy@gmail.com", "Noe", "Toy", "NOE.TOY@GMAIL.COM", "NOE_TOY83", "AQAAAAIAAYagAAAAEEyuolzADRmiavbxFkGe7/xiU+bov22H70QCBL7Aq664Pn/rH/xHvPjeLg5FhcM5WQ==", "825-036-8160", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/695.jpg", "Noe_Toy83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "44765 Schaefer Ridges, West Marianne, Wallis and Futuna", "853f3c57-c94e-42f7-a5e6-023b3d03a6d9", new DateTime(2024, 7, 12, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(3516), "Joshua_Frami@hotmail.com", "Joshua", "Frami", "JOSHUA_FRAMI@HOTMAIL.COM", "JOSHUA41", "AQAAAAIAAYagAAAAEDlqHn/7XNDHCpLrkPYX71YldYIhtdRF7UL0ozOmogzx7ns7kR72A7H0WptJanzpLA==", "736-755-1856", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/881.jpg", "Joshua41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "565 Veum Trafficway, West Johnpaulborough, Suriname", "9be5880e-9aa7-48b8-8f88-52cfb646e912", new DateTime(2024, 6, 12, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(3998), "Karson_Considine81@yahoo.com", "Karson", "Considine", "KARSON_CONSIDINE81@YAHOO.COM", "KARSON_CONSIDINE", "AQAAAAIAAYagAAAAEJETRpdIzRyiNj7nSYliW1Qcu0URQ9ao0Ly/VEXLEGTlIZchZFebtANJRNQLVfS48A==", "473-838-7757", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/599.jpg", "Karson_Considine" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0825 Alta Mountains, North Orlandoport, Sierra Leone", "b44bff68-8497-4e81-a9ce-dca99000a243", new DateTime(2024, 8, 13, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(4349), "Jovany_Wiza54@yahoo.com", "Jovany", "Wiza", "JOVANY_WIZA54@YAHOO.COM", "JOVANY_WIZA", "AQAAAAIAAYagAAAAEOk8kIJsfIVgrXIhBmO1Sjh+ii/wi9W2ovRw0OUKNq/EDJ2xxlT1E1IaoE3ZBuzBng==", "477-732-4267", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/25.jpg", "Jovany_Wiza" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8321 Princess Prairie, Kutchmouth, Morocco", "6f5d099b-ba70-4866-8e45-3f8ae9941a56", new DateTime(2024, 11, 9, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(4804), "Monserrat_Cronin@hotmail.com", "Monserrat", "Cronin", "MONSERRAT_CRONIN@HOTMAIL.COM", "MONSERRAT.CRONIN", "AQAAAAIAAYagAAAAEG75B02IqlBuMVXoDIaJpJ0yG1f75mwQZu9LnB9R5D8XVGulzs2FRQif8965wxr5Rw==", "913-833-8927", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/596.jpg", "Monserrat.Cronin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0679 Hirthe Wells, Mariambury, Solomon Islands", "e699644c-943c-4961-9615-436e2f4fe06c", new DateTime(2024, 5, 17, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(5132), "Twila.Gerhold83@gmail.com", "Twila", "Gerhold", "TWILA.GERHOLD83@GMAIL.COM", "TWILA_GERHOLD69", "AQAAAAIAAYagAAAAEPv4poE4C0+M7bZLd4RposEWXqmspA3ACz/dn1jRtBqQ0VJcUED4bfFmI0difRNGvg==", "828-445-5332", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/738.jpg", "Twila_Gerhold69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "378 Lemke Corners, Port Carolemouth, Russian Federation", "c8dc9ae6-4db1-4edb-aed8-feba2cf9fa09", new DateTime(2024, 2, 15, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(5507), "Jesse51@hotmail.com", "Jesse", "Torp", "JESSE51@HOTMAIL.COM", "JESSE_TORP25", "AQAAAAIAAYagAAAAEKBeqk1h8WbAXyZa3d6h7zYJipvFsYAVJMvLA3EPVYu0HIaDILLE4sJ1vHsln+go4A==", "639-500-5739", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/74.jpg", "Jesse_Torp25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7283 Bartoletti Neck, Prohaskaview, Papua New Guinea", "84bc906a-5140-4bf9-a100-27f6c2c5b13a", new DateTime(2024, 5, 23, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(5951), "Walton.Carroll54@yahoo.com", "Walton", "Carroll", "WALTON.CARROLL54@YAHOO.COM", "WALTON0", "AQAAAAIAAYagAAAAEIIm/x5R8YgOLVPDMzQDCu5wGgZKCJh5s+tWepDAtVzln6eelGi9ZseZYPeoAtxA7g==", "668-556-3148", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/65.jpg", "Walton0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "46524 Robin Rapid, Larsonhaven, Turkmenistan", "982c9e43-318f-4fc5-8c81-31a0a20f9efa", new DateTime(2024, 12, 19, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(6421), "Pedro.Rempel@gmail.com", "Pedro", "Rempel", "PEDRO.REMPEL@GMAIL.COM", "PEDRO.REMPEL", "AQAAAAIAAYagAAAAELg7tGW1p8MiuP8qZ41FJdTLo64dedrxgYXrSZIcHZCIcU8HkKRrIDcMdQBkP1kU+g==", "187-955-1905", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/440.jpg", "Pedro.Rempel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "93454 Antonia Lock, Cheyenneland, Tajikistan", "4a4b71cf-8b8a-4aec-98ac-981cc34550b2", new DateTime(2023, 12, 31, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(6781), "Christian_Rosenbaum24@hotmail.com", "Christian", "Rosenbaum", "CHRISTIAN_ROSENBAUM24@HOTMAIL.COM", "CHRISTIAN.ROSENBAUM", "AQAAAAIAAYagAAAAEL0+7FimC6ItTxFy7uvltr6e8PiY5q5f96/70iRIDoyMq4fXqjZqQP1GWUdM9y3qiQ==", "429-925-0484", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/882.jpg", "Christian.Rosenbaum" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "257 Bianka Shoal, New Sarai, Rwanda", "ad2b26d7-cf13-4343-8674-cfa019e68b81", new DateTime(2024, 1, 27, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(7182), "Alexandro13@gmail.com", "Alexandro", "Thiel", "ALEXANDRO13@GMAIL.COM", "ALEXANDRO47", "AQAAAAIAAYagAAAAEK0fWe8p03RQS3B4CghMIARo7cQbrHOUnDU1uh1FHa13JeOtFYFnajnwIIUHYc0ljg==", "148-139-4768", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/10.jpg", "Alexandro47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4950 Jay Courts, West Hermann, Haiti", "998dceeb-e706-4f41-b204-139b14f7c0e8", new DateTime(2024, 4, 12, 10, 23, 26, 576, DateTimeKind.Utc).AddTicks(8405), "Jayde_Weimann10@yahoo.com", "Jayde", "Weimann", "JAYDE_WEIMANN10@YAHOO.COM", "JAYDE.WEIMANN", "AQAAAAIAAYagAAAAEFT9IFpQeW7w2ZSapgmT4O5YiB2iczHcUf7NYcb7iKIPZ3DlaUxzdGikNGc3tnVt0Q==", "698-232-7956", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/104.jpg", "Jayde.Weimann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "839 Kaylie Drives, West Damionville, Vietnam", "483662f6-957f-4c75-abc9-ac0cab319b28", new DateTime(2024, 5, 27, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(975), "Camren.Breitenberg88@gmail.com", "Camren", "Breitenberg", "CAMREN.BREITENBERG88@GMAIL.COM", "CAMREN.BREITENBERG65", "AQAAAAIAAYagAAAAEFuGAGK5nbY3Vrc52co1UQVmHa3zzRLyr2TfbGFDP/9kYENPHv+yPM0nyNfo4irlfA==", "355-276-3566", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1131.jpg", "Camren.Breitenberg65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "56319 Borer Station, Faheyhaven, Reunion", "d3320232-1348-412c-9822-d5178ada9052", new DateTime(2024, 3, 31, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(3562), "Karson.Mitchell@yahoo.com", "Karson", "Mitchell", "KARSON.MITCHELL@YAHOO.COM", "KARSON_MITCHELL34", "AQAAAAIAAYagAAAAEPXt1ZteLI9NLeQ9snSIluJzdJMF8dh+fAOoO3jE9mleTIduOi7z32S2Uofo9YZODA==", "083-903-6938", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/140.jpg", "Karson_Mitchell34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "70537 Amparo Shores, Bartonbury, Guadeloupe", "59efc1c4-e2bc-41aa-86c3-6c893d4793a0", new DateTime(2024, 8, 30, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(4578), "Kenya24@gmail.com", "Kenya", "Fritsch", "KENYA24@GMAIL.COM", "KENYA_FRITSCH", "AQAAAAIAAYagAAAAEGS08Fgb3nxaUvlo4YQdLCfA739d7WrB4h105EPdWUI0vg1CSuxBCmIlz+RedXAC+g==", "033-438-0902", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/909.jpg", "Kenya_Fritsch" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "10268 Alva Ridge, Creolachester, Saint Kitts and Nevis", "3ea4eb69-ca8c-46aa-8d69-87b8fc94d76b", new DateTime(2024, 6, 8, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(4816), "Dayne.Kautzer21@yahoo.com", "Dayne", "Kautzer", "DAYNE.KAUTZER21@YAHOO.COM", "DAYNE9", "AQAAAAIAAYagAAAAEFVKe/S+P5C7nEivwvwGqsBIxi6mPuqbPZ6saExQSIuAPOyaCOq49tYprt3bgQKz1Q==", "702-593-5064", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1047.jpg", "Dayne9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "750 Lueilwitz Cliff, Kayleeside, Seychelles", "dcb8b053-7aa3-4ff2-89c0-e3eca1bb2bda", new DateTime(2024, 12, 21, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(5064), "Gage50@hotmail.com", "Gage", "Rutherford", "GAGE50@HOTMAIL.COM", "GAGE_RUTHERFORD", "AQAAAAIAAYagAAAAEP9NA/DWYqdyvl8nhBC4GqupNO6bKme/Om2SPiHriEF+7XVj0urTHKU8ZDCnooTuUQ==", "884-618-3697", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/315.jpg", "Gage_Rutherford" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "095 Olson Neck, Ryanland, Tajikistan", "fc9a8f29-ea77-44cc-90f5-e3cf2c81ed64", new DateTime(2024, 12, 1, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(5277), "Lilly_Lowe85@gmail.com", "Lilly", "Lowe", "LILLY_LOWE85@GMAIL.COM", "LILLY59", "AQAAAAIAAYagAAAAEJHpJ7965Q/l/KrQEVeHTaubZJOmTd6F2xXsUMEDfJu5XQFkA6L5Boq/tRjFL9ECjg==", "937-663-3131", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1217.jpg", "Lilly59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "586 Kennedi Estates, Bethelland, Tajikistan", "8ce7a922-9bd8-4895-9b5c-e335d9163165", new DateTime(2024, 7, 21, 10, 23, 26, 577, DateTimeKind.Utc).AddTicks(5493), "Melany_Kling@yahoo.com", "Melany", "Kling", "MELANY_KLING@YAHOO.COM", "MELANY18", "AQAAAAIAAYagAAAAEMQteJ7qjzlQaK2OKIhePurRjlK2BFdGXL6ZtvogB2jfpgAoIwdTWppd+gFkHij5ww==", "065-873-0719", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/594.jpg", "Melany18" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 28, 409, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 10, 23, 26, 502, DateTimeKind.Utc).AddTicks(8733));
        }
    }
}
